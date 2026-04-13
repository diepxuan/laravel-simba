# Báo cáo Phân tích DLL: SiChangeFY.dll

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
| Assembly Name | SiChangeFY |
| Assembly Title | SiChangeFY |
| Assembly Company | Asiasoft |
| Assembly Product | SiChangeFY |
| Assembly Copyright | Copyright © Asiasoft 2012 |
| Assembly Trademark | "" |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | cffea815-cf42-4dcb-b095-d066624fb67d |
| ComVisible | false |

---

## Cấu trúc File

```
SiChangeFY.dll/
├── SiChangeFY.csproj            # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmSiChangeFY.cs         # Main form class
├── AsiaErp.UserInterface.My/
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MySettingsProperty.cs
│   └── InternalXmlHelper.cs
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | LINQ to XML |
| System.Core | .NET Core extensions |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections.Generic`, `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSiChangeFY` | `frmCalc` | Form thay đổi năm tài chính |

---

## Controls và Events

| Control | Loại | Mục đích |
|---------|------|----------|
| `cboFinanceYear` | AsComboBox | ComboBox chọn năm tài chính |
| `lblFinancialYear` | Label | Nhãn "Năm tài chính" |
| `cmdOK` | Button | Nút OK (override từ base) |
| `cmdCancel` | Button | Nút Cancel (từ base) |

### Events

| Event | Handler | Mô tả |
|-------|---------|-------|
| `cmdOK.Click` | `cmdOK_Click` | Xử lý khi chọn năm |
| `cmdCancel.Click` | `cmdCancel_Click` | Đóng form |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Năm tài chính" - Nhãn chọn năm

### Thuật ngữ kế toán

| Thuật tngữ | Ý nghĩa |
|-----------|---------|
| `financial_year` | Năm tài chính |
| `intFinanceYear` | Biến lưu năm tài chính được chọn |

---

## Mục đích sử dụng

**SiChangeFY.dll là module thay đổi năm tài chính** trong hệ thống AsiaERP của Asiasoft.

### Chức năng chính

#### 1. Chọn năm tài chính
- Hiển thị danh sách năm từ (năm hiện tại - 10) đến (năm hiện tại + 10)
- Mặc định chọn năm tài chính hiện tại của hệ thống
- Cho phép chuyển đổi nhanh giữa các năm

#### 2. Cập nhật hệ thống
- Cập nhật `SystemInformations.FinancialYear`
- Ảnh hưởng đến toàn bộ dữ liệu hiển thị trong hệ thống
- Thay đổi ngay lập tức không cần restart

### Đặc điểm kỹ thuật

- Kế thừa từ `frmCalc` (form tính toán/xử lý đơn giản)
- ComboBox với DropDownStyle = DropDownList (chỉ chọn, không nhập)
- Phạm vi năm: ±10 năm so với năm hiện tại
- Lưu giá trị vào biến `intFinanceYear` trước khi cập nhật

### Quy trình xử lý

1. Khởi tạo form với danh sách năm (Now.Year ± 10)
2. Chọn mặc định năm hiện tại của hệ thống
3. Người dùng chọn năm mới
4. Click OK → Cập nhật `SystemInformations.FinancialYear`
5. Đóng form

---

## Kết luận

Đây là module Windows Forms đơn giản của hệ thống AsiaERP, phục vụ cho việc thay đổi năm tài chính làm việc - một chức năng cơ bản cho phép người dùng xem và làm việc với dữ liệu của các năm tài chính khác nhau.

---

*Ngày phân tích: 2026-03-29*
