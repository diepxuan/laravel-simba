# Stored Procedures Conversion

This document lists all stored procedures that have been converted to PHP classes in the `Diepxuan\Simba\StoredProcedures` namespace.

## Usage

Each class provides a static `call(array $params): mixed` method that maps to the corresponding stored procedure. Use `ProcedureCaller::call()` internally.

Example:
```php
use Diepxuan\Simba\StoredProcedures\AsGetSoCt;

$result = AsGetSoCt::call([
    'pMa_Cty' => '001',
    'pMa_ct' => 'GL1',
]);
```

## Procedures Converted

### asGL* (General Ledger)
Xem chi tiết trong [docs/procedures-gl.md](docs/procedures-gl.md). Đã chuyển đổi 20 procedures.

### asGet* (Get data)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asGetRight | AsGetRight | pUserName, pMenuID | Get user rights |
| asGetArkhInfo_SO | (pending) | | |
| asGLRptNKC06 | AsGLRptNKC06 | pMa_cty, pNgay_ct1, pNgay_ct2, pTk, pMa_Nt | |
| asGLRptBCTCCR04 | AsGLRptBCTCCR04 | pMa_Cty, pNam, pNgay_Ct1, pNgay_Ct2, pNgay_Ct01, pNgay_Ct02, pMau, pMa_nt | |
| asGLUpdMAUBCTCTMVI02a | AsGLUpdMAUBCTCTMVI02a | pMa_cty, pMau, pMa_so, pChi_tieu, pNd_chtieu, pCach_tinh, pIsPrint, pIsItalic, pTk_01, pBold | |
| asGLRptBCTCTMVI12 | AsGLRptBCTCTMVI12 | pMa_cty, pMau, pNgay1, pNgay2 | |
| asGLRptBCTCTMVI15a | AsGLRptBCTCTMVI15a | pMa_cty, pMau, pNgay1, pNgay2, pTk_01 | |
| asGLUpdBudget | AsGLUpdBudget | pStt_rec, pMa_cty, pNam, pTk, pTk_du, pTtps_no_co, pMa_bp, pMa_phi, pMa_spct, pUser, pT1, pT2, pT3, pT4, pT5, pT6, pT7, pT8, pT9, pT10, pT11, pT12 | |
| asGLRptBCT02 | AsGLRptBCT02 | pMa_cty, pNgay1, pNgay2, pThue_suat, pTk, pTk_du | |
| asGLRptBCTC02_CheckSL | AsGLRptBCTC02_CheckSL | pma_cty, pQd_cdkt, pNgay, pChiTieuCoSoLieu, pMau, pDest | |
| asGLInsMAUBCTCTmVI15c | AsGLInsMAUBCTCTmVI15c | pMa_cty, pMau, pMa_so, pChi_tieu, pNd_chtieu, pCach_tinh, pLoai_ps, pTk_01, pTk_02, pIsPrint, pIsItalic, pBold, pModify, pTien_01, pTien_02, pTien_03, pTien_04, pTien_05, pTien_06, pUserData, pGhi_chu, pNgay1, pNgay2, pcach_tinh, pTk_01, pTk_02, pModify, pModify, pUserData, pMa_cty, pMau, pMa_so, pChi_tieu, pNd_chtieu, pCach_tinh, pLoai_ps, pTk_01, pTk_02, pIsPrint, pIsItalic, pBold, pModify, pMa_cty, pMau, pNgay1, pNgay2, pMa_so, pChi_tieu, pNd_chtieu, pCach_tinh, pLoai_ps, pTk_01, pTk_02, pGhi_chu, pIsPrint, pIsItalic, pBold, pModify, pTien_01, pTien_02, pTien_03, pTien_04, pTien_05, pTien_06 | |

### asIN* (Inventory)
Xem chi tiết trong [docs/procedures-in.md](docs/procedures-in.md). Đã chuyển đổi 22 procedures.

### asHR* (Human Resources)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asHrUpdQTDanhGiaPH | AsHrUpdQTDanhGiaPH | pMa_cty, pId, pId_qtdg, pNgay_dg, pNgay_bd, pNgay_kt, pMa_nvdg, pMa_nhdg, pTrang_thai, pKet_luan, pGhi_chu, pTai_lieu, pLuser | Sửa đánh giá nhân viên |
| asINUpdDMBARCODE | AsINUpdDMBARCODE | pMa_cty, pMa_vt, pMa_vach, pKsd, pLUser | |
| asINInsPH6 | AsINInsPH6 | pMa_cty, pStt_rec, pMa_ct, pMa_gd, pNgay_ct, pNgay_lct, pSo_ct, pNgay_ctn, pSo_ctn, pMa_kh, pNguoi_gd, pDien_giai, pPN_GTB, pPX_GDD, pTk_vt_lrtd, pTk_lrtd, pT_so_luong, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pPost2gl, pPost2in, pLUser | |

### asSI* (Sales & Inventory)
Xem chi tiết trong [docs/procedures-si.md](docs/procedures-si.md). Đã chuyển đổi 23 procedures.

### asDel* (Delete)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asDelTAOUT | AsDelTAOUT | pMa_cty, pStt_rec | Delete TAOUT |

### asAR* (Accounts Receivable)
Xem chi tiết trong [docs/procedures-ar.md](docs/procedures-ar.md). Đã chuyển đổi 11 procedures.

### asPost* (Posting)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asPostPoPh4_PoCt | AsPostPoPh4_PoCt | pMa_cty, pStt_rec | Post phieu nhap chi phi. PoPh4 -> PoCt |
| asARUpdTT_SoDuSo5 | AsARUpdTT_SoDuSo5 | pMa_cty, pStt_rec_hd | |
| asARUpdDMDCKH | AsARUpdDMDCKH | pMa_cty, pMa_kh, pMa_dckh, pTen_kh, pDia_chi, pTel, pFax, pNguoi_gd, pKsd, pDc_md, pLUser | |

### asAP* (Accounts Payable)
Xem chi tiết trong [docs/procedures-ap.md](docs/procedures-ap.md). Đã chuyển đổi 18 procedures.

### asPO* (Purchase Order)
Xem chi tiết trong [docs/procedures-po.md](docs/procedures-po.md). Đã chuyển đổi 14 procedures.

### System/Utility Procedures
Xem chi tiết trong [docs/procedures-system.md](docs/procedures-system.md) và [docs/procedures-system-2.md](docs/procedures-system-2.md). Đã chuyển đổi 46 procedures.

## Notes

- Parameters with default values in SQL are given appropriate defaults in PHP (null, empty string, '0', etc.).
- Output parameters (`@pRet output`) are omitted from the PHP call; they are handled internally by the stored procedure.
- All classes return `Illuminate\Support\Collection` unless otherwise specified (some return a single value like `AsGetSoCt`).
- The connection is automatically determined via `SModel::getConnectionName()`.

### Newly Converted Procedures (Batch 2026-02-12)

