# Báo cáo Phân tích DLL: INDMLO.dll

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
| Assembly Name | INDMLO |
| Assembly Title | Danh mục lô |
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
INDMLO.dll/
├── INDMLO.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmINDMLO.cs             # Main form class (danh mục view)
    └── frmINDMLOEdit.cs         # Edit form class
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`
- `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINDMLO` | `frmDMView` | Form xem danh mục lô |
| `frmINDMLOEdit` | `frmDMEdit` | Form nhập liệu/chỉnh sửa lô |

---

## Chi tiết Form frmINDMLOEdit

### Các trường dữ liệu chính

| Control | Tên trường | Mục đích |
|---------|------------|----------|
| txtMa_Lo | Ma_Lo | Mã lô |
| txtTen_Lo | Ten_Lo | Tên lô |
| txtHan_dung | han_dung | Hạn dùng (date) |
| txtTrang_thai | trang_thai | Trạng thái |
| chkKsd | Ksd | Không sử dụng |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã lô" - Mã định danh lô
- "Tên lô" - Tên lô
- "Hạn dùng" - Ngày hết hạn sử dụng
- "Trạng thái" - Trạng thái lô

### Định dạng ngày

- Format: `@Ddd/MM/yyyy`
- Mask: `##/##/####`
- Default value: `01/01/1900`

---

## Mục đích sử dụng

**INDMLO.dll là module quản lý danh mục lô** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý thông tin lô
- Mã lô, tên lô
- Hạn dùng (ngày hết hạn)
- Trạng thái lô

#### 2. Ứng dụng
- Theo dõi hàng hóa theo lô sản xuất
- Quản lý hạn sử dụng (đặc biệt quan trọng cho ngành dược, thực phẩm)
- Truy xuất nguồn gốc sản phẩm

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Sử dụng AsMaskedTextBox cho ngày hạn dùng
- Validation dữ liệu đầu vào
- Định dạng ngày chuẩn dd/MM/yyyy

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục lô - chức năng quan trọng trong quản lý kho và truy xuất nguồn gốc sản phẩm.

---

*Ngày phân tích: 2026-03-29*
