# ARPost2TT.dll - Phân bổ thanh toán

## Tổng quan

DLL thực hiện chức năng phân bổ thanh toán (Payment Allocation) trong module AR. Cho phép phân bổ các khoản thanh toán từ khách hàng vào các hóa đơn công nợ tương ứng.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaErp.UserInterface` |
| Assembly | `Asia Enterprise` |
| Version | `9.1.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © AsiaSoft 2010` |

## Forms chính

### frmARPost2TT
- **Kế thừa**: `frmReport`
- **Mô tả**: Form phân bổ thanh toán
- **Chức năng**:
  - Chọn khách hàng cần phân bổ thanh toán
  - Hiển thị danh sách hóa đơn chưa thanh toán
  - Phân bổ số tiền thanh toán vào từng hóa đơn
  - Tự động phân bổ theo thứ tự ngày hóa đơn

## Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Kh | `AsTextBox` | Mã khách hàng |
| lblTen_Kh | `Label` | Tên khách hàng |
| txtMa_Tk | `AsTextBox` | Tài khoản công nợ |
| lblTen_Tk | `Label` | Tên tài khoản |
| dgvHoaDon | `DataGridView` | Danh sách hóa đơn |
| txtTien_TT | `AsTextNumeric` | Số tiền thanh toán |

## Business Logic

### Phân bổ thanh toán
1. Chọn khách hàng cần thanh toán
2. Hệ thống hiển thị các hóa đơn chưa thanh toán của khách hàng
3. Nhập số tiền thanh toán
4. Hệ thống tự động phân bổ vào các hóa đơn theo thứ tự:
   - Ưu tiên hóa đơn cũ nhất (ngày hóa đơn nhỏ nhất)
   - Phân bổ cho đến khi hết số tiền thanh toán

### Tính toán
- Số tiền còn phải thu = Số tiền hóa đơn - Số tiền đã thanh toán
- Số tiền phân bổ không vượt quá số tiền còn phải thu

## Dependencies

- `AsiaErp.Framework`
- `System.Data`
- `System.Windows.Forms`

## Ghi chú

- Chức năng quan trọng để cập nhật trạng thái thanh toán của hóa đơn
- Ảnh hưởng trực tiếp đến số dư công nợ khách hàng
