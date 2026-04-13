# Báo cáo Phân tích DLL: GLMAUBCTCTMV23.dll

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
| Assembly Name | GLMAUBCTCTMV23 |
| Assembly Title | GLBCTC07V23 |
| Assembly Product | GLBCTC07V23 |
| Assembly Copyright | Copyright ©  2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 0af75de9-3674-4038-8add-a90552f3da95 |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV23.dll/
├── GLMAUBCTCTMV23.csproj        # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMV23.cs     # Main form class (View)
│   └── frmGLMAUBCTCTMV23Edit.cs # Edit form class
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
| `frmGLMAUBCTCTMV23` | `frmDMComplexView` | Form xem danh sách mẫu báo cáo tài chính V23 |
| `frmGLMAUBCTCTMV23Edit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu báo cáo |

---

## Form Controls (frmGLMAUBCTCTMV23Edit)

| Control | Type | Mục đích |
|---------|------|----------|
| txtMa_chtieu | AsTextBox | Mã chỉ tiêu |
| txtChi_tieu | TextBox | Tên chỉ tiêu |
| txtNd_chtieu | TextBox | Nội dung chỉ tiêu (Multiline) |
| txtCach_tinh | TextBox | Công thức tính toán |
| txtTaikhoan | AsTextBox | Tài khoản kế toán (Lookup TK) |
| lblTK | Label | Hiển thị tên tài khoản |
| cboLoai_ps | AsComboBox | Loại phát sinh |
| txtMauQD | TextBox | Mẫu quyết định |
| ChkIs_print | CheckBox | Có in |
| ChkIs_italic | CheckBox | In nghiêng |
| chkKsd | AsCheckBox | In đậm |

---

## Loại phát sinh (cboLoai_ps)

| Key | Value | Ý nghĩa |
|-----|-------|---------|
| "" | "" | Không chọn |
| NODK | Dư nợ đầu kỳ | Số dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ | Số dư có đầu kỳ |
| NOCK | Dư nợ cuối kỳ | Số dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ | Số dư có cuối kỳ |
| PSNO | Phát sinh nợ | Phát sinh bên nợ |
| PSCO | Phát sinh có | Phát sinh bên có |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã chỉ tiêu" - Mã số chỉ tiêu báo cáo
- "Chỉ tiêu" - Tên chỉ tiêu
- "Nội dung chỉ tiêu" - Diễn giải chi tiết
- "Công thức" - Cách tính chỉ tiêu
- "Tài khoản" - Tài khoản kế toán liên quan
- "Loại phát sinh" - Loại phát sinh (NODK, CODK, PSNO...)
- "In đậm", "In nghiêng", "Có in" - Tùy chọn in ấn

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã số chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu |
| `nd_chtieu` | Nội dung chỉ tiêu |
| `cach_tinh` | Cách tính/Công thức |
| `tk_01` | Tài khoản 01 |
| `loai_ps` | Loại phát sinh |
| `mau` | Mẫu quyết định |
| `IsPrint` | Có in hay không |
| `IsItalic` | In nghiêng |
| `bold` | In đậm |

---

## Mục đích sử dụng

**GLMAUBCTCTMV23.dll là module quản lý mẫu Báo cáo tài chính V23** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu (ma_so) theo quyết định V23
- Nhập tên chỉ tiêu và nội dung chi tiết
- Thiết lập công thức tính toán cho chỉ tiêu
- Liên kết với tài khoản kế toán (Lookup TK)

#### 2. Phân loại phát sinh
- Hỗ trợ 6 loại phát sinh: NODK, CODK, NOCK, COCK, PSNO, PSCO
- Cho phép chọn loại phát sinh phù hợp cho từng chỉ tiêu

#### 3. Tùy chọn định dạng in ấn
- Chọn in hoặc không in chỉ tiêu (Có in)
- Định dạng in đậm (In đậm)
- Định dạng in nghiêng (In nghiêng)

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với BindingSource (bsDanhMuc)
- Validation dữ liệu đầu vào (mã chỉ tiêu, tên chỉ tiêu bắt buộc)
- Lookup tài khoản tự động (AutoLookup)
- ComboBox loại phát sinh với DataSource từ ArrayList
- Kế thừa từ frmDMComplexEdit/frmDMComplexView của Framework

### Mã báo cáo

**V23** - Mẫu báo cáo tài chính theo quyết định số 23 (Thông tư kế toán Việt Nam).

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia, phục vụ cho việc cấu hình và quản lý mẫu Báo cáo tài chính theo quyết định V23, với khả năng phân loại phát sinh đa dạng.

---

*Ngày phân tích: 2026-03-29*
