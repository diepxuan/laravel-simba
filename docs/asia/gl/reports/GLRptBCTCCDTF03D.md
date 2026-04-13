# GLRptBCTCCDTF03D - Báo cáo tài chính chi tiết F03D

## Mô tả

Module báo cáo hiển thị báo cáo tài chính chi tiết theo mẫu F03D.

## Chức năng chính

### 1. Báo cáo theo tài khoản
- Lọc báo cáo theo mã tài khoản cụ thể
- AutoLookup tài khoản với gợi ý autocomplete
- Hiển thị tên tài khoản tương ứng

### 2. Khoảng thời gian báo cáo
- Chọn kỳ báo cáo (cboKyBc)
- Nhập ngày bắt đầu/kết thúc linh hoạt
- Mặc định theo kỳ kế toán

### 3. Mẫu báo cáo
- Chọn mẫu báo cáo từ danh sách
- Tiêu đề báo cáo tùy chỉnh
- Hỗ trợ chỉnh sửa mẫu báo cáo (cmdModifyReport)

### 4. Xuất dữ liệu
- Xuất ra Excel (cmdExcel)
- In ấn trực tiếp
- Preview trước khi in

## Tham số báo cáo

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| txtTk | AsTextBox | Nhập mã tài khoản |
| lblTen_Tk | Label | Hiển thị tên tài khoản |
| lblTk | Label | Nhãn "Tài khoản" |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Ngày bắt đầu/kết thúc |
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| cboMau_bc | ComboBox | Chọn mẫu báo cáo |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| txtMa_Nt | AsTextBox | Mã ngoại tệ (ẩn) |
| optVND, optNt | RadioButton | Tùy chọn tiền tệ (ẩn) |

## Thuộc tính Controls

**txtTk (AsTextBox):**
- `AutoLookup = true` - Tự động tìm kiếm
- `AutoValid = false` - Không tự động validate
- `BackColor = SystemColors.Info` - Màu nền info
- `CharacterCasing = Upper` - Chữ hoa
- `LookupCodeName = "TK"` - Lookup theo mã TK
- `UseAutoCompleteSource = true` - Dùng autocomplete
- `NameControl = lblTen_Tk` - Bind tên TK vào label

## Tham số truy vấn (Stored Procedure)

```csharp
ArrayList params = new ArrayList();
params.Add(CompanyInformations.CompanyID);  // Mã công ty
params.Add(txtNgay1.Value);                 // Ngày bắt đầu
params.Add(txtNgay2.Value);                 // Ngày kết thúc
params.Add(txtTk.Text);                     // Mã tài khoản
```

## Formula Fields

| Field | Giá trị |
|-------|---------|
| `strFiltertitle` | Tiêu đề filter (Tài khoản: [TK - Tên TK]) |

## Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Base form cho các báo cáo
- Sử dụng `AsTextBox` với chức năng AutoLookup
- Tích hợp với Asia ERP Framework và Helper
- Hỗ trợ đa tiền tệ (có controls nhưng bị ẩn)

## Dependencies

- AsiaErp.Framework
- System.Data
- System.Windows.Forms
- Microsoft.VisualBasic
