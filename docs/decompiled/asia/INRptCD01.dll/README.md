# Báo cáo Phân tích DLL: INRptCD01.dll

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
| Assembly Name | INRptCD01 |
| Assembly Title | Báo cáo công nợ 01 |
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
INRptCD01.dll/
├── INRptCD01.csproj           # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmINRptCD01.cs          # Main report form
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
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |
| CrystalDecisions.Windows.Forms | Crystal Reports viewer |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `CrystalDecisions.Windows.Forms`
- `System`, `System.Collections`, `System.Collections.Generic`
- `System.ComponentModel`, `System.Data`, `System.Diagnostics`
- `System.Drawing`, `System.Runtime.CompilerServices`, `System.Runtime.InteropServices`
- `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINRptCD01` | `frmReport` | Form báo cáo công nợ 01 |

---

## Chi tiết Form frmINRptCD01

### Các trường dữ liệu lọc chính

| Control | Tên trường | Mục đích |
|---------|------------|----------|
| cboKyBc | Kỳ báo cáo | Chọn kỳ báo cáo |
| txtNgay1 | Ngày bắt đầu | Từ ngày |
| txtNgay2 | Ngày kết thúc | Đến ngày |
| txtMa_kho | Ma_kho | Lọc theo kho |
| txtMa_vt | Ma_vt | Lọc theo vật tư |
| txtMa_tkvt | TK_VT | Lọc theo TK vật tư |
| txtMa_nhvt | Ma_NhVt | Lọc theo nhóm vật tư |
| txtMa_vitri | Ma_vitri | Lọc theo vị trí |
| cboDVT | DVT | Đơn vị tính |
| ChkPsdc | Psdc | Tính phát sinh điều chuyển |

### Phân loại vật tư (ẩn)

| Control | Tên trường | Mục đích |
|---------|------------|----------|
| txtMa_plvt1 | Ma_plvt1 | Phân loại VT 1 |
| txtMa_plvt2 | Ma_plvt2 | Phân loại VT 2 |
| txtMa_plvt3 | Ma_plvt3 | Phân loại VT 3 |
| txtOrder1 | Order1 | Thứ tự phân loại 1 |
| txtOrder2 | Order2 | Thứ tự phân loại 2 |
| txtOrder3 | Order3 | Thứ tự phân loại 3 |

### Đơn vị tính

| Giá trị | Mô tả |
|---------|-------|
| 0 | Đơn vị tính Kho |
| 1 | Đơn vị tính Mua |
| 2 | Đơn vị tính Bán |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Báo cáo công nợ 01" - Tiêu đề báo cáo
- "Kỳ báo cáo" - Chọn kỳ
- "Mã kho" - Lọc theo kho
- "Mã vật tư" - Lọc theo vật tư
- "Nhóm vật tư" - Lọc theo nhóm
- "Mã TKVT" - Lọc theo TK vật tư
- "Mã vị trí" - Lọc theo vị trí
- "Đơn vị tính" - Chọn ĐVT
- "PS điều chuyển" - Tính PS điều chuyển

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_vt` | Mã vật tư |
| `ma_kho` | Mã kho |
| `ma_tkvt` | Mã TK vật tư |
| `ma_nhvt` | Mã nhóm vật tư |
| `ma_vitri` | Mã vị trí |
| `ton_dau` | Tồn đầu |
| `ps_nhap` | Phát sinh nhập |
| `ps_xuat` | Phát sinh xuất |
| `ton_cuoi` | Tồn cuối |

---

## Mục đích sử dụng

**INRptCD01.dll là module báo cáo công nợ 01** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo công nợ vật tư
- Tồn đầu kỳ
- Phát sinh nhập/xuất trong kỳ
- Tồn cuối kỳ
- Giá trị tồn kho

#### 2. Lọc dữ liệu đa dạng
- Theo kỳ báo cáo
- Theo kho, vị trí
- Theo vật tư, nhóm vật tư
- Theo tài khoản vật tư
- Theo đơn vị tính

#### 3. Tính năng bổ sung
- Tính phát sinh điều chuyển
- Drilldown xuống chi tiết (F5)
- Xuất Excel
- In ấn qua Crystal Reports

### Đặc điểm kỹ thuật

- Sử dụng CrystalReportViewer
- Hỗ trợ drilldown (F5 để xem chi tiết)
- Validation thứ tự phân loại
- Tích hợp KyBaoCao
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ)

### Xử lý drilldown

| Phím | Chức năng |
|------|-----------|
| F5 | Xem chi tiết vật tư |

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc báo cáo công nợ vật tư - một báo cáo quan trọng trong quản lý kho.

---

*Ngày phân tích: 2026-03-29*
