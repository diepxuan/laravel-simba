# Báo cáo Phân tích DLL: INCDFIFO.dll

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
| Assembly Name | INCDFIFO |
| Assembly Title | Công nợ định mức FIFO |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | true |

---

## Cấu trúc File

```
INCDFIFO.dll/
├── INCDFIFO.csproj            # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaERP.DataAccess/
│   ├── INCDFIFODAO.cs           # Data Access Object
│   └── MsSqlINCDFIFODAO.cs      # MSSQL Implementation
├── AsiaERP.UserInterface/
│   ├── frmINCDFIFO.cs           # Main form class
│   ├── frmINCDFIFOEdit.cs       # Edit form class
│   └── frmINCDFIFOFilter.cs     # Filter form class
├── My/
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MySettingsProperty.cs
│   └── InternalXmlHelper.cs
└── My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaERP.DataAccess`, `AsiaERP.UserInterface`
- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.Collections.Generic`
- `System.ComponentModel`, `System.Data`, `System.Diagnostics`
- `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINCDFIFO` | `frmOBView` | Form xem công nợ định mức FIFO |
| `frmINCDFIFOEdit` | - | Form chỉnh sửa |
| `frmINCDFIFOFilter` | - | Form lọc dữ liệu |
| `INCDFIFODAO` | - | Data Access Object |
| `MsSqlINCDFIFODAO` | - | MSSQL DAO Implementation |

---

## Chi tiết Form frmINCDFIFO

### Các trường dữ liệu chính

| Field | Kiểu | Mục đích |
|-------|------|----------|
| `check` | bool | Kiểm tra đã chọn filter |
| `strMa_vt` | string | Mã vật tư (từ filter) |
| `strMa_kho` | string | Mã kho (từ filter) |
| `STR_TKVT` | string | Tài khoản vật tư |

### Phương thức quan trọng

| Method | Mô tả |
|--------|-------|
| `Login()` | Hiển thị form filter, nhận điều kiện lọc |
| `GetData()` | Lấy dữ liệu công nợ định mức theo điều kiện |
| `frmINCDVT_Shown()` | Kiểm tra và đóng form nếu không chọn filter |

---

## Chi tiết Form frmINCDFIFOFilter

### Các trường dữ liệu

| Control | Mục đích |
|---------|----------|
| txtMa_vt | Mã vật tư |
| txtMa_kho | Mã kho |
| txtYear | Năm tài chính |

---

## Các chuỗi Text đáng chú ý

### Thuật ngữ FIFO

FIFO (First In First Out) là phương pháp:
- Nhập trước xuất trước
- Tính giá tồn kho theo giá nhập đầu tiên
- Phù hợp với hàng hóa có hạn sử dụng

---

## Mục đích sử dụng

**INCDFIFO.dll là module quản lý công nợ định mức theo phương pháp FIFO** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý công nợ định mức
- Theo dõi công nợ theo định mức FIFO
- Quản lý theo vật tư và kho
- Theo dõi theo năm tài chính

#### 2. Phương pháp FIFO
- Nhập trước xuất trước
- Tính giá vốn theo giá nhập đầu tiên
- Phù hợp với ngành hàng có hạn sử dụng

#### 3. Lọc và tìm kiếm
- Lọc theo mã vật tư
- Lọc theo mã kho
- Lọc theo năm tài chính

### Đặc điểm kỹ thuật

- Sử dụng DAO pattern cho data access
- Tách biệt interface và MSSQL implementation
- Form filter riêng biệt
- Kiểm tra điều kiện trước khi hiển thị dữ liệu

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý công nợ định mức theo phương pháp FIFO - một phương pháp tính giá tồn kho phổ biến.

---

*Ngày phân tích: 2026-03-29*
