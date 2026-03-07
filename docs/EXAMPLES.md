# Examples - Laravel Simba

Các ví dụ thực tế khi sử dụng Laravel Simba package.

---

## Mục lục

1. [Basic Examples](#basic-examples)
2. [Intermediate Examples](#intermediate-examples)
3. [Advanced Examples](#advanced-examples)
4. [Real-world Scenarios](#real-world-scenarios)

---

## Basic Examples

### 1. Đọc dữ liệu từ Models

```php
use Diepxuan\Simba\Models\ArDmKh;
use Diepxuan\Simba\Models\InDmVt;

// Lấy tất cả khách hàng
$customers = ArDmKh::all();

// Tìm khách hàng theo mã
$customer = ArDmKh::find('KH001');

// Query với điều kiện
$activeCustomers = ArDmKh::where('ksd', 0)->get();

// Tìm vật tư theo nhóm
$materials = InDmVt::where('ma_nh_vt', 'NVL')->get();
```

### 2. Gọi Stored Procedure cơ bản

```php
use Diepxuan\Simba\StoredProcedures\AsGetSoCt;
use Diepxuan\Simba\StoredProcedures\AsGetSoDuKh;

// Lấy số chứng từ tiếp theo
$stt_rec = AsGetSoCt::call([
    'pMa_Cty' => '001',
    'pMa_Ct'  => 'CA4',
]);

// Lấy số dư khách hàng
$balance = AsGetSoDuKh::call([
    'pMa_Cty' => '001',
    'pMa_kh'  => 'KH001',
    'pTk'     => '131',
    'pNgay'   => '2024-03-31',
]);

echo "Số dư: " . ($balance->first()->Cong_no ?? 0);
```

### 3. Sử dụng với OUTPUT Parameters

```php
use Diepxuan\Simba\StoredProcedures\AsChkUserLogin;

$result = AsChkUserLogin::call([
    'pUserName' => 'admin',
    'pPassword' => 'password123',
    'pRet'      => ['type' => 'INT', 'output' => true],
    'pMessage'  => ['type' => 'NVARCHAR(255)', 'output' => true],
]);

$row = $result->first();
if ($row->Ret === 0) {
    echo "Login successful";
} else {
    echo "Login failed: " . ($row->Message ?? 'Unknown error');
}
```

---

## Intermediate Examples

### 4. Tạo Phiếu Thu hoàn chỉnh

```php
use Illuminate\Support\Facades\DB;
use Diepxuan\Simba\StoredProcedures\AsGetSoCt;
use Diepxuan\Simba\StoredProcedures\AsCAInsPH2;
use Diepxuan\Simba\StoredProcedures\AsCAInsCT2;
use Diepxuan\Simba\StoredProcedures\AsProcessCt;

class ReceiptService
{
    public function createReceipt(array $data): string
    {
        return DB::transaction(function () use ($data) {
            $maCty = '001';
            $maCt = 'CA4'; // Giấy báo nợ
            
            // 1. Get voucher number
            $stt_rec = AsGetSoCt::call([
                'pMa_Cty' => $maCty,
                'pMa_Ct'  => $maCt,
            ]);
            
            // 2. Insert Header
            AsCAInsPH2::call([
                'pMa_cty'    => $maCty,
                'pStt_rec'   => $stt_rec,
                'pMa_ct'     => $maCt,
                'pSo_ct'     => $data['so_ct'],
                'pNgay_ct'   => $data['ngay_ct'],
                'pMa_kh'     => $data['ma_kh'],
                'pPs_no'     => 0,
                'pPs_co'     => $data['so_tien'],
                'pDien_giai' => $data['dien_giai'],
                'pUser'      => $data['user'],
            ]);
            
            // 3. Insert Details
            foreach ($data['details'] as $detail) {
                AsCAInsCT2::call([
                    'pMa_cty'   => $maCty,
                    'pStt_rec'  => $stt_rec,
                    'pTk'       => $detail['tk'],
                    'pPs_no'    => $detail['ps_no'] ?? 0,
                    'pPs_co'    => $detail['ps_co'] ?? 0,
                    'pDien_giai'=> $detail['dien_giai'] ?? null,
                ]);
            }
            
            // 4. Process voucher
            AsProcessCt::call([
                'pMa_cty'  => $maCty,
                'pMa_Ct'   => $maCt,
                'pStt_rec' => $stt_rec,
                'pMode'    => '1',
            ]);
            
            return $stt_rec;
        });
    }
}

// Usage
$service = new ReceiptService();
try {
    $stt_rec = $service->createReceipt([
        'so_ct'      => 'GN001',
        'ngay_ct'    => '2024-03-06',
        'ma_kh'      => 'KH001',
        'so_tien'    => 10000000,
        'dien_giai'  => 'Thanh toan tien hang',
        'user'       => 'admin',
        'details'    => [
            ['tk' => '1121101', 'ps_no' => 10000000, 'dien_giai' => 'Tien mat'],
        ],
    ]);
    echo "Created: $stt_rec";
} catch (\Exception $e) {
    echo "Error: " . $e->getMessage();
}
```

### 5. Tạo Hóa đơn bán hàng

```php
use Illuminate\Support\Facades\DB;
use Diepxuan\Simba\StoredProcedures\AsGetSoCt;
use Diepxuan\Simba\StoredProcedures\AsARInsPH1;
use Diepxuan\Simba\StoredProcedures\AsARInsCT1;
use Diepxuan\Simba\StoredProcedures\AsProcessCt;

class InvoiceService
{
    public function createInvoice(array $data): string
    {
        return DB::transaction(function () use ($data) {
            $maCty = '001';
            $maCt = 'AR1';
            
            // Calculate totals
            $tienHang = collect($data['items'])->sum('tien_hang');
            $tienThue = collect($data['items'])->sum('tien_thue');
            $tongCong = $tienHang + $tienThue;
            
            // Get voucher number
            $stt_rec = AsGetSoCt::call([
                'pMa_Cty' => $maCty,
                'pMa_Ct'  => $maCt,
            ]);
            
            // Insert Header
            AsARInsPH1::call([
                'pMa_cty'    => $maCty,
                'pStt_rec'   => $stt_rec,
                'pMa_ct'     => $maCt,
                'pSo_ct'     => $data['so_hd'],
                'pNgay_ct'   => $data['ngay_hd'],
                'pMa_kh'     => $data['ma_kh'],
                'pPs_no'     => $tongCong,
                'pPs_co'     => 0,
                'pTien_hang' => $tienHang,
                'pTien_thue' => $tienThue,
                'pDien_giai' => $data['dien_giai'],
                'pUser'      => $data['user'],
            ]);
            
            // Insert Details
            foreach ($data['items'] as $item) {
                AsARInsCT1::call([
                    'pMa_cty'    => $maCty,
                    'pStt_rec'   => $stt_rec,
                    'pMa_vt'     => $item['ma_vt'],
                    'pDvt'       => $item['dvt'],
                    'pSo_luong'  => $item['so_luong'],
                    'pDon_gia'   => $item['don_gia'],
                    'pTien_hang' => $item['tien_hang'],
                    'pThue_suat' => $item['thue_suat'],
                    'pTien_thue' => $item['tien_thue'],
                    'pTk'        => '5111',
                    'pDien_giai' => $item['dien_giai'],
                ]);
            }
            
            // Process
            AsProcessCt::call([
                'pMa_cty'  => $maCty,
                'pMa_Ct'   => $maCt,
                'pStt_rec' => $stt_rec,
                'pMode'    => '1',
            ]);
            
            return $stt_rec;
        });
    }
}
```

### 6. Báo cáo tồn kho

```php
use Diepxuan\Simba\Models\InDmKho;
use Diepxuan\Simba\Models\InCt3;
use Diepxuan\Simba\Models\InDmVt;

class InventoryReportService
{
    public function getInventoryReport(string $maKho, string $tuNgay, string $denNgay): array
    {
        $kho = InDmKho::find($maKho);
        
        if (!$kho) {
            throw new \Exception("Kho $maKho not found");
        }
        
        // Get transactions
        $transactions = InCt3::where('ma_kho', $maKho)
            ->whereBetween('ngay_ct', [$tuNgay, $denNgay])
            ->get();
        
        // Group by material
        $inventory = $transactions->groupBy('ma_vt')->map(function ($items) {
            $first = $items->first();
            
            return [
                'ma_vt'     => $first->ma_vt,
                'ten_vt'    => $first->vatTu->ten_vt ?? $first->ma_vt,
                'dvt'       => $first->dvt,
                'sl_nhap'   => $items->sum('sl_nhap'),
                'sl_xuat'   => $items->sum('sl_xuat'),
                'sl_ton'    => $items->sum('sl_nhap') - $items->sum('sl_xuat'),
                'don_gia_bq'=> $items->avg('don_gia') ?? 0,
                'thanh_tien'=> ($items->sum('sl_nhap') - $items->sum('sl_xuat')) * ($items->avg('don_gia') ?? 0),
            ];
        })->values();
        
        return [
            'kho' => [
                'ma_kho' => $kho->ma_kho,
                'ten_kho'=> $kho->ten_kho,
            ],
            'period' => [
                'from' => $tuNgay,
                'to'   => $denNgay,
            ],
            'inventory' => $inventory,
            'summary' => [
                'total_items' => $inventory->count(),
                'total_value' => $inventory->sum('thanh_tien'),
            ],
        ];
    }
}

// Usage
$report = (new InventoryReportService())->getInventoryReport(
    'KHO001',
    '2024-01-01',
    '2024-03-31'
);

return response()->json($report);
```

---

## Advanced Examples

### 7. Service Pattern với Repository

```php
// app/Repositories/Simba/CustomerRepository.php
namespace App\Repositories\Simba;

use Diepxuan\Simba\Models\ArDmKh;
use Diepxuan\Simba\StoredProcedures\AsGetSoDuKh;
use Diepxuan\Simba\StoredProcedures\AsARInsDMKH;
use Diepxuan\Simba\StoredProcedures\AsARUpdDMKH;

class CustomerRepository
{
    public function all(): \Illuminate\Support\Collection
    {
        return ArDmKh::where('ksd', 0)->get();
    }
    
    public function find(string $maKh): ?ArDmKh
    {
        return ArDmKh::find($maKh);
    }
    
    public function getBalance(string $maKh, string $ngay = null): float
    {
        $ngay = $ngay ?? now()->format('Y-m-d');
        
        $result = AsGetSoDuKh::call([
            'pMa_Cty' => '001',
            'pMa_kh'  => $maKh,
            'pTk'     => '131',
            'pNgay'   => $ngay,
        ]);
        
        return (float) ($result->first()->Cong_no ?? 0);
    }
    
    public function create(array $data): bool
    {
        $result = AsARInsDMKH::call([
            'pMa_cty'    => '001',
            'pMa_kh'     => $data['ma_kh'],
            'pTen_kh'    => $data['ten_kh'],
            'pDia_chi'   => $data['dia_chi'] ?? null,
            'pMa_so_thue'=> $data['ma_so_thue'] ?? null,
            'pDien_thoai'=> $data['dien_thoai'] ?? null,
            'pEmail'     => $data['email'] ?? null,
            'pUser'      => $data['user'],
        ]);
        
        return ($result->first()->Ret ?? -1) === 0;
    }
    
    public function update(string $maKh, array $data): bool
    {
        $result = AsARUpdDMKH::call([
            'pMa_cty'    => '001',
            'pMa_kh'     => $maKh,
            'pTen_kh'    => $data['ten_kh'] ?? null,
            'pDia_chi'   => $data['dia_chi'] ?? null,
            'pDien_thoai'=> $data['dien_thoai'] ?? null,
            'pEmail'     => $data['email'] ?? null,
            'pUser'      => $data['user'],
        ]);
        
        return ($result->first()->Ret ?? -1) === 0;
    }
}

// Usage in Controller
class CustomerController extends Controller
{
    public function __construct(
        private CustomerRepository $customerRepo
    ) {}
    
    public function index()
    {
        return $this->customerRepo->all();
    }
    
    public function show(string $maKh)
    {
        $customer = $this->customerRepo->find($maKh);
        $balance = $this->customerRepo->getBalance($maKh);
        
        return response()->json([
            'customer' => $customer,
            'balance'  => $balance,
        ]);
    }
}
```

### 8. Job Queue cho Bulk Operations

```php
// app/Jobs/ProcessBulkInvoice.php
namespace App\Jobs;

use Illuminate\Bus\Queueable;
use Illuminate\Contracts\Queue\ShouldQueue;
use Illuminate\Foundation\Bus\Dispatchable;
use Illuminate\Queue\InteractsWithQueue;
use Illuminate\Queue\SerializesModels;
use Illuminate\Support\Facades\DB;
use Diepxuan\Simba\StoredProcedures\AsGetSoCt;
use Diepxuan\Simba\StoredProcedures\AsARInsPH1;
use Diepxuan\Simba\StoredProcedures\AsARInsCT1;
use Diepxuan\Simba\StoredProcedures\AsProcessCt;

class ProcessBulkInvoice implements ShouldQueue
{
    use Dispatchable, InteractsWithQueue, Queueable, SerializesModels;
    
    public function __construct(
        public array $invoices,
        public string $user
    ) {}
    
    public function handle(): void
    {
        foreach ($this->invoices as $invoice) {
            try {
                DB::transaction(function () use ($invoice) {
                    $maCty = '001';
                    $maCt = 'AR1';
                    
                    $stt_rec = AsGetSoCt::call([
                        'pMa_Cty' => $maCty,
                        'pMa_Ct'  => $maCt,
                    ]);
                    
                    AsARInsPH1::call([
                        'pMa_cty'    => $maCty,
                        'pStt_rec'   => $stt_rec,
                        'pMa_ct'     => $maCt,
                        'pSo_ct'     => $invoice['so_hd'],
                        'pNgay_ct'   => $invoice['ngay_hd'],
                        'pMa_kh'     => $invoice['ma_kh'],
                        'pPs_no'     => $invoice['tong_cong'],
                        'pPs_co'     => 0,
                        'pTien_hang' => $invoice['tien_hang'],
                        'pTien_thue' => $invoice['tien_thue'],
                        'pDien_giai' => $invoice['dien_giai'],
                        'pUser'      => $this->user,
                    ]);
                    
                    foreach ($invoice['items'] as $item) {
                        AsARInsCT1::call([
                            'pMa_cty'    => $maCty,
                            'pStt_rec'   => $stt_rec,
                            'pMa_vt'     => $item['ma_vt'],
                            'pSo_luong'  => $item['so_luong'],
                            'pDon_gia'   => $item['don_gia'],
                            'pTien_hang' => $item['tien_hang'],
                            'pThue_suat' => $item['thue_suat'],
                            'pTien_thue' => $item['tien_thue'],
                            'pTk'        => '5111',
                        ]);
                    }
                    
                    AsProcessCt::call([
                        'pMa_cty'  => $maCty,
                        'pMa_Ct'   => $maCt,
                        'pStt_rec' => $stt_rec,
                        'pMode'    => '1',
                    ]);
                });
            } catch (\Exception $e) {
                Log::error("Failed to process invoice {$invoice['so_hd']}: " . $e->getMessage());
                throw $e; // Re-throw to fail job
            }
        }
    }
}

// Usage
ProcessBulkInvoice::dispatch($invoices, 'admin')->onQueue('simba');
```

---

## Real-world Scenarios

### 9. E-commerce Integration

```php
// Sync order from e-commerce to Simba
class OrderSyncService
{
    public function syncOrder(Order $order): void
    {
        DB::transaction(function () use ($order) {
            // 1. Create/Update customer
            $this->syncCustomer($order->customer);
            
            // 2. Create invoice
            $invoiceSttRec = $this->createInvoice($order);
            
            // 3. Create receipt if paid
            if ($order->is_paid) {
                $this->createReceipt($order, $invoiceSttRec);
            }
        });
    }
    
    private function syncCustomer(Customer $customer): void
    {
        $exists = ArDmKh::find($customer->ma_kh);
        
        if (!$exists) {
            AsARInsDMKH::call([
                'pMa_cty'    => '001',
                'pMa_kh'     => $customer->ma_kh,
                'pTen_kh'    => $customer->ten_kh,
                'pDia_chi'   => $customer->dia_chi,
                'pDien_thoai'=> $customer->dien_thoai,
                'pEmail'     => $customer->email,
                'pUser'      => 'system',
            ]);
        } else {
            AsARUpdDMKH::call([
                'pMa_cty'    => '001',
                'pMa_kh'     => $customer->ma_kh,
                'pTen_kh'    => $customer->ten_kh,
                'pDia_chi'   => $customer->dia_chi,
                'pDien_thoai'=> $customer->dien_thoai,
                'pEmail'     => $customer->email,
                'pUser'      => 'system',
            ]);
        }
    }
}
```

### 10. API Endpoint Example

```php
// routes/api.php
Route::prefix('simba')->group(function () {
    Route::get('/customers', [CustomerController::class, 'index']);
    Route::get('/customers/{maKh}', [CustomerController::class, 'show']);
    Route::post('/invoices', [InvoiceController::class, 'store']);
    Route::get('/inventory/{maKho}', [InventoryController::class, 'report']);
    Route::get('/balance/{maKh}', [CustomerController::class, 'balance']);
});

// app/Http/Controllers/Api/InvoiceController.php
namespace App\Http\Controllers\Api;

use App\Http\Controllers\Controller;
use App\Http\Requests\StoreInvoiceRequest;
use App\Services\Simba\InvoiceService;
use Illuminate\Http\JsonResponse;

class InvoiceController extends Controller
{
    public function __construct(
        private InvoiceService $invoiceService
    ) {}
    
    public function store(StoreInvoiceRequest $request): JsonResponse
    {
        try {
            $stt_rec = $this->invoiceService->createInvoice(
                $request->validated()
            );
            
            return response()->json([
                'success' => true,
                'data'    => ['stt_rec' => $stt_rec],
                'message' => 'Invoice created successfully',
            ], 201);
        } catch (\Exception $e) {
            return response()->json([
                'success' => false,
                'message' => $e->getMessage(),
            ], 400);
        }
    }
}
```

---

## Testing Examples

### Unit Test with Mock

```php
// tests/Unit/InvoiceServiceTest.php
namespace Tests\Unit;

use Tests\TestCase;
use Mockery;
use Diepxuan\Simba\StoredProcedures\AsGetSoCt;
use Diepxuan\Simba\StoredProcedures\AsARInsPH1;
use App\Services\Simba\InvoiceService;

class InvoiceServiceTest extends TestCase
{
    public function test_create_invoice(): void
    {
        // Mock stored procedure calls
        $this->mock(AsGetSoCt::class, function ($mock) {
            $mock->shouldReceive('call')
                ->once()
                ->andReturn(collect(['stt_rec' => 'AR120240306001']));
        });
        
        $this->mock(AsARInsPH1::class, function ($mock) {
            $mock->shouldReceive('call')
                ->once()
                ->andReturn(collect(['Ret' => 0]));
        });
        
        $service = new InvoiceService();
        $result = $service->createInvoice([
            'so_hd'    => 'HD001',
            'ngay_hd'  => '2024-03-06',
            'ma_kh'    => 'KH001',
            'items'    => [],
            'user'     => 'admin',
        ]);
        
        $this->assertEquals('AR120240306001', $result);
    }
}
```

---

**Cập nhật lần cuối:** 2026-03-06
**Version:** 1.0
