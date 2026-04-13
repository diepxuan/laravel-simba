# Báo cáo Phân tích DLL: PORptF5TH0.dll

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
| Assembly Name | PORptF5TH0 |
| Assembly Title | SORptF5TH0 |
| Assembly Company | asiasoft |
| Assembly Product | SORptF5TH0 |
| Assembly Copyright | Copyright © asiasoft 2010 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | dd8441b0-de09-4d15-9116-d78ffc695258 |
| ComVisible | false |

---

## Cấu trúc File

```
PORptF5TH0.dll/
├── PORptF5TH0.csproj               # Project file
├── app.ico                         # Application icon
├── Properties/
│   └── AssemblyInfo.cs             # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmPORptF5TH0.cs            # Main drilldown form
└── AsiaErp.UserInterface.My/
    ├── MyComputer.cs
    ├── MyApplication.cs
    ├── MySettings.cs
    ├── MySettingsProperty.cs
    ├── MyProject.cs
    ├── InternalXmlHelper.cs
    └── Resources/
        └── Resources.cs            # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Drawing | Graphics và UI |
| System.Windows.Forms | Windows Forms controls |
| AsiaErp.Framework | Asia ERP Framework |
| Microsoft.VisualBasic | Visual Basic runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.UserInterface`
- `System`, `System.Collections`, `System.Collections.Generic`
- `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`
- `System.Runtime.CompilerServices`, `System.Runtime.InteropServices`
- `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPORptF5TH0` | `frmDrilldownReport` | Form báo cáo tổng hợp F5 (drill-down) |

---

## Constructors

| Constructor | Tham số | Mô tả |
|-------------|---------|-------|
| `frmPORptF5TH0()` | - | Constructor mặc định |
| `frmPORptF5TH0(...)` | motherReportInfo, drilldown_menuid, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, datasource, arg | Constructor drill-down với thông tin từ báo cáo mẹ |

---

## Phương thức chính

| Phương thức | Mô tả |
|-------------|-------|
| `CreateDrilldownArgument()` | Tạo tham số drill-down khi người dùng nhấn F5 từ báo cáo mẹ |
| `InitializeComponent()` | Khởi tạo các thành phần UI |

---

## Mục đích sử dụng

**PORptF5TH0.dll là module Báo cáo tổng hợp F5 (drill-down)** trong hệ thống Simba Accounting của Asia Software.

### Chức năng chính

#### 1. Báo cáo Drill-down (F5)
- Được gọi khi người dùng nhấn F5 từ báo cáo mẹ
- Hiển thị chi tiết dữ liệu từ dòng được chọn trong báo cáo tổng hợp
- Kế thừa từ `frmDrilldownReport` để xử lý drill-down

#### 2. Nhận tham số từ báo cáo mẹ
- `motherReportInfo`: Thông tin báo cáo mẹ
- `drilldown_menuid`: Menu ID của báo cáo drill-down
- `formularFields`: Các trường công thức
- `isNT`: Cờ ngoại tệ
- `nhan_in`: Nhãn in
- `filter4Tilte`: Điều kiện filter cho tiêu đề
- `formatedColList`: Danh sách cột định dạng
- `datasource`: Dữ liệu nguồn
- `arg`: Các tham số bổ sung

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDrilldownReport` - form drill-down chuẩn của framework
- Form đơn giản, không có nhiều controls (chỉ có Container)
- Chức năng chính là nhận tham số và hiển thị dữ liệu chi tiết
- Sử dụng `CreateDrilldownArgument()` để xử lý drill-down tiếp theo

---

## Kết luận

Đây là module báo cáo drill-down F5 trong hệ thống Simba Accounting, được sử dụng để hiển thị chi tiết dữ liệu khi người dùng drill-down từ các báo cáo tổng hợp mua hàng.

---

*Ngày phân tích: 2026-03-29*
