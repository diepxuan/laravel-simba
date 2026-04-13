# Báo cáo Phân tích DLL: FACalKHTS.dll

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
| Assembly Name | FACalKHTS |
| Assembly Title | Tính khấu hao tài sản cố định |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
FACalKHTS.dll/
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmFACalKHTS.cs              # Form tính khấu hao tài sản
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Windows.Forms | Windows Forms UI |
| System.Drawing | Graphics support |
| System.Resources | Resource management |
| AsiaErp.Framework | ERP Framework Core |
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Drawing`, `System.Resources`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmFACalKHTS` | `frmCalc` | Form tính khấu hao tài sản cố định |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Tính khấu hao tài sản cố định" - Tiêu đề form
- "Tháng" - Chọn kỳ báo cáo
- "Mã tài sản" - Lọc theo tài sản
- "&Nhận" - Button thực hiện tính

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `thang1` | Tháng tính khấu hao |
| `ma_ts` | Mã tài sản (tùy chọn) |
| `ma_cty` | Mã công ty |
| `nam` | Năm tài chính |

---

## Mục đích sử dụng

**FACalKHTS.dll là module Tính khấu hao tài sản cố định** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Tính khấu hao tài sản
- Chọn tháng cần tính khấu hao (qua cboKyBc)
- Chọn mã tài sản cụ thể (tùy chọn, để trống = tất cả)
- Thực hiện tính khấu hao cho các tài sản đủ điều kiện

#### 2. Tham số tính toán
- `CompanyInformations.CompanyID` - Mã công ty
- `SystemInformations.FinancialYear` - Năm tài chính
- `cboKyBc.Text` - Tháng tính khấu hao
- `txtMa_Ts.Text` - Mã tài sản (tùy chọn)

#### 3. Validation
- Kiểm tra ngày kết thúc kỳ > ngày khóa sổ (`ngay_ks`)
- Không cho tính khấu hao cho kỳ đã khóa sổ

#### 4. Lưu trữ trạng thái
- Lưu tháng đã chọn vào biến public `thang1` để sử dụng lại

### Đặc điểm kỹ thuật

- Kế thừa `frmCalc` - form tính toán chuẩn
- Sử dụng `AsComboBox` cho chọn kỳ báo cáo
- Sử dụng `AsTextBox` với AutoLookup cho chọn tài sản
- Thực thi qua `MyController.Execute()` với tham số mảng
- Hiển thị thông báo thành công/thất bại

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc tính khấu hao tài sản cố định theo tháng - chức năng định kỳ trong quản lý tài sản.

---

*Ngày phân tích: 2026-03-29*
