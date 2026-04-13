# Phân tích DLL: ARPost2TT.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ARPost2TT.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmARPost2TT |
| **Kế thừa** | frmReport |
| **Chức năng** | Phân bổ thanh toán (Payment Allocation) |

## 2. Forms

### 2.1 frmARPost2TT (Report Form)

**Mô tả:** Form phân bổ thanh toán

**Controls chính:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Kh | AsTextBox | Mã khách hàng |
| lblTen_Kh | Label | Tên khách hàng |
| txtMa_Tk | AsTextBox | Tài khoản công nợ |
| lblTen_Tk | Label | Tên tài khoản |
| dgvHoaDon | DataGridView | Danh sách hóa đơn |
| txtTien_TT | AsTextNumeric | Số tiền thanh toán |

**Chức năng:**
- Chọn khách hàng cần phân bổ thanh toán
- Hiển thị danh sách hóa đơn chưa thanh toán
- Phân bổ số tiền thanh toán vào từng hóa đơn
- Tự động phân bổ theo thứ tự ngày hóa đơn

## 3. Business Logic

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

## 4. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asARGetMaCT | Lấy danh sách chứng từ |
| asARGetPost2TT_ARTT | Lấy dữ liệu thanh toán |
| asARGetPost2TT | Lấy chi tiết thanh toán |
| asARInsPost2TT_ARTT | Thêm phân bổ thanh toán |
| asARDelPost2TT_ARTT | Xóa phân bổ thanh toán |

## 5. Dependencies

- `AsiaErp.Framework`
- `System.Data`
- `System.Windows.Forms`

## 6. Ghi chú

- Chức năng quan trọng để cập nhật trạng thái thanh toán của hóa đơn
- Ảnh hưởng trực tiếp đến số dư công nợ khách hàng