#### asAP* (Accounts Payable)
| Procedure | Class | Parameters |
|-----------|-------|------------|
| asAPDelCT1 | AsAPDelCT1 | pMa_cty, pStt_rec |
| asAPDelCT3 | AsAPDelCT3 | pMa_cty, pStt_rec |
| asAPDelCT4 | AsAPDelCT4 | pMa_cty, pStt_rec |
| asAPDelPost2TT_APTT | AsAPDelPost2TT_APTT | pMa_cty, pStt_rec, pStt_rec_hd, pTien_tt, pTien_tt_nt |
| asAPDelTT | AsAPDelTT | pMa_cty, pStt_rec, pStt_rec_pt |
| asAPFilt1 | AsAPFilt1 | pKeyPh, pKeyCt |
| asAPFilt3 | AsAPFilt3 | pKeyPh, pKeyCt |
| asAPFilt4 | AsAPFilt4 | pKeyPh, pKeyCt |
| asAPInsPH3 | AsAPInsPH3 | pMa_cty, pStt_rec, pMa_ct, pSo_ct, pNgay_ct, pNgay_lct, pMa_kh, pDia_chi, pNguoi_gd, pDien_giai, pTk_co, pMa_gd, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pDu, pDu_nt, pTrang_thai, pPost2gl, pLUser |
| asAPInsPH4 | AsAPInsPH4 | pMa_cty, pMa_ct, pStt_rec, pSo_ct, pNgay_ct, pNgay_lct, pMa_nt, pTy_gia, pT_tien, pT_tien_nt, pNt_ph, pTrang_thai, pPost2gl, pLUser |
| asAPPostPh1_aptt | AsAPPostPh1_aptt | pMa_cty, pStt_rec |
| asAPPostPh1_glct | AsAPPostPh1_glct | pMa_cty, pStt_rec |
| asAPReCalAP34Relate | AsAPReCalAP34Relate | pMa_cty, pStt_rec |
| asAPRptBK01 | AsAPRptBK01 | pMa_cty, pNgay1, pNgay2, pMa_kh, pMa_vt, pMa_nhvt, pMa_kho, pMa_lo, pMa_phi, pMa_spct, pMa_bp, pMa_nt, pMa_hd, pSo_PN, pSoct1, pSoct2, pMa_plkh1, pMa_plkh2, pMa_plkh3 |
| asAPUpdPH1 | AsAPUpdPH1 | pMa_cty, pStt_rec, pMa_ct, pSo_ct, pNgay_ct, pNgay_lct, pMa_kh, pDia_chi, pNguoi_gd, pDien_giai, pTk_co, pMa_gd, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pDu, pDu_nt, pTrang_thai, pPost2gl, pLUser |
| asAPUpdPH3 | AsAPUpdPH3 | pMa_cty, pStt_rec, pMa_ct, pSo_ct, pNgay_ct, pNgay_lct, pMa_kh, pDia_chi, pNguoi_gd, pDien_giai, pTk_co, pMa_gd, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pDu, pDu_nt, pTrang_thai, pPost2gl, pLUser |
| asAPUpdPH4 | AsAPUpdPH4 | pMa_cty, pMa_ct, pStt_rec, pSo_ct, pNgay_ct, pNgay_lct, pMa_nt, pTy_gia, pT_tien, pT_tien_nt, pNt_ph, pTrang_thai, pPost2gl, pLUser |
| asAPUpdTT | AsAPUpdTT | pMa_cty, pStt_rec, pMa_ct, pNgay_ct, pSo_ct, pMa_KH, pTk_pt, pMa_nt, pTy_gia, pT_tien0, pT_tien_nt0, pT_thue, pT_thue_nt, pT_tt, pT_tt_nt, pNgay_tt, pMa_tt_po, pHan_ck, pTl_ck, pHan_tt, pLs_qh, pMa_hd, pDien_giai, pStt_rec_tt, pNgay_ct_tt, pMa_ct_tt, pSo_ct_tt, pTien_da_tt_nt, pTien_da_tt, pDu_hd, pDu_hd_nt, pLUser |
| asAPUpdTt_SoDuPo1 | AsAPUpdTt_SoDuPo1 | pMa_cty, pStt_rec |
| asAPUpdTt_SoDuPo2 | AsAPUpdTt_SoDuPo2 | pMa_cty, pStt_rec |
| asAPUpdTt_SoDuPo3 | AsAPUpdTt_SoDuPo3 | pMa_cty, pStt_rec_hd |
| asAPUpdTt_SoDuPo4 | AsAPUpdTt_SoDuPo4 | pMa_cty, pStt_rec |
| asAPUpdTt_SoDuPo6 | AsAPUpdTt_SoDuPo6 | pMa_cty, pStt_rec_hd |
| asPODelCP4 | AsPODelCP4 | pMa_cty, pStt_rec | |

#### asAR* (Accounts Receivable)
| Procedure | Class | Parameters |
|-----------|-------|------------|
| asARDelCDKH | AsARDelCDKH | pMa_cty, pMa_kh, pTk, pMa_Nt, pMa_SpCt, pMa_hd, pMa_Bp, pNam |
| asARDelCT1 | AsARDelCT1 | pMa_cty, pStt_rec |
| asARDelCT3 | AsARDelCT3 | pMa_cty, pStt_rec |
| asARDelCT4 | AsARDelCT4 | pMa_cty, pStt_rec |
| asARDelDMDCKH | AsARDelDMDCKH | pMa_cty, pMa_kh, pMa_dckh |
| asARDelDMKH | AsARDelDMKH | pMa_cty, pMa_kh |
| asARDelDMNHKH | AsARDelDMNHKH | pMa_cty, pMa_nhkh |


| asARInsDMKH | AsARInsDMKH | pMa_cty, pMa_kh, pLoai, pTen_kh, pMa_so_thue, pDia_chi, pTel, pFax, pEmail, pHome_page, pNguoi_gd, pMa_ngh, pTen_nh, pCn_nh, pSo_tk_nh, pTinh_tp_nh, pTk, pMa_plkh1, pMa_plkh2, pMa_plkh3, pMa_nhkh, pMa_tt, pMa_httt, pMa_httt_po, pGh_no, pHan_ck, pTl_ck, pHan_tt, pLs_qh, pGhi_chu, pTinh_dt_nb, pIskh, pIsncc, pIsnv, pKsd, pLUser |
| asARInsDMNHKH | AsARInsDMNHKH | pMa_cty, pMa_nhkh, pTen_nhkh, pKsd, pLUser |
| asARInsDMPLKH | AsARInsDMPLKH | pMa_cty, pMa_plkh, pTen_plkh, pLoai, pKsd, pLUser |
| asARInsPh4 | AsARInsPh4 | pMa_cty, pMa_ct, pStt_rec, pSo_ct, pNgay_ct, pNgay_lct, pNt_ph, pMa_nt, pTy_gia, pT_tien, pT_tien_nt, pTrang_thai, pUser |
| asARInsTT | AsARInsTT | pMa_cty, pStt_rec, pMa_ct, pNgay_ct, pSo_ct, pMa_KH, pTk_pt, pMa_nt, pTy_gia, pT_tien2, pT_tien_nt2, pT_thue, pT_thue_nt, pT_tt, pT_tt_nt, pTien_tt, pTien_tt_nt, pNgay_tt, pMa_tt, pHan_ck, pTl_ck, pHan_tt, pLs_qh, pMa_hd, pDien_giai, pStt_rec_tt, pNgay_ct_tt, pMa_ct_tt, pSo_ct_tt, pTien_da_tt_nt, pTien_da_tt, pDu_hd, pDu_hd_nt, pLUser |
| asARPhanBoThanhToan | AsARPhanBoThanhToan | pMa_cty, pTk_pt, pMa_kh, pNgay_ct1, pNgay_ct2 |
| asARPostPh1_artt | AsARPostPh1_artt | pMa_cty, pStt_rec |
| asARPostPh1_glct | AsARPostPh1_glct | pMa_cty, pStt_rec |
| asARReCalAR14Relate | AsARReCalAR14Relate | pMa_cty, pStt_rec |
| asARReCalAR34Relate | AsARReCalAR34Relate | pMa_cty, pStt_rec |
| asARRecalCustBalance | AsARRecalCustBalance | pMa_cty, pMa_kh, pNam |
| asARRptBCCN01 | AsARRptBCCN01 | ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt |
| asARRptBCCN011 | AsARRptBCCN011 | ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt |
| asARRptBCCN01SL | AsARRptBCCN01SL |  |
| asARRptBCCN01a | AsARRptBCCN01a | ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt |
| asARRptBCCN01a_Crys | AsARRptBCCN01a_Crys | ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt |
| asARRptBCCN02 | AsARRptBCCN02 | pMa_cty, pNgay1, pNgay2, pTk, pMa_kh, pMa_plkh1, pMa_plkh2, pMa_plkh3, pMa_nt, pGroup1, pGroup2, pGroup3 |
| asARRptBCCN03 | AsARRptBCCN03 | ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_plkh1, ma_plkh2, ma_plkh3, ma_nt |
| asARRptBCCN04 | AsARRptBCCN04 | ma_cty, Ngay1, Ngay2, Tk, pGroup, pDetail, ma_hd, ma_kh, ma_plkh1, ma_plkh2, ma_plkh3, pMa_BP, pMa_NVKD, pMa_SPCT, ma_nt |
| asARRptBCCN05 | AsARRptBCCN05 | pMa_cty, pNgay1, pNgay2, pTk, pMa_kh, pMa_nt |
| asARRptBCCN05_Crys | AsARRptBCCN05_Crys | ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt |
| asARRptBCCN06 | AsARRptBCCN06 | pMa_cty, pNgay1, pHan_Ky1, pHan_Ky2, pHan_Ky3, pMa_NCC, pMa_NhNCC, pMa_nt, pMa_TT |
| asARRptBK01 | AsARRptBK01 | pMa_cty, pNgay1, pNgay2, pMa_kh, pMa_vt, pMa_nhvt, pMa_kho, pMa_lo, pMa_bp, pMa_hd, pMa_phi, pMa_spct, pMa_nvkd, pMa_nt, pSoct1, pSoct2, pMa_plkh1, pMa_plkh2, pMa_plkh3 |
| asARRptBK02 | AsARRptBK02 | pMa_cty, pNgay1, pHan_Ky1, pHan_Ky2, pHan_Ky3, pMa_NCC, pMa_NhNCC, pSap_xep, pTat_toan, pMa_nt, pMa_TT |
| asARRptBccnHd01 | AsARRptBccnHd01 | pMa_cty, pNgay1, pHan_Ky1, pHan_Ky2, pHan_Ky3, pMa_NCC, pMa_NhNCC, pSap_xep, pTat_toan, pMa_nt, pMa_TT |
| asARRptF5BCCN | AsARRptF5BCCN | ma_cty, Tk, ma_kh, Ngay1, Ngay2, ma_nt |
| asARRptF5BCCN04 | AsARRptF5BCCN04 | Ma_cty, Tk, Ma_kh, Ma_loai, Ma, Ngay1, Ngay2, Ma_nt, pMa_hd, pMa_bp |
| asARUpdCDKH | AsARUpdCDKH | pMa_cty, pTk, pNam, pMa_Kh, pMa_SpCt, pMa_hd, pMa_Bp, pDu_No_Nt, pDu_Co_Nt, pDu_No, pDu_Co, pUser |
### asCO* (Cost)

