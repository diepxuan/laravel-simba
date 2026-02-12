# Accounts Receivable (AR) Stored Procedures

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asARDelDMPLKH | `AsARDelDMPLKH` | `pMa_cty, pMa_plkh, pLoai` | Xóa ARDelDMPLKH |
| asARDelNgHKH | `AsARDelNgHKH` | `pId_cn` | Xóa ARDelNgHKH |
| asARDelPH1 | `AsARDelPH1` | `pMa_cty, pStt_rec, pLUser` | Xóa ARDelPH1 |
| asARDelPH3 | `AsARDelPH3` | `pMa_cty, pStt_rec, pLUser` | Xóa ARDelPH3 |
| asARDelPH4 | `AsARDelPH4` | `pMa_cty, pStt_rec, pLUser` | Xóa ARDelPH4 |
| asARDelPost2TT_ARTT | `AsARDelPost2TT_ARTT` | `pMa_cty, pStt_rec, pStt_rec_hd, pTien_tt, pTien_tt_nt` | Xóa ARDelPost2TT_ARTT |
| asARDelTT | `AsARDelTT` | `pMa_cty, pStt_rec, pStt_rec_pt` | Xóa ARDelTT |
| asARFilt1 | `AsARFilt1` | `pKeyPh (nvarchar(1000)), pKeyCt (nvarchar(1000))` | Lọc danh sách phiếu thu/chi và chi tiết theo điều kiện. Trả về hai result sets: phiếu và chi tiết. |
| asARFilt3 | `AsARFilt3` | `pKeyPh, pKeyCt` | Lọc danh sách ARFilt3 |
| asARFilt4 | `AsARFilt4` | `pKeyPh, pKeyCt` | Lọc danh sách ARFilt4 |
| asARGetCDKH | `AsARGetCDKH` | `pMa_Cty, pNam, pTk, pMa_kh, pMa_hd, pMa_bp, pMa_spct, pLoai` | Lấy thông tin ARGetCDKH |
| asARGetCT1 | `AsARGetCT1` | `pMa_cty (nvarchar(3)), pStt_rec (nvarchar(20)), pStruct (nvarchar(1))` | Lấy thông tin chi tiết phiếu công nợ phải thu (bảng ARCT1) theo mã công ty và số chứng từ. |
| asARGetCT3 | `AsARGetCT3` | `pMa_cty (nvarchar(3)), pStt_rec (nvarchar(20)), pStruct (nvarchar(1))` | Lấy thông tin chi tiết phiếu công nợ phải thu (bảng ARCT3). |
| asARGetCt4 | `AsARGetCt4` | `pMa_cty, pStt_rec, pStruct` | Lấy thông tin ARGetCt4 |
| asARGetCty | `AsARGetCty` | `pMa_cty1, pMa_cty2` | Lấy thông tin ARGetCty |
| asARGetDMDCKH | `AsARGetDMDCKH` | `pMa_cty, pMa_kh, pMa_dckh, pStruct` | Lấy thông tin ARGetDMDCKH |
| asARGetDMDCKH_dmkh | `AsARGetDMDCKH_dmkh` | `pMa_cty, pMa_kh, pMa_dckh, pStruct` | Lấy thông tin ARGetDMDCKH_dmkh |
| asARGetDMKH | `AsARGetDMKH` | `pMa_cty, pMa_kh, pStruct, pModuleId` | Lấy thông tin ARGetDMKH |
| asARGetDMNHKH | `AsARGetDMNHKH` | `pMa_cty, pMa_nhkh, pStruct` | Lấy thông tin ARGetDMNHKH |
| asARGetDMPLKH | `AsARGetDMPLKH` | `pMa_cty, pMa_plkh, pStruct, pLoai` | Lấy thông tin ARGetDMPLKH |
| asARGetMaCT | `AsARGetMaCT` | `pMa_cty (nvarchar(3))` | Tìm kiếm mã loại chứng từ được phân bổ cho module công nợ phải thu (CA1, CA3, AR4, AP4). |
| asARGetNgHKh | `AsARGetNgHKh` | `pMa_cty, pMa_kh` | Lấy thông tin ARGetNgHKh |
| asARGetPH1 | `AsARGetPH1` | `pMa_cty (nvarchar(3)), pStt_rec (nvarchar(20)), pMa_ct (nvarchar(3)), pStruct (nvarchar(1))` | Lấy thông tin phiếu công nợ phải thu (bảng ARPH1) theo mã công ty, số chứng từ, mã chứng từ. |
| asARGetPH3 | `AsARGetPH3` | `pMa_cty, pStt_rec, pMa_ct, pStruct` | Lấy thông tin ARGetPH3 |
| asARGetPH4 | `AsARGetPH4` | `pMa_cty, pStt_rec, pMa_ct, pStruct` | Lấy thông tin ARGetPH4 |
| asARGetPost2TT | `AsARGetPost2TT` | `pMa_cty, pLoai_ct, pSo1, pSo2, pNgay1, pNgay2, pMa_kh, pTk, pDien_giai` | Lấy thông tin ARGetPost2TT |
| asARGetPost2TT_ARTT | `AsARGetPost2TT_ARTT` | `pMa_cty, pStt_rec, pTk_pt, pMa_kh, pNgay_ct, pLoai` | Lấy thông tin ARGetPost2TT_ARTT |
| asARGetSO14AR1 | `AsARGetSO14AR1` | `pKey` | Lấy thông tin ARGetSO14AR1 |
| asARGetSO34AR1 | `AsARGetSO34AR1` | `pMa_cty (nvarchar(3)), pStt_rec (nvarchar(20)), pStruct (nvarchar(1))` | Lấy thông tin phiếu bán hàng liên quan đến công nợ phải thu (bảng SO34AR1). |
| asARGetTT | `AsARGetTT` | `pMa_cty (nvarchar(3)), pStt_rec (nvarchar(20)), pStruct (nvarchar(1))` | Lấy thông tin thanh toán (bảng ARTT). |
| asARInsCdKH | `AsARInsCdKH` | `pMa_cty, pNam, pTk, pMa_nt, pMa_kh, pMa_bp, pMa_hd, pMa_spct, pDu_no, pDu_co, pDu_no_nt, pDu_co_nt, pUser` | Chèn dữ liệu vào bảng arcdkh (công nợ chi tiết khách hàng) và đồng bộ sang glcdtk (công nợ chi tiết tài khoản). Có output parameter `pRet`. |
| asARInsDMDCKH | `AsARInsDMDCKH` | `pMa_cty, pMa_kh, pMa_dckh, pTen_kh, pDia_chi, pTel, pFax, pNguoi_gd, pKsd, pDc_md, pLUser` | Thêm mới địa chỉ khách hàng (danh mục địa chỉ khách hàng). Có output parameter `pRet`. |
| asARInsPH1 | `AsARInsPH1` | `pMa_cty, pStt_rec, pMa_ct, pSo_ct, pStt_rec_dh, pSo_dh, pNgay_ct, pNgay_lct, pMa_kh, pDia_chi, pNguoi_gd, pDien_giai, pTk_no, pMa_gd, pMa_nt, pTy_gia, pT_tien_nt, pT_tien, pDu, pDu_nt, pTrang_thai, pPost2gl, pLUser` | Thêm mới phiếu công nợ phải thu (bảng ARPH1). Có output parameter `pRet`. |
| asARInsPost2TT_ARTT | `AsARInsPost2TT_ARTT` | `pMa_cty, pStt_rec, pStt_rec_hd, pMa_ct, pNguoi_gd, pDien_giai, pTk_pt, pMa_kh, pSo_ct, pNgay_ct, pMa_nt, pTy_gia, pT_tt, pT_tt_nt, pTien_tt, pTien_tt_nt, pTien_tt_qd, pT_tien, pT_tien_nt, pUser` | Thêm mới phân bổ chứng từ công nợ phải thu (bảng artt). Có output parameter `pRet`. |

