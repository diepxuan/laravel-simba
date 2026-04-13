# GL Module - General Ledger

Module sổ cái tổng hợp (General Ledger).

## Cấu trúc thư mục

- `vouchers/` - Chứng từ nghiệp vụ GL
- `reports/` - Báo cáo GL
- `masters/` - Danh mục và dữ liệu nền tảng
- `financial-statements/` - Báo cáo tài chính

## Vouchers

| File | Mô tả |
|------|-------|
| [GLPost2GL.md](vouchers/GLPost2GL.md) | Chuyển số liệu vào sổ cái |
| [GLCDTK.md](vouchers/GLCDTK.md) | Số dư đầu kỳ các tài khoản (Opening Balance) |
| [GLNB.md](vouchers/GLNB.md) | Nghiệp vụ (ghi sổ nhanh/bút toán) |
| [GLVchGL1.md](vouchers/GLVchGL1.md) | Voucher ghi sổ chung |
| [GLPost2DGTG.md](vouchers/GLPost2DGTG.md) | Đánh giá tỷ giá cuối kỳ |
| [GLPost2GLKC.md](vouchers/GLPost2GLKC.md) | Kết chuyển tự động |
| [GLTransferGLCDTK.md](vouchers/GLTransferGLCDTK.md) | Chuyển số dư TK sang năm sau |

### Chi tiết Vouchers

#### GLCDTK - Số dư đầu kỳ các tài khoản
- Nhập số dư đầu kỳ cho các tài khoản kế toán
- Phân biệt số dư đầu kỳ và đầu năm
- Hỗ trợ số dư ngoại tệ (dư nợ NT, dư có NT)
- Tính tổng số dư tự động
- Stored Procedure: `asGLCalSumCdTk`

#### GLPost2DGTG - Đánh giá tỷ giá cuối kỳ
- Thực hiện đánh giá tỷ giá tự động
- Cấu hình tài khoản lãi/lỗ chênh lệch tỷ giá
- Phân tích theo bộ phận, phí, hợp đồng, SPCT, khách hàng

#### GLPost2GLKC - Kết chuyển tự động
- Thực hiện các bút toán kết chuyển cuối kỳ
- Kết chuyển doanh thu, chi phí, lãi lỗ
- Tự động tạo chứng từ kết chuyển

## Reports

### Báo cáo Cân đối phát sinh (BCPT)

| File | Mô tả |
|------|-------|
| [GLRptBCPT01.md](reports/GLRptBCPT01.md) | Bảng cân đối phát sinh các tiểu tài khoản của một tài khoản |
| [GLRptBCPT02.md](reports/GLRptBCPT02.md) | Bảng cân đối phát sinh một tài khoản theo ngày |
| [GLRptBCPT03.md](reports/GLRptBCPT03.md) | Bảng cân đối kế toán theo kỳ |
| [GLRptBCPT04.md](reports/GLRptBCPT04.md) | Bảng cân đối phát sinh một tài khoản theo chứng từ |
| [GLRptBCPT05.md](reports/GLRptBCPT05.md) | Báo cáo kết quả hoạt động sản xuất kinh doanh |
| [GLRptBcpt08.md](reports/GLRptBcpt08.md) | Báo cáo kết quả hoạt động sản xuất kinh doanh (Mẫu PL01) |

### Báo cáo Thuế (BCT)

| File | Mô tả |
|------|-------|
| [GLRptBCT01.md](reports/GLRptBCT01.md) | Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào (Thuế GTGT đầu vào) |
| [GLRptBCT02.md](reports/GLRptBCT02.md) | Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ bán ra (Thuế GTGT đầu ra) |
| [GLRptBCT03.md](reports/GLRptBCT03.md) | Tờ khai giá trị gia tăng (Tờ khai GTGT) |
| [GLRptBCT04.md](reports/GLRptBCT04.md) | Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp |
| [GLRptBCT05.md](reports/GLRptBCT05.md) | Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp (Phiên bản 5) |
| [GLRptBCT06.md](reports/GLRptBCT06.md) | Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp (Phiên bản 6) |

