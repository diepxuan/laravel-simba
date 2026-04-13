# CO_SUMMARY - Tổng quan Module Giá thành (Cost Accounting)

## Tổng quan

Tài liệu này tổng hợp thông tin từ **19 DLL** thuộc module CO (Cost Accounting - Kế toán giá thành) của hệ thống ERP Asia Enterprise.

---

## Danh sách DLL

### I. Danh mục (Master Data) - 8 DLL

| # | DLL | Tên chức năng | Loại | Mô tả ngắn |
|---|-----|---------------|------|------------|
| 1 | **CODMSPCT** | Danh mục công trình | Danh mục | Quản lý sản phẩm công trình (SPCT) |
| 2 | **CODMNHSPCT** | Danh mục nhóm SPCT | Danh mục | Phân nhóm sản phẩm công trình |
| 3 | **CODMBOM** | Định mức nguyên vật liệu | Danh mục | Quản lý BOM (Bill of Materials) |
| 4 | **CODMBOM_** | Định mức NVL (alt) | Danh mục | Phiên bản thay thế CODMBOM |
| 5 | **CODD1** | Định mức chi tiết | Danh mục | Khai báo định mức chi phí theo SPCT |
| 6 | **CODMPB** | Danh mục phân bổ | Danh mục | Khai báo bút toán phân bổ tự động |
| 7 | **CoDMCPTT** | Danh mục CPTT | Danh mục | Quản lý chi phí tập trung |
| 8 | **COLK** | Liên kết | Danh mục | Khai báo liên kết kết chuyển |
| 9 | **CoNgungKHCPTT** | Ngừng phân bổ CPTT | Danh mục | Đánh dấu ngừng phân bổ chi phí |

### II. Nghiệp vụ (Transaction) - 4 DLL

| # | DLL | Tên chức năng | Loại | Mô tả ngắn |
|---|-----|---------------|------|------------|
| 10 | **COPB** | Phân bổ tự động | Nghiệp vụ | Thực hiện bút toán phân bổ chi phí |
| 11 | **CoCalcCost** | Tính giá thành | Nghiệp vụ | Tính toán và cập nhật giá thành SPCT |
| 12 | **CoPostCPTT2GL** | Post chi phí sang GL | Nghiệp vụ | Ghi sổ chi phí tập trung sang tổng hợp |
| 13 | **CoDelPostCP2GL** | Xóa post chi phí | Nghiệp vụ | Xóa bút toán post chi phí sang GL |

### III. Báo cáo (Reports) - 6 DLL

| # | DLL | Tên chức năng | Loại | Mô tả ngắn |
|---|-----|---------------|------|------------|
| 14 | **CORptGt01** | Báo cáo giá thành 01 | Báo cáo | Báo cáo GT có chi tiết vật tư |
| 15 | **CORptGt02** | Báo cáo giá thành 02 | Báo cáo | Báo cáo GT theo SPCT |
| 16 | **CORptGt03** | Báo cáo giá thành 03 | Báo cáo | Báo cáo GT nâng cao |
| 17 | **COGDBGT** | Giá định biên GT | Báo cáo | Báo cáo giá định biên giá thành |
| 18 | **CoRptCTPBCPTT** | Báo cáo chi tiết PB | Báo cáo | Chi tiết phân bổ CPTT |
| 19 | **CoRptKHCPTT** | Báo cáo khai báo CPTT | Báo cáo | Danh sách khai báo chi phí tập trung |

---

## Chi tiết từng DLL

### 1. CODMSPCT - Danh mục sản phẩm công trình

**Chức năng**: Quản lý danh mục sản phẩm/công trình - đối tượng tính giá thành chính.

**Fields chính**:
- `ma_spct`: Mã sản phẩm chi tiết
- `ten_spct`: Tên sản phẩm chi tiết

**Forms**: `frmCODMSPCT` (kế thừa frmDMView)

**Đặc điểm**: Hỗ trợ chế độ chỉ xem (par1="1") và phím tắt F3/F4/F8.

---

### 2. CODMNHSPCT - Danh mục nhóm sản phẩm công trình

**Chức năng**: Phân loại sản phẩm công trình theo nhóm.

**Fields chính**:
- `cap`: Cấp độ nhóm
- `stt_nhom`: Số thứ tự nhóm

**Forms**: `frmCODMNHSPCT`, `frmCODMNHSPCTEdit`

---

### 3. CODMBOM - Định mức nguyên vật liệu

**Chức năng**: Quản lý định mức BOM (Bill of Materials) - cấu trúc sản phẩm.

**Fields chính**:
- `ma_spct`: Mã sản phẩm chi tiết
- `ma_vt`: Mã vật tư
- `so_luong`: Số lượng định mức
- `don_gia_luong`: Đơn giá nhân công
- `vt_chinh`: Vật tư chính
- `ngay1`, `ngay2`: Ngày hiệu lực

