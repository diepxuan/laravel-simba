# Báo cáo Phân tích DLL: GLMAUBCTCTMV03.dll

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
| Assembly Name | GLMAUBCTCTMV03 |
| Assembly Title | GLBCTC07V03 |
| Assembly Company | |
| Assembly Product | GLBCTC07V03 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 02332808-eda8-405f-94b6-13bcae3f7fd1 |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV03.dll/
├── GLMAUBCTCTMV03.csproj        # Project file
├── app.ico                        # Application icon
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMV03.cs         # Main view form
│   └── frmGLMAUBCTCTMV03Edit.cs     # Edit form
└── AsiaErp.UserInterface.My/
    ├── MySettings.cs
    ├── MyProject.cs
    ├── MySettingsProperty.cs
    ├── MyComputer.cs
    └── MyApplication.cs
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs               # Resource manager
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
- `System`, `System.Collections`, `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMV03` | `frmDMComplexView` | Form xem danh sách mẫu báo cáo tài chính V03 |
| `frmGLMAUBCTCTMV03Edit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu báo cáo tài chính V03 |
| `Resources` | - | Resource manager cho localization |

---

## Controls và UI Components

### frmGLMAUBCTCTMV03Edit

| Control | Loại | Mục đích |
|---------|------|----------|
| txtMa_chtieu | AsTextBox | Mã chỉ tiêu (Uppercase, AutoComplete) |
| txtChi_tieu | TextBox | Tên chỉ tiêu |
| txtNd_chtieu | TextBox (Multiline) | Nội dung chỉ tiêu |
| txtCach_tinh | TextBox | Cách tính/Công thức |
| txtTaikhoan | AsTextBox | Tài khoản (Lookup Code: TK) |
| lblTK | Label | Hiển thị tên tài khoản |
| cboLoai_ps_dk | AsComboBox | Loại phát sinh đầu kỳ |
| cboLoai_ps_ck | AsComboBox | Loại phát sinh cuối kỳ |
| txtMauQD | AsTextBox | Mẫu quyết định |
| ChkIs_print | CheckBox | Có in hay không |
| ChkIs_italic | CheckBox | In nghiêng |
| chkKsd | AsCheckBox | In đậm (bold) |

---

## Business Logic

### Loại Phát Sinh Đầu Kỳ (LoaiPS_DK)

| Key | Value |
|-----|-------|
| "" | (Trống) |
| NODK | Dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ |
| NODKCN | Dư nợ đầu kỳ công nợ |
| CODKCN | Dư có đầu kỳ công nợ |

### Loại Phát Sinh Cuối Kỳ (LoaiPS_CK)

| Key | Value |
|-----|-------|
| "" | (Trống) |
| NOCK | Dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ |
| NOCKCN | Dư nợ cuối kỳ công nợ |
| COCKCN | Dư có cuối kỳ công nợ |

### Data Binding

| Field | Control | Property |
|-------|---------|----------|
| mau | txtMauQD | Text |
| ma_so | txtMa_chtieu | Text |
| chi_tieu | txtChi_tieu | Text |
| nd_chtieu | txtNd_chtieu | Text |
| cach_tinh | txtCach_tinh | Text |
| loai_ps_dk | cboLoai_ps_dk | SelectedValue |
| loai_ps_ck | cboLoai_ps_ck | SelectedValue |
| tk_01 | txtTaikhoan | Text |
| IsItalic | ChkIs_italic | Checked |
| IsPrint | ChkIs_print | Checked |
| bold | chkKsd | Checked |

### Validation

- **Mã chỉ tiêu**: Bắt buộc nhập (không được để trống)
- **Chỉ tiêu**: Bắt buộc nhập (không được để trống)
- **Mẫu QĐ**: Tự động lấy từ `CompanyInformations.Qd_cdkt` nếu để trống

### Events

| Event | Handler | Mô tả |
|-------|---------|---------|
| Load | frmGLMAUBCTCTMV03Edit_Load | Set default IsPrint = true khi thêm mới; Khởi tạo ComboBox Loại PS |

---

## Mục đích sử dụng

**GLMAUBCTCTMV03.dll là module quản lý Mẫu báo cáo tài chính V03** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính V03
- Định nghĩa mã chỉ tiêu và tên chỉ tiêu
- Nhập nội dung chi tiết cho từng chỉ tiêu
- Cấu hình cách tính/công thức cho chỉ tiêu
- Gắn tài khoản kế toán liên quan (tk_01)
- Chọn loại phát sinh đầu kỳ (Dư nợ/có đầu kỳ, công nợ)
- Chọn loại phát sinh cuối kỳ (Dư nợ/có cuối kỳ, công nợ)
- Gán mẫu quyết định (theo quy định của Bộ Tài chính)

#### 2. Định dạng in ấn
- Tùy chọn in đậm (bold)
- Tùy chọn in nghiêng (italic)
- Tùy chọn có in hay không (IsPrint)

#### 3. Quản lý dữ liệu
- Thêm mới chỉ tiêu
- Sửa đổi thông tin chỉ tiêu
- Xóa chỉ tiêu (nếu được phép)
- Xem danh sách chỉ tiêu

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Kế thừa từ `frmDMComplexEdit` và `frmDMComplexView` của Framework
- Hỗ trợ AutoComplete cho các trường lookup
- Validation dữ liệu đầu vào với ErrorProvider
- Lookup tài khoản (TK) với hiển thị tên tài khoản
- ComboBox có DataSource với DictionaryEntry (Key-Value)
- Static ArrayList cho danh sách Loại PS (khởi tạo lazy)

### Mã báo cáo

**BCTC V03** - Báo cáo tài chính V03 (theo Thông tư 200/2014/TT-BTC hoặc QĐ 15/2006/QĐ-BTC)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc cấu hình và quản lý mẫu báo cáo tài chính V03 - một báo cáo tài chính quan trọng trong kế toán doanh nghiệp Việt Nam. Module này hỗ trợ cấu hình công thức tính toán, loại phát sinh đầu/cuối kỳ và liên kết với tài khoản kế toán.

---

*Ngày phân tích: 2026-03-29*
