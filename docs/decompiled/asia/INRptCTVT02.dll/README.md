# Báo cáo Phân tích DLL: INRptCTVT02.dll

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
| Assembly Name | INRptCTVT02 |
| Assembly Title | Thẻ kho-sổ chi tiết vật tư (in tất cả) |
| Assembly Company | Công ty phần mềm Asia |
| Assembly Product | Simba Accounting |
| Assembly Copyright | Copyright © 2014 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 14.1.0.0 |
| Assembly File Version | 14.1.0.0 |
| GUID | 0999bb13-6eca-481f-948c-5331516db194 |
| ComVisible | false |

---

## Cấu trúc File

```
INRptCTVT02.dll/
├── INRptCTVT02.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaERP.UserInterface/
    └── frmINRptCTVT02.cs         # Main report form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Drawing | Graphics support |
| System.Windows.Forms | Windows Forms controls |
| System.Xml | XML processing |
| AsiaErp.Framework | Asia ERP Framework |
| CrystalDecisions.Windows.Forms | Crystal Reports viewer |
| Microsoft.VisualBasic | Visual Basic runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `CrystalDecisions.Windows.Forms`
- `System`, `System.ComponentModel`, `System.Data`, `System.Drawing`, `System.Windows.Forms`, `System.Xml`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINRptCTVT02` | `frmReport` | Form báo cáo chi tiết vật tư 02 (in tất cả) |

---

## Các Controls trên Form

### Controls nhập liệu chính

| Control | Tên | Mục đích |
|---------|-----|----------|
| AsTextBox | txtMa_vt | Mã vật tư |
| AsTextBox | txtMa_nhvt | Mã nhóm vật tư |
| AsTextBox | txtMa_tkvt | Mã TK vật tư |
| AsTextBox | txtMa_kho | Mã kho |
| AsTextBox | txtMa_vitri | Mã vị trí |

### Controls ComboBox

| Control | Tên | Mục đích |
|---------|-----|----------|
| ComboBox | cboDVT | Đơn vị tính |

### Controls CheckBox

| Control | Tên | Mục đích |
|---------|-----|----------|
| AsCheckBox | chkPS_dc | Hiển thị phát sinh điều chỉnh |

### Controls Crystal Report

| Control | Tên | Mục đích |
|---------|-----|----------|
| CrystalReportViewer | crvReportViewer | Xem và in báo cáo |

### Label hiển thị

| Label | Mục đích |
|-------|----------|
| lblMa_vt | Mã vật tư |
| lblTen_vt | Tên vật tư |
| lblNhom_vt | Nhóm vật tư |
| lblTen_nhvt | Tên nhóm VT |
| lblMa_tkvt | Mã TKVT |
| lblTen_tkvt | Tên TKVT |
| lblMa_kho | Mã kho |
| lblTen_kho | Tên kho |
| lblMa_vitri | Mã vị trí |
| lblTen_vitri | Tên vị trí |
| lblDVT | Đơn vị tính |
| lblPsdc | Phát sinh điều chỉnh |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `ma_vt` | Mã vật tư |
| `ma_nhvt` | Mã nhóm vật tư |
| `ma_tkvt` | Mã tài khoản vật tư |
| `ma_kho` | Mã kho |
| `ma_vitri` | Mã vị trí |
| `dvt` | Đơn vị tính |
| `ps_dc` | Phát sinh điều chỉnh |
| `the_kho` | Thẻ kho |
| `so_ctvt` | Sổ chi tiết vật tư |

---

## Mục đích sử dụng

**INRptCTVT02.dll là module báo cáo "Thẻ kho - Sổ chi tiết vật tư 02 (in tất cả)"** trong hệ thống Simba Accounting của Asia Software.

### Chức năng chính

#### 1. Báo cáo thẻ kho/sổ chi tiết vật tư
- In thẻ kho cho tất cả các vật tư theo tiêu chí lọc
- Hiển thị chi tiết nhập xuất tồn của từng vật tư
- Hỗ trợ xem phát sinh điều chỉnh (nếu có)

#### 2. Các tiêu chí lọc báo cáo
- **Vật tư**: Lọc theo mã vật tư hoặc nhóm vật tư
- **TK vật tư**: Lọc theo tài khoản vật tư
- **Kho**: Lọc theo mã kho cụ thể
- **Vị trí**: Lọc theo vị trí trong kho
- **Đơn vị tính**: Chọn đơn vị tính hiển thị
- **Phát sinh điều chỉnh**: Tùy chọn hiển thị các phát sinh điều chỉnh

#### 3. Tính năng "In tất cả"
- Cho phép in liên tục thẻ kho của nhiều vật tư
- Không cần chọn từng vật tư riêng lẻ
- Phù hợp cho việc in báo cáo định kỳ

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - base form báo cáo chuẩn của Asia ERP
- Sử dụng các custom controls `AsTextBox`, `AsCheckBox` với tính năng validation
- Tích hợp Crystal Report Viewer để hiển thị và in ấn báo cáo
- Hỗ trợ xử lý XML cho dữ liệu báo cáo

---

## Kết luận

Đây là module Windows Forms của hệ thống Simba Accounting, phục vụ cho việc xem và in thẻ kho/sổ chi tiết vật tư - một báo cáo quan trọng trong quản lý kho và theo dõi chi tiết nhập xuất tồn của từng vật tư.

---

*Ngày phân tích: 2026-03-29*
