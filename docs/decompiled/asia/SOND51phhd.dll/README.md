# Báo cáo Phân tích DLL: SOND51phhd.dll

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
| Assembly Name | SOND51phhd |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| ComVisible | false |

---

## Cấu trúc File

```
SOND51phhd.dll/
├── SOND51phhd.csproj            # Project file
├── app.ico                      # Application icon
├── Resources.resx               # Resources
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.DataAccess/
│   ├── SOND51phhdDAO.cs         # DAO Interface
│   └── MsSqlSOND51phhdDAO.cs    # MSSQL DAO Implementation
├── AsiaErp.UserInterface/
│   ├── frmSOND51phhd.cs         # Main form class
│   └── frmSOND51phhdEdit.cs     # Edit form class
└── My/
    ├── MyApplication.cs         # Application settings
    └── MyProject.cs             # Project settings
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| Framework | Asia ERP Framework |
| CrystalDecisions.CrystalReports.Engine | Crystal Reports |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `CrystalDecisions.CrystalReports.Engine`
- `System`, `System.Collections`, `System.ComponentModel`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSOND51phhd` | `frmDMComplexView` | Form danh mục phát hành hóa đơn |
| `frmSOND51phhdEdit` | - | Form chỉnh sửa thông tin phát hành hóa đơn |
| `SOND51phhdDAO` | `DAO` | Interface định nghĩa các phương thức truy xuất dữ liệu |
| `MsSqlSOND51phhdDAO` | - | Implementation của SOND51phhdDAO cho MSSQL |

---

## Mục đích sử dụng

**SOND51phhd.dll là module quản lý "Phát hành hóa đơn"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Danh mục phát hành hóa đơn
- Quản lý các đợt phát hành hóa đơn GTGT
- Theo dõi số seri hóa đơn đã phát hành
- Quản lý mã tờ báo cáo (`ma_tb`)

#### 2. In ấn báo cáo
- Tích hợp Crystal Reports
- In báo cáo phát hành hóa đơn
- Truyền tham số công ty và mã tờ báo cáo

#### 3. Quản lý trạng thái
- Theo dõi các hóa đơn đã phát hành
- Quản lý số lượng hóa đơn còn lại

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMComplexView` - form danh mục phức tạp
- DAO pattern cho data access
- Crystal Reports integration cho in ấn
- Sử dụng `ReportDocument` để load và hiển thị báo cáo

### Các trường công thức báo cáo

| Trường | Giá trị |
|--------|---------|
| `strHeadCompanyName` | Tên công ty mẹ |
| `strCompanyName` | Tên công ty |
| `strTitle` | Tiêu đề báo cáo |

### Module liên quan

Module này thuộc nhóm Sales (SO) và liên quan đến:
- `SOND51mathd.dll` - Mã hóa đơn
- `SOND51mhd.dll` - Mẫu hóa đơn
- `SOND51phhd.dll` - Phát hành hóa đơn (module này)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục phát hành hóa đơn GTGT. Module cung cấp chức năng xem danh sách, chỉnh sửa và in ấn báo cáo phát hành hóa đơn.

---

*Ngày phân tích: 2026-03-29*
