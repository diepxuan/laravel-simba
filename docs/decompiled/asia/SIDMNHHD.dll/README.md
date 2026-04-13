# Báo cáo Phân tích DLL: SIDMNHHD.dll

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
| Assembly Name | SIDMNHHD |
| Assembly Title | Danh mục nhóm hợp đồng |
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
SIDMNHHD.dll/
├── SIDMNHHD.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmSIDMNHHD.cs           # Main form class - Danh mục nhóm hợp đồng
    └── frmSIDMNHHDEdit.cs       # Form chỉnh sửa nhóm hợp đồng
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| AsiaErp.Framework | Asia ERP Framework |
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Drawing | Graphics |
| System.Windows.Forms | Windows Forms |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSIDMNHHD` | `frmDMView` | Form xem danh mục nhóm hợp đồng |
| `frmSIDMNHHDEdit` | `frmDMEdit` | Form chỉnh sửa nhóm hợp đồng |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã nhóm" (`ma_nhhd`)
- "Tên nhóm" (`ten_nhhd`)

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nhhd` | Mã nhóm hợp đồng |
| `ten_nhhd` | Tên nhóm hợp đồng |
| `ksd` | Không sử dụng |

---

## Mục đích sử dụng

**SIDMNHHD.dll là module quản lý Danh mục nhóm hợp đồng** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý danh mục nhóm hợp đồng
- Khai báo mã nhóm hợp đồng (`ma_nhhd`)
- Khai báo tên nhóm hợp đồng (`ten_nhhd`)
- Phân loại hợp đồng theo nhóm

#### 2. Trạng thái sử dụng
- Cho phép đánh dấu nhóm không còn sử dụng (`ksd`)
- Kiểm soát hiển thị trong các form liên quan

#### 3. Tích hợp với danh mục hợp đồng
- Sử dụng trong SIDMHD.dll để phân loại hợp đồng
- Lookup từ danh mục hợp đồng

### Đặc điểm kỹ thuật

- Sử dụng `frmDMView`/`frmDMEdit` cơ bản
- DataBinding với DataTable
- Validation dữ liệu đầu vào
- Hỗ trợ trạng thái sử dụng (`ksd`)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục nhóm hợp đồng - phân loại các hợp đồng theo nhóm để dễ dàng quản lý và báo cáo.

---

*Ngày phân tích: 2026-03-29*
