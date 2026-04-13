# Báo cáo Phân tích DLL: SIDMNGH.dll

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
| Assembly Name | SIDMNGH |
| Assembly Title | Danh mục ngân hàng |
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
SIDMNGH.dll/
├── SIDMNGH.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmSIDMNGH.cs            # Main form class - Danh mục ngân hàng
    └── frmSIDMNGHEdit.cs        # Form chỉnh sửa ngân hàng
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| AsiaErp.Framework | Asia ERP Framework |
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Windows.Forms | Windows Forms |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System.ComponentModel`, `System.Diagnostics`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSIDMNGH` | `frmDMView` | Form xem danh mục ngân hàng |
| `frmSIDMNGHEdit` | `frmDMEdit` | Form chỉnh sửa thông tin ngân hàng |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã ngân hàng" (`ma_ngh`)
- "Tên ngân hàng" (`ten_ngh`)
- "Ghi chú" (`ghi_chu`)

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ngh` | Mã ngân hàng |
| `ten_ngh` | Tên ngân hàng |
| `ghi_chu` | Ghi chú |
| `sd` | Trạng thái sử dụng |

---

## Mục đích sử dụng

**SIDMNGH.dll là module quản lý Danh mục ngân hàng** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý danh mục ngân hàng
- Khai báo mã ngân hàng (`ma_ngh`)
- Khai báo tên ngân hàng (`ten_ngh`)
- Ghi chú thông tin bổ sung

#### 2. Trạng thái sử dụng
- Cho phép đánh dấu ngân hàng không còn sử dụng (`sd`)
- Kiểm soát hiển thị trong các form liên quan

### Đặc điểm kỹ thuật

- Sử dụng `frmDMView`/`frmDMEdit` cơ bản
- DataBinding với DataTable
- Validation dữ liệu đầu vào
- Hỗ trợ trạng thái sử dụng (`ksd`/`sd`)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục ngân hàng - sử dụng trong các nghiệp vụ thanh toán, chuyển khoản, và quản lý tài khoản ngân hàng.

---

*Ngày phân tích: 2026-03-29*