### Báo cáo Tài chính (BCTC)

| File | Mô tả |
|------|-------|
| [GLRptBctc01.md](reports/GLRptBctc01.md) | Bảng cân đối phát sinh các tài khoản (Trial Balance) |
| [GLRptBctc02.md](reports/GLRptBctc02.md) | Bảng cân đối kế toán (Balance Sheet) |
| [GLRptBctc03.md](reports/GLRptBctc03.md) | Báo cáo kết quả hoạt động kinh doanh (Income Statement) |
| [GLRptBctc04.md](reports/GLRptBctc04.md) | Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp (Cash Flow Statement) |

### Báo cáo Tài chính Chi tiết (BCTCCDT)

| File | Mô tả |
|------|-------|
| [GLRptBCTCCDTB02.md](reports/GLRptBCTCCDTB02.md) | Báo cáo tài chính chi tiết B02 |
| [GLRptBCTCCDTB03.md](reports/GLRptBCTCCDTB03.md) | Báo cáo tài chính chi tiết B03 |
| [GLRptBCTCCDTF02.md](reports/GLRptBCTCCDTF02.md) | Báo cáo tài chính chi tiết F02 |
| [GLRptBCTCCDTF03A.md](reports/GLRptBCTCCDTF03A.md) | Báo cáo tài chính chi tiết F03A (xây lắp) |
| [GLRptBCTCCDTF03B.md](reports/GLRptBCTCCDTF03B.md) | Báo cáo tài chính chi tiết F03B |
| [GLRptBCTCCDTF03C.md](reports/GLRptBCTCCDTF03C.md) | Báo cáo tài chính chi tiết F03C |
| [GLRptBCTCCDTF03D.md](reports/GLRptBCTCCDTF03D.md) | Báo cáo tài chính chi tiết F03D |

### Báo cáo Tài chính CCR (Thông tư 03)

| File | Mô tả |
|------|-------|
| [GLRptBCTCCR01.md](reports/GLRptBCTCCR01.md) | Bảng cân đối phát sinh (CCR01) |
| [GLRptBCTCCR01F5.md](reports/GLRptBCTCCR01F5.md) | Drill-down báo cáo CCR01 - Sổ chi tiết/TK đối ứng |
| [GLRptBCTCCR02.md](reports/GLRptBCTCCR02.md) | Bảng cân đối kế toán (theo Thông tư 03) |
| [GLRptBCTCCR03.md](reports/GLRptBCTCCR03.md) | Báo cáo kết quả hoạt động kinh doanh (theo Thông tư 03) |
| [GLRptBCTCCR04.md](reports/GLRptBCTCCR04.md) | Báo cáo lưu chuyển tiền tệ (phương pháp trực tiếp - Thông tư 03) |

### Báo cáo BK (Báo cáo khác)

| File | Mô tả |
|------|-------|
| [GLRptBk01.md](reports/GLRptBk01.md) | Báo cáo BK01 |
| [GLRptBk02.md](reports/GLRptBk02.md) | Báo cáo BK02 |

### Chứng từ ghi sổ (CTGS)

| File | Mô tả |
|------|-------|
| [GLRptCTGS01.md](reports/GLRptCTGS01.md) | Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào |
| [GLRptCTGS02.md](reports/GLRptCTGS02.md) | Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào (theo số CT) |
| [GLRptCTGS03.md](reports/GLRptCTGS03.md) | Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào theo tài khoản |
| [GLRptCTGS05.md](reports/GLRptCTGS05.md) | Bảng kê chứng từ tổng hợp với bộ lọc chi tiết đa chiều |

### Báo cáo F5 (Drill-down)

