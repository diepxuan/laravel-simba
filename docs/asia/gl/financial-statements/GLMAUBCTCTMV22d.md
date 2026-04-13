# GLMAUBCTCTMV22d - Mẫu báo cáo tài chính V22d

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLMAUBCTCTMV22d.dll |
| Loại | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Chức năng | Quản lý mẫu báo cáo tài chính V22d |

## Chức năng chính

### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu (ma_so) theo quy định
- Nhập tên chỉ tiêu và nội dung chi tiết
- Liên kết với tài khoản kế toán (tk_01)
- Hỗ trợ lookup tài khoản từ bảng TK

### 2. Công thức tính toán
- Nhập công thức tính giá trị chỉ tiêu (cach_tinh)
- Công thức có thể tham chiếu đến các tài khoản khác
- Max 50 ký tự cho công thức

### 3. Định dạng in ấn
- Tùy chọn có in / không in chỉ tiêu
- Định dạng in đậm (bold)
- Định dạng in nghiêng (italic)
- Mẫu quy định (mau) theo QĐ của công ty

### 4. Quản lý theo mẫu QĐ
- Mỗi chỉ tiêu thuộc về một mẫu quyết định (mau)
- Mặc định lấy từ `CompanyInformations.Qd_cdkt`
- Hỗ trợ nhiều mẫu báo cáo khác nhau

## Controls trên form Edit

| Control | Loại | Mục đích |
|---------|------|----------|
| txtMa_chtieu | AsTextBox | Mã chỉ tiêu (khóa chính) |
| txtChi_tieu | TextBox | Tên chỉ tiêu |
| txtNd_chtieu | TextBox (Multiline) | Nội dung chỉ tiêu |
| txtCach_tinh | TextBox | Công thức tính toán |
| txtTaikhoan | AsTextBox | Tài khoản kế toán (lookup TK) |
| lblTK | Label | Hiển thị tên tài khoản |
| txtMauQD | TextBox | Mẫu quyết định |
| ChkIs_print | CheckBox | Có in (mặc định checked khi thêm mới) |
| ChkIs_italic | CheckBox | In nghiêng |
| chkKsd | AsCheckBox | In đậm (bold) |

## Data Binding

| Field | Control | Kiểu dữ liệu |
|-------|---------|--------------|
| ma_so | txtMa_chtieu | String |
| chi_tieu | txtChi_tieu | String |
| nd_chtieu | txtNd_chtieu | String (multiline) |
| cach_tinh | txtCach_tinh | String (max 50 ký tự) |
| tk_01 | txtTaikhoan | String (tài khoản kế toán) |
| mau | txtMauQD | String |
| IsPrint | ChkIs_print | Boolean |
| IsItalic | ChkIs_italic | Boolean |
| bold | chkKsd | Boolean |

## Validation Rules

1. **Mã chỉ tiêu (txtMa_chtieu)**: Bắt buộc nhập
2. **Chỉ tiêu (txtChi_tieu)**: Bắt buộc nhập
3. **Mẫu QĐ (txtMauQD)**: Nếu rỗng, tự động gán = `CompanyInformations.Qd_cdkt`

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu |
| `nd_chtieu` | Nội dung chỉ tiêu |
| `cach_tinh` | Công thức tính |
| `tk_01` | Tài khoản |
| `mau` | Mẫu quyết định |
| `IsItalic` | In nghiêng |
| `IsPrint` | Có in |
| `bold` | In đậm |

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmGLMAUBCTCTMV22d` | `frmDMComplexView` | Form xem danh sách mẫu BCTC |
| `frmGLMAUBCTCTMV22dEdit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu BCTC |

## Mã báo cáo

**V22d** - Báo cáo tình hình tài chính theo Thông tư 200/2014/TT-BTC (hoặc QĐ 15, QĐ 48 cũ).

## Dependencies

- `Microsoft.VisualBasic` - Visual Basic runtime support
- `Framework` - Asia ERP Framework
- `Helper` - Asia ERP Helper

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLMAUBCTCTMV22d |
| Assembly Title | GLBCTC07V22d |
| Assembly Product | GLBCTC07V22d |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| GUID | 0155120e-d167-4792-8b1c-be79bcb8ccc9 |

---

*Ngày cập nhật: 2026-03-29*
