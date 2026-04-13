# ARRptBCCN05.dll - Báo cáo đối chiếu công nợ

## Tổng quan

DLL báo cáo đối chiếu công nợ (Accounts Receivable Reconciliation Report). Dùng để đối chiếu công nợ giữa sổ sách của công ty và xác nhận của khách hàng.

## Thông tin kỹ thuật

| Thuộc tính | Giá tị |
|------------|---------|
| Namespace | `AsiaErp.UserInterface` |
| Assembly | `Asia Enterprise` |
| Version | `9.1.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © AsiaSoft 2010` |
| Title | `Sổ chi tiết công nợ một khách hàng` |

## Forms chính

### frmARRptBCCN05
- **Kế thừa**: `frmReport`
- **Mô tả**: Form báo cáo đối chiếu công nợ
- **Chức năng**:
  - In giấy đối chiếu công nợ gửi khách hàng
  - Hiển thị chi tiết phát sinh
  - Có thông tin xác nhận của khách hàng

## Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Tk | `AsTextBox` | Mã tài khoản |
| txtMa_Kh | `AsTextBox` | Mã khách hàng |
| txtNgay1 | `AsMaskedTextBox` | Từ ngày |
| txtNgay2 | `AsMaskedTextBox` | Đến ngày |
| txtNgay_lp | `AsMaskedTextBox` | Ngày lập đối chiếu |

## Cấu trúc báo cáo đối chiếu

### Thông tin chung
- Tên công ty
- Địa chỉ, điện thoại
- Tên khách hàng
- Địa chỉ khách hàng
- Ngày lập đối chiếu

### Chi tiết công nợ
| Cột | Mô tả |
|-----|-------|
| ngay_ct | Ngày chứng từ |
| so_ct | Số chứng từ |
| dien_giai | Diễn giải |
| ps_no | Phát sinh nợ |
| ps_co | Phát sinh có |
| du_cuoi | Số dư cuối |

### Phần xác nhận
- Chữ ký xác nhận của khách hàng
- Ngày xác nhận
- Ý kiến của khách hàng (nếu có)

## Business Logic

### Đối chiếu
1. Lấy số dư đầu kỳ
2. Liệt kê tất cả chứng từ phát sinh
3. Tính số dư cuối kỳ
4. In giấy đối chiếu gửi khách hàng

### Xử lý chênh lệch
- Nếu khách hàng không xác nhận, cần kiểm tra lại
- So sánh với sổ sách của khách hàng
- Tìm nguyên nhân chênh lệch (nếu có)

## Dependencies

- `AsiaErp.Framework`
- `CrystalDecisions.Windows.Forms`

## Ghi chú

- Báo cáo quan trọng cho việc đối chiếu công nợ định kỳ
- Thường được gửi hàng tháng/quý cho khách hàng
- Cần lưu trữ giấy xác nhận của khách hàng
