# Báo cáo Phân tích DLL: GLMAUBCTCTMV08.dll

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
| Assembly Name | GLMAUBCTCTMV08 |
| Assembly Title | GLBCTC07V08 |
| Assembly Product | GLBCTC07V08 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 76235428-9a04-4384-9205-c595568c4e32 |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV08.dll/
├── GLMAUBCTCTMV08.csproj        # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMV08.cs     # Main form class (view)
│   └── frmGLMAUBCTCTMV08Edit.cs # Edit form class
└── AsiaErp.UserInterface.My/
    ├── MySettingsProperty.cs
    ├── MyComputer.cs
    ├── MyApplication.cs
    ├── MyProject.cs
    └── MySettings.cs
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
- `System`, `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMV08` | `frmDMComplexView` | Form xem danh sách chỉ tiêu báo cáo tài chính V08 |
| `frmGLMAUBCTCTMV08Edit` | `frmDMComplexEdit` | Form nhập liệu chỉ tiêu báo cáo tài chính V08 |

---

## Các trường dữ liệu chính (frmGLMAUBCTCTMV08Edit)

### Thông tin chỉ tiêu

| Control | Thuộc tính | Ý nghĩa |
|---------|------------|---------|
| txtMa_chtieu | ma_so | Mã chỉ tiêu |
| txtChi_tieu | chi_tieu | Tên chỉ tiêu |
| txtNd_chtieu | nd_chtieu | Nội dung chỉ tiêu |
| txtCach_tinh | cach_tinh | Công thức tính |
| txtMauQD | mau | Mẫu quyết định |

### Tài khoản kế toán (6 tài khoản)

| Control | Thuộc tính | Ý nghĩa |
|---------|------------|---------|
| txtTk1 | tk_01 | Tài khoản 1 |
| txtTk2 | tk_02 | Tài khoản 2 |
| txtTk3 | tk_03 | Tài khoản 3 |
| txtTk4 | tk_04 | Tài khoản 4 |
| txtTk5 | tk_05 | Tài khoản 5 |
| txtTk6 | tk_06 | Tài khoản 6 |

### Loại phát sinh

| Control | Thuộc tính | Giá trị |
|---------|------------|---------|
| cboLoai_ps | loai_ps | Loại phát sinh: NODK, CODK, NOCK, COCK, PSNO, PSCO |

### Tùy chọn hiển thị

| Control | Thuộc tính | Ý nghĩa |
|---------|------------|---------|
| ChkIs_print | IsPrint | Có in |
| ChkIs_italic | IsItalic | In nghiêng |
| chkKsd | bold | In đậm |

---

## Loại phát sinh (LoaiPS)

| Key | Value |
|-----|-------|
| NODK | Dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ |
| NOCK | Dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ |
| PSNO | Phát sinh nợ |
| PSCO | Phát sinh có |

---

## Mục đích sử dụng

**GLMAUBCTCTMV08.dll là module quản lý mẫu báo cáo tài chính V08** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu, tên chỉ tiêu, nội dung chỉ tiêu
- Cấu hình công thức tính toán cho chỉ tiêu
- Liên kết với tối đa 6 tài khoản kế toán

#### 2. Phân loại phát sinh
- Hỗ trợ 6 loại phát sinh: Dư nợ/có đầu kỳ, Dư nợ/có cuối kỳ, Phát sinh nợ/có
- Tính toán tự động theo loại phát sinh được chọn

#### 3. Tùy chọn in ấn
- Có in / Không in chỉ tiêu
- Định dạng in: đậm, nghiêng

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- AutoLookup cho tài khoản (LookupCodeName = "TK")
- Validation dữ liệu đầu vào
- Tích hợp với Asia ERP Framework

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc cấu hình và quản lý mẫu báo cáo tài chính V08 - một mẫu báo cáo theo quy định của Bộ Tài chính Việt Nam.

---

*Ngày phân tích: 2026-03-29*
