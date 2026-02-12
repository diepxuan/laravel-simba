# General Ledger (GL) Stored Procedures

Danh sách các stored procedure nhóm GL (General Ledger) đã được chuyển đổi sang class PHP.

## Tổng quan

Nhóm GL bao gồm các thủ tục liên quan đến kế toán tổng hợp: tính tổng số dư, chuyển số dư, tạo bút toán đánh giá tỷ giá, kết chuyển, v.v.

## Danh sách procedures

| Procedure | Class | Parameters | Description |
| ----------- | ------- | ------------ | ------------- || asGLCalSumCdTk | AsGLCalSumCdTk | 5 (pMa_cty, pTk, pNam, pMa_nt, pRet output) | Tính tổng theo tài khoản từ bảng GLCDTK. || asGLChuyenSdTk | AsGLChuyenSdTk | 3 (pMa_cty, pNgay_cnt, pRet output) | Chuyển số dư khách hàng và tài khoản sang năm sau. || asGLCopyMauBs | AsGLCopyMauBs | 4 (pMa_cty1, pMa_cty2, pMau, pRet output) | Copy cách tính giữa 2 công ty (từ công ty nguồn sang công ty đích). || asGLCrtDGTG | AsGLCrtDGTG | 8 (pma_cty, pma_ct, pma_nt, pstt, pngay1, pngay2, puser, pRet output) | Tạo bút toán đánh giá tỷ giá. || asGLCrtDGTG1 | AsGLCrtDGTG1 | 20 (pma_cty, pstt, pma_nt, ptk_dgtg, ptk_lai_cltg, ptk_lo_cltg, ptk_cltg_cn, pten_bt, pdg_kh, pdg_bp, pdg_hd, pdg_spct, pdg_phi, ploai_dg, pngay1, pngay2, pstt_rec, pma_ct, pso_ct, puser) | Thực hiện thao tác tạo bút toán đánh giá tỷ giá (internal). || asGLCrtKC | AsGLCrtKC | 8 (pMa_cty, pMa_ct, pNgay1, pNgay2, pTk, pTk_du, pUser, pRet output) | Tạo bút toán kết chuyển tự động. || asGLCrtKC1 | AsGLCrtKC1 | 17 (pma_cty, pstt, ptk, ptk_du, pten_bt, pkc_bp, pkc_hd, pkc_spct, pkc_phi, ploai_kc, pkc_dt_ps, pngay1, pngay2, pstt_rec, pma_ct, pso_ct, puser) | Thực hiện thao tác tạo bút toán kết chuyển tự động (internal). || asGLDelDGTG | AsGLDelDGTG | 5 (pMa_cty, pMa_ct, pngay1, pngay2, pstt) | Xóa bút toán đánh giá tỷ giá. || asGLDelMAUBCTCTMVI10 | AsGLDelMAUBCTCTMVI10 | 3 (pMa_cty, pMau, pLoai) | Xóa mẫu báo cáo tài chính chỉ tiêu MVI10. || asGLDelMAUBCTCTMVI17 | AsGLDelMAUBCTCTMVI17 | 3 (pMa_cty, pMau, pLoai) | Xóa mẫu báo cáo tài chính chỉ tiêu MVI10. || asGLInsNB | AsGLInsNB | 5 (pMa_cty, pStt_rec, pMa_ct, pNgay_ct, pUser) | Thêm mới ngân hàng. || asGLRptBCTCCR03 | AsGLRptBCTCCR03 | 4 (pMa_cty, pMau, pLoai, pNam) | Báo cáo tài chính mẫu CCR03. || asGLRptNKC01 | AsGLRptNKC01 | 4 (pMa_cty, pMau, pLoai, pNam) | Báo cáo nội kiểm soát mẫu NKC01. || asGLDKCTGS | AsGLDKCTGS | 9 (pMa_cty, pThang, pNam, pMa_ct, pTk, pTen_ctgs, pSo_hieu, pNgay, pRet output) | Đăng ký chứng từ ghi sổ. || asGLDelBudget | AsGLDelBudget | 2 (pStt_rec, pMa_cty) | Xoá một bản ghi của DMBudget. || asGLDelCRCt1 | AsGLDelCRCt1 | 3 (pMa_cty, pStt_rec, pRet output) | Xoá một bản ghi của CRCT1. || asGLDelCRPh1 | AsGLDelCRPh1 | 4 (pMa_cty, pStt_rec, pLUser, pRet output) | Xoá một bản ghi của CRPH1. || asGLDelCdTk | AsGLDelCdTk | 4 (pMa_cty, pTk, pNam, pRet output) | Xoá một bản ghi của GLCDTK. || asGLDelCt1 | AsGLDelCt1 | 3 (pMa_cty, pStt_rec, pRet output) | Xoá một bản ghi của GLCT1. || asGLDelDMCTGS | AsGLDelDMCTGS | 3 (pMa_cty, pMa_ct, pRet output) | Xoá một bản ghi của GLDMCTGS. || asGLRptBCTC02 | AsGLRptBCTC02 | 6 (pma_cty, pQd_cdkt, pNgay, pChiTieuCoSoLieu, pMau, pDest) | Báo cáo cân đối kế toán. || asGLRptBCTC05 | AsGLRptBCTC05 | 8 (pMa_Cty, pNgay_Ct1, pNgay_Ct2, pNgay_Ct01, pNgay_Ct02, pMau, pMa_bp, pMa_Nt) | Lưu chuyển tiền tệ gián tiếp. || asGLRptBCT05 | AsGLRptBCT05 | 4 (pMa_Cty, pNgay1, pNgay2, pMau) | Phụ biểu kết quả kinh doanh. |