| Procedure | Class | Parameters | Description |
|---|---|---|---|
| asCOGetDMCoBomPH | AsCOGetDMCoBomPH | pMa_cty, pma_spct | |

### asHr* (Other)

| Procedure | Class | Parameters | Description |
|---|---|---|---|
| asHrUpdDmPhanCapHanhChinh | AsHrUpdDmPhanCapHanhChinh | pMa_cty, pMa_pchc, pTen_pchc, pCap, pParent, pStt, pKsd, pLuser | |

### asDe* (Other)

| Procedure | Class | Parameters | Description |
|---|---|---|---|
| asDelOpeningBlanceInfo | AsDelOpeningBlanceInfo | pCode_name | |

### asPo* (Other)

| Procedure | Class | Parameters | Description |
|---|---|---|---|
| asPostSoPh4_glct | AsPostSoPh4_glct |  | |

### asFa* (Other)

| Procedure | Class | Parameters | Description |
|---|---|---|---|
| asFaUpdBHCC | AsFaUpdBHCC | pMa_cty, pMa_cc, pSo_luong, pNgay_giam, pUser, pID, ptk_cp, pMa_bpsd, pGt_da_Kh | |
| asFaUpdDmTs1 | AsFaUpdDmTs1 | pMa_cty, pMa_ts, pMa_ts_tgng, pDien_giai, pTang_giam, pMa_ldtg, pSo_ct, pNgay_ct, pNgay_tg, pNgay_gt_cl, pNgay_bdkh, pNgay_tkh, pNgay_giam, pTinh_kh, pSt_kh, pTl_kh, pSo_luong, pNg_gia_n1, pNg_gia_n2, pNg_gia_n3, pNg_gia_n4, pT_ng_gia, pGt_kh_n1, pGt_kh_n2, pGt_kh_n3, pGt_kh_n4, pT_gt_kh, pGt_cl_n1, pGt_cl_n2, pGt_cl_n3, pGt_cl_n4, pT_gt_cl, pKh_th_n1, pKh_th_n2, pKh_th_n3, pKh_th_n4, pT_kh_th, pSua_kh, pIs_giam, pIs_tkh, pKsd, pNg_gia_n10, pNg_gia_n20, pNg_gia_n30, pNg_gia_n40, pT_ng_gia0, pGt_kh_n10, pGt_kh_n20, pGt_kh_n30, pGt_kh_n40, pT_gt_kh0, pGt_cl_n10, pGt_cl_n20, pGt_cl_n30, pGt_cl_n40, pT_gt_cl0, pKh_th_n10, pKh_th_n20, pKh_th_n30, pKh_th_n40, pT_kh_th0, pLUser | |

### asFA* (Fixed Assets)

| Procedure | Class | Parameters | Description |
|---|---|---|---|
| asFAGetKHTS | AsFAGetKHTS | pMa_cty, pNam, pThang, pMa_ts | |
| asFAInsDMLK | AsFAInsDMLK | pMa_cty, pMa_ts, pMa_lk, pTg, pTen_lk, pDvt, pSo_luong, pGia_tri, pGhi_chu, pKsd, pLUser | |

### asAp* (Other)

| Procedure | Class | Parameters | Description |
|---|---|---|---|
| asApGetPH4 | AsApGetPH4 | pMa_cty, pStt_rec, pMa_ct, pStruct | |

### asIn* (Other)

| Procedure | Class | Parameters | Description |
|---|---|---|---|
| asInsRightgroupCompany | AsInsRightgroupCompany | pGroupName, pMa_cty, pActive | |
## Conversion Progress

- Total SQL files in `SimbaSql/dbo/StoredProcedures/`: 2031
- Files with prefix `as*`: 1831
- Converted so far: 488
- Last updated: 2026-02-12

## Newly Converted Procedures

### asSYS* (Sys)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSysCopyDatabaseCompany | AsSysCopyDatabaseCompany | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asSysCreateCompany | AsSysCreateCompany | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asSysDelAllData | AsSysDelAllData | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asSysDoiMaCongTy | AsSysDoiMaCongTy | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asSysUpdCompany | AsSysUpdCompany | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |


### asSOI* (SOI)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSOInsND51xlhdct | AsSOInsND51xlhdct | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asSOInsND51dmqdadhd | AsSOInsND51dmqdadhd | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asSOInsPH6 | AsSOInsPH6 | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |


### asPRO* (Pro)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asProcessPoPh0 | AsProcessPoPh0 | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asProcessGlPh1 | AsProcessGlPh1 | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asProcessInPh2 | AsProcessInPh2 | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asProcessApPh3 | AsProcessApPh3 | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asProcessApPh4 | AsProcessApPh4 | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asProcessCaPh1 | AsProcessCaPh1 | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asProcessInPh5 | AsProcessInPh5 | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asProcessSoPh2 | AsProcessSoPh2 | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |


### asSOR* (SOR)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSORptBK052 | AsSORptBK052 | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asSORptLaiLoHopDong | AsSORptLaiLoHopDong | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |


### asSOR* (Sor)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSortDashFrequentlyFunction | AsSortDashFrequentlyFunction | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |


### asSOD* (SOD)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSODelCT1 | AsSODelCT1 | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asSODelCT6 | AsSODelCT6 | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |
| asSODelDMPTVT | AsSODelDMPTVT | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |


### asSOC* (SOC)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSOChkRightStatusSO1 | AsSOChkRightStatusSO1 | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |


### asSOG* (SOG)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSOGetBKHDCT | AsSOGetBKHDCT | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |


### asSOU* (SoU)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSoUpdDMTD | AsSoUpdDMTD | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |


## Newly Converted Procedures

### asSYS* (sys)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSysCopyDatabaseCompany | AsSysCopyDatabaseCompany | ? | |
| asSysCreateCompany | AsSysCreateCompany | ? | |
| asSysDelAllData | AsSysDelAllData | ? | |
| asSysDoiMaCongTy | AsSysDoiMaCongTy | ? | |
| asSysUpdCompany | AsSysUpdCompany | ? | |


### asSOI* (soi)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSOInsND51xlhdct | AsSOInsND51xlhdct | ? | |
| asSOInsND51dmqdadhd | AsSOInsND51dmqdadhd | ? | |
| asSOInsPH6 | AsSOInsPH6 | ? | |


### asPRO* (pro)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asProcessPoPh0 | AsProcessPoPh0 | ? | |
| asProcessGlPh1 | AsProcessGlPh1 | ? | |
| asProcessInPh2 | AsProcessInPh2 | ? | |
| asProcessApPh3 | AsProcessApPh3 | ? | |
| asProcessApPh4 | AsProcessApPh4 | ? | |
| asProcessCaPh1 | AsProcessCaPh1 | ? | |
| asProcessInPh5 | AsProcessInPh5 | ? | |
| asProcessSoPh2 | AsProcessSoPh2 | ? | |


### asSOR* (sor)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSORptBK052 | AsSORptBK052 | ? | |
| asSortDashFrequentlyFunction | AsSortDashFrequentlyFunction | ? | |
| asSORptLaiLoHopDong | AsSORptLaiLoHopDong | ? | |


### asSOD* (sod)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSODelCT1 | AsSODelCT1 | ? | |
| asSODelCT6 | AsSODelCT6 | ? | |
| asSODelDMPTVT | AsSODelDMPTVT | ? | |


### asSOC* (soc)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSOChkRightStatusSO1 | AsSOChkRightStatusSO1 | ? | |


### asSOG* (sog)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSOGetBKHDCT | AsSOGetBKHDCT | ? | |


### asSOU* (sou)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSoUpdDMTD | AsSoUpdDMTD | ? | |


## Newly Converted Procedures

### asSYS* (sys)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSysCopyDatabaseCompany | AsSysCopyDatabaseCompany | SourceDB, DestDB, Ma_CTy | |
| asSysCreateCompany | AsSysCreateCompany | pMa_cty_cu, pMa_cty_moi | |
| asSysDelAllData | AsSysDelAllData | pMa_cty, pmau | |
| asSysDoiMaCongTy | AsSysDoiMaCongTy | pMa_cty_cu, pMa_cty_moi | |
| asSysUpdCompany | AsSysUpdCompany | pMa_cty, pTen_tcty, pTen_cty, pDia_chi, pLanguage | |


