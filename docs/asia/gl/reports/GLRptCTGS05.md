# GLRptCTGS05 - Bảng kê chứng từ

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Mã báo cáo | CTGS05 |
| Tên báo cáo | Bảng kê chứng từ |
| Assembly | GLRptCTGS05.dll |
| Namespace | AsiaErp.UserInterface |
| Form chính | frmGLRptCTGS05 |
| Kế thừa | frmReport |

## Mục đích

Báo cáo bảng kê chứng từ với bộ lọc chi tiết đa chiều - báo cáo linh hoạt nhất trong nhóm CTGS.

## Chức năng

### 1. Lọc đa chiều
- **Thời gian**: ngày báo cáo, ngày lô, số lô
- **Chứng từ**: khoảng số chứng từ
- **Kế toán**: TK, TK đối ứng
- **Khách hàng**: mã KH, nhóm KH, phân loại KH 1/2/3
- **Đối tượng**: bộ phận, phí, hợp đồng, khế ước, SPCT, công trình
- **Nội dung**: diễn giải (autocomplete)
- Hỗ trợ đa ngoại tệ

### 2. Xử lý kỳ báo cáo
- cboNgay_lo: chọn loại kỳ (NGAY/THANG/QUY/NAM)
- Tự động điền ngày từ/đến khi chọn kỳ
- Cho phép nhập tay khi chọn "NGAY"

### 3. Xem và in ấn
- Hiển thị dữ liệu trên DataGridView
- Tạo filter title động từ các điều kiện đã chọn
- In báo cáo qua Crystal Report
- Xuất Excel

## Controls trên form

### Bộ lọc chứng từ

| Control | Type | Mô tả |
|---------|------|-------|
| txtSo_Ct1, txtSo_Ct2 | TextBox | Khoảng số chứng từ (từ - đến) |
| txtTk, lblTen_Tk | AsTextBox, Label | Tài khoản + tên TK (lookup) |
| txtTk_Du, lblTen_Tk_Du | AsTextBox, Label | Tài khoản đối ứng + tên (lookup) |
| txtMa_Kh, lblTen_Kh | AsTextBox, Label | Mã khách hàng + tên (lookup) |
| txtMa_NhKh, lblTen_NhKh | AsTextBox, Label | Nhóm khách hàng + tên (lookup) |

### Bộ lọc phân loại

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Plkh1, lblTen_Plkh1 | AsTextBox, Label | Phân loại KH 1 (loai='1') |
| txtMa_Plkh2, lblTen_Plkh2 | AsTextBox, Label | Phân loại KH 2 (loai='2') |
| txtMa_Plkh3, lblTen_Plkh3 | AsTextBox, Label | Phân loại KH 3 (loai='3') |

### Bộ lọc đối tượng khác

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Bp, lblTen_Bp | AsTextBox, Label | Mã bộ phận + tên (lookup) |
| txtMa_Phi, lblTen_Phi | AsTextBox, Label | Mã phí + tên (lookup) |
| txtMa_Hd, lblTen_Hd | AsTextBox, Label | Mã hợp đồng + tên (lookup) |
| txtMa_Ku, lblTen_Ku | AsTextBox, Label | Mã khế ước + tên (lookup) |
| txtMa_Spct, lblTen_Spct | AsTextBox, Label | Mã sản phẩm chi tiết + tên (lookup) |
| txtMa_Ct | AsTextBoxMulti | Mã công trình (multi-value) |
| txtDien_giai | TextBox | Lọc theo diễn giải (autocomplete) |

### Bộ lọc ngày lô

| Control | Type | Mô tả |
|---------|------|-------|
| cboNgay_lo | AsComboBox | Chọn kỳ ngày lô (NGAY/THANG/QUY/NAM) |
| txtNgay_lo1, txtNgay_lo2 | AsMaskedTextBox | Khoảng ngày lô (từ - đến) |
| txtSo_lo1, txtSo_lo2 | TextBox | Khoảng số lô (từ - đến) |

### Controls chuẩn

| Control | Type | Mô tả |
|---------|------|-------|
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Khoảng ngày báo cáo |
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND, optNt | RadioButton | Chọn loại tiền |

## Tham số báo cáo (24 tham số)

| STT | Tham số | Ý nghĩa |
|-----|---------|---------|
| 1 | CompanyID | Mã công ty |
| 2-3 | txtNgay1, txtNgay2 | Ngày báo cáo |
| 4-5 | txtNgay_lo1, txtNgay_lo2 | Ngày lô |
| 6 | txtMa_Ct | Mã công trình |
| 7 | txtTk | Tài khoản |
| 8 | txtTk_Du | Tài khoản đối ứng |
| 9 | txtMa_NhKh | Nhóm KH |
| 10-12 | txtMa_Plkh1/2/3 | Phân loại KH |
| 13 | txtMa_Kh | Mã KH |
| 14-15 | txtSo_Ct1, txtSo_Ct2 | Số chứng từ |
| 16-17 | txtSo_lo1, txtSo_lo2 | Số lô |
| 18 | txtMa_Nt | Ngoại tệ |
| 19 | txtMa_Hd | Hợp đồng |
| 20 | txtMa_Phi | Phí |
| 21 | txtDien_giai | Diễn giải |
| 22 | txtMa_Bp | Bộ phận |
| 23 | txtMa_Spct | SPCT |
| 24 | txtMa_Ku | Khế ước |

## Lookup codes

| Control | LookupCodeName | Where Condition |
|---------|---------------|-----------------|
| txtTk | TK | - |
| txtTk_Du | TK | - |
| txtMa_Kh | MA_KH | - |
| txtMa_NhKh | MA_NHKH | - |
| txtMa_Plkh1 | MA_PLKH | loai='1' |
| txtMa_Plkh2 | MA_PLKH | loai='2' |
| txtMa_Plkh3 | MA_PLKH | loai='3' |
| txtMa_Bp | MA_BP | - |
| txtMa_Phi | MA_PHI | - |
| txtMa_Hd | MA_HD | - |
| txtMa_Ku | MA_KU | - |
| txtMa_Spct | MA_SPCT | - |
| txtMa_Ct | MA_CT | - |

## Methods chính

| Method | Mô tả |
|--------|-------|
| InitOtherComponents() | Khởi tạo, gọi InitNgayLo() để load danh sách kỳ |
| InitNgayLo() | Load danh sách kỳ báo cáo từ Environment.GetKyBaoCao() |
| cboKyTruoc_SelectedValueChanged() | Xử lý thay đổi kỳ - tự động điền ngày từ/đến |
| LoadData() | Lấy dữ liệu với 24 tham số lọc |
| GetFilterTitle() | Tạo chuỗi tiêu đề lọc từ các điều kiện đã chọn |

## Dependencies

- Microsoft.VisualBasic
- System.Data
- System.Windows.Forms
- Framework (AsiaErp.Framework)

## Ghi chú

- Kế thừa từ frmReport - form báo cáo chuẩn của Asia ERP
- Sử dụng 24 tham số để lọc dữ liệu
- Hỗ trợ lookup tự động cho hầu hết các trường
- txtMa_Ct là AsTextBoxMulti - cho phép chọn nhiều công trình
- txtDien_giai có AutoCompleteMode=Suggest
- GetFilterTitle() tạo chuỗi mô tả điều kiện lọc đầy đủ