| File | Mô tả |
|------|-------|
| [GLRptF5BCPT08.md](reports/GLRptF5BCPT08.md) | Báo cáo F5 chi phí thuế 08 |
| [GLRptF5BCTC02.md](reports/GLRptF5BCTC02.md) | Báo cáo F5 tài chính 02 |
| [GLRptF5BCTC02CT.md](reports/GLRptF5BCTC02CT.md) | Báo cáo F5 tài chính 02 CT |
| [GLRptF5Bctc03.md](reports/GLRptF5Bctc03.md) | Báo cáo F5 tài chính 03 |
| [GLRptF5BCTC03CT.md](reports/GLRptF5BCTC03CT.md) | Báo cáo F5 tài chính 03 CT |
| [GLRptF5Bctc04.md](reports/GLRptF5Bctc04.md) | Báo cáo F5 tài chính 04 |
| [GLRptF5CTGS01.md](reports/GLRptF5CTGS01.md) | F5 Chứng từ ghi sổ 01 |
| [GLRptF5CTGS02.md](reports/GLRptF5CTGS02.md) | F5 Chứng từ ghi sổ 02 |
| [GLRptF5CTGS03.md](reports/GLRptF5CTGS03.md) | F5 Chứng từ ghi sổ 03 |

### Nhật ký chung (NKC)

| File | Mô tả |
|------|-------|
| [GLRptNKC01All.md](reports/GLRptNKC01All.md) | Bảng cân đối phát sinh các tài khoản (NKC01 All) |
| [GLRptNkc01.md](reports/GLRptNkc01.md) | Sổ cái (NKC01) |
| [GLRptNkc02.md](reports/GLRptNkc02.md) | Sổ nhật ký chung (NKC02) |
| [GLRptNkc03.md](reports/GLRptNkc03.md) | Sổ nhật ký thu tiền (NKC03) |
| [GLRptNkc04.md](reports/GLRptNkc04.md) | Sổ nhật ký bán hàng (NKC04) |
| [GLRptNkc05.md](reports/GLRptNkc05.md) | Sổ nhật ký mua hàng (NKC05) |
| [GLRptNkc06.md](reports/GLRptNkc06.md) | Sổ chi tiết các tài khoản (NKC06) |
| [GLRptNkc07.md](reports/GLRptNkc07.md) | Sổ cái chữ T của một tài khoản (NKC07) |
| [GLRptNKC08.md](reports/GLRptNKC08.md) | Nhật ký chung 08 |
| [GLRptNKCTNK1.md](reports/GLRptNKCTNK1.md) | Nhật ký chung tổng hợp theo tài khoản (NKCTNK1) |
| [GLRptNKCTSoCai.md](reports/GLRptNKCTSoCai.md) | Nhật ký chung tổng hợp sổ cái (NKCTSoCai) |
| [GLRptTH01.md](reports/GLRptTH01.md) | Báo cáo tổng hợp 01 |
| [GLRptTMBCTC.md](reports/GLRptTMBCTC.md) | Báo cáo tài chính tổng hợp |

## Masters

| File | Mô tả |
|------|-------|
| [GLDMTK.md](masters/GLDMTK.md) | Danh mục tài khoản (Chart of Accounts) |
| [GLBudget.md](masters/GLBudget.md) | Ngân sách (Budget) |
| [GLDMCTGS.md](masters/GLDMCTGS.md) | Danh mục chứng từ ghi sổ (CTGS) |
| [GLDKCTGS.md](masters/GLDKCTGS.md) | Đăng ký chứng từ ghi sổ |
| [GLDMDGTG.md](masters/GLDMDGTG.md) | Khai báo bút toán đánh giá tỷ giá |
| [GLDMKC.md](masters/GLDMKC.md) | Khai báo bút toán kết chuyển tự động |

### Chi tiết Masters

#### GLDMTK - Danh mục tài khoản
- Quản lý danh mục tài khoản kế toán dạng cây phân cấp
- Tự động xác định tài khoản mẹ, bậc tài khoản
- Thụt lề tên TK theo bậc
- Stored Procedure: `asGlCheckTkMe`

#### GLBudget - Ngân sách
- Thiết lập ngân sách theo tài khoản, bộ phận, phí, SPCT
- Nhập giá trị dự toán cho 12 tháng
- Nhiều phương pháp điều chỉnh: cố định, phân chia, lũy kế, tăng trưởng %
- Stored Procedures: `asGLGetBudget`, `asGLGetSample0Budget`, `asGLGetSample1Budget`