### asSOI* (soi)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSOInsND51xlhdct | AsSOInsND51xlhdct | pMa_cty, pKieu_xl, pMa_tb, pMa_chung, pTen_loai, pMau_so, pSo_seri, pTu_so, pDen_so, pSo_luong, pLien_hd, pGhi_chu, pRet | |
| asSOInsND51dmqdadhd | AsSOInsND51dmqdadhd | pMa_cty, pMa_qd, pNgay_qd, pNgay_ad, pNgay_hl, pTen_cty, pGiam_doc, pDangky_kd, pMa_bp, pCq_thue, pHt_tb, pNcc, pHdmd, pTnbp, pCdate, pCuser, pLdate, pLuser, pRet | |
| asSOInsPH6 | AsSOInsPH6 | pMa_cty, pStt_rec, pMa_ct, pSo_ct, pNgay_ct, pCa, pT_tien2, pT_ck, pT_thue, pT_tt, pLUser, pRet | |


### asPRO* (pro)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asProcessPoPh0 | AsProcessPoPh0 | pMa_cty, pStt_rec, pMode | |
| asProcessGlPh1 | AsProcessGlPh1 | pMa_cty, pStt_rec, pMode | |
| asProcessInPh2 | AsProcessInPh2 | pMa_cty, pStt_rec, pMode | |
| asProcessApPh3 | AsProcessApPh3 | pMa_cty, pStt_rec, pMode | |
| asProcessApPh4 | AsProcessApPh4 | pMa_cty, pStt_rec, pMode | |
| asProcessCaPh1 | AsProcessCaPh1 | pMa_cty, pStt_rec, pMode | |
| asProcessInPh5 | AsProcessInPh5 | pMa_cty, pStt_rec, pMode | |
| asProcessSoPh2 | AsProcessSoPh2 | pMa_cty, pStt_rec, pMode | |


### asSOR* (sor)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSORptBK052 | AsSORptBK052 | pMa_cty, pNgay1, pNgay2, pMa_kh, pMa_nhkh, pMa_vt, pMa_nhvt, pTK_VT, pMa_kho, pMa_bp, pMa_nvkd, pMa_nt, pMa_hd, pMa_Nhhd, pSo_DH, pSoct1, pSoct2, pMa_plkh1, pMa_plkh2, pMa_plkh3, pMa_plvt1, pMa_plvt2, pMa_plvt3 | |
| asSortDashFrequentlyFunction | AsSortDashFrequentlyFunction | pMenuIdSource, pSttTarget, pUserName, pDashID, pRet | |
| asSORptLaiLoHopDong | AsSORptLaiLoHopDong | ? | |


### asSOD* (sod)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSODelCT1 | AsSODelCT1 | pMa_cty, pStt_rec, pRet | |
| asSODelCT6 | AsSODelCT6 | pMa_cty, pStt_rec, pRet | |
| asSODelDMPTVT | AsSODelDMPTVT | pMa_cty, pMa_pt, pRet | |


### asSOC* (soc)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSOChkRightStatusSO1 | AsSOChkRightStatusSO1 | pMa_cty, pStt_rec, pLanguage | |


### asSOG* (sog)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSOGetBKHDCT | AsSOGetBKHDCT | pMa_cty | |


### asSOU* (sou)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSoUpdDMTD | AsSoUpdDMTD | pMa_cty, pMa_td, pTen_td, pKm, pKsd, pLUser, pRet | |


### asPO* (Purchase Order)
| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asPOInsPH3 | AsPOInsPH3 | pMa_cty, pStt_rec, pMa_ct, pMa_gd, pMau_hd, pMa_kh, pDia_chi, pNguoi_gd, pMa_httt, pTk_pt, pDien_giai, pGhi_chu, pSo_seri, pSo_ct, pNgay_ct, pNgay_lct, pKht_tain, pNgay_pn, pSo_pn, pNgay_hd, pSo_hd, pMa_tt_po, pHan_ck, pTl_ck, pHan_tt, pLs_qh, pMa_nt, pTy_gia, pT_tien_nt0, pT_tien0, pT_thue_nk_nt, pT_thue_nk, pT_thue_ttdb_nt, pT_thue_ttdb, pT_cp_nt, pT_cp, pT_tien_nt, pT_tien, pT_thue_nt, pT_thue, pTl_ck_hd, pT_ck, pT_ck_nt, pT_tt, pT_tt_nt, pT_so_luong, pSua_tien, pSua_thue, pSua_thue_nk, pSua_thue_ttdb, pSua_tt, pTao_tu_pn, pTao_tu_dh, pTs_nk, pTs_ttdb, pPost2gl, pTrang_thai, pLUser | Insert record into POPH3 table |

| asARUpdDMKH | AsARUpdDMKH | pMa_cty, pMa_kh, pLoai, pTen_kh, pMa_so_thue, pDia_chi, pTel, pFax, pEmail, pHome_page, pNguoi_gd, pMa_ngh, pTen_nh, pCn_nh, pSo_tk_nh, pTinh_tp_nh, pTk, pMa_plkh1, pMa_plkh2, pMa_plkh3, pMa_nhkh, pMa_tt, pMa_httt, pMa_httt_po, pGh_no, pHan_ck, pTl_ck, pHan_tt, pLs_qh, pGhi_chu, pTinh_dt_nb, pIskh, pIsncc, pIsnv, pKsd, pLUser |  |
| asARUpdDMNHKH | AsARUpdDMNHKH | pMa_cty, pMa_nhkh, pTen_nhkh, pKsd, pLUser |  |
| asARUpdDMPLKH | AsARUpdDMPLKH | pMa_cty, pMa_plkh, pTen_plkh, pLoai, pKsd, pLUser |  |
| asARUpdNgHKH | AsARUpdNgHKH | pId_cn, pMa_cty, pMa_kh, pMa_nh, pSo_tk, pTen_nh, pChi_nhanh, pTinh_tp, pTel, pFax, pEmail, pNguoi_gd, pKSd, pLUser |  |
| asARUpdPH1 | AsARUpdPH1 | pMa_cty, pStt_rec, pMa_ct, pSo_ct, pStt_rec_dh, pSo_dh, pNgay_ct, pNgay_lct, pMa_kh, pDia_chi, pNguoi_gd, pDien_giai, pTk_no, pMa_gd, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pDu, pDu_nt, pTrang_thai, pPost2gl, pLUser |  |
| asARUpdPH3 | AsARUpdPH3 | pMa_cty, pStt_rec, pMa_ct, pSo_ct, pNgay_ct, pNgay_lct, pMa_kh, pDia_chi, pNguoi_gd, pDien_giai, pTk_no, pMa_gd, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pDu, pDu_nt, pTrang_thai, pPost2gl, pLUser |  |
| asARUpdPh4 | AsARUpdPh4 | pMa_cty, pMa_ct, pStt_rec, pSo_ct, pNgay_ct, pNgay_lct, pNt_ph, pMa_nt, pTy_gia, pT_tien, pT_tien_nt, pTrang_thai, pLUser |  |
| asARUpdTT | AsARUpdTT | pMa_cty, pStt_rec, pMa_ct, pNgay_ct, pSo_ct, pMa_KH, pTk_pt, pMa_nt, pTy_gia, pT_tien2, pT_tien_nt2, pT_thue, pT_thue_nt, pT_tt, pT_tt_nt, pTien_tt, pTien_tt_nt, pNgay_tt, pMa_tt, pHan_ck, pTl_ck, pHan_tt, pLs_qh, pMa_hd, pDien_giai, pStt_rec_tt, pNgay_ct_tt, pMa_ct_tt, pSo_ct_tt, pTien_da_tt_nt, pTien_da_tt, pDu_hd, pDu_hd_nt, pLUser |  |
| asARUpdTT_SoDuAr1 | AsARUpdTT_SoDuAr1 | pMa_cty, pStt_rec |  |
| asARUpdTT_SoDuSo1 | AsARUpdTT_SoDuSo1 | pMa_cty, pStt_rec_dh |  |
| asARUpdTT_SoDuSo3 | AsARUpdTT_SoDuSo3 | pMa_cty, pStt_rec_hd |  |
| asApDelPH1 | AsApDelPH1 | pMa_cty, pStt_rec, pLUser |  |
| asApDelPH3 | AsApDelPH3 | pMa_cty, pStt_rec, pLUser |  |
| asApDelPH4 | AsApDelPH4 | pMa_cty, pStt_rec, pLUser |  |
| asApGetCt4 | AsApGetCt4 | pMa_cty, pStt_rec, pStruct |  |
| asApGetPH1 | AsApGetPH1 | pMa_cty, pStt_rec, pMa_ct, pStruct |  |
| asArUpdTT_SoDuAr3 | AsArUpdTT_SoDuAr3 | pMa_cty, pStt_rec |  |
| asCACalLaiKU | AsCACalLaiKU | pMa_cty, pThang, pNam, pMa_ct, pMa_ku, pUser |  |
| asCADelCDKU | AsCADelCDKU | pMa_cty, pNam, pMa_ku |  |
| asCADelCT1 | AsCADelCT1 | pMa_cty, pStt_rec |  |
| asCADelCT2 | AsCADelCT2 | pMa_cty, pStt_rec |  |
| asCADelCT3 | AsCADelCT3 | pMa_cty, pStt_rec |  |
| asCADelDMKU | AsCADelDMKU | pMa_cty, pMa_ku |  |
| asCADelLaiKU | AsCADelLaiKU | pMa_cty, pThang, pNam, pMa_ku |  |
| asCADelPH2 | AsCADelPH2 | pMa_cty, pStt_rec, pLUser |  |
| asCADelPH3 | AsCADelPH3 | pMa_cty, pStt_rec, pLUser |  |
| asCADelPostLaiKU | AsCADelPostLaiKU | pMa_cty, pThang, pNam, pMa_ct, pMa_ku |  |
| asCADelTTHU | AsCADelTTHU | pMa_cty, pStt_rec |  |
| asCAFilt1 | AsCAFilt1 | pKeyPh, pKeyCt |  |
| asCAFilt2 | AsCAFilt2 | pKeyPh, pKeyCt |  |


