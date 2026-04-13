# Báo cáo Phân tích DLL: INRptTHX01.dll

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
| Assembly Name | INRptTHX01 |
| Assembly Title | Tổng hợp hàng xuất kho |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
INRptTHX01.dll/
├── INRptTHX01.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmINRptTHX01.cs         # Main report form
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
| `frmINRptTHX01` | `frmReport` | Form báo cáo tổng hợp xuất 01 |

---

## Các Controls trên Form

### Controls nhập liệu chính

| Control | Tên | Mục đích |
|---------|-----|----------|
| AsTextBox | txtMa_vt | Mã vật tư |
| AsTextBox | txtMa_nhvt | Mã nhóm vật tư |
| AsTextBox | txtMa_Kh | Mã khách hàng |
| AsTextBox | txtMa_kho_xuat | Mã kho xuất |
| AsTextBox | txtMa_Kho_nhap | Mã kho nhập |
| AsTextBox | txtTk_vt | TK vật tư |
| AsTextBox | txtTk_Du | TK đối ứng |
| AsTextBox | txtMa_NX | Mã dạng nhập xuất |
| AsTextBox | txtMa_Bp | Mã bộ phận |
| AsTextBox | txtMa_Hd | Mã hợp đồng |
| AsTextBox | txtMa_lo | Mã lô |
| TextBox | txtSo_Ct1 | Số chứng từ từ |
| TextBox | txtSo_Ct2 | Số chứng từ đến |

### Controls ComboBox

| Control | Tên | Mục đích |
|---------|-----|----------|
| ComboBox | cboLoai_px | Loại phiếu xuất |

### Controls CheckBox

| Control | Tên | Mục đích |
|---------|-----|----------|
| AsCheckBox | ChkPsdc | Hiển thị phát sinh điều chỉnh |

### Controls Crystal Report

| Control | Tên | Mục đích |
|---------|-----|----------|
| CrystalReportViewer | crvReportViewer | Xem và in báo cáo |

### Label hiển thị

| Label | Mục đích |
|-------|----------|
| lblMa_vt | Mã vật tư |
| lblTen_vt | Tên vật tư |
| lblMa_nhvt | Mã nhóm VT |
| lblTen_nhvt | Tên nhóm VT |
| lblMa_Kh | Mã khách hàng |
| lblTen_Kh | Tên khách hàng |
| lblMa_kho_xuat | Mã kho xuất |
| lblTen_kho_xuat | Tên kho xuất |
| lblMa_kho_nhap | Mã kho nhập |
| lblTen_kho_nhap | Tên kho nhập |
| lblTk_vt | TK vật tư |
| lblTen_Tkvt | Tên TK vật tư |
| lblTk_Du | TK đối ứng |
| lblTen_Tk_Du | Tên TK đối ứng |
| lblMa_NX | Mã dạng NX |
| lblTen_dangNX | Tên dạng NX |
| lblMa_Bp | Mã bộ phận |
| lblTen_Bp | Tên bộ phận |
| lblMa_Hd | Mã hợp đồng |
| lblTen_Hd | Tên hợp đồng |
| lblMa_lo | Mã lô |
| lblTen_lo | Tên lô |
| lblMa_loaiPx | Loại phiếu xuất |
| lblPS_dc | Phát sinh điều chỉnh |
| lblSo_Ct1 | Số CT từ |
| lblSo_Ct2 | Số CT đến |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `thx` | Tổng hợp xuất |
| `ma_vt` | Mã vật tư |
| `ma_nhvt` | Mã nhóm vật tư |
| `ma_kh` | Mã khách hàng |
| `ma_kho_xuat` | Mã kho xuất |
| `ma_kho_nhap` | Mã kho nhập (chuyển kho) |
| `tk_vt` | Tài khoản vật tư |
| `tk_du` | Tài khoản đối ứng |
| `ma_nx` | Mã dạng nhập xuất |
| `ma_bp` | Mã bộ phận |
| `ma_hd` | Mã hợp đồng |
| `ma_lo` | Mã lô |
| `loai_px` | Loại phiếu xuất |
| `ps_dc` | Phát sinh điều chỉnh |

---

## Mục đích sử dụng

**INRptTHX01.dll là module báo cáo "Tổng hợp hàng xuất kho 01"** trong hệ thống Asia Enterprise của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo tổng hợp xuất kho
- Tổng hợp các phiếu xuất kho theo nhiều tiêu chí
- Hỗ trợ theo dõi xuất kho nội bộ (chuyển kho) qua kho nhập
- Hiển thị tổng số lượng, giá trị xuất theo từng nhóm

#### 2. Các tiêu chí lọc báo cáo
- **Vật tư**: Lọc theo mã vật tư hoặc nhóm vật tư
- **Khách hàng**: Lọc theo mã khách hàng
- **Kho xuất**: Lọc theo mã kho xuất
- **Kho nhập**: Lọc theo mã kho nhập (dùng cho chuyển kho)
- **TK vật tư**: Lọc theo tài khoản vật tư
- **TK đối ứng**: Lọc theo tài khoản đối ứng
- **Dạng NX**: Lọc theo dạng nhập xuất
- **Bộ phận**: Lọc theo mã bộ phận
- **Hợp đồng**: Lọc theo mã hợp đồng
- **Lô**: Lọc theo mã lô
- **Số chứng từ**: Lọc theo khoảng số chứng từ
- **Loại phiếu xuất**: Lọc theo loại phiếu xuất

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - base form báo cáo chuẩn của Asia ERP
- Sử dụng các custom controls `AsTextBox`, `AsCheckBox` với tính năng validation
- Tích hợp Crystal Report Viewer để hiển thị và in ấn báo cáo
- Hỗ trợ lookup dữ liệu tự động (hiển thị tên khi nhập mã)
- Thuộc phiên bản Asia Enterprise 9.1 (cũ hơn Simba Accounting)

---

## Kết luận

Đây là module Windows Forms của hệ thống Asia Enterprise, phục vụ cho việc xem và in báo cáo tổng hợp hàng xuất kho - một báo cáo quan trọng trong quản lý kho và theo dõi hàng xuất.

---

*Ngày phân tích: 2026-03-29*