## Ghi chú

## Newly Converted Procedures (Batch 2026-02-12 subagent-51)

### asARInsDMKH

- **Class:** AsARInsDMKH
- **Parameters:** pMa_cty, pMa_kh, pLoai, pTen_kh, pMa_so_thue, pDia_chi, pTel, pFax, pEmail, pHome_page, pNguoi_gd, pMa_ngh, pTen_nh, pCn_nh, pSo_tk_nh, pTinh_tp_nh, pTk, pMa_plkh1, pMa_plkh2, pMa_plkh3, pMa_nhkh, pMa_tt, pMa_httt, pMa_httt_po, pGh_no, pHan_ck, pTl_ck, pHan_tt, pLs_qh, pGhi_chu, pTinh_dt_nb, pIskh, pIsncc, pIsnv, pKsd, pLUser, pRet
- **Description:** 
- **SQL File:** `asARInsDMKH.sql`

### asARInsDMNHKH

- **Class:** AsARInsDMNHKH
- **Parameters:** pMa_cty, pMa_nhkh, pTen_nhkh, pKsd, pLUser, pRet
- **Description:** 
- **SQL File:** `asARInsDMNHKH.sql`

### asARInsDMPLKH

- **Class:** AsARInsDMPLKH
- **Parameters:** pMa_cty, pMa_plkh, pTen_plkh, pLoai, pKsd, pLUser, pRet
- **Description:** 
- **SQL File:** `asARInsDMPLKH.sql`

