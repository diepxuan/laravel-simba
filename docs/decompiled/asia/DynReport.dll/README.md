# Báo cáo Phân tích DLL: DynReport.dll

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
| Assembly Name | DynReport |
| Assembly Title | DynGlRptBCTC01 |
| Assembly Product | DynGlRptBCTC01 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | d04f93c9-70f5-484f-9160-e3ed40940889 |
| ComVisible | false |

---

## Cấu trúc File

```
DynReport.dll/
├── DynReport.csproj                  # Project file
├── app.ico                           # Application icon
├── AsiaErp.UserInterface.DynCrystalReport.rpt  # Crystal Report template
├── Properties/
│   └── AssemblyInfo.cs               # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── DynCrystalReport.cs           # Crystal Report wrapper class
│   ├── CachedDynCrystalReport.cs     # Cached Crystal Report
│   └── MyDataSet.cs                  # DataSet for report
└── AsiaErp.UserInterface.My/
    ├── MyApplication.cs              # Application settings
    ├── MySettings.cs                 # Settings
    ├── MySettingsProperty.cs         # Settings property
    ├── MyComputer.cs                 # Computer info
    └── MyProject.cs                  # Project info
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| CrystalDecisions.CrystalReports.Engine | Crystal Reports engine |
| CrystalDecisions.ReportSource | Crystal Reports report source |
| CrystalDecisions.Shared | Crystal Reports shared components |
| System.Data | Data access |
| System.Xml | XML processing |
| System.Data.DataSetExtensions | DataSet extensions |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `DynCrystalReport` | `ReportClass` | Wrapper class cho Crystal Report template |
| `CachedDynCrystalReport` | - | Cached version của Crystal Report |
| `MyDataSet` | `DataSet` | DataSet chứa dữ liệu báo cáo |

---

## Crystal Report Sections

| Section | Index | Mục đích |
|---------|-------|----------|
| `ReportHeaderA` | 0 | Header báo cáo phần A |
| `ReportHeaderb` | 1 | Header báo cáo phần B |
| `PageHeader` | 2 | Header trang |
| `Details` | 3 | Chi tiết báo cáo |
| `ReportFooterA` | 4 | Footer báo cáo phần A |
| `ReportFooterB` | 5 | Footer báo cáo phần B |
| `Page` | 6 | Footer trang |

---

## Report Objects

| Object Pattern | Loại | Mục đích |
|----------------|------|----------|
| `lblCol{n}` | `TextObject` | Label cho cột n |
| `txtCol{n}` | `FieldObject` | Text field cho cột n |

---

## Mục đích sử dụng

**DynReport.dll là module báo cáo Crystal Report động** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Crystal Report Integration
- Wrapper cho Crystal Reports runtime
- Tích hợp với Asia ERP Framework
- Hỗ trợ cached reports để tăng hiệu suất

#### 2. Dynamic Column Mapping
- Tự động mapping cột từ DataGridView sang Crystal Report
- Điều chỉnh độ rộng cột theo DataGridView
- Mapping header text từ DataGridView

#### 3. Data Processing
- Nhận dữ liệu từ `AsDataGridView`
- Tạo DataTable copy cho báo cáo
- Rename cột theo report object names

### Đặc điểm kỹ thuật

- Sử dụng Crystal Decisions SDK
- Hỗ trợ 8 cột động (lblCol0-7, txtCol0-7)
- Tích hợp với `AsDataGridView` control
- Có thể xử lý visible/invisible columns

---

## Kết luận

Đây là module tích hợp Crystal Reports cho phép tạo báo cáo động từ dữ liệu DataGridView, sử dụng template Crystal Report có sẵn với khả năng mapping cột tự động.

---

*Ngày phân tích: 2026-03-29*