### Newly Converted Procedures (Batch 2026-02-12 subagent-2)

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asARUpdDMKH | AsARUpdDMKH |  |  |
| asARUpdDMNHKH | AsARUpdDMNHKH |  |  |
| asARUpdDMPLKH | AsARUpdDMPLKH |  |  |
| asARUpdNgHKH | AsARUpdNgHKH |  |  |
| asARUpdPH1 | AsARUpdPH1 |  |  |
| asARUpdPH3 | AsARUpdPH3 |  |  |
| asARUpdPh4 | AsARUpdPh4 |  |  |
| asARUpdTT | AsARUpdTT |  |  |
| asARUpdTT_SoDuAr1 | AsARUpdTT_SoDuAr1 |  |  |
| asARUpdTT_SoDuSo1 | AsARUpdTT_SoDuSo1 |  |  |
| asARUpdTT_SoDuSo3 | AsARUpdTT_SoDuSo3 |  |  |
| asApDelPH1 | AsApDelPH1 |  |  |
| asApDelPH3 | AsApDelPH3 |  |  |
| asApDelPH4 | AsApDelPH4 |  |  |
| asApGetCt4 | AsApGetCt4 |  |  |
| asApGetPH1 | AsApGetPH1 |  |  |
| asArUpdTT_SoDuAr3 | AsArUpdTT_SoDuAr3 |  |  |
| asCACalLaiKU | AsCACalLaiKU |  |  |
| asCADelCDKU | AsCADelCDKU |  |  |
| asCADelCT1 | AsCADelCT1 |  |  |
| asCADelCT2 | AsCADelCT2 |  |  |
| asCADelCT3 | AsCADelCT3 |  |  |
| asCADelDMKU | AsCADelDMKU |  |  |
| asCADelLaiKU | AsCADelLaiKU |  |  |
| asCADelPH2 | AsCADelPH2 |  |  |
| asCADelPH3 | AsCADelPH3 |  |  |
| asCADelPostLaiKU | AsCADelPostLaiKU |  |  |
| asCADelTTHU | AsCADelTTHU |  |  |
| asCAFilt1 | AsCAFilt1 |  |  |
| asCAFilt2 | AsCAFilt2 |  |  |

## System / Utility Procedures (sp*, usp*, fn*, vw*, z*)

| Object | Class | Category | Parameters | Description |
|--------|-------|----------|------------|-------------|
| avDependencies | AvDependencies | Views | N/A | |
| avIndex | AvIndex | Views | N/A | |
| concat_TEST | Concat_TEST | Views | N/A | |
| avIndexStatus | AvIndexStatus | Views | N/A | |
| zGenStruc | ZGenStruc | StoredProcedures | tbl | |
| spUtil_ReIndexDatabase_UpdateStats | SpUtil_ReIndexDatabase_UpdateStats | StoredProcedures | pMa_cty | |
| zasIIGetCT6D | ZasIIGetCT6D | StoredProcedures | pMa_cty, pStt_rec | |
| z_asSIGetReportInfo | Z_asSIGetReportInfo | StoredProcedures | pMa_cty | |
| z_asCORptBCGT01 | Z_asCORptBCGT01 | StoredProcedures | pMa_cty, pThang, pNam, plstMa_spct | |
| z_asCoUpdDmHsPb1 | Z_asCoUpdDmHsPb1 | StoredProcedures | pMa_cty, pThang, pNam, pMa_sp, pTk, pTen_sp, pHeso_621, pHeso_622, pHeso_td, pThs_621, pThs_622, pThs_td, pRet | |
| z_asSiGetDmCp | Z_asSiGetDmCp | StoredProcedures | pMa_cty, pMa_cp, pStruct | |
| zCopyDatabase | ZCopyDatabase | StoredProcedures | sourcedb, destdb | |
| z_spupdglmauBcTc05 | Z_spupdglmauBcTc05 | StoredProcedures | pma_cty, pmau, pma_so, pstt, pchi_tieu, pcach_tinh, ptk_no, ptk_co, pbold, pin_ck, pma_so_ctu, pRet | |
| z_TestVnField | Z_TestVnField | StoredProcedures | pMa_cty | |
| z_zzasARRptBBBTCN01 | Z_zzasARRptBBBTCN01 | StoredProcedures | ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt | |
| zasINDelCT7 | ZasINDelCT7 | StoredProcedures | pMa_cty, pStt_rec, pStt_rec0, pRet | |
| zUpdExtendedPropery | ZUpdExtendedPropery | StoredProcedures | tblName, colName, property | |
| zasSOUpdCT3 | ZasSOUpdCT3 | StoredProcedures | pMa_cty, pStt_rec, pStt_rec0, pStt_rec_dh, pStt_rec0_dh, pStt_rec_px, pStt_rec0_px, pSo_dh, pSo_px, pMa_kho, pMa_vt, pTen_vt, pDvt, pSo_luong, pSo_luong_qd, pGia_nt2, pGia2, pTien_nt2, pTien2, pTl_ck, pTien_ck_nt, pTien_ck, pCk_ds, pCk_ds_nt, pTs_gtgt, pThue_gtgt_nt, pThue_gtgt, pTt_nt, pTt, pMa_nvkd, pMa_bp, pMa_hd, pMa_phi, pMa_vitri, pMa_lo, pMa_spct, pTk_pt, pTk_thue, pTk_dt, pTk_gv, pTk_vt, pTk_ck, pKhuyen_mai, pTra_ck, pSl_xuat, pSl_xuat_qd, pRet | |
| zasSOUpdCT4 | ZasSOUpdCT4 | StoredProcedures | pMa_cty, pStt_rec, pStt_rec0, pStt_rec_dh, pStt_rec0_dh, pStt_rec_px, pStt_rec0_px, pStt_rec_hd, pStt_rec0_hd, pSo_dh, pSo_px, pSo_hd, pMa_kho, pMa_vt, pTen_vt, pDvt, pSo_luong, pSo_luong_qd, pGia_nt2, pGia2, pTien_nt2, pTien2, pTl_ck, pTien_ck_nt, pTien_ck, pCk_ds, pCk_ds_nt, pTs_gtgt, pThue_gtgt_nt, pThue_gtgt, pTt_nt, pTt, pMa_nvkd, pMa_bp, pMa_hd, pMa_phi, pMa_vitri, pMa_lo, pMa_spct, pTk_pt, pTk_thue, pTk_tl, pTk_gv, pTk_vt, pTk_ck, pGia_nt, pGia, pTien_nt, pTien, pKhuyen_mai, pTra_ck, pRet | |
| SiGetDmProduct | SiGetDmProduct | StoredProcedures | pMa_cty | |
| z_testtttttt | Z_testtttttt | StoredProcedures | pMa_cty, pMa_bp, pStruct | |
| z_asARInsDMNgHKH | Z_asARInsDMNgHKH | StoredProcedures | pId_cn, pMa_cty, pMa_kh, pMa_nh, pSo_tk, pTen_nh, pChi_nhanh, pTinh_tp, pTel, pFax, pEmail, pNguoi_gd, pKsd, pLUser, pRet | |
| z_asSIRptLogCt | Z_asSIRptLogCt | StoredProcedures | pMa_cty, pUser, pAction, pNgay1, pNgay2 | |
| z_asCOCXoaButToanPhanBo | Z_asCOCXoaButToanPhanBo | StoredProcedures | pMa_cty, pMa_ct, pNgay_ct | |
| z_asSiDelDmCp | Z_asSiDelDmCp | StoredProcedures | pMa_cty, pMa_cp, pRet | |


### Newly Converted Procedures (Batch 2026-02-12 AR)

