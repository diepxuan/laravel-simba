# Báo cáo Phân tích DLL: GlRptBCT06.dll

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
| Assembly Name | GlRptBCT06 |
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
GlRptBCT06.dll/
├── GlRptBCT06.csproj               # Project file
├── app.ico                         # Application icon
├── Properties/
│   └── AssemblyInfo.cs             # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGlRptBCT06.cs            # Main report form
│   ├── frmTATNDN031A.cs            # Form mẫu TATNDN031A
│   └── frmTATNDN031AEdit.cs        # Edit form
└── AsiaErp.UserInterface.My/
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

- `AsiaErp.Framework`
- `System.Collections`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptBCT06` | `frmReport` | Form báo cáo lưu chuyển tiền tệ |
| `frmTATNDN031A` | - | Form mẫu TATNDN031A |
| `frmTATNDN031AEdit` | - | Form chỉnh sửa |

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

---

## Mục đích sử dụng

**GlRptBCT06.dll là module báo cáo "Lưu chuyển tiền tệ theo phương pháp trực tiếp"** (Direct Method Cash Flow Statement) - phiên bản thứ 6 trong hệ thống ERP Asia Enterprise.

### Chức năng chính

#### 1. Lọc dữ liệu báo cáo
- Chọn kỳ báo cáo (từ ngày đến ngày)
- Chọn mẫu báo cáo
- Chọn loại tiền tệ (VND/ngoại tệ)

#### 2. Khai báo công thức
- Nút "KB Công thức" mở form `frmTATNDN031A`
- Cho phép định nghĩa công thức tính toán các chỉ tiêu lưu chuyển tiền

#### 3. Hiển thị và xuất báo cáo
- Hiển thị dữ liệu trên DataGridView
- Xuất báo cáo ra Excel
- In báo cáo

#### 4. Tham số truyền vào stored procedure

| Thứ tự | Tham số | Ý nghĩa |
|--------|---------|---------|
| 1 | CompanyID | Mã công ty |
| 2 | Ngay1 | Ngày bắt đầu |
| 3 | Ngay2 | Ngày kết thúc |
| 4 | ma_mau | Mã mẫu báo cáo |

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Form báo cáo chuẩn
- Tích hợp với `frmTATNDN031A` cho khai báo công thức
- Đơn giản hơn các phiên bản BCT04 và BCT05
- Không có tính năng nhập liệu trực tiếp trên grid
- Tập trung vào việc hiển thị và xuất báo cáo

### So sánh với các phiên bản khác

| Phiên bản | Đặc điểm |
|-----------|----------|
| BCT04 | Có nhập liệu trực tiếp, tầng Data Access riêng |
| BCT05 | Có nhập liệu trực tiếp, tầng Data Access riêng |
| BCT06 | Đơn giản, chỉ hiển thị, không nhập liệu trực tiếp |

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc lập báo cáo Lưu chuyển tiền tệ theo phương pháp trực tiếp. Đây là phiên bản thứ 6, đơn giản hơn các phiên bản trước, tập trung vào việc hiển thị và xuất báo cáo mà không hỗ trợ nhập liệu trực tiếp trên grid.

---

*Ngày phân tích: 2026-03-29*
