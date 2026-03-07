# Accounts Receivable (AR) Stored Procedures

Nghiệp vụ phải thu khách hàng.

---

## Giới thiệu

Nhóm stored procedures `AsAR*` xử lý các nghiệp vụ phải thu khách hàng trong hệ thống Simba.

### Chứng từ chính

| Code | Name | Description |
|------|------|-------------|
| `AR1` | Hóa đơn bán hàng | Ghi nhận công nợ phải thu |
| `AR3` | Phiếu thu tiền | Thu tiền từ khách hàng |
| `AR4` | Giấy báo có | Tiền vào từ khách hàng |

### Tables liên quan

| Table | Description |
|-------|-------------|
| `AR_PH1` | Header chứng từ phải thu |
| `AR_CT1` | Chi tiết chứng từ phải thu |
| `ARDMKH` | Danh mục khách hàng |
| `AR_TT` | Theo dõi công nợ phải thu |
| `AR_CDKH` | Công nợ đầu kỳ khách hàng |

---

## Customer Management

### asARInsDMKH - Insert Customer

```php
use Diepxuan\Simba\StoredProcedures\AsARInsDMKH;

AsARInsDMKH::call([
    'pMa_cty'    => '001',
    'pMa_kh'     => 'KH001',
    'pTen_kh'    => 'Cong Ty ABC',
    'pDia_chi'   => '123 Nguyen Hue, Q1, TP.HCM',
    'pMa_so_thue'=> '0312345678',
    'pDien_thoai'=> '028.1234567',
    'pEmail'     => 'contact@abc.com',
    'pMa_nht'    => 'VCB',
    'pSo_tk_nh'  => '123456789',
    'pUser'      => 'admin',
]);
```

### asARUpdDMKH - Update Customer

```php
use Diepxuan\Simba\StoredProcedures\AsARUpdDMKH;

AsARUpdDMKH::call([
    'pMa_cty'    => '001',
    'pMa_kh'     => 'KH001',
    'pTen_kh'    => 'Cong Ty ABC (Updated)',
    'pDien_thoai'=> '028.9876543',
    'pUser'      => 'admin',
]);
```

### asARGetDMKH - Get Customer Info

```php
use Diepxuan\Simba\StoredProcedures\AsARGetDMKH;

$customer = AsARGetDMKH::call([
    'pMa_cty' => '001',
    'pMa_kh'  => 'KH001',
]);
```

---

## Invoice (AR1) Procedures

### asARInsPH1 - Insert Invoice Header

```php
use Diepxuan\Simba\StoredProcedures\AsARInsPH1;

AsARInsPH1::call([
    'pMa_cty'    => '001',
    'pStt_rec'   => 'AR120240306001',
    'pMa_ct'     => 'AR1',
    'pSo_ct'     => 'HD001',
    'pNgay_ct'   => '2024-03-06',
    'pMa_kh'     => 'KH001',
    'pPs_no'     => 11000000,
    'pPs_co'     => 0,
    'pTien_hang' => 10000000,
    'pTien_thue' => 1000000,
    'pDien_giai' => 'Hoa don ban hang',
    'pUser'      => 'admin',
]);
```

### asARInsCT1 - Insert Invoice Detail

```php
use Diepxuan\Simba\StoredProcedures\AsARInsCT1;

AsARInsCT1::call([
    'pMa_cty'    => '001',
    'pStt_rec'   => 'AR120240306001',
    'pMa_vt'     => 'VT001',
    'pDvt'       => 'Cai',
    'pSo_luong'  => 10,
    'pDon_gia'   => 1000000,
    'pTien_hang' => 10000000,
    'pThue_suat' => 10,
    'pTien_thue' => 1000000,
    'pTk'        => '5111',
    'pDien_giai' => 'Ban san pham VT001',
]);
```

---

## Receipt (AR3) Procedures

### asARInsPH3 - Insert Receipt Header

```php
use Diepxuan\Simba\StoredProcedures\AsARInsPH3;

AsARInsPH3::call([
    'pMa_cty'    => '001',
    'pStt_rec'   => 'AR320240306001',
    'pMa_ct'     => 'AR3',
    'pSo_ct'     => 'PT001',
    'pNgay_ct'   => '2024-03-06',
    'pMa_kh'     => 'KH001',
    'pPs_no'     => 0,
    'pPs_co'     => 11000000,
    'pDien_giai' => 'Thu tien thanh toan HD001',
    'pUser'      => 'admin',
]);
```

---

## Get Balance Procedures

### asGetSoDuKh - Get Customer Balance

**Mục đích:** Lấy số dư công nợ của khách hàng tại một thời điểm.

```php
use Diepxuan\Simba\StoredProcedures\AsGetSoDuKh;

$balance = AsGetSoDuKh::call([
    'pMa_Cty' => '001',
    'pMa_kh'  => 'KH001',
    'pTk'     => '131',
    'pNgay'   => '2024-03-31',
]);

// Result structure
// {
//     So_du_no: 5000000,
//     So_du_co: 0,
//     Cong_no: 5000000 // No - Co
// }
```

---

## Complete Example

### Tạo hóa đơn và thu tiền

