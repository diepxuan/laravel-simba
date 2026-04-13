# PO6 - Hóa đơn mua dịch vụ

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã chứng từ | PO6 |
| Tên | Hóa đơn mua dịch vụ |
| Assembly | PoVchPO6.dll |
| Loại | Voucher |
| Framework | .NET Framework 3.5 |

## Chức năng

### 1. Nhập liệu hóa đơn mua dịch vụ
- Quản lý thông tin nhà cung cấp (mã KH, tên, địa chỉ, MST)
- Quản lý thông tin hóa đơn VAT (số seri, số HĐ, ngày HĐ)
- Xử lý đa tiền tệ (tỷ giá, quy đổi)
- Chi tiết dịch vụ với TK nợ, giá, thuế

### 2. Tính toán tự động
- Tính tổng tiền, thuế GTGT, thanh toán
- Chuyển đổi ngoại tệ theo tỷ giá
- Tính thuế GTGT theo từng dòng

### 3. Quản lý thuế
- Tab thuế riêng (`tabTain`)
- Tích hợp với `ctlTaIn` (control thuế đầu vào)
- Lấy thuế từ chi tiết chứng từ

### 4. Hạch toán
- Tab hạch toán riêng (`tabHach_toan`)
- TK phải trả (TK có)
- TK thuế GTGT được khấu trừ

### 5. Tìm kiếm
- Tìm kiếm theo nhiều tiêu chí (NCC, ngày, số tiền, vật tư...)
- Lọc theo bộ phận, phí, hợp đồng, SPCT

## Các trường chính

| Trường | Ý nghĩa |
|---------|----------|
| ma_nt | Mã ngoại tệ |
| ty_gia | Tỷ giá |
| ma_kh | Mã nhà cung cấp |
| so_hd | Số hóa đơn |
| ngay_hd | Ngày hóa đơn |
| ma_httt | Mã hình thức thanh toán |
| t_tien | Tổng tiền |
| t_thue | Tổng thuế |
| t_tt | Tổng thanh toán |
| tk_pt | Tài khoản phải trả |
| tk_thue | Tài khoản thuế |

## Tab Pages

| Tab | Mục đích |
|-----|---------|
| Chi tiết | Chi tiết vật tư/dịch vụ |
| tabTain | Thuế đầu vào |
| tabHach_toan | Hạch toán kế toán |

## Controls chính

### Thông tin phiếu (Header)

| Control | Loại | Mục đích |
|---------|------|----------|
| txtSo_Seri | TextBox | Số seri hóa đơn |
| txtNgay_lct | AsMaskedTextBox | Ngày lập chứng từ |
| cboMa_NT | AsComboBoxNT | Mã ngoại tệ |
| txtTy_gia | AsTextNumeric | Tỷ giá |
| txtMa_Kh | AsTextBox | Mã nhà cung cấp |
| txtNguoi_Gd | TextBox | Người giao dịch |
| txtDia_chi | TextBox | Địa chỉ |
| txtMa_so_thue | TextBox | Mã số thuệ |
| txtSo_hd | TextBox | Số hóa đơn |
| txtNgay_hd | AsMaskedTextBox | Ngày hóa đơn |
| txtMa_Httt | AsTextBox | Hình thức thanh toán |
| txtDien_giai | TextBox | Diễn giải |

### Tab Chi tiết (Detail)

| Control | Loại | Mục đích |
|---------|------|----------|
| adgvDetail | AsInputDGV | DataGridView chi tiết |
| dgvcMa_vt | DataGridViewAsTextBoxColumn | Mã vật tư/dịch vụ |
| dgvcTen_vt | DataGridViewTextBoxColumn | Tên vật tư |
| dgvcDvt | DataGridViewTextBoxColumn | Đơn vị tính |
| dgvcSo_luong | DataGridViewAsTextNumericColumn | Số lượng |
| dgvcGia_Nt | DataGridViewAsTextNumericColumn | Giá ngoại tệ |
| dgvcTien_nt | DataGridViewAsTextNumericColumn | Tiền ngoại tệ |
| dgvcTs_gtgt | DataGridViewAsTextNumericColumn | Thuế suất GTGT |
| dgvcThue_gtgt_nt | DataGridViewAsTextNumericColumn | Thuế GTGT NT |
| dgvcGia | DataGridViewAsTextNumericColumn | Giá VNĐ |
| dgvcTien | DataGridViewAsTextNumericColumn | Tiền VNĐ |
| dgvcThue_gtgt | DataGridViewAsTextNumericColumn | Thuế GTGT VNĐ |
| dgvcTk_no | DataGridViewAsTextBoxColumn | TK nợ |

### Tổng tiền

| Control | Loại | Mục đích |
|---------|------|----------|
| txtT_Tien_nt | AsTextNumeric | Tổng tiền ngoại tệ |
| txtT_Thue_nt | AsTextNumeric | Tổng thuế NT |
| txtT_tt_nt | AsTextNumeric | Tổng thanh toán NT |
| txtT_Tien | AsTextNumeric | Tổng tiền VNĐ |
| txtT_Thue | AsTextNumeric | Tổng thuế VNĐ |
| txtT_tt | AsTextNumeric | Tổng thanh toán VNĐ |

## Form liên quan

| Form | Mục đích |
|------|---------|
| frmPoVchPO6 | Form nhập liệu chính |
| frmPoVchPO6Find | Form tìm kiếm chứng từ |

## Dependencies

- AsiaErp.Framework
- AsiaErp.POUtilities
- Microsoft.VisualBasic
- System.Data
- System.Core

## Ghi chú

- Kế thừa từ `frmVoucher` và `frmVoucherFind`
- DataBinding với DataTable (PHTable, CTTable, TAINTable)
- Validation dữ liệu đầu vào (mã KH, TK, số tiền)
- Hỗ trợ nhiều loại tiền tệ
- Tích hợp với module POUtilities