Đã chuyển đổi thêm 28 stored procedures nhóm AR (Accounts Receivable). Xem chi tiết trong [docs/procedures-ar.md](docs/procedures-ar.md).





### Newly Converted Procedures (Batch 2026-02-12 subagent)

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asPOInsPH3 | AsPOInsPH3 | pMa_cty, pStt_rec, pMa_ct, pMa_gd, pMau_hd, pMa_kh, pDia_chi, pNguoi_gd, pMa_httt, pTk_pt, pDien_giai, pGhi_chu, pSo_seri, pSo_ct, pNgay_ct, pNgay_lct, pKht_tain, pNgay_pn, pSo_pn, pNgay_hd, pSo_hd, pMa_tt_po, pHan_ck, pTl_ck, pHan_tt, pLs_qh, pMa_nt, pTy_gia, pT_tien_nt0, pT_tien0, pT_thue_nk_nt, pT_thue_nk, pT_thue_ttdb_nt, pT_thue_ttdb, pT_cp_nt, pT_cp, pT_tien_nt, pT_tien, pT_thue_nt, pT_thue, pTl_ck_hd, pT_ck, pT_ck_nt, pT_tt, pT_tt_nt, pT_so_luong, pSua_tien, pSua_thue, pSua_thue_nk, pSua_thue_ttdb, pSua_tt, pTao_tu_pn, pTao_tu_dh, pTs_nk, pTs_ttdb, pPost2gl, pTrang_thai, pLUser |  |
| asPostInPh2_glct | AsPostInPh2_glct | pMa_cty, pStt_rec |  |
| asFAGetDMBPSD | AsFAGetDMBPSD | pMa_cty, pMa_bpsd, pStruct |  |
| asGetMaPlvt1ByMaVt | AsGetMaPlvt1ByMaVt |  |  |
| asINGetDMKHO | AsINGetDMKHO |  |  |
| asGLRptNKC012 | AsGLRptNKC012 | pMa_cty, pNgay_Ct1, pNgay_Ct2, pTk, pMa_Nt, pStt_dong_nkc |  |
| asGLUpdMAUBCTCTMVI08b | AsGLUpdMAUBCTCTMVI08b | pMa_cty, pMau, pMa_so, pChi_tieu, pNd_chtieu, pCach_tinh, pTk_01, pIsPrint, pIsItalic, pBold, pRet |  |
| asPostPoPh6_apTt | AsPostPoPh6_apTt | pMa_cty, pStt_rec |  |
| asSIGetDMBP | AsSIGetDMBP | pMa_cty, pMa_bp, pStruct |  |
| asARRptBK03 | AsARRptBK03 | pMa_cty, pNgay1, pNgay2, pMa_gd, pSoct1, pSoct2, pMa_kh, pMa_nhkh, pMa_plkh1, pMa_plkh2, pMa_plkh3, pSap_xep, pTat_toan, pMa_NT |  |
| asGLRptCheckCashFlow | AsGLRptCheckCashFlow | pMa_cty, pNgay_ct1, pNgay_ct2 |  |
| asFARptSoSD | AsFARptSoSD | pMa_cty, pNgay1, pNgay2, pMa_tscd, pMa_cc, pMa_bpsd, pLoai |  |
| asHrInsDmNhomDanhGiaCT | AsHrInsDmNhomDanhGiaCT | pMa_cty, pMa_nhdg, pMa_tcdg, pTen_tcdg, pDiem_toi_da |  |
| asGetMenuIdByCommand | AsGetMenuIdByCommand | pCmd |  |
| asDelVoucherInfo | AsDelVoucherInfo | pVoucher_code |  |
| asHrGetDTKhoa | AsHrGetDTKhoa | pMa_cty, pMa_kdt |  |
| asINInsPH1 | AsINInsPH1 | pMa_cty, pStt_rec, pMa_ct, pMa_gd, pNgay_ct, pNgay_lct, pSo_ct, pMa_kh, pTen_kh, pDia_chi, pNguoi_gd, pDien_giai, pMa_nx, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pT_so_luong, pPN_GTB, pTrang_thai, pPost2gl, pPost2in, pGia_thanh, pLUser |  |
| asPORptBCPT021 | AsPORptBCPT021 | pMa_cty, pngay1, pNgay2, pPOct1, pPOct2, pMa_kh, pMa_nhkh, pMa_plkh1, pMa_plkh2, pMa_plkh3, pMa_hd, pMa_nhhd, pMa_NT, pMa_vt, pMa_nhvt, pMa_plvt1, pMa_plvt2, pMa_plvt3, pma_tt_po, pStatus |  |
| asSAUpdDmCongDoan | AsSAUpdDmCongDoan | pMa_cty, pMa_congdoan, pMa_sanpham, pTen_cd, pKsd, pLUser |  |
| asCOUpdDMCoBomPH | AsCOUpdDMCoBomPH | pMa_cty, pMa_spct, pNgay1, pNgay2, pDon_gia_luong, pGhi_chu, pUser |  |
| asINDelCt3 | AsINDelCt3 | pMa_cty, pStt_rec |  |
| asPOInsPH4 | AsPOInsPH4 | pMa_cty, pStt_rec, pMa_ct, pMa_kh, pDia_chi, pNguoi_gd, pMa_httt, pTk_pt, pDien_giai, pSo_seri, pSo_ct, pNgay_ct, pNgay_lct, pSua_tt, pMa_tt_po, pHan_ck, pTl_ck, pHan_tt, pLs_qh, pMa_nt, pTy_gia, pT_tien_nt0, pT_tien0, pT_cp_nt, pT_cp, pT_thue_nt, pT_thue, pT_tt, pT_tt_nt, pT_so_luong, pPost2gl, pTrang_thai, pKht_tain, pLUser |  |
| asGLInsBudget | AsGLInsBudget | pStt_rec, pMa_cty, pNam, pTk, pTk_du, pTtps_no_co, pMa_bp, pMa_phi, pMa_spct, pUser, pT1, pT2, pT3, pT4, pT5, pT6, pT7, pT8, pT9, pT10, pT11, pT12, pRet |  |
| asINGetDMBARCODE | AsINGetDMBARCODE | pMa_cty, pMa_vt |  |
| asGLCR1GetMaSo_MaBang | AsGLCR1GetMaSo_MaBang | pMa_cty, pTk |  |
| asGLInsMAUBCTCTMVI15a | AsGLInsMAUBCTCTMVI15a | pMa_cty, pMau, pMa_so, pChi_tieu, pNd_chtieu, pcach_tinh, pTk_01, pIsPrint, pIsItalic, pBold, pModify, pgia_tri_dk, pton_dk, pps_tang, pps_giam, pgia_tri_ck, pton_ck, pUserData, pGhi_chu, pNgay1, pNgay2 |  |
| asHrGetDmKhacDs | AsHrGetDmKhacDs | pMa_cty, pCode_name |  |
| asGLInsCdTk | AsGLInsCdTk | pMa_cty, pTk, pNam, pMa_nt, pDu_no_nt00, pDu_co_nt00, pDu_no00, pDu_co00, pDu_no_nt, pDu_co_nt, pDu_no, pDu_co, pLUser |  |
| asPODelCT4 | AsPODelCT4 | pMa_cty, pStt_rec |  |
| asGLInsMAUBCTCTMVI13 | AsGLInsMAUBCTCTMVI13 | pMa_cty, pMau, pma_so, pChi_tieu, pNd_chtieu, pCach_tinh, pTk_01, pIsPrint, pIsItalic, pBold, pModify, pcuoi_ky, pDau_ky, pUserData, pGhi_chu, pNgay1, pNgay2 |  |

## System / Utility Procedures (sp*, usp*, fn*, vw*, z*)

