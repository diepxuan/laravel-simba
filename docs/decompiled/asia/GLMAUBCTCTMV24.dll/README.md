# Báo cáo Phân tích DLL: GLMAUBCTCTMV24.dll

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
| Assembly Name | GLMAUBCTCTMV24 |
| Assembly Title | GLBCTC07V24 |
| Assembly Product | GLBCTC07V24 |
| Assembly Copyright | Copyright ©  2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 6c93f617-be1e-4cf5-9524-e6bdf3595fea |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV24.dll/
├── GLMAUBCTCTMV24.csproj        # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMV24.cs     # Main form class (View)
│   └── frmGLMAUBCTCTMV24Edit.cs # Edit form class
└── AsiaErp.UserInterface.My/
    ├── MyApplication.cs
    ├── MyComputer.cs
    ├── MyProject.cs
    ├── MySettings.cs
    └── MySettingsProperty.cs
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
- `System`, `System.Collections`, `System.ComponentModel`, `System.Diagnostics`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMV24` | `frmDMComplexView` | Form xem danh sách mẫu báo cáo tài chính V24 |
| `frmGLMAUBCTCTMV24Edit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu báo cáo |

---

## Form Controls (frmGLMAUBCTCTMV24Edit)

| Control | Type | Mục đích |
|---------|------|----------|
| txtMa_chtieu | AsTextBox | Mã chỉ tiêu |
| txtChi_tieu | TextBox | Tên chỉ tiêu |
| txtNd_chtieu | TextBox | Nội dung chỉ tiêu (Multiline) |
| txtCach_tinh | TextBox | Công thức tính toán |
| txtTaikhoan | AsTextBox | Tài khoản kế toán (Lookup TK) |
| lblTK | Label | Hiển thị tên tài khoản |
| cboLoai_ps_dk | AsComboBox | Loại dư đầu kỳ |
| cboLoai_ps_ck | AsComboBox | Loại dư cuối kỳ |
| txtMauQD | TextBox | Mẫu quyết định |
| ChkIs_print | CheckBox | Có in |
| ChkIs_italic | CheckBox | In nghiêng |
| chkKsd | AsCheckBox | In đậm |

---

## Loại dư đầu kỳ (cboLoai_ps_dk)

| Key | Value | Ý nghĩa |
|-----|-------|---------|
| "" | "" | Không chọn |
| NODK | Dư nợ đầu kỳ | Số dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ | Số dư có đầu kỳ |

## Loại dư cuối kỳ (cboLoai_ps_ck)

| Key | Value | Ý nghĩa |
|-----|-------|---------|
| "" | "" | Không chọn |
| NOCK | Dư nợ cuối kỳ | Số dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ | Số dư có cuối kỳ |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã chỉ tiêu" - Mã số chỉ tiêu báo cáo
- "Chỉ tiêu" - Tên chỉ tiêu
- "Nội dung chỉ tiêu" - Diễn giải chi tiết
- "Công thức" - Cách tính chỉ tiêu
- "Tài khoản" - Tài khoản kế toán liên quan
- "Loại dư ĐK" - Loại dư đầu kỳ
- "Loại dư CK" - Loại dư cuối kỳ
- "In đậm", "In nghiêng", "Có in" - Tùy chọn in ấn

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã số chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu |
| `nd_chtieu` | Nội dung chỉ tiêu |
| `cach_tinh` | Cách tính/Công thức |
| `tk_01` | Tài khoản 01 |
| `loai_ps_dk` | Loại phát sinh đầu kỳ |
| `loai_ps_ck` | Loại phát sinh cuối kỳ |
| `mau` | Mẫu quyết định |
| `IsPrint` | Có in hay không |
| `IsItalic` | In nghiêng |
| `bold` | In đậm |

---

## Mục đích sử dụng

**GLMAUBCTCTMV24.dll là module quản lý mẫu Báo cáo tài chính V24** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu (ma_so) theo quyết định V24
- Nhập tên chỉ tiêu và nội dung chi tiết
- Thiết lập công thức tính toán cho chỉ tiêu
- Liên kết với tài khoản kế toán (Lookup TK)

#### 2. Phân loại dư đầu/cuối kỳ riêng biệt
- **Loại dư đầu kỳ**: NODK (Dư nợ), CODK (Dư có)
- **Loại dư cuối kỳ**: NOCK (Dư nợ), COCK (Dư có)
- Cho phép cấu hình riêng biệt cho đầu kỳ và cuối kỳ

#### 3. Tùy chọn định dạng in ấn
- Chọn in hoặc không in chỉ tiêu (Có in)
- Định dạng in đậm (In đậm)
- Định dạng in nghiêng (In nghiêng)

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với BindingSource (bsDanhMuc)
- Validation dữ liệu đầu vào (mã chỉ tiêu, tên chỉ tiêu bắt buộc)
- Lookup tài khoản tự động (AutoLookup)
- Hai ComboBox riêng biệt cho loại dư đầu kỳ và cuối kỳ
- Kế thừa từ frmDMComplexEdit/frmDMComplexView của Framework

### Mã báo cáo

**V24** - Mẫu báo cáo tài chính theo quyết định số 24 (Thông tư kế toán Việt Nam).

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia, phục vụ cho việc cấu hình và quản lý mẫu Báo cáo tài chính theo quyết định V24, với đặc điểm phân biệt riêng loại dư đầu kỳ và loại dư cuối kỳ.

---

*Ngày phân tích: 2026-03-29*
