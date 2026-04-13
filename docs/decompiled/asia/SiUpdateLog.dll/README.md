# Báo cáo Phân tích DLL: SiUpdateLog.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# (decompiled từ VB.NET) |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SiUpdateLog |
| Assembly Title | WindowsApplication1 |
| Assembly Company | - |
| Assembly Product | WindowsApplication1 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 02d1b2fa-3ec8-45f4-a8b9-c0b316177ea3 |
| ComVisible | false |

---

## Cấu trúc File

```
SiUpdateLog.dll/
├── SiUpdateLog.csproj              # Project file
├── app.ico                         # Application icon
├── Resources.resx                  # Resource file
├── Properties/
│   └── AssemblyInfo.cs             # Assembly metadata
├── My/
│   ├── MyApplication.cs            # VB My namespace
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   └── InternalXmlHelper.cs
├── My.Resources/
│   └── Resources.cs                # Resource manager
├── AsiaErp.DataAccess/
│   ├── SIUpdateLogDAO.cs           # Interface DAO
│   └── MsSQLSIUpdateLogDAO.cs      # Implementation SQL Server
└── AsiaErp.UserInterface/
    ├── frmSiUpdateLog.cs           # Form chính
    ├── frmSiUpdateLogEdit.cs       # Form chỉnh sửa
    ├── frmCreateConnection.cs      # Form tạo kết nối
    ├── frmFilterOjectToUpdate.cs   # Form lọc đối tượng
    ├── frmHistory.cs               # Form lịch sử
    └── frmLookup.cs                # Form tra cứu
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Xml.Linq | XML processing |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| AsiaCompress | Nén/giải nén file |
| ToolCommon | Công cụ chung |
| System.Configuration | Cấu hình ứng dụng |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `AsiaErp.Compress`
- `AsiaErp.ToolCommon`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSiUpdateLog` | `frmDMView` | Form quản lý log cập nhật chính |
| `frmSiUpdateLogEdit` | - | Form chỉnh sửa log cập nhật |
| `frmCreateConnection` | - | Form tạo kết nối database |
| `frmFilterOjectToUpdate` | - | Form lọc đối tượng cần cập nhật |
| `frmHistory` | - | Form xem lịch sử cập nhật |
| `frmLookup` | - | Form tra cứu thông tin |
| `SIUpdateLogDAO` | `DAO` | Interface truy xuất dữ liệu |
| `MsSQLSIUpdateLogDAO` | `SIUpdateLogDAO` | Implementation cho SQL Server |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Choose" - Chọn đối tượng
- "Name" - Tên đối tượng
- "Type" - Loại (File/DBObject)
- "Last_Modify" - Ngày sửa đổi cuối
- "FullPath" - Đường dẫn đầy đủ
- "&Tạo File" - Button tạo file zip
- "&History" - Button xem lịch sử
- "(Alt + Shift + Z to unzip)" - Hướng dẫn giải nén

### Cột DataGridView (Chi tiết)

| Cột | Ý nghĩa |
|-----|---------|
| Chon | Checkbox chọn đối tượng |
| Name | Tên đối tượng |
| TypeName | Loại đối tượng (File/DBObject) |
| Last_Modify | Ngày sửa đổi |
| FullPath | Đường dẫn đầy đủ |

### Thuật ngữ kỹ thuật

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `BugNumber` | Số hiệu lỗi/phiên bản |
| `ProductName` | Tên sản phẩm |
| `Description` | Mô tả cập nhật |
| `Connection` | Chuỗi kết nối database |
| `TYPE IN (N'FN', N'IF', N'TF', N'FS', N'FT')` | Filter cho Function |
| `TYPE IN (N'P', N'PC')` | Filter cho Stored Procedure |

---

## Mục đích sử dụng

**SiUpdateLog.dll là module quản lý log cập nhật và tạo package update** cho hệ thống ERP Asia.

### Chức năng chính

#### 1. Quản lý log cập nhật
- Lưu trữ thông tin các bản cập nhật (bug fix, tính năng mới)
- Theo dõi đối tượng cập nhật: File DLL, Database Objects (Function, Store Procedure, View)
- Quản lý thông tin: Bug number, Product name, Description, Note, Dates

#### 2. Tạo package update (Zip)
- Chọn các đối tượng cần đóng gói (Files và DB Objects)
- Xuất SQL script cho Database Objects:
  - Functions (FN, IF, TF, FS, FT)
  - Stored Procedures (P, PC)
  - Views
- Tạo file Readme.txt chứa thông tin cập nhật
- Nén thành file .zip với cấu trúc:
  - `/Readme.txt` - Thông tin cập nhật
  - `/TSQL/*.sql` - Script SQL
  - `/_Dlls/*.dll` - File DLL cập nhật
  - `/Reports/*.rpt` - File báo cáo
  - `/Reports/NT/*.rpt` - File báo cáo NT

#### 3. Xem lịch sử cập nhật
- Theo dõi lịch sử áp dụng update
- Tra cứu thông tin update theo Product ID

#### 4. Quản lý kết nối
- Tạo và lưu trữ connection strings
- Kết nối đến nhiều database khác nhau

### Đặc điểm kỹ thuật

- Sử dụng `AsiaCompress` để nén/giải nén file
- Hỗ trợ đa database thông qua connection string
- Validation dữ liệu đầu vào
- Tạo SQL script với DROP statement trước khi CREATE
- Encoding UTF8 cho file nén
- Hotkey: F5 (History), F8 (Delete), Alt+Shift+Z (Unzip)

### Database Objects hỗ trợ

| Loại | Filter SQL |
|------|-----------|
| Function | `TYPE IN (N'FN', N'IF', N'TF', N'FS', N'FT')` |
| Stored Procedure | `TYPE IN (N'P', N'PC')` |
| View | `sys.views` |

---

## Kết luận

Đây là module quan trọng trong quy trình deploy/update của hệ thống Asia ERP, cho phép đóng gói và phân phối các bản cập nhật bao gồm cả code (DLL) và database objects (SQL scripts) trong một file zip duy nhất.

---

*Ngày phân tích: 2026-03-29*