| asGLRptBCTC02 | AsGLRptBCTC02 | 6 (@pma_cty, @pQd_cdkt, @pNgay, @pChiTieuCoSoLieu, @pMau, @pDest) | ======================================================= |
| asGLRptBCTC05 | AsGLRptBCTC05 | 0 () | ======================================================= |
| asGLRptBCT05 | AsGLRptBCT05 | 4 (@pMa_Cty, @pNgay1, @pNgay2, @pMau) | ======================================================= |
| asGLRptBCTCCDTb02 | AsGLRptBCTCCDTb02 | 2 (@pMa_cty, @pTk) | ======================================================= |
| asGLRptBCTCTmVI15c | AsGLRptBCTCTmVI15c | 4 (@pMa_cty, @pMau, @pNgay1, @pNgay2) | ============================================= |
| asGLRptBCTCCDTf03B | AsGLRptBCTCCDTf03B | 0 () | ================================================================================ |
| asGLRptBCTCTMVI02c | AsGLRptBCTCTMVI02c | 4 (@pMa_cty, @pMau, @pNgay1, @pNgay2) | 	--Tạo cấu trúc bảng và load số liệu theo nguồn lấy dữ liệu |
| asGLRptBCTCTMVI0708 | AsGLRptBCTCTMVI0708 | 4 (@pMa_cty, @pMau, @pNgay1, @pNgay2) | 	--Tạo cấu trúc bảng và load số liệu theo nguồn lấy dữ liệu |
| asGLRptBCTCTMVI03 | AsGLRptBCTCTMVI03 | 4 (@pMa_cty, @pMau, @pNgay1, @pNgay2) | ============================================= |
| asGLRptBCTCTMVI212 | AsGLRptBCTCTMVI212 | 4 (@pMa_cty, @pMau, @pNgay1, @pNgay2) | 			-- Lấy dữ liệu trong bảng người dùng, giữ nguyên mọi giá trị đã lưu |
| asGLRptBCTCTMVI04 | AsGLRptBCTCTMVI04 | 4 (@pMa_cty, @pMau, @pNgay1, @pNgay2) | 	--Tạo cấu trúc bảng và load số liệu theo nguồn lấy dữ liệu |
| asGLRptBCT03_dieuchinh | AsGLRptBCT03_dieuchinh | 8 (@pMa_cty, @pThang1, @pThang2, @pNam, @pStt_rec, @pDoanh_so, @pThue, @pRet) | ============================================= |
| asGLRptBCTCCDTb03 | AsGLRptBCTCCDTb03 | 0 () | ======================================================= |
| asGLRptBCTC04 | AsGLRptBCTC04 | 8 (@pMa_Cty, @pQd_cdkt, @pNgay_Ct1, @pNgay_Ct2, @pNgay_Ct01, @pNgay_Ct02, @pMau, @pMa_nt) | ======================================================= |
| asGLRptBCT04 | AsGLRptBCT04 | 0 () | ======================================================= |
| asGLRptBCT03 | AsGLRptBCT03 | 3 (@pMa_cty, @pNgay1, @pNgay2) | =========================================== |
| asGLRptBCTC03 | AsGLRptBCTC03 | 0 () | SET NOCOUNT ON |
| asGLRptBCTCTM | AsGLRptBCTCTM | 4 (@pMa_cty, @pMau, @pNgay1, @pNgay2) | ============================================= |
| asGLRptBCTCTMVI13 | AsGLRptBCTCTMVI13 | 4 (@pMa_cty, @pMau, @pNgay1, @pNgay2) | ============================================= |
| asGLRptBCTCCR02 | AsGLRptBCTCCR02 | 6 (@pma_cty, @pNam, @pNgay, @pChiTieuCoSoLieu, @pMau, @pDest) | ======================================================= |
| asGLRptBCTCTMVI25a | AsGLRptBCTCTMVI25a | 4 (@pMa_cty, @pMau, @pNgay1, @pNgay2) | 	--Tạo cấu trúc bảng và load số liệu theo nguồn lấy dữ liệu |
| asGLRptBCTCTMVI05 | AsGLRptBCTCTMVI05 | 4 (@pMa_cty, @pMau, @pNgay1, @pNgay2) | 	--Tạo cấu trúc bảng và load số liệu theo nguồn lấy dữ liệu |
| asGLRptBCTCTMCal | AsGLRptBCTCTMCal | 6 (@pMa_cty, @pMau, @pNgay1, @pNgay2, @pTab_Name, @pRet) | ============================================= |
| asGLRptBCTCTMVI15D | AsGLRptBCTCTMVI15D | 4 (@pMa_cty, @pMau, @pNgay1, @pNgay2) | 	--Tạo cấu trúc bảng và load số liệu theo nguồn lấy dữ liệu |
| asGLRptBCTC04_CheckSL | AsGLRptBCTC04_CheckSL | 0 () | Thu tuc lay du lieu va ho tro kiem tra bao cao luu chuyen tien te |
| asGLRptBCTCCDTf03D | AsGLRptBCTCCDTf03D | 0 () | BAO CAO CHU DAU TU |
| asGLRptBCTCCDTf03C | AsGLRptBCTCCDTf03C | 0 () | BAO CAO CHU DAU TU |
| asGLRptBCTCTMVI01 | AsGLRptBCTCTMVI01 | 4 (@pMa_cty, @pMau, @pNgay1, @pNgay2) | ============================================= |
| asGLRptBCTCCR01F5 | AsGLRptBCTCCR01F5 | 3 (@pMa_Cty, @pTk, @pMa_nt) | ==================================================== |
| asGLRptBCTCTMVI25b | AsGLRptBCTCTMVI25b | 4 (@pMa_cty, @pMau, @pNgay1, @pNgay2) | ============================================= |
## Chi tiết từng procedure

