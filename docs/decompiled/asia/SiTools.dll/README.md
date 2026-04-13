# Báo cáo Phân tích DLL: SiTools.dll

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
| Assembly Name | SiTools |
| Assembly Title | SiTools |
| Assembly Company | Asiasoft |
| Assembly Product | SiTools |
| Assembly Copyright | Copyright © Asiasoft 2012 |
| Assembly File Version | 1.0.0.0 |
| GUID | 96ba4f69-17e5-4928-a056-65b316b85db8 |
| ComVisible | false |

---

## Cấu trúc File

```
SiTools.dll/
├── SiTools.csproj                   # Project file
├── app.ico                          # Application icon
├── app.manifest                     # Application manifest
├── frmPassword.cs                   # Form nhập password
├── OpenListBoxColors.cs             # Control ListBox màu
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
├── AsiaErp.DataAccess/
│   ├── ISiToolsDao.cs               # Data Access Interface
│   └── MsSqlISiToolsDao.cs          # SQL Server Implementation
├── AsiaErp.UserInterface/
│   ├── frmMainTools.cs              # Form chính tools
│   └── frmCreateCompany.cs          # Form tạo công ty mới
├── AsiaErp.Framework/
│   └── AsListBoxColors.cs           # ListBox control custom
├── DTE.Bussiness/
│   ├── CacheSample.cs               # Cache sample data
│   └── KeyValue.cs                  # Key-Value data structure
└── My/
    ├── MyApplication.cs             # Application settings
    ├── MyComputer.cs                # Computer info
    ├── MySettings.cs                # User settings
    ├── MySettingsProperty.cs        # Settings property
    └── MyProject.cs                 # Project helpers
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML processing |
| System.Web | Web utilities (Caching) |
| System.Xml | XML processing |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| System.Data | Data access |
| System.Configuration | Configuration management |
| System.Core | Core functionality |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `AsiaErp.UserInterface`
- `DTE.Bussiness`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `System.Configuration`, `System.Xml`, `System.Xml.Linq`
- `System.Web.Caching`
- `System.IO`, `System.Collections.Generic`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmMainTools` | `frmAsiaRoot` | Form chính quản lý tools hệ thống |
| `frmCreateCompany` | - | Form tạo công ty mới |
| `frmPassword` | - | Form nhập/xác nhận password |
| `AsListBoxColors` | ListBox | ListBox control với màu custom |
| `ISiToolsDao` | Interface | Data access interface |
| `MsSqlISiToolsDao` | - | SQL Server implementation |
| `CacheSample` | - | Quản lý cache sample data |
| `KeyValue` | - | Cấu trúc dữ liệu Key-Value |

---

## Các trường dữ liệu chính

### Form frmMainTools

#### Tabs chính

| Tab | Mục đích |
|-----|----------|
| `tabComanyInfo` | Thông tin công ty |
| `tabInterface` | Cấu hình giao diện |
| `tabMenu` | Cấu hình menu |

#### Controls cấu hình giao diện

| Control | Mục đích |
|---------|----------|
| `tbxFont` | Font chữ chính |
| `tbxBgColor` | Màu nền menu |
| `tbxForeColor` | Màu chữ |
| `tbxWPanel` | Width panel |
| `tbxWColumn` | Width column |
| `tbxMnSelectedColor` | Màu menu selected |
| `tbxSubMnForeColor` | Màu chữ sub menu |
| `tbxDetailMnForeColor` | Màu chữ detail menu |
| `tbDetailMnFont` | Font detail menu |

#### DataGridView

| Control | Mục đích |
|---------|----------|
| `asDgvCompanyInfo` | Hiển thị thông tin công ty |

---

## Mục đích sử dụng

**SiTools.dll là bộ công cụ tiện ích hệ thống** trong hệ thống ERP của Asia Software Development JSC, cung cấp các chức năng quản lý cấu hình và tiện ích cho admin.

### Chức năng chính

#### 1. Quản lý thông tin công ty
- Xem và chỉnh sửa thông tin công ty
- Tạo công ty mới (`frmCreateCompany`)
- Quản lý danh sách công ty trong hệ thống multi-tenant

#### 2. Cấu hình giao diện (UI Configuration)
- Tùy chỉnh font chữ, màu sắc
- Cấu hình width panel, column
- Màu sắc menu, sub-menu, detail menu
- Lưu cấu hình vào config file

#### 3. Quản lý menu hệ thống
- Cấu hình menu chính, menu con
- Tùy chỉnh font, màu cho từng loại menu
- Insert/Update menu info và resx resources

#### 4. Tiện ích khác
- Form nhập password (`frmPassword`)
- ListBox với màu custom (`AsListBoxColors`)
- Cache sample data (`CacheSample`)
- Key-Value data structure (`KeyValue`)

### Đặc điểm kỹ thuật

- Kế thừa từ `frmAsiaRoot` của Framework
- Sử dụng DAO pattern cho data access
- Tích hợp System.Web.Caching cho caching
- Hỗ trợ đọc/ghi configuration files
- Custom control: `AsListBoxColors` cho hiển thị màu
- Sử dụng XML cho cấu hình và resources

### Enums trong frmMainTools

```csharp
fMenu: Insert = 1, Update
fDictionaryInfo: Insert = 3, Update
fDictionaryResx: Insert = 5, Update
fReportInfo: Insert = 7, Update
fReportResx: Insert = 9, Update
fVoucherInfo: Insert = 11, Update
fVoucherResx: Insert = 13, Update
fDaoInfo: Insert = 15, Update
fReportDrillDownInfo: Insert = 17, Update
```

Các enum này định nghĩa các chế độ thao tác (Insert/Update) cho từng loại đối tượng trong hệ thống.

---

## Kết luận

Đây là module tools/admin utility quan trọng, cung cấp giao diện quản lý cấu hình hệ thống, thông tin công ty, và các tiện ích phát triển. Module được thiết kế cho admin/super user để cấu hình và quản lý hệ thống ERP Asia.

---

*Ngày phân tích: 2026-03-29*
