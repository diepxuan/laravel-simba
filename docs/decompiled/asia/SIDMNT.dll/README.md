# Báo cáo Phân tích DLL: SIDMNT.dll

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
| Assembly Name | SIDMNT |
| Assembly Title | Danh mục ngoại tệ |
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
SIDMNT.dll/
├── SIDMNT.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmSIDMNT.cs             # Main form class - Danh mục ngoại tệ
    └── frmSIDMNTEdit.cs         # Form chỉnh sửa ngoại tệ
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
- `System`, `System.Collections.Generic`, `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSIDMNT` | `frmDMView` | Form xem danh mục ngoại tệ |
| `frmSIDMNTEdit` | `frmDMEdit` | Form chỉnh sửa thông tin ngoại tệ |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã ngoại tệ" (`ma_nt`)
- "Tên ngoại tệ" (`ten_nt`)

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ (tối đa 3 ký tự) |
| `ten_nt` | Tên ngoại tệ |
| `ksd` | Không sử dụng |

---

## Mục đích sử dụng

**SIDMNT.dll là module quản lý Danh mục ngoại tệ** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý danh mục ngoại tệ
- Khai báo mã ngoại tệ (`ma_nt`) - tối đa 3 ký tự
- Khai báo tên ngoại tệ (`ten_nt`)
- Hỗ trợ đa tiền tệ trong hệ thống

#### 2. Trạng thái sử dụng
- Cho phép đánh dấu ngoại tệ không còn sử dụng (`ksd`)
- Kiểm soát hiển thị trong các form liên quan

#### 3. Tích hợp hệ thống
- Sử dụng rộng rãi trong các module chứng từ
- Liên kết với tỷ giá ngoại tệ
- Refresh cấu hình sau khi cập nhật (`Environment.RefreshConfiguration`)

### Đặc điểm kỹ thuật

- Sử dụng `frmDMView`/`frmDMEdit` cơ bản
- DataBinding với DataTable
- Validation dữ liệu đầu vào
- Hỗ trợ trạng thái sử dụng (`ksd`)
- Tự động refresh cấu hình sau Insert/Update

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục ngoại tệ - nền tảng cho việc xử lý giao dịch đa tiền tệ trong hệ thống kế toán.

---

*Ngày phân tích: 2026-03-29*
