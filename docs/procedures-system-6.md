# System Procedures (sp*, usp*, fn*, vw*, z*) - Batch 6

This document lists system stored procedures, functions, views, and utility objects converted on 2026-02-12.

| Object | Class | Category | Parameters | Description |
|--------|-------|----------|------------|-------------|
| zasINInsPH7 | ZasINInsPH7 | StoredProcedures | pMa_cty, pStt_rec, pMa_ct, pMa_gd, pNgay_ct, pNgay_lct, pSo_ct, pMa_kh, pTen_kh, pDia_chi, pNguoi_gd, pDien_giai, pMa_nx, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pTrang_thai, pPost2gl, pPost2in, pLUser, pRet | Insert into INPH7 |
| z_asCOUpdDmHsPb2 | Z_asCOUpdDmHsPb2 | StoredProcedures | pMa_cty, pThang, pNam, pMa_sp, pTk, pTen_sp, pHs_621_ck, pHs_622_ck, pHs_td_ck, pHs_621_dd, pHs_622_dd, pHs_td_dd, pHs_621_lh, pHs_622_lh, pHs_td_lh, pHs_621_ls, pHs_622_ls, pHs_td_ls, pThs_621, pThs_621_ck, pThs_622_ck, pThs_td_ck, pThs_621_dd, pThs_622_dd, pThs_td_dd, pThs_621_lh, pThs_622_lh, pThs_td_lh, pThs_621_ls, pThs_622_ls, pThs_td_ls, pMa_pb, pRet | Update CODmHsPb2 |
| zGenSP_GetCol2Select | ZGenSP_GetCol2Select | StoredProcedures | (none) | Load columns of glct table for select |
| z_asCoGetDmPbGt2 | Z_asCoGetDmPbGt2 | StoredProcedures | pMa_cty, pStt, pStruct | Get CoDmPbGt2 |
| z_asGetVoucherInfo | Z_asGetVoucherInfo | StoredProcedures | (none) | Get VoucherInfo |
| z_assiInsDmCp | Z_assiInsDmCp | StoredProcedures | pMa_cty, pMa_cp, pTen_cp, pKsd, pLUser, pRet | Insert into siDmCp |
| z_asCODelDmHsPb2 | Z_asCODelDmHsPb2 | StoredProcedures | pMa_cty, pThang, pNam, pMa_sp, pRet | Delete CODmHsPb2 |
| z_asSIdelReportresx | Z_asSIdelReportresx | StoredProcedures | pmenuid, pma_mau, pRet | Delete Reportresx |
| z_asGetDictionaryResx | Z_asGetDictionaryResx | StoredProcedures | pCode_name, pLanguage | Get DictionaryResx |
| zzz_asGLRptBCTCCDTb03 | Zzz_asGLRptBCTCCDTb03 | StoredProcedures | pMa_cty, pNgay1, pNgay2, pTk_xl, pTk_tb, pTk_bt, pTk_ql, pTk_tv, pTk_khac, pMa_spct | Báo cáo chủ đầu tư |
| z_asCOUpdateCost1 | Z_asCOUpdateCost1 | StoredProcedures | pMa_cty, pNgay_ct1, pNgay_ct2 | Cập nhật giá thành phẩm |
| z_asINRptCD01_Old | Z_asINRptCD01_Old | StoredProcedures | pMa_cty, pNgay1, pNgay2, pLoai_bc, pMa_vt, pTk_vt, pMa_nhvt, pMa_kho, pMa_vitri, pma_plvt1, pma_plvt2, pma_plvt3, group1, group2, group3, pDVT, pPSDC, pNgoai_te | Tổng hợp nhập xuất tồn (old) |
| z_asGet_col_list | Z_asGet_col_list | StoredProcedures | pCode_name | Get column list for a table |
| zChk_param_len | ZChk_param_len | StoredProcedures | pField_name | Check parameter length |
| zzz_VertCDT | Zzz_VertCDT | StoredProcedures | (none) | Convert số liệu báo cáo chủ đầu tư |
| z_asUpdVoucherInfo | Z_asUpdVoucherInfo | StoredProcedures | pvoucher_code, pph_table_name, pct_table_name, pcp_table_name, pmenuid, pph_extra_edit_cotrol_list, psearch_class_name, pview_class_name, pprint_class_name, pma_nt_default, pph_carry_field_list, pct_carry_field_list, pph_print_field_list, prow_per_page, pnumber_of_copy, phas_cp, phas_tain, phas_taout, pcopy_enabled, pnxt, pdescription, pRet | Update VoucherInfo |
| z_asDelDictionaryInfo | Z_asDelDictionaryInfo | StoredProcedures | pcode_name, pRet | Delete DictionaryInfo |
| z_asCOGetDMBOM | Z_asCOGetDMBOM | StoredProcedures | pMa_cty, pStt_Rec_Lenh, pMa_spct, pStruct | Get CODMBOM |
| z_asTotal | Z_asTotal | StoredProcedures | table, fSum, fGroup, sFilterSum | Tính tổng theo điều kiện cho một bảng |
| z_asARGetDMNgHKH | Z_asARGetDMNgHKH | StoredProcedures | pId_cn, pMa_cty, pMa_kh, pMa_nh, pStruct | Get ardmNgHKh |
| z_asSIDELDMCN | Z_asSIDELDMCN | StoredProcedures | pmenuid, pmoduleid, pbar, pbarenUS, pdllName, pcommand, pcode_name, preport, pbasicright, pform, popt, ppar1, ppar2, ppar3, ppar4, ppar5, ppar6, ppar7, ppar8, ppicture1, ppicture2, pdeveloper, pmaintainer, pstt, pused, prowid, pactive, pRet | Delete menu record |
| z_spGetglmauBcTc05 | Z_spGetglmauBcTc05 | StoredProcedures | pma_cty | Get glmauBcTc05 |
| z_asSORptBK012 | Z_asSORptBK012 | StoredProcedures | pMa_cty, pNgay1, pNgay2, pTrang_thai, pMa_kh, pMa_nhkh, pMa_vt, pMa_nhvt, pMa_kho, pMa_bp, pMa_nvkd, pMa_hd, pMa_nhhd, pMa_nt, pSoct1, pSoct2, pMa_plkh1, pMa_plkh2, pMa_plkh3, pMa_plvt1, pMa_plvt2, pMa_plvt3 | Bảng kê đơn đặt hàng - phần thông tin chung |
| z_asCOInsDMBOM | Z_asCOInsDMBOM | StoredProcedures | pMa_cty, pMa_lenh, pMa_spct, pCo_sp, pMa_vt, pCo_vt, pTen_vt, pDvt, pHe_so, pSo_luong, pGhi_chu, pSl_hs, pRet | Insert CODMBOM |
| z_asCoInsDmPbGt2 | Z_asCoInsDmPbGt2 | StoredProcedures | pMa_cty, pStt, pTen_bt, pSo_ct, pTk_no, pTk_co, pTk_lay_hs, pMa_pb, pRet | Insert CoDmPbGt2 |
