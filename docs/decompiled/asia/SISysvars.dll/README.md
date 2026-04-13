# Báo cáo Phân tích DLL: SISysvars.dll

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
| Assembly Name | SISysvars |
| Assembly Title | SISysvars |
| Assembly Company | Asia |
| Assembly Product | SISysvars |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | |
| Assembly Description | Khai báo tham số hệ thống |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | be56873b-80da-4134-a658-da6c064c5bc0 |
| ComVisible | false |

---

## Cấu trúc File

```
SISysvars.dll/
├── SISysvars.csproj             # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmSISysvars.cs          # Main form class - System variables
├── AsiaErp.DataAccess/
│   ├── MsSqlSISysvarsDAO.cs     # Data Access Object (SQL Server)
│   └── SISysvarsDAO.cs          # DAO Interface
├── My/
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   └── MySettingsProperty.cs
└── My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| AsiaErp.Framework | Asia ERP Framework |
| AsiaErp.DataAccess | Data Access Layer |
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Drawing | Graphics |
| System.Windows.Forms | Windows Forms |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.ComponentModel`, `System.Data`, `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSISysvars` | `frmAsiaRoot` | Form quản lý tham số hệ thống |
| `SISysvarsDAO` | - | Data Access Object cho system variables |
| `MsSqlSISysvarsDAO` | `SISysvarsDAO` | SQL Server implementation |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Tên tham số" (`varDescrpt`)
- "Giá trị" (`varValue`)
- "&Sửa" / "&Lưu" (Button actions)

### Cột DataGridView

| Cột | Ý nghĩa |
|-----|---------|
| `varName` | Tên biến (ẩn) |
| `varDescrpt` | Mô tả tham số |
| `varValue` | Giá trị tham số |
| `varType` | Kiểu dữ liệu (ẩn) |
| `maxlength` | Độ dài tối đa (ẩn) |
| `isEdit` | Cho phép sửa |
| `Description` | Mô tả chi tiết |

### Thuật ngữ kỹ thuật

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `varName` | Tên biến hệ thống |
| `varValue` | Giá trị biến |
| `varDescrpt` | Mô tả biến |
| `varType` | Kiểu dữ liệu |
| `moduleid` | Mã module/phân hệ |
| `isEdit` | Trạng thái cho phép sửa |

---

## Mục đích sử dụng

**SISysvars.dll là module quản lý Tham số hệ thống** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý tham số hệ thống
- Hiển thị danh sách các tham số hệ thống
- Xem giá trị hiện tại của từng tham số
- Sửa đổi giá trị tham số (nếu được phép)

#### 2. Phân loại tham số
- Tham số theo module/phân hệ (`moduleid`)
- Tham số chỉ đọc (không cho phép sửa)
- Tham số có thể sửa (`isEdit = 1`)

#### 3. Cập nhật và đồng bộ
- Lưu thay đổi vào database
- Refresh cấu hình hệ thống (`Environment.RefreshConfiguration`)
- Áp dụng ngay cho phiên làm việc hiện tại

#### 4. Mô tả và hướng dẫn
- Hiển thị mô tả chi tiết cho từng tham số
- Giúp người dùng hiểu rõ tác dụng của tham số

### Đặc điểm kỹ thuật

- Sử dụng `frmAsiaRoot` - form gốc của hệ thống
- DataGridView hiển thị danh sách tham số (`AsDataGridView`)
- DataBinding với DataTable
- DAO pattern cho data access
- Phân biệt trạng thái Edit/Save
- Màu sắc phân biệt tham số không được sửa (Gray)

### Các tham số quan trọng

Module quản lý các tham số cấu hình như:
- Định dạng số tiền
- Định dạng ngày tháng
- Cấu hình in ấn
- Cấu hình báo cáo
- Các tham số nghiệp vụ khác

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý tham số hệ thống - công cụ cấu hình và tùy chỉnh hành vi của hệ thống ERP theo nhu cầu của từng doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