**Forms**: `frmCODMBOM` (kế thừa frmAsiaRoot)

**DAO**: ICODMBOMDAO, MsSqlCODMBOMDAO

**Stored Procedures**:
- asCOGetDMCobomPH/CT
- asCOInsDMCoBomPH/CT
- asCOUpdDMCoBomPH
- asCODelDMCobomPH/CT

---

### 4. CODD1 - Định mức chi tiết

**Chức năng**: Khai báo định mức chi phí theo sản phẩm chi tiết.

**Fields chính**:
- `ma_spct`: Mã sản phẩm chi tiết
- `tk`: Tài khoản kế toán
- `so_luong`: Số lượng định mức
- `tien`: Giá trị/Chi phí định mức
- `nam`, `thang`: Năm/tháng áp dụng

**Forms**: `frmCoDD1`, `frmCoDD1Edit`, `frmCoDD1Filter`

---

### 5. CODMPB - Danh mục bút toán phân bổ tự động

**Chức năng**: Khai báo các bút toán phân bổ chi phí tự động.

**Fields chính**:
- `tk`: Tài khoản kế toán
- `ten_tk`: Tên tài khoản

**Forms**: `frmCODMPB` (kế thừa frmDMComplexView)

**UI**: SplitContainer với dgvCTPB hiển thị chi tiết phân bổ.

---

### 6. CoDMCPTT - Danh mục chi phí tập trung

**Chức năng**: Quản lý chi phí tập trung cần phân bổ dần.

**Fields chính**:
- `ma_cptt`, `ten_cptt`: Mã và tên chi phí
- `so_luong`, `don_gia`, `ng_gia`: Số lượng, đơn giá, nguyên giá
- `so_ky`: Số kỳ phân bổ
- `gt_da_kh`, `gt_cl`: Giá trị đã khấu hao, còn lại
- `kh_ky`: Giá trị phân bổ 1 kỳ
- `ngay_bdkh`, `ngay_gt_cl`: Ngày bắt đầu, ngày GTCL
- `tk_cptt`, `tk_cp`: TK phân bổ, TK chi phí
- `ma_bpsd`, `ma_spct`, `MA_PHI`: Bộ phận, SPCT, mã phí

**Forms**: `frmCoDMCPTT`, `frmCoDMCPTTEdit`

**Tính toán tự động**:
- Nguyên giá = Số lượng × Đơn giá
- Giá trị còn lại = Nguyên giá - Giá trị đã phân bổ
- Giá trị phân bổ 1 kỳ = Nguyên giá / Số kỳ

---

### 7. COLK - Liên kết

**Chức năng**: Khai báo liên kết dữ liệu cho bút toán kết chuyển.

**Fields chính**:
- `lk`: Liên kết
- `nam`: Năm tài chính

**Forms**: `frmCoLk`, `frmCoLkEdit`, `frmCOLKFilter`

---

### 8. CoNgungKHCPTT - Ngừng phân bổ chi phí tập trung

**Chức năng**: Đánh dấu thời điểm ngừng phân bổ chi phí.

**Fields chính**:
- `ma_cptt`: Mã chi phí
- `ng_gia`: Nguyên giá (read-only)
- `ngay_bdkh`: Ngày bắt đầu phân bổ (read-only)
- `ngay_tkh`: Ngày tháng ngừng phân bổ
- `kh_so_du`: Phân bổ nốt số dư

**Forms**: `frmCoNgungKhCPTT`, `frmCoNgungKhCPTTEdit`

**Stored Procedures**:
- asCoUpdNgungKH_CPTT
- asCoDelNgungKH_CPTT

---

### 9. COPB - Bút toán phân bổ tự động

**Chức năng**: Thực hiện phân bổ chi phí tự động.

**Fields chính**:
- `tk_pb`: TK phân bổ
- `tien_pb`: Tiền phân bổ
- `he_so`: Hệ số phân bổ
- `tien_nhan`: Tiền nhận phân bổ
- `ma_spct`, `ma_bo`: SPCT, bộ phận
- `tk_du`: TK đối ứng

**Forms**: `frmCOPB` (kế thừa frmAsiaRoot)

**UI Components**:
- `cboKyBc`: Kỳ báo cáo
- `dgvDMPB`, `dgvDMPB2`: 2 DataGridView master-detail
- `btn_PB`, `btn_XPB`: Phân bổ/Xóa phân bổ

**DAO**: COPBDAO

---

### 10. CoCalcCost - Tính giá thành

**Chức năng**: Tính toán và cập nhật giá thành sản phẩm.

**Fields chính**:
- `TK`: Tài khoản dở dang
- `ngay_ks`: Ngày khóa sổ
- `ma_spct`: Mã sản phẩm chi tiết

