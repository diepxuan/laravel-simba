# Báo cáo Phân tích DLL: GLMAUBCTCTMVI25A.dll

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
| Assembly Name | GLMAUBCTCTMVI25A |
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
GLMAUBCTCTMVI25A.dll/
├── GLMAUBCTCTMVI25A.csproj      # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMVI25A.cs   # Main view form class
│   └── frmGLMAUBCTCTMVI25AEdit.cs # Edit form class
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
- `System`, `System.Collections`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMVI25A` | `frmDMComplexView` | Form xem danh sách mẫu báo cáo tài chính I25A |
| `frmGLMAUBCTCTMVI25AEdit` | `frmDMComplexEdit` | Form chỉnh sửa mẫu báo cáo tài chính I25A |
| `Resources` | - | Resource manager cho localization |

---

## Các controls và trường dữ liệu chính

### Form Edit (frmGLMAUBCTCTMVI25AEdit)

| Control | Kiểu | Mục đích |
|---------|------|----------|
| txtMa_chtieu | AsTextBox | Mã chỉ tiêu báo cáo |
| txtChi_tieu | TextBox | Tên chỉ tiêu |
| txtNd_chtieu | TextBox | Nội dung chỉ tiêu |
| txtCach_tinh | TextBox | Cách tính chỉ tiêu |
| txtMauQD | TextBox | Mẫu quyết định |
| txtTk1 - txtTk12 | AsTextBox | Tài khoản từ 1 đến 12 |
| lblTK1 - lblTK12 | Label | Nhãn tài khoản |
| cboLoai_ps | AsComboBox | Loại phát sinh |
| cboNam_ps | AsComboBox | Năm phát sinh |
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
| `tk1-tk12` | Tài khoản 1-12 |
| `loai_ps` | Loại phát sinh |
| `nam_ps` | Năm phát sinh |
| `is_print` | Có in |
| `is_italic` | In nghiêng |

---

## Mục đích sử dụng

**GLMAUBCTCTMVI25A.dll là module quản lý mẫu báo cáo tài chính I25A** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý mẫu báo cáo tài chính I25A
- Định nghĩa mã chỉ tiêu báo cáo
- Quản lý tên chỉ tiêu và nội dung
- Cấu hình cách tính cho từng chỉ tiêu
- Hỗ trợ đến 12 tài khoản kế toán (tk1-tk12) - nhiều nhất trong các mẫu

#### 2. Tùy chỉnh hiển thị và phạm vi
- Tùy chọn in/nghiêng cho từng chỉ tiêu
- Cấu hình loại phát sinh (loai_ps)
- Cấu hình năm phát sinh (nam_ps)
- Quản lý mẫu quyết định áp dụng

#### 3. Tích hợp Framework
- Kế thừa từ `frmDMComplexView` và `frmDMComplexEdit`
- Sử dụng `AsTextBox`, `AsComboBox` từ Framework
- Binding dữ liệu với DataTable

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Kiểm tra validation dữ liệu đầu vào
- Hỗ trợ localization qua Resources
- Tích hợp với Asia ERP Framework
- Hỗ trợ nhiều tài khoản nhất (12 tài khoản)
- Có thêm trường năm phát sinh (nam_ps)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia, phục vụ cho việc cấu hình mẫu báo cáo tài chính I25A - một loại báo cáo tài chính theo quy định của Việt Nam. Module này có cấu trúc phức tạp nhất với hỗ trợ đến 12 tài khoản và thêm trường năm phát sinh.

---

*Ngày phân tích: 2026-03-29*
