# Báo cáo Phân tích DLL: SODMTD.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SODMTD |
| Assembly Title | SODMTD |
| Assembly Company | - |
| Assembly Product | SODMTD |
| Assembly Copyright | Copyright © 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 344e6e7e-8297-470e-9df5-42ec2b6508da |
| ComVisible | false |

---

## Cấu trúc File

```
SODMTD.dll/
├── SODMTD.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSODMTD.cs           # Main view form
│   └── frmSODMTDEDIT.cs       # Edit form
└── AsiaErp.UserInterface.My/
    ├── MyProject.cs
    ├── MySettings.cs
    ├── MySettingsProperty.cs
    ├── MyComputer.cs
    ├── MyApplication.cs
    └── InternalXmlHelper.cs
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System | Core .NET Framework |
| System.Drawing | Graphics và UI |
| System.Windows.Forms | Windows Forms UI |
| AsiaErp.Framework | Asia ERP Framework (frmDMView, frmDMEdit) |
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSODMTD` | `frmDMView` | Form xem danh sách tuyến đường |
| `frmSODMTDEDIT` | `frmDMEdit` | Form nhập/sửa thông tin tuyến đường |

---

## Các trường dữ liệu (frmSODMTDEDIT)

### TextBox controls
| Control | Trường DB | Mô tả |
|---------|-------------|-------|
| txtMa_TD | Ma_TD | Mã tuyến đường |
| txtTen_TD | Ten_TD | Tên tuyến đường |

### Numeric controls (AsTextNumeric)
| Control | Trường DB | Đơn vị | Mô tả |
|---------|-------------|----------|-------|
| txtKm | Km | km | Khoảng cách |

### Checkbox
| Control | Trường DB | Mô tả |
|---------|-------------|-------|
| chkKsd | Ksd | Không sử dụng |

---

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| TD | Tuyến đường |
| Ma_TD | Mã tuyến đường |
| Ten_TD | Tên tuyến đường |
| Km | Kilomet - Khoảng cách |
| Ksd | Không sử dụng |

---

## Mục đích sử dụng

**SODMTD.dll là module quản lý Danh mục tuyến đường** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý thông tin tuyến đường
- Mã tuyến đường (Ma_TD) - Max length: 8
- Tên tuyến đường (Ten_TD) - Max length: 50
- Khoảng cách (Km)

#### 2. Tính năng cơ bản
- Thêm mới, sửa, xóa tuyến đường
- Kiểm tra dữ liệu bắt buộc (Mã, Tên)
- Đánh dấu không sử dụng (Ksd)
- Tự động tính toán và binding dữ liệu

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMView` và `frmDMEdit` của Framework
- Sử dụng DataBinding với DataTable
- Validation dữ liệu đầu vào
- Mask format cho số: `### ### ### ###`
- TextBox nhập mã: CharacterCasing = Upper

---

## Kết luận

Đây là module Windows Forms đơn giản quản lý danh mục tuyến đường, phục vụ cho việc định nghĩa các tuyến vận chuyển trong hệ thống ERP. Module lưu trữ thông tin cơ bản về tuyến đường bao gồm mã, tên và khoảng cách.

---

*Ngày phân tích: 2026-03-29*