**Forms**: `frmCoCalcCost` (kế thừa frmReport2DGV)

**UI Components**:
- `dgvBCPh`, `dgvBCCt`: 2 DataGridView master-detail
- `btnUpdate`: Cập nhật GT
- `btnDelUpdate`: Xóa cập nhật GT
- `crvReportViewer`: Crystal Report viewer

---

### 11. CoPostCPTT2GL - Post chi phí sang GL

**Chức năng**: Ghi sổ chi phí tập trung sang tổng hợp.

**Fields chính**:
- `KyBc`: Kỳ báo cáo
- `nam`: Năm
- `ngay_ks`: Ngày khóa sổ

**Forms**: `frmCoPostCPTT2GL` (kế thừa frmCalc)

**Error Codes**: 50010 (lỗi), 50015 (thành công), 50136 (ngày khóa sổ)

---

### 12. CoDelPostCP2GL - Xóa post chi phí sang GL

**Chức năng**: Xóa bút toán post chi phí đã chuyển sang GL.

**Fields chính**:
- `KyBc`: Kỳ báo cáo
- `nam`: Năm

**Forms**: `frmCoDelPostCP2GL` (kế thừa frmCalc)

---

### 13-15. CORptGt01/02/03 - Báo cáo giá thành

**Chức năng**: Các loại báo cáo giá thành.

| Báo cáo | Đặc điểm |
|---------|----------|
| CORptGt01 | Có chi tiết vật tư (chkCt_vt) |
| CORptGt02 | Hiển thị tên SPCT đầy đủ |
| CORptGt03 | Báo cáo nâng cao |

**Fields chung**:
- `tk`, `ten_tk`: Tài khoản
- `ma_spct`, `ten_spct`: Sản phẩm
- `nam`, `thang1`, `thang2`: Thời gian

**Forms**: `frmCORptGt01/02/03` (kế thừa frmReport)

---

### 16. COGDBGT - Giá định biên giá thành

**Chức năng**: Báo cáo giá định biên theo tài khoản chi phí.

**Fields chính**:
- `tk`, `ten_tk`: Tài khoản
- `nam`, `thang1`, `thang2`: Thời gian

**Forms**: `frmCOGDBGT` (kế thừa frmReport)

---

### 17. CoRptCTPBCPTT - Báo cáo chi tiết phân bổ CPTT

**Chức năng**: Báo cáo chi tiết các bút toán phân bổ chi phí.

**Fields chính**:
- `Ma_bpsd`: Bộ phận sử dụng
- `Ma_cp`: Mã chi phí
- `Tk_pb`, `Tk_cp`: TK phân bổ, TK chi phí
- `Ma_phi`: Mã phí
- `Ma_spct`: Mã SPCT

**Forms**: `frmCoRptCTPBCPTT` (kế thừa frmReport)

---

### 18. CoRptKHCPTT - Báo cáo khai báo chi phí tập trung

**Chức năng**: Báo cáo danh sách chi phí tập trung đã khai báo.

**Fields chính**:
- `Ma_bpsd`: Bộ phận sử dụng

**Forms**: `frmCoRptKHCPTT` (kế thừa frmReport)

---

## Quy trình xử lý điển hình

### Tính giá thành sản phẩm

```
1. Khai báo danh mục
   └─> CODMSPCT: Danh mục SPCT
   └─> CODMNHSPCT: Nhóm SPCT
   └─> CODMBOM: Định mức NVL
   └─> CODD1: Định mức chi tiết
   └─> CoDMCPTT: Chi phí tập trung
   └─> CODMPB: Bút toán phân bổ

2. Xử lý nghiệp vụ
   └─> COPB: Phân bổ chi phí
   └─> CoCalcCost: Tính giá thành
   └─> CoPostCPTT2GL: Post sang GL

3. Báo cáo
   └─> CORptGt01/02/03: Báo cáo giá thành
   └─> COGDBGT: Giá định biên
   └─> CoRptCTPBCPTT: Chi tiết phân bổ
```

---

## Technical Summary

### Framework
- **.NET Framework**: 3.5
- **Ngôn ngữ**: C#
- **UI**: Windows Forms
- **Database**: SQL Server

### Kiến trúc
- **Pattern**: DAO (Data Access Object)
- **Base Forms**: frmDMView, frmDMComplexView, frmAsiaRoot, frmReport, frmCalc
- **Data Access**: Stored Procedures qua MsSqlDAO

### Dependencies chung
- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data
- CrystalDecisions.Windows.Forms (một số module)

---

## Tham chiếu

- [docs/asia/co/README.md](co/README.md) - Tài liệu chính module CO
- [docs/asia/co/vouchers/](co/vouchers/) - Tài liệu chi tiết từng DLL

---

*Ngày tổng hợp: 2026-03-29*