### asGLCalSumCdTk
- **Mục đích**: Tính tổng số dư đầu kỳ, trong kỳ theo tài khoản.
- **Tham số**:
  - `pMa_cty` (nvarchar(3)): mã công ty.
  - `pTk` (nvarchar(20)): tài khoản (có thể dùng wildcard '%').
  - `pNam` (int): năm.
  - `pMa_nt` (nvarchar(3)): mã ngoại tệ.
  - `pRet` (int output): mã lỗi.
- **Giá trị mặc định**: pMa_cty = công ty mặc định, pNam = năm hiện tại, pMa_nt = 'VND'.
- **Kết quả**: một bản ghi chứa các tổng du_no_nt00, du_co_nt00, du_no00, du_co00, du_no_nt, du_co_nt, du_no, du_co.

### asGLChuyenSdTk
- **Mục đích**: Chuyển số dư khách hàng và tài khoản sang năm sau.
- **Tham số**:
  - `pMa_cty` (nvarchar(3)): mã công ty.
  - `pNgay_cnt` (smalldatetime): ngày cuối năm trước.
  - `pRet` (int output): mã lỗi (50012 nếu ngày đầu năm sau ≤ ngày khóa sổ).
- **Giá trị mặc định**: pMa_cty = công ty mặc định.
- **Kết quả**: không có result set.

