# Phân tích DLL: CARptTMNH03.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CARptTMNH03.dll |
| **Namespace** | AsiaERP.UserInterface |
| **Forms** | frmCARptTMNH03 |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo sổ chi tiết vay theo khế ước |

## 2. Forms chi tiết

### frmCARptTMNH03

**Controls:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtTk | AsTextBox | Tài khoản vay (bắt buộc) |
| lblTen_Tk | Label | Tên tài khoản (hiển thị) |
| lblTk | Label | Nhãn "Tài khoản vay" |
| txtMa_ku | AsTextBox | Mã khế ước |
| lblTen_ku | Label | Tên khế ước (hiển thị) |
| lblMa_ku | Label | Nhãn "Mã khế ước" |

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
| LoadData | Load dữ liệu báo cáo |
| GetFilterTitle | Lấy tiêu đề filter cho báo cáo |

**Business Logic:**

- Bắt buộc nhập tài khoản vay
- Có thể lọc theo khế ước cụ thể
- Hiển thị chi tiết phát sinh vay theo từng khế ước

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CARptTMNH03 | Lấy dữ liệu chi tiết vay theo KU |

## 4. Parameters

| Parameter | Type | Mô tả |
|-----------|------|-------|
| CompanyID | int | ID công ty |
| Ngay1 | date | Ngày bắt đầu |
| Ngay2 | date | Ngày kết thúc |
| TK | varchar | Tài khoản vay |
| Ma_KU | varchar | Mã khế ước (có thể null) |
| Ma_NT | varchar | Mã ngoại tệ |

---

**Lưu ý:** 
- Báo cáo chi tiết vay theo khế ước
- Theo dõi lịch sử vay, trả gốc, trả lãi của từng KU
