# General Ledger (GL) Stored Procedures

Nghiệp vụ kế toán tổng hợp.

---

## Giới thiệu

Nhóm stored procedures `AsGL*` xử lý các nghiệp vụ kế toán tổng hợp trong hệ thống Simba.

### Tables liên quan

| Table | Description |
|-------|-------------|
| `GL_PH1` | Header bút toán |
| `GL_CT1` | Chi tiết bút toán (định khoản) |
| `GLDMTK` | Danh mục tài khoản kế toán |
| `GLCDTK` | Số dư đầu kỳ tài khoản |
| `GLKC` | Bút toán kết chuyển |
| `GLDGTG` | Đánh giá tỷ giá |

---

## Account Management

### asGLInsDMTK - Insert Chart of Account

```php
use Diepxuan\Simba\StoredProcedures\AsGLInsDMTK;

AsGLInsDMTK::call([
    'pMa_cty'    => '001',
    'pTk'        => '1121101',
    'pTen_tk'    => 'Tien mat tai Vietcombank',
    'pTk_me'     => '1121',
    'pLoai_tk'   => '1', // 1: Tai san, 2: No phai tra, etc.
    'pMa_nht'    => 'VCB',
    'pSo_tk_nh'  => '123456789',
    'pUser'      => 'admin',
]);
```

### asGLUpdDMTK - Update Account

```php
use Diepxuan\Simba\StoredProcedures\AsGLUpdDMTK;

AsGLUpdDMTK::call([
    'pMa_cty'    => '001',
    'pTk'        => '1121101',
    'pTen_tk'    => 'Tien mat tai Vietcombank - Chi nhanh HCM',
    'pUser'      => 'admin',
]);
```

---

## Journal Entry Procedures

### asGLInsPH1 - Insert Journal Entry Header

```php
use Diepxuan\Simba\StoredProcedures\AsGLInsPH1;

AsGLInsPH1::call([
    'pMa_cty'    => '001',
    'pStt_rec'   => 'GL120240306001',
    'pMa_ct'     => 'GL1',
    'pSo_ct'     => 'GN001',
    'pNgay_ct'   => '2024-03-06',
    'pDien_giai' => 'But toan ke toan',
    'pUser'      => 'admin',
]);
```

### asGLInsCT1 - Insert Journal Entry Detail

```php
use Diepxuan\Simba\StoredProcedures\AsGLInsCT1;

// Debit entry
AsGLInsCT1::call([
    'pMa_cty'    => '001',
    'pStt_rec'   => 'GL120240306001',
    'pTk'        => '1121101',
    'pPs_no'     => 10000000,
    'pPs_co'     => 0,
    'pMa_nt'     => 'VND',
    'pTy_gia'    => 1,
    'pDien_giai' => 'Thu tien mat',
]);

// Credit entry
AsGLInsCT1::call([
    'pMa_cty'    => '001',
    'pStt_rec'   => 'GL120240306001',
    'pTk'        => '131',
    'pPs_no'     => 0,
    'pPs_co'     => 10000000,
    'pMa_nt'     => 'VND',
    'pTy_gia'    => 1,
    'pDien_giai' => 'Giam cong no KH',
]);
```

---

## Balance Procedures

### asGLCalSumCdTk - Calculate Account Balance

```php
use Diepxuan\Simba\StoredProcedures\AsGLCalSumCdTk;

$balance = AsGLCalSumCdTk::call([
    'pMa_cty' => '001',
    'pTk'     => '131',
    'pNam'    => 2024,
    'pMa_nt'  => 'VND',
    'pRet'    => ['type' => 'INT', 'output' => true],
]);
```

### asGLChuyenSdTk - Transfer Balance to Next Year

```php
use Diepxuan\Simba\StoredProcedures\AsGLChuyenSdTk;

AsGLChuyenSdTk::call([
    'pMa_cty'     => '001',
    'pNgay_cnt'   => '2024-12-31',
    'pRet'        => ['type' => 'INT', 'output' => true],
]);
```

---

## Automatic Entries

### asGLCrtKC - Create Automatic Closing Entry

