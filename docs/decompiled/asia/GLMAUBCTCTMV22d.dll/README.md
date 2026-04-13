# Báo cáo Phân tích DLL: GLMAUBCTCTMV22d.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLMAUBCTCTMV22d |
| Assembly Title | GLBCTC07V22d |
| Assembly Product | GLBCTC07V22d |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 0155120e-d167-4792-8b1c-be79bcb8ccc9 |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV22d.dll/
├── GLMAUBCTCTMV22d.csproj       # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMV22d.cs    # Main form (view)
│   └── frmGLMAUBCTCTMV22dEdit.cs # Edit form
├── AsiaErp.UserInterface.My/
│   ├── MySettings.cs            # Application settings
│   ├── MySettingsProperty.cs    # Settings property
│   ├── MyProject.cs             # MyProject wrapper
│   ├── MyComputer.cs            # MyComputer wrapper
│   └── MyApplication.cs         # MyApplication wrapper
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.UserInterface.My`
- `System`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMV22d` | `frmDMComplexView` | Form xem danh sách mẫu báo cáo tài chính |
| `frmGLMAUBCTCTMV22dEdit` | `frmDMComplexEdit` | Form chỉnh sửa/cập nhật chỉ tiêu báo cáo |
| `Resources` | - | Resource manager cho localization |
| `MySettings` | `ApplicationSettingsBase` | Quản lý cấu hình ứng dụng |

---

## Chi tiết Form Edit (frmGLMAUBCTCTMV22dEdit)

### Controls trên form

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

### Data Binding (Database Fields)

| Field | Control | Kiểu dữ liệu |
|-------|---------|--------------|
| ma_so | txtMa_chtieu | String (code_length từ DictComplexInfo) |
| chi_tieu | txtChi_tieu | String |
| nd_chtieu | txtNd_chtieu | String (multiline) |
| cach_tinh | txtCach_tinh | String (max 50 ký tự) |
| tk_01 | txtTaikhoan | String (tài khoản kế toán) |
| mau | txtMauQD | String (mặc định = CompanyInformations.Qd_cdkt) |
| IsPrint | ChkIs_print | Boolean |
| IsItalic | ChkIs_italic | Boolean |
| bold | chkKsd | Boolean |

### Validation Rules

1. **Mã chỉ tiêu (txtMa_chtieu)**: Bắt buộc nhập, max length = `code_length`
2. **Chỉ tiêu (txtChi_tieu)**: Bắt buộc nhập
3. **Mẫu QĐ (txtMauQD)**: Nếu rỗng, tự động gán = `CompanyInformations.Qd_cdkt`
4. **Nội dung chỉ tiêu**: Trim khoảng trắng đầu/cuối

### Events và Business Logic

| Event/Method | Mô tả |
|--------------|-------|
| `InitBeforeGetData()` | Thiết lập max length cho mã chỉ tiêu, focus vào txtMa_chtieu |
| `ValidData()` | Kiểm tra dữ liệu hợp lệ trước khi lưu |
| `InsertToDB()` | Thực hiện insert, focus lại mã nếu lỗi |
| `DisableFields()` | Vô hiệu hóa fields khi ở chế độ view, focus vào chỉ tiêu |
| `DataBinding()` | Bind controls với DataTable |
| `frmGLMAUBCTCTMV22dEdit_Load()` | Set ChkIs_print = true khi thêm mới |
| `ProcessKeyPreview()` | Xử lý phím tắt (bỏ qua nếu focus ở txtNd_chtieu) |

---

## Các chuỗi Text đáng chú ý

### Nhãn UI

| Label | Text |
|-------|------|
| Label1 | Mã chỉ tiêu |
| Label2 | Chỉ tiêu |
| Label4 | Nội dung chỉ tiêu |
| Label6 | Công thức |
| Label8 | Tài khoản |

### CheckBox

| Control | Text | Ý nghĩa |
|---------|------|---------|
| ChkIs_print | Có in | Hiển thị trên báo cáo |
| ChkIs_italic | In nghiêng | Định dạng in nghiêng |
| chkKsd | In đậm | Định dạng in đậm |

---

## Mục đích sử dụng

**GLMAUBCTCTMV22d.dll là module quản lý mẫu báo cáo tài chính** theo Thông tư 200/2014/TT-BTC (mẫu V22d - Báo cáo tình hình tài chính).

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu (ma_so) theo quy định
- Nhập tên chỉ tiêu và nội dung chi tiết
- Liên kết với tài khoản kế toán (tk_01)
- Hỗ trợ lookup tài khoản từ bảng TK

#### 2. Công thức tính toán
- Nhập công thức tính giá trị chỉ tiêu (cach_tinh)
- Công thức có thể tham chiếu đến các tài khoản khác
- Max 50 ký tự cho công thức

#### 3. Định dạng in ấn
- Tùy chọn có in / không in chỉ tiêu
- Định dạng in đậm (bold)
- Định dạng in nghiêng (italic)
- Mẫu quy định (mau) theo QĐ của công ty

#### 4. Quản lý theo mẫu QĐ
- Mỗi chỉ tiêu thuộc về một mẫu quyết định (mau)
- Mặc định lấy từ `CompanyInformations.Qd_cdkt`
- Hỗ trợ nhiều mẫu báo cáo khác nhau

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable (bsDanhMuc)
- Kế thừa từ `frmDMComplexEdit` - framework chuẩn của Asia ERP
- Sử dụng `AsTextBox` với AutoLookup cho tài khoản
- Validation tích hợp sẵn qua `epNotice` (ErrorProvider)
- Hỗ trợ chế độ Edit/View với `DisableFields()`

### Mã báo cáo

**V22d** - Báo cáo tình hình tài chính theo Thông tư 200/2014/TT-BTC (hoặc QĐ 15, QĐ 48 cũ).

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia, phục vụ cho việc cấu hình và quản lý các chỉ tiêu trong mẫu báo cáo tài chính V22d. Module cho phép người dùng định nghĩa các chỉ tiêu, công thức tính toán, liên kết tài khoản kế toán và tùy chỉnh định dạng in ấn.

---

*Ngày phân tích: 2026-03-29*
