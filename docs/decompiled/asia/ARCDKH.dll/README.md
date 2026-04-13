# ARCDKH.dll - Công nợ khách hàng

## Tổng quan

DLL quản lý công nợ khách hàng (Accounts Receivable Customer Debt) trong module AR. Cung cấp giao diện xem và quản lý các khoản công nợ phải thu từ khách hàng.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaERP.UserInterface` |
| Assembly | `Asia Enterprise` |
| Version | `9.1.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © AsiaSoft 2010` |

## Forms chính

### frmARCDKH
- **Kế thừa**: `frmReport`
- **Mô tả**: Form báo cáo công nợ khách hàng
- **Chức năng**: 
  - Xem danh sách công nợ theo khách hàng
  - Lọc theo kỳ báo cáo, mã khách hàng, tài khoản
  - Hỗ trợ xuất Excel và in báo cáo Crystal Report

### frmARCDKHEdit
- **Kế thừa**: Không xác định (form chỉnh sửa)
- **Mô tả**: Form chỉnh sửa thông tin công nợ

### frmARCDKHFilter
- **Kế thừa**: Không xác định (form lọc)
- **Mô tả**: Form lọc dữ liệu công nợ

## Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Kh | `AsTextBox` | Mã khách hàng |
| txtMa_Tk | `AsTextBox` | Mã tài khoản công nợ |
| txtNgay1/txtNgay2 | `AsMaskedTextBox` | Từ ngày/Đến ngày |
| cboKyBc | `ComboBox` | Kỳ báo cáo |
| crvReportViewer | `CrystalReportViewer` | Xem báo cáo Crystal |

## Business Logic

### Lọc dữ liệu
- Lọc theo khoảng thời gian (từ ngày - đến ngày)
- Lọc theo mã khách hàng
- Lọc theo tài khoản công nợ (tk_cn=1)
- Lọc theo loại tiền tệ (VND/Ngoại tệ)

### Báo cáo
- Sử dụng Crystal Report để hiển thị báo cáo
- Hỗ trợ xuất Excel
- Drill-down để xem chi tiết

## Dependencies

- `AsiaErp.Framework` - Framework lõi
- `CrystalDecisions.Windows.Forms` - Crystal Report
- `Microsoft.VisualBasic`

## Ghi chú

- Form kế thừa từ `frmReport` nên có đầy đủ chức năng báo cáo chuẩn
- Sử dụng `AsTextBox` với AutoLookup cho các trường mã (khách hàng, tài khoản)
- Hỗ trợ đa tiền tệ (VND và ngoại tệ)