### asGLCopyMauBs
- **Mục đích**: Copy cách tính giữa 2 công ty.
- **Tham số**:
  - `pMa_cty1` (nvarchar(3)): công ty đích.
  - `pMa_cty2` (nvarchar(3)): công ty nguồn.
  - `pMau` (nvarchar(10)): mã mẫu báo cáo.
  - `pRet` (int output): mã lỗi.
- **Giá trị mặc định**: pMa_cty1 = công ty mặc định.
- **Kết quả**: không có result set.

### asGLCrtDGTG
- **Mục đích**: Tạo bút toán đánh giá tỷ giá.
- **Tham số**:
  - `pma_cty` (nvarchar(3)): mã công ty.
  - `pma_ct` (nvarchar(3)): mã chứng từ (GL5).
  - `pma_nt` (nvarchar(3)): mã ngoại tệ.
  - `pstt` (int): số thứ tự đánh giá tỷ giá.
  - `pngay1` (smalldatetime): ngày bắt đầu kỳ.
  - `pngay2` (smalldatetime): ngày kết thúc kỳ.
  - `puser` (nvarchar(20)): người dùng.
  - `pRet` (int output): mã lỗi.
- **Giá trị mặc định**: pma_cty = công ty mặc định, pma_nt = 'VND', pstt = 1, pngay1/pngay2 = đầu/cuối tháng hiện tại.
- **Kết quả**: không có result set.

### asGLCrtDGTG1
- **Mục đích**: Thực hiện thao tác tạo bút toán đánh giá tỷ giá (internal).
- **Tham số**: 20 tham số, xem class.
- **Giá trị mặc định**: nhiều giá trị mặc định (USD, các tài khoản mặc định).
- **Kết quả**: không có result set.

### asGLCrtKC
- **Mục đích**: Tạo bút toán kết chuyển tự động.
- **Tham số**:
  - `pMa_cty` (nvarchar(3)): mã công ty.
  - `pMa_ct` (nvarchar(3)): mã chứng từ.
  - `pNgay1` (smalldatetime): ngày bắt đầu kỳ.
  - `pNgay2` (smalldatetime): ngày kết thúc kỳ.
  - `pTk` (nvarchar(20)): tài khoản nguồn.
  - `pTk_du` (nvarchar(20)): tài khoản đích.
  - `pUser` (nvarchar(20)): người dùng.
  - `pRet` (int output): mã lỗi.
- **Giá trị mặc định**: pMa_cty = công ty mặc định, pNgay1/pNgay2 = đầu/cuối tháng hiện tại.
- **Kết quả**: không có result set.

### asGLCrtKC1
- **Mục đích**: Thực hiện thao tác tạo bút toán kết chuyển tự động (internal).
- **Tham số**: 17 tham số, xem class.
- **Giá trị mặc định**: nhiều giá trị mặc định.
- **Kết quả**: không có result set.

### asGLDelDGTG
- **Mục đích**: Xóa bút toán đánh giá tỷ giá.
- **Tham số**:
  - `pMa_cty` (nvarchar(3)): mã công ty.
  - `pMa_ct` (nvarchar(3)): mã chứng từ.
  - `pngay1` (smalldatetime): ngày bắt đầu.
  - `pngay2` (smalldatetime): ngày kết thúc.
  - `pstt` (int): số thứ tự.
- **Giá trị mặc định**: không.
- **Kết quả**: không có result set.

### asGLDelMAUBCTCTMVI10
- **Mục đích**: Xóa mẫu báo cáo tài chính chỉ tiêu MVI10.
- **Tham số**:
  - `pMa_cty` (nvarchar(3)): mã công ty.
  - `pMau` (nvarchar(10)): mã mẫu.
  - `pLoai` (int): loại.
- **Giá trị mặc định**: không.
- **Kết quả**: không có result set.

### asGLDelMAUBCTCTMVI17
- **Mục đích**: Xóa mẫu báo cáo tài chính chỉ tiêu MVI17.
- **Tham số**: tương tự MVI10.
- **Giá trị mặc định**: không.
- **Kết quả**: không có result set.

