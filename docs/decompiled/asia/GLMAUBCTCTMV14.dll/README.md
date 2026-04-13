# Báo cáo Phân tích DLL: GLMAUBCTCTMV14.dll

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
| Assembly Name | GLMAUBCTCTMV14 |
| Assembly Title | GLBCTC07V14 |
| Assembly Product | GLBCTC07V14 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 660f2b56-eb3f-4ea0-a35c-35e3908fbf30 |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV14.dll/
├── GLMAUBCTCTMV14.csproj        # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMV14.cs     # Main form class (view)
│   └── frmGLMAUBCTCTMV14Edit.cs # Edit form class
└── AsiaErp.UserInterface.My/
    ├── MySettingsProperty.cs
    ├── MyComputer.cs
    ├── MyApplication.cs
    ├── MyProject.cs
    ├── MySettings.cs
    └── Resources/
        └── Resources.cs
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
- `System`, `System.Collections`, `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMV14` | `frmDMComplexView` | Form xem danh sách chỉ tiêu báo cáo tài chính V14 |
| `frmGLMAUBCTCTMV14Edit` | `frmDMComplexEdit` | Form nhập liệu chỉ tiêu báo cáo tài chính V14 |

---

## Các trường dữ liệu chính (frmGLMAUBCTCTMV14Edit)

### Thông tin chỉ tiêu

| Control | Thuộc tính | Ý nghĩa |
|---------|------------|---------|
| txtMa_chtieu | ma_so | Mã chỉ tiêu |
| txtChi_tieu | chi_tieu | Tên chỉ tiêu |
| txtNd_chtieu | nd_chtieu | Nội dung chỉ tiêu |
| txtCach_tinh | cach_tinh | Công thức tính |
| txtMauQD | mau | Mẫu quyết định |

### Tài khoản kế toán

| Control | Thuộc tính | Ý nghĩa |
|---------|------------|---------|
| txtTaikhoan | tk_01 | Tài khoản kế toán |

### Loại dư đầu kỳ và cuối kỳ

| Control | Thuộc tính | Ý nghĩa |
|---------|------------|---------|
| cboLoai_ps_dk | loai_ps_dk | Loại dư đầu kỳ |
| cboLoai_ps_ck | loai_ps_ck | Loại dư cuối kỳ |

### Tùy chọn hiển thị

| Control | Thuộc tính | Ý nghĩa |
|---------|------------|---------|
| ChkIs_print | IsPrint | Có in |
| ChkIs_italic | IsItalic | In nghiêng |
| chkKsd | bold | In đậm |

---

## Loại dư đầu kỳ (LoaiPS_DK)

| Key | Value |
|-----|-------|
| NODK | Dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ |
| NODKCN | Dư nợ đầu kỳ công nợ |
| CODKCN | Dư có đầu kỳ công nợ |

## Loại dư cuối kỳ (LoaiPS_CK)

| Key | Value |
|-----|-------|
| NOCK | Dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ |
| NOCKCN | Dư nợ cuối kỳ công nợ |
| COCKCN | Dư có cuối kỳ công nợ |

---

## Mục đích sử dụng

**GLMAUBCTCTMV14.dll là module quản lý mẫu báo cáo tài chính V14** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu, tên chỉ tiêu, nội dung chỉ tiêu
- Cấu hình công thức tính toán cho chỉ tiêu
- Liên kết với 1 tài khoản kế toán

#### 2. Phân loại dư đầu kỳ và cuối kỳ
- Hỗ trợ phân loại dư đầu kỳ: NODK, CODK, NODKCN, CODKCN
- Hỗ trợ phân loại dư cuối kỳ: NOCK, COCK, NOCKCN, COCKCN
- Tính toán tự động theo loại dư được chọn

#### 3. Tùy chọn in ấn
- Có in / Không in chỉ tiêu
- Định dạng in: đậm, nghiêng

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- AutoLookup cho tài khoản (LookupCodeName = "TK")
- Validation dữ liệu đầu vào
- Tích hợp với Asia ERP Framework

### Khác biệt so với V12-V13

V14 khác biệt đáng kể:
- Có 2 dropdown riêng biệt cho loại dư đầu kỳ và cuối kỳ
- Hỗ trợ cả dư công nợ (CN) cho cả đầu kỳ và cuối kỳ
- Phù hợp với báo cáo tài chính cần phân biệt rõ dư đầu/cuối kỳ và công nợ

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc cấu hình và quản lý mẫu báo cáo tài chính V14 - một mẫu báo cáo hỗ trợ phân loại dư đầu kỳ và cuối kỳ (bao gồm công nợ) theo quy định của Bộ Tài chính Việt Nam.

---

*Ngày phân tích: 2026-03-29*