```php
use Diepxuan\Simba\StoredProcedures\AsGLCrtKC;

AsGLCrtKC::call([
    'pMa_cty'   => '001',
    'pMa_ct'    => 'KC1',
    'pNgay1'    => '2024-01-01',
    'pNgay2'    => '2024-12-31',
    'pTk'       => '511%',
    'pTk_du'    => '911',
    'pUser'     => 'admin',
    'pRet'      => ['type' => 'INT', 'output' => true],
]);
```

### asGLCrtDGTG - Create Foreign Exchange Revaluation

```php
use Diepxuan\Simba\StoredProcedures\AsGLCrtDGTG;

AsGLCrtDGTG::call([
    'pma_cty'   => '001',
    'pma_ct'    => 'DGTG',
    'pma_nt'    => 'USD',
    'pstt'      => 'DGTG202403',
    'pngay1'    => '2024-03-01',
    'pngay2'    => '2024-03-31',
    'puser'     => 'admin',
    'pRet'      => ['type' => 'INT', 'output' => true],
]);
```

---

## Reports

### asGLRptBCTC01 - Balance Sheet

```php
use Diepxuan\Simba\StoredProcedures\AsGLRptBCTC01;

$report = AsGLRptBCTC01::call([
    'pMa_cty'     => '001',
    'pNgay'       => '2024-03-31',
    'pMau'        => 'BCTC01',
]);
```

### asGLRptNKC01 - Internal Control Report

```php
use Diepxuan\Simba\StoredProcedures\AsGLRptNKC01;

$report = AsGLRptNKC01::call([
    'pMa_cty'   => '001',
    'pNgay_tu'  => '2024-01-01',
    'pNgay_den' => '2024-03-31',
]);
```

---

## Complete Example

### Tạo bút toán kế toán

```php
use Illuminate\Support\Facades\DB;
use Diepxuan\Simba\StoredProcedures\AsGetSoCt;
use Diepxuan\Simba\StoredProcedures\AsGLInsPH1;
use Diepxuan\Simba\StoredProcedures\AsGLInsCT1;
use Diepxuan\Simba\StoredProcedures\AsProcessCt;

function createJournalEntry(array $data): string
{
    return DB::transaction(function () use ($data) {
        $maCty = '001';
        $maCt = 'GL1';
        
        // 1. Get voucher number
        $stt_rec = AsGetSoCt::call([
            'pMa_Cty' => $maCty,
            'pMa_Ct'  => $maCt,
        ]);
        
        // 2. Insert Header
        AsGLInsPH1::call([
            'pMa_cty'    => $maCty,
            'pStt_rec'   => $stt_rec,
            'pMa_ct'     => $maCt,
            'pSo_ct'     => $data['so_ct'],
            'pNgay_ct'   => $data['ngay_ct'],
            'pDien_giai' => $data['dien_giai'],
            'pUser'      => $data['user'],
        ]);
        
        // 3. Insert Details (must balance: total debit = total credit)
        $totalDebit = 0;
        foreach ($data['entries'] as $entry) {
            AsGLInsCT1::call([
                'pMa_cty'    => $maCty,
                'pStt_rec'   => $stt_rec,
                'pTk'        => $entry['tk'],
                'pPs_no'     => $entry['ps_no'] ?? 0,
                'pPs_co'     => $entry['ps_co'] ?? 0,
                'pMa_nt'     => $entry['ma_nt'] ?? 'VND',
                'pTy_gia'    => $entry['ty_gia'] ?? 1,
                'pDien_giai' => $entry['dien_giai'] ?? $data['dien_giai'],
            ]);
            
            $totalDebit += $entry['ps_no'] ?? 0;
        }
        
        // 4. Validate balance
        if ($totalDebit <= 0) {
            throw new \Exception('Invalid journal entry: total debit must be > 0');
        }
        
        // 5. Process
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
createJournalEntry([
    'so_ct'      => 'GN001',
    'ngay_ct'    => '2024-03-06',
    'dien_giai'  => 'Dieu chinh ke toan',
    'user'       => 'admin',
    'entries'    => [
        ['tk' => '1121101', 'ps_no' => 10000000, 'ps_co' => 0],
        ['tk' => '131', 'ps_no' => 0, 'ps_co' => 10000000],
    ],
]);
```

---

**Cập nhật lần cuối:** 2026-03-06
**Version:** 1.0