### asGLInsNB
- **Mục đích**: Thêm mới ngân hàng.
- **Tham số**:
  - `pMa_cty` (nvarchar(3)): mã công ty.
  - `pStt_rec` (nvarchar(20)): số tham chiếu.
  - `pMa_ct` (nvarchar(3)): mã chứng từ.
  - `pNgay_ct` (smalldatetime): ngày chứng từ.
  - `pUser` (nvarchar(20)): người dùng.
- **Giá trị mặc định**: không.
- **Kết quả**: không có result set.

### asGLRptBCTCCR03
- **Mục đích**: Báo cáo tài chính mẫu CCR03.
- **Tham số**:
  - `pMa_cty` (nvarchar(3)): mã công ty.
  - `pMau` (nvarchar(10)): mã mẫu.
  - `pLoai` (int): loại.
  - `pNam` (int): năm.
- **Giá trị mặc định**: không.
- **Kết quả**: result set của báo cáo.

### asGLRptNKC01
- **Mục đích**: Báo cáo nội kiểm soát mẫu NKC01.
- **Tham số**: tương tự CCR03.
- **Giá trị mặc định**: không.
- **Kết quả**: result set của báo cáo.

## Cập nhật

Danh sách này sẽ được bổ sung khi có thêm procedures được chuyển đổi.


## asGLRptNKC06

- **Class:** AsGLRptNKC06
- **Parameters:** pMa_cty, pNgay_ct1, pNgay_ct2, pTk, pMa_Nt
- **Description:** 
- **SQL File:** `asGLRptNKC06.sql`

## asGLRptBCTCCR04

- **Class:** AsGLRptBCTCCR04
- **Parameters:** pMa_Cty, pNam, pNgay_Ct1, pNgay_Ct2, pNgay_Ct01, pNgay_Ct02, pMau, pMa_nt
- **Description:** 
- **SQL File:** `asGLRptBCTCCR04.sql`

## asGLUpdMAUBCTCTMVI02a

- **Class:** AsGLUpdMAUBCTCTMVI02a
- **Parameters:** pMa_cty, pMau, pMa_so, pChi_tieu, pNd_chtieu, pCach_tinh, pIsPrint, pIsItalic, pTk_01, pBold
- **Description:** 
- **SQL File:** `asGLUpdMAUBCTCTMVI02a.sql`

## asGLRptBCTCTMVI12

- **Class:** AsGLRptBCTCTMVI12
- **Parameters:** pMa_cty, pMau, pNgay1, pNgay2
- **Description:** 
- **SQL File:** `asGLRptBCTCTMVI12.sql`

## asGLRptBCTCTMVI15a

- **Class:** AsGLRptBCTCTMVI15a
- **Parameters:** pMa_cty, pMau, pNgay1, pNgay2, pTk_01
- **Description:** 
- **SQL File:** `asGLRptBCTCTMVI15a.sql`

## asGLUpdBudget

- **Class:** AsGLUpdBudget
- **Parameters:** pStt_rec, pMa_cty, pNam, pTk, pTk_du, pTtps_no_co, pMa_bp, pMa_phi, pMa_spct, pUser, pT1, pT2, pT3, pT4, pT5, pT6, pT7, pT8, pT9, pT10, pT11, pT12
- **Description:** 
- **SQL File:** `asGLUpdBudget.sql`

## asGLRptBCT02

- **Class:** AsGLRptBCT02
- **Parameters:** pMa_cty, pNgay1, pNgay2, pThue_suat, pTk, pTk_du
- **Description:** 
- **SQL File:** `asGLRptBCT02.sql`

## asGLRptBCTC02_CheckSL

- **Class:** AsGLRptBCTC02_CheckSL
- **Parameters:** pma_cty, pQd_cdkt, pNgay, pChiTieuCoSoLieu, pMau, pDest
- **Description:** 
- **SQL File:** `asGLRptBCTC02_CheckSL.sql`

## asGLInsMAUBCTCTmVI15c