```php
use Illuminate\Support\Facades\DB;
use Diepxuan\Simba\StoredProcedures\AsGetSoCt;
use Diepxuan\Simba\StoredProcedures\AsARInsPH1;
use Diepxuan\Simba\StoredProcedures\AsARInsCT1;
use Diepxuan\Simba\StoredProcedures\AsARInsPH3;
use Diepxuan\Simba\StoredProcedures\AsARInsCT3;
use Diepxuan\Simba\StoredProcedures\AsProcessCt;

function createInvoiceAndReceipt(array $invoiceData): array
{
    return DB::transaction(function () use ($invoiceData) {
        $maCty = '001';
        
        // === TẠO HÓA ĐƠN (AR1) ===
        $stt_rec_hd = AsGetSoCt::call([
            'pMa_Cty' => $maCty,
            'pMa_Ct'  => 'AR1',
        ]);
        
        // Insert Invoice Header
        AsARInsPH1::call([
            'pMa_cty'    => $maCty,
            'pStt_rec'   => $stt_rec_hd,
            'pMa_ct'     => 'AR1',
            'pSo_ct'     => $invoiceData['so_hd'],
            'pNgay_ct'   => $invoiceData['ngay_hd'],
            'pMa_kh'     => $invoiceData['ma_kh'],
            'pPs_no'     => $invoiceData['tong_cong'],
            'pPs_co'     => 0,
            'pTien_hang' => $invoiceData['tien_hang'],
            'pTien_thue' => $invoiceData['tien_thue'],
            'pDien_giai' => $invoiceData['dien_giai'],
            'pUser'      => $invoiceData['user'],
        ]);
        
        // Insert Invoice Details
        foreach ($invoiceData['items'] as $item) {
            AsARInsCT1::call([
                'pMa_cty'    => $maCty,
                'pStt_rec'   => $stt_rec_hd,
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
        
        // Process Invoice
        AsProcessCt::call([
            'pMa_cty'  => $maCty,
            'pMa_Ct'   => 'AR1',
            'pStt_rec' => $stt_rec_hd,
            'pMode'    => '1',
        ]);
        
        // === TẠO PHIẾU THU (AR3) ===
        $stt_rec_pt = AsGetSoCt::call([
            'pMa_Cty' => $maCty,
            'pMa_Ct'  => 'AR3',
        ]);
        
        // Insert Receipt Header
        AsARInsPH3::call([
            'pMa_cty'    => $maCty,
            'pStt_rec'   => $stt_rec_pt,
            'pMa_ct'     => 'AR3',
            'pSo_ct'     => $invoiceData['so_pt'],
            'pNgay_ct'   => $invoiceData['ngay_pt'],
            'pMa_kh'     => $invoiceData['ma_kh'],
            'pPs_no'     => 0,
            'pPs_co'     => $invoiceData['tong_cong'],
            'pDien_giai' => 'Thu tien HD ' . $invoiceData['so_hd'],
            'pUser'      => $invoiceData['user'],
        ]);
        
        // Insert Receipt Detail (link to invoice)
        AsARInsCT3::call([
            'pMa_cty'     => $maCty,
            'pStt_rec'    => $stt_rec_pt,
            'pTk'         => '131',
            'pMa_ct'      => 'AR1',
            'pStt_rec_ct' => $stt_rec_hd,
            'pPs_no'      => 0,
            'pPs_co'      => $invoiceData['tong_cong'],
            'pDien_giai'  => 'Thu tien HD ' . $invoiceData['so_hd'],
        ]);
        
        // Process Receipt
        AsProcessCt::call([
            'pMa_cty'  => $maCty,
            'pMa_Ct'   => 'AR3',
            'pStt_rec' => $stt_rec_pt,
            'pMode'    => '1',
        ]);
        
        return [
            'invoice_stt_rec' => $stt_rec_hd,
            'receipt_stt_rec' => $stt_rec_pt,
        ];
    });
}

// Usage
$result = createInvoiceAndReceipt([
    'so_hd'       => 'HD001',
    'ngay_hd'     => '2024-03-06',
    'ma_kh'       => 'KH001',
    'tien_hang'   => 10000000,
    'tien_thue'   => 1000000,
    'tong_cong'   => 11000000,
    'dien_giai'   => 'Ban hang hoa',
    'so_pt'       => 'PT001',
    'ngay_pt'     => '2024-03-06',
    'user'        => 'admin',
    'items'       => [
        [
            'ma_vt'     => 'VT001',
            'dvt'       => 'Cai',
            'so_luong'  => 10,
            'don_gia'   => 1000000,
            'tien_hang' => 10000000,
            'thue_suat' => 10,
            'tien_thue' => 1000000,
            'dien_giai' => 'San pham VT001',
        ],
    ],
]);
```

---

## Reports

### asARRptBCCN01 - Báo cáo công nợ khách hàng

```php
use Diepxuan\Simba\StoredProcedures\AsARRptBCCN01;

$report = AsARRptBCCN01::call([
    'pMa_cty'   => '001',
    'pNgay_tu'  => '2024-01-01',
    'pNgay_den' => '2024-03-31',
    'pMa_kh'    => 'KH001',
]);
```

### asARRptBK01 - Bảng kê hóa đơn

```php
use Diepxuan\Simba\StoredProcedures\AsARRptBK01;

$report = AsARRptBK01::call([
    'pMa_cty'   => '001',
    'pNgay_tu'  => '2024-01-01',
    'pNgay_den' => '2024-03-31',
]);
```

---

## Best Practices

1. **Kiểm tra tồn tại khách hàng** trước khi tạo hóa đơn
2. **Sử dụng transaction** cho invoice + receipt
3. **Link chứng từ** đúng cách (stt_rec_ct)
4. **Validate số tiền** trước khi insert
5. **Process ngay** sau khi tạo chứng từ

---

**Cập nhật lần cuối:** 2026-03-06
**Version:** 1.0
