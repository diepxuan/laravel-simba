# Stored Procedures Overview

Tổng quan về hệ thống Stored Procedures trong Laravel Simba.

---

## Giới thiệu

Tất cả thao tác **INSERT**, **UPDATE**, **DELETE** trên database Simba phải thực hiện thông qua Stored Procedures. Đây là nguyên tắc bất biến để đảm bảo:

- ✅ Tính nhất quán dữ liệu
- ✅ Business rules được enforce ở database level
- ✅ Audit trail tự động
- ✅ Performance optimization
- ✅ Security & permissions

---

## Kiến trúc

```
┌─────────────────────────────────────────────────────────┐
│                   APPLICATION LAYER                      │
│              (Controllers, Services, Jobs)              │
└─────────────────────────────────────────────────────────┘
                            │
                            ▼
┌─────────────────────────────────────────────────────────┐
│           STORED PROCEDURE CLASSES (PHP)                │
│  ┌─────────────────────────────────────────────────┐   │
│  │  class AsCAInsPH2 extends StoredProcedure      │   │
│  │  {                                              │   │
│  │      protected static string $name = 'asCAInsPH2'; │   │
│  │      public static function call(array $params) │   │
│  │  }                                              │   │
│  └─────────────────────────────────────────────────┘   │
└─────────────────────────────────────────────────────────┘
                            │
                            ▼
┌─────────────────────────────────────────────────────────┐
│                  SQL SERVER DATABASE                     │
│  ┌─────────────────────────────────────────────────┐   │
│  │  CREATE PROCEDURE asCAInsPH2                    │   │
│  │      @pMa_cty nvarchar(3),                      │   │
│  │      @pStt_rec nvarchar(33),                    │   │
│  │      ...                                        │   │
│  │  AS BEGIN                                       │   │
│  │      -- Business logic here                     │   │
│  │  END                                            │   │
│  └─────────────────────────────────────────────────┘   │
└─────────────────────────────────────────────────────────┘
```

---

## Categories

Stored procedures được phân loại theo module nghiệp vụ:

### 1. Access Control (CA) - Tiền mặt & Ngân hàng

| Prefix | Mô tả | Examples |
|--------|-------|----------|
| `AsCAIns*` | Insert chứng từ | `asCAInsPH2`, `asCAInsCT2` |
| `AsCAUpd*` | Update chứng từ | `asCAUpdPH2`, `asCAUpdCT2` |
| `AsCADel*` | Delete chứng từ | `asCADelPH2`, `asCADelCT2` |
| `AsCAFilt*` | Lọc chứng từ | `asCAFilt1`, `asCAFilt2` |
| `AsCAGet*` | Lấy dữ liệu | `asCAGetPH2`, `asCAGetCT2` |
| `AsCARpt*` | Báo cáo | `asCARptTMNH01`, `asCARptTMNH02` |
| `AsChk*` | Kiểm tra | `asChkUserLogin`, `asChkExecRight` |

**Tables liên quan:** `CA_PH2`, `CA_CT2`, `CA_TTHU`, `CA_DMKU`

[Xem chi tiết](./ca.md)

---

### 2. Accounts Receivable (AR) - Phải thu khách hàng

| Prefix | Mô tả | Examples |
|--------|-------|----------|
| `AsARIns*` | Insert | `asARInsPH1`, `asARInsCT1`, `asARInsDMKH` |
| `AsARUpd*` | Update | `asARUpdPH1`, `asARUpdDMKH` |
| `AsARDel*` | Delete | `asARDelPH1`, `asARDelDMKH` |
| `AsARGet*` | Get data | `asARGetPH1`, `asARGetDMKH`, `asARGetTT` |
| `AsARRpt*` | Reports | `asARRptBCCN01`, `asARRptBK01` |

**Tables liên quan:** `AR_PH1`, `AR_CT1`, `ARDMKH`, `AR_TT`

[Xem chi tiết](./ar.md)

---

### 3. Accounts Payable (AP) - Phải trả nhà cung cấp

| Prefix | Mô tả | Examples |
|--------|-------|----------|
| `AsAPIns*` | Insert | `asAPInsPH1`, `asAPInsCT1` |
| `AsAPUpd*` | Update | `asAPUpdPH1`, `asAPUpdTT` |
| `AsAPDel*` | Delete | `asAPDelPH1`, `asAPDelTT` |
| `AsAPGet*` | Get data | `asAPGetPH1`, `asAPGetTT` |
| `AsAPRpt*` | Reports | `asAPRptBK01`, `asAPRptBK02` |

