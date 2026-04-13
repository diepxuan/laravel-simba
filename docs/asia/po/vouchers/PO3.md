# PO3 - Hóa đơn mua hàng

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã chứng từ | PO3 |
| Tên | Hóa đơn mua hàng |
| Assembly | POVchPO3.dll |
| Loại | Voucher |
| Framework | .NET Framework 3.5 |

## Chức năng

### 1. Nhập liệu hóa đơn mua hàng
- Quản lý thông tin nhà cung cấp
- Nhập thông tin hóa đơn (số HĐ, ngày HĐ)
- Quản lý hình thức thanh toán
- Nhập chi tiết hàng hóa/vật tư mua

### 2. Quản lý chi phí mua hàng
- Tab chi phí riêng (`tabChi_phi`)
- Phân bổ chi phí mua hàng cho các mặt hàng
- Tính toán chi phí nhập khẩu (nếu có)

### 3. Hạch toán kế toán
- Tab hạch toán (`tabHach_toan`)
- Tài khoản phải trả (`tk_pt`)
- Tài khoản thuế GTGT (`tk_thue`)
- Control `ctlTaIn` cho thuế đầu vào

### 4. Tính toán tự động
- Tính tổng tiền hàng
- Tính chi phí mua hàng
- Tính thuế GTGT
- Tính chiết khấu thanh toán
- Tính tổng thanh toán
- Phân bổ chi phí (`cmdPhan_bo`)

### 5. Liên kết chứng từ
- Lấy dữ liệu từ đơn đặt hàng (PO1)
- Kiểm tra khớp đơn hàng với hóa đơn

## Các trường chính

| Trường | Ý nghĩa |
|---------|----------|
| ma_kh | Mã nhà cung cấp |
| so_hd | Số hóa đơn |
| ngay_hd | Ngày hóa đơn |
| ma_httt | Mã hình thức thanh toán |
| t_tien_nt0 | Tổng tiền hàng NT |
| t_tien0 | Tổng tiền hàng |
| t_cp_nt | Tổng chi phí NT |
| t_cp | Tổng chi phí |
| t_thue_nt | Tổng thuế NT |
| t_thue | Tổng thuế |
| t_ck_nt | Tổng chiết khấu NT |
| t_ck | Tổng chiết khấu |
| t_tt_nt | Tổng thanh toán NT |
| t_tt | Tổng thanh toán |
| tk_thue | Tài khoản thuế |
| tk_pt | Tài khoản phải trả |

## Tab Pages

| Tab | Mục đích |
|-----|---------|
| tabChi_phi | Chi phí mua hàng |
| tabHach_toan | Hạch toán kế toán |
| tabTain | Thuế đầu vào |

## Cột chi tiết hóa đơn

| Cột | Ý nghĩa |
|-----|----------|
| dgvcMa_vt | Mã vật tư |
| dgvcTen_vt | Tên vật tư |
| dgvcDvt | Đơn vị tính |
| dgvcMa_kho | Mã kho |
| dgvcSo_luong | Số lượng |
| dgvcGia_nt0 | Giá ngoại tệ |
| dgvcTien_nt0 | Tiền ngoại tệ |
| dgvcTs_gtgt | Thuế suất GTGT |
| dgvcThue_Gtgt_nt | Thuế GTGT NT |
| dgvcGia0 | Giá |
| dgvcTien0 | Tiền |
| dgvcThue_gtgt | Thuế GTGT |
| dgvcMa_bp | Mã bộ phận |
| dgvcMa_phi | Mã phí |
| dgvcMa_spct | Mã SP chi tiết |
| dgvcMa_Lo | Mã lô |

## Cột chi phí

| Cột | Ý nghĩa |
|-----|----------|
| dgvcMa_chiphi | Mã chi phí |
| dgvcTen_chi_phi | Tên chi phí |
| dgvcTT_PB | Thông tin phân bổ |
| dgvcTien_cp_nt_cp | Tiền chi phí NT |
| dgvcTs_gtgt_cp | Thuế suất chi phí |
| dgvcThue_gtgt_nt_cp | Thuế GTGT chi phí NT |
| dgvcTt_nt_Cp | Tổng tiền chi phí NT |
| dgvcTien_cp_cp | Tiền chi phí |
| dgvcThue_gtgt_cp | Thuế GTGT chi phí |
| dgvcTt_Cp | Tổng tiền chi phí |

## Form liên quan

| Form | Mục đích |
|------|---------|
| frmPOVchPO3 | Form nhập liệu chính |
| frmPOVchPO3Find | Form tìm kiếm chứng từ |
| frmPoVchPo3FindPO1 | Form tìm kiếm đơn đặt hàng |
| frmPOVchPO3SeachPO1 | Form tìm kiếm nâng cao |

## Dependencies

- AsiaErp.Framework
- AsiaErp.POUtilities
- Microsoft.VisualBasic
- System.Data
- System.Core
- System.Xml.Linq

## Ghi chú

- Kế thừa từ `frmVoucher`
- Sử dụng Multi-Tab (Chi tiết, Chi phí, Hạch toán, Thuế)
- Tích hợp `ctlTaIn` cho quản lý thuế đầu vào
- SplitContainer cho phân chia màn hình chi phí
- Hỗ trợ nhập khẩu với các loại thuế đặc biệt
