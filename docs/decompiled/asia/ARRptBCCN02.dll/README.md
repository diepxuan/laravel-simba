# ARRptBCCN02.dll - Báo cáo công nợ theo phân loại

## Tổng quan

DLL báo cáo công nợ theo phân loại khách hàng (Accounts Receivable Report by Classification). Tổng hợp công nợ theo các tiêu chí phân loại khách hàng.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaErp.UserInterface` |
| Assembly | `Asia Enterprise` |
| Version | `9.1.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © AsiaSoft 2010` |

## Forms chính

### frmARRptBCCN02
- **Kế thừa**: `frmReport`
- **Mô tả**: Form báo cáo công nợ theo phân loại
- **Chức năng**:
  - Báo cáo công nợ theo phân loại khách hàng (PL1, PL2, PL3)
  - Tổng hợp theo nhóm phân loại
  - So sánh công nợ giữa các nhóm

## Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_plkh1 | `AsTextBox` | Phân loại KH 1 |
| txtMa_plkh2 | `AsTextBox` | Phân loại KH 2 |
| txtMa_plkh3 | `AsTextBox` | Phân loại KH 3 |
| txtNgay1 | `AsMaskedTextBox` | Từ ngày |
| txtNgay2 | `AsMaskedTextBox` | Đến ngày |
| cboKyBc | `ComboBox` | Kỳ báo cáo |

## Cấu trúc báo cáo

| Cột | Mô tả |
|-----|-------|
| ma_plkh | Mã phân loại |
| ten_plkh | Tên phân loại |
| du_dk | Số dư đầu kỳ |
| ps_no | Phát sinh nợ |
| ps_co | Phát sinh có |
| du_ck | Số dư cuối kỳ |

## Business Logic

### Phân loại
- Phân loại 1: Theo ngành nghề, lĩnh vực
- Phân loại 2: Theo khu vực địa lý
- Phân loại 3: Theo mức độ quan trọng

### Tổng hợp
- Nhóm khách hàng theo phân loại
- Tính tổng công nợ theo từng nhóm
- So sánh tỷ trọng giữa các nhóm

## Dependencies

- `AsiaErp.Framework`
- `System.Data`
- `CrystalDecisions.Windows.Forms`

## Ghi chú

- Hỗ trợ phân tích công nợ theo nhiều chiều
- Có thể kết hợp nhiều tiêu chí phân loại
- Phù hợp cho báo cáo quản trị