**Tables liên quan:** `AP_PH1`, `AP_CT1`, `AP_TT`

[Xem chi tiết](./ap.md)

---

### 4. General Ledger (GL) - Kế toán tổng hợp

| Prefix | Mô tả | Examples |
|--------|-------|----------|
| `AsGLIns*` | Insert | `asGLInsPH1`, `asGLInsCT1`, `asGLInsDMTK` |
| `AsGLUpd*` | Update | `asGLUpdPH1`, `asGLUpdDMTK` |
| `AsGLDel*` | Delete | `asGLDelPH1`, `asGLDelDMTK` |
| `AsGLGet*` | Get data | `asGLGetPH1`, `asGLGetDMTK` |
| `AsGLRpt*` | Reports | `asGLRptBCTC01`, `asGLRptNKC01` |
| `AsGLCrt*` | Create entries | `asGLCrtKC`, `asGLCrtDGTG` |

**Tables liên quan:** `GL_PH1`, `GL_CT1`, `GLDMTK`, `GLCDTK`

[Xem chi tiết](./gl.md)

---

### 5. Inventory (IN) - Quản lý kho

| Prefix | Mô tả | Examples |
|--------|-------|----------|
| `AsINIns*` | Insert | `asINInsPH3`, `asINInsCT3`, `asINInsDMVT` |
| `AsINUpd*` | Update | `asINUpdPH3`, `asINUpdDMVT` |
| `AsINDel*` | Delete | `asINDelPH3`, `asINDelDMVT` |
| `AsINGet*` | Get data | `asINGetPH3`, `asINGetDMVT`, `asINGetTonKho` |
| `AsINRpt*` | Reports | `asINRptCD01`, `asINRptBKX01` |
| `AsInCal*` | Calculations | `asInCalGiaFIFO`, `asInCalGiaTB` |

**Tables liên quan:** `IN_PH3`, `IN_CT3`, `INDMVT`, `INDMKHO`, `INCDVT`

[Xem chi tiết](./in.md)

---

### 6. Purchase Order (PO) - Mua hàng

| Prefix | Mô tả | Examples |
|--------|-------|----------|
| `AsPOIns*` | Insert | `asPOInsPH3`, `asPOInsCT3` |
| `AsPOUpd*` | Update | `asPOUpdPH3`, `asPOUpdCT3` |
| `AsPODel*` | Delete | `asPODelPH3`, `asPODelCT3` |
| `AsPOGet*` | Get data | `asPOGetPH3`, `asPOGetCT3` |
| `AsPORpt*` | Reports | `asPORptTH01`, `asPORptBK01` |
| `AsPOChk*` | Check rights | `asPOChkRightStatusPO3` |

**Tables liên quan:** `PO_PH3`, `PO_CT3`, `PO_DMTT`

[Xem chi tiết](./po.md)

---

### 7. Sales Order (SO) - Bán hàng

| Prefix | Mô tả | Examples |
|--------|-------|----------|
| `AsSOIns*` | Insert | `asSOInsPH3`, `asSOInsCT3`, `asSOInsDMKM` |
| `AsSOUpd*` | Update | `asSOUpdPH3`, `asSOUpdDMKM` |
| `AsSODel*` | Delete | `asSODelPH3`, `asSODelDMKM` |
| `AsSOGet*` | Get data | `asSOGetPH3`, `asSOGetDMKM` |
| `AsSORpt*` | Reports | `asSORptTH01`, `asSORptBK01` |
| `AsSOChk*` | Check rights | `asSOChkRightStatusSO3` |

**Tables liên quan:** `SO_PH3`, `SO_CT3`, `SODMKM`, `SODMGIABAN`

[Xem chi tiết](./so.md)

---

### 8. System (SYS) - Nghiệp vụ hệ thống

| Prefix | Mô tả | Examples |
|--------|-------|----------|
| `AsSys*` | System ops | `asSysCopyDatabaseCompany` |
| `AsGet*` | Get config | `asGetCompanyInfo`, `asGetUserInfo` |
| `AsIns*` | Insert config | `asInsUserInfo`, `asInsMenu` |
| `AsUpd*` | Update config | `asUpdUserInfo`, `asUpdMenu` |
| `AsDel*` | Delete config | `asDelUserInfo`, `asDelMenu` |

