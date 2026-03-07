# Access Control (CA) Stored Procedures

Nghiệp vụ tiền mặt (Cash) và ngân hàng (Bank).

---

## Giới thiệu

Nhóm stored procedures `AsCA*` xử lý các chứng từ tiền mặt và ngân hàng trong hệ thống Simba.

### Chứng từ chính

| Code | Name | Description |
|------|------|-------------|
| `CA1` | Phiếu thu tiền mặt | Thu tiền bằng tiền mặt |
| `CA2` | Phiếu chi tiền mặt | Chi tiền bằng tiền mặt |
| `CA3` | Giấy báo có ngân hàng | Tiền vào tài khoản ngân hàng |
| `CA4` | Giấy báo nợ ngân hàng | Tiền ra từ tài khoản ngân hàng |
| `CA5` | Lãi tiền gửi | Tính lãi tiền gửi ngân hàng |
| `CA6` | Chuyển khoản nội bộ | Chuyển tiền giữa các tài khoản |

### Tables liên quan

| Table | Description |
|-------|-------------|
| `CA_PH2` | Header chứng từ tiền mặt/ngân hàng |
| `CA_CT2` | Chi tiết chứng từ (định khoản) |
| `CA_TTHU` | Theo dõi công nợ phải thu |
| `CA_DMKU` | Danh mục kho quỹ (tiền mặt, TK ngân hàng) |
| `CA_LAIKU` | Lãi tiền gửi |

---

## Insert Procedures

### asCAInsPH2 - Insert Phiếu Thu/Chi Header

**Mục đích:** Tạo mới header chứng từ tiền mặt/ngân hàng.

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | ✅ | Mã công ty |
| `pStt_rec` | nvarchar(33) | ✅ | Số thứ tự record |
| `pMa_ct` | nvarchar(3) | ✅ | Mã chứng từ (CA1, CA2, CA3, CA4) |
| `pSo_ct` | nvarchar(20) | ✅ | Số chứng từ |
| `pNgay_ct` | datetime | ✅ | Ngày chứng từ |
| `pMa_kh` | nvarchar(20) | ❌ | Mã khách hàng (nếu có) |
| `pMa_nvt` | nvarchar(20) | ❌ | Mã nhân viên thu/chi |
| `pPs_no` | decimal | ❌ | Phát sinh Nợ |
| `pPs_co` | decimal | ❌ | Phát sinh Có |
| `pDien_giai` | nvarchar(255) | ✅ | Diễn giải nội dung |
| `pUser` | nvarchar(50) | ✅ | Người tạo |

**Ví dụ:**

```php
use Diepxuan\Simba\StoredProcedures\AsCAInsPH2;

$result = AsCAInsPH2::call([
    'pMa_cty'    => '001',
    'pStt_rec'   => 'CA420240306001',
    'pMa_ct'     => 'CA4',
    'pSo_ct'     => 'GN001',
    'pNgay_ct'   => '2024-03-06',
    'pMa_kh'     => 'KH001',
    'pPs_no'     => 0,
    'pPs_co'     => 10000000,
    'pDien_giai' => 'Thanh toan tien hang',
    'pUser'      => 'admin',
]);
```

---

### asCAInsCT2 - Insert Phiếu Thu/Chi Detail

**Mục đích:** Tạo chi tiết định khoản cho chứng từ.

**Parameters:**

| Name | Type | Required | Description |
|------|------|----------|-------------|
| `pMa_cty` | nvarchar(3) | ✅ | Mã công ty |
| `pStt_rec` | nvarchar(33) | ✅ | Số thứ tự record |
| `pTk` | nvarchar(20) | ✅ | Tài khoản kế toán |
| `pMa_ct` | nvarchar(3) | ❌ | Mã chứng từ đối ứng |
| `pStt_rec_ct` | nvarchar(33) | ❌ | STT record chứng từ đối ứng |
| `pPs_no` | decimal | ❌ | Phát sinh Nợ |
| `pPs_co` | decimal | ❌ | Phát sinh Có |
| `pMa_nt` | nvarchar(3) | ❌ | Mã ngoại tệ |
| `pTy_gia` | decimal | ❌ | Tỷ giá |
| `pDien_giai` | nvarchar(255) | ❌ | Diễn giải chi tiết |

**Ví dụ:**

