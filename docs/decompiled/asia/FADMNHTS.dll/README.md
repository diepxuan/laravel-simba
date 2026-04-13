# Báo cáo Phân tích DLL: FADMNHTS.dll

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
| Assembly Name | FADMNHTS |
| Assembly Title | danh mục phân nhóm tài sản cố định |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaErp |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 915aca13-7f2a-47d2-b5a7-ca1cb90334d1 |
| ComVisible | false |

---

## Cấu trúc File

```
FADMNHTS.dll/
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmFADMNHTS.cs               # Main form - Danh mục nhóm tài sản
│   └── frmFADMNHTSEdit.cs           # Edit form - Chi tiết nhóm tài sản
└── AsiaErp.UserInterface.My/
    ├── MyProject.cs                 # Project configuration
    ├── MyApplication.cs             # Application context
    ├── MyComputer.cs                # Computer info
    ├── MySettings.cs                # Application settings
    ├── MySettingsProperty.cs        # Settings properties
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
| `frmFADMNHTS` | `frmDMComplexView` | Form danh mục nhóm tài sản |
| `frmFADMNHTSEdit` | - | Form nhập liệu chi tiết nhóm TS |

---

## Mục đích sử dụng

**FADMNHTS.dll là module Danh mục phân nhóm tài sản cố định** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Quản lý danh mục nhóm tài sản
- Xem danh sách nhóm tài sản (3 cấp: loai_nh=1,2,3)
- Thêm, sửa, xóa nhóm tài sản
- Phân cấp nhóm: Nhóm 1, Nhóm 2, Nhóm 3

#### 2. Thông tin nhóm tài sản
- Mã nhóm tài sản (ma_nhts)
- Tên nhóm tài sản
- Loại nhóm (loai_nh): 1, 2, hoặc 3
- Các thông tin khác theo cấu trúc danh mục phức tạp

#### 3. Sử dụng trong danh mục tài sản
- Trong FADMTS: txtMa_nhts1, txtMa_nhts2, txtMa_nhts3
- Lookup với điều kiện: loai_nh=1, loai_nh=2, loai_nh=3

### Đặc điểm kỹ thuật

- Sử dụng `frmDMComplexView` - form danh mục phức tạp
- Hỗ trợ 3 cấp nhóm tài sản
- DataGridView hiển thị danh sách
- LookupCodeName = "MA_NHTS"

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP AsiaErp, phục vụ cho việc quản lý danh mục phân nhóm tài sản cố định (3 cấp) để phân loại và quản lý tài sản theo nhóm.

---

*Ngày phân tích: 2026-03-29*
