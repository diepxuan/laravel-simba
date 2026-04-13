# Báo cáo Phân tích DLL: GenerationReport.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Class Library) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |
| Namespace | GenerationReport |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GenerationReport |
| Assembly Title | GenerationReport |
| Assembly Product | GenerationRepot |
| Assembly Company | AsiaSoft |
| Assembly Copyright | Copyright © Asiasoft 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | a98b523b-ef72-473e-9bdf-f5e526a4b668 |
| ComVisible | false |

---

## Cấu trúc File

```
GenerationReport.dll/
├── GenerationReport.csproj        # Project file
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── Rdl/                           # RDL schema definitions
└── GenerationReport/
    ├── CreateReport.cs            # Main report creation class
    ├── RdlGenerator.cs            # RDL XML generator
    ├── ReportConfig.cs            # Report configuration
    ├── TableRdlGenerator.cs       # Table layout generator
    ├── TextBoxRdlGenerator.cs     # Textbox generator
    ├── HeaderRdlGenerator.cs      # Header generator (stub)
    ├── EBorderStyle.cs            # Border style enum
    ├── HorizontalText.cs          # Horizontal alignment enum
    ├── VerticalText.cs            # Vertical alignment enum (stub)
    └── Utility.cs                 # Utility functions
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | DataTable, DataRow operations |
| System.Windows.Forms | DataGridView |
| System.Drawing | Font, PointF, SizeF |
| System.Xml.Serialization | RDL XML serialization |
| Rdl | RDL schema types |
| AsiaErp.Framework | Environment, SIConfiguration |

### Namespaces sử dụng

- `System`, `System.Collections.Generic`, `System.Data`, `System.IO`
- `System.Drawing`, `System.Windows.Forms`, `System.Xml.Serialization`
- `AsiaErp.Framework`

---

## Classes và Components

| Class | Mục đích |
|-------|----------|
| `CreateReport` | Class chính tạo báo cáo từ DataGridView |
| `RdlGenerator` | Tạo nội dung RDL XML cho report |
| `ReportConfig` | Cấu hình font, margin, format số |
| `TableRdlGenerator` | Tạo layout bảng trong report |
| `TextBoxRdlGenerator` | Tạo textbox trong report |
| `EBorderStyle` | Enum định nghĩa kiểu border |
| `HorizontalText` | Enum căn chỉnh ngang |
| `VerticalText` | Enum căn chỉnh dọc |
| `Utility` | Các hàm tiện ích |

---

## Thuộc tính CreateReport

| Property | Kiểu | Mô tả |
|----------|------|-------|
| `Title` | string | Tiêu đề báo cáo |
| `CompanyName` | string | Tên công ty |
| `ParentCompanyName` | string | Tên công ty mẹ |
| `SubTitle` | string | Phụ đề |
| `FilterTitle` | string | Tiêu đề bộ lọc |
| `SubFilterTitle` | string | Phụ đề bộ lọc |
| `FormatDateTime` | string | Định dạng ngày tháng |
| `FormatNumber` | string | Định dạng số |
| `DGView` | DataGridView | DataGridView nguồn |
| `TableSource` | DataTable | DataTable đã xử lý |
| `Ngay1`, `Ngay2` | string | Ngày từ/đến |
| `Parent` | string | Parent control |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Trang " + PageNumber + "/" + TotalPages - Số trang

### Định dạng

| Định dạng | Mô tả |
|-----------|-------|
| `{0:dd/MM/yyyy}` | Ngày tháng mặc định |
| Amount_Input_Format | Định dạng tiền |
| FCPrice_Input_Format | Định dạng giá ngoại tệ |
| FCAmount_Input_Format | Định dạng tiền ngoại tệ |
| Price_Input_Format | Định dạng giá |
| Qty_Input_Format | Định dạng số lượng |

### Format codes

| Code | Ý nghĩa |
|------|---------|
| 0 | Amount |
| 1 | FC Price |
| 2 | FC Amount |
| 3 | Price |
| 4 | Quantity |

---

## Mục đích sử dụng

**GenerationReport.dll là module tạo báo cáo động (RDL)** trong hệ thống ERP của AsiaSoft.

### Chức năng chính

#### 1. Tạo báo cáo từ DataGridView
- Chuyển đổi DataGridView thành DataTable
- Xử lý định dạng số, ngày tháng
- Thay thế ký tự đặc biệt trong tên cột

#### 2. Tạo file RDL (Report Definition Language)
- Tạo XML theo chuẩn RDL
- Định nghĩa DataSource, DataSet
- Tạo PageHeader, PageFooter, Body

#### 3. Cấu hình báo cáo
- Font cho từng phần (tiêu đề, công ty, tài khoản)
- Margin trang (top, bottom, left, right)
- Định dạng số và ngày tháng

#### 4. Layout bảng
- Tạo bảng từ DataGridView
- Định nghĩa cột và header
- Căn chỉnh text

### Đặc điểm kỹ thuật

- Sử dụng XML Serialization cho RDL
- Hỗ trợ nhiều định dạng số
- Tự động phát hiện kiểu dữ liệu (số, ngày tháng)
- Tích hợp với AsiaErp.Framework

### Cấu trúc RDL được tạo

```
Report
├── DataSources
├── DataSets
├── PageHeader
│   ├── ParentCompanyName
│   ├── CompanyName
│   ├── Title
│   ├── SubTitle
│   ├── FilterTitle
│   └── SubFilterTitle
├── Body
│   └── Table
└── PageFooter
    └── Trang (Page number)
```

---

## Kết luận

Đây là module thư viện tạo báo cáo động RDL, cho phép tạo báo cáo từ DataGridView với định dạng linh hoạt và xuất ra dạng MemoryStream để hiển thị hoặc in ấn.

---

*Ngày phân tích: 2026-03-29*