| Object | Class | Category | Parameters | Description |
|--------|-------|----------|------------|-------------|
| avDependencies | AvDependencies | Views | N/A | |
| avIndex | AvIndex | Views | N/A | |
| concat_TEST | Concat_TEST | Views | N/A | |
| avIndexStatus | AvIndexStatus | Views | N/A | |
| zGenStruc | ZGenStruc | StoredProcedures | tbl | |
| spUtil_ReIndexDatabase_UpdateStats | SpUtil_ReIndexDatabase_UpdateStats | StoredProcedures | pMa_cty | |
| zasIIGetCT6D | ZasIIGetCT6D | StoredProcedures | pMa_cty, pStt_rec | |
| z_asSIGetReportInfo | Z_asSIGetReportInfo | StoredProcedures | pMa_cty | |
| z_asCORptBCGT01 | Z_asCORptBCGT01 | StoredProcedures | pMa_cty, pThang, pNam, plstMa_spct | |
| z_asCoUpdDmHsPb1 | Z_asCoUpdDmHsPb1 | StoredProcedures | pMa_cty, pThang, pNam, pMa_sp, pTk, pTen_sp, pHeso_621, pHeso_622, pHeso_td, pThs_621, pThs_622, pThs_td, pRet | |
| z_asSiGetDmCp | Z_asSiGetDmCp | StoredProcedures | pMa_cty, pMa_cp, pStruct | |
| zCopyDatabase | ZCopyDatabase | StoredProcedures | sourcedb, destdb | |
| z_spupdglmauBcTc05 | Z_spupdglmauBcTc05 | StoredProcedures | pma_cty, pmau, pma_so, pstt, pchi_tieu, pcach_tinh, ptk_no, ptk_co, pbold, pin_ck, pma_so_ctu, pRet | |
| z_TestVnField | Z_TestVnField | StoredProcedures | pMa_cty | |
| z_zzasARRptBBBTCN01 | Z_zzasARRptBBBTCN01 | StoredProcedures | ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt | |
| zasINDelCT7 | ZasINDelCT7 | StoredProcedures | pMa_cty, pStt_rec, pStt_rec0, pRet | |
| zUpdExtendedPropery | ZUpdExtendedPropery | StoredProcedures | tblName, colName, property | |
| zasSOUpdCT3 | ZasSOUpdCT3 | StoredProcedures | pMa_cty, pStt_rec, pStt_rec0, pStt_rec_dh, pStt_rec0_dh, pStt_rec_px, pStt_rec0_px, pSo_dh, pSo_px, pMa_kho, pMa_vt, pTen_vt, pDvt, pSo_luong, pSo_luong_qd, pGia_nt2, pGia2, pTien_nt2, pTien2, pTl_ck, pTien_ck_nt, pTien_ck, pCk_ds, pCk_ds_nt, pTs_gtgt, pThue_gtgt_nt, pThue_gtgt, pTt_nt, pTt, pMa_nvkd, pMa_bp, pMa_hd, pMa_phi, pMa_vitri, pMa_lo, pMa_spct, pTk_pt, pTk_thue, pTk_dt, pTk_gv, pTk_vt, pTk_ck, pKhuyen_mai, pTra_ck, pSl_xuat, pSl_xuat_qd, pRet | |
| zasSOUpdCT4 | ZasSOUpdCT4 | StoredProcedures | pMa_cty, pStt_rec, pStt_rec0, pStt_rec_dh, pStt_rec0_dh, pStt_rec_px, pStt_rec0_px, pStt_rec_hd, pStt_rec0_hd, pSo_dh, pSo_px, pSo_hd, pMa_kho, pMa_vt, pTen_vt, pDvt, pSo_luong, pSo_luong_qd, pGia_nt2, pGia2, pTien_nt2, pTien2, pTl_ck, pTien_ck_nt, pTien_ck, pCk_ds, pCk_ds_nt, pTs_gtgt, pThue_gtgt_nt, pThue_gtgt, pTt_nt, pTt, pMa_nvkd, pMa_bp, pMa_hd, pMa_phi, pMa_vitri, pMa_lo, pMa_spct, pTk_pt, pTk_thue, pTk_tl, pTk_gv, pTk_vt, pTk_ck, pGia_nt, pGia, pTien_nt, pTien, pKhuyen_mai, pTra_ck, pRet | |
| SiGetDmProduct | SiGetDmProduct | StoredProcedures | pMa_cty | |
| z_testtttttt | Z_testtttttt | StoredProcedures | pMa_cty, pMa_bp, pStruct | |
| z_asARInsDMNgHKH | Z_asARInsDMNgHKH | StoredProcedures | pId_cn, pMa_cty, pMa_kh, pMa_nh, pSo_tk, pTen_nh, pChi_nhanh, pTinh_tp, pTel, pFax, pEmail, pNguoi_gd, pKsd, pLUser, pRet | |
| z_asSIRptLogCt | Z_asSIRptLogCt | StoredProcedures | pMa_cty, pUser, pAction, pNgay1, pNgay2 | |
| z_asCOCXoaButToanPhanBo | Z_asCOCXoaButToanPhanBo | StoredProcedures | pMa_cty, pMa_ct, pNgay_ct | |
| z_asSiDelDmCp | Z_asSiDelDmCp | StoredProcedures | pMa_cty, pMa_cp, pRet | |

### Newly Converted Procedures (Batch 2026-02-12 System)

Đã chuyển đổi thêm 25 stored procedures hệ thống (sp*, usp*, fn*, vw*, z*). Xem chi tiết trong [docs/procedures-system-6.md](docs/procedures-system-6.md).

### Newly Converted Procedures (Batch 2026-02-12 subagent-53)

| Procedure | Class | Parameters |
|-----------|-------|------------|
| asCARptTMNH05 | AsCARptTMNH05 |  |
| asCARptTMNH032 | AsCARptTMNH032 | pNgay2 |
| asCARptTMNH04 | AsCARptTMNH04 |  |
| asCARptTMNH02 | AsCARptTMNH02 |  |
| asCARptTMNH01a | AsCARptTMNH01a | ptk, pNgay_Ct1, pMa_Nt |
| asCARptTMNH03 | AsCARptTMNH03 | pNgay2 |
| asCARptTMNH01 | AsCARptTMNH01 |  |
| asCARecalCA2 | AsCARecalCA2 |  |
| asCAInsTTHU | AsCAInsTTHU |  |
| asCAInsPH3 | AsCAInsPH3 |  |
| asCAInsPH2 | AsCAInsPH2 |  |
| asCAInsPH1 | AsCAInsPH1 |  |
| asCAInsDMKU | AsCAInsDMKU |  |
| asCAInsLaiKu | AsCAInsLaiKu |  |
| asCAInsCT3 | AsCAInsCT3 |  |
| asCAInsCT2 | AsCAInsCT2 |  |
| asCAInsCT1 | AsCAInsCT1 |  |
| asCAGetTTHU | AsCAGetTTHU |  |
| asCAInsCDKU | AsCAInsCDKU |  |
| asCAGetPH2 | AsCAGetPH2 |  |
| asCAGetPH3 | AsCAGetPH3 |  |
| asCAGetPH1 | AsCAGetPH1 |  |
| asCAGetDMKU | AsCAGetDMKU |  |
| asCAGetCT2 | AsCAGetCT2 |  |
| asCAGetLaiKu | AsCAGetLaiKu |  |
| asCAGetCT3 | AsCAGetCT3 |  |
| asCAGetCT1 | AsCAGetCT1 |  |
| asCAGetCDKU | AsCAGetCDKU |  |
| asCAFilt3 | AsCAFilt3 |  |
| asCTBCTC_SB | AsCTBCTC_SB |  |
### Newly Converted Procedures (Batch 2026-02-12 subagent-55)

| Procedure | Class | Parameters |
|-----------|-------|------------|
| AsSIInsDMHTTT | AsSIInsDMHTTT |  |
| AsHrGetTDDeThi | AsHrGetTDDeThi |  |
| AsChkCodeExistsBeforeChange | AsChkCodeExistsBeforeChange |  |
| AsINFilt3 | AsINFilt3 |  |
| AsPostInPh5_FaCc | AsPostInPh5_FaCc |  |
| AsCARptTMNH07 | AsCARptTMNH07 |  |
| AsProcessSoPh5 | AsProcessSoPh5 |  |
| AsINRptBKX01 | AsINRptBKX01 |  |
| AsGetTygia | AsGetTygia |  |
| AsGLUpdDMDGTG | AsGLUpdDMDGTG |  |
| AsDelreportDrilldownInfo | AsDelreportDrilldownInfo |  |
| AsGLUpdMauBs | AsGLUpdMauBs |  |
| AsCoRptKHCPTT | AsCoRptKHCPTT |  |
| AsPOGetPH5 | AsPOGetPH5 |  |
| AsGetInforNVL | AsGetInforNVL |  |
| AsGetGroupRightMenu | AsGetGroupRightMenu |  |
| AsPOChkRightStatusPO3 | AsPOChkRightStatusPO3 |  |
| AsInsDictionaryComplexResx | AsInsDictionaryComplexResx |  |
| AsGLRptNKCTSoCai | AsGLRptNKCTSoCai |  |
| AsSiDelUpdateLogCT | AsSiDelUpdateLogCT |  |
| AsPostGlPh1_glct_1n | AsPostGlPh1_glct_1n |  |
| AsSIUpdDMHTTT | AsSIUpdDMHTTT |  |
| AsUpdSysVar | AsUpdSysVar |  |
| AsINRptCTVT02_crys | AsINRptCTVT02_crys |  |
| AsHrInsChamCongKhac | AsHrInsChamCongKhac |  |
| AsSIDelDMBP | AsSIDelDMBP |  |
| AsPORptF5TH02 | AsPORptF5TH02 |  |
| AsGetReportDrilldownInfo | AsGetReportDrilldownInfo |  |
| AsHrDelQTNghiCheDo | AsHrDelQTNghiCheDo |  |
| AsInGetSetup | AsInGetSetup |  |

