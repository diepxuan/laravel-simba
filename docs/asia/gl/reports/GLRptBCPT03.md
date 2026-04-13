# GLRptBCPT03 - Bảng cân đối kế toán theo kỳ

## Mô tả

Module báo cáo hiển thị bảng cân đối kế toán (Balance Sheet) theo kỳ, hỗ trợ so sánh số liệu giữa các kỳ.

## Chức năng chính

### 1. Báo cáo cân đối kế toán
- Hiển thị bảng cân đối kế toán theo kỳ
- So sánh số liệu giữa các kỳ
- Hỗ trợ xem theo tháng và số kỳ so sánh

### 2. Phân tích theo kỳ
- Chọn loại báo cáo (cboLoai_bc)
- Chọn tháng báo cáo
- Chọn số kỳ để so sánh
- Xem xu hướng biến động qua các kỳ

### 3. Lọc dữ liệu
- Lọc theo mã ngoại tệ
- Lựa chọn mẫu báo cáo
- Lựa chọn loại tiền tệ (VND/Ngoại tệ)

## Tham số báo cáo

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| cboLoai_bc | ComboBox | Loại báo cáo |
| txtMonth | AsTextNumeric | Tháng |
| txtSo_ky | AsTextNumeric | Số kỳ |
| cboMau_bc | ComboBox | Mẫu báo cáo |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND, optNt | RadioButton | Lựa chọn tiền tệ |
| txtTieu_De | TextBox | Tiêu đề báo cáo |

## Cột báo cáo

| Cột | Ý nghĩa |
|-----|---------|
| Chỉ tiêu | Tên chỉ tiêu |
| Mã số | Mã số chỉ tiêu |
| Tháng hiện tại | Số liệu tháng hiện tại |
| Kỳ trước | Số liệu kỳ trước |
| Chênh lệch | Chênh lệch giữa các kỳ |
| % | Tỷ lệ % thay đổi |

## Tham số truy vấn (Stored Procedure)

```csharp
ArrayList params = new ArrayList();
params.Add(CompanyInformations.CompanyID);  // Mã công ty
params.Add(txtMonth.Value);                 // Tháng
params.Add(txtSo_ky.Value);                 // Số kỳ
params.Add(cboLoai_bc.SelectedValue);       // Loại báo cáo
params.Add(txtMa_Nt.Text);                  // Mã ngoại tệ
```

## Events

| Event | Mục đích |
|-------|----------|
| cboLoai_bc_SelectedIndexChanged | Xử lý khi thay đổi loại báo cáo |

## Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Base form báo cáo của Asia ERP
- Sử dụng `ArrayList` để truyền tham số cho stored procedure
- Các trường ngày ẩn (Visible = false) - sử dụng tháng/kỳ thay thế
- Event `cboLoai_bc_SelectedIndexChanged` để xử lý thay đổi loại báo cáo

## Dependencies

- AsiaErp.Framework
- System.Data
- System.Drawing
- System.Windows.Forms
- Microsoft.VisualBasic
