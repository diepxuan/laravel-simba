# Laravel Simba - Documentation

Tài liệu đầy đủ cho package `diepxuan/laravel-simba` - Laravel Integration With Simba (phần mềm kế toán).

---

## Mục lục

1. [Giới thiệu](#giới-thiệu)
2. [Cài đặt](#cài-đặt)
3. [Cấu hình](#cấu-hình)
4. [Sử dụng](#sử-dụng)
5. [Database Access Policy](#database-access-policy)
6. [Stored Procedures](#stored-procedures)
7. [Models](#models)
8. [API Reference](#api-reference)
9. [Examples](#examples)
10. [Troubleshooting](#troubleshooting)

---

## Giới thiệu

Laravel Simba là package tích hợp Laravel với hệ thống ERP Simba (phần mềm kế toán). Package cung cấp:

- **Eloquent Models** tương ứng với các bảng dữ liệu Simba
- **Stored Procedure Classes** để gọi các thủ tục lưu trữ từ Simba
- **Hỗ trợ composite primary key** thông qua package `eloquent-composite`
- **Xử lý charset** (encoding) tự động

### Nguyên tắc thiết kế

> **CHỈ ĐỌC (READ-ONLY)** - Mọi thao tác **INSERT/UPDATE/DELETE** phải thực hiện thông qua **Stored Procedures**.

Xem chi tiết: [Database Access Policy](./DATABASE_ACCESS_POLICY.md)

---

## Cài đặt

### Yêu cầu hệ thống

- PHP >= 8.1
- Laravel >= 10.0
- SQL Server (sqlsrv driver)
- Extension: `pdo_sqlsrv`, `sqlsrv`

### Cài đặt qua Composer

```bash
composer require diepxuan/laravel-simba
```

### Dependencies

Package phụ thuộc vào:

```json
{
  "diepxuan/php-charset": "*",
  "diepxuan/laravel-core": "*",
  "diepxuan/laravel-eloquent-composite": "*"
}
```

---

## Cấu hình

### Environment Variables

Thêm vào file `.env`:

```env
# Simba Connection
SIMBA_CONNECTION=sqlsrv

# SQL Server Configuration (nếu dùng connection riêng)
DB_CONNECTION_SIMBA=sqlsrv
DB_HOST_SIMBA=127.0.0.1
DB_PORT_SIMBA=1433
DB_DATABASE_SIMBA=simba_db
DB_USERNAME_SIMBA=username
DB_PASSWORD_SIMBA=password
```

### Config File

Package sử dụng config từ `config/simba.php` (nếu có) hoặc default:

```php
// config/simba.php
return [
    'connection' => env('SIMBA_CONNECTION', 'sqlsrv'),
];
```

---

## Sử dụng

### Đọc dữ liệu (READ)

```php
use Diepxuan\Simba\Models\ArDmKh;
use Diepxuan\Simba\Models\GlCt;

// Lấy tất cả khách hàng
$customers = ArDmKh::all();

// Tìm khách hàng theo mã
$customer = ArDmKh::where('ma_kh', 'KH001')->first();

// Query phức tạp
$transactions = GlCt::where('ma_cty', '001')
    ->where('ngay_ct', '>=', '2024-01-01')
    ->where('tk', '131')
    ->get();
```

### Gọi Stored Procedures (WRITE)

```php
use Diepxuan\Simba\StoredProcedures\AsGetSoCt;
use Diepxuan\Simba\StoredProcedures\AsCAInsPH2;
use Diepxuan\Simba\StoredProcedures\ProcedureCaller;

// Lấy số chứng từ tiếp theo
$stt_rec = AsGetSoCt::call([
    'pMa_Cty' => '001',
    'pMa_Ct'  => 'CA4',
]);

// Insert phiếu thu qua Stored Procedure
$result = AsCAInsPH2::call([
    'pMa_cty'   => '001',
    'pStt_rec'  => $stt_rec,
    'pMa_ct'    => 'CA4',
    'pSo_ct'    => 'PT001',
    'pNgay_ct'  => '2024-03-06',
    'pMa_kh'    => 'KH001',
    'pPs_no'    => 1000000,
    'pDien_giai'=> 'Thu tien ban hang',
    'pUser'     => 'admin',
]);
```

### Sử dụng trong Transaction

```php
use Illuminate\Support\Facades\DB;
use Diepxuan\Simba\StoredProcedures\AsCAInsPH2;
use Diepxuan\Simba\StoredProcedures\AsCAInsCT2;
use Diepxuan\Simba\StoredProcedures\AsProcessCt;

DB::transaction(function () use ($data) {
    // 1. Lấy số chứng từ
    $stt_rec = AsGetSoCt::call([
        'pMa_Cty' => '001',
        'pMa_Ct'  => 'CA4',
    ]);
    
    // 2. Insert Header
    AsCAInsPH2::call([
        'pMa_cty'  => '001',
        'pStt_rec' => $stt_rec,
        // ... parameters
    ]);
    
    // 3. Insert Details
    foreach ($data['details'] as $detail) {
        AsCAInsCT2::call([
            'pMa_cty'  => '001',
            'pStt_rec' => $stt_rec,
            // ... parameters
        ]);
    }
    
    // 4. Process chứng từ
    AsProcessCt::call([
        'pMa_Cty'  => '001',
        'pMa_Ct'   => 'CA4',
        'pStt_rec' => $stt_rec,
        'pMode'    => '1',
    ]);
});
```

---

## Database Access Policy

Package tuân thủ nguyên tắc bảo mật nghiêm ngặt:

| Thao tác | Được phép | Cách thực hiện |
|----------|-----------|----------------|
| **SELECT** | ✅ | Eloquent Models, Query Builder |
| **INSERT** | ❌ | Chỉ qua Stored Procedures |
| **UPDATE** | ❌ | Chỉ qua Stored Procedures |
| **DELETE** | ❌ | Chỉ qua Stored Procedures |

Xem chi tiết: [DATABASE_ACCESS_POLICY.md](./DATABASE_ACCESS_POLICY.md)

---

## Stored Procedures

### Categories

Stored procedures được phân loại theo module:

| Category | Prefix | Mô tả |
|----------|--------|-------|
| **Access Control** | `AsCA*` | Chứng từ tiền mặt, ngân hàng |
| **Accounts Receivable** | `AsAR*` | Nghiệp vụ phải thu |
| **Accounts Payable** | `AsAP*` | Nghiệp vụ phải trả |
| **General Ledger** | `AsGL*` | Kế toán tổng hợp |
| **Inventory** | `AsIN*` | Quản lý kho |
| **Purchase Order** | `AsPO*` | Mua hàng |
| **Sales Order** | `AsSO*` | Bán hàng |
| **System** | `AsSys*` | Nghiệp vụ hệ thống |
| **Fixed Assets** | `AsFA*` | Tài sản cố định |
| **Costing** | `AsCO*` | Tính giá thành |
| **HR & Payroll** | `AsHr*` | Nhân sự, lương |
| **Tax** | `AsTa*` | Thuế, báo cáo thuế |

### Danh sách đầy đủ

Xem chi tiết từng category:

- [Stored Procedures Overview](./STORED_PROCEDURES/overview.md)
- [Access Control (CA)](./STORED_PROCEDURES/ca.md)
- [Accounts Receivable (AR)](./STORED_PROCEDURES/ar.md)
- [Accounts Payable (AP)](./STORED_PROCEDURES/ap.md)
- [General Ledger (GL)](./STORED_PROCEDURES/gl.md)
- [Inventory (IN)](./STORED_PROCEDURES/in.md)
- [Purchase Order (PO)](./STORED_PROCEDURES/po.md)
- [Sales Order (SO)](./STORED_PROCEDURES/so.md)

---

## Models

### SModel (Base Model)

Tất cả models kế thừa từ `SModel`:

```php
namespace Diepxuan\Simba\SModel;

class ArDmKh extends SModel
{
    protected $table = 'ARDMKH';
    protected $primaryKey = 'ma_kh';
    public $incrementing = false;
    protected $keyType = 'string';
}
```

### Models phổ biến

| Model | Table | Mô tả |
|-------|-------|-------|
| `ArDmKh` | ARDMKH | Danh mục khách hàng |
| `InDmVt` | INDMVT | Danh mục vật tư |
| `InDmKho` | INDMKHO | Danh mục kho |
| `GlCt` | GLCT | Chứng từ kế toán |
| `GlDmTk` | GLDMTK | Danh mục tài khoản |
| `SysCompany` | SYSCOMPANY | Thông tin công ty |
| `SysUserInfo` | SYSUSERINFO | Thông tin người dùng |

### Models mở rộng (Models/)

Package cung cấp 2 lớp models:

1. **SModel/** - Models cơ bản (auto-generated)
2. **Models/** - Models mở rộng (có thể thêm scope, logic)

```php
// Sử dụng models mở rộng
use Diepxuan\Simba\Models\ArDmKh;

$customer = ArDmKh::withActive()->find('KH001');
```

---

## API Reference

### ProcedureCaller

Class cơ bản để gọi stored procedures:

```php
use Diepxuan\Simba\StoredProcedures\ProcedureCaller;

// Gọi procedure cơ bản
$result = ProcedureCaller::call('asGetSoCt', [
    'pMa_Cty' => '001',
    'pMa_Ct'  => 'CA4',
]);

// Gọi với OUTPUT parameter
$result = ProcedureCaller::call('asChkUserLogin', [
    'pUserName' => 'admin',
    'pPassword' => 'password',
    'pRet'      => ['type' => 'INT', 'output' => true],
]);

// Lấy giá trị output
$ret = $result->first()->Ret ?? 0;
```

### StoredProcedure Base Class

```php
namespace Diepxuan\Simba\StoredProcedures;

abstract class StoredProcedure
{
    protected static string $name = '';
    protected static array $params = [];
    
    public static function call(array $params = [])
    {
        // Implementation
    }
}
```

---

## Examples

### 1. Tạo phiếu thu mới

```php
use Diepxuan\Simba\StoredProcedures\AsGetSoCt;
use Diepxuan\Simba\StoredProcedures\AsCAInsPH2;
use Diepxuan\Simba\StoredProcedures\AsCAInsCT2;
use Diepxuan\Simba\StoredProcedures\AsProcessCt;

function createReceipt(array $data): string
{
    return DB::transaction(function () use ($data) {
        $maCty = '001';
        $maCt = 'CA4';
        
        // Lấy số chứng từ
        $stt_rec = AsGetSoCt::call([
            'pMa_Cty' => $maCty,
            'pMa_Ct'  => $maCt,
        ]);
        
        // Insert header
        AsCAInsPH2::call([
            'pMa_cty'   => $maCty,
            'pStt_rec'  => $stt_rec,
            'pMa_ct'    => $maCt,
            'pSo_ct'    => $data['so_ct'],
            'pNgay_ct'  => $data['ngay_ct'],
            'pMa_kh'    => $data['ma_kh'],
            'pPs_no'    => $data['so_tien'],
            'pDien_giai'=> $data['dien_giai'],
            'pUser'     => auth()->user()->username,
        ]);
        
        // Insert details (nếu có)
        foreach ($data['details'] ?? [] as $detail) {
            AsCAInsCT2::call([
                'pMa_cty'  => $maCty,
                'pStt_rec' => $stt_rec,
                'pTk'      => $detail['tk'],
                'pPs_no'   => $detail['ps_no'],
                'pPs_co'   => $detail['ps_co'],
            ]);
        }
        
        // Process chứng từ
        AsProcessCt::call([
            'pMa_Cty'  => $maCty,
            'pMa_Ct'   => $maCt,
            'pStt_rec' => $stt_rec,
            'pMode'    => '1',
        ]);
        
        return $stt_rec;
    });
}
```

### 2. Lấy số dư khách hàng

```php
use Diepxuan\Simba\StoredProcedures\AsGetSoDuKh;
use Diepxuan\Simba\Models\ArDmKh;

function getCustomerBalance(string $maKh, string $ngay): array
{
    $customer = ArDmKh::find($maKh);
    
    $balance = AsGetSoDuKh::call([
        'pMa_Cty' => '001',
        'pMa_kh'  => $maKh,
        'pTk'     => '131',
        'pNgay'   => $ngay,
    ]);
    
    return [
        'customer' => $customer,
        'balance'  => $balance->first(),
    ];
}
```

### 3. Query dữ liệu kho

```php
use Diepxuan\Simba\Models\InDmVt;
use Diepxuan\Simba\Models\InDmKho;
use Diepxuan\Simba\Models\InCt3;

function getInventoryReport(string $maKho, string $tuNgay, string $denNgay)
{
    $kho = InDmKho::find($maKho);
    
    $transactions = InCt3::where('ma_kho', $maKho)
        ->whereBetween('ngay_ct', [$tuNgay, $denNgay])
        ->with(['vatTu', 'phieu'])
        ->get();
    
    $tonKho = $transactions->groupBy('ma_vt')->map(function ($items) {
        return [
            'ma_vt' => $items->first()->ma_vt,
            'ten_vt' => $items->first()->vatTu->ten_vt,
            'nhap' => $items->sum('sl_nhap'),
            'xuat' => $items->sum('sl_xuat'),
            'ton' => $items->sum('sl_nhap') - $items->sum('sl_xuat'),
        ];
    });
    
    return [
        'kho' => $kho,
        'period' => [$tuNgay, $denNgay],
        'inventory' => $tonKho,
    ];
}
```

---

## Troubleshooting

### Lỗi thường gặp

#### 1. Connection Error

```
SQLSTATE[08001]: [SQL Server] SQL Server does not exist
```

**Giải pháp:**
- Kiểm tra `SIMBA_CONNECTION` trong `.env`
- Verify SQL Server driver: `php -m | grep sqlsrv`
- Kiểm tra connection string

#### 2. Stored Procedure Not Found

```
Could not find stored procedure 'asGetSoCt'
```

**Giải pháp:**
- Verify procedure exists in database
- Check user permissions
- Ensure correct database selected

#### 3. Charset Issues

```
Invalid character encoding
```

**Giải pháp:**
- Install `diepxuan/php-charset` package
- Configure charset in config
- Use `mb_convert_encoding` if needed

#### 4. Composite Key Error

```
Primary key must be an array for composite keys
```

**Giải pháp:**
- Install `diepxuan/laravel-eloquent-composite`
- Use array for find: `Model::find(['key1', 'key2'])`

### Debug Mode

Enable query logging:

```php
DB::enableQueryLog();

// Execute queries

dd(DB::getQueryLog());
```

### Performance Tips

1. **Use indexes** on frequently queried columns
2. **Batch operations** with stored procedures
3. **Cache** reference data (danh mục)
4. **Limit result sets** with pagination

---

## Tài liệu liên quan

- [DATABASE_ACCESS_POLICY.md](./DATABASE_ACCESS_POLICY.md) - Chính sách truy cập database
- [STORED_PROCEDURES/](./STORED_PROCEDURES/) - Chi tiết stored procedures
- [PROCEDURES_OPTIMIZED.md](./PROCEDURES_OPTIMIZED.md) - Procedures đã optimize

---

## Liên hệ

- **Author**: Tran Ngoc Duc
- **Email**: ductn@diepxuan.com
- **Repository**: `diepxuan/laravel-simba`

---

**Cập nhật lần cuối:** 2026-03-06
**Version:** 1.0
