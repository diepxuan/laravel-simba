# Báo cáo Phân tích DLL: INRptTHN02.dll

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
| Assembly Name | INRptTHN02 |
| Assembly Title | Tổng hợp hàng nhập kho |
| Assembly Company | Công ty phần mềm Asia |
| Assembly Product | Simba Accounting |
| Assembly Copyright | Copyright © 2014 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 14.1.0.0 |
| Assembly File Version | 14.1.0.0 |
| GUID | 60eda3ab-6993-4226-b766-f0f60d81e945 |
| ComVisible | false |

---

## Cấu trúc File

```
INRptTHN02.dll/
├── INRptTHN02.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaERP.UserInterface/
    └── frmINRptTHN02.cs         # Main report form
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
| `frmINRptTHN02` | `frmReport` | Form báo cáo tổng hợp nhập 02 |

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
| AsTextBox | txtMa_nh_ncc | Mã nhóm NCC |
| AsTextBox | txtPl_ncc1 | Phân loại NCC 1 |
| AsTextBox | txtPl_ncc2 | Phân loại NCC 2 |
| AsTextBox | txtPl_ncc3 | Phân loại NCC 3 |
| AsTextBox | txtMa_spct | Mã sản phẩm chi tiết |
| AsTextBox | txtMa_Phi | Mã phí |
| AsTextBox | txtMa_lo | Mã lô |
| TextBox | txtSo_Ct1 | Số chứng từ từ |
| TextBox | txtSo_Ct2 | Số chứng từ đến |

### Controls ComboBox

| Control | Tên | Mục đích |
|---------|-----|----------|
| ComboBox | cboNhom_theo | Nhóm theo |
| ComboBox | cboChitiet | Chi tiết |
| ComboBox | cboLoai_pn | Loại phiếu nhập |
| ComboBox | cboLoai_gd | Loại giao dịch |
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
| lblTen_nh_ncc | Tên nhóm NCC |
| lblPl_ncc1 | Phân loại NCC 1 |
| lblTen_pl_ncc1 | Tên PL NCC 1 |
| lblPl_ncc2 | Phân loại NCC 2 |
| lblTen_pl_ncc2 | Tên PL NCC 2 |
| lblPl_ncc3 | Phân loại NCC 3 |
| lblTen_pl_ncc3 | Tên PL NCC 3 |
| lblMa_spct | Mã SPCT |
| lblTen_spct | Tên SPCT |
| lblTenPhi | Tên phí |
| lblMaLo | Mã lô |
| lblTen_lo | Tên lô |
| lblNhom_theo | Nhóm theo |
| lblChitiet | Chi tiết |
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
| `pl_ncc` | Phân loại nhà cung cấp |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ma_phi` | Mã phí |
| `ma_lo` | Mã lô |
| `loai_pn` | Loại phiếu nhập |
| `loai_gd` | Loại giao dịch |
| `dvt` | Đơn vị tính |
| `ps_dc` | Phát sinh điều chỉnh |

---

## Mục đích sử dụng

**INRptTHN02.dll là module báo cáo "Tổng hợp hàng nhập kho 02"** trong hệ thống Simba Accounting của Asia Software.

### Chức năng chính

#### 1. Báo cáo tổng hợp nhập kho nâng cao
- Tổng hợp các phiếu nhập kho theo nhiều tiêu chí phức tạp
- Hỗ trợ nhóm và chi tiết hóa dữ liệu
- Phân loại theo nhiều cấp độ (nhóm NCC, phân loại NCC)

#### 2. Các tiêu chí lọc báo cáo
- **Vật tư**: Lọc theo mã vật tư hoặc nhóm vật tư
- **Kho**: Lọc theo mã kho cụ thể
- **Vị trí**: Lọc theo vị trí trong kho
- **TK vật tư**: Lọc theo tài khoản vật tư
- **TK đối ứng**: Lọc theo tài khoản đối ứng
- **Dạng NX**: Lọc theo dạng nhập xuất
- **Bộ phận**: Lọc theo mã bộ phận
- **Hợp đồng**: Lọc theo mã hợp đồng
- **Nhà cung cấp**: Lọc theo mã NCC, nhóm NCC, phân loại NCC (3 cấp)
- **SPCT**: Lọc theo sản phẩm chi tiết
- **Phí**: Lọc theo mã phí
- **Lô**: Lọc theo mã lô
- **Số chứng từ**: Lọc theo khoảng số chứng từ
- **Loại phiếu nhập**: Lọc theo loại phiếu nhập
- **Loại giao dịch**: Lọc theo loại giao dịch
- **Đơn vị tính**: Chọn đơn vị tính hiển thị

#### 3. Tính năng nhóm và chi tiết
- **Nhóm theo**: Chọn tiêu chí nhóm dữ liệu
- **Chi tiết**: Tùy chọn mức độ chi tiết của báo cáo
- Hiển thị phát sinh điều chỉnh (tùy chọn)

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - base form báo cáo chuẩn của Asia ERP
- Sử dụng các custom controls `AsTextBox`, `AsCheckBox` với tính năng validation
- Tích hợp Crystal Report Viewer để hiển thị và in ấn báo cáo
- Hỗ trợ lookup dữ liệu tự động (hiển thị tên khi nhập mã)
- Xử lý sự kiện `SelectedValueChanged` cho các ComboBox nhóm và chi tiết

---

## Kết luận

Đây là module Windows Forms của hệ thống Simba Accounting, phục vụ cho việc xem và in báo cáo tổng hợp hàng nhập kho nâng cao - một báo cáo quan trọng trong quản lý kho với nhiều tùy chọn nhóm và phân loại dữ liệu.

---

*Ngày phân tích: 2026-03-29*
