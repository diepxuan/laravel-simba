# PO7 - Phiếu nhập kho nội bộ

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã chứng từ | PO7 |
| Tên | Phiếu nhập kho nội bộ |
| Assembly | POVchPO7.dll |
| Loại | Voucher |
| Framework | .NET Framework 3.5 |

## Chức năng

### 1. Nhập liệu chứng từ nhập kho
- Quản lý thông tin nhà cung cấp (mã NCC, tên, địa chỉ, MST, người bán)
- Quản lý thông tin hóa đơn (số HĐ, ngày HĐ, mẫu HĐ)
- Xử lý đa tiền tệ (tỷ giá, phát sinh ngoại tệ/VNĐ)
- Quản lý phương thức thanh toán

### 2. Chi tiết nhập kho
- Nhập liệu vật tư: mã hàng, tên hàng, đvt, kho, số lượng
- Tính toán giá và thành tiền (ngoại tệ và VND)
- Quản lý chi phí nhập khẩu
- Theo dõi tồn kho tức thời

### 3. Quản lý thuế
- Thuế nhập khẩu (%NK)
- Thuế tiêu thụ đặc biệt (%TTĐB)
- Thuế GTGT (%VAT)
- Tích hợp với `ctlTaIn` (control thuế đầu vào)

### 4. Chi phí nhập khẩu
- Tab riêng quản lý chi phí nhập khẩu
- Phân bổ chi phí cho các mặt hàng
- Quản lý NCC chi phí, TK phải trả

### 5. Hạch toán
- Tab hạch toán tự động
- TK kho, TK thuế NK, TK thuế TTDB, TK có
- Tổng hợp tiền hàng, thuế, chi phí

## Các trường chính

| Trường | Ý nghĩa |
|---------|----------|
| ma_nt | Mã ngoại tệ |
| ty_gia | Tỷ giá |
| ma_kh | Mã nhà cung cấp |
| so_hd | Số hóa đơn |
| ngay_hd | Ngày hóa đơn |
| ma_httt | Mã hình thức thanh toán |
| tien_nt0 | Tiền hàng ngoại tệ |
| tien0 | Tiền hàng VND |
| thue_nk | Thuế nhập khẩu |
| thue_ttdb | Thuế tiêu thụ đặc biệt |
| thue_gtgt | Thuế GTGT |
| tk_vt | Tài khoản kho |
| tk_pt | Tài khoản phải trả |
| ma_kho | Mã kho |
| ma_vt | Mã vật tư |

## Tab Pages

| Tab | Ý nghĩa |
|-----|---------|
| Chi tiết | Chi tiết vật tư nhập kho |
| Chi phí nhập khẩu | Chi phí liên quan nhập khẩu |
| Hạch toán | Thông tin hạch toán kế toán |
| Thuế GTGT | Thông tin thuế giá trị gia tăng |

## Cột DataGridView (Chi tiết chứng từ)

| Cột | Ý nghĩa |
|-----|----------|
| Mã hàng | Mã vật tư |
| Tên hàng | Tên vật tư |
| Đvt | Đơn vị tính |
| Kho | Mã kho nhập |
| Tồn | Số lượng tồn kho |
| Số lượng | Số lượng nhập |
| Đơn giá | Giá nhập ngoại tệ |
| Thành tiền | Tiền hàng ngoại tệ |
| Chi phí | Chi phí ngoại tệ |
| %NK | Thuế suất nhập khẩu |
| Thuế NK | Thuế nhập khẩu |
| %TTĐB | Thuế suất tiêu thụ đặc biệt |
| Thuế TTĐB | Thuế tiêu thụ đặc biệt |
| %VAT | Thuế suất GTGT |
| VAT | Thuế GTGT |
| Đơn giá VND | Giá VND |
| Tiền VND | Thành tiền VND |
| CP VND | Chi phí VND |

## Form liên quan

| Form | Mục đích |
|------|---------|
| frmPOVchPO7 | Form nhập liệu chính |

## Dependencies

- AsiaErp.Framework
- AsiaErp.POUtilities
- Microsoft.VisualBasic
- System.Data

## Ghi chú

- Kế thừa từ `frmVoucher`
- Sử dụng DataBinding với DataTable (PHTable, CTTable, CPTable, TAINTable)
- Kiểm tra validation dữ liệu đầu vào
- Hỗ trợ nhiều loại tiền tệ với làm tròn theo cấu hình
- Tích hợp với module POUtilities
- Tính toán tự động tổng tiền, thuế, thanh toán
