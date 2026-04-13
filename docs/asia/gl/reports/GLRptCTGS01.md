# GLRptCTGS01 - Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã báo cáo | CTGS01 |
| Tên báo cáo | Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào |
| Assembly | GLRptCTGS01.dll |
| Namespace | AsiaErp.UserInterface |
| Form chính | frmGLRptCTGS01 |
| Kế thừa | frmReport |

## Mục đích

Báo cáo bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ mua vào phục vụ cho việc kê khai thuế GTGT đầu vào và quản lý chứng từ mua vào theo kỳ.

## Chức năng

### 1. Lọc và hiển thị báo cáo
- Chọn kỳ báo cáo (tháng/quý/năm)
- Lọc theo khoảng ngày báo cáo
- Chọn mẫu báo cáo in
- Hỗ trợ đa ngoại tệ (VND hoặc ngoại tệ)

### 2. Xem và in ấn
- Hiển thị dữ liệu trên DataGridView
- In báo cáo qua Crystal Report
- Xuất Excel

### 3. Drill-down (F5)
- Xem chi tiết theo lô chứng từ
- Tham số drill-down: ngày lô, số lô
- Filter condition: số lô + diễn giải

## Controls trên form

| Control | Type | Mô tả |
|---------|------|-------|
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Ngày bắt đầu/kết thúc |
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND, optNt | RadioButton | Tùy chọn tiền tệ |
| cmdOk | Button | Xem báo cáo |
| cmdModifyReport | Button | Sửa mẫu báo cáo |
| cmdCancel | Button | Hủy |
| cmdExcel | Button | Xuất Excel |

## Tham số báo cáo

| Tham số | Ý nghĩa |
|---------|---------|
| CompanyID | Mã công ty |
| txtNgay1 | Ngày bắt đầu |
| txtNgay2 | Ngày kết thúc |
| txtMa_Nt | Mã ngoại tệ |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| ngay_lo | Ngày lô chứng từ |
| so_lo | Số lô chứng từ |
| dien_giai | Diễn giải |

## Dependencies

- Microsoft.VisualBasic
- System.Data
- Framework (AsiaErp.Framework)
- Helper (AsiaErp.Helper)

## Ghi chú

- Form đơn giản, ít filter
- Hỗ trợ drill-down theo lô chứng từ
- Hỗ trợ đa tiền tệ
- Phục vụ kê khai thuế GTGT đầu vào theo Thông tư 39/2014/TT-BTC
