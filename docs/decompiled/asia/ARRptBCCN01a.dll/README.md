# ARRptBCCN01a.dll - Báo cáo công nợ Excel nâng cao

## Tổng quan

DLL báo cáo công nợ Excel nâng cao (Advanced Accounts Receivable Excel Report). Cung cấp báo cáo công nợ định dạng Excel với nhiều tùy chọn và định dạng phong phú.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaErp.UserInterface` |
| Assembly | `Asia Enterprise` |
| Version | `9.1.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © AsiaSoft 2010` |
| Title | `Sổ chi tiết công nợ (Excel nâng cao)` |

## Forms chính

### frmARRptBCCN01a
- **Kế thừa**: `frmReport`
- **Mô tả**: Form báo cáo công nợ Excel nâng cao
- **Chức năng**:
  - Báo cáo công nợ định dạng Excel
  - Nhiều mẫu báo cáo tùy chọn
  - Tùy chỉnh cột hiển thị
  - Định dạng theo yêu cầu

## Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Tk | `AsTextBox` | Mã tài khoản |
| txtMa_Kh | `AsTextBox` | Mã khách hàng |
| txtNgay1 | `AsMaskedTextBox` | Từ ngày |
| txtNgay2 | `AsMaskedTextBox` | Đến ngày |
| cboMau_bc | `ComboBox` | Mẫu báo cáo Excel |
| cmdExcel | `Button` | Xuất Excel |

## Tính năng Excel

### Định dạng
- Header tùy chỉnh
- Màu sắc, font chữ theo mẫu
- Căn chỉnh, độ rộng cột tự động
- Công thức tính toán trong Excel

### Dữ liệu
- Số dư đầu kỳ
- Chi tiết phát sinh
- Số dư cuối kỳ
- Thông tin khách hàng đầy đủ

## Dependencies

- `AsiaErp.Framework`
- `Microsoft.Office.Interop.Excel` (hoặc tương tự)
- `System.Data`

## Ghi chú

- Yêu cầu cài đặt