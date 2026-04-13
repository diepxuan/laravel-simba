# ARRptBCCN01.dll - Báo cáo công nợ theo TK và KH

## Tổng quan

DLL báo cáo công nợ theo tài khoản và khách hàng (Accounts Receivable Report by Account and Customer). Hiển thị số dư công nợ chi tiết theo từng tài khoản và khách hàng.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaErp.UserInterface` |
| Assembly | `Asia Enterprise` |
| Version | `9.1.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © AsiaSoft 2010` |
| Title | `Sổ chi tiết công nợ` |

## Forms chính

### frmARRptBCCN01
- **Kế thừa**: `frmReport`
- **Mô tả**: Form báo cáo công nợ theo TK và KH
- **Chức năng**:
  - Báo cáo sổ chi tiết công nợ
  - Lọc theo tài khoản, khách hàng, kỳ
  - Hiển thị số dư đầu kỳ, phát sinh, số dư cuối kỳ
  - Drill-down xem chi tiết chứng từ

## Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Tk | `AsTextBox` | Mã tài khoản |
| txtMa_Kh | `AsTextBox` | Mã khách hàng |
| txtNgay1 | `AsMaskedTextBox` | Từ ngày |
| txtNgay2 | `AsMaskedTextBox` | Đến ngày |
| cboKyBc | `ComboBox` | Kỳ báo cáo |
| cboMau_bc | `ComboBox` | Mẫu báo cáo |
| optVND/optNt | `RadioButton` | Loại tiền |
| dgvBC | `DataGridView` | Dữ liệu báo cáo |

## Cấu trúc báo cáo

| Cột | Mô tả |
|-----|-------|
| ma_kh | Mã khách hàng |
| ten_kh | Tên khách hàng |
| du_dk | Số dư đầu kỳ |
| ps_no | Phát sinh nợ |
| ps_co | Phát sinh có |
| du_ck | Số dư cuối kỳ |

## Business Logic

### Tính toán số dư
- Số dư đầu kỳ: Lấy từ số dư đầu kỳ theo tài khoản
- Phát sinh nợ: Tổng các bút toán nợ trong kỳ
- Phát sinh có: Tổng các bút toán có trong kỳ
- Số dư cuối kỳ = Đầu kỳ + Nợ - Có

### Drill-down
- F4: Xem chi tiết chứng từ phát sinh
- Hiển thị tất cả chứng từ liên quan đến khách hàng

## Dependencies

- `AsiaErp.Framework`
- `CrystalDecisions.Windows.Forms`
- `System.Data`

## Ghi chú

- Báo cáo chuẩn theo quy định kế toán
- Hỗ trợ xem theo VND hoặc ngoại tệ
- Có thể xuất Excel và in Crystal Report
