# GLRptBCTCCR02 - Bảng cân đối kế toán

## Mô tả

Module báo cáo hiển thị Bảng cân đối kế toán (Balance Sheet) theo quy định của pháp luật kế toán Việt Nam.

## Chức năng chính

### 1. Báo cáo Bảng cân đối kế toán
- Hiển thị tình hình tài chính của doanh nghiệp tại một thời điểm
- So sánh số liệu giữa các kỳ báo cáo
- Hỗ trợ lọc chỉ tiêu có số liệu

### 2. Quản lý mẫu báo cáo
- Tích hợp form frmGLMauBS01 để quản lý mẫu
- Hỗ trợ chỉnh sửa công thức tính toán
- Lưu trữ nhiều mẫu báo cáo khác nhau

### 3. Drill-down chi tiết
- Xem chi tiết công thức tính
- Xem sổ chi tiết theo tài khoản
- Xem cân đối phát sinh công nợ

## Tham số báo cáo

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| cmdBS | Button | Mở form KB Công thức |
| chkChiTieuCoSoLieu | CheckBox | Chỉ hiển thị chỉ tiêu có số liệu |
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Ngày bắt đầu/kết thúc |
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND, optNt | RadioButton | Tùy chọn tiền tệ |

## Events

| Event | Handler | Mô tả |
|-------|---------|-------|
| AsTabControl.SelectedIndexChanged | AsTabControl_SelectedIndexChanged | Cập nhật title bar khi chuyển tab |
| cmdBS.Click | cmdBS_Click | Mở form frmGLMauBS01 |

## Phương thức chính

### LoadData()
Load dữ liệu báo cáo với các tham số:
- CompanyID
- FinancialYear
- Ngày báo cáo (txtNgay2)
- Checkbox chỉ tiêu có số liệu
- Mã mẫu báo cáo

### CreateDrilldownArgument()
Xử lý drill-down với các phím tắt:
- **F5**: Chi tiết công thức/Sổ chi tiết
- **Ctrl+F5**: Sổ chi tiết
- **Shift+F5**: Cân đối PS công nợ

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã số chỉ tiêu |
| `cach_tinh` | Cách tính/công thức |
| `tk` | Tài khoản |
| `chi_tieu` | Chỉ tiêu báo cáo |
| `cong_no` | Công nợ |

## Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` base class
- Sử dụng DataBinding với DataTable
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ)
- Tích hợp drill-down đa cấp

## Dependencies

- AsiaErp.Framework
- AsiaErp.UserInterface.My
- System.Data
- System.Windows.Forms
- Microsoft.VisualBasic
