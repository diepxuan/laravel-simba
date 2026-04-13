# Báo cáo Phân tích DLL: INRptF5CD01.dll

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
| Assembly Name | INRptF5CD01 |
| Assembly Title | GLRptF5CTGS01 |
| Assembly Company | Asia |
| Assembly Product | GLRptF5CTGS01 |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | (trống) |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 555e1310-3ce6-4277-ba6a-2a9dff935e02 |
| ComVisible | false |

---

## Cấu trúc File

```
INRptF5CD01.dll/
├── INRptF5CD01.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmINRptF5CD01.cs         # Main report form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Windows.Forms | Windows Forms controls |
| AsiaErp.Framework | Asia ERP Framework |
| Microsoft.VisualBasic | Visual Basic runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System.ComponentModel`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINRptF5CD01` | `frmDrilldownReport` | Form báo cáo công nợ F5 01 (drill-down) |

---

## Các thuộc tính và phương thức

### Constructor

| Phương thức | Tham số | Mục đích |
|---------------|---------|----------|
| `.ctor()` | (không) | Khởi tạo form mặc định |
| `.ctor(ReportInformation, string, AsDictionary, bool, string, string, string, object, params object[])` | motherReportInfo, drilldownMenuId, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, datasource, arg | Khởi tạo form drill-down từ báo cáo cha |

### Phương thức bảo vệ

| Phương thức | Mục đích |
|--------------|----------|
| `InitOtherComponents()` | Khởi tạo các component bổ sung, focus vào DataGridView báo cáo |
| `Dispose(bool)` | Giải phóng tài nguyên |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `F5` | Phím tắt drill-down (xem chi tiết) trong báo cáo |
| `CD` | Công nợ |
| `drilldown` | Chức năng xem chi tiết từ báo cáo tổng hợp |
| `motherReport` | Báo cáo gốc/tổng hợp |

---

## Mục đích sử dụng

**INRptF5CD01.dll là module báo cáo "Công nợ F5 01"** - một báo cáo drill-down trong hệ thống Asia ERP.

### Chức năng chính

#### 1. Báo cáo drill-down công nợ
- Hiển thị chi tiết công nợ khi người dùng nhấn F5 từ báo cáo tổng hợp
- Kế thừa thông tin từ báo cáo cha (mother report)
- Hiển thị dữ liệu chi tiết theo context đã chọn

#### 2. Các tham số drill-down

| Tham số | Mô tả |
|-----------|-------|
| `motherReportInfo` | Thông tin báo cáo cha |
| `drilldownMenuId` | ID menu drill-down |
| `formularFields` | Các trường công thức tính toán |
| `isNT` | Có phải ngoại tệ không |
| `nhan_in` | Nhãn in |
| `filter4Tilte` | Tiêu đề bộ lọc |
| `formatedColList` | Danh sách cột định dạng |
| `datasource` | Nguồn dữ liệu |
| `arg` | Các tham số bổ sung |

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDrilldownReport` - base form báo cáo drill-down chuẩn của Asia ERP
- Tự động focus vào DataGridView báo cáo khi khởi tạo
- Không có giao diện nhập liệu phức tạp - dữ liệu được truyền từ báo cáo cha
- Đơn giản, nhẹ - chỉ hiển thị dữ liệu đã được xử lý

### Luồng hoạt động

1. Người dùng xem báo cáo tổng hợp công nợ
2. Người dùng chọn dòng cần xem chi tiết và nhấn F5
3. Hệ thống khởi tạo `frmINRptF5CD01` với thông tin từ báo cáo cha
4. Form hiển thị chi tiết công nợ tương ứng

---

## Kết luận

Đây là module Windows Forms đơn giản của hệ thống Asia ERP, phục vụ chức năng drill-down (xem chi tiết) từ báo cáo công nợ tổng hợp. Module này không có giao diện nhập liệu phức tạp mà chỉ đóng vai trò hiển thị dữ liệu chi tiết được truyền từ báo cáo cha.

---

*Ngày phân tích: 2026-03-29*
