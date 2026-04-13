# Báo cáo Phân tích DLL: GLMAUBCTCTMVI11.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLMAUBCTCTMVI11 |
| Assembly Title | GLBCTC07V09 |
| Assembly Company | (trống) |
| Assembly Product | GLBCTC07V09 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Trademark | (trống) |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | de80061a-33f9-4bf2-9939-3a34f3f95c1a |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMVI11.dll/
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMVI11.cs    # Main form class (danh mục view)
│   └── frmGLMAUBCTCTMVI11Edit.cs # Edit form (nhập liệu chỉ tiêu)
├── AsiaErp.UserInterface.My/
│   ├── MySettingsProperty.cs    # Settings property
│   ├── MyComputer.cs            # Computer helper
│   ├── MyApplication.cs         # Application helper
│   ├── InternalXmlHelper.cs     # XML helper
│   ├── MyProject.cs             # Project info
│   └── MySettings.cs            # Application settings
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| AsiaErp.Framework | Asia ERP Framework |
| AsiaErp.Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMVI11` | `frmDMComplexView` | Form xem danh sách chỉ tiêu báo cáo tài chính |
| `frmGLMAUBCTCTMVI11Edit` | `frmDMComplexEdit` | Form nhập/sửa chỉ tiêu báo cáo |
| `Resources` | - | Resource manager cho localization |

---

## Chi tiết Form Edit (frmGLMAUBCTCTMVI11Edit)

### Controls chính

| Control | Loại | Mục đích |
|---------|------|----------|
| txtMa_chtieu | AsTextBox | Mã chỉ tiêu |
| txtMauQD | AsTextBox | Mẫu quyết định |
| txtChi_tieu | TextBox | Tên chỉ tiêu |
| txtNd_chtieu | TextBox (Multiline) | Nội dung chỉ tiêu |
| txtCach_tinh | TextBox | Công thức tính |
| txtTk1-txtTk7 | AsTextBox | Tài khoản 1-7 |
| lblTK1-lblTK7 | Label | Hiển thị tên tài khoản |
| cboLoai_ps | AsComboBox | Loại phát sinh |
| ChkIs_print | CheckBox | Có in |
| ChkIs_italic | CheckBox | In nghiêng |
| chkKsd | AsCheckBox | In đậm |

### Loại phát sinh (cboLoai_ps)

| Key | Value |
|-----|-------|
| "" | (trống) |
| NODK | Dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ |
| NOCK | Dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ |
| PSNO | Phát sinh nợ |
| PSCO | Phát sinh có |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu |
| `nd_chtieu` | Nội dung chỉ tiêu |
| `cach_tinh` | Công thức tính |
| `loai_ps` | Loại phát sinh |
| `tk_01` đến `tk_07` | Tài khoản 1-7 |
| `mau` | Mẫu quyết định |
| `IsPrint` | Có in |
| `IsItalic` | In nghiêng |
| `bold` | In đậm |

---

## Mục đích sử dụng

**GLMAUBCTCTMVI11.dll là module quản lý danh mục chỉ tiêu báo cáo tài chính** theo Thông tư số 200/2014/TT-BTC (mẫu BCTC07 - Bảng cân đối kế toán).

### Chức năng chính

#### 1. Quản lý danh mục chỉ tiêu
- Mã chỉ tiêu báo cáo tài chính
- Tên chỉ tiêu và nội dung mô tả
- Gắn với mẫu quyết định (QĐ công bố)

#### 2. Cấu hình tài khoản kế toán
- Hỗ trợ tối đa 7 tài khoản kế toán cho mỗi chỉ tiêu
- Lookup tài khoản tự động (LookupCodeName = "TK")
- Hiển thị tên tài khoản tương ứng

#### 3. Công thức tính
- Lưu trữ công thức tính toán chỉ tiêu
- Hỗ trợ loại phát sinh: Dư nợ/có đầu kỳ, Dư nợ/có cuối kỳ, Phát sinh nợ/có

#### 4. Định dạng in ấn
- Tùy chọn có in chỉ tiêu
- Định dạng in đậm
- Định dạng in nghiêng

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Validation dữ liệu đầu vào (mã chỉ tiêu, tên chỉ tiêu không được trống)
- AutoComplete cho tài khoản kế toán
- Kế thừa từ frmDMComplexEdit/frmDMComplexView của Framework

### Mã chứng từ

**GLMAUBCTCTMVI11** - Danh mục chỉ tiêu mẫu Báo cáo tài chính (BCTC07 - Bảng cân đối kế toán) theo Thông tư 200.

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia, phục vụ cho việc cấu hình danh mục chỉ tiêu báo cáo tài chính theo chuẩn Thông tư 200/2014/TT-BTC của Bộ Tài chính Việt Nam. Module cho phép người dùng định nghĩa các chỉ tiêu, gắn tài khoản kế toán và công thức tính toán tương ứng.

---

*Ngày phân tích: 2026-03-29*
