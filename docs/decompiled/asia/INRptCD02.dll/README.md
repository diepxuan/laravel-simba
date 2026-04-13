# Báo cáo Phân tích DLL: INRptCD02.dll

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
| Assembly Name | INRptCD02 |
| Assembly Title | Báo cáo tồn kho |
| Assembly Company | Công ty phần mềm Asia |
| Assembly Product | Simba Accounting |
| Assembly Copyright | Copyright © 2014 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 14.1.0.0 |
| Assembly File Version | 14.1.0.0 |
| GUID | 6cf0aa81-5a68-42ff-8764-7956a0ff3a07 |
| ComVisible | false |

---

## Cấu trúc File

```
INRptCD02.dll/
├── INRptCD02.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaERP.UserInterface/
    └── frmINRptCD02.cs         # Main report form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Drawing | Graphics support |
| System.Windows.Forms | Windows Forms controls |
| AsiaErp.Framework | Asia ERP Framework |
| CrystalDecisions.Windows.Forms | Crystal Reports viewer |
| Microsoft.VisualBasic | Visual Basic runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `CrystalDecisions.Windows.Forms`
- `System`, `System.ComponentModel`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINRptCD02` | `frmReport` | Form báo cáo công nợ/tồn kho 02 |

---

## Các Controls trên Form

### Controls nhập liệu chính

| Control | Tên | Mục đích |
|---------|-----|----------|
| AsTextBox | txtMa_vt | Mã vật tư |
| AsTextBox | txtNh_vt | Nhóm vật tư |
| AsTextBox | txtMa_kho | Mã kho |
| AsTextBox | txtMa_vitri | Mã vị trí |
| AsTextBox | txtMa_tkvt | Mã TK vật tư |
| AsTextBox | txtMa_lo | Mã lô |
| AsMaskedTextBox | txtNgay | Ngày báo cáo |

### Controls ComboBox

| Control | Tên | Mục đích |
|---------|-----|----------|
| ComboBox | cboDVT | Đơn vị tính |

### Controls RadioButton

| Control | Tên | Mục đích |
|---------|-----|----------|
| RadioButton | rbDK | Tồn đầu kỳ |
| RadioButton | rbCk | Tồn cuối kỳ |

### Controls CheckBox

| Control | Tên | Mục đích |
|---------|-----|----------|
| CheckBox | ChkQuaToiDa | Vượt tồn tối đa |
| CheckBox | ChkQuaToiThieu | Vượt tồn tối thiểu |

### Controls Crystal Report

| Control | Tên | Mục đích |
|---------|-----|----------|
| CrystalReportViewer | crvReportViewer | Xem và in báo cáo |

### Panel

| Control | Tên | Mục đích |
|---------|-----|----------|
| Panel | Panel1 | Chứa các tùy chọn radio button |

### Label hiển thị

| Label | Mục đích |
|-------|----------|
| lblMa_vt | Mã vật tư |
| lblTen_vt | Tên vật tư |
| lblNhom_vt | Nhóm vật tư |
| lblTen_nhvt | Tên nhóm VT |
| lblMa_kho | Mã kho |
| lblTen_kho | Tên kho |
| lblMa_vitri | Mã vị trí |
| lblTen_vitri | Tên vị trí |
| lblMa_dvt | Đơn vị tính |
| lblMa_tkvt | Mã TKVT |
| lblTen_tkvt | Tên TKVT |
| lblDate | Ngày |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `ma_vt` | Mã vật tư |
| `nh_vt` | Nhóm vật tư |
| `ma_kho` | Mã kho |
| `ma_vitri` | Mã vị trí |
| `ma_tkvt` | Mã tài khoản vật tư |
| `ma_lo` | Mã lô |
| `dvt` | Đơn vị tính |
| `dk` | Đầu kỳ |
| `ck` | Cuối kỳ |
| `ton_toi_da` | Tồn tối đa |
| `ton_toi_thieu` | Tồn tối thiểu |

---

## Mục đích sử dụng

**INRptCD02.dll là module báo cáo "Công nợ/Tồn kho 02"** trong hệ thống Simba Accounting của Asia Software.

### Chức năng chính

#### 1. Báo cáo tồn kho
- Hiển thị thông tin tồn kho của vật tư tại thời điểm báo cáo
- Hỗ trợ xem tồn đầu kỳ hoặc tồn cuối kỳ
- Theo dõi tình trạng tồn kho (vượt tồn tối đa/tối thiểu)

#### 2. Các tiêu chí lọc báo cáo
- **Vật tư**: Lọc theo mã vật tư hoặc nhóm vật tư
- **Kho**: Lọc theo mã kho cụ thể
- **Vị trí**: Lọc theo vị trí trong kho
- **TK vật tư**: Lọc theo tài khoản vật tư
- **Lô**: Lọc theo mã lô
- **Ngày**: Ngày báo cáo
- **Đơn vị tính**: Chọn đơn vị tính hiển thị

#### 3. Tính năng cảnh báo tồn kho
- **Vượt tồn tối đa**: Hiển thị các vật tư có tồn kho vượt quá mức tối đa
- **Vượt tồn tối thiểu**: Hiển thị các vật tư có tồn kho dưới mức tối thiểu

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - base form báo cáo chuẩn của Asia ERP
- Sử dụng các custom controls `AsTextBox`, `AsMaskedTextBox` với tính năng validation
- Tích hợp Crystal Report Viewer để hiển thị và in ấn báo cáo
- Sử dụng `AsMaskedTextBox` cho nhập liệu ngày tháng theo định dạng chuẩn

---

## Kết luận

Đây là module Windows Forms của hệ thống Simba Accounting, phục vụ cho việc xem và in báo cáo tồn kho/công nợ - một báo cáo quan trọng trong quản lý kho và kiểm soát hàng tồn kho.

---

*Ngày phân tích: 2026-03-29*