### asARInsPh4

- **Class:** AsARInsPh4
- **Parameters:** pMa_cty, pMa_ct, pStt_rec, pSo_ct, pNgay_ct, pNgay_lct, pNt_ph, pMa_nt, pTy_gia, pT_tien, pT_tien_nt, pTrang_thai, pUser, pRet
- **Description:** 
- **SQL File:** `asARInsPh4.sql`

### asARInsTT

- **Class:** AsARInsTT
- **Parameters:** pMa_cty, pStt_rec, pMa_ct, pNgay_ct, pSo_ct, pMa_KH, pTk_pt, pMa_nt, pTy_gia, pT_tien2, pT_tien_nt2, pT_thue, pT_thue_nt, pT_tt, pT_tt_nt, pTien_tt, pTien_tt_nt, pNgay_tt, pMa_tt, pHan_ck, pTl_ck, pHan_tt, pLs_qh, pMa_hd, pDien_giai, pStt_rec_tt, pNgay_ct_tt, pMa_ct_tt, pSo_ct_tt, pTien_da_tt_nt, pTien_da_tt, pDu_hd, pDu_hd_nt, pLUser, pRet
- **Description:** 
- **SQL File:** `asARInsTT.sql`

### asARPhanBoThanhToan

- **Class:** AsARPhanBoThanhToan
- **Parameters:** pMa_cty, pTk_pt, pMa_kh, pNgay_ct1, pNgay_ct2
- **Description:** 
- **SQL File:** `asARPhanBoThanhToan.sql`

### asARPostPh1_artt

- **Class:** AsARPostPh1_artt
- **Parameters:** 
- **Description:** 
- **SQL File:** `asARPostPh1_artt.sql`

### asARPostPh1_glct

- **Class:** AsARPostPh1_glct
- **Parameters:** 
- **Description:** 
- **SQL File:** `asARPostPh1_glct.sql`

### asARReCalAR14Relate

- **Class:** AsARReCalAR14Relate
- **Parameters:** 
- **Description:** 
- **SQL File:** `asARReCalAR14Relate.sql`

### asARReCalAR34Relate

- **Class:** AsARReCalAR34Relate
- **Parameters:** 
- **Description:** 
- **SQL File:** `asARReCalAR34Relate.sql`

### asARRecalCustBalance

- **Class:** AsARRecalCustBalance
- **Parameters:** pMa_cty, pMa_kh, pNam
- **Description:** 
- **SQL File:** `asARRecalCustBalance.sql`

### asARRptBCCN01

- **Class:** AsARRptBCCN01
- **Parameters:** ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt
- **Description:** 
- **SQL File:** `asARRptBCCN01.sql`

### asARRptBCCN011

- **Class:** AsARRptBCCN011
- **Parameters:** ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt
- **Description:** 
- **SQL File:** `asARRptBCCN011.sql`

### asARRptBCCN01SL

- **Class:** AsARRptBCCN01SL
- **Parameters:** 
- **Description:** 
- **SQL File:** `asARRptBCCN01SL.sql`

### asARRptBCCN01a

- **Class:** AsARRptBCCN01a
- **Parameters:** ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt
- **Description:** 
- **SQL File:** `asARRptBCCN01a.sql`

### asARRptBCCN01a_Crys

- **Class:** AsARRptBCCN01a_Crys
- **Parameters:** ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt
- **Description:** 
- **SQL File:** `asARRptBCCN01a_Crys.sql`

### asARRptBCCN02

- **Class:** AsARRptBCCN02
- **Parameters:** pMa_cty, pNgay1, pNgay2, pTk, pMa_kh, pMa_plkh1, pMa_plkh2, pMa_plkh3, pMa_nt, pGroup1, pGroup2, pGroup3
- **Description:** 
- **SQL File:** `asARRptBCCN02.sql`

### asARRptBCCN03

- **Class:** AsARRptBCCN03
- **Parameters:** ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_plkh1, ma_plkh2, ma_plkh3, ma_nt
- **Description:** 
- **SQL File:** `asARRptBCCN03.sql`

### asARRptBCCN04

- **Class:** AsARRptBCCN04
- **Parameters:** ma_cty, Ngay1, Ngay2, Tk, pGroup, pDetail, ma_hd, ma_kh, ma_plkh1, ma_plkh2, ma_plkh3, pMa_BP, pMa_NVKD, pMa_SPCT, ma_nt
- **Description:** 
- **SQL File:** `asARRptBCCN04.sql`

### asARRptBCCN05

- **Class:** AsARRptBCCN05
- **Parameters:** pMa_cty, pNgay1, pNgay2, pTk, pMa_kh, pMa_nt
- **Description:** 
- **SQL File:** `asARRptBCCN05.sql`

