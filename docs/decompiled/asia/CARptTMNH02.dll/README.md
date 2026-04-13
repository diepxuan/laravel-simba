# CARptTMNH02.dll - Báo cáo tiền mặt/ngân hàng 02

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
- txtNgay1, txtNgay2: Kỳ báo cáo
- cboKyBc: Chọn kỳ
- cboMau_bc: Chọn mẫu báo cáo
- txtMa_Nt: Mã ngoại tệ
- optVND, optNt: Chọn loại tiền
- txtTieu_De: Tiêu đề báo cáo
- cmdOk, cmdCancel, cmdExcel, cmdModifyReport: Các nút chức năng

**Events:**
- `ValidData()`: Kiểm tra bắt buộc nhập tài khoản
- `LoadData()`: Load dữ liệu báo cáo
  - Parameters: CompanyID, TK, Ngày1, Ngày2, Mã NT
- `GetFilterTitle()`: Lấy tiêu đề filter cho báo cáo

**Business Logic:**
- Bắt buộc nhập tài khoản
- Lọc theo kỳ, theo tài khoản, theo ngoại tệ
- Hiển thị sổ quỹ tiền mặt/ngân hàng (dạng sổ quỹ)

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| (Theo cấu hình Controller) | Lấy dữ liệu sổ quỹ TM/NH |

## 4. Mapping PHP

Không áp dụng (đây là form báo cáo, không phải voucher).

---

**Lưu ý:** 
- Báo cáo sổ quỹ tiền mặt/ngân hàng
- Khác với CARptTMNH01 ở cách trình bày (sổ quỹ vs sổ chi tiết)
