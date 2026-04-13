# Báo cáo Phân tích DLL: FADelKHTS.dll

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
| Assembly Name | FADelKHTS |
| Assembly Title | Xóa khấu hao tài sản cố định |
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
FADelKHTS.dll/
├── FADelKHTS.csproj            # Project file
├── app.ico                     # Application icon
├── Properties/
│   └── AssemblyInfo.cs         # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmFADelKHTS.cs         # Main form class
└── AsiaErp.UserInterface.My/
    ├── MySettings.cs           # Settings manager
    └── MySettingsProperty.cs   # Settings property
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFADelKHTS` | `frmCalc` | Form xóa khấu hao tài sản cố định |

---

## UI Controls

| Control | Type | Mục đích |
|---------|------|----------|
| `cboKyBc` | AsComboBox | Chọn kỳ báo cáo (tháng) |
| `txtMa_Ts` | AsTextBox | Nhập mã tài sản |
| `lblThang` | Label | Nhãn "Tháng" |
| `lblMa_ts` | Label | Nhãn "Mã tài sản" |
| `lblTen_TS` | Label | Hiển thị tên tài sản |

---

## Business Logic

### Tham số thực thi (Execute)

| Thứ tự | Tham số | Mô tả |
|--------|---------|-------|
| 1 | CompanyID | Mã công ty |
| 2 | FinancialYear | Năm tài chính |
| 3 | cboKyBc.Text | Tháng báo cáo |
| 4 | txtMa_Ts.Text | Mã tài sản |
| 5 | par1 | Tham số menu |

### Validation

- Kiểm tra ngày khóa sổ (`ngay_ks`): Không cho phép xóa dữ liệu trước ngày khóa sổ
- Kiểm tra mã tài sản hợp lệ (thông qua LookupCodeName = "MA_TS")

### Xử lý chính

1. Người dùng chọn tháng và nhập mã tài sản
2. Hệ thống tự động hiển thị tên tài sản
3. Kiểm tra quyền và ngày khóa sổ
4. Gọi stored procedure thông qua `MyController.Execute()`
5. Hiển thị thông báo kết quả

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Tháng" - Chọn kỳ báo cáo
- "Mã tài sản" - Nhập mã tài sản cần xóa khấu hao

### Lookup

| Code | Mô tả |
|------|-------|
| MA_TS | Mã tài sản - tự động lookup tên tài sản |

### Mã thông báo

| Mã | Ý nghĩa |
|----|---------|
| 50010 | Thông báo lỗi |
| 50015 | Thông báo thành công |
| 50136 | Lỗi ngày khóa sổ |

---

## Mục đích sử dụng

**FADelKHTS.dll là module xóa khấu hao tài sản cố định** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Xóa khấu hao tài sản cố định
- Chọn kỳ báo cáo (tháng) cần xóa khấu hao
- Nhập mã tài sản cụ thể cần xóa khấu hao
- Hệ thống tự động hiển thị tên tài sản (lookup)
- Kiểm tra ngày khóa sổ trước khi thực hiện

#### 2. Kiểm soát an toàn
- Kiểm tra ngày khóa sổ để tránh xóa dữ liệu đã khóa
- Validation dữ liệu đầu vào
- Thông báo kết quả rõ ràng

### Đặc điểm kỹ thuật

- Kế thừa từ `frmCalc` - form tính toán chuẩn của Asia ERP
- Sử dụng `AsComboBox` và `AsTextBox` controls
- Hỗ trợ AutoLookup cho mã tài sản (MA_TS)
- Tích hợp với Asia ERP Framework
- Lưu trữ tháng đã chọn vào PublicVariables ("Thang1")

### Luồng dữ liệu

```
User chọn Tháng + Nhập Mã TS → AutoLookup Tên TS → Validate ngày khóa sổ → Execute SP → Thông báo kết quả
```

---

## Kết luận

Đây là module phục vụ cho việc xóa khấu hao của một tài sản cố định cụ thể trong một kỳ nhất định. Module đảm bảo tính toàn vẹn dữ liệu thông qua kiểm tra ngày khóa sổ và cung cấp giao diện thuận tiện với chức năng auto-lookup tên tài sản.

---

*Ngày phân tích: 2026-03-29*