```php
use Diepxuan\Simba\StoredProcedures\AsCAInsCT2;

// Định khoản: Nợ 112 / Có 131
AsCAInsCT2::call([
    'pMa_cty'   => '001',
    'pStt_rec'  => 'CA420240306001',
    'pTk'       => '1121101',
    'pMa_ct'    => 'AR1',
    'pStt_rec_ct'=> 'AR120240306001',
    'pPs_no'    => 10000000,
    'pPs_co'    => 0,
    'pDien_giai'=> 'Thu tien tu KH001',
]);
```

---

## Update Procedures

### asCAUpdPH2 - Update Header

```php
use Diepxuan\Simba\StoredProcedures\AsCAUpdPH2;

AsCAUpdPH2::call([
    'pMa_cty'    => '001',
    'pStt_rec'   => 'CA420240306001',
    'pSo_ct'     => 'GN001-EDIT',
    'pNgay_ct'   => '2024-03-06',
    'pDien_giai' => 'Cap nhat dien giai',
    'pUser'      => 'admin',
]);
```

### asCAUpdCT2 - Update Detail

```php
use Diepxuan\Simba\StoredProcedures\AsCAUpdCT2;

AsCAUpdCT2::call([
    'pMa_cty'   => '001',
    'pStt_rec'  => 'CA420240306001',
    'pTk'       => '1121101',
    'pPs_no'    => 15000000, // Updated amount
    'pUser'     => 'admin',
]);
```

---

## Delete Procedures

### asCADelPH2 - Delete Header

```php
use Diepxuan\Simba\StoredProcedures\AsCADelPH2;

AsCADelPH2::call([
    'pMa_cty'  => '001',
    'pStt_rec' => 'CA420240306001',
    'pUser'    => 'admin',
]);
```

### asCADelCT2 - Delete Detail

```php
use Diepxuan\Simba\StoredProcedures\AsCADelCT2;

AsCADelCT2::call([
    'pMa_cty'  => '001',
    'pStt_rec' => 'CA420240306001',
    'pTk'      => '1121101',
    'pUser'    => 'admin',
]);
```

---

## Get/Filter Procedures

### asCAGetPH2 - Get Header

```php
use Diepxuan\Simba\StoredProcedures\AsCAGetPH2;

$phieu = AsCAGetPH2::call([
    'pMa_cty'  => '001',
    'pStt_rec' => 'CA420240306001',
]);
```

### asCAFilt1 - Filter Receipts

```php
use Diepxuan\Simba\StoredProcedures\AsCAFilt1;

$receipts = AsCAFilt1::call([
    'pMa_cty'   => '001',
    'pMa_ct'    => 'CA4',
    'pNgay_tu'  => '2024-01-01',
    'pNgay_den' => '2024-03-31',
    'pMa_kh'    => 'KH001',
]);
```

---

## Process Procedures

### asProcessCaPh2 - Process Receipt

**Mục đích:** Kết chuyển chứng từ vào sổ cái.

```php
use Diepxuan\Simba\StoredProcedures\AsProcessCt;

AsProcessCt::call([
    'pMa_cty'  => '001',
    'pMa_Ct'   => 'CA4',
    'pStt_rec' => 'CA420240306001',
    'pMode'    => '1', // 1: Process, 0: Unprocess
]);
```

### asPostCaPh2_glct - Post to General Ledger

```php
use Diepxuan\Simba\StoredProcedures\AsPostCaPh2_glct;

AsPostCaPh2_glct::call([
    'pMa_cty'  => '001',
    'pStt_rec' => 'CA420240306001',
]);
```

---

## Report Procedures

### asCARptTMNH01 - Báo cáo tiền mặt/ngân hàng

```php
use Diepxuan\Simba\StoredProcedures\AsCARptTMNH01;

$report = AsCARptTMNH01::call([
    'pMa_cty'   => '001',
    'pNgay_tu'  => '2024-01-01',
    'pNgay_den' => '2024-03-31',
    'pMa_kho'   => 'TM001', // Kho tiền mặt hoặc TK ngân hàng
]);
```

---

## Complete Example

### Tạo Giấy Báo Nợ (CA4) hoàn chỉnh

