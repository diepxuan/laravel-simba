# GLRptBCTCCDTF03C - Báo cáo tài chính chi tiết F03C

## Mô tả

Module báo cáo hiển thị báo cáo tài chính chi tiết theo mẫu F03C.

## Chức năng chính

### 1. Báo cáo tài chính chi tiết F03C
- Báo cáo chi tiết theo tài khoản
- Lọc theo kỳ báo cáo
- Hiển thị thông tin tài khoản được chọn

### 2. Tham số hóa báo cáo
- Nhận tham số từ menu thông qua MyMenuInfo.par1
- Cho phép chọn một tài khoản cụ thể
- Tự động hiển thị tên tài khoản khi chọn mã

### 3. Xuất dữ liệu
- Hỗ trợ xuất Excel
- In ấn báo cáo
- Tùy chỉnh tiêu đề báo cáo

## Tham số báo cáo

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| txtTk | AsTextBox | Tài khoản lọc báo cáo |
| lblTen_Tk | Label | Hiển thị tên tài khoản |
| lblTk | Label | Nhãn "Tài khoản" |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Từ ngày, đến ngày |
| cboKyBc | ComboBox | Kỳ báo cáo |
| cboMau_bc | ComboBox | Mẫu báo cáo |

## Thuật ngữ kỹ thuật

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `txtTk` | TextBox nhập mã tài khoản |
| `LookupCodeName = "TK"` | Mã lookup cho danh mục tài khoản |
| `AutoLookup = true` | Tự động tìm kiếm khi nhập |

## Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của framework
- Sử dụng `AsTextBox` với AutoLookup cho tài khoản
- DataBinding với DataTable
- Form đơn giản, tập trung vào một tham số tài khoản

## Dependencies

- AsiaErp.Framework
- AsiaErp.DataAccess
- System.Data
- System.Windows.Forms
- Microsoft.VisualBasic
