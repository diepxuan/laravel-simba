# Báo cáo Phân tích DLL: GlRptBCT04.dll

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
| Assembly Name | GlRptBCT04 |
| Assembly Title | Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
GlRptBCT04.dll/
├── GlRptBCT04.csproj               # Project file
├── app.ico                         # Application icon
├── Properties/
│   └── AssemblyInfo.cs             # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGlRptBCT04.cs            # Main report form
│   ├── frmGLMauCF01.cs             # Form mẫu công thức 01
│   └── frmTATNDN01AEdit.cs         # Edit form
├── AsiaErp.DataAccess/
│   ├── IGlRptBCT04.cs              # Interface data access
│   └── MsSqlGlRptBCT04.cs          # SQL Server implementation
└── My/
    ├── MySettings.cs
    └── MySettingsProperty.cs
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Microsoft.VisualBasic | VB runtime |

### Namespaces sử dụng

- `AsiaErp.DataAccess`, `AsiaErp.Framework`
- `System.Collections`, `System.ComponentModel`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptBCT04` | `frmReport` | Form báo cáo lưu chuyển tiền tệ |
| `frmGLMauCF01` | - | Form mẫu công thức |
| `frmTATNDN01AEdit` | - | Form chỉnh sửa |
| `IGlRptBCT04` | - | Interface data access |
| `MsSqlGlRptBCT04` | - | SQL Server DAO implementation |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp" - Tên báo cáo
- "KB Công thức" - Nút khai báo công thức tính toán

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã số chỉ tiêu |
| `cach_tinh` | Cách tính (công thức) |
| `tien` | Số tiền |
| `stt` | Số thứ tự |
| `modify` | Cho phép sửa đổi |

---

## Mục đích sử dụng

**GlRptBCT04.dll là module báo cáo "Lưu chuyển tiền tệ theo phương pháp trực tiếp"** (Direct Method Cash Flow Statement) trong hệ thống ERP Asia Enterprise.

### Chức năng chính

#### 1. Lọc dữ liệu báo cáo
- Chọn kỳ báo cáo (từ ngày đến ngày)
- Chọn mẫu báo cáo

#### 2. Khai báo công thức
- Nút "KB Công thức" mở form `frmGLMauCF01`
- Cho phép định nghĩa công thức tính toán các chỉ tiêu lưu chuyển tiền

#### 3. Nhập liệu trực tiếp trên grid
- Một số chỉ tiêu cho phép nhập liệu trực tiếp (modify = true)
- Cột "tien" có thể chỉnh sửa
- Tự động tính toán lại các chỉ tiêu phụ thuộc

#### 4. Tính toán động
- Parse công thức từ chuỗi `cach_tinh`
- Tính toán giá trị chỉ tiêu theo công thức
- Hỗ trợ các phép toán: +, -, *, /
- Validate công thức trước khi tính

#### 5. Cập nhật dữ liệu
- Lưu giá trị nhập trực tiếp vào database
- Interface `IGlRptBCT04` với method `UpdateDataCell`

#### 6. Tham số truyền vào stored procedure

| Thứ tự | Tham số | Ý nghĩa |
|--------|---------|---------|
| 1 | CompanyID | Mã công ty |
| 2 | Ngay1 | Ngày bắt đầu |
| 3 | Ngay2 | Ngày kết thúc |
| 4 | ma_mau | Mã mẫu báo cáo |

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Form báo cáo chuẩn
- Tích hợp với `frmGLMauCF01` cho khai báo công thức
- Xử lý nhập liệu trực tiếp trên DataGridView
- Sự kiện `CellEnter` và `CellValidated` cho xử lý nhập liệu
- Tầng Data Access với Interface `IGlRptBCT04`
- Tính toán công thức động qua `DataTable.Compute`

### Xử lý công thức

```csharp
// Ví dụ công thức: "A+B-C"
// Chuyển thành: "sum([A])+sum([B])-sum([C])"
// Tính toán qua DataTable.Compute
```

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc lập báo cáo Lưu chuyển tiền tệ theo phương pháp trực tiếp theo chuẩn mực kế toán Việt Nam. Báo cáo cho phép nhập liệu trực tiếp và định nghĩa công thức tính toán linh hoạt.

---

*Ngày phân tích: 2026-03-29*
