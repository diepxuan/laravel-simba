# GLRptCTGS02 - Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã báo cáo | CTGS02 |
| Tên báo cáo | Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào |
| Assembly | GLRptCTGS02.dll |
| Namespace | AsiaErp.UserInterface |
| Form chính | frmGLRptCTGS02 |
| Kế thừa | frmReport |

## Mục đích

Báo cáo bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào theo Thông tư 39/2014/TT-BTC, hỗ trợ lọc theo khoảng số chứng từ.

## Chức năng

### 1. Lọc và hiển thị báo cáo
- Lọc theo khoảng ngày báo cáo
- Lọc theo khoảng số chứng từ (từ số - đến số)
- Chọn kỳ báo cáo
- Chọn mẫu báo cáo in
- Hỗ trợ đa ngoại tệ (VND hoặc ngoại tệ)

### 2. Xem và in ấn
- Hiển thị dữ liệu trên DataGridView
- Cho phép đánh dấu (TAG=1) các dòng cần in
- In báo cáo qua Crystal Report
- Xuất Excel

### 3. Drill-down (F7)
- Xem chi tiết theo lô chứng từ
- Tham số drill-down: ngày lô, số lô
- Filter condition: số lô - diễn giải

## Controls trên form

| Control | Type | Mô tả |
|---------|------|-------|
| txtTu_so | AsTextBox | Nhập số chứng từ từ |
| txtDen_so | AsTextBox | Nhập số chứng từ đến |
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Khoảng ngày báo cáo |
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND, optNt | RadioButton | Chọn loại tiền (VND/Ngoại tệ) |

## Tham số báo cáo

| Tham số | Ý nghĩa |
|---------|---------|
| CompanyID | Mã công ty |
| txtNgay1, txtNgay2 | Khoảng ngày báo cáo |
| txtTu_so, txtDen_so | Khoảng số chứng từ |
| txtMa_Nt | Mã ngoại tệ |
| TAG=1 | Lọc các dòng được đánh dấu để in |

## Methods chính

| Method | Mô tả |
|--------|-------|
| LoadData() | Lấy dữ liệu báo cáo từ server |
| FormatGridView() | Định dạng DataGridView, set readonly cho các cột |
| dgvBC_CellEnter() | Xử lý sự kiện khi enter vào cell, cho phép edit cột "tag" |
| CreateDrilldownArgument() | Tạo tham số drilldown khi F7 |
| LoadDataToCrystal() | Load dữ liệu vào Crystal Report |
| ViewCrystalBySource() | Xem báo cáo Crystal với dữ liệu đã chọn |

## Dependencies

- Microsoft.VisualBasic
- System.Data
- System.Windows.Forms
- Framework (AsiaErp.Framework)

## Ghi chú

- Kế thừa từ frmReport base class
- Sử dụng DataBinding với DataTable
- Validate: phải chọn mẫu báo cáo trước khi load dữ liệu
- Cột "tag" cho phép người dùng đánh dấu các dòng cần in
