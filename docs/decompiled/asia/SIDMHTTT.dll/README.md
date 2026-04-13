# Báo cáo Phân tích DLL: SIDMHTTT.dll

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
| Assembly Name | SIDMHTTT |
| Assembly Title | Danh muc nhap xuat |
| Assembly Company | ASIA |
| Assembly Product | SIDMHTTT |
| Assembly Copyright | Copyright © ASIA 2010 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 9f3d649b-8da3-4e47-9d58-1597c53f111c |
| ComVisible | false |

---

## Cấu trúc File

```
SIDMHTTT.dll/
├── SIDMHTTT.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSIDMHTTT.cs           # Main form class - Danh mục HTTT
│   └── frmSIDMHTTTEdit.cs       # Form chỉnh sửa HTTT
└── AsiaErp.UserInterface.My/
    ├── MyApplication.cs
    ├── MyComputer.cs
    ├── MyProject.cs
    ├── MySettings.cs
    └── MySettingsProperty.cs
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| AsiaErp.Framework | Asia ERP Framework |
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Windows.Forms | Windows Forms |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System.Collections`, `System.ComponentModel`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSIDMHTTT` | `frmDMComplexView` | Form xem danh mục hình thức thanh toán |
| `frmSIDMHTTTEdit` | `frmDMComplexEdit` | Form chỉnh sửa hình thức thanh toán |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã nhập xuất" (`ma_nx` / `ma_httt`)
- "Tên nhập xuất" (`ten_nx` / `ten_httt`)
- "Tài khoản" (`tk`)
- "Tên tài khoản" (`ten_tk`)

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_httt` | Mã hình thức thanh toán |
| `ten_httt` | Tên hình thức thanh toán |
| `tk` | Tài khoản kế toán |
| `moduleid` | Mã module phân hệ |

---

## Mục đích sử dụng

**SIDMHTTT.dll là module quản lý Danh mục hình thức thanh toán** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý hình thức thanh toán
- Khai báo mã hình thức thanh toán (`ma_httt`)
- Khai báo tên hình thức thanh toán (`ten_httt`)
- Liên kết với tài khoản kế toán (`tk`)

#### 2. Phân loại theo module
- Hỗ trợ nhiều phân hệ (moduleid)
- Sử dụng `MyMenuInfo.par1` để lọc theo phân hệ

#### 3. Tích hợp tài khoản
- Lookup tài khoản chi tiết (`chi_tiet=1`)
- Hiển thị tên tài khoản tự động

### Đặc điểm kỹ thuật

- Sử dụng `frmDMComplexView`/`frmDMComplexEdit` - hỗ trợ danh mục phức tạp
- DataBinding với DataTable
- AutoLookup cho trường tài khoản
- Validation dữ liệu đầu vào
- Hỗ trợ trạng thái sử dụng (`ksd`)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục hình thức thanh toán - định nghĩa các phương thức thanh toán và liên kết với tài khoản kế toán tương ứng.

---

*Ngày phân tích: 2026-03-29*