#### GLDMCTGS - Danh mục chứng từ ghi sổ
- Quản lý các loại chứng từ ghi sổ
- Cấu hình mã CT, tên CT, tài khoản mặc định, số hiệu

#### GLDKCTGS - Đăng ký chứng từ ghi sổ
- Liệt kê và chọn chứng từ để đăng ký theo kỳ
- Chọn kỳ báo cáo (tháng/quý/năm)
- Xử lý đăng ký hàng loạt

#### GLDMDGTG - Khai báo bút toán đánh giá tỷ giá
- Khai báo các bút toán đánh giá tỷ giá tự động
- Cấu hình TK đánh giá TG, TK lãi/lỗ CLTG
- Phân tích theo: bộ phận, phí, hợp đồng, SPCT, khách hàng

#### GLDMKC - Khai báo bút toán kết chuyển tự động
- Khai báo các bút toán kết chuyển cuối kỳ
- Cấu hình tài khoản nguồn và đích
- Tham số `par1` phân loại loại kết chuyển

## Financial Statements

| File | Mô tả |
|------|-------|
| [GLMAUBCTCTMI.md](financial-statements/GLMAUBCTCTMI.md) | Mẫu báo cáo tài chính TMI |
| [GLMAUBCTCTMIX.md](financial-statements/GLMAUBCTCTMIX.md) | Mẫu báo cáo tài chính TMIX |
| [GLMAUBCTCTMV01.md](financial-statements/GLMAUBCTCTMV01.md) | Mẫu báo cáo tài chính TMV01 |
| [GLMAUBCTCTMV02.md](financial-statements/GLMAUBCTCTMV02.md) | Mẫu báo cáo tài chính TMV02 |
| [GLMAUBCTCTMV03.md](financial-statements/GLMAUBCTCTMV03.md) | Mẫu báo cáo tài chính TMV03 |
| [GLMAUBCTCTMV08.md](financial-statements/GLMAUBCTCTMV08.md) | Mẫu báo cáo tài chính TMV08 |
| [GLMAUBCTCTMV09.md](financial-statements/GLMAUBCTCTMV09.md) | Mẫu báo cáo tài chính TMV09 |
| [GLMAUBCTCTMV10.md](financial-statements/GLMAUBCTCTMV10.md) | Mẫu báo cáo tài chính TMV10 |
| [GLMAUBCTCTMV11.md](financial-statements/GLMAUBCTCTMV11.md) | Mẫu báo cáo tài chính TMV11 |
| [GLMAUBCTCTMV12.md](financial-statements/GLMAUBCTCTMV12.md) | Mẫu báo cáo tài chính TMV12 |
| [GLMAUBCTCTMV13.md](financial-statements/GLMAUBCTCTMV13.md) | Mẫu báo cáo tài chính TMV13 |
| [GLMAUBCTCTMV14.md](financial-statements/GLMAUBCTCTMV14.md) | Mẫu báo cáo tài chính TMV14 |
| [GLMAUBCTCTMV20C.md](financial-statements/GLMAUBCTCTMV20C.md) | Mẫu báo cáo tài chính TMV20C |
| [GLMAUBCTCTMV21.md](financial-statements/GLMAUBCTCTMV21.md) | Mẫu báo cáo tài chính TMV21 |
| [GLMAUBCTCTMV22A.md](financial-statements/GLMAUBCTCTMV22A.md) | Mẫu báo cáo tài chính TMV22A |
| [GLMAUBCTCTMV22b.md](financial-statements/GLMAUBCTCTMV22b.md) | Mẫu báo cáo tài chính TMV22b |
| [GLMAUBCTCTMV22c.md](financial-statements/GLMAUBCTCTMV22c.md) | Mẫu báo cáo tài chính TMV22c |
| [GLMAUBCTCTMV22d.md](financial-statements/GLMAUBCTCTMV22d.md) | Mẫu báo cáo tài chính TMV22d |
| [GLMAUBCTCTMV23.md](financial-statements/GLMAUBCTCTMV23.md) | Mẫu báo cáo tài chính TMV23 |
| [GLMAUBCTCTMV24.md](financial-statements/GLMAUBCTCTMV24.md) | Mẫu báo cáo tài chính TMV24 |
| [GLMAUBCTCTMVI02a.md](financial-statements/GLMAUBCTCTMVI02a.md) | Mẫu báo cáo tài chính TMI02a |
| [GLMAUBCTCTMVI02B.md](financial-statements/GLMAUBCTCTMVI02B.md) | Mẫu báo cáo tài chính TMI02B |
| [GLMAUBCTCTMVI02c.md](financial-statements/GLMAUBCTCTMVI02c.md) | Mẫu báo cáo tài chính TMI02c |
| [GLMAUBCTCTMVI09.md](financial-statements/GLMAUBCTCTMVI09.md) | Mẫu báo cáo tài chính TMI09 |
| [GLMAUBCTCTMVI10.md](financial-statements/GLMAUBCTCTMVI10.md) | Mẫu báo cáo tài chính TMI10 |
| [GLMAUBCTCTMVI11.md](financial-statements/GLMAUBCTCTMVI11.md) | Mẫu báo cáo tài chính TMI11 |
| [GLMAUBCTCTMVI12.md](financial-statements/GLMAUBCTCTMVI12.md) | Mẫu báo cáo tài chính TMI12 |
| [GLMAUBCTCTMVI15c.md](financial-statements/GLMAUBCTCTMVI15c.md) | Mẫu báo cáo tài chính TMI15c |
| [GLMAUBCTCTMVI211.md](financial-statements/GLMAUBCTCTMVI211.md) | Mẫu báo cáo tài chính TMI211 |
| [GLMAUBCTCTMVI212.md](financial-statements/GLMAUBCTCTMVI212.md) | Mẫu báo cáo tài chính TMI212 |
| [GLMAUBCTCTMVI25A.md](financial-statements/GLMAUBCTCTMVI25A.md) | Mẫu báo cáo tài chính TMI25A |
| [GLMAUBCTCTMVI29B.md](financial-statements/GLMAUBCTCTMVI29B.md) | Mẫu báo cáo tài chính TMI29B |
| [GLMAUBCTCTMVII.md](financial-statements/GLMAUBCTCTMVII.md) | Mẫu báo cáo tài chính TMII |
| [GLMAUBCTCTMVIII.md](financial-statements/GLMAUBCTCTMVIII.md) | Mẫu báo cáo tài chính TMIII |