### asARRptBCCN05_Crys

- **Class:** AsARRptBCCN05_Crys
- **Parameters:** ma_cty, Ngay1, Ngay2, Tk, ma_kh, ma_nt
- **Description:** 
- **SQL File:** `asARRptBCCN05_Crys.sql`

### asARRptBCCN06

- **Class:** AsARRptBCCN06
- **Parameters:** pMa_cty, pNgay1, pHan_Ky1, pHan_Ky2, pHan_Ky3, pMa_NCC, pMa_NhNCC, pMa_nt, pMa_TT
- **Description:** 
- **SQL File:** `asARRptBCCN06.sql`

### asARRptBK01

- **Class:** AsARRptBK01
- **Parameters:** pMa_cty, pNgay1, pNgay2, pMa_kh, pMa_vt, pMa_nhvt, pMa_kho, pMa_lo, pMa_bp, pMa_hd, pMa_phi, pMa_spct, pMa_nvkd, pMa_nt, pSoct1, pSoct2, pMa_plkh1, pMa_plkh2, pMa_plkh3
- **Description:** 
- **SQL File:** `asARRptBK01.sql`

### asARRptBK02

- **Class:** AsARRptBK02
- **Parameters:** pMa_cty, pNgay1, pHan_Ky1, pHan_Ky2, pHan_Ky3, pMa_NCC, pMa_NhNCC, pSap_xep, pTat_toan, pMa_nt, pMa_TT
- **Description:** 
- **SQL File:** `asARRptBK02.sql`

### asARRptBccnHd01

- **Class:** AsARRptBccnHd01
- **Parameters:** pMa_cty, pNgay1, pHan_Ky1, pHan_Ky2, pHan_Ky3, pMa_NCC, pMa_NhNCC, pSap_xep, pTat_toan, pMa_nt, pMa_TT
- **Description:** 
- **SQL File:** `asARRptBccnHd01.sql`

### asARRptF5BCCN

- **Class:** AsARRptF5BCCN
- **Parameters:** ma_cty, Tk, ma_kh, Ngay1, Ngay2, ma_nt
- **Description:** 
- **SQL File:** `asARRptF5BCCN.sql`

### asARRptF5BCCN04

- **Class:** AsARRptF5BCCN04
- **Parameters:** Ma_cty, Tk, Ma_kh, Ma_loai, Ma, Ngay1, Ngay2, Ma_nt, pMa_hd, pMa_bp
- **Description:** 
- **SQL File:** `asARRptF5BCCN04.sql`

### asARUpdCDKH

- **Class:** AsARUpdCDKH
- **Parameters:** pMa_cty, pTk, pNam, pMa_Kh, pMa_SpCt, pMa_hd, pMa_Bp, pDu_No_Nt, pDu_Co_Nt, pDu_No, pDu_Co, pUser, pRet
- **Description:** 
- **SQL File:** `asARUpdCDKH.sql`

- Các procedure có output parameter `pRet` hiện chưa được xử lý bởi `ProcedureCaller`. Cần cập nhật `ProcedureCaller` nếu muốn lấy giá trị output.
- Các tham số có giá trị mặc định trong SQL được chuyển thành giá trị mặc định trong class (ví dụ `null`).
- Để gọi procedure, sử dụng phương thức tĩnh `::call()` của class tương ứng, truyền mảng tham số.
- Chi tiết đầy đủ về từng tham số xem trong comment của từng class.

## Liên kết

- [Tổng hợp tất cả procedure](../PROCEDURES.md)
- [Nhóm AP (Accounts Payable)](./procedures-ap.md)

## asARUpdTT_SoDuSo5

- **Class:** AsARUpdTT_SoDuSo5
- **Parameters:** pMa_cty, pStt_rec_hd
- **Description:** 
- **SQL File:** `asARUpdTT_SoDuSo5.sql`

## asARUpdDMDCKH

- **Class:** AsARUpdDMDCKH
- **Parameters:** pMa_cty, pMa_kh, pMa_dckh, pTen_kh, pDia_chi, pTel, pFax, pNguoi_gd, pKsd, pDc_md, pLUser
- **Description:** 
- **SQL File:** `asARUpdDMDCKH.sql`

## asARRptBK03

- **Class:** AsARRptBK03
- **Parameters:** pMa_cty, pNgay1, pNgay2, pMa_gd, pSoct1, pSoct2, pMa_kh, pMa_nhkh, pMa_plkh1, pMa_plkh2, pMa_plkh3, pSap_xep, pTat_toan, pMa_NT
- **Description:** 
- **SQL File:** `asARRptBK03.sql`

