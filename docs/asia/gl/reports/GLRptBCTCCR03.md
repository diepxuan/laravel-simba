# GLRptBCTCCR03 - Báo cáo kết quả hoạt động kinh doanh

## Mô tả

Module báo cáo hiển thị Báo cáo kết quả hoạt động kinh doanh (Income Statement) theo chuẩn mực kế toán Việt Nam.

## Chức năng chính

### 1. Báo cáo kết quả hoạt động kinh doanh
- Chọn kỳ báo cáo hiện tại và kỳ trước để so sánh
- Lọc theo bộ phận, ngoại tệ
- Hỗ trợ nhiều mẫu báo cáo khác nhau
- Xuất báo cáo ra Excel

### 2. Quản lý mẫu công thức
- Khai báo công thức tính toán cho từng chỉ tiêu
- Hỗ trợ hai chế độ tính:
  - Tính theo số dư tài khoản (nhập DSTK nợ/có)
  - Tính theo công thức (cộng/trừ các chỉ tiêu khác)
- Thiết lập in đậm, ẩn/hiện chỉ tiêu

### 3. Drill-down chi tiết
- Nhấn F5 để xem chi tiết chỉ tiêu
- Drill-down theo công thức: Hiển thị các chỉ tiêu tham gia tính toán
- Drill-down theo tài khoản: Xem sổ chi tiết TK nợ/có

## Tham số báo cáo

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| cboKyBc | ComboBox | Chọn kỳ báo cáo hiện tại |
| cboKyTruoc | ComboBox | Chọn kỳ báo cáo trước |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Ngày bắt đầu/kết thúc kỳ hiện tại |
| txtNgay01, txtNgay02 | AsMaskedTextBox | Ngày bắt đầu/kết thúc kỳ trước |
| txtMa_Bp | AsTextBox | Mã bộ phận lọc báo cáo |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| optVND, optNt | RadioButton | Tùy chọn đơn vị tiền tệ |
| cmdPL | Button | Mở form khai báo công thức |

## Forms liên quan

### frmGLMauPL01
Form quản lý danh mục mẫu biểu phụ lục 01.
- Kế thừa từ `frmDMView` (danh mục dạng view)
- Quản lý các mẫu công thức tính toán cho báo cáo
- Lọc theo mã mẫu (`ma_mau`) được truyền vào constructor

### frmGLMauPL01Edit
Form chỉnh sửa chi tiết mẫu biểu với các controls:
- txtStt: Số thứ tự
- txtMa_so: Mã số chỉ tiêu
- txtChi_tieu: Tên chỉ tiêu
- txtTm: Thuyết minh
- chkIn_ck: AsCheckBox - In/Không in
- chkBold: AsCheckBox - Đậm/Không đậm
- chkCach_tinh: AsCheckBox - Tính theo SD TK / Tính theo công thức
- txtDsTk_no: AsTextBox - Danh sách TK nợ
- txtDsTK_co: AsTextBox - Danh sách TK có
- chkgiam_tru: AsCheckBox - Tính/Không tính giảm trừ
- txtCach_tinh: TextBox - Công thức tính toán

## Chế độ tính toán

### 1. Tính theo số dư tài khoản
- Nhập danh sách TK nợ/có
- Tính số dư từ các tài khoản

### 2. Tính theo công thức
- Nhập công thức tính từ các chỉ tiêu khác
- Hỗ trợ các phép toán: +, -, *, /

## Events

| Event | Handler | Mô tả |
|-------|---------|-------|
| cboKyTruoc.SelectedValueChanged | cboKyTruoc_SelectedValueChanged | Tự động tính ngày kỳ trước |
| cmdPL.Click | cmdPL_Click | Mở form quản lý mẫu công thức |
| chkCach_tinh.Click | chkCach_tinh_Click | Chuyển đổi chế độ tính toán |
| chkCach_tinh.Validated | chkCach_tinh_Validated | Focus control phù hợp |

## Đặc điểm kỹ thuật

- Sử dụng `KyBaoCao` object để quản lý các kỳ báo cáo
- Tự động tính ngày bắt đầu/kết thúc kỳ trước dựa trên năm tài chính
- DataBinding với DataTable cho form chỉnh sửa
- Validation tài khoản khi nhập danh sách TK
- Hỗ trợ public variables để lưu trạng thái lựa chọn kỳ báo cáo

## Dependencies

- AsiaErp.Framework
- AsiaErp.UserInterface.My
- System.Data
- System.Windows.Forms
- Microsoft.VisualBasic
