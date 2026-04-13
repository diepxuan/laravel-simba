# GLRptBCTCCDTF03A - Báo cáo tài chính chi tiết F03A

## Mô tả

Module báo cáo hiển thị báo cáo tài chính chi tiết theo mẫu F03A - chuyên dụng cho ngành xây dựng.

## Chức năng chính

### 1. Báo cáo chi tiết F03A
- Hiển thị báo cáo tài chính chi tiết theo mẫu F03A
- Phân loại TK xây dựng theo nhiều loại tài khoản

### 2. Phân loại TK xây dựng
Hỗ trợ nhập nhiều loại tài khoản liên quan đến xây dựng:
- Xây lắp
- Thiết bị
- Bồi thường
- Quản lý dự án
- Tư vấn
- Khác

### 3. Lọc theo SPCT
- Cho phép lọc theo mã sản phẩm chi tiết
- Hỗ trợ kỳ báo cáo tùy chọn

### 4. Tham số từ menu
- Nhận 6 tham số tài khoản từ menu gọi (par1 đến par6)
- Cho phép chọn nhiều tài khoản đồng thời
- Tự động hiển thị tên tài khoản khi chọn mã

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
| txtMa_Nt | AsTextBox | Mã ngoại tệ (ẩn) |
| optVND, optNt | RadioButton | Tùy chọn tiền tệ (ẩn) |
| txtTieu_De | TextBox | Tiêu đề báo cáo |

## Tham số truy vấn (Stored Procedure)

```csharp
ArrayList params = new ArrayList();
params.Add(CompanyInformations.CompanyID);  // Mã công ty
params.Add(txtNgay1.Value);                 // Ngày bắt đầu
params.Add(txtNgay2.Value);                 // Ngày kết thúc
params.Add(txtTk_xaylap.Text);              // TK xây lắp
params.Add(txtTk_Thietbi.Text);             // TK thiết bị
params.Add(txtTk_boithuong.Text);           // TK bồi thường
params.Add(txtTk_QLDA.Text);                // TK QLDA
params.Add(txtTk_TuVan.Text);               // TK tư vấn
params.Add(txtTk_Khac.Text);                // TK khác
params.Add(txtMa_SPCT.Text);                // Mã SPCT
```

## Business Logic

### InitOtherComponents
Khởi tạo giá trị mặc định từ menu:
- `txtTk_xaylap.Text = MyMenuInfo.par1`
- `txtTk_Thietbi.Text = MyMenuInfo.par2`
- `txtTk_boithuong.Text = MyMenuInfo.par3`
- `txtTk_QLDA.Text = MyMenuInfo.par4`
- `txtTk_TuVan.Text = MyMenuInfo.par5`
- `txtTk_Khac.Text = MyMenuInfo.par6`

### LoadData
Phương thức `LoadData` thực hiện:
