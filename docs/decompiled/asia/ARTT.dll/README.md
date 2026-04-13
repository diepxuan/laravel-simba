# ARTT.dll - Điều khoản thanh toán

## Tổng quan

DLL quản lý điều khoản thanh toán (Payment Terms). Quản lý các điều khoản thanh toán như hạn thanh toán, chiết khấu, lãi quá hạn.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaERP.UserInterface` |
| Assembly | `ARTT` |
| Version | `1.0.0.0` |
| Company | `ASIA` |
| Copyright | `Copyright © ASIA 2010` |
| Title | `Số dư đầu kỳ của các hóa đơn phải thu` |

## Forms chính

### frmARTT
- **Kế thừa**: `frmOBView`
- **Mô tả**: Form xem điều khoản thanh toán
- **Chức năng**:
  - Hiển thị danh sách điều khoản thanh toán
  - Quản lý số dư đầu kỳ hóa đơn

### frmARTTEdit
- **Kế thừa**: `frmOBEdit`
- **Mô tả**: Form thêm/sửa điều khoản thanh toán
- **Chức năng**:
  - Nhập thông tin hóa đơn đầu kỳ
  - Nhập thông tin thanh toán
  - Tính toán số dư còn phải thu

## Cấu trúc dữ liệu

| Trường | Mô tả |
|--------|-------|
| ma_tt | Mã điều khoản thanh toán |
| ten_tt | Tên điều khoản |
| han_tt | Hạn thanh toán (ngày) |
| han_ck | Hạn chiết khấu (ngày) |
| tl_ck | Tỷ lệ chiết khấu (%) |
| ls_qh | Lãi suất quá hạn (%) |

## Controls chính (frmARTTEdit)

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_kh | `AsTextBox` | Mã khách hàng |
| txtTK_pt | `AsTextBox` | TK phải thu |
| txtMa_hd | `AsTextBox` | Mã hợp đồng |
| txtMa_tt | `AsTextBox` | Mã thanh toán |
| txtNgay_ct | `AsMaskedTextBox` | Ngày chứng từ |
| txtSo_ct | `TextBox` | Số chứng từ |
| txtTien_hang_nt | `AsTextNumeric` | Tiền hàng NT |
| txtTien_thue_nt | `AsTextNumeric` | Tiền thuế NT |
| txtTong_tt_nt | `AsTextNumeric` | Tổng thanh toán NT |
| txtTien_tt_nt | `AsTextNumeric` | Đã thanh toán NT |
| txtDu_hd_nt | `AsTextNumeric` | Còn phải thanh toán NT |
| cboNgoai_te | `AsComboBoxNT` | Ngoại tệ |
| txtTy_gia | `AsTextNumeric` | Tỷ giá |

## Business Logic

### Tính toán
- Tổng thanh toán = Tiền hàng + Tiền thuế
- Số dư còn phải thu = Tổng thanh toán - Đã thanh toán

### Tự động cập nhật
```csharp
// Khi chọn mã thanh toán
txtHan_tt.Value = e.ValidatedRow["han_tt"];
txtHan_ck.Value = e.ValidatedRow["han_ck"];
txtLS_qh.Value = e.ValidatedRow["ls_qh"];
txtTL_ck.Value = e.ValidatedRow["tl_ck"];

// Tính ngày thanh toán
txtngay_tt.Value = ngay_ct.AddDays(Conversions.ToDouble(txtHan_tt.Value));
```

### Đa tiền tệ
- Hỗ trợ nhập liệu VND và ngoại tệ
- Tự động quy đổi theo tỷ giá
- Kiểm tra cảnh báo điều chỉnh

## Dependencies

- `AsiaErp.Framework`
- `Microsoft.VisualBasic`
- `System.Data`

## Ghi chú

- Quản lý số dư đầu kỳ các hóa đơn phải thu
- Tích hợp thông tin thanh toán và hợp đồng
- Hỗ trợ đa tiền tệ với kiểm soát chặt chẽ
