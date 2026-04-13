# Báo cáo Phân tích DLL: INRptTHN01.dll

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
| Assembly Name | INRptTHN01 |
| Assembly Title | INRptTHN01 |
| Assembly Company | ASIA |
| Assembly Product | INRptTHN01 |
| Assembly Copyright | Copyright © ASIA 2010 |
| Assembly Trademark | (trống) |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 939abd30-624e-44d7-a4f3-3dc180f6712b |
| ComVisible | false |

---

## Cấu trúc File

```
INRptTHN01.dll/
├── INRptTHN01.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaERP.UserInterface/
    └── frmINRptTHN01.cs         # Main report form
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
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINRptTHN01` | `frmReport` | Form báo cáo tổng hợp nhập 01 |

---

## Các Controls trên Form

### Controls nhập liệu chính

| Control | Tên | Mục đích |
|---------|-----|----------|
| AsTextBox | txtMa_vt | Mã vật tư |
| AsTextBox | txtMa_nh_vt | Mã nhóm vật tư |
| AsTextBox | txtMa_kho | Mã kho |
| AsTextBox | txtMa_vitri | Mã vị trí |
| AsTextBox | txtTK_vt | TK vật tư |
| AsTextBox | txtTK_du | TK đối ứng |
| AsTextBox | txtMa_nx | Mã dạng nhập xuất |
| AsTextBox | txtMa_bp | Mã bộ phận |
| AsTextBox | txtMa_hd | Mã hợp đồng |
| AsTextBox | txtMa_ncc | Mã nhà cung cấp |
| TextBox | txtSo_CT1 | Số chứng từ từ |
| TextBox | txtSo_CT2 | Số chứng từ đến |

### Controls ComboBox

| Control | Tên | Mục đích |
|---------|-----|----------|
| ComboBox | cboLoai_pn | Loại phiếu nhập |
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
| lblMa_nh_vt | Mã nhóm VT |
| lblTen_nh_vt | Tên nhóm VT |
| lblMa_kho | Mã kho |
| lblTen_kho | Tên kho |
| lblMa_vitri | Mã vị trí |
| lblTen_vitri | Tên vị trí |
| lblTK_vt | TK vật tư |
| lblTen_tk_vt | Tên TK vật tư |
| lblTK_du | TK đối ứng |
| lblTen_tk_du | Tên TK đối ứng |
| lblMa_nx | Mã dạng NX |
| lblTen_nx | Tên dạng NX |
| lblMa_bp | Mã bộ phận |
| lblTen_bp | Tên bộ phận |
| lblMa_hd | Mã hợp đồng |
| lblTen_hd | Tên hợp đồng |
| lblMa_ncc | Mã NCC |
| lblTen_ncc | Tên NCC |
| lblNh_ncc | Nhóm NCC |
| lblSo_ct1 | Số CT từ |
| lblSo_ct2 | Số CT đến |
| lblLoai_pn | Loại phiếu nhập |
| lblDVT | Đơn vị tính |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `thn` | Tổng hợp nhập |
| `ma_vt` | Mã vật tư |
| `ma_nh_vt` | Mã nhóm vật tư |
| `ma_kho` | Mã kho |
| `ma_vitri` | Mã vị trí |
| `tk_vt` | Tài khoản vật tư |
| `tk_du` | Tài khoản đối ứng |
| `ma_nx` | Mã dạng nhập xuất |
| `ma_bp` | Mã bộ phận |
| `ma_hd` | Mã hợp đồng |
| `ma_ncc` | Mã nhà cung cấp |
| `nh_ncc` | Nhóm nhà cung cấp |
| `loai_pn` | Loại phiếu nhập |
| `dvt` | Đơn vị tính |
| `ps_dc` | Phát sinh điều chỉnh |

---

## Mục đích sử dụng

**INRptTHN01.dll là module báo cáo "Tổng hợp nhập 01"** trong hệ thống Asia ERP.

### Chức năng chính

#### 1. Báo cáo tổng hợp nhập kho
- Tổng hợp các phiếu nhập kho theo nhiều tiêu chí
- Hiển thị tổng số lượng, giá trị nhập theo từng nhóm
- Hỗ trợ xem phát sinh điều chỉnh

#### 2. Các tiêu chí lọc báo cáo
- **Vật tư**: Lọc theo mã vật tư hoặc nhóm vật tư
- **Kho**: Lọc theo mã kho cụ thể
- **Vị trí**: Lọc theo vị trí trong kho
- **TK vật tư**: Lọc theo tài khoản vật tư
- **TK đối ứng**: Lọc theo tài khoản đối ứng
- **Dạng NX**: Lọc theo dạng nhập xuất
- **Bộ phận**: Lọc theo mã bộ phận
- **Hợp đồng**: Lọc theo mã hợp đồng
- **Nhà cung cấp**: Lọc theo mã nhà cung cấp
- **Số chứng từ**: Lọc theo khoảng số chứng từ
- **Loại phiếu nhập**: Lọc theo loại phiếu nhập
- **Đơn vị tính**: Chọn đơn vị tính hiển thị

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - base form báo cáo chuẩn của Asia ERP
- Sử dụng các custom controls `AsTextBox`, `AsCheckBox` với tính năng validation
- Tích hợp Crystal Report Viewer để hiển thị và in ấn báo cáo
- Hỗ trợ lookup dữ liệu tự động (hiển thị tên khi nhập mã)

---

## Kết luận

Đây là module Windows Forms của hệ thống Asia ERP, phục vụ cho việc xem và in báo cáo tổng hợp nhập kho - một báo cáo quan trọng trong quản lý kho và theo dõi hàng nhập.

---

*Ngày phân tích: 2026-03-29*
