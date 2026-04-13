# Phân tích DLL: CARptTMNH02.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CARptTMNH02.dll |
| **Namespace** | AsiaERP.UserInterface |
| **Forms** | frmCARptTMNH02 |
| **Kế thừa** | frmReport |
| **Chức năng** | Báo cáo sổ quỹ tiền mặt/ngân hàng |

## 2. Forms chi tiết

### frmCARptTMNH02

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
| ValidData | Kiểm tra bắt buộc nhập tài khoản |
| LoadData | Load dữ liệu báo cáo |
| GetFilterTitle | Lấy tiêu đề filter cho báo cáo |

**Business Logic:**

- Bắt buộc nhập tài khoản
- Lọc theo kỳ, theo tài khoản, theo ngoại tệ
- Hiển thị sổ quỹ tiền mặt/ngân hàng (dạng sổ quỹ)

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CARptTMNH02 | Lấy dữ liệu sổ quỹ TM/NH |

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
- Báo cáo sổ quỹ tiền mặt/ngân hàng
- Khác với CARptTMNH01 ở cách trình bày (sổ quỹ vs sổ chi tiết)
