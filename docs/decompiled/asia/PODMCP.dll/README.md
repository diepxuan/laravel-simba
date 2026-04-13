# Báo cáo Phân tích DLL: PODMCP.dll

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
| Assembly Name | PODMCP |
| Assembly Title | Danh mục chương trình mua hàng |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| ComVisible | false |

---

## Cấu trúc File

```
PODMCP.dll/
├── PODMCP.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmPODMCP.cs           # Main form class (danh mục view)
    └── frmPODMCPEdit.cs       # Edit form class
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.ComponentModel`, `System.Diagnostics`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPODMCP` | `frmDMView` | Form xem danh mục chương trình mua hàng |
| `frmPODMCPEdit` | `frmDMEdit` | Form chỉnh sửa danh mục chương trình mua hàng |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Danh mục chương trình mua hàng" - Tên chức năng chính
- "Mã chương trình" (`txtMa_cp`)
- "Tên chương trình" (`txtTen_cp`)
- "Thông tin phân bổ" (`cbott_pb`)

### Thuật ngữ nghiệp vụ

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `ma_cp` | Mã chương trình mua hàng |
| `ten_cp` | Tên chương trình mua hàng |
| `tt_pb` | Thông tin phân bổ |

---

## Mục đích sử dụng

**PODMCP.dll là module quản lý Danh mục chương trình mua hàng** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý danh mục chương trình mua hàng
- Thêm mới chương trình mua hàng
- Chỉnh sửa thông tin chương trình
- Xóa chương trình không còn sử dụng
- Tìm kiếm và lọc danh mục

#### 2. Thông tin quản lý
- Mã chương trình (`ma_cp`)
- Tên chương trình (`ten_cp`)
- Thông tin phân bổ (`tt_pb`)
- Trạng thái sử dụng (`chkKsd`)

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMView` và `frmDMEdit` (Framework chuẩn của Asia ERP)
- Sử dụng DataBinding với BindingSource
- Hỗ trợ validation dữ liệu đầu vào
- Tích hợp với hệ thống phân quyền của Asia ERP

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục chương trình mua hàng - một danh mục quan trọng trong module Mua hàng (PO).

---

*Ngày phân tích: 2026-03-29*
