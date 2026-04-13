# PO1 - Đơn đặt hàng mua

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã chứng từ | PO1 |
| Tên | Đơn đặt hàng mua |
| Assembly | POVchPO1.dll |
| Loại | Voucher |
| Framework | .NET Framework 3.5 |

## Chức năng

### 1. Nhập liệu đơn đặt hàng mua
- Quản lý thông tin nhà cung cấp (mã KH, tên, địa chỉ, người giao dịch, mã số thuế)
- Quản lý thông tin đơn hàng (diễn giải, tỷ giá, ngoại tệ)
- Nhập chi tiết vật tư/hàng hóa cần mua

### 2. Quản lý chi tiết đơn hàng
- Mã vật tư, tên vật tư, đơn vị tính
- Số lượng đặt hàng
- Giá và thành tiền (ngoại tệ và VNĐ)
- Thuế GTGT
- Thông tin kho, vị trí kho
- Thông tin bộ phận, phí, sản phẩm chi tiết

### 3. Tính toán tự động
- Tính tổng tiền hàng
- Tính thuế GTGT
- Tính chiết khấu
- Tính tổng thanh toán
- Chuyển đổi ngoại tệ theo tỷ giá

### 4. Quản lý trạng thái
- Trạng thái đơn hàng (chờ duyệt, đã duyệt, đã nhận, ...)
- Kiểm tra tồn kho

### 5. Tìm kiếm và liên kết
- Tìm kiếm đơn hàng theo nhiều tiêu chí
- Liên kết với đơn hàng gốc (PO0)

## Các trường chính

| Trường | Ý nghĩa |
|---------|----------|
| ma_kh | Mã nhà cung cấp |
| nguoi_gd | Người giao dịch |
| dien_giai | Diễn giải |
| ty_gia | Tỷ giá |
| ma_nt | Mã ngoại tệ |
| t_tien_nt0 | Tổng tiền ngoại tệ |
| t_tien0 | Tổng tiền |
| t_thue_nt | Tổng thuế ngoại tệ |
| t_thue | Tổng thuế |
| t_tt_nt | Tổng thanh toán ngoại tệ |
| t_tt | Tổng thanh toán |
| t_ck_nt | Tổng chiết khấu ngoại tệ |
| t_ck | Tổng chiết khấu |
| trang_thai | Trạng thái đơn hàng |

## Cột chi tiết

| Cột | Ý nghĩa |
|-----|----------|
| dgvcMa_vt | Mã vật tư |
| dgvcTen_vt | Tên vật tư |
| dgvcDvt | Đơn vị tính |
| dgvcMa_kho | Mã kho |
| dgvcMa_Vitri | Mã vị trí kho |
| dgvcTon | Tồn kho |
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
| dgvcMa_spct | Mã sản phẩm chi tiết |
| dgvcMa_Lo | Mã lô |
| dgvSo_dh | Số đơn hàng |

## Form liên quan

| Form | Mục đích |
|------|---------|
| frmPOVchPO1 | Form nhập liệu chính |
| frmPOVchPO1Find | Form tìm kiếm chứng từ |
| frmPOVchPO1FindPO0 | Form tìm kiếm đơn hàng gốc |
| frmPOVchPO1SeachPO0 | Form tìm kiếm nâng cao |

## Dependencies

- AsiaErp.Framework
- AsiaErp.POUtilities
- Microsoft.VisualBasic
- System.Data

## Ghi chú

- Kế thừa từ `frmVoucher`
- Sử dụng `AsInputDGV` cho nhập liệu chi tiết
- Hỗ trợ đa tiền tệ với tỷ giá linh hoạt
- Validation dữ liệu đầu vào (mã KH, mã vật tư, số lượng)
