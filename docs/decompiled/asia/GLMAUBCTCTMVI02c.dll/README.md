# Báo cáo Phân tích DLL: GLMAUBCTCTMVI02c.dll

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
| Assembly Name | GLMAUBCTCTMVI02c |
| Assembly Title | GLBCTC07V02 |
| Assembly Product | GLBCTC07V02 |
| Assembly Copyright | Copyright ©  2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | fd320180-3362-4ff5-944d-42ce790ecc50 |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMVI02c.dll/
├── GLMAUBCTCTMVI02c.csproj      # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMVI02c.cs   # Main form class (View)
│   └── frmGLMAUBCTCTMVI02cEdit.cs # Edit form class
└── AsiaErp.UserInterface.My/
    ├── MyApplication.cs
    ├── MyComputer.cs
    ├── MyProject.cs
    ├── MySettings.cs
    ├── MySettingsProperty.cs
    └── InternalXmlHelper.cs
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
- `System`, `System.Collections.Generic`, `System.ComponentModel`, `System.Diagnostics`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMVI02c` | `frmDMComplexView` | Form xem danh sách mẫu báo cáo tài chính I02c |
| `frmGLMAUBCTCTMVI02cEdit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu báo cáo |

---

## Form Controls (frmGLMAUBCTCTMVI02cEdit)

| Control | Type | Mục đích |
|---------|------|----------|
| txtMa_chtieu | AsTextBox | Mã chỉ tiêu |
| txtChi_tieu | TextBox | Tên chỉ tiêu |
| txtNd_chtieu | TextBox | Nội dung chỉ tiêu (Multiline) |
| txtCong_thuc | TextBox | Công thức tính toán |
| txtTaikhoan | AsTextBox | Tài khoản kế toán (Lookup TK) |
| lblTK | Label | Hiển thị tên tài khoản |
| txtMauQD | AsTextBox | Mẫu quyết định |
| ChkIs_print | CheckBox | Có in |
| ChkIs_italic | CheckBox | In nghiêng |
| chkKsd | AsCheckBox | In đậm |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã chỉ tiêu" - Mã số chỉ tiêu báo cáo
- "Chỉ tiêu" - Tên chỉ tiêu
- "Nội dung chỉ tiêu" - Diễn giải chi tiết
- "Công thức" - Cách tính chỉ tiêu
- "Tài khoản" - Tài khoản kế toán liên quan
- "In đậm", "In nghiêng", "Có in" - Tùy chọn in ấn

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã số chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu |
| `nd_chtieu` | Nội dung chỉ tiêu |
| `cach_tinh` | Cách tính/Công thức |
| `tk_01` | Tài khoản 01 |
| `mau` | Mẫu quyết định |
| `IsPrint` | Có in hay không |
| `IsItalic` | In nghiêng |
| `bold` | In đậm |

---

## Mục đích sử dụng

**GLMAUBCTCTMVI02c.dll là module quản lý mẫu Báo cáo tài chính I02c** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu (ma_so) theo quyết định I02c
- Nhập tên chỉ tiêu và nội dung chi tiết
- Thiết lập công thức tính toán cho chỉ tiêu
- Liên kết với tài khoản kế toán (Lookup TK)

#### 2. Tùy chọn định dạng in ấn
- Chọn in hoặc không in chỉ tiêu (Có in)
- Định dạng in đậm (In đậm)
- Định dạng in nghiêng (In nghiêng)

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với BindingSource (bsDanhMuc)
- Validation dữ liệu đầu vào (mã chỉ tiêu, tên chỉ tiêu bắt buộc)
- Lookup tài khoản tự động (AutoLookup)
- Kế thừa từ frmDMComplexEdit/frmDMComplexView của Framework
- Sử dụng WeakReference để quản lý memory

### Mã báo cáo

**I02c** - Mẫu báo cáo tài chính theo quyết định số I02c (Thông tư kế toán Việt Nam).

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia, phục vụ cho việc cấu hình và quản lý mẫu Báo cáo tài chính theo quyết định I02c.

---

*Ngày phân tích: 2026-03-29*
