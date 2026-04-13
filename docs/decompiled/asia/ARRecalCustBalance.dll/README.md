# ARRecalCustBalance.dll - Tính lại số dư khách hàng

## Tổng quan

DLL thực hiện chức năng tính lại số dư công nợ khách hàng (Recalculate Customer Balance). Dùng để tính toán lại số dư công nợ khi có sai lệch hoặc sau khi import dữ liệu.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaERP.UserInterface` |
| Assembly | `Asia Enterprise` |
| Version | `9.1.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © AsiaSoft 2010` |

## Forms chính

### frmARRecalCustBalance
- **Kế thừa**: `frmReport`
- **Mô tả**: Form tính lại số dư khách hàng
- **Chức năng**:
  - Chọn khoảng thời gian tính lại số dư
  - Chọn khách hàng cần tính lại (hoặc tất cả)
  - Thực hiện tính toán lại số dư công nợ
  - Hiển thị kết quả tính toán

## Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| txtNgay1 | `AsMaskedTextBox` | Từ ngày |
| txtNgay2 | `AsMaskedTextBox` | Đến ngày |
| txtMa_Kh | `AsTextBox` | Mã khách hàng (tùy chọn) |
| lblTen_Kh | `Label` | Tên khách hàng |
| cmdTinhLai | `Button` | Thực hiện tính lại |
| dgvKetQua | `DataGridView` | Kết quả tính toán |

## Business Logic

### Quy trình tính lại số dư
1. Xác định khoảng thời gian cần tính lại
2. Lấy tất cả chứng từ phát sinh trong kỳ
3. Tính lại số dư theo công thức:
   - Số dư đầu kỳ
   - (+) Phát sinh nợ
   - (-) Phát sinh có
   - (=) Số dư cuối kỳ
4. Cập nhật số dư vào bảng số dư

### Cảnh báo
- Kiểm tra ngày khóa sổ trước khi tính lại
- Không cho phép tính lại trước ngày khóa sổ
- Sao lưu dữ liệu trước khi thực hiện

## Dependencies

- `AsiaErp.Framework`
- `System.Data`
- `System.Windows.Forms`

## Ghi chú

- Chức năng này cần chạy khi có sai lệch số dư
- Có thể chọn tính lại cho một khách hàng cụ thể hoặc tất cả
- Thường dùng sau khi import dữ liệu từ hệ thống khác
