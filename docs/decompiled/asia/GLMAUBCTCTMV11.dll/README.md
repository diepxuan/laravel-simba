# Báo cáo Phân tích DLL: GLMAUBCTCTMV11.dll

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
| Assembly Name | GLMAUBCTCTMV11 |
| Assembly Title | GLBCTC07V11 |
| Assembly Product | GLBCTC07V11 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 134e7253-c2a0-47cc-97e4-277592d844ec |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV11.dll/
├── GLMAUBCTCTMV11.csproj        # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMV11.cs     # Main form class (view)
│   └── frmGLMAUBCTCTMV11Edit.cs # Edit form class
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
| `frmGLMAUBCTCTMV11` | `frmDMComplexView` | Form xem danh sách chỉ tiêu báo cáo tài chính V11 |
| `frmGLMAUBCTCTMV11Edit` | `frmDMComplexEdit` | Form nhập liệu chỉ tiêu báo cáo tài chính V11 |

---

## Các trường dữ liệu chính (frmGLMAUBCTCTMV11Edit)

### Thông tin chỉ tiêu

| Control | Thuộc tính | Ý nghĩa |
|---------|------------|---------|
| txtMa_chtieu | ma_so | Mã chỉ tiêu |
| txtChi_tieu | chi_tieu | Tên chỉ tiêu |
| txtNd_chtieu | nd_chtieu | Nội dung chỉ tiêu |
| txtCach_tinh | cach_tinh | Công thức tính |
| txtMauQD | mau | Mẫu quyết định |

### Tài khoản và công trình

| Control | Thuộc tính | Ý nghĩa |
|---------|------------|---------|
| txtTaikhoan | tk_01 | Tài khoản kế toán |
| txtCongTrinh | ma_spct | Mã công trình/sản phẩm chi tiết |

### Tùy chọn hiển thị

| Control | Thuộc tính | Ý nghĩa |
|---------|------------|---------|
| ChkIs_print | IsPrint | Có in |
| ChkIs_italic | IsItalic | In nghiêng |
| chkKsd | bold | In đậm |

---

## Mục đích sử dụng

**GLMAUBCTCTMV11.dll là module quản lý mẫu báo cáo tài chính V11** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu, tên chỉ tiêu, nội dung chỉ tiêu
- Cấu hình công thức tính toán cho chỉ tiêu
- Liên kết với 1 tài khoản kế toán

#### 2. Quản lý công trình
- Hỗ trợ mã công trình/sản phẩm chi tiết (ma_spct)
- LookupCodeName = "MA_SPCT"
- LookupWhereCondition = "SAN_PHAM <> '1'" (chỉ lấy công trình, không lấy sản phẩm)

#### 3. Tùy chọn in ấn
- Có in / Không in chỉ tiêu
- Định dạng in: đậm, nghiêng

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- AutoLookup cho tài khoản (LookupCodeName = "TK")
- AutoLookup cho công trình (LookupCodeName = "MA_SPCT")
- Validation dữ liệu đầu vào
- Tích hợp với Asia ERP Framework

### Khác biệt so với V08-V10

V11 khác biệt đáng kể so với các phiên bản trước:
- Chỉ hỗ trợ 1 tài khoản thay vì 6-7 tài khoản
- Thêm trường công trình (ma_spct) để quản lý theo công trình
- Không có dropdown loại phát sinh
- Phù hợp với báo cáo tài chính theo dõi công trình

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc cấu hình và quản lý mẫu báo cáo tài chính V11 - một mẫu báo cáo theo dõi công trình theo quy định của Bộ Tài chính Việt Nam.

---

*Ngày phân tích: 2026-03-29*
