# DynReport.dll - Crystal Report Dynamic

## Tong quan

| Thuoc tinh | Gia tri |
|------------|---------|
| **Module** | Common (Reporting) |
| **Loai** | Class Library - Crystal Report Wrapper |
| **Chuc nang** | Wrapper cho Crystal Reports, cho phep render bao cao dong tu AsDataGridView, mapping columns dynamically vao report template |
| **Assembly** | DynReport v1.0.0.0 |
| **Framework** | .NET Framework 3.5 |
| **Namespace** | AsiaErp.UserInterface |
| **AllowUnsafeBlocks** | True |
| **GUID** | d04f93c9-70f5-484f-9160-e3ed40940889 |

## Dependencies

| Assembly | Muc dich |
|----------|----------|
| CrystalDecisions.CrystalReports.Engine | Crystal Reports engine |
| CrystalDecisions.ReportSource | Report source & caching |
| CrystalDecisions.Shared | Shared components |
| AsiaErp.Framework | Framework base (AsDataGridView, utilities) |
| Microsoft.VisualBasic | VB runtime support |

## File Structure

```
DynReport.dll/
├── DynReport.csproj
├── app.ico
├── AsiaErp.UserInterface.DynCrystalReport.rpt   # Crystal Report template (embedded)
├── Properties/
│   └── AssemblyInfo.cs
├── AsiaErp.UserInterface/
│   ├── DynCrystalReport.cs           # Report wrapper class
│   ├── CachedDynCrystalReport.cs     # Cached report component
│   └── MyDataSet.cs                  # Typed DataSet
└── AsiaErp.UserInterface.My/
    ├── MyApplication.cs
    ├── MyComputer.cs
    ├── MyProject.cs
    ├── MySettings.cs
    └── MySettingsProperty.cs
```

## Classes

### DynCrystalReport

| Thuoc tinh | Chi tiet |
|------------|----------|
| **Ke thua** | CrystalDecisions.CrystalReports.Engine.ReportClass |
| **Muc dich** | Wrapper class cho Crystal Report template embedded |
| **ResourceName** | DynCrystalReport.rpt |
| **FullResourceName** | AsiaErp.UserInterface.DynCrystalReport.rpt |
| **NewGenerator** | true |

**Report Sections (7 sections):**

| Section | Index | Muc dich |
|---------|-------|----------|
| ReportHeaderA | 0 | Header bao cao A |
| ReportHeaderb | 1 | Header bao cao B |
| PageHeader | 2 | Header trang |
| Details | 3 | Chi tiet |
| ReportFooterA | 4 | Footer bao cao A |
| ReportFooterB | 5 | Footer bao cao B |
| Page | 6 | Footer trang |

**Phuong thuc quan trong:**

| Method | Input | Output | Muc dich |
|--------|-------|--------|----------|
| Process(AsDataGridView) | AsDataGridView | DataTable | Lay du lieu tu grid, mapping columns vao report objects (lblCol0-7, txtCol0-7), tra ve DataTable de hien thi bao cao |

**Process() logic:**
1. Copy DataTable tu AsDataGridView.DataSource
2. Duyet qua cac visible columns cua grid
3. Map moi column vao report objects:
   - `lblCol{n}` (TextObject): set Text = HeaderText, Width = column.Width
   - `txtCol{n}` (FieldObject): rename column, set Width
4. Tra ve DataTable da xu ly

### CachedDynCrystalReport

| Thuoc tinh | Chi tiet |
|------------|----------|
| **Ke thua** | Component, ICachedReport |
| **Muc dich** | Caching wrapper cho DynCrystalReport |
| **IsCacheable** | true |
| **ShareDBLogonInfo** | false |
| **CacheTimeOut** | CachedReportConstants.DEFAULT_TIMEOUT |

### MyDataSet

| Thuoc tinh | Chi tiet |
|------------|----------|
| **Ke thua** | DataSet (Typed DataSet) |
| **Muc dich** | Data container cho report data |
| **Tables** | MyDataTable (30 columns: DataColumn1..DataColumn30) |

**MyDataTableDataTable:**
- 30 DataColumn (DataColumn1..DataColumn30), kieu string
- Typed DataRow class (MyDataTableRow) voi 30 properties
- Event: MyDataTableRowChanging, MyDataTableRowChanged, MyDataTableRowDeleting, MyDataTableRowDeleted

### Report Objects trong Template

| Object Pattern | Loai | Muc dich |
|----------------|------|----------|
| lblCol{n} | TextObject | Label cho column header |
| txtCol{n} | FieldObject | Field hien thi gia tri |

## Ket luan

DynReport.dll la **Crystal Report wrapper** cho phep tao bao cao dong tu bat ky AsDataGridView nao. Khong co data access layer rieng - chi la wrapper de map data tu grid vao Crystal Report template embedded. Template co san 8 cặp label/field (lblCol0-7/txtCol0-7) de hien thi toi da 8 columns.
