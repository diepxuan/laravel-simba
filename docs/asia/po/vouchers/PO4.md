# PO4 - Phiếu nhập kho

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã chứng từ | PO4 |
| Tên | Phiếu nhập kho |
| Assembly | POVchPO4.dll |
| Loại | Voucher |
| Framework | .NET Framework 3.5 |

## Chức năng

### 1. Nhập liệu phiếu nhập kho
- Quản lý thông tin nhà cung cấp
- Nhập thông tin phiếu nhập kho
- Quản lý hình thức thanh toán
- Nhập chi tiết hàng hóa/vật tư nhập kho

### 2. Chọn từ đơn hàng/hóa đơn
- Nút "Chọn đơn hàng" (`cmdChon_dh`)
- Lấy dữ liệu từ đơn đặt hàng (PO1)
- Lấy dữ liệu từ hóa đơn mua (PO3)
- Tự động điền thông tin chi tiết

### 3. Quản lý chi phí nhập kho
- Tab chi phí (`tabChi_phi`)
- Phân bổ chi phí nhập kho cho các mặt hàng
- Tính toán chi phí vận chuyển, bốc xếp, ...

### 4. Hạch toán kế toán
- Tab hạch toán (`tabHach_toan`)
- Tài khoản phải trả (`tk_pt`)
- Tài khoản thuế (`tk_thue`)
- Tài khoản vật tư (`dgvcTk_vt`)
- Control `ctlTaIn` cho thuế đầu vào

### 5. Tính toán tự động
- Tính tổng tiền hàng nhập
- Tính chi phí nhập kho
- Tính thuế GTGT
- Tính tổng thanh toán
- Phân bổ chi phí (`cmdPhan_bo`)

### 6. Liên kết chứng từ
- Liên kết với đơn đặt hàng (PO1)
- Liên kết với hóa đơn mua (PO3)
- Kiểm tra khớp số lượng nhập với đơn hàng

## Các trường chính

| Trường | Ý nghĩa |
|---------|----------|
| ma_kh | Mã nhà cung cấp |
| ma_httt | Mã hình thức thanh toán |
| t_tien_nt0 | Tổng tiền hàng NT |
| t_tien0 | Tổng tiền hàng |
| t_cp_nt | Tổng chi phí NT |
| t_cp | Tổng chi phí |
| tien_cp_pb_nt | Tiền chi phí phân bổ NT |
| tien_cp_pb | Tiền chi phí phân bổ |
| t_thue_nt | Tổng thuế NT |
| t_thue | Tổng thuế |
| t_tt_nt | Tổng thanh toán NT |
| t_tt | Tổng thanh toán |
| tk_pt | Tài khoản phải trả |
| tk_thue | Tài khoản thuế |

## Tab Pages

| Tab | Mục đích |
|-----|---------|
| tabChi_phi | Chi phí nhập kho |
| tabHach_toan | Hạch toán kế toán |
| tabTain | Thuế đầu vào |

## Cột chi tiết nhập kho

| Cột | Ý nghĩa |
|-----|----------|
| dgvcMa_vt | Mã vật tư |
| dgvcTen_vt | Tên vật tư |
| dgvcDvt | Đơn vị tính |
| dgvcMa_kho | Mã kho |
| dgvcSo_luong | Số lượng nhập |
| dgvcMa_nt | Mã ngoại tệ |
| dgvcTien_nt0 | Tiền ngoại tệ |
| dgvcCp_nt | Chi phí ngoại tệ |
| dgvcTien0 | Tiền |
| dgvcCp | Chi phí |
| dgvcTk_vt | Tài khoản vật tư |
| dgvcTk_co | Tài khoản có |
| dgvSo_pn | Số phiếu nhập |

## Cột chi phí

| Cột | Ý nghĩa |
|-----|----------|
| dgvcMa_chiphi | Mã chi phí |
| dgvcTT_PB | Thông tin phân bổ |
| dgvcTen_chi_phi | Tên chi phí |
| dgvcTien_cp_nt_cp | Tiền chi phí NT |
| dgvcTs_Gtgt | Thuế suất GTGT |
| dgvcThue_gtgt_nt_cp | Thuế GTGT NT |
| dgvcTt_nt_cp | Tổng tiền NT |
| dgvcTien_cp_cp | Tiền chi phí |
| dgvcThue_gtgt_cp | Thuế GTGT |
| dgvcTt_Cp | Tổng tiền |

## Form liên quan

| Form | Mục đích |
|------|---------|
| frmPOVchPO4 | Form nhập liệu chính |
| frmPOVchPO4Find | Form tìm kiếm chứng từ |
| frmPOVchPO4FindPO2PO3PO7 | Form tìm kiếm từ đơn hàng/hóa đơn |
| frmPOVchPO4SeachPO2PO3PO7 | Form tìm kiếm nâng cao |

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
- Hỗ trợ chọn dữ liệu từ nhiều nguồn (PO1, PO3, PO7)
