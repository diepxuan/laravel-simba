# Báo cáo Phân tích DLL: INRptBK01.dll

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
| Assembly Name | INRptBK01 |
| Assembly Title | Bảng kê chứng từ |
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
INRptBK01.dll/
├── INRptBK01.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaERP.UserInterface/
│   └── frmINRptBK01.cs          # Main report form
├── AsiaERP.UserInterface.My/
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MySettingsProperty.cs
│   └── InternalXmlHelper.cs
└── AsiaERP.UserInterface.My.Resources/
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

- `AsiaERP.UserInterface`
- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.ComponentModel`
- `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`
- `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINRptBK01` | `frmReport` | Form bảng kê chứng từ |

---

## Chi tiết Form frmINRptBK01

### Các trường dữ liệu chính

| Control | Tên trường | Mục đích |
|---------|------------|----------|
| cboMau_bc | Mau_bc | Mẫu báo cáo |
| txtTieu_De | Tieu_De | Tiêu đề báo cáo |
| txtMonth | Tháng | Tháng báo cáo |
| txtYear | Năm | Năm báo cáo |
| txtMa_vt | Ma_vt | Mã vật tư (lọc) |
| txtMa_kho | Ma_kho | Mã kho (lọc) |
| txtMa_Nt | Ma_nt | Mã ngoại tệ |
| optVND | optVND | Hiển thị VND |
| optNt | optNt | Hiển thị ngoại tệ |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bảng kê chứng từ" - Tiêu đề báo cáo
- "Tháng" - Tháng báo cáo
- "Năm" - Năm báo cáo
- "Mã vật tư" - Lọc theo vật tư
- "Mã kho" - Lọc theo kho
- "Mẫu báo cáo" - Chọn mẫu in

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_vt` | Mã vật tư |
| `ma_kho` | Mã kho |
| `thang` | Tháng báo cáo |
| `nam` | Năm báo cáo |
| `so_ct` | Số chứng từ |
| `ngay_ct` | Ngày chứng từ |

---

## Mục đích sử dụng

**INRptBK01.dll là module bảng kê chứng từ** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Bảng kê chứng từ
- Liệt kê các chứng từ nhập/xuất kho
- Theo tháng/năm
- Theo vật tư, kho

#### 2. Lọc dữ liệu
- Theo tháng/năm
- Theo vật tư
- Theo kho
- Theo loại tiền tệ

#### 3. Tính năng bổ sung
- Chọn mẫu báo cáo
- Xuất Excel
- In ấn
- Hỗ trợ đa tiền tệ

### Đặc điểm kỹ thuật

- Validation tháng (1-12)
- Validation năm (>0)
- Mặc định tháng/năm hiện tại
- AutoLookup cho các trường mã
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ)

### Tham số báo cáo

| Tham số | Mô tả |
|---------|-------|
| CompanyID | Mã công ty |
| Year | Năm báo cáo |
| Month | Tháng báo cáo |
| Ma_vt | Mã vật tư (lọc) |
| Ma_kho | Mã kho (lọc) |

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc in bảng kê chứng từ nhập xuất kho theo tháng - báo cáo tổng hợp chứng từ.

---

*Ngày phân tích: 2026-03-29*
