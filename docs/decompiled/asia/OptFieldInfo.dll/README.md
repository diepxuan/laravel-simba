# Báo cáo Phân tích DLL: OptFieldInfo.dll

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
| Assembly Name | OptFieldInfo |
| Assembly Title | Danh mục các trường tự do |
| Assembly Company | - |
| Assembly Product | OptFieldInfo |
| Assembly Copyright | Copyright © 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 9b304409-4ff6-4cbc-8537-d3c362024ff9 |
| ComVisible | false |

---

## Cấu trúc File

```
OptFieldInfo.dll/
├── OptFieldInfo.csproj          # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmOptFieldInfo.cs       # Main form class
├── AsiaErp.DataAccess/
│   ├── OptFieldDAO.cs           # DAO Interface
│   └── MsSqlOptFieldDAO.cs      # SQL Server DAO Implementation
└── My/
    ├── MySettings.cs            # Application settings
    ├── MyApplication.cs         # Application context
    ├── MyComputer.cs            # Computer info
    ├── MyProject.cs             # Project info
    └── MySettingsProperty.cs    # Settings properties
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| AsiaErp.Framework | Asia ERP Framework |
| AsiaErp.Helper | Asia ERP Helper |
| Microsoft.VisualBasic | Visual Basic runtime support |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmOptFieldInfo` | `frmAsiaRoot` | Form quản lý danh mục các trường tự do |
| `OptFieldDAO` | `DAO` | Interface định nghĩa các phương thức truy xuất dữ liệu |
| `MsSqlOptFieldDAO` | `MsSqlDAO` | Implementation SQL Server cho OptFieldDAO |

---

## UI Components (frmOptFieldInfo)

### Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `dgvOpt` | `AsDataGridView` | Grid hiển thị danh sách trường tự do |
| `cmdOk` | `Button` | Lưu thay đổi |
| `cmdExit` | `Button` | Thoát form |

### Cột DataGridView

| Cột | DataPropertyName | HeaderText | Mô tả |
|-----|------------------|------------|-------|
| Column5 | Stt | STT | Số thứ tự (ẩn) |
| Column1 | Field | Tên trường | Tên trường dữ liệu |
| Column2 | descrpt | Diễn giải | Mô tả trường |
| Column3 | length | Độ dài | Độ dài trường |
| Column4 | caption | Tiêu đề | Tiêu đề hiển thị (có thể chỉnh sửa) |
| Column6 | - | Column6 | Cột ẩn |

---

## Data Access Layer

### OptFieldDAO Interface

| Phương thức | Tham số | Return | Mô tả |
|-------------|---------|--------|-------|
| `GetOptField()` | - | `DataTable` | Lấy danh sách các trường tự do |
| `UpdOptField()` | pStt, pField, pCaption, pUser | `int` | Cập nhật tiêu đề trường |

### Stored Procedures

| Procedure | Mục đích |
|-----------|----------|
| `asGetOptFieldInfo` | Lấy thông tin các trường tự do |
| `asUpdOptFieldInfo` | Cập nhật tiêu đề trường tự do |

---

## Business Logic

### 1. Load dữ liệu
- Gọi `asGetOptFieldInfo` để lấy danh sách trường tự do
- Bind dữ liệu vào `dgvOpt`
- Áp dụng màu xen kẽ từ `ClientConfiguration.DM_AlternatingBackColor`

### 2. Cập nhật dữ liệu
- Lấy các row đã được modify (`DataViewRowState.ModifiedCurrent`)
- Gọi `UpdOptField` cho từng row để cập nhật tiêu đề
- Hiển thị thông báo thành công (`CMessageBox.Show(50015)`)

---

## Mục đích sử dụng

**OptFieldInfo.dll là module quản lý danh mục các trường tự do (Custom Fields)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý trường tự do
- Hiển thị danh sách các trường tự do trong hệ thống
- Cho phép chỉnh sửa tiêu đề (caption) của từng trường
- Hiển thị thông tin: Tên trường, Diễn giải, Độ dài, Tiêu đề

#### 2. Cấu hình hiển thị
- Người dùng có thể tùy chỉnh tiêu đề hiển thị cho các trường tự do
- Thay đổi được lưu vào database thông qua stored procedure

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Chỉ cho phép chỉnh sửa cột "Tiêu đề"
- Các cột khác chỉ đọc (ReadOnly)
- Kết nối đến database hệ thống (`a_blnIsSysDB: true`)

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc cấu hình và quản lý các trường tự do (custom fields) - cho phép người dùng tùy chỉnh tiêu đề hiển thị của các trường mở rộng trong hệ thống.

---

*Ngày phân tích: 2026-03-29*
