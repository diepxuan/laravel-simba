# Báo cáo Phân tích DLL: INRptCTVT01.dll

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
| Assembly Name | INRptCTVT01 |
| Assembly Title | Báo cáo chi tiết vật tư 01 |
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
INRptCTVT01.dll/
├── INRptCTVT01.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaERP.UserInterface/
│   └── frmINRptCTVT01.cs        # Main report form
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
| CrystalDecisions.Windows.Forms | Crystal Reports viewer |

### Namespaces sử dụng

- `AsiaERP.UserInterface`
- `AsiaErp.Framework`
- `CrystalDecisions.Windows.Forms`
- `System`, `System.Collections`, `System.Collections.Generic`
- `System.ComponentModel`, `System.Data`, `System.Diagnostics`
- `System.Drawing`, `System.Runtime.CompilerServices`
- `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINRptCTVT01` | `frmReport` | Form báo cáo chi tiết vật tư 01 |

---

## Chi tiết Form frmINRptCTVT01

### Các trường dữ liệu chính

| Control | Tên trường | Mục đích |
|---------|------------|----------|
| cboKyBc | Kỳ báo cáo | Chọn kỳ báo cáo |
| txtNgay1 | Ngày bắt đầu | Từ ngày |
| txtNgay2 | Ngày kết thúc | Đến ngày |
| txtMa_vt | Ma_vt | Mã vật tư (bắt buộc) |
| txtMa_kho | Ma_kho | Mã kho (bắt buộc) |
| txtMa_vitri | Ma_vitri | Mã vị trí (tùy chọn) |
| txtTK_VT | TK_VT | Tài khoản vật tư |
| cboDVT | DVT | Đơn vị tính |
| txtMa_Nt | Ma_nt | Mã ngoại tệ |
| cboMau_bc | Mau_bc | Mẫu báo cáo |

### Đơn vị tính

| Giá trị | Mô tả |
|---------|-------|
| 0 | Đơn vị kho |
| 1 | Đơn vị mua |
| 2 | Đơn vị bán |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Báo cáo chi tiết vật tư" - Tiêu đề báo cáo
- "Kỳ báo cáo" - Chọn kỳ
- "Mã vật tư" - Vật tư cần xem chi tiết (bắt buộc)
- "Mã kho" - Kho cần xem (bắt buộc)
- "Mã vị trí" - Vị trí trong kho
- "TK VT" - Tài khoản vật tư
- "Đơn vị tính" - Chọn ĐVT hiển thị

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_vt` | Mã vật tư |
| `ma_kho` | Mã kho |
| `ma_vitri` | Mã vị trí |
| `tk_vt` | Tài khoản vật tư |
| `dvt` | Đơn vị tính |
| `so_ct` | Số chứng từ |
| `ngay_ct` | Ngày chứng từ |
| `ps_nhap` | Phát sinh nhập |
| `ps_xuat` | Phát sinh xuất |
| `ton` | Tồn kho |

---

## Mục đích sử dụng

**INRptCTVT01.dll là module báo cáo chi tiết vật tư** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo chi tiết vật tư
- Chi tiết nhập/xuất từng chứng từ
- Theo vật tư và kho cụ thể
- Tồn đầu, phát sinh, tồn cuối

#### 2. Lọc dữ liệu
- Theo kỳ báo cáo
- Theo vật tư (bắt buộc)
- Theo kho (bắt buộc)
- Theo vị trí (tùy chọn)
- Theo tài khoản vật tư
- Theo đơn vị tính

#### 3. Tính năng bổ sung
- Tự động lấy tên vật tư và ĐVT
- Xuất Excel
- In ấn qua Crystal Reports
- Hỗ trợ đa tiền tệ

### Đặc điểm kỹ thuật

- Sử dụng CrystalReportViewer
- Validation bắt buộc: Mã vật tư, Mã kho
- AutoLookup với ValidReturnFieldList
- AfterCodeValidating cho txtMa_vt
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ)

### Xử lý sự kiện

| Sự kiện | Mô tả |
|---------|-------|
| `txtMa_vt_AfterCodeValidating` | Lấy Ten_VT và DVT từ vật tư |

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc báo cáo chi tiết nhập xuất tồn của từng vật tư - báo cáo chi tiết theo dõi biến động từng mặt hàng.

---

*Ngày phân tích: 2026-03-29*
