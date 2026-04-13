# Phân tích DLL: CARptTMNH06.dll

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

| Control | Mô tả |
|---------|-------|
| txtNgay1, txtNgay2 | Kỳ báo cáo |
| cboKyBc | Chọn kỳ |
| cboMau_bc | Chọn mẫu báo cáo |
| txtMa_Nt | Mã ngoại tệ |
| optVND, optNt | Chọn loại tiền |
| txtTieu_De | Tiêu đề báo cáo |

**Events:**

| Event | Mô tả |
|-------|-------|
| ValidData | Kiểm tra bắt buộc nhập tài khoản |
| LoadData | Load dữ liệu báo cáo |
| GetFilterTitle | Lấy tiêu đề filter cho báo cáo |

**Business Logic:**

- Bắt buộc nhập tài khoản
- Có thể lọc theo khế ước (mặc định ẩn)
- Sử dụng Crystal Report để hiển thị báo cáo
- Hiển thị sổ chi tiết vay

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CARptTMNH06 | Lấy dữ liệu sổ chi tiết vay |

## 4. Parameters

| Parameter | Type | Mô tả |
|-----------|------|-------|
| CompanyID | int | ID công ty |
| Ngay1 | date | Ngày bắt đầu |
| Ngay2 | date | Ngày kết thúc |
| TK | varchar | Tài khoản |
| Ma_KU | varchar | Mã khế ước (có thể null) |
| Ma_NT | varchar | Mã ngoại tệ |

---

**Lưu ý:** 
- Sử dụng Crystal Report Viewer để hiển thị báo cáo
- Có thể xuất ra nhiều định dạng (PDF, Excel, Word...)