## Newly Converted Procedures (Batch 2026-02-12 subagent-56)

Converted 26 stored procedures. See details in [docs/procedures-batch-56.md](docs/procedures-batch-56.md).

| Procedure | Class | Parameters |
|-----------|-------|------------|
|-----------|-------|------------|-------------|
| asInPostTienVon2Glct | AsInPostTienVon2Glct | pMa_cty, pStt_rec, pMa_ct | |
| asSIGetTableColumnDefine | AsSIGetTableColumnDefine | pTableName | |
| asHrDelQTDanhGiaCT | AsHrDelQTDanhGiaCT | pMa_cty, pId, pId_qtdg, pMa_tcdg, pRet | |
| asUpdateDictResX | AsUpdateDictResX | pcode_name, plang_id, pformated_col_list | |
| asINRptF5CD05 | AsINRptF5CD05 | pMa_cty, pMa_vt, pMa_kho, pMa_vitri, pTk_vt, pMa_nhvt, pNgay, pMa_nt, pdvt, pMa_lo | |
| asPOUpdDMTT | AsPOUpdDMTT | pMa_cty, pma_tt_po, pMo_ta, pHan_ck, pTl_ck, pHan_tt, pLs_qh, pkSd, pLUser, pRet | |
| asHrUpdDmThangBangLuong | AsHrUpdDmThangBangLuong | pMa_cty, pMa_tbl, pTen_tbl, pKsd, pLuser, pRet | |
| asHrInsQTKhenThuong | AsHrInsQTKhenThuong | pMa_cty, pId, pId_qtktkl, pLoai_ktkl, pMa_ktkl, pNoi_dung, pGhi_chu, pTai_lieu, pCuser, pRet | |
| asPostPoPh5_taOut | AsPostPoPh5_taOut | pMa_Cty, pStt_rec | |
| asINRptCD01_ViTri | AsINRptCD01_ViTri | pMa_cty, pNgay1, pNgay2, pLoai_bc, pMa_vt, pTk_vt, pMa_nhvt, pMa_kho, pMa_vitri, pma_plvt1, pma_plvt2, pma_plvt3, group1, group2, group3, pDVT, pPSDC, pNgoai_te | |
| asSOGetND51xlhdct | AsSOGetND51xlhdct | pMa_cty, pKieu_xl, pMa_tb | |
| asSORptBCPT011 | AsSORptBCPT011 | pMa_cty, pNgay1, pNgay2, pSoct1, pSoct2, pMa_kh, pMa_nhkh, pMa_plkh1, pMa_plkh2, pMa_plkh3, pMa_hd, pMa_nhhd, pMa_NT, pMa_vt, pMa_nhvt, pMa_plvt1, pMa_plvt2, pMa_plvt3, pMa_bp, pMa_nvkd, pMa_TT, pStatus | |
| asCODelCalcPb | AsCODelCalcPb | pMa_cty, pNgay1, pNgay2, pId, pMa_ct, pUser | |
| asPOGetPH2 | AsPOGetPH2 | pMa_cty, pStt_rec, pMa_ct, pStruct | |
| asPOChkRightStatusPO4 | AsPOChkRightStatusPO4 | pMa_cty, pStt_rec, pLanguage | |
| asPostArPh3_glct | AsPostArPh3_glct | pMa_cty, pStt_rec | |
| asPOLookupSO14PO0 | AsPOLookupSO14PO0 | pMa_cty, pKey | |
| asPostApPh4_glct | AsPostApPh4_glct | pma_cty, pstt_rec | |
| asHrDelDmKhac | AsHrDelDmKhac | pMa_cty, pCode_name, pMa, pRet | |
| asGLInsDMDGTG | AsGLInsDMDGTG | pMa_cty, pLoai_dg, pTk_dgtg, pStt, pTk_lai_cltg, pTk_lo_cltg, pTk_cltg_cn, pTen_bt, pDg_kh, pDg_bp, pDg_hd, pDg_spct, pDg_phi, pSo_ct, pKsd, pLUser, pRet | |
| asHrUpdDmNhomDanhGiaCT | AsHrUpdDmNhomDanhGiaCT | pMa_cty, pMa_nhdg, pMa_tcdg, pTen_tcdg, pDiem_toi_da, pRet | |
| asPOLookupPn4Px | AsPOLookupPn4Px | pMa_cty, pKey | |
| asCOUpdDMSPCT | AsCOUpdDMSPCT | pMa_cty, pMa_spct, pTen_spct, pNgay_kc, pNgay_kt, pDu_toan, pDu_toan_NT, pDv_tc, pGhi_chu, pDvt, pMa_nhspct, pSan_pham, pKsd, pLUser, pRet | |
| asInsVoucherResx | AsInsVoucherResx | pVoucher_code, pLanguage, pPh_formated_col_list, pCt_formated_col_list, pDescription, pRet | |
| asGetMenuBar | AsGetMenuBar | pLanguage | |

### Newly Converted Procedures (Batch 2026-02-12 subagent-59)

Converted 17 stored procedures (asCA* and asCO*). 

| Procedure | Class | Parameters |
|-----------|-------|------------|
| asCARptTMNH06 | AsCARptTMNH06 | pMa_cty, pNgay_ct1, pNgay_ct2, pTk, pMa_Ku, pMa_Nt |
| asCARptTMNH08 | AsCARptTMNH08 | pMa_Cty, pTk, pNgay_Ct1, pNgay_Ct2, pMa_Nt |
| asCAUpdCDKU | AsCAUpdCDKU | pMa_cty, pNam, pMa_ku, pTk, pMa_nt, pNgay_ku, pNgay_tt, pDa_vay, pDa_vay_nt, pDa_tt, pDa_tt_nt, pLUser |
| asCAUpdDMKU | AsCAUpdDMKU | pMa_cty, pMa_ku, pTen_ku, pSo_ku, pNgay_vay, pNgay_ky, pThoi_han, pTinh_theo, pPhuong_phap, pKy_tt_goc, pKy_tt_lai, pNgay_dh, pMa_hd, pMa_nt, pTien_nt, pTien, pLai_suat, pLs_qh, pTk_vay, pTk_cp, pTk_cp_pt, pGhi_chu, pKsd, pLUser |
| asCAUpdLaiKu | AsCAUpdLaiKu | pMa_cty, pNgay_tra, pMa_ku, pNam, pThang, pTien_lai_tk, pTien_lai_tk_nt, pTien_goc_tk, pTien_goc_tk_nt, pTien_lai_qh, pTien_lai_qh_nt, pTien_goc_qh, pTien_goc_qh_nt, pSua_lai, pSua_goc, pLUser |
| asCAUpdPH1 | AsCAUpdPH1 | pMa_cty, pStt_rec, pMa_ct, pSo_ct, pNgay_ct, pNgay_lct, pMa_kh, pDia_chi, pNguoi_gd, pDien_giai, pTk_no, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pTrang_thai, pPost2gl, pLUser |
| asCAUpdPH3 | AsCAUpdPH3 | pMa_cty, pStt_rec, pMa_ct, pSo_ct, pNgay_ct, pNgay_lct, pKht_tain, pMa_kh, pDia_chi, pNguoi_gd, pDien_giai, pTk_co, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pT_Thue, pT_Tt_nt, pT_Tt, pTrang_thai, pPost2gl, pLUser |
| asCAUpdTTHU | AsCAUpdTTHU | pMa_cty, pStt_rec, pMa_ct, pNgay_ct, pSo_ct, pMa_ct_tt, pStt_rec_tt, pNgay_ct_tt, pSo_ct_tt, pMa_KH, pTk_tu, pMa_nt, pTy_gia, pTien_pc, pTien_pc_nt, pTien_da_tt, pTien_da_tt_nt, pTat_toan, pDien_giai, pLUser |
| asCOCalcHsPb | AsCOCalcHsPb | pMa_cty, pNgay1, pNgay2, pId, pPb_theo, pHs_theo |
| asCOCalcPb | AsCOCalcPb | pMa_cty, pNgay1, pNgay2, pId, pMa_ct, pUser |
| asCODelDMCoBomCT | AsCODelDMCoBomCT | pMa_cty, pMa_spct, pMa_vt |
| asCODelDMNHSPCT | AsCODelDMNHSPCT | pMa_cty, pMa_nhspct |
| asCODelDMPB | AsCODelDMPB | pMa_cty, pId, pTk_pb, pMa_ct |
| asCODelDMPB1 | AsCODelDMPB1 | pMa_cty, pId, pTk_nhan_pb, pMa_ct |
| asCODelDMSPCT | AsCODelDMSPCT | pMa_cty, pMa_spct |
| asCODelPostCp2GlCt | AsCODelPostCp2GlCt | pMa_cty, pMa_ct, pNam, pThang |
| asCODelUpdateCost | AsCODelUpdateCost | pMa_cty, pNgay1, pNgay2, pTk154 |
