# PO5 - Phiếu trả lại hàng mua

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã chứng từ | PO5 |
| Tên | Phiếu trả lại hàng mua |
| Assembly | POVchPO5.dll |
| Loại | Voucher |
| Framework | .NET Framework 3.5 |

## Chức năng

### 1. Nhập liệu phiếu trả lại hàng mua
- Quản lý thông tin nhà cung cấp
- Nhập thông tin phiếu trả lại hàng
- Quản lý số seri chứng từ và số seri hóa đơn gốc
- Nhập chi tiết hàng hóa/vật tư trả lại

### 2. Chọn từ phiếu nhập/hóa đơn
- Nút "Chọn phiếu nhập" (`cmdChon_Pn`)
- Lấy dữ liệu từ phiếu nhập kho (PO4)
- Lấy dữ liệu từ hóa đơn mua (PO3)
- Tự động điền thông tin chi tiết từ chứng từ gốc

### 3. Quản lý số lượng trả
- Kiểm tra tồn kho (`dgvcTon`)
- Nhập số lượng trả lại
- Giữ nguyên giá từ chứng từ gốc
- Checkbox "Giá đã định" (`chkGia_dd`)

### 4. Hạch toán kế toán
- Tab hạch toán (`tabHach_toan`)
- Tài khoản phải trả (`tk_pt`)
- Tài khoản thuế (`tk_thue`)
- Tài khoản vật tư (`dgvcTk_vt`)
- Giảm trừ công nợ nhà cung cấp

### 5. Tính toán tự động
- Tính tổng tiền hàng trả
- Tính thuế GTGT giảm trừ
- Tính tổng thanh toán giảm
- Cập nhật tồn kho (giảm)

### 6. Liên kết chứng từ
- Liên kết với phiếu nhập kho (PO4)
- Liên kết với hóa đơn mua (PO3)
- Kiểm tra số lượng trả không vượt quá số lượng nhập

## Các trường chính

| Trường | Ý nghĩa |
|---------|----------|
| ma_kh | Mã nhà cung cấp |
| so_seri | Số seri chứng từ |
| so_seri_mhd | Số seri mua hóa đơn gốc |
| ma_httt | Mã hình thức thanh toán |
| t_tien_nt | Tổng tiền hàng NT |
| t_tien | Tổng tiền hàng |
| t_thue_nt | Tổng thuế NT |
| t_thue | Tổng thuế |
| t_tt_nt | Tổng thanh toán NT |
| t_tt | Tổng thanh toán |
| t_so_luong | Tổng số lượng |
| tk_thue | Tài khoản thuế |
| tk_pt | Tài khoản phải trả |
| gia_dd | Giá đã định (checkbox) |

## Tab Pages

| Tab | Mục đích |
|-----|---------|
| tabHach_toan | Hạch toán kế toán |

## Cột chi tiết trả lại

| Cột | Ý nghĩa |
|-----|----------|
| dgvcMa_vt | Mã vật tư |
| dgvcTen_vt | Tên vật tư |
| dgvcDvt | Đơn vị tính |
| dgvcMa_kho | Mã kho |
| dgvcTon | Tồn kho |
| dgvcSo_luong | Số lượng trả |
| dgvcGia_nt | Giá ngoại tệ |
| dgvcTien_nt | Tiền ngoại tệ |
| dgvcTs_gtgt | Thuế suất GTGT |
| dgvcThue_gtgt_nt | Thuế GTGT NT |
| dgvcGia | Giá |
| dgvcTien | Tiền |
| dgvcThue_gtgt | Thuế GTGT |
| dgvcSo_hd | Số hóa đơn gốc |
| dgvcTk_vt | Tài khoản vật tư |
| dgvcTk_pt | Tài khoản phải trả |
| dgvcMa_vt_ht | Mã vật tư hạch toán |

## Form liên quan

| Form | Mục đích |
|------|---------|
| frmPOVchPO5 | Form nhập liệu chính |
| frmPOVchPO5Find | Form tìm kiếm chứng từ |
| frmPOVchPO5FindPO3PO7 | Form tìm kiếm từ hóa đơn/phiếu nhập |
| frmPOVchPO5SeachPO2PO3PO7 | Form tìm kiếm nâng cao |

## Dependencies

- AsiaErp.Framework
- AsiaErp.POUtilities
- Microsoft.VisualBasic
- System.Data

## Ghi chú

- Kế thừa từ `frmVoucher`
- Sử dụng `AsInputDGV` cho nhập liệu chi tiết
- Tích hợp `POUtilities` cho các hàm chung
- SplitContainer cho phân chia màn hình hạch toán
- Hỗ trợ chọn dữ liệu từ nhiều nguồn (PO2, PO3, PO7)
- Validation số lượng trả không vượt quá tồn kho
