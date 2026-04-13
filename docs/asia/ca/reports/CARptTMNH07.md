# Phân tích DLL: CARptTMNH07.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CARptTMNH07.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCARptTMNH07 |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo tổng hợp vay nợ theo tài khoản và khế ước |

## 2. Forms chi tiết

### frmCARptTMNH07

**Controls:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtTk | AsTextBox | Tài khoản (bắt buộc) |
| lblTen_Tk | Label | Tên tài khoản (hiển thị) |
| lblTk | Label | Nhãn "Tài khoản" |
| txtMa_ku | AsTextBox | Mã khế ước |
| lblTen_ku | Label | Tên khế ước (hiển thị) |
| Label2 | Label | Nhãn "Mã khế ước" |

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
- Có thể lọc theo khế ước
- Hiển thị báo cáo tổng hợp vay nợ

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CARptTMNH07 | Lấy dữ liệu tổng hợp vay nợ |

## 4. Parameters

| Parameter | Type | Mô tả |
|-----------|------|-------|
| CompanyID | int | ID công ty |
| TK | varchar | Tài khoản |
| Ma_KU | varchar | Mã khế ước (có thể null) |
| Ngay1 | date | Ngày bắt đầu |
| Ngay2 | date | Ngày kết thúc |
| Ma_NT | varchar | Mã ngoại tệ |

---

**Lưu ý:** 
- Báo cáo tổng hợp vay nợ
- Có thể xem theo tài khoản tổng hợp hoặc chi tiết theo khế ước
