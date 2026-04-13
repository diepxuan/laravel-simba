# Báo cáo Phân tích DLL: INDMPLVT.dll

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
| Assembly Name | INDMPLVT |
| Assembly Title | Danh mục phân loại vật tư - IN input |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | true |

---

## Cấu trúc File

```
INDMPLVT.dll/
├── INDMPLVT.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmINDMPLVT.cs           # Main form class (danh sách)
    └── frmINDMPLVTEdit.cs       # Edit form (thêm/sửa)
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.ComponentModel`, `System.Diagnostics`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINDMPLVT` | `frmDMComplexView` | Form xem danh sách phân loại vật tư |
| `frmINDMPLVTEdit` | `frmDMComplexEdit` | Form thêm/sửa phân loại vật tư |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Danh mục phân loại vật tư - IN input" - Tên chức năng chính
- "Mã phân loại" - Mã phân loại vật tư
- "Tên phân loại" - Tên phân loại vật tư
- "Kiểu" - Loại phân loại (1, 2, 3)

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_plvt` | Mã phân loại vật tư |
| `ten_plvt` | Tên phân loại vật tư |
| `loai` | Kiểu phân loại (1/2/3) |
| `ksd` | Không sử dụng |

---

## Mục đích sử dụng

**INDMPLVT.dll là module quản lý danh mục phân loại vật tư** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý phân loại vật tư
- Tạo và quản lý các phân loại vật tư
- Hỗ trợ 3 kiểu phân loại (Loại 1, 2, 3)
- Mã phân loại tối đa theo cấu hình hệ thống
- Tên phân loại tối đa 50 ký tự

#### 2. Tính năng danh mục chuẩn
- Thêm mới phân loại vật tư
- Sửa thông tin phân loại
- Xóa phân loại (ẩn qua trạng thái KSD)
- Tìm kiếm và lọc dữ liệu

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMComplexView` và `frmDMComplexEdit`
- DataBinding với DataTable
- Validation dữ liệu đầu vào
- Hỗ trợ phím tắt và navigation

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục phân loại vật tư - một danh mục cơ bản trong module Inventory (IN).

---

*Ngày phân tích: 2026-03-29*
