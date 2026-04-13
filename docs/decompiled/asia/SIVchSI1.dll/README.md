# Báo cáo Phân tích DLL: SIVchSI1.dll

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
| Assembly Name | SIVchSI1 |
| Assembly Title | Phiếu nhập kho |
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
SIVchSI1.dll/
├── INVchIN1.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmInVchIN1.cs           # Main form class - Phiếu nhập kho
│   └── frmInVchIN1Find.cs       # Form tìm kiếm phiếu nhập
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| AsiaErp.Framework | Asia ERP Framework |
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Drawing | Graphics |
| System.Windows.Forms | Windows Forms |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.Collections.Generic`, `System.ComponentModel`, `System.Data`, `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmInVchIN1` | `frmVoucher` | Form nhập liệu phiếu nhập kho |
| `frmInVchIN1Find` | - | Form tìm kiếm phiếu nhập kho |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã khách hàng" (`ma_kh`)
- "Tên khách hàng" (`ten_kh`)
- "Người giao dịch" (`nguoi_gd`)
- "Địa chỉ" (`dia_chi`)
- "Diễn giải" (`dien_giai`)
- "Ngày lập chứng từ" (`ngay_lct`)
- "Mã ngoại tệ" (`ma_nt`)
- "Tỷ giá" (`ty_gia`)
- "Tổng tiền" (`t_tien`)
- "Mã giao dịch" (`ma_gd`)

### Cột DataGridView (Chi tiết phiếu nhập)

| Cột | Ý nghĩa |
|-----|---------|
| `ma_vt` | Mã vật tư |
| `ten_vt` | Tên vật tư |
| `dvt` | Đơn vị tính |
| `ma_kho` | Mã kho |
| `ton` | Tồn kho |
| `so_luong` | Số lượng |
| `gia_nt` | Giá ngoại tệ |
| `tien_nt` | Tiền ngoại tệ |
| `gia` | Giá (VNĐ) |
| `tien` | Tiền (VNĐ) |
| `tk_vt` | Tài khoản vật tư |
| `tk_co` | Tài khoản có |
| `ma_spct` | Mã SPCT |
| `ma_hd` | Mã hợp đồng |
| `ma_phi` | Mã phí |
| `ma_bp` | Mã bộ phận |
| `ma_lo` | Mã lô |

### Loại phiếu nhập

| Giá trị | Ý nghĩa |
|---------|---------|
| 1 | Phiếu nhập thành phẩm |
| 2 | Phiếu nhập khác |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ct` | Mã chứng từ (IN1) |
| `ngay_ct` | Ngày chứng từ |
| `ngay_lct` | Ngày lập chứng từ |
| `so_ct` | Số chứng từ |
| `ma_kh` | Mã khách hàng |
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `t_tien_nt` | Tổng tiền ngoại tệ |
| `t_tien` | Tổng tiền (VNĐ) |
| `t_so_luong` | Tổng số lượng |

---

## Mục đích sử dụng

**SIVchSI1.dll là module quản lý Phiếu nhập kho** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu phiếu nhập kho
- Quản lý thông tin khách hàng (mã KH, tên, địa chỉ, người giao dịch)
- Quản lý thông tin chứng từ (số CT, ngày CT, ngày lập CT)
- Xử lý đa tiền tệ (tỷ giá, tổng tiền ngoại tệ/VNĐ)

#### 2. Chi tiết nhập kho
- Nhập liệu vật tư (mã VT, tên VT, đơn vị tính)
- Quản lý kho (mã kho, tồn kho)
- Nhập số lượng và giá
- Tính toán tiền tự động

#### 3. Tài khoản kế toán
- Tài khoản vật tư (`tk_vt`)
- Tài khoản có (`tk_co`)

#### 4. Thông tin bổ sung
- Mã SPCT (sản phẩm chi tiết)
- Mã hợp đồng
- Mã phí
- Mã bộ phận
- Mã lô

#### 5. Tính toán tự động
- Tính tổng số lượng
- Tính tổng tiền
- Chuyển đổi ngoại tệ theo tỷ giá

### Đặc điểm kỹ thuật

- Sử dụng `frmVoucher` - form chứng từ chuẩn
- DataGridView nhập liệu chi tiết (`AsInputDGV`)
- AutoLookup cho các trường mã: Khách hàng, Vật tư, Kho, Tài khoản
- Validation dữ liệu đầu vào
- Hỗ trợ tính giá trung bình (`chkGia_tb`)
- Hỗ trợ tính giá thành (`chkGia_thanh`)

### Mã chứng từ

**IN1** (Phiếu nhập kho) - một loại chứng từ nhập kho trong kế toán kho.

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu và quản lý phiếu nhập kho - một loại chứng từ quan trọng trong quản lý kho và kế toán hàng tồn kho.

---

*Ngày phân tích: 2026-03-29*
