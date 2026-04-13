# GLRptBCTCCDTF03B - Báo cáo tài chính chi tiết F03B

## Mô tả

Module báo cáo hiển thị báo cáo tài chính chi tiết theo mẫu F03B.

## Chức năng chính

### 1. Báo cáo tài chính chi tiết F03B
- Báo cáo chi tiết theo các tài khoản: xây lắp, thiết bị, bồi thường, quản lý dự án, tư vấn, khác
- Lọc theo mã sản phẩm chi tiết (SPCT)
- Hỗ trợ kỳ báo cáo tùy chọn

### 2. Tham số hóa báo cáo
- Nhận tham số từ menu thông qua MyMenuInfo.par1-par6
- Cho phép chọn nhiều tài khoản đồng thời
- Tự động hiển thị tên tài khoản khi chọn mã

### 3. Xuất dữ liệu
- Hỗ trợ xuất Excel
- In ấn báo cáo
- Drill-down để xem chi tiết

## Tham số báo cáo

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| txtTk_xaylap | AsTextBox | Tài khoản xây lắp |
| txtTk_Thietbi | AsTextBox | Tài khoản thiết bị |
| txtTk_boithuong | AsTextBox | Tài khoản bồi thường |
| txtTk_QLDA | AsTextBox | Tài khoản quản lý dự án |
| txtTk_TuVan | AsTextBox | Tài khoản tư vấn |
| txtTk_Khac | AsTextBox | Tài khoản khác |
| txtMa_SPCT | AsTextBox | Mã sản phẩm chi tiết |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Từ ngày, đến ngày |
| cboKyBc | ComboBox | Kỳ báo cáo |
| cboMau_bc | ComboBox | Mẫu báo cáo |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk_xaylap` | Tài khoản xây lắp |
| `tk_thietbi` | Tài khoản thiết bị |
| `tk_boithuong` | Tài khoản bồi thường |
| `tk_qlda` | Tài khoản quản lý dự án |
| `tk_tuvan` | Tài khoản tư vấn |
| `tk_khac` | Tài khoản khác |
| `ma_spct` | Mã sản phẩm chi tiết |

## Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của framework
- Sử dụng `AsTextBox` với AutoLookup cho tài khoản
- DataBinding với DataTable
- Hỗ trợ đa tiền tệ (ẩn theo mặc định)

## Dependencies

- AsiaErp.Framework
- AsiaErp.DataAccess
- System.Data
- System.Windows.Forms
- Microsoft.VisualBasic
