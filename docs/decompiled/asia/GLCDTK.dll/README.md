# Báo cáo Phân tích DLL: GLCDTK.dll

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
| Assembly Name | GLCDTK |
| Assembly Title | Số dư đầu kỳ các tài khoản |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaErp |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 8a7d23a8-8e3c-49d8-b94f-f3b9d5c5d6ae |
| ComVisible | false |

---

## Cấu trúc File

```
GLCDTK.dll/
├── GLCDTK.csproj                # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── AsiaERP.DataAccess/
│   ├── ICalcSumTKDAO.cs         # Interface DAO
│   └── MsSqlCalcSumTkDAO.cs     # SQL Server DAO implementation
├── AsiaErp.UserInterface/
│   ├── frmGLCDTK.cs             # Main form - Số dư đầu kỳ TK
│   ├── frmGLCDTKEdit.cs       # Edit form - Nhập số dư
│   ├── frmGLCDTKFilter.cs     # Filter form - Chọn kỳ
│   └── frmGLCDTKFilterTk.cs   # Filter TK form
├── AsiaERP.UserInterface/
│   └── frmGLSdDkTk.cs         # Form tính tổng số dư
├── My/
│   ├── MyApplication.cs           # VB My.Application
│   ├── MyComputer.cs          # VB My.Computer
│   ├── MyProject.cs          # VB My.Project
│   ├── MySettings.cs       # Settings
│   ├── MySettingsProperty.cs  # Settings property
│   └── InternalXmlHelper.cs  # XML Helper
└── My.Resources/
    └── Resources.cs       # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| AsiaErp.Framework | Asia ERP Framework |
| AsiaERP.UserInterface | UI Framework |

### Namespaces sử dụng

- `AsiaERP.DataAccess`
- `AsiaErp.Framework`
- `AsiaERP.UserInterface`
- `System`, `System.Data`, `System.Windows.Forms`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLCDTK` | `frmOBView` | Form xem số dư đầu kỳ tài khoản |
| `frmGLCDTKEdit` | `frmOBEdit` | Form nhập số dư đầu kỳ |
| `frmGLCDTKFilter` | - | Form chọn kỳ nhập số dư |
| `frmGLCDTKFilterTk` | - | Form lọc tài khoản |
| `frmGLSdDkTk` | - | Form tính tổng số dư |
| `ICalcSumTKDAO` | Interface | Interface tính tổng |
| `MsSqlCalcSumTkDAO` | `MsSqlDAO` | Triển khai tính tổng |
| `Resources` | - | Resource manager |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Số dư đầu kỳ các tài khoản" - Tên chức năng chính
- "Đầu kỳ", "Đầu năm" - Phân biệt số dư
- "Dư nợ", "Dư có" - Số dư VND
- "Dư nợ NT", "Dư có NT" - Số dư ngoại tệ
- "Tính tổng" - Button tính tổng số dư

### Cột DataGridView

| Cột | Ý nghĩa |
|-----|---------|
| tk | Tài khoản |
| ten_tk | Tên tài khoản |
| du_no00 | Dư nợ đầu năm |
| du_co00 | Dư có đầu năm |
| du_no_nt00 | Dư nợ NT đầu năm |
| du_co_nt00 | Dư có NT đầu năm |
| du_no | Dư nợ đầu kỳ |
| du_co | Dư có đầu kỳ |
| du_no_nt | Dư nợ NT đầu kỳ |
| du_co_nt | Dư có NT đầu kỳ |
| tk_cn | Tài khoản công nợ |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk` | Tài khoản |
| `ten_tk` | Tên tài khoản |
| `du_no` | Dư nợ |
| `du_co` | Dư có |
| `du_no_nt` | Dư nợ ngoại tệ |
| `du_co_nt` | Dư có ngoại tệ |
| `du_no00` | Dư nợ đầu năm |
| `du_co00` | Dư có đầu năm |
| `tk_cn` | Tài khoản công nợ |

---

## Mục đích sử dụng

**GLCDTK.dll là module Số dư đầu kỳ các tài khoản (Công nợ tài khoản)** trong hệ thống ERP Asia Enterprise.

### Chức năng chính

#### 1. Nhập số dư đầu kỳ tài khoản
- Nhập số dư đầu kỳ cho các tài khoản kế toán
- Phân biệt số dư đầu kỳ và đầu năm
- Hỗ trợ số dư ngoại tệ
#### 2. Quản lý số dư
- Xem danh sách số dư theo tài khoản
- Nhập số dư nợ/có cho từng tài khoản
- Quản lý số dư ngoại tệ
#### 3. Tính tổng số dư
- Tính tổng dư nợ/dư có
- Tính tổng dư nợ NT/dư có NT
- Stored Procedure: `asGLCalSumCdTk`
#### 4. Kiểm soát kỳ
- Chọn tháng nhập số dư
- Kiểm tra khóa sổ (ngày khóa)
- Cảnh báo nếu nhập trước kỳ khóa
### Đặc điểm kỹ thuật

- Kế thừa từ `frmOBView` - Form opening balance chuẩn
- Sử dụng `AsTextNumeric` cho nhập số tiền
- Validation dữ liệu đầu vào
- Mask format cho số tiền (Amount, FCAmount)
- Tích hợp DAO pattern
### Stored Procedures

| Procedure | Mục đích |
|-----------|----------|
| `asGLCalSumCdTk` | Tính tổng số dư công nợ tài khoản |
---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập và quản lý số dư đầu kỳ các tài khoản kế toán.
---

*Ngày phân tích: 2026-03-29*
