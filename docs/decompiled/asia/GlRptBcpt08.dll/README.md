# Báo cáo Phân tích DLL: GlRptBcpt08.dll

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
| Assembly Name | GlRptBcpt08 |
| Assembly Title | Báo cáo kết quả hoạt động sản xuất kinh doanh |
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
GlRptBcpt08.dll/
├── GlRptBcpt08.csproj              # Project file
├── app.ico                         # Application icon
├── Properties/
│   └── AssemblyInfo.cs             # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGlRptBcpt08.cs           # Main report form
│   ├── frmGLMauPL01.cs             # Form mẫu phụ lục 01
│   └── frmGLMauPL01Edit.cs         # Edit form mẫu phụ lục
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
| Microsoft.VisualBasic | VB runtime |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System.Collections`, `System.ComponentModel`, `System.Data`, `System.Drawing`, `System.Runtime.InteropServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptBcpt08` | `frmReport` | Form báo cáo KQHĐSXKD |
| `frmGLMauPL01` | - | Form mẫu phụ lục 01 |
| `frmGLMauPL01Edit` | - | Form chỉnh sửa mẫu phụ lục |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "KB Công thức" - Nút khai báo công thức tính toán

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã số chỉ tiêu |
| `cach_tinh` | Cách tính (công thức) |
| `tk` | Tài khoản |
| `cong_no` | Công nợ |
| `tien` | Tiền |

---

## Mục đích sử dụng

**GlRptBcpt08.dll là module báo cáo "Kết quả hoạt động sản xuất kinh doanh"** với tính năng khai báo công thức và drill-down trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Lọc dữ liệu báo cáo
- Chọn kỳ báo cáo
- Chọn mẫu báo cáo
- Chọn loại tiền tệ (VND/ngoại tệ)

#### 2. Khai báo công thức
- Nút "KB Công thức" mở form `frmGLMauPL01`
- Cho phép định nghĩa công thức tính toán các chỉ tiêu

#### 3. Drill-down (Xem chi tiết)
- Phím F5: Drill-down đến báo cáo chi tiết
- Phím Shift+F5: Xem sổ chi tiết tài khoản
- Phím Ctrl+F5: Xem công nợ (nếu là TK công nợ)

#### 4. Xử lý công thức
- Parse công thức từ chuỗi `cach_tinh`
- Tính toán giá trị chỉ tiêu từ các mã số khác
- Hỗ trợ các phép toán: +, -, *, /

#### 5. Tham số truyền vào stored procedure

| Thứ tự | Tham số | Ý nghĩa |
|--------|---------|---------|
| 1 | CompanyID | Mã công ty |
| 2 | Ngay1 | Ngày bắt đầu |
| 3 | Ngay2 | Ngày kết thúc |
| 4 | ma_mau | Mã mẫu báo cáo |
| 5 | ma_nt | Mã ngoại tệ |

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Form báo cáo chuẩn
- Override `CreateDrilldownArgument` để xử lý drill-down
- Hỗ trợ 3 loại drill-down khác nhau (F5, Shift+F5, Ctrl+F5)
- Tích hợp với `frmGLMauPL01` cho khai báo công thức
- Xử lý công thức tính toán động

### Xử lý Drill-down

| Phím | Chức năng |
|------|-----------|
| F5 | Drill-down theo công thức hoặc tài khoản |
| Shift+F5 | Xem sổ chi tiết tài khoản |
| Ctrl+F5 | Xem công nợ (chỉ cho TK công nợ) |

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP, phục vụ cho việc xem và in báo cáo Kết quả hoạt động sản xuất kinh doanh với tính năng khai báo công thức linh hoạt và drill-down đa tầng để phân tích chi tiết.

---

*Ngày phân tích: 2026-03-29*
