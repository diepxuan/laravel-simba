# GenerationReport - Module tạo báo cáo động (RDL)

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GenerationReport.dll |
| Loại | Class Library |
| Namespace | `GenerationReport` |
| Framework | .NET Framework |

---

## Chức năng

Tạo báo cáo động RDL (Report Definition Language) từ DataGridView với định dạng linh hoạt.

---

## Classes

| Class | Mục đích |
|-------|----------|
| `CreateReport` | Class chính tạo báo cáo từ DataGridView |
| `RdlGenerator` | Tạo nội dung RDL XML cho report |
| `ReportConfig` | Cấu hình font, margin, format số |
| `TableRdlGenerator` | Tạo layout bảng trong report |
| `TextBoxRdlGenerator` | Tạo textbox trong report |
| `HeaderRdlGenerator` | Tạo header (stub) |
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

## Định dạng

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

## Chức năng chi tiết

### 1. Tạo báo cáo từ DataGridView
- Chuyển đổi DataGridView thành DataTable
- Xử lý định dạng số, ngày tháng
- Thay thế ký tự đặc biệt trong tên cột

### 2. Tạo file RDL
- Tạo XML theo chuẩn RDL
- Định nghĩa DataSource, DataSet
- Tạo PageHeader, PageFooter, Body

### 3. Cấu hình báo cáo
- Font cho từng phần (tiêu đề, công ty, tài khoản)
- Margin trang (top, bottom, left, right)
- Định dạng số và ngày tháng

### 4. Layout bảng
- Tạo bảng từ DataGridView
- Định nghĩa cột và header
- Căn chỉnh text

---

## Cấu trúc RDL được tạo

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

## Dependencies

- `System.Data` - DataTable, DataRow
- `System.Windows.Forms` - DataGridView
- `System.Drawing` - Font, PointF, SizeF
- `System.Xml.Serialization` - RDL XML serialization
- `Rdl` - RDL schema types
- `AsiaErp.Framework` - Environment, SIConfiguration

---

*Ngày tạo: 2026-03-29*