## Thuật ngữ kế toán chung

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk` | Tài khoản |
| `ten_tk` | Tên tài khoản |
| `tk_me` | Tài khoản mẹ |
| `tk_du` | Tài khoản đối ứng |
| `tk_cn` | Tài khoản công nợ |
| `du_no` | Dư nợ |
| `du_co` | Dư có |
| `du_no_nt` | Dư nợ ngoại tệ |
| `du_co_nt` | Dư có ngoại tệ |
| `ma_ct` | Mã chứng từ |
| `ten_ct` | Tên chứng từ |
| `ma_bp` | Mã bộ phận |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |
| `so_hieu` | Số hiệu chứng từ |
| `stt` | Số thứ tự |
| `ctgs` | Chứng từ ghi sổ |
| `dgtg` | Đánh giá tỷ giá |
| `kc` | Kết chuyển |
| `cltg` | Chênh lệch tỷ giá |

## Framework Forms

| Form Base | Mô tả |
|-----------|-------|
| `frmDMView` | Form danh mục chuẩn |
| `frmDMEdit` | Form nhập liệu danh mục |
| `frmDMComplexView` | Form danh mục phức tạp |
| `frmDMComplexEdit` | Form nhập liệu danh mục phức tạp |
| `frmOBView` | Form opening balance |
| `frmOBEdit` | Form nhập opening balance |
| `frmAsiaRoot` | Form root của Asia ERP |

---

*Ngày cập nhật: 2026-03-29*

---

## Tổng kết Module GL

Module GL (General Ledger) bao gồm đầy đủ các chức năng:

### Vouchers (Chứng từ)
- Quản lý số dư đầu kỳ (GLCDTK)
- Nghiệp vụ ghi sổ (GLNB, GLVchGL1)
- Chuyển số liệu vào sổ cái (GLPost2GL)
- Đánh giá tỷ giá (GLPost2DGTG)
- Kết chuyển tự động (GLPost2GLKC)
- Chuyển số dư sang năm sau (GLTransferGLCDTK)

### Reports (Báo cáo)
- **BCPT**: Bảng cân đối phát sinh các loại
- **BCT**: Báo cáo thuế GTGT, tờ khai
- **BCTC**: 4 báo cáo tài chính chính (BCTC01-04)
- **BCTCCDT**: Báo cáo tài chính chi tiết
- **BCTCCR**: Báo cáo theo Thông tư 03
- **NKC**: Nhật ký chung và sổ cái
- **CTGS**: Chứng từ ghi sổ
- **F5**: Các báo cáo drill-down

### Masters (Danh mục)
- Danh mục tài khoản (GLDMTK)
- Ngân sách (GLBudget)
- Chứng từ ghi sổ (GLDMCTGS, GLDKCTGS)
- Đánh giá tỷ giá (GLDMDGTG)
- Kết chuyển tự động (GLDMKC)

### Financial Statements (Mẫu báo cáo tài chính)
- Đầy đủ các mẫu báo cáo tài chính theo chuẩn mực kế toán Việt Nam

---

## Danh sách đầy đủ báo cáo GL

### BCPT - Báo cáo Cân đối Phát sinh
- BCPT01: Bảng cân đối phát sinh các tiểu tài khoản của một tài khoản
- BCPT02: Bảng cân đối phát sinh một tài khoản theo ngày
- BCPT03: Bảng cân đối kế toán theo kỳ
- BCPT04: Bảng cân đối phát sinh một tài khoản theo chứng từ
- BCPT05: Báo cáo kết quả hoạt động sản xuất kinh doanh
- BCPT08: Báo cáo kết quả hoạt động sản xuất kinh doanh (Mẫu PL01)

### BCT - Báo cáo Thuế
- BCT01: Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào (Thuế GTGT đầu vào)
- BCT02: Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ bán ra (Thuế GTGT đầu ra)
- BCT03: Tờ khai giá trị gia tăng (Tờ khai GTGT)
- BCT04: Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp
- BCT05: Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp (Phiên bản 5)
- BCT06: Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp (Phiên bản 6)

### BCTC - Báo cáo Tài chính
- BCTC01: Bảng cân đối phát sinh các tài khoản (Trial Balance)
- BCTC02: Bảng cân đối kế toán (Balance Sheet)
- BCTC03: Báo cáo kết quả hoạt động kinh doanh (Income Statement)
- BCTC04: Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp (Cash Flow Statement)

### BCTCCDT - Báo cáo Tài chính Chi tiết
- BCTCCDTB02: Báo cáo tài chính chi tiết B02
- BCTCCDTB03: Báo cáo tài chính chi tiết B03
- BCTCCDTF02: Báo cáo tài chính chi tiết F02
- BCTCCDTF03A: Báo cáo tài chính chi tiết F03A (xây lắp)
- BCTCCDTF03B: Báo cáo tài chính chi tiết F03B
- BCTCCDTF03C: Báo cáo tài chính chi tiết F03C
- BCTCCDTF03D: Báo cáo tài chính chi tiết F03D

### BCTCCR - Báo cáo Tài chính (Thông tư 03)
- BCTCCR01: Bảng cân đối phát sinh
- BCTCCR01F5: Drill-down báo cáo CCR01
- BCTCCR02: Bảng cân đối kế toán
- BCTCCR03: Báo cáo kết quả hoạt động kinh doanh
- BCTCCR04: Báo cáo lưu chuyển tiền tệ (phương pháp trực tiếp)

---

## Chi tiết báo cáo Nhật ký chung (NKC)

### NKC01 - Sổ cái
- **Mục đích**: Hiển thị sổ cái cho một tài khoản cụ thể
- **Tham số**: CompanyID, Ngày bắt đầu, Ngày kết thúc, Tài khoản, Mã ngoại tệ
- **Tính năng**: Auto-lookup tài khoản, tính dư đầu/cuối kỳ

### NKC01 All - Bảng cân đối phát sinh các tài khoản
- **Mục đích**: Bảng cân đối phát sinh cho tất cả các tài khoản
- **Tham số**: CompanyID, Ngày bắt đầu, Ngày kết thúc, Tài khoản, Bậc, Mã ngoại tệ
- **Tính năng**: 2 mẫu báo cáo, lọc theo bậc TK, đánh STT theo sổ NKC, drill-down đa dạng (F5, Ctrl+F5, Shift+F5)

### NKC02 - Sổ nhật ký chung
- **Mục đích**: Sổ nhật ký chung tổng hợp
- **Tham số**: CompanyID, Ngày bắt đầu, Ngày kết thúc, Mã ngoại tệ
- **Tính năng**: Chọn kỳ báo cáo, chọn mẫu báo cáo, xuất Excel

### NKC03 - Sổ nhật ký thu tiền
- **Mục đích**: Theo dõi các giao dịch thu tiền
- **Tham số**: CompanyID, Ngày bắt đầu, Ngày kết thúc, Danh sách TK nợ, Danh sách TK có, Mã bộ phận, Mã ngoại tệ
- **Tính năng**: Lọc theo bộ phận, nhập danh sách tài khoản nợ/có

### NKC04 - Sổ nhật ký bán hàng
- **Mục đích**: Theo dõi các giao dịch bán hàng
- **Tham số**: CompanyID, Ngày bắt đầu, Ngày kết thúc, TK phải thu, TKDT hàng hóa, TKDT thành phẩm, TKDT dịch vụ, Mã ngoại tệ
- **Tính năng**: Phân loại doanh thu theo 4 nhóm (hàng hóa, thành phẩm, dịch vụ, phải thu)

### NKC05 - Sổ nhật ký mua hàng
- **Mục đích**: Theo dõi các giao dịch mua hàng
- **Tham số**: CompanyID, Ngày bắt đầu, Ngày kết thúc, TK phải trả, TK hàng hóa, TK NVL, TK kho khác, Mã ngoại tệ
- **Tính năng**: Phân loại chi phí theo 4 nhóm (hàng hóa, NVL, kho khác, phải trả)

### NKC06 - Sổ chi tiết các tài khoản
- **Mục đích**: Hiển thị chi tiết phát sinh của một tài khoản
- **Tham số**: CompanyID, Ngày bắt đầu, Ngày kết thúc, Tài khoản, Mã ngoại tệ
- **Tính năng**: Tính toán số dư đầu kỳ và cuối kỳ

### NKC07 - Sổ cái chữ T của một tài khoản
- **Mục đích**: Hiển thị sổ cái theo định dạng chữ T (T-Account)
- **Tham số**: CompanyID, Ngày bắt đầu, Ngày kết thúc, Tài khoản, Mã ngoại tệ
- **Tính năng**: Tổng hợp phát sinh theo tài khoản đối ứng, drill-down theo TK đối ứng (F5)

### NKC08 - Nhật ký chung 08
- **Mục đích**: Báo cáo nhật ký chung dạng mở rộng
- **Tham số**: CompanyID, Ngày bắt đầu, Ngày kết thúc, Tài khoản
- **Tính năng**: Form lớn (790x510), không hỗ trợ lọc theo ngoại tệ

### NKCTNK1 - Nhật ký chung tổng hợp theo tài khoản
- **Mục đích**: Báo cáo nhật ký chung tổng hợp theo một tài khoản
- **Tham số**: CompanyID, Ngày bắt đầu, Ngày kết thúc, Tài khoản
- **Tính năng**: Tổng hợp (không chi tiết), focus vào txtTk khi click tab

### NKCTSoCai - Nhật ký chung tổng hợp sổ cái
- **Mục đích**: Báo cáo nhật ký chung tổng hợp sổ cái
- **Tham số**: CompanyID, Ngày bắt đầu, Ngày kết thúc, Tài khoản
- **Tính năng**: Tập trung vào sổ cái (ledger), tương tự NKCTNK1