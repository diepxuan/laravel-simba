# GLRptBCTCCR04 - Báo cáo lưu chuyển tiền tệ (phương pháp trực tiếp)

## Mô tả

Module báo cáo hiển thị Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp (Direct Method Cash Flow Statement).

## Chức năng chính

### 1. Báo cáo Lưu chuyển tiền tệ (Direct Method)
- Hiển thị dòng tiền vào/ra của doanh nghiệp
- Phân loại theo hoạt động kinh doanh, đầu tư, tài chính
- So sánh với kỳ trước

### 2. Phương pháp trực tiếp (Direct Method)
- Theo dõi trực tiếp các khoản thu/chi tiền mặt
- Không điều chỉnh từ lợi nhuận
- Phù hợp với chuẩn mực kế toán quốc tế

### 3. Quản lý mẫu báo cáo
- Tích hợp form frmGLMauCF01 để quản lý mẫu cash flow
- Hỗ trợ chỉnh sửa công thức tính toán

### 4. Drill-down chi tiết
- Xem chi tiết công thức tính các chỉ tiêu
- Xem sổ chi tiết theo TK nợ/TK có

## Tham số báo cáo

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| cmdCF | Button | Mở form KB Công thức cash flow |
| cboKyTruoc | ComboBox | Chọn kỳ trước để so sánh |
| txtNgay01, txtNgay02 | AsMaskedTextBox | Ngày kỳ trước |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Ngày kỳ báo cáo |
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND, optNt | RadioButton | Tùy chọn tiền tệ |

## Events

| Event | Handler | Mô tả |
|-------|---------|-------|
| cboKyTruoc.SelectedValueChanged | cboKyTruoc_SelectedValueChanged | Cập nhật ngày kỳ trước |
| cmdCF.Click | cmdCF_Click | Mở form frmGLMauCF01 |

## Phương thức chính

### InitKyBaoCaoTruoc()
Khởi tạo danh sách kỳ báo cáo trước:
- DataSource từ `AsiaErp.Framework.Environment.GetKyBaoCao()`
- ValueMember: "ma", DisplayMember: "ten_ky"

### LoadData()
Load dữ liệu báo cáo với các tham số:
- CompanyID
- FinancialYear
- Ngày kỳ báo cáo (txtNgay1, txtNgay2)
- Ngày kỳ trước (txtNgay01, txtNgay02)
- Mã mẫu báo cáo
- Mã ngoại tệ

### GetFilterCondiction()
Tạo chuỗi mô tả điều kiện lọc:
- Kỳ báo cáo
- Kỳ trước
- Mã ngoại tệ

### CreateDrilldownArgument()
Xử lý drill-down với phím F5:
- Drill-down theo cách tính (công thức)
- Drill-down theo tài khoản nợ (tk_no) và tài khoản có (tk_co)

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã số chỉ tiêu |
| `cach_tinh` | Cách tính/công thức |
| `tk_no` | Tài khoản nợ |
| `tk_co` | Tài khoản có |
| `chi_tieu` | Chỉ tiêu báo cáo |

## Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` base class
- Hỗ trợ so sánh kỳ (kỳ hiện tại vs kỳ trước)
- Hỗ trợ đa tiền tệ
- Tích hợp drill-down đa cấp

## Dependencies

- AsiaErp.Framework
- System.Data
- System.Windows.Forms
- Microsoft.VisualBasic
