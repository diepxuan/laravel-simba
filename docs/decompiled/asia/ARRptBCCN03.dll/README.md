# ARRptBCCN03.dll - Báo cáo công nợ tổng hợp phân loại

## Tổng quan

DLL báo cáo công nợ tổng hợp theo phân loại (Accounts Receivable Summary Report by Classification). Tổng hợp công nợ theo phân loại khách hàng ở cấp độ tổng hợp.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaErp.UserInterface` |
| Assembly | `Asia Enterprise` |
| Version | `9.1.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © AsiaSoft 2010` |

## Forms chính

### frmARRptBCCN03
- **Kế thừa**: `frmReport`
- **Mô tả**: Form báo cáo công nợ tổng hợp phân loại
- **Chức năng**:
  - Báo cáo tổng hợp công nợ theo phân loại
  - Không hiển thị chi tiết từng khách hàng
  - Chỉ hiển thị tổng số theo nhóm phân loại

## Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_plkh1 | `AsTextBox` | Phân loại KH 1 |
| txtMa_plkh2 | `AsTextBox` | Phân loại KH 2 |
| txtMa_plkh3 | `AsTextBox` | Phân loại KH 3 |
| txtNgay1 | `AsMaskedTextBox` | Từ ngày |
| txtNgay2 | `AsMaskedTextBox` | Đến ngày |

## Cấu trúc báo cáo

| Cột | Mô tả |
|-----|-------|
| ma_plkh | Mã phân loại |
| ten_plkh | Tên phân loại |
| so_luong_kh | Số lượng khách hàng |
| tong_du_dk | Tổng số dư đầu kỳ |
| tong_ps_no | Tổng phát sinh nợ |
| tong_ps_co | Tổng phát sinh có |
| tong_du_ck | Tổng số dư cuối kỳ |

## Business Logic

### Tổng hợp
- Nhóm tất cả khách hàng theo phân loại
- Tính tổng các chỉ tiêu công nợ
- Đếm số lượng khách hàng trong nhóm

## Dependencies

- `AsiaErp.Framework`
- `System.Data`

## Ghi chú

- Dạng báo cáo tổng hợp, không có chi tiết
- Phù hợp cho báo cáo quản trị cấp cao
- So sánh nhanh giữa các nhóm phân loại
