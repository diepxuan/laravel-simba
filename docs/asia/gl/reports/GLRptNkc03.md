# GlRptNkc03

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo nhật ký chung (NKC) - Mẫu 03 với filter theo bộ phận và danh sách tài khoản

## Forms

### frmGlRptNkc03.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo nhật ký chung với filter nâng cao theo bộ phận và danh sách TK

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cboKyBc | ComboBox | Kỳ báo cáo | SelectedIndexChanged |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu | ValueChanged |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc | ValueChanged |
| cboMau_bc | ComboBox | Mẫu báo cáo | SelectedIndexChanged |
| txtMa_Nt | AsTextBox | Mã ngoại tệ | TextChanged |
| optVND | RadioButton | Loại tiền VND | CheckedChanged |
| optNt | RadioButton | Loại tiền ngoại tệ | CheckedChanged |
| txtMa_Bp | AsTextBox | Mã bộ phận | Validated, AutoLookup |
| lblTen_Bp | Label | Tên bộ phận | - |
| txtDs_Tk | AsTextBox | Danh sách TK nợ | Validated |
| txtDs_Tk_Du | AsTextBox | Danh sách TK có | - |
| txtTieu_De | TextBox | Tiêu đề báo cáo | TextChanged |
| cmdOk | Button | Thực thi báo cáo | Click |
| cmdCancel | Button | Hủy | Click |
| cmdExcel | Button | Xuất Excel | Click |
| cmdModifyReport | Button | Sửa mẫu báo cáo | Click |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| components | IContainer | Container cho components |
| Is_close | bool | Flag kiểm tra form closing |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitializeComponent | none | void | Khởi tạo UI |
| LoadData | none | bool | Tải dữ liệu báo cáo |
| InitOtherComponents | none | void | Khởi tạo thêm components, set giá trị mặc định |
| ValidData | none | bool | Validate dữ liệu đầu vào |
| txtDs_Tk_Validated | sender, EventArgs | void | Validate danh sách tài khoản (chỉ cho phép số và dấu phẩy) |
| frmGlRptNkc03_FormClosing | sender, FormClosingEventArgs | void | Xử lý khi đóng form |

## Data Access

Không có DAO riêng - sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| SP từ ReportInfo | Lấy dữ liệu NKC | @pMa_cty, @pNgay1, @pNgay2, @pDs_Tk, @pDs_Tk_Du, @pMa_Bp, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc) -> Tự động tính ngày bắt đầu/kết thúc
2. Nhập danh sách tài khoản nợ (txtDs_Tk) - validate chỉ cho phép số và dấu phẩy
3. Nhập danh sách tài khoản có (txtDs_Tk_Du)
4. Chọn bộ phận (txtMa_Bp) với AutoLookup
5. Chọn loại tiền và mã ngoại tệ
6. Click cmdOk để thực thi
7. Gọi LoadData() với 7 tham số

### Validation rules
- txtDs_Tk: Chỉ cho phép ký tự số (0-9) và dấu phẩy (,)
- Sử dụng epNotice (ErrorProvider) để hiển thị lỗi
- Mã lỗi 50017: "Danh sách tài khoản không hợp lệ"

### Parameters truyền vào SP
1. CompanyID - Mã công ty
2. Ngày bắt đầu (txtNgay1.Value)
3. Ngày kết thúc (txtNgay2.Value)
4. Danh sách TK nợ (txtDs_Tk.Text)
5. Danh sách TK có (txtDs_Tk_Du.Text)
6. Mã bộ phận (txtMa_Bp.Text)
7. Mã ngoại tệ (txtMa_Nt.Text)

### Khởi tạo giá trị mặc định
- txtDs_Tk: Lấy từ MyMenuInfo