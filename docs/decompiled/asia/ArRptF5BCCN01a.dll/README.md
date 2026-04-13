# Báo cáo Phân tích DLL: ArRptF5BCCN01a.dll

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
| Assembly Name | ArRptF5BCCN01a |
| Assembly Title | ArRptF5BCCN01a |
| Assembly Company | Asia |
| Assembly Product | ArRptF5BCCN01a |
| Assembly Copyright | Copyright © Asia 2012 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 0d1d53c2-481f-49c3-b5c7-ede2b65a4e09 |
| ComVisible | false |

---

## Cấu trúc File

```
ArRptF5BCCN01a.dll/
├── ArRptF5BCCN01a.csproj        # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmArRptF5BCCN01a.cs     # Main form class - Báo cáo F5 công nợ
└── AsiaErp.UserInterface.My/
    ├── MyProject.cs             # VB.NET My project support
    ├── MyComputer.cs            # VB.NET My computer support
    ├── MySettings.cs            # Settings manager
    ├── MySettingsProperty.cs    # Settings property
    ├── MyApplication.cs         # Application support
    ├── InternalXmlHelper.cs     # XML helper
    └── Resources/
        └── Resources.cs         # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML LINQ support |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |
| System.Core | .NET Core extensions |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System`, `System.Collections`, `System.Collections.Generic`
| `System.ComponentModel`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`
- `System.Runtime.CompilerServices`, `System.Runtime.InteropServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmArRptF5BCCN01a` | `frmDrilldownReport` | Form báo cáo F5 công nợ khách hàng |

---

## Business Logic và Events

### Constructors

| Constructor | Tham số | Mô tả |
|-------------|---------|-------|
| `frmArRptF5BCCN01a()` | | Constructor mặc định |
| `frmArRptF5BCCN01a(...)` | ReportInformation, drilldownMenuId, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, datasource, arg | Constructor với thông tin báo cáo drilldown |

### Methods chính

| Phương thức | Mô tả |
|-------------|-------|
| `InitOtherComponents()` | Khởi tạo các component bổ sung, focus vào DataGridView báo cáo |
| `CreateDrilldownArgument()` | Tạo argument cho drilldown report (trả về null) |
| `InitializeComponent()` | Khởi tạo UI components |

### Events

| Event | Handler | Mục đích |
|-------|---------|----------|
| Form Load | (inherited) | Khởi tạo form báo cáo |

---

## Mục đích sử dụng

**ArRptF5BCCN01a.dll là module báo cáo F5 công nợ** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo F5 công nợ khách hàng
- Hiển thị báo cáo công nợ khách hàng theo định dạng F5
- Hỗ trợ drilldown (đào sâu) từ báo cáo tổng hợp sang chi tiết
- Hiển thị dữ liệu dưới dạng DataGridView với khả năng tương tác

#### 2. Tính năng Drilldown
- Kế thừa từ `frmDrilldownReport` - form báo cáo có khả năng drilldown
- Hỗ trợ điều hướng từ báo cáo tổng quan sang chi tiết
- Truyền thông tin drilldown qua `ReportInformation` và các tham số liên quan

#### 3. Tham số báo cáo

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| motherReportInfo | ReportInformation | Thông tin báo cáo mẹ |
| drilldownMenuId | string | ID menu drilldown |
| formularFields | AsDictionary | Dictionary các trường công thức |
| isNT | bool | Có phải ngoại tệ không |
| nhan_in | string | Nhãn in |
| filter4Tilte | string | Filter cho tiêu đề |
| formatedColList | string | Danh sách cột định dạng |
| datasource | object | Nguồn dữ liệu |
| arg | params object[] | Các tham số bổ sung |

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDrilldownReport` - base form cho báo cáo drilldown
- Sử dụng DataGridView (`dgvBC`) để hiển thị dữ liệu báo cáo
- Tích hợp với Framework và Helper của Asia ERP
- Hỗ trợ cả VNĐ và ngoại tệ (tham số `isNT`)

### Mã báo cáo

**F5 BCCN01a** (Báo cáo công nợ F5) - một dạng báo cáo công nợ khách hàng theo chuẩn F5 trong hệ thống kế toán Asia Enterprise.

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc hiển thị báo cáo F5 công nợ khách hàng với khả năng drilldown để xem chi tiết công nợ.

---

*Ngày phân tích: 2026-03-29*
