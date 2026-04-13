# GLRptBCTCCDTF02 - Báo cáo tài chính chi tiết F02

## Mô tả

Module báo cáo hiển thị báo cáo tài chính chi tiết theo mẫu F02.

## Chức năng chính

### 1. Báo cáo chi tiết F02
- Hiển thị báo cáo tài chính chi tiết theo mẫu F02
- Lọc theo tài khoản cụ thể
- Lọc theo mã sản phẩm chi tiết (SPCT)

### 2. Tham số từ menu
- Nhận tham số tài khoản từ menu gọi (MyMenuInfo.par1)
- Cho phép chọn nhiều tài khoản đồng thời
- Tự động hiển thị tên tài khoản khi chọn mã

### 3. Xuất dữ liệu
- Hỗ trợ xuất Excel
- In ấn báo cáo
- Drill-down để xem chi tiết

## Tham số báo cáo

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| txtTk | AsTextBox | Tài khoản |
| lblTen_Tk | Label | Tên tài khoản |
| txtMa_SPCT | AsTextBox | Mã sản phẩm chi tiết |
| lblTen_Ma_SPCT | Label | Tên sản phẩm chi tiết |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Từ ngày, đến ngày |
| cboKyBc | ComboBox | Kỳ báo cáo |
| cboMau_bc | ComboBox | Mẫu báo cáo |
| txtMa_Nt | AsTextBox | Mã ngoại tệ (ẩn) |
| optVND, optNt | RadioButton | Tùy chọn tiền tệ (ẩn) |
| txtTieu_De | TextBox | Tiêu đề báo cáo |

## Tham số truy vấn (Stored Procedure)

```csharp
ArrayList params = new ArrayList();
params.Add(CompanyInformations.CompanyID);  // Mã công ty
params.Add(txtNgay1.Value);                 // Ngày bắt đầu
params.Add(txtNgay2.Value);                 // Ngày kết thúc
params.Add(txtTk.Text);                     // Tài khoản
params.Add(txtMa_SPCT.Text);                // Mã SPCT
```

## Business Logic

### InitOtherComponents
Khởi tạo giá trị mặc định:
- `txtTk.Text = MyMenuInfo.par1` (tài khoản từ menu)

### LoadData
Phương thức `LoadData` thực hiện:
1. Tạo ArrayList với các tham số
2. Gọi `base.MyController.GetData` để lấy dữ liệu
3. Thiết lập FilterTitle vào FomularFields

### GetFilterTitle
Tạo chuỗi tiêu đề lọc hiển thị trên báo cáo:
- Tài khoản (nếu có)

## Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Sử dụng tham số từ `MyMenuInfo` (par1)
- Hỗ trợ lọc theo sản phẩm chi tiết (SPCT)
- Ẩn các tùy chọn tiền tệ (chỉ hiển thị VND)

## Dependencies

- AsiaErp.Framework
- AsiaErp.Helper
- System.Data
- System.Windows.Forms
- Microsoft.VisualBasic.CompilerServices
