# Phân tích DLL: ARRecalCustBalance.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ARRecalCustBalance.dll |
| **Namespace** | AsiaERP.UserInterface |
| **Form chính** | frmARRecalCustBalance |
| **Kế thừa** | frmReport |
| **Chức năng** | Tính lại số dư khách hàng (Recalculate Customer Balance) |

## 2. Forms

### 2.1 frmARRecalCustBalance (Report Form)

**Mô tả:** Form tính lại số dư khách hàng

**Controls chính:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtNgay1 | AsMaskedTextBox | Từ ngày |
| txtNgay2 | AsMaskedTextBox | Đến ngày |
| txtMa_Kh | AsTextBox | Mã khách hàng (tùy chọn) |
| lblTen_Kh | Label | Tên khách hàng |
| cmdTinhLai | Button | Thực hiện tính lại |
| dgvKetQua | DataGridView | Kết quả tính toán |

**Chức năng:**
- Chọn khoảng thời gian tính lại số dư
- Chọn khách hàng cần tính lại (hoặc tất cả)
- Thực hiện tính toán lại số dư công nợ
- Hiển thị kết quả tính toán

## 3. Business Logic

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

## 4. Dependencies

- `AsiaErp.Framework`
- `System.Data`
- `System.Windows.Forms`

## 5. Ghi chú

- Chức năng này cần chạy khi có sai lệch số dư
- Có thể chọn tính lại cho một khách hàng cụ thể hoặc tất cả
- Thường dùng sau khi import dữ liệu từ hệ thống khác
