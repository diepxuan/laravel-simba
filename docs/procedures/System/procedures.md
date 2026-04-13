# System/Utility Procedures

Tổng hợp các system stored procedures, functions, views và utility objects.

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
| zGenStruc1 | ZGenStruc1 | tbl (default null) | Get table structure with descriptions |
| GetFolderUpdate | GetFolderUpdate | purl (nvarchar), pupd (int) | Update or retrieve updateserver column in sisetup |
| XoaTable_Liennk | XoaTableLiennk | none | Drop tables with name like '%BCTCTM%' |
| afChkCodeExists | AfChkCodeExists | pMa_Cty, pTable_name, pCode_name, pCode_value | Check if a code exists in a table (returns int) |
| afChkExistsCodeDict | AfChkExistsCodeDict | pMa_cty, pTable_name, pCode_name, pCode_value | Check existence of a code across dictionary tables (returns int) |
| afChkExistsCodeDictOnTable | AfChkExistsCodeDictOnTable | pMa_cty, pTable_name, pCode_name, pCode_value, pTblName (output) | Check existence and return table name with description |
| sysBackupAsData | SysBackupAsData | none | Backup asData database to device asData_srv |
| sysGrant | SysGrant | stm (nvarchar), obj (nvarchar), user (nvarchar) | Grant permissions on objects to a user |
| sysRevoke | SysRevoke | stm (nvarchar), obj (nvarchar), user (nvarchar) | Revoke permissions from a user |
| zAsAddYear2NgayCt | ZAsAddYear2NgayCt | pMa_cty, increment | Add/subtract years to NGAY_CT and related date fields |
| zCheckSmSysTable | ZCheckSmSysTable | pMa_cty | Check system table records for a company |
| zChkDatabaseDesign | ZChkDatabaseDesign | none | Check database design inconsistencies (column length, defaults) |
| zChk_Var_Len | ZChkVarLen | pTable | Check variable length usage in procedures |
| zCopyDatabase | ZCopyDatabase | sourcedb, destdb | Copy data between databases (excluding system tables) |
| zCreateCompany | ZCreateCompany | ma_cty, ma_cty_mau | Create a new company by copying setup data |
| zDeleteCompany | ZDeleteCompany | ma_cty | Delete all data for a given company |
| zDropExtendedPropery | ZDropExtendedPropery | tblName, colName, property | Drop an extended property from a column |
| zFindColumns | ZFindColumns | pColumnName | Find columns matching a pattern across tables |
| zGenExits | ZGenExits | pTablename, pFieldName | Generate function afExist{FieldName} to check existence |
| zGenExits_new | ZGenExitsNew | pTablename, pFieldName | Similar to zGenExits but prints to screen |
| zGenFieldDescription | ZGenFieldDescription | table_name | Get extended property descriptions for columns of a table |
| zGenSP_GetAllSP | ZGenSPGetAllSP | none | Get all stored procedure names |
| zGenSp | ZGenSp | tbl, out (default 'SCREEN') | Generate CRUD stored procedures for a table (asIns, asUpd, asGet, asDel) |
| zGenSpAll | ZGenSpAll | table | Generate CRUD procedures for all tables (or one) |
| zGenSpCt | ZGenSpCt | tbl, out (default 'SCREEN') | Generate CRUD stored procedures for a document table (with module prefix) |
| zGenSpDanhMuc | ZGenSpDanhMuc | tbl, out (default 'SCREEN') | Generate CRUD stored procedures for a master data table (with dictionary info) |
| zGenTest | ZGenTest | sptest, spinsert (default '') | Generate test call for a stored procedure |
| zasIIGetCT6D | ZasIIGetCT6D | pMa_cty, pStt_rec | |
| z_asSIGetReportInfo | Z_asSIGetReportInfo | pMa_cty | |
| z_asCORptBCGT01 | Z_asCORptBCGT01 | pMa_cty, pThang, pNam, plstMa_spct | |
| z_asCoUpdDmHsPb1 | Z_asCoUpdDmHsPb1 | pMa_cty, pThang, pNam, pMa_sp, pTk, pTen_sp, pHeso_621, pHeso_622, pHeso_td, pThs_621, pThs_622, pThs_td, pRet | |
| z_asSiGetDmCp | Z_asSiGetDmCp | pMa_cty, pMa_cp, pStruct | |
| z_spupdglmauBcTc05 | Z_spupdglmauBcTc05 | pma_cty, pmau, pma_so, pstt, pchi_tieu, pcach_tinh, ptk_no, ptk_co, pbold, pin_ck, pma_so_ctu, pRet | |
| z_TestVnField | Z_TestVnField | pMa_cty | |
| z_zzasARRptBBBTCN01 | Z_zzasARRptBBBTCN01 | ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt | |
| zasINDelCT7 | ZasINDelCT7 | pMa_cty, pStt_rec, pStt_rec0, pRet | |
| z_asARInsDMNgHKH | Z_asARInsDMNgHKH | pId_cn, pMa_cty, pMa_kh, pMa_nh, pSo_tk, pTen_nh, pChi_nhanh, pTinh_tp, pTel, pFax, pEmail, pNguoi_gd, pKsd, pLUser, pRet | |
| z_asSIRptLogCt | Z_asSIRptLogCt | pMa_cty, pUser, pAction, pNgay1, pNgay2 | |
| z_asCOCXoaButToanPhanBo | Z_asCOCXoaButToanPhanBo | pMa_cty, pMa_ct, pNgay_ct | |
| z_asSiDelDmCp | Z_asSiDelDmCp | pMa_cty, pMa_cp, pRet | |
| zasINInsPH7 | ZasINInsPH7 | pMa_cty, pStt_rec, pMa_ct, pMa_gd, pNgay_ct, pNgay_lct, pSo_ct, pMa_kh, pTen_kh, pDia_chi, pNguoi_gd, pDien_giai, pMa_nx, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pTrang_thai, pPost2gl, pPost2in, pLUser, pRet | Insert into INPH7 |
| z_asCOUpdDmHsPb2 | Z_asCOUpdDmHsPb2 | pMa_cty, pThang, pNam, pMa_sp, pTk, pTen_sp, pHs_621_ck, pHs_622_ck, pHs_td_ck, pHs_621_dd, pHs_622_dd, pHs_td_dd, pHs_621_lh, pHs_622_lh, pHs_td_lh, pHs_621_ls, pHs_622_ls, pHs_td_ls, pThs_621, pThs_621_ck, pThs_622_ck, pThs_td_ck, pThs_621_dd, pThs_622_dd, pThs_td_dd, pThs_621_lh, pThs_622_lh, pThs_td_lh, pThs_621_ls, pThs_622_ls, pThs_td_ls, pMa_pb, pRet | Update CODmHsPb2 |
| z_asCoGetDmPbGt2 | Z_asCoGetDmPbGt2 | pMa_cty, pStt, pStruct | Get CoDmPbGt2 |
| z_asGetVoucherInfo | Z_asGetVoucherInfo | none | Get VoucherInfo |
| z_assiInsDmCp | Z_assiInsDmCp | pMa_cty, pMa_cp, pTen_cp, pKsd, pLUser, pRet | Insert into siDmCp |
| z_asCODelDmHsPb2 | Z_asCODelDmHsPb2 | pMa_cty, pThang, pNam, pMa_sp, pRet | Delete CODmHsPb2 |
| z_asSIdelReportresx | Z_asSIdelReportresx | pmenuid, pma_mau, pRet | Delete Reportresx |
| z_asGetDictionaryResx | Z_asGetDictionaryResx | pCode_name, pLanguage | Get DictionaryResx |
| zzz_asGLRptBCTCCDTb03 | Zzz_asGLRptBCTCCDTb03 | pMa_cty, pNgay1, pNgay2, pTk_xl, pTk_tb, pTk_bt, pTk_ql, pTk_tv, pTk_khac, pMa_spct | Báo cáo chủ đầu tư |
| z_asCOUpdateCost1 | Z_asCOUpdateCost1 | pMa_cty, pNgay_ct1, pNgay_ct2 | Cập nhật giá thành phẩm |
| z_asINRptCD01_Old | Z_asINRptCD01_Old | pMa_cty, pNgay1, pNgay2, pLoai_bc, pMa_vt, pTk_vt, pMa_nhvt, pMa_kho, pMa_vitri, pma_plvt1, pma_plvt2, pma_plvt3, group1, group2, group3, pDVT, pPSDC, pNgoai_te | Tổng hợp nhập xuất tồn (old) |
| z_asGet_col_list | Z_asGetColList

---

## Related Documentation

| Document | Description |
|----------|-------------|
| [Module Overview](./README.md) | Tổng quan module |

## Cross-Module References

| Module | Relationship |
|--------|--------------|
| [SI](../SI/) | System module |

---

*End of System Procedures Documentation*
