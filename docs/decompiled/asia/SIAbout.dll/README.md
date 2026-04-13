# Báo cáo Phân tích DLL: SIAbout.dll

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
| Assembly Name | SIAbout |
| Assembly Title | Thông tin chương trình |
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
SIAbout.dll/
├── SIAbout.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmSIAbout.cs            # Form thông tin phần mềm
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System | .NET Framework core |
| System.Drawing | Graphics and UI |
| System.Windows.Forms | Windows Forms UI |
| AsiaErp.Framework | Asia ERP Framework |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSIAbout` | `frmCalc` | Form hiển thị thông tin về phần mềm |
| `Resources` | - | Resource manager cho localization |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Thông tin chương trình" - Tên chức năng chính
- "Người sử dụng" - Tên user đăng nhập
- "Năm tài chính" - Financial year
- "Ngày khóa sổ" - Ngày khóa sổ kế toán
- "Đơn vị" - Mã và tên công ty
- "Bản cập nhập" - Phiên bản phần mềm
- "Server" - Tên server database
- "Database" - Tên database (Data/Sys)

### Thuật ngữ hệ thống

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `UserName` | Tên người dùng đăng nhập |
| `FinancialYear` | Năm tài chính hiện tại |
| `CompanyID` | Mã đơn vị/công ty |
| `CompanyName` | Tên đơn vị/công ty |
| `ngay_ks` | Ngày khóa sổ |
| `ServerName` | Tên SQL Server |
| `DATADatabaseName` | Database dữ liệu chính |
| `SYSDatabaseName` | Database hệ thống |

---

## Mục đích sử dụng

**SIAbout.dll là module hiển thị thông tin về phần mềm** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Hiển thị thông tin người dùng
- Tên người dùng đăng nhập (`SystemInformations.UserName`)
- Thông tin phiên làm việc hiện tại

#### 2. Hiển thị thông tin công ty
- Mã đơn vị (`CompanyID`)
- Tên đơn vị (`CompanyName`)
- Ngày khóa sổ (`ngay_ks`)

#### 3. Hiển thị thông tin năm tài chính
- Năm tài chính hiện tại
- Khoảng thời gian: 01/01/YYYY - 31/12/YYYY

#### 4. Hiển thị thông tin phần mềm
- Tên sản phẩm (`ProductName`)
- Phiên bản (`ProductVersion`)

#### 5. Hiển thị thông tin cơ sở dữ liệu
- Tên SQL Server (`ServerName`)
- Database dữ liệu (`DATADatabaseName`)
- Database hệ thống (`SYSDatabaseName`)

### Đặc điểm kỹ thuật

- Form chỉ hiển thị thông tin (read-only), không có chức năng chỉnh sửa
- Sử dụng các control `AsMaskedTextBox` và `TextBox` với `ReadOnly = true`
- Lấy thông tin từ các static class: `SystemInformations`, `CompanyInformations`, `DatabaseConfigurations`
- Kế thừa từ `frmCalc` - form cơ sở của hệ thống

---

## Kết luận

Đây là một module Windows Forms đơn giản của hệ thống ERP Asia Enterprise, phục vụ cho việc hiển thị thông tin tổng quan về phần mềm, người dùng, công ty và cơ sở dữ liệu. Module này thường được gọi từ menu "Help" hoặc "About" của ứng dụng.

---

*Ngày phân tích: 2026-03-29*
