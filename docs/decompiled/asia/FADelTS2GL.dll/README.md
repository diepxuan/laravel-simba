# Báo cáo Phân tích DLL: FADelTS2GL.dll

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
| Assembly Name | FADelTS2GL |
| Assembly Title | Xóa bút toán phân bổ tài sản cố định |
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
FADelTS2GL.dll/
├── FADelTS2GL.csproj           # Project file
├── app.ico                     # Application icon
├── Properties/
│   └── AssemblyInfo.cs         # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmFADelTS2GL.cs        # Main form class
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
| `frmFADelTS2GL` | `frmCalc` | Form xóa bút toán phân bổ tài sản cố định sang General Ledger |

---

## UI Controls

| Control | Type | Mục đích |
|---------|------|----------|
| `cboKyBc` | AsComboBox | Chọn kỳ báo cáo (tháng) |
| `txtNam` | AsTextNumeric | Năm tài chính (readonly) |
| `lblThang` | Label | Nhãn "Tháng" |
| `lblNam` | Label | Nhãn "Năm" |

---

## Business Logic

### Tham số thực thi (Execute)

| Thứ tự | Tham số | Mô tả |
|--------|---------|-------|
| 1 | CompanyID | Mã công ty |
| 2 | par1 | Tham số menu |
| 3 | txtNam.Value | Năm tài chính |
| 4 | cboKyBc.Text | Tháng báo cáo |
| 5 | 0 | Tham số mặcịnh |

### Validation

- Kiểm tra ngày khóa sổ (`ngay_ks`): Không cho phép xóa dữ liệu trước ngày khóa sổ
- Sử dụng `KyBaoCao` object để lấy thông tin kỳ báo cáo

### Xử lý chính

1. Người dùng chọn tháng cần xóa bút toán
2. Hệ thống tự động lấy năm tài chính hiện tại
3. Kiểm tra quyền và ngày khóa sổ
4. Gọi stored procedure thông qua `MyController.Execute()`
5. Hiển thị thông báo kết quả (không đóng form sau khi thực hiện)

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Tháng" - Chọn kỳ báo cáo
- "Năm" - Năm tài chính

### Mã thông báo

| Mã | Ý nghĩa |
|----|---------|
| 50010 | Thông báo lỗi |
| 50015 | Thông báo thành công |
| 50136 | Lỗi ngày khóa sổ |

---

## Mục đích sử dụng

**FADelTS2GL.dll là module xóa bút toán phân bổ tài sản cố định sang General Ledger** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Xóa bút toán phân bổ TSCĐ
- Chọn kỳ báo cáo (tháng) cần xóa
- Hệ thống tự động lấy năm tài chính hiện tại
- Kiểm tra ngày khóa sổ trước khi thực hiện

#### 2. Kiểm soát an toàn
- Kiểm tra ngày khóa sổ để tránh xóa dữ liệu đã khóa
- Validation dữ liệu đầu vào
- Thông báo kết quả rõ ràng

### Đặc điểm kỹ thuật

- Kế thừa từ `frmCalc` - form tính toán chuẩn của Asia ERP
- Sử dụng `AsComboBox` và `AsTextNumeric` controls
- Tích hợp với Asia ERP Framework
- Lưu trữ tháng đã chọn vào PublicVariables ("thang1")
- Khác với FADelCC2GL: không tự động đóng form sau khi thực hiện

### Luồng dữ liệu

```
User chọn Tháng → Validate ngày khóa sổ → Execute SP → Thông báo kết quả
```

---

## Kết luận

Đây là module phục vụ cho việc xóa bút toán phân bổ tài sản cố định (TSCĐ) đã post sang General Ledger. Module đảm bảo tính toàn vẹn dữ liệu thông qua kiểm tra ngày khóa sổ và cung cấp giao diện đơn giản để người dùng thực hiện thao tác.

---

*Ngày phân tích: 2026-03-29*