**Tables liên quan:** `SYSCOMPANY`, `SYSUSERINFO`, `SYSMENU`

[Xem chi tiết](./system.md)

---

### 9. Fixed Assets (FA) - Tài sản cố định

| Prefix | Mô tả | Examples |
|--------|-------|----------|
| `AsFAIns*` | Insert | `asFAInsDMTS`, `asFAInsDMCC` |
| `AsFAUpd*` | Update | `asFAUpdDMTS`, `asFAUpdKHTS` |
| `AsFADel*` | Delete | `asFADelDMTS`, `asFADelGiamTS` |
| `AsFAGet*` | Get data | `asFAGetDMTS`, `asFAGetKHTS` |
| `AsFARpt*` | Reports | `asFARptBCTS01`, `asFARptBCPT01` |
| `AsFaCal*` | Calculations | `asFaCalDepreciation` |

**Tables liên quan:** `FADMTS`, `FADMCC`, `FA_DTS D`

[Xem chi tiết](./fa.md)

---

### 10. Costing (CO) - Tính giá thành

| Prefix | Mô tả | Examples |
|--------|-------|----------|
| `AsCOIns*` | Insert | `asCOInsDMPB`, `asCOInsDMSPCT` |
| `AsCOUpd*` | Update | `asCOUpdDMPB`, `asCOUpdHsPb` |
| `AsCODel*` | Delete | `asCODelDMPB`, `asCODelDMSPCT` |
| `AsCOGet*` | Get data | `asCOGetDMPB`, `asCOGetDMSPCT` |
| `AsCORpt*` | Reports | `asCORptGt01`, `asCoRptKHCPTT` |
| `AsCoCal*` | Calculations | `asCoCalcCost_GD`, `asCoCalcPb` |

**Tables liên quan:** `CO_DMPB`, `CO_DMSPCT`, `CO_DD`

[Xem chi tiết](./co.md)

---

### 11. HR & Payroll (Hr) - Nhân sự & Lương

| Prefix | Mô tả | Examples |
|--------|-------|----------|
| `AsHrIns*` | Insert | `asHrInsHSNS`, `asHrInsQTHopDongLD` |
| `AsHrUpd*` | Update | `asHrUpdHSNS`, `asHrUpdQTHopDongLD` |
| `AsHrDel*` | Delete | `asHrDelHSNS`, `asHrDelQTHopDongLD` |
| `AsHrGet*` | Get data | `asHrGetHSNS`, `asHrGetChamCong` |
| `AsHrRpt*` | Reports | `asHrRptPhieuLuong`, `asHrRptBangLuong01` |

**Tables liên quan:** `HR_HSNS`, `HR_QTHOPDONGLD`, `HR_CHAMCONG`

[Xem chi tiết](./hr.md)

---

### 12. Tax (Ta) - Thuế & Báo cáo thuế

| Prefix | Mô tả | Examples |
|--------|-------|----------|
| `AsTaIns*` | Insert | `asTaInsIn`, `asTaInsOut`, `asTaInsTNDN01A` |
| `AsTaUpd*` | Update | `asTaUpdIn`, `asTaUpdOut` |
| `AsTaDel*` | Delete | `asTaDelIn`, `asTaDelTNDN01A` |
| `AsTaGet*` | Get data | `asTaGetIn`, `asTaGetOut` |
| `AsTaRpt*` | Reports | `asTaRptTNDN01B` |

**Tables liên quan:** `TA_IN`, `TA_OUT`, `TA_TNDN01A`

[Xem chi tiết](./ta.md)

---

## Naming Convention

### Pattern

```
as[Module][Action][Target]
```

**Ví dụ:**

| Procedure Name | Breakdown | Meaning |
|----------------|-----------|---------|
| `asCAInsPH2` | CA + Ins + PH2 | Insert phiếu tiền mặt header |
| `asARUpdDMKH` | AR + Upd + DMKH | Update danh mục khách hàng |
| `asGLDelCT1` | GL + Del + CT1 | Delete chứng từ kế toán chi tiết |
| `asINGetTonKho` | IN + Get + TonKho | Lấy tồn kho |
| `asPORptTH01` | PO + Rpt + TH01 | Báo cáo tổng hợp mua hàng 01 |

