# Báo cáo Phân tích DLL: INRptBKN04.dll

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
| Assembly Name | INRptBKN04 |
| Assembly Title | Bảng kê phiếu nhập |
| Assembly Company | Công ty phần mềm Asia |
| Assembly Product | Simba Accounting |
| Assembly Copyright | Copyright © 2014 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 14.1.0.0 |
| Assembly File Version | 14.1.0.0 |
| GUID | fe9ea2e5-2a21-45d5-bdd4-fa64c0d260c9 |
| ComVisible | false |

---

## Cấu trúc File

```
INRptBKN04.dll/
├── INRptBKN04.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmINRptBKN04.cs         # Main report form
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
| Microsoft.VisualBasic | Visual Basic runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINRptBKN04` | `frmReport` | Form báo cáo bảng kê phiếu nhập 04 |

---

## Các Controls trên Form

### Controls nhập liệu chính

| Control | Tên | Mục đích |
|---------|-----|----------|
| AsTextBox | txtMa_kho | Mã kho |
| AsTextBox | txtMa_vt | Mã vật tư |
| AsTextBox | txtMa_nhvt | Mã nhóm vật tư |
| AsTextBox | txtMa_kh | Mã khách hàng |
| AsTextBox | txtMa_d_nx | Mã dạng nhập xuất |
| AsTextBox | txtMa_bp | Mã bộ phận |
| AsTextBox | txtMa_hd | Mã hợp đồng |
| AsTextBox | txtMa_Phi | Mã phí |
| AsTextBox | txtMa_spct | Mã sản phẩm chi tiết |
| AsTextBox | txtMa_lo | Mã lô |
| AsTextBox | txtMa_vtri | Mã vị trí |
| AsTextBox | txtMa_TKVT | Mã TK vật tư |
| AsTextBox | txtTK_du | TK đối ứng |
| TextBox | txtSo_Ct1 | Số chứng từ từ |
| TextBox | txtSo_Ct2 | Số chứng từ đến |

### Controls ComboBox

| Control | Tên | Mục đích |
|---------|-----|----------|
| ComboBox | cboTheo_nhom | Nhóm theo |
| ComboBox | cboTheo_dvt | Theo đơn vị tính |
| ComboBox | cboLoai_pn | Loại phiếu nhập |
| ComboBox | cboLoai_gd | Loại giao dịch |

### Label hiển thị

| Label | Mục đích |
|-------|----------|
| lblTen_kho | Tên kho |
| lblTen_vt | Tên vật tư |
| lblTen_Nhvt | Tên nhóm vật tư |
| lblTen_KH | Tên khách hàng |
| lblTen_Ma_d_nx | Tên dạng NX |
| lblTen_bp | Tên bộ phận |
| lblTen_hd | Tên hợp đồng |
| lblTenPhi | Tên phí |
| lblTen_spct | Tên SPCT |
| lblTen_lo | Tên lô |
| lblTen_vtri | Tên vị trí |
| lblTen_TKVT | Tên TKVT |
| lblTen_TKdu | Tên TK đối ứng |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `ma_kho` | Mã kho |
| `ma_vt` | Mã vật tư |
| `ma_nhvt` | Mã nhóm vật tư |
| `ma_kh` | Mã khách hàng |
| `ma_d_nx` | Mã dạng nhập xuất |
| `ma_bp` | Mã bộ phận |
| `ma_hd` | Mã hợp đồng |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ma_lo` | Mã lô |
| `ma_vtri` | Mã vị trí |
| `tk_vt` | Tài khoản vật tư |
| `tk_du` | Tài khoản đối ứng |
| `so_ct` | Số chứng từ |
| `loai_pn` | Loại phiếu nhập |

---

## Mục đích sử dụng

**INRptBKN04.dll là module báo cáo "Bảng kê phiếu nhập 04"** trong hệ thống Simba Accounting của Asia Software.

### Chức năng chính

#### 1. Báo cáo bảng kê phiếu nhập
- Liệt kê chi tiết các phiếu nhập kho theo nhiều tiêu chí lọc
- Hỗ trợ nhóm dữ liệu theo nhiều khía cạnh (nhóm vật tư, khách hàng, kho...)
- Hiển thị theo đơn vị tính tùy chọn

#### 2. Các tiêu chí lọc báo cáo
- **Kho**: Lọc theo mã kho cụ thể
- **Vật tư**: Lọc theo mã vật tư hoặc nhóm vật tư
- **Khách hàng/NCC**: Lọc theo mã khách hàng/nhà cung cấp
- **Dạng NX**: Lọc theo dạng nhập xuất
- **Bộ phận**: Lọc theo mã bộ phận
- **Hợp đồng**: Lọc theo mã hợp đồng
- **Phí**: Lọc theo mã phí
- **SPCT**: Lọc theo sản phẩm chi tiết
- **Lô**: Lọc theo mã lô
- **Vị trí**: Lọc theo vị trí trong kho
- **TK vật tư**: Lọc theo tài khoản vật tư
- **TK đối ứng**: Lọc theo tài khoản đối ứng
- **Số chứng từ**: Lọc theo khoảng số chứng từ
- **Loại phiếu nhập**: Lọc theo loại phiếu nhập
- **Loại giao dịch**: Lọc theo loại giao dịch

#### 3. Tính năng nhóm và chi tiết
- Hỗ trợ nhóm báo cáo theo nhiều tiêu chí
- Chuyển đổi đơn vị tính khi hiển thị
- Tích hợp Crystal Reports để in ấn

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - base form báo cáo chuẩn của Asia ERP
- Sử dụng các custom controls `AsTextBox` với tính năng validation
- Tích hợp Crystal Report Viewer để hiển thị và in ấn báo cáo
- Hỗ trợ lookup dữ liệu tự động (hiển thị tên khi nhập mã)

---

## Kết luận

Đây là module Windows Forms của hệ thống Simba Accounting, phục vụ cho việc xem và in báo cáo bảng kê phiếu nhập kho - một báo cáo quan trọng trong quản lý kho và kế toán hàng tồn kho.

---

*Ngày phân tích: 2026-03-29*
