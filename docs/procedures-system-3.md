# System Procedures (sp*, usp*, fn*, vw*, z*)

This document lists system stored procedures, functions, views, and utility objects.

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
