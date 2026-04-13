# Phiếu nhập kho (IN1)

## Thông tin chung

| Thuộc tính | Giá trị |
|-------------|---------|
| **Mã chứng từ** | IN1 |
| **Tên chứng từ** | Phiếu nhập kho |
| **DLL** | SIVchSI1.dll |
| **Form chính** | frmInVchIN1 |
| **Form tìm kiếm** | frmInVchIN1Find |

## Mục đích

Module quản lý phiếu nhập kho trong hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu và quản lý phiếu nhập kho - một loại chứng từ quan trọng trong quản lý kho và kế toán hàng tồn kho.

## Chức năng chính

### 1. Nhập liệu phiếu nhập kho
- Quản lý thông tin khách hàng (mã KH, tên, địa chỉ, người giao dịch)
- Quản lý thông tin chứng từ (số CT, ngày CT, ngày lập CT)
- Xử lý đa tiền tệ (tỷ giá, tổng tiền ngoại tệ/VNĐ)

### 2. Chi tiết nhập kho
- Nhập liệu vật tư (mã VT, tên VT, đơn vị tính)
- Quản lý kho (mã kho, tồn kho)
- Nhập số lượng và giá
- Tính toán tiền tự động

### 3. Tài khoản kế toán
- Tài khoản vật tư (`tk_vt`)
- Tài khoản có (`tk_co`)

### 4. Thông tin bổ sung
- Mã SPCT (sản phẩm chi tiết)
- Mã hợp đồng
- Mã phí
- Mã bộ phận
- Mã lô

### 5. Tính toán tự động
- Tính tổng số lượng
- Tính tổng tiền
- Chuyển đổi ngoại tệ theo tỷ giá

## Cấu trúc dữ liệu

### Thông tin chung (Master)

| Trường | Mô tả |
|---------|--------|
| `ma_ct` | Mã chứng từ (IN1) |
| `ngay_ct` | Ngày chứng từ |
| `ngay_lct` | Ngày lập chứng từ |
| `so_ct` | Số chứng từ |
| `ma_kh` | Mã khách hàng |
| `ten_kh` | Tên khách hàng |
| `nguoi_gd` | Người giao dịch |
| `dia_chi` | Địa chỉ |
| `dien_giai` | Diễn giải |
| `ma_gd` | Mã giao dịch |
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `t_tien_nt` | Tổng tiền ngoại tệ |
| `t_tien` | Tổng tiền (VNĐ) |
| `t_so_luong` | Tổng số lượng |

### Chi tiết (Detail)

| Trường | Mô tả |
|---------|--------|
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

## Loại phiếu nhập

| Giá trị | Ý nghĩa |
|---------|----------|
| 1 | Phiếu nhập thành phẩm |
| 2 | Phiếu nhập khác |

## Đặc điểm kỹ thuật

- Sử dụng `frmVoucher` - form chứng từ chuẩn
- DataGridView nhập liệu chi tiết (`AsInputDGV`)
- AutoLookup cho các trường mã: Khách hàng, Vật tư, Kho, Tài khoản
- Validation dữ liệu đầu vào
- Hỗ trợ tính giá trung bình (`chkGia_tb`)
- Hỗ trợ tính giá thành (`chkGia_thanh`)

## Dependencies

- AsiaErp.Framework
- Microsoft.VisualBasic
- System.Data
- System.Drawing
- System.Windows.Forms

## Version

- Assembly Version: 9.1.0.0
- Copyright: AsiaSoft 2010
