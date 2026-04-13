# CARptTMNH06.dll - Báo cáo tiền mặt/ngân hàng 06

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CARptTMNH06.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCARptTMNH06 |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo sổ chi tiết vay (Crystal Report) |

## 2. Forms chi tiết

### frmCARptTMNH06

**Controls:**
| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_TK | AsTextBox | Tài khoản (bắt buộc) |
| lblMa_TK | Label | Nhãn "Tài khoản" |
| lblTen_TK | Label | Tên tài khoản (hiển thị) |
| txtMa_ku | AsTextBox | Mã khế ước (ẩn) |
| lblMa_ku | Label | Nhãn "Mã khế ước" (ẩn) |
| lblTen_ku | Label | Tên khế ước (ẩn) |
| crvReportViewer | CrystalReportViewer | Viewer báo cáo Crystal |

**Kế thừa từ frmReport:**
- txtNgay1, txtNgay2: Kỳ báo cáo
- cboKyBc: Chọn kỳ
- cboMau_bc: Chọn mẫu báo cáo
- txtMa_Nt: Mã ngoại tệ
- optVND, optNt: Chọn loại tiền
- txtTieu_De: Tiêu đề báo cáo

**Events:**
- `ValidData()`: Kiểm tra bắt buộc nhập tài khoản
- `LoadData()`: Load dữ liệu báo cáo
  - Parameters: CompanyID, Ngày1, Ngày2, TK, Mã KU, Mã NT
- `GetFilterTitle()`: Lấy tiêu đề filter cho báo cáo

**Business Logic:**
- Bắt buộc nhập tài khoản
- Có thể lọc theo khế ước (mặc định ẩn)
- Sử dụng Crystal Report để hiển thị báo cáo
- Hiển thị sổ chi tiết vay

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| (Theo cấu hình Controller) | Lấy dữ liệu sổ chi tiết vay |

## 4. Mapping PHP

Không áp dụng (đây là form báo cáo, không phải voucher).

---

**Lưu ý:** 
- Sử dụng Crystal Report Viewer để hiển thị báo cáo
- Có thể xuất ra nhiều định dạng (PDF, Excel, Word...)
