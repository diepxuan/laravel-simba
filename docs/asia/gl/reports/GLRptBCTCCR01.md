# GLRptBCTCCR01 - Báo cáo tài chính CCR01

## Mô tả

Module báo cáo hiển thị báo cáo tài chính CCR01 - báo cáo cân đối phát sinh theo tài khoản.

## Chức năng chính

### 1. Báo cáo tài chính CCR01
- Báo cáo cân đối phát sinh theo tài khoản
- Hỗ trợ hiển thị theo cấp bậc tài khoản
- Tùy chọn lên sổ cái

### 2. Drill-down (F5)
- **F5**: Xem sổ chi tiết của tài khoản
- **Ctrl+F5**: Xem sổ chi tiết
- **Shift+F5**: Cân đối phát sinh công nợ
- **F7**: Xem
- **F9**: In

### 3. Tham số hóa báo cáo
- Chọn tài khoản cụ thể
- Chọn số bậc hiển thị (1-9)
- Tùy chọn lên sổ cái

### 4. Xuất dữ liệu
- Hỗ trợ xuất Excel
- In ấn báo cáo
- Drill-down để xem chi tiết

## Tham số báo cáo

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| txtTk | AsTextBox | Tài khoản lọc báo cáo |
| txtBac | AsTextNumeric | Số bậc hiển thị (mặc định: 9) |
| chkTK_sc | CheckBox | Lên cho tài khoản sổ cái |
| lblTk | Label | Nhãn "Tài khoản" |
| lblbac | Label | Nhãn "In đến bậc" |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Từ ngày, đến ngày |
| cboKyBc | ComboBox | Kỳ báo cáo |
| cboMau_bc | ComboBox | Mẫu báo cáo |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND, optNt | RadioButton | Tùy chọn tiền tệ |

## Thuật ngữ kỹ thuật

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `txtTk` | TextBox nhập mã tài khoản |
| `txtBac` | Số bậc cấp tài khoản |
| `chkTK_sc` | Checkbox tài khoản sổ cái |
| `LookupCodeName = "TK"` | Mã lookup cho danh mục tài khoản |

## Phím tắt

| Phím | Chức năng |
|------|-----------|
| F5 | Xem sổ chi tiết của tài khoản |
| Ctrl+F5 | Xem sổ chi tiết |
| Shift+F5 | Cân đối phát sinh công nợ |
| F7 | Xem báo cáo |
| F9 | In báo cáo |

## Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của framework
- Sử dụng `AsTextBox` với AutoLookup cho tài khoản
- Sử dụng `AsTextNumeric` cho số bậc
- DataBinding với DataTable
- Hỗ trợ đa tiền tệ (VND/NT)

## Dependencies

- AsiaErp.Framework
- AsiaErp.DataAccess
- System.Data
- System.Windows.Forms
- Microsoft.VisualBasic
