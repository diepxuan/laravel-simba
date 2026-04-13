# Báo cáo Phân tích DLL: GLRptBCPT04.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLRptBCPT04 |
| Assembly Title | Báo cáo kết quả hoạt động sản xuất kinh doanh theo kỳ |
| Assembly Company | ASIASOFT |
| Assembly Product | DTE |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly File Version | 1.0.0.0 |
| Assembly Version | 1.0.0.0 |
| GUID | a341c082-09ae-4758-a1e6-9e068fc1292f |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptBCPT04.dll/
├── GLRptBCPT04.csproj              # Project file
├── app.ico                         # Application icon
├── Properties/
│   └── AssemblyInfo.cs             # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptBCPT04.cs           # Main report form
├── AsiaErp.UserInterface.My/
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MySettingsProperty.cs
│   ├── MyComputer.cs
│   └── MyApplication.cs
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs                # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| Framework | Asia ERP Framework |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System.Collections`, `System.ComponentModel`, `System.Data`, `System.Drawing`, `System.Text`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptBCPT04` | `frmReport` | Form báo cáo KQHĐSXKD theo kỳ |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Báo cáo kết quả hoạt động sản xuất kinh doanh theo kỳ" - Tên báo cáo
- "Từ tháng" - Label chọn tháng bắt đầu
- "đến tháng" - Label chọn tháng kết thúc
- "Quý / Tháng" - Label chọn loại kỳ báo cáo
- "Mã bộ phận" - Label nhập mã bộ phận

### Combobox options

| Control | Options |
|---------|---------|
| `cboThang1`, `cboThang2` | 1-12 (các tháng trong năm) |
| `cboQuy_Thang` | "Theo quý", "Theo tháng" |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_bp` | Mã bộ phận |
| `ma_nt` | Mã ngoại tệ |
| `tieu_de` | Tiêu đề báo cáo |
| `mau_bc` | Mẫu báo cáo |
| `ky_bc` | Kỳ báo cáo |

---

## Mục đích sử dụng

**GLRptBCPT04.dll là module báo cáo "Kết quả hoạt động sản xuất kinh doanh theo kỳ"** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Lọc dữ liệu báo cáo
- Chọn kỳ báo cáo (theo quý hoặc theo tháng)
- Chọn từ tháng đến tháng
- Lọc theo mã bộ phận
- Chọn loại tiền tệ (VND/ngoại tệ)
- Chọn mẫu báo cáo

#### 2. Tính toán và hiển thị
- Tải dữ liệu từ database theo các tham số lọc
- Hiển thị dữ liệu trên DataGridView
- Xuất báo cáo ra Excel
- In báo cáo qua Crystal Report

#### 3. Tham số truyền vào stored procedure

| Thứ tự | Tham số | Ý nghĩa |
|--------|---------|---------|
| 1 | CompanyID | Mã công ty |
| 2 | FinancialYear | Năm tài chính |
| 3 | Thang1 | Tháng bắt đầu |
| 4 | Thang2 | Tháng kết thúc |
| 5 | Quy_Thang | Loại kỳ (1=Quý, 2=Tháng) |
| 6 | ma_mau | Mã mẫu báo cáo |
| 7 | ma_bp | Mã bộ phận |

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Form báo cáo chuẩn
- Sử dụng `AsTextBox` với AutoLookup cho mã bộ phận
- Hỗ trợ đa tiền tệ (VND/ngoại tệ)
- Tích hợp Crystal Report cho in ấn

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP, phục vụ cho việc xem và in báo cáo Kết quả hoạt động sản xuất kinh doanh theo kỳ - một báo cáo tài chính quan trọng theo chuẩn mực kế toán Việt Nam.

---

*Ngày phân tích: 2026-03-29*