```php
use Illuminate\Support\Facades\DB;
use Diepxuan\Simba\StoredProcedures\AsGetSoCt;
use Diepxuan\Simba\StoredProcedures\AsCAInsPH2;
use Diepxuan\Simba\StoredProcedures\AsCAInsCT2;
use Diepxuan\Simba\StoredProcedures\AsProcessCt;

function createBankDebitNote(array $data): string
{
    return DB::transaction(function () use ($data) {
        $maCty = '001';
        $maCt = 'CA4';
        
        // 1. Lấy số chứng từ tiếp theo
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
            'pMa_nvt'    => $data['ma_nvt'] ?? null,
            'pPs_no'     => 0,
            'pPs_co'     => $data['so_tien'],
            'pDien_giai' => $data['dien_giai'],
            'pUser'      => $data['user'],
        ]);
        
        // 3. Insert Details (định khoản)
        foreach ($data['details'] as $detail) {
            AsCAInsCT2::call([
                'pMa_cty'    => $maCty,
                'pStt_rec'   => $stt_rec,
                'pTk'        => $detail['tk'],
                'pMa_ct'     => $detail['ma_ct'] ?? null,
                'pStt_rec_ct'=> $detail['stt_rec_ct'] ?? null,
                'pPs_no'     => $detail['ps_no'] ?? 0,
                'pPs_co'     => $detail['ps_co'] ?? 0,
                'pMa_nt'     => $detail['ma_nt'] ?? null,
                'pTy_gia'    => $detail['ty_gia'] ?? 1,
                'pDien_giai' => $detail['dien_giai'] ?? null,
            ]);
        }
        
        // 4. Process chứng từ
        AsProcessCt::call([
            'pMa_cty'  => $maCty,
            'pMa_Ct'   => $maCt,
            'pStt_rec' => $stt_rec,
            'pMode'    => '1',
        ]);
        
        return $stt_rec;
    });
}

// Usage
try {
    $stt_rec = createBankDebitNote([
        'so_ct'      => 'GN001',
        'ngay_ct'    => '2024-03-06',
        'ma_kh'      => 'KH001',
        'so_tien'    => 10000000,
        'dien_giai'  => 'Thanh toan tien hang',
        'user'       => 'admin',
        'details'    => [
            [
                'tk'         => '1121101',
                'ps_no'      => 10000000,
                'dien_giai'  => 'Tien mat chuyen khoan',
            ],
        ],
    ]);
    
    echo "Created receipt: $stt_rec";
} catch (\Exception $e) {
    echo "Error: " . $e->getMessage();
}
```

---

## Validation Rules

### Header Validation

```php
$rules = [
    'ma_cty'   => 'required|string|max:3',
    'ma_ct'    => 'required|string|in:CA1,CA2,CA3,CA4,CA5,CA6',
    'so_ct'    => 'required|string|max:20',
    'ngay_ct'  => 'required|date',
    'dien_giai'=> 'required|string|max:255',
    'user'     => 'required|string|max:50',
];
```

### Detail Validation

```php
$rules = [
    'tk'       => 'required|string|max:20',
    'ps_no'    => 'numeric|min:0',
    'ps_co'    => 'numeric|min:0',
    'ty_gia'   => 'numeric|min:0',
];
```

---

## Error Codes

| Code | Meaning | Solution |
|------|---------|----------|
| `-1` | Invalid company code | Check `pMa_cty` parameter |
| `-2` | Duplicate voucher number | Use `AsGetSoCt` to get unique number |
| `-3` | Invalid account | Verify chart of accounts |
| `-4` | Amount mismatch (No != Co) | Ensure debits = credits |
| `-5` | Missing required field | Check all required parameters |
| `-6` | User permission denied | Verify user rights |

---

## Best Practices

1. **Luôn lấy số chứng từ từ `AsGetSoCt`** để tránh trùng
2. **Sử dụng transaction** cho multi-step operations
3. **Validate input** trước khi gọi stored procedures
4. **Check return value** để xử lý lỗi
5. **Log đầy đủ** cho audit trail

---

## Tài liệu liên quan

- [Overview](./overview.md)
- [Accounts Receivable (AR)](./ar.md)
- [General Ledger (GL)](./gl.md)
- [DATABASE_ACCESS_POLICY.md](../DATABASE_ACCESS_POLICY.md)

---

**Cập nhật lần cuối:** 2026-03-06
**Version:** 1.0
