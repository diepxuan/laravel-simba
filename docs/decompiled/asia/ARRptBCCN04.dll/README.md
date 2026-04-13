# ARRptBCCN04.dll - Báo cáo công nợ nhóm và chi tiết

## Tổng quan

DLL báo cáo công nợ theo nhóm khách hàng và chi tiết (Accounts Receivable Report by Group and Detail). Kết hợp giữa báo cáo tổng hợp theo nhóm và chi tiết từng khách hàng.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaErp.UserInterface` |
| Assembly | `Asia Enterprise` |
| Version | `9.1.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © AsiaSoft 2010` |

## Forms chính

### frmARRptBCCN04
- **Kế thừa**: `frmReport`
- **Mô tả**: Form báo cáo công nợ nhóm và chi tiết
- **Chức năng**:
  - Hiển thị tổng hợp theo nhóm khách hàng
  - Chi tiết từng khách hàng trong nhóm
  - Drill-down từ nhóm xuống chi tiết

## Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_NhKh | `AsTextBox` | Mã nhóm khách hàng |
| txtMa_Kh | `AsTextBox` | Mã khách hàng |
| txtNgay1 | `AsMaskedTextBox` | Từ ngày |
| txtNgay2 | `AsMaskedTextBox` | Đến ngày |
| cboKyBc | `ComboBox` | Kỳ báo cáo |

## Cấu trúc báo cáo

### Tổng hợp nhóm
| Cột | Mô tả |
|-----|-------|
| ma_nhkh | Mã nhóm KH |
| ten_nhkh | Tên nhóm |
| du_dk | Số dư đầu kỳ |
| ps_no | Phát sinh nợ |
| ps_co | Phát sinh có |
| du_ck | Số dư cuối kỳ |

### Chi tiết khách hàng
| Cột | Mô tả |
|-----|-------|
| ma_kh | Mã khách hàng |
| ten_kh | Tên khách hàng |
| du_dk | Số dư đầu kỳ |
| ps_no | Phát sinh nợ |
| ps_co | Phát sinh có |
| du_ck | Số dư cuối kỳ |

## Business Logic

### Cấu trúc báo cáo
1. Hiển thị tổng hợp theo nhóm
2. Dưới mỗi nhóm liệt kê chi tiết khách hàng
3. Có dòng tổng cộng cho mỗi nhóm
4. Dòng tổng cộng chung ở cuối báo cáo

## Dependencies

- `AsiaErp.Framework`
- `System.Data`
- `CrystalDecisions.Windows.Forms`

## Ghi chú

- Kết hợp ưu điểm của báo cáo tổng hợp và chi tiết
- Phù hợp cho việc quản lý công nợ theo nhóm
- Dễ dàng theo dõi công nợ từng khách trong nhóm
