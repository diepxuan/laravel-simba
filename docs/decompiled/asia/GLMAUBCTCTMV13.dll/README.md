# Báo cáo Phân tích DLL: GLMAUBCTCTMV13.dll

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
| Assembly Name | GLMAUBCTCTMV13 |
| Assembly Title | GLBCTC07V13 |
| Assembly Product | GLBCTC07V13 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | a26594bc-3068-4cf4-92c6-9cca9ef4e36a |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV13.dll/
├── GLMAUBCTCTMV13.csproj        # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMV13.cs     # Main form class (view)
│   └── frmGLMAUBCTCTMV13Edit.cs # Edit form class
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
- `System`, `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMV13` | `frmDMComplexView` | Form xem danh sách chỉ tiêu báo cáo tài chính V13 |
| `frmGLMAUBCTCTMV13Edit` | `frmDMComplexEdit` | Form nhập liệu chỉ tiêu báo cáo tài chính V13 |

---

## Các trường dữ liệu chính (frmGLMAUBCTCTMV13Edit)

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

### Tùy chọn hiển thị

| Control | Thuộc tính | Ý nghĩa |
|---------|------------|---------|
| ChkIs_print | IsPrint | Có in |
| ChkIs_italic | IsItalic | In nghiêng |
| chkKsd | bold | In đậm |

---

## Mục đích sử dụng

**GLMAUBCTCTMV13.dll là module quản lý mẫu báo cáo tài chính V13** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu, tên chỉ tiêu, nội dung chỉ tiêu
- Cấu hình công thức tính toán cho chỉ tiêu
- Liên kết với 1 tài khoản kế toán

#### 2. Tùy chọn in ấn
- Có in / Không in chỉ tiêu
- Định dạng in: đậm, nghiêng

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- AutoLookup cho tài khoản (LookupCodeName = "TK")
- Validation dữ liệu đầu vào
- Tích hợp với Asia ERP Framework

### So sánh với V12

V13 có cấu trúc tương tự V12:
- Cùng sử dụng 1 tài khoản
- Không có trường công trình
- Không có dropdown loại phát sinh
- Có thể là phiên bản cập nhật hoặc mẫu báo cáo khác của V12

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc cấu hình và quản lý mẫu báo cáo tài chính V13 - một mẫu báo cáo đơn giản theo quy định của Bộ Tài chính Việt Nam.

---

*Ngày phân tích: 2026-03-29*