- **Class:** AsGLInsMAUBCTCTmVI15c
- **Parameters:** pMa_cty, pMau, pMa_so, pChi_tieu, pNd_chtieu, pCach_tinh, pLoai_ps, pTk_01, pTk_02, pIsPrint, pIsItalic, pBold, pModify, pTien_01, pTien_02, pTien_03, pTien_04, pTien_05, pTien_06, pUserData, pGhi_chu, pNgay1, pNgay2, pcach_tinh, pTk_01, pTk_02, pModify, pModify, pUserData, pMa_cty, pMau, pMa_so, pChi_tieu, pNd_chtieu, pCach_tinh, pLoai_ps, pTk_01, pTk_02, pIsPrint, pIsItalic, pBold, pModify, pMa_cty, pMau, pNgay1, pNgay2, pMa_so, pChi_tieu, pNd_chtieu, pCach_tinh, pLoai_ps, pTk_01, pTk_02, pGhi_chu, pIsPrint, pIsItalic, pBold, pModify, pTien_01, pTien_02, pTien_03, pTien_04, pTien_05, pTien_06
- **Description:** 
- **SQL File:** `asGLInsMAUBCTCTmVI15c.sql`

## asGLRptNKC012

- **Class:** AsGLRptNKC012
- **Parameters:** pMa_cty, pNgay_Ct1, pNgay_Ct2, pTk, pMa_Nt, pStt_dong_nkc
- **Description:** 
- **SQL File:** `asGLRptNKC012.sql`

## asGLUpdMAUBCTCTMVI08b

- **Class:** AsGLUpdMAUBCTCTMVI08b
- **Parameters:** pMa_cty, pMau, pMa_so, pChi_tieu, pNd_chtieu, pCach_tinh, pTk_01, pIsPrint, pIsItalic, pBold, pRet
- **Description:** 
- **SQL File:** `asGLUpdMAUBCTCTMVI08b.sql`

## asGLRptCheckCashFlow

- **Class:** AsGLRptCheckCashFlow
- **Parameters:** pMa_cty, pNgay_ct1, pNgay_ct2
- **Description:** 
- **SQL File:** `asGLRptCheckCashFlow.sql`

## asGLInsBudget

- **Class:** AsGLInsBudget
- **Parameters:** pStt_rec, pMa_cty, pNam, pTk, pTk_du, pTtps_no_co, pMa_bp, pMa_phi, pMa_spct, pUser, pT1, pT2, pT3, pT4, pT5, pT6, pT7, pT8, pT9, pT10, pT11, pT12, pRet
- **Description:** 
- **SQL File:** `asGLInsBudget.sql`

## asGLCR1GetMaSo_MaBang

- **Class:** AsGLCR1GetMaSo_MaBang
- **Parameters:** pMa_cty, pTk
- **Description:** 
- **SQL File:** `asGLCR1GetMaSo_MaBang.sql`

## asGLInsMAUBCTCTMVI15a

- **Class:** AsGLInsMAUBCTCTMVI15a
- **Parameters:** pMa_cty, pMau, pMa_so, pChi_tieu, pNd_chtieu, pcach_tinh, pTk_01, pIsPrint, pIsItalic, pBold, pModify, pgia_tri_dk, pton_dk, pps_tang, pps_giam, pgia_tri_ck, pton_ck, pUserData, pGhi_chu, pNgay1, pNgay2
- **Description:** 
- **SQL File:** `asGLInsMAUBCTCTMVI15a.sql`

## asGLInsCdTk

- **Class:** AsGLInsCdTk
- **Parameters:** pMa_cty, pTk, pNam, pMa_nt, pDu_no_nt00, pDu_co_nt00, pDu_no00, pDu_co00, pDu_no_nt, pDu_co_nt, pDu_no, pDu_co, pLUser
- **Description:** 
- **SQL File:** `asGLInsCdTk.sql`

## asGLInsMAUBCTCTMVI13

- **Class:** AsGLInsMAUBCTCTMVI13
- **Parameters:** pMa_cty, pMau, pma_so, pChi_tieu, pNd_chtieu, pCach_tinh, pTk_01, pIsPrint, pIsItalic, pBold, pModify, pcuoi_ky, pDau_ky, pUserData, pGhi_chu, pNgay1, pNgay2
- **Description:** 
- **SQL File:** `asGLInsMAUBCTCTMVI13.sql`








