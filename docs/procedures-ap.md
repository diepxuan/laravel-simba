# Accounts Payable (AP) Stored Procedures

Các stored procedures nhóm Accounts Payable (asAP*) đã được chuyển đổi sang PHP classes.

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asApGetPH3 | AsApGetPH3 | pMa_cty, pStt_rec, pMa_ct, pStruct | Get APPH3 data |
| asAPInsPost2TT_APTT | AsAPInsPost2TT_APTT | pMa_cty, pStt_rec, pMa_ct, pSo_ct, pNgay_ct, pNgay_lct, pMa_kh, pDia_chi, pNguoi_gd, pDien_giai, pTk_co, pMa_gd, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pDu, pDu_nt, pTrang_thai, pPost2gl, pLUser, pRet (output) | Insert APTT from posting |
| asAPGetCT1 | AsAPGetCT1 | pMa_cty, pStt_rec, pStruct | Get APCT1 data |
| asAPGetCT3 | AsAPGetCT3 | pMa_cty, pStt_rec, pStruct | Get APCT3 data |
| asAPGetMaCT | AsAPGetMaCT | pMa_cty | Tìm kiếm mã loại chứng từ được phân bổ |
| asAPGetPO4AP1 | AsAPGetPO4AP1 | pKey | Lấy hóa đơn cho phiếu chi tiền hàng |
| asAPGetPO4AP3 | AsAPGetPO4AP3 | pKey | Lấy hóa đơn cho phiếu thu tiền bán hàng |
| asAPGetPO1AP1 | AsAPGetPO1AP1 | pKey | Lấy hóa đơn cho phiếu thu tiền bán hàng (PO1) |
| asAPGetPost2TT | AsAPGetPost2TT | pMa_cty, pLoai_ct, pSo1, pSo2, pNgay1, pNgay2, pMa_kh, pTk, pDien_giai | Tìm kiếm chứng từ cần phân bổ cho hóa đơn mua hàng |
| asAPGetPost2TT_APTT | AsAPGetPost2TT_APTT | pMa_cty, pStt_rec, pTk_pt, pMa_kh, pNgay_ct, pLoai | Tìm kiếm chứng từ phân bổ |
| asAPGetTT | AsAPGetTT | pMa_cty, pMa_ct | Get APTT data |
| asAPInsCT1 | AsAPInsCT1 | pMa_cty, pStt_rec, pStt_rec0, pStt_rec_hd, pStt_rec_dh, pSo_hd, pNgay_hd, pSo_dh, pNgay_dh, pMa_nt, pTien_tt, pTien_tt_nt, pTien_tt_qd, pTt_hd, pTt_hd_nt, pDu_hd, pDu_hd_nt, pTk, pDien_giai, pMa_lo, pMa_bp, pMa_hd, pMa_phi, pMa_spct, pRet (output) | Insert APCT1 |
| asAPInsCT3 | AsAPInsCT3 | pMa_cty, pStt_rec, pStt_rec0, pStt_rec_hd, pStt_rec_dh, pSo_hd, pNgay_hd, pMa_nt, pTien_tt, pTien_tt_nt, pTien_tt_qd, pTt_hd, pTt_hd_nt, pTk, pDien_giai, pMa_lo, pMa_bp, pMa_hd, pMa_phi, pMa_spct, pRet (output) | Insert APCT3 |
| asAPInsCT4 | AsAPInsCT4 | pMa_cty, pStt_rec, pStt_rec0, pTk, pMa_kh, pDien_giai, pMa_nt, pTy_gia, pPs_co, pPs_co_nt, pPs_no, pPs_no_nt, pNh_dk, pMa_lo, pMa_bp, pMa_hd, pMa_phi, pMa_spct, pRet (output) | Insert APCT4 |
| asAPInsPH1 | AsAPInsPH1 | pMa_cty, pStt_rec, pMa_ct, pSo_ct, pStt_rec_dh, pSo_dh, pNgay_ct, pNgay_lct, pMa_kh, pDia_chi, pNguoi_gd, pDien_giai, pTk_co, pMa_gd, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pDu, pDu_nt, pTrang_thai, pPost2gl, pLUser, pRet (output) | Insert APPH1 |
| asAPInsTT | AsAPInsTT | pMa_cty, pStt_rec, pMa_ct, pNgay_ct, pSo_ct, pMa_kh, pTk_pt, pMa_nt, pTy_gia, pT_tien0, pT_tien_nt0, pT_thue, pT_thue_nt, pT_tt, pT_tt_nt, pNgay_tt, pMa_tt_po, pHan_ck, pTl_ck, pHan_tt, pLs_qh, pMa_hd, pDien_giai, pStt_rec_tt, pNgay_ct_tt, pMa_ct_tt, pSo_ct_tt, pTien_da_tt_nt, pTien_da_tt, pDu_hd, pDu_hd_nt, pLUser, pRet (output) | Insert APTT |
| asAPReCalAP14Relate | AsAPReCalAP14Relate | pMa_cty, pStt_rec | Recalculate AP1/AP4 related balances |
| asAPRptBK02 | AsAPRptBK02 | pMa_cty, pNgay1, pHan_Ky1, pHan_Ky2, pHan_Ky3, pMa_NCC, pMa_NhNCC, pSap_xep, pTat_toan, pMa_nt | Bảng kê hóa đơn theo hạn thanh toán |
| asAPRptBK03 | AsAPRptBK03 | pMa_cty, pNgay1, pNgay2, pMa_gd, pSoct1, pSoct2, pMa_kh, pMa_nhkh, pMa_plkh1, pMa_plkh2, pMa_plkh3, pSap_xep, pTat_toan, pMa_NT | Bảng kê phiếu chi thanh toán tiền hàng |

**Tổng số:** 41 procedures đã chuyển đổi.

> Lưu ý: Các tham số có hậu tố `(output)` không cần truyền vào khi gọi PHP class, hệ thống tự xử lý.

## Các procedures chưa chuyển đổi

Còn lại khoảng 23 procedures asAP* chưa được chuyển đổi. Danh sách các file SQL còn lại:

- asAPDelCT1.sql
- asAPDelTT.sql
- asAPFilt3.sql
- asAPFilt4.sql
- asAPUpdPH1.sql
- asAPUpdPH3.sql
- asAPUpdPH4.sql
- asAPUpdTt_SoDuPo1.sql
- asAPUpdTt_SoDuPo2.sql
- asAPUpdTt_SoDuPo3.sql
- asAPUpdTt_SoDuPo4.sql
- asAPUpdTt_SoDuPo6.sql
- ... (còn tiếp)


## asApGetPH4

- **Class:** AsApGetPH4
- **Parameters:** pMa_cty, pStt_rec, pMa_ct, pStruct
- **Description:** 
- **SQL File:** `asApGetPH4.sql`
