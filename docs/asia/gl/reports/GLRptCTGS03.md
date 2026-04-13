# GLRptCTGS03 - Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào theo tài khoản

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã báo cáo | CTGS03 |
| Tên báo cáo | Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào theo tài khoản |
| Assembly | GLRptCTGS03.dll |
| Namespace | AsiaErp.UserInterface |
| Form chính | frmGLRptCTGS03 |
| Kế thừa | frmReport |

## Mục đích

Báo cáo bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào theo tài khoản kế toán cụ thể.

## Chức năng

### 1. Lọc và hiển thị báo cáo theo TK
- Lọc theo tài khoản kế toán cụ thể (bắt buộc)
- Lọc theo khoảng ngày báo cáo
- Chọn kỳ báo cáo
- Chọn mẫu báo cáo in
- Hỗ trợ đa ngoại tệ (VND hoặc ngoại tệ)

### 2. Xem và in ấn
- Hiển thị dữ liệu trên DataGridView
- In báo cáo qua Crystal Report
- Xuất Excel

### 3. Drill-down (F7)
- Xem chi tiết chứng từ theo lô và tài khoản
- Tham số drill-down: ngày lô, số lô, tài khoản, tài khoản đối ứng
- Filter condition: số lô - diễn giải

## Controls trên form

| Control | Type | Mô tả |
|---------|------|-------|
| txtTk | AsTextBox | Nhập tài khoản cần báo cáo |
| lblTk | Label | Nhãn "Tài khoản" |
| lblTen_tk | Label | Hiển thị tên tài khoản (lookup) |
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Khoảng ngày báo cáo |
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND, optNt | RadioButton | Chọn loại tiền (VND/Ngoại tệ) |

## Tham số báo cáo

| Tham số | Ý nghĩa |
|---------|---------|
| CompanyID | Mã công ty |
| txtTk | Tài khoản cần báo cáo (bắt buộc) |
| txtNgay1, txtNgay2 | Khoảng ngày báo cáo |
| txtMa_Nt | Mã ngoại tệ |

## Validation

- Tài khoản là bắt buộc - nếu để trống sẽ báo lỗi 50002
- txtTk có AutoLookup=true, LookupCodeName="TK"
- lblTen_tk là NameControl hiển thị tên TK khi lookup

## Methods chính

| Method | Mô tả |
|--------|-------|
| LoadData() | Lấy dữ liệu báo cáo với tham số: CompanyID, TK, ngày từ/đến, mã ngoại tệ |
| InitOtherComponents() | Khởi tạo components, select vào cboKyBc |
| CreateDrilldownArgument() | Tạo tham số drilldown khi F7 - chi tiết theo lô và TK |

## Dependencies

- Microsoft.VisualBasic
- System.Data
- System.Windows.Forms
- Framework (AsiaErp.Framework)

## Ghi chú

- Kế thừa từ frmReport - form báo cáo chuẩn của Asia ERP
- Sử dụng DataBinding với DataTable
- Validate: tài khoản không được để trống
