# Báo cáo Phân tích DLL: INRptBKX04.dll

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
| Assembly Name | INRptBKX04 |
| Assembly Title | Bảng kê phiếu xuất |
| Assembly Company | Công ty phần mềm Asia |
| Assembly Product | Simba Accounting |
| Assembly Copyright | Copyright © 2014 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 14.1.0.0 |
| Assembly File Version | 14.1.0.0 |
| GUID | 41e7ce2c-5025-41e8-8787-c97ea9ea8a82 |
| ComVisible | false |

---

## Cấu trúc File

```
INRptBKX04.dll/
├── INRptBKX04.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmINRptBKX04.cs         # Main report form
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
| `frmINRptBKX04` | `frmReport` | Form báo cáo bảng kê phiếu xuất 04 |

---

## Các Controls trên Form

### Controls nhập liệu chính

| Control | Tên | Mục đích |
|---------|-----|----------|
| AsTextBox | txtMa_kho | Mã kho |
| AsTextBox | txtMa_vt | Mã vật tư |
| AsTextBox | txtMa_nhvt | Mã nhóm vật tư |
| AsTextBox | txtMa_kh | Mã khách hàng |
| AsTextBox | txtMa_BP | Mã bộ phận |
| AsTextBox | txtMa_hd | Mã hợp đồng |
| AsTextBox | txtMa_Phi | Mã phí |
| AsTextBox | txtMa_SPCT | Mã sản phẩm chi tiết |
| AsTextBox | txtMa_lo | Mã lô |
| AsTextBox | txtTK | Tài khoản |
| AsTextBox | txtTK_DU | TK đối ứng |
| TextBox | txtSo_ct1 | Số chứng từ từ |
| TextBox | txtSo_ct2 | Số chứng từ đến |

### Controls ComboBox

| Control | Tên | Mục đích |
|---------|-----|----------|
| AsComboBox | cboNhom_theo | Nhóm theo |
| AsComboBox | cboTheo_DVT | Theo đơn vị tính |
| AsComboBox | cboLoai_phieu | Loại phiếu |
| ComboBox | cboLoai_gd | Loại giao dịch |

### Label hiển thị

| Label | Mục đích |
|-------|----------|
| lblNhom_theo | Nhóm theo |
| lblTheo_DVT | Theo DVT |
| lblLoai_phieu | Loại phiếu |
| lblTK | Tài khoản |
| lblTen_TK | Tên TK |
| lblTK_DU | TK đối ứng |
| lblTen_TKDU | Tên TK đối ứng |
| lblMa_BP | Mã bộ phận |
| lblTen_BP | Tên bộ phận |
| lblMa_SPCT | Mã SPCT |
| lblTen_SPCT | Tên SPCT |
| lblMa_hd | Mã hợp đồng |
| lblTen_hd | Tên hợp đồng |
| lblMa_kho | Mã kho |
| lblTen_kho | Tên kho |
| lblMa_nhvt | Mã nhóm VT |
| lblTen_nhvt | Tên nhóm VT |
| lblMa_vt | Mã vật tư |
| lblTen_vt | Tên vật tư |
| lblSo_Ct1 | Số CT từ |
| lblSo_ct2 | Số CT đến |
| lblMa_kh | Mã khách hàng |
| lblTen_kh | Tên khách hàng |
| lblMaLo | Mã lô |
| lblTen_lo | Tên lô |
| lblTenPhi | Tên phí |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `bkx` | Bảng kê xuất |
| `ma_kho` | Mã kho |
| `ma_vt` | Mã vật tư |
| `ma_nhvt` | Mã nhóm vật tư |
| `ma_kh` | Mã khách hàng |
| `ma_bp` | Mã bộ phận |
| `ma_hd` | Mã hợp đồng |
| `ma_phi` | Mã phí |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ma_lo` | Mã lô |
| `tk` | Tài khoản |
| `tk_du` | Tài khoản đối ứng |
| `so_ct` | Số chứng từ |
| `loai_phieu` | Loại phiếu |
| `loai_gd` | Loại giao dịch |
| `dvt` | Đơn vị tính |

---

## Mục đích sử dụng

**INRptBKX04.dll là module báo cáo "Bảng kê phiếu xuất 04"** trong hệ thống Simba Accounting của Asia Software.

### Chức năng chính

#### 1. Báo cáo bảng kê phiếu xuất
- Liệt kê chi tiết các phiếu xuất kho theo nhiều tiêu chí lọc
- Hỗ trợ nhóm dữ liệu theo nhiều khía cạnh (nhóm vật tư, khách hàng, kho...)
- Hiển thị theo đơn vị tính tùy chọn

#### 2. Các tiêu chí lọc báo cáo
- **Kho**: Lọc theo mã kho cụ thể
- **Vật tư**: Lọc theo mã vật tư hoặc nhóm vật tư
- **Khách hàng**: Lọc theo mã khách hàng
- **Bộ phận**: Lọc theo mã bộ phận
- **Hợp đồng**: Lọc theo mã hợp đồng
- **Phí**: Lọc theo mã phí
- **SPCT**: Lọc theo sản phẩm chi tiết
- **Lô**: Lọc theo mã lô
- **Tài khoản**: Lọc theo tài khoản
- **TK đối ứng**: Lọc theo tài khoản đối ứng
- **Số chứng từ**: Lọc theo khoảng số chứng từ
- **Loại phiếu**: Lọc theo loại phiếu xuất
- **Loại giao dịch**: Lọc theo loại giao dịch

#### 3. Tính năng nhóm và chi tiết
- Hỗ trợ nhóm báo cáo theo nhiều tiêu chí
- Chuyển đổi đơn vị tính khi hiển thị
- Tích hợp Crystal Reports để in ấn

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - base form báo cáo chuẩn của Asia ERP
- Sử dụng các custom controls `AsTextBox`, `AsComboBox` với tính năng validation
- Tích hợp Crystal Report Viewer để hiển thị và in ấn báo cáo
- Hỗ trợ lookup dữ liệu tự động (hiển thị tên khi nhập mã)

---

## Kết luận

Đây là module Windows Forms của hệ thống Simba Accounting, phục vụ cho việc xem và in báo cáo bảng kê phiếu xuất kho - một báo cáo quan trọng trong quản lý kho và kế toán hàng tồn kho.

---

*Ngày phân tích: 2026-03-29*
