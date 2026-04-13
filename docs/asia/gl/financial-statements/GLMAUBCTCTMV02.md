# GLMAUBCTCTMV02 - Mẫu báo cáo tài chính V02

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLMAUBCTCTMV02.dll |
| Loại | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Chức năng | Quản lý mẫu báo cáo tài chính V02 |

## Chức năng chính

### 1. Quản lý chỉ tiêu báo cáo tài chính V02
- Định nghĩa mã chỉ tiêu và tên chỉ tiêu
- Nhập nội dung chi tiết cho từng chỉ tiêu
- Cấu hình công thức tính toán cho chỉ tiêu
- Gắn tài khoản kế toán liên quan (tk_01)
- Gán mẫu quyết định (theo quy định của Bộ Tài chính)

### 2. Định dạng in ấn
- Tùy chọn in đậm (bold)
- Tùy chọn in nghiêng (italic)
- Tùy chọn có in hay không (IsPrint)

### 3. Quản lý dữ liệu
- Thêm mới chỉ tiêu
- Sửa đổi thông tin chỉ tiêu
- Xóa chỉ tiêu (nếu được phép)
- Xem danh sách chỉ tiêu

## Controls và UI Components

### frmGLMAUBCTCTMV02Edit

| Control | Loại | Mục đích |
|---------|------|----------|
| txtMa_chtieu | AsTextBox | Mã chỉ tiêu (Uppercase, AutoComplete) |
| txtChi_tieu | TextBox | Tên chỉ tiêu |
| txtNd_chtieu | TextBox (Multiline) | Nội dung chỉ tiêu |
| txtCong_thuc | TextBox | Công thức tính toán |
| txtTaikhoan | AsTextBox | Tài khoản (Lookup Code: TK) |
| lblTK | Label | Hiển thị tên tài khoản |
| txtMauQD | AsTextBox | Mẫu quyết định |
| ChkIs_print | CheckBox | Có in hay không |
| ChkIs_italic | CheckBox | In nghiêng |
| chkKsd | AsCheckBox | In đậm (bold) |

## Business Logic

### Data Binding

| Field | Control | Property |
|-------|---------|----------|
| mau | txtMauQD | Text |
| ma_so | txtMa_chtieu | Text |
| chi_tieu | txtChi_tieu | Text |
| nd_chtieu | txtNd_chtieu | Text |
| cach_tinh | txtCong_thuc | Text |
| tk_01 | txtTaikhoan | Text |
| IsItalic | ChkIs_italic | Checked |
| IsPrint | ChkIs_print | Checked |
| bold | chkKsd | Checked |

### Validation

- **Mã chỉ tiêu**: Bắt buộc nhập (không được để trống)
- **Chỉ tiêu**: Bắt buộc nhập (không được để trống)
- **Mẫu QĐ**: Tự động lấy từ `CompanyInformations.Qd_cdkt` nếu để trống

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmGLMAUBCTCTMV02` | `frmDMComplexView` | Form xem danh sách mẫu BCTC V02 |
| `frmGLMAUBCTCTMV02Edit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu BCTC V02 |

## Dependencies

- `Microsoft.VisualBasic` - Visual Basic runtime support
- `Framework` - Asia ERP Framework
- `Helper` - Asia ERP Helper

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLMAUBCTCTMV02 |
| Assembly Title | GLBCTC07V02 |
| Assembly Product | GLBCTC07V02 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| GUID | fd320180-3362-4ff5-944d-42ce790ecc50 |

---

*Ngày cập nhật: 2026-03-29*
