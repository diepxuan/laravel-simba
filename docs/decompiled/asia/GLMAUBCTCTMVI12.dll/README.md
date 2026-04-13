# Báo cáo Phân tích DLL: GLMAUBCTCTMVI12.dll

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
| Assembly Name | GLMAUBCTCTMVI12 |
| Assembly Title | GLBCTC07V09 |
| Assembly Product | GLBCTC07V09 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | de80061a-33f9-4bf2-9939-3a34f3f95c1a |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMVI12.dll/
├── GLMAUBCTCTMVI12.csproj       # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMVI12.cs    # Main view form class
│   └── frmGLMAUBCTCTMVI12Edit.cs # Edit form class
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML LINQ support |
| System.Core | .NET Core extensions |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMVI12` | `frmDMComplexView` | Form xem danh sách mẫu báo cáo tài chính I12 |
| `frmGLMAUBCTCTMVI12Edit` | `frmDMComplexEdit` | Form chỉnh sửa mẫu báo cáo tài chính I12 |
| `Resources` | - | Resource manager cho localization |

---

## Các controls và trường dữ liệu chính

### Form Edit (frmGLMAUBCTCTMVI12Edit)

| Control | Kiểu | Mục đích |
|---------|------|----------|
| txtMa_chtieu | AsTextBox | Mã chỉ tiêu báo cáo |
| txtChi_tieu | TextBox | Tên chỉ tiêu |
| txtNd_chtieu | TextBox | Nội dung chỉ tiêu |
| txtCach_tinh | TextBox | Cách tính chỉ tiêu |
| txtMauQD | AsTextBox | Mẫu quyết định |
| txtTaikhoan | AsTextBox | Tài khoản |
| lblTK | Label | Nhãn tài khoản |
| ChkIs_print | CheckBox | Có in hay không |
| ChkIs_italic | CheckBox | In nghiêng |

---

## Các chuỗi Text đáng chú ý

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_chtieu` | Mã chỉ tiêu |
| `chi_tieu` | Chỉ tiêu |
| `nd_chtieu` | Nội dung chỉ tiêu |
| `cach_tinh` | Cách tính |
| `mau_QD` | Mẫu quyết định |
| `taikhoan` | Tài khoản |
| `is_print` | Có in |
| `is_italic` | In nghiêng |

---

## Mục đích sử dụng

**GLMAUBCTCTMVI12.dll là module quản lý mẫu báo cáo tài chính I12** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý mẫu báo cáo tài chính I12
- Định nghĩa mã chỉ tiêu báo cáo
- Quản lý tên chỉ tiêu và nội dung
- Cấu hình cách tính cho từng chỉ tiêu
- Hỗ trợ 1 tài khoản kế toán (đơn giản hơn I10/I11)

#### 2. Tùy chỉnh hiển thị
- Tùy chọn in/nghiêng cho từng chỉ tiêu
- Quản lý mẫu quyết định áp dụng

#### 3. Tích hợp Framework
- Kế thừa từ `frmDMComplexView` và `frmDMComplexEdit`
- Sử dụng `AsTextBox` từ Framework
- Binding dữ liệu với DataTable

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Kiểm tra validation dữ liệu đầu vào
- Hỗ trợ localization qua Resources
- Tích hợp với Asia ERP Framework
- Cấu trúc đơn giản hơn I10/I11 (chỉ 1 tài khoản)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia, phục vụ cho việc cấu hình mẫu báo cáo tài chính I12 - một loại báo cáo tài chính theo quy định của Việt Nam. Module này có cấu trúc đơn giản hơn I10/I11 với chỉ 1 trường tài khoản.

---

*Ngày phân tích: 2026-03-29*
