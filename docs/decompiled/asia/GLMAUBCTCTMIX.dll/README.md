# Báo cáo Phân tích DLL: GLMAUBCTCTMIX.dll

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
| Assembly Name | GLMAUBCTCTMIX |
| Assembly Title | GLBCTC071234 |
| Assembly Company | |
| Assembly Product | GLBCTC071234 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 62801a54-c3fa-401f-997f-89c27d89262f |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMIX.dll/
├── GLMAUBCTCTMIX.csproj        # Project file
├── app.ico                       # Application icon
├── Properties/
│   └── AssemblyInfo.cs           # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMIX.cs         # Main view form
│   └── frmGLMAUBCTCTMIXEdit.cs     # Edit form
└── AsiaErp.UserInterface.My/
    ├── MySettings.cs
    ├── MyProject.cs
    ├── MySettingsProperty.cs
    ├── MyComputer.cs
    ├── MyApplication.cs
    └── InternalXmlHelper.cs
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs              # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML LINQ support |
| System.Core | .NET Core extensions |
| Framework | Asia ERP Framework (native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections.Generic`, `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMIX` | `frmDMComplexView` | Form xem danh sách mẫu báo cáo tài chính IX |
| `frmGLMAUBCTCTMIXEdit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu báo cáo tài chính IX |
| `Resources` | - | Resource manager cho localization |

---

## Controls và UI Components

### frmGLMAUBCTCTMIXEdit

| Control | Loại | Mục đích |
|---------|------|----------|
| txtMa_chtieu | AsTextBox | Mã chỉ tiêu (Uppercase, AutoComplete) |
| txtChi_tieu | TextBox | Tên chỉ tiêu |
| txtNd_chtieu | TextBox (Multiline) | Nội dung chỉ tiêu |
| txtMauQD | AsTextBox | Mẫu quyết định |
| ChkIs_print | CheckBox | Có in hay không |
| ChkIs_italic | CheckBox | In nghiêng |
| chkKsd | AsCheckBox | In đậm (bold) |

---

## Business Logic

### Data Binding

| Field | Control | Property |
|-------|---------|----------|
| mau | txtMauQD | Text |
| ma_so | txtMa_chtieu | Text |
| chi_tieu | txtChi_tieu | Text |
| nd_chtieu | txtNd_chtieu | Text |
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
| Load | frmGLMAUBCTCTMIXEdit_Load | Set default IsPrint = true khi thêm mới |

---

## Mục đích sử dụng

**GLMAUBCTCTMIX.dll là module quản lý Mẫu báo cáo tài chính IX** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính IX
- Định nghĩa mã chỉ tiêu và tên chỉ tiêu
- Nhập nội dung chi tiết cho từng chỉ tiêu
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
- Sử dụng WeakReference list để quản lý memory (ENC pattern)

### Mã báo cáo

**BCTC IX** - Báo cáo tài chính IX (theo Thông tư 200/2014/TT-BTC hoặc QĐ 15/2006/QĐ-BTC)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc cấu hình và quản lý mẫu báo cáo tài chính IX - một báo cáo tài chính quan trọng trong kế toán doanh nghiệp Việt Nam.

---

*Ngày phân tích: 2026-03-29*
