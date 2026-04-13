# Báo cáo Phân tích DLL: FADMLDTS.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | FADMLDTS |
| Assembly Title | danh mục lý do tăng giảm tài sản cố định |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 9.1.0.0 |
| GUID | 96bc1ec0-19f8-4303-862b-fa51c232d544 |
| ComVisible | false |

---

## Cấu trúc File

```
FADMLDTS.dll/
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmFADMLDTS.cs               # Main form - Danh mục loại động tài sản
│   └── frmFADMLDTGEdit.cs           # Edit form - Chi tiết loại động TS
└── AsiaErp.UserInterface.My/
    ├── MyProject.cs                 # Project configuration
    ├── MyApplication.cs             # Application context
    ├── InternalXmlHelper.cs         # XML helper
    ├── MySettings.cs                # Application settings
    ├── MySettingsProperty.cs        # Settings properties
    ├── MyComputer.cs                # Computer info
    └── My.Resources/
        └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Windows.Forms | Windows Forms UI |
| System.Drawing | Graphics support |
| AsiaErp.Framework | ERP Framework Core |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Drawing`, `System.Windows.Forms`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFADMLDTS` | `frmDMView` | Form danh mục loại động tài sản |
| `frmFADMLDTGEdit` | - | Form nhập liệu chi tiết loại động TS |

---

## Mục đích sử dụng

**FADMLDTS.dll là module Danh mục loại động tài sản cố định** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Quản lý danh mục loại động tài sản
- Xem danh sách các loại động tài sản (tăng/giảm)
- Thêm, sửa, xóa loại động tài sản
- Phân loại: Tăng (tg='T') hoặc Giảm (tg='G')

#### 2. Thông tin loại động tài sản
- Mã loại động tài sản
- Tên loại động tài sản
- Loại: Tăng hoặc Giảm
- Các thông tin khác theo cấu trúc danh mục chuẩn

### Đặc điểm kỹ thuật

- Sử dụng `frmDMView` - form danh mục chuẩn
- DataGridView hiển thị danh sách
- Tích hợp với module tăng/giảm tài sản

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP AsiaERP, phục vụ cho việc quản lý danh mục loại động tài sản cố định (phân loại tăng/giảm) để sử dụng trong các chứng từ biến động tài sản.

---

*Ngày phân tích: 2026-03-29*