### Action Codes

| Code | Meaning | Description |
|------|---------|-------------|
| `Ins` | Insert | Thêm mới |
| `Upd` | Update | Cập nhật |
| `Del` | Delete | Xóa |
| `Get` | Get | Lấy dữ liệu |
| `Filt` | Filter | Lọc dữ liệu |
| `Rpt` | Report | Báo cáo |
| `Chk` | Check | Kiểm tra |
| `Crt` | Create | Tạo mới (entries) |
| `Cal` | Calculate | Tính toán |
| `Post` | Post | Kết chuyển/ghi nhận |
| `Process` | Process | Xử lý chứng từ |
| `ReCal` | Recalculate | Tính lại |

---

## Sử dụng trong PHP

### Cách 1: Gọi trực tiếp qua ProcedureCaller

```php
use Diepxuan\Simba\StoredProcedures\ProcedureCaller;

$result = ProcedureCaller::call('asGetSoCt', [
    'pMa_Cty' => '001',
    'pMa_Ct'  => 'CA4',
]);
```

### Cách 2: Sử dụng class wrapper (recommended)

```php
use Diepxuan\Simba\StoredProcedures\AsGetSoCt;

$result = AsGetSoCt::call([
    'pMa_Cty' => '001',
    'pMa_Ct'  => 'CA4',
]);
```

### Cách 3: Với OUTPUT parameters

```php
use Diepxuan\Simba\StoredProcedures\AsChkUserLogin;

$result = AsChkUserLogin::call([
    'pUserName' => 'admin',
    'pPassword' => 'password',
    'pRet'      => ['type' => 'INT', 'output' => true],
]);

// Lấy giá trị output
$ret = $result->first()->Ret ?? 0;
```

---

## Best Practices

### 1. Luôn sử dụng Transaction

```php
use Illuminate\Support\Facades\DB;

DB::transaction(function () {
    // Multiple SP calls
    AsCAInsPH2::call($headerParams);
    AsCAInsCT2::call($detailParams);
    AsProcessCt::call($processParams);
});
```

### 2. Validate input trước khi gọi SP

```php
if (empty($data['ma_kh'])) {
    throw new ValidationException('Mã khách hàng không được để trống');
}

if ($data['so_tien'] <= 0) {
    throw new ValidationException('Số tiền phải lớn hơn 0');
}
```

### 3. Handle errors properly

```php
try {
    $result = AsCAInsPH2::call($params);
    
    if ($result->first()->Ret ?? 0 !== 0) {
        throw new Exception('Lỗi từ stored procedure: ' . ($result->first()->Message ?? 'Unknown error'));
    }
} catch (\Exception $e) {
    DB::rollBack();
    Log::error('Error creating receipt: ' . $e->getMessage());
    throw $e;
}
```

### 4. Use constants for magic values

```php
class SimbaConstants
{
    public const DEFAULT_COMPANY = '001';
    public const VOUCHER_TYPE_CA4 = 'CA4';
    public const VOUCHER_TYPE_AR1 = 'AR1';
    public const STATUS_PENDING = '0';
    public const STATUS_POSTED = '1';
}

// Usage
AsGetSoCt::call([
    'pMa_Cty' => SimbaConstants::DEFAULT_COMPANY,
    'pMa_Ct'  => SimbaConstants::VOUCHER_TYPE_CA4,
]);
```

---

## Performance Tips

1. **Batch operations**: Group multiple inserts/updates in one transaction
2. **Use appropriate indexes**: Ensure columns used in WHERE clauses are indexed
3. **Limit result sets**: Use pagination for large datasets
4. **Cache reference data**: Danh mục (DM) tables rarely change
5. **Avoid N+1 queries**: Use eager loading with relationships

---

## Tài liệu liên quan

- [DATABASE_ACCESS_POLICY.md](../DATABASE_ACCESS_POLICY.md)
- [PROCEDURES_OPTIMIZED.md](../PROCEDURES_OPTIMIZED.md)
- Category-specific docs: [ca.md](./ca.md), [ar.md](./ar.md), [gl.md](./gl.md), etc.

---

**Cập nhật lần cuối:** 2026-03-06
**Version:** 1.0
