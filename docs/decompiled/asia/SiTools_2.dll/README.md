# Báo cáo Phân tích DLL: SiTools_2.dll

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
| Assembly Name | SiTools_2 |
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
SiTools_2.dll/
├── SiTools_2.csproj                 # Project file
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
│   └── KeyValue.cs                  # Key-Value data structure
└── My/
    ├── MyApplication.cs             # Application settings
    ├── MyComputer.cs                # Computer info
    ├── MySettings.cs                # User settings
    ├── MySettingsProperty.cs        # Settings property
    ├── MyProject.cs                 # Project helpers
    └── InternalXmlHelper.cs         # XML helper internal
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML processing |
| System.Xml | XML processing |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| System.Data | Data access |
| System.Core | Core functionality |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `AsiaErp.UserInterface`
- `DTE.Bussiness`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `System.Xml`, `System.Xml.Linq`
- `System.IO`, `System.Collections.Generic`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmMainTools` | `frmAsiaRoot` | Form chính quản lý tools hệ thống (version 2) |
| `frmCreateCompany` | - | Form tạo công ty mới |
| `frmPassword` | - | Form nhập/xác nhận password |
| `AsListBoxColors` | ListBox | ListBox control với màu custom |
| `OpenListBoxColors` | - | Helper mở ListBox colors |
| `ISiToolsDao` | Interface | Data access interface |
| `MsSqlISiToolsDao` | - | SQL Server implementation |
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

#### DataGridView

| Control | Mục đích |
|---------|----------|
| `asDgvCompanyInfo` | Hiển thị thông tin công ty |

---

## Mục đích sử dụng

**SiTools_2.dll là phiên bản nâng cấp của SiTools.dll** - bộ công cụ tiện ích hệ thống trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý thông tin công ty
- Xem và chỉnh sửa thông tin công ty
- Tạo công ty mới (`frmCreateCompany`)
- Quản lý danh sách công ty trong hệ thống multi-tenant

#### 2. Cấu hình giao diện (UI Configuration)
- Tùy chỉnh font chữ, màu sắc
- Cấu hình width panel, column
- Màu sắc menu, sub-menu
- Lưu cấu hình vào config file

#### 3. Quản lý menu hệ thống
- Cấu hình menu chính, menu con
- Tùy chỉnh font, màu cho từng loại menu
- Insert/Update menu info và resx resources

#### 4. Tiện ích khác
- Form nhập password (`frmPassword`)
- ListBox với màu custom (`AsListBoxColors`)
- Key-Value data structure (`KeyValue`)
- Internal XML helper (`InternalXmlHelper`)

### Khác biệt so với SiTools.dll (version 1)

| Đặc điểm | SiTools.dll | SiTools_2.dll |
|----------|-------------|---------------|
| System.Web reference | Có | Không |
| System.Configuration reference | Có | Không |
| InternalXmlHelper | Không | Có |
| CacheSample | Có | Không |

SiTools_2.dll loại bỏ dependency vào `System.Web` và `System.Configuration`, thay vào đó sử dụng cách tiếp cận nhẹ hơn cho caching và configuration.

### Đặc điểm kỹ thuật

- Kế thừa từ `frmAsiaRoot` của Framework
- Sử dụng DAO pattern cho data access
- Custom control: `AsListBoxColors` cho hiển thị màu
- Sử dụng XML cho cấu hình và resources
- Không phụ thuộc vào System.Web.Caching
- InternalXmlHelper cho xử lý XML nội bộ

---

## Kết luận

Đây là phiên bản cải tiến của module SiTools, tối ưu hóa dependencies và cung cấp các công cụ quản lý cấu hình hệ thống. Module phù hợp cho admin/super user để cấu hình và quản lý hệ thống ERP Asia với footprint nhỏ hơn version 1.

---

*Ngày phân tích: 2026-03-29*
