# Báo cáo Phân tích DLL: Fakkts.dll

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
| Assembly Name | Fakkts |
| Assembly Title | Fakkts |
| Assembly Product | Fakkts |
| Assembly Company | Asiasoft |
| Assembly Copyright | Copyright © Asiasoft 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | bf477b90-f584-4b48-ab1d-2c878fd156d2 |
| ComVisible | false |

---

## Cấu trúc File

```
Fakkts.dll/
├── Fakkts.csproj                     # Project file
├── app.ico                           # Application icon
├── AsiaERP.UserInterface.frmFakkts.resx  # Form resources
├── Properties/
│   └── AssemblyInfo.cs               # Assembly metadata
├── AsiaERP.UserInterface/
│   └── frmFakkts.cs                  # Main form - Kiểm kê tài sản
└── AsiaERP.UserInterface.My/
    ├── MyApplication.cs              # Application settings
    ├── MySettings.cs                 # Settings
    ├── MySettingsProperty.cs         # Settings property
    ├── MyComputer.cs                 # Computer info
    ├── MyProject.cs                  # Project info
    └── InternalXmlHelper.cs          # XML helper
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Xml.Linq | LINQ to XML |
| System.Data.DataSetExtensions | DataSet extensions |
| System.Core | .NET Core extensions |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |
| Microsoft.Office.Interop.Excel | Excel interop for import |

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFakkts` | `frmAsiaRoot` | Form kiểm kê tài sản cố định, hỗ trợ import từ Excel |

---

## Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `Panel1` | `Panel` | Container chính |
| `dgvKK` | `AsDataGridView` | DataGridView hiển thị danh sách kiểm kê |
| `btnImportExcel` | `Button` | Nút import từ Excel |
| `oFDialog` | `OpenFileDialog` | Dialog chọn file Excel |

---

## DataGridView Columns

| Column | Loại | Mục đích |
|--------|------|----------|
| `dgvcFA_CODE` | `DataGridViewTextBoxColumn` | Mã tài sản |
| `dgvcQuanlity` | `DataGridViewAsTextNumericColumn` | Số lượng |
| `dgvcDate` | `DataGridViewAsMaskedTextBoxColumn` | Ngày kiểm kê |

---

## Mục đích sử dụng

**Fakkts.dll là module Kiểm kê Tài sản (Fixed Asset Inventory)** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý Kiểm kê Tài sản
- Nhập liệu kiểm kê tài sản cố định
- Hiển thị danh sách tài sản kiểm kê
- Quản lý thông tin: mã tài sản, số lượng, ngày kiểm kê

#### 2. Import từ Excel
- Import dữ liệu kiểm kê từ file Excel
- Sử dụng `Microsoft.Office.Interop.Excel`
- OpenFileDialog để chọn file

#### 3. Data Management
- Sử dụng `System.Data.DataTable` làm nguồn dữ liệu
- Binding với DataGridView
- Cập nhật dữ liệu real-time

### Đặc điểm kỹ thuật

- Kế thừa từ `frmAsiaRoot` (form base của Asia ERP)
- Sử dụng custom controls: `AsDataGridView`, `DataGridViewAsTextNumericColumn`, `DataGridViewAsMaskedTextBoxColumn`
- Tích hợp Excel Interop cho import dữ liệu
- Hỗ trợ OLE DB cho đọc file Excel

---

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `FA_CODE` | Mã tài sản cố định (Fixed Asset Code) |
| `Quanlity` | Số lượng |
| `dgvKK` | DataGridView Kiểm kê |
| `KK` | Kiểm kê |
| `Fakkts` | Fixed Asset Kiểm kê Tài sản |

---

## Kết luận

Đây là module hỗ trợ việc kiểm kê tài sản cố định, cho phép nhập liệu trực tiếp hoặc import từ Excel, giúp đơn giản hóa quy trình kiểm kê tài sản trong doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
