# Phân tích DLL: CARptTMNH01.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CARptTMNH01.dll |
| **Namespace** | AsiaERP.UserInterface |
| **Forms** | frmCARptTMNH01 |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo sổ chi tiết tiền mặt/ngân hàng |

## 2. Forms chi tiết

### frmCARptTMNH01

**Controls:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtTk | AsTextBox | Tài khoản (bắt buộc) |
| lblTen_Tk | Label | Tên tài khoản (hiển thị) |
| lblTk | Label | Nhãn "Tài khoản" |

**Kế thừa từ frmReport:**

| Control | Mô tả |
|---------|-------|
| txtNgay1, txtNgay2 | Kỳ báo cáo |
| cboKyBc | Chọn kỳ |
| cboMau_bc | Chọn mẫu báo cáo |
| txtMa_Nt | Mã ngoại tệ |
| optVND, optNt | Chọn loại tiền |
| txtTieu_De | Tiêu đề báo cáo |
| cmdOk, cmdCancel, cmdExcel, cmdModifyReport | Các nút chức năng |

**Events:**

| Event | Mô tả |
|-------|-------|
| InitOtherComponents | Set giá trị mặc định cho txtTk từ par2 |
| ValidData | Kiểm tra bắt buộc nhập tài khoản |
| LoadData | Load dữ liệu báo cáo |
| GetFilterTitle | Lấy tiêu đề filter cho báo cáo |

**Business Logic:**

- Bắt buộc nhập tài khoản
- Lọc theo kỳ, theo tài khoản, theo ngoại tệ
- Hiển thị sổ chi tiết phát sinh của TK tiền mặt/ngân hàng

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CARptTMNH01 | Lấy dữ liệu sổ chi tiết TM/NH |

## 4. Parameters

| Parameter | Type | Mô tả |
|-----------|------|-------|
| CompanyID | int | ID công ty |
| TK | varchar | Tài khoản |
| Ngay1 | date | Ngày bắt đầu |
| Ngay2 | date | Ngày kết thúc |
| Ma_NT | varchar | Mã ngoại tệ |

---

**Lưu ý:** 
- Báo cáo sổ chi tiết tiền mặt/ngân hàng
- Thường là báo cáo 01 trong nhóm báo cáo TM/NH
