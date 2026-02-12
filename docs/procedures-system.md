# System/Utility Procedures Conversion

This document lists all system/utility stored procedures, functions, and views that have been converted to PHP classes in the `Diepxuan\Simba\StoredProcedures` namespace.

## Views

| View | Class | Parameters | Description |
|------|-------|------------|-------------|
| avDependencies | AvDependencies | none | Get dependencies of all objects |
| avIndex | AvIndex | none | Get index information |
| concat_TEST | ConcatTest | none | Test concatenation view |
| avIndexStatus | AvIndexStatus | none | Get index status |

## System Stored Procedures

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| spUtil_ReIndexDatabase_UpdateStats | SpUtilReIndexDatabaseUpdateStats | none | Reindex all tables and update statistics |
| zGenStruc | ZGenStruc | tbl (nvarchar) | Get structure of a table |
| z_spupdglmauBcTc05 | ZSpupdglmauBcTc05 | pma_cty, pmau, pma_so, pstt, pchi_tieu, pcach_tinh, ptk_no, ptk_co, pbold, pin_ck, pma_so_ctu | Update glmauBcTc05 record |
| z_TestVnField | ZTestVnField | none | Test Vietnamese field display |
| zUpdExtendedPropery | ZUpdExtendedPropery | tblName, colName, property, val | Update extended property of a column |
| SiGetDmProduct | SiGetDmProduct | none | Get product list |
| z_testtttttt | ZTesttttttt | pMa_cty, pMa_bp (default null), pStruct (default '0') | Test procedure calling asSIGetDMBP |
| zGenSP_GetCol2Select | ZGenSPGetCol2Select | none | Load columns of glct table for select |
| zInsExtendedPropery | ZInsExtendedPropery | tblName, colName, property, val | Insert extended property for a column |
| afChkExistsCodeDMKC | AfChkExistsCodeDMKC | pMa_cty, pMa_ct, pTk, pTk_du | Check if auto‑transfer accounting entry exists |
| zGenSelect | ZGenSelect | tbl, alias (default '') | Generate SELECT statement for a table |
| zChk_param_len | ZChkParamLen | pField_name | Check parameter length consistency |
| zzz_VertCDT | ZzzVertCDT | none | Convert investment report data (commented) |
| zGenSpChungTu | ZGenSpChungTu | tbl, out (default 'SCREEN') | Generate CRUD stored procedures for a document table |
| z_spGetglmauBcTc05 | ZSpGetglmauBcTc05 | pma_cty (default null) | Get glmauBcTc05 records |
| zGenStruc1 | ZGenStruc1 | tbl (default null) | Get table structure with descriptions |


## asPostInPh2_glct

- **Class:** AsPostInPh2_glct
- **Parameters:** pMa_cty, pStt_rec
- **Description:** 
- **SQL File:** `asPostInPh2_glct.sql`

## asGetMaPlvt1ByMaVt

- **Class:** AsGetMaPlvt1ByMaVt
- **Parameters:** 
- **Description:** 
- **SQL File:** `asGetMaPlvt1ByMaVt.sql`

## asPostPoPh6_apTt

- **Class:** AsPostPoPh6_apTt
- **Parameters:** pMa_cty, pStt_rec
- **Description:** 
- **SQL File:** `asPostPoPh6_apTt.sql`

## asHrInsDmNhomDanhGiaCT

- **Class:** AsHrInsDmNhomDanhGiaCT
- **Parameters:** pMa_cty, pMa_nhdg, pMa_tcdg, pTen_tcdg, pDiem_toi_da
- **Description:** 
- **SQL File:** `asHrInsDmNhomDanhGiaCT.sql`

## asGetMenuIdByCommand

- **Class:** AsGetMenuIdByCommand
- **Parameters:** pCmd
- **Description:** 
- **SQL File:** `asGetMenuIdByCommand.sql`

## asDelVoucherInfo

- **Class:** AsDelVoucherInfo
- **Parameters:** pVoucher_code
- **Description:** 
- **SQL File:** `asDelVoucherInfo.sql`

## asHrGetDTKhoa

- **Class:** AsHrGetDTKhoa
- **Parameters:** pMa_cty, pMa_kdt
- **Description:** 
- **SQL File:** `asHrGetDTKhoa.sql`

## asHrGetDmKhacDs

- **Class:** AsHrGetDmKhacDs
- **Parameters:** pMa_cty, pCode_name
- **Description:** 
- **SQL File:** `asHrGetDmKhacDs.sql`

## Notes

- Parameters with default values in SQL are given appropriate defaults in PHP (null, empty string, '0', etc.).
- Output parameters (`@pRet output`) are omitted from the PHP call; they are handled internally by the stored procedure.
- All classes return `Illuminate\Support\Collection` unless otherwise specified.
- The connection is automatically determined via `SModel::getConnectionName()`.

## Usage Example

```php
use Diepxuan\Simba\StoredProcedures\ZGenStruc;

$result = ZGenStruc::call([
    'tbl' => 'glct',
]);
```

## Conversion Progress

- System procedures converted: 20
- Last updated: 2026-02-12

## asHrUpdDmPhanCapHanhChinh

- **Class:** AsHrUpdDmPhanCapHanhChinh
- **Parameters:** pMa_cty, pMa_pchc, pTen_pchc, pCap, pParent, pStt, pKsd, pLuser
- **Description:** 
- **SQL File:** `asHrUpdDmPhanCapHanhChinh.sql`

## asDelOpeningBlanceInfo

- **Class:** AsDelOpeningBlanceInfo
- **Parameters:** pCode_name
- **Description:** 
- **SQL File:** `asDelOpeningBlanceInfo.sql`

## asFaUpdBHCC

- **Class:** AsFaUpdBHCC
- **Parameters:** pMa_cty, pMa_cc, pSo_luong, pNgay_giam, pUser, pID, ptk_cp, pMa_bpsd, pGt_da_Kh
- **Description:** 
- **SQL File:** `asFaUpdBHCC.sql`
