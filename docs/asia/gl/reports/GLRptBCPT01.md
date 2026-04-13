# GLRptBCPT01 - Bảng cân đối phát sinh các tiểu tài khoản của một tài khoản

## Mô tả

Module báo cáo hiển thị bảng cân đối phát sinh của các tiểu tài khoản thuộc một tài khoản tổng hợp.

## Chức năng chính

### 1. Xem chi tiết tiểu tài khoản
- Chọn một tài khoản tổng hợp
- Hiển thị chi tiết các tiểu tài khoản thuộc TK đó
- Xem số dư và phát sinh của từng tiểu tài khoản

### 2. Lọc dữ liệu
- Lọc theo khoảng thời gian (từ ngày - đến ngày)
- Lọc theo mã ngoại tệ
- Lựa chọn mẫu báo cáo

### 3. Xuất dữ liệu
- Xuất báo cáo ra Excel
- In báo cáo
- Sửa mẫu báo cáo

## Tham số báo cáo

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| txtTk | AsTextBox | Tài khoản cần xem |
| txtNgay1, txtNgay2 | AsMaskedTextBox | Từ ngày, đến ngày |
| cboKyBc | ComboBox | Kỳ báo cáo |
| cboMau_bc | ComboBox | Mẫu báo cáo |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND, optNt | RadioButton | Lựa chọn tiền tệ |
| txtTieu_De | TextBox | Tiêu đề báo cáo |

## Cột báo cáo

| Cột | Ý nghĩa |
|-----|---------|
| Tiểu tài khoản | Mã tiểu tài khoản |
| Tên tiểu tài khoản | Tên chi tiết |
| Số dư đầu kỳ | Số dư đầu kỳ |
| Phát sinh nợ | Phát sinh bên Nợ |
| Phát sinh có | Phát sinh bên Có |
| Số dư cuối kỳ | Số dư cuối kỳ |

## Tham số truy vấn (Stored Procedure)

```csharp
ArrayList params = new ArrayList();
params.Add(CompanyInformations.CompanyID);  // Mã công ty
params.Add(txtNgay1.Value);                 // Từ ngày
params.Add(txtNgay2.Value);                 // Đến ngày
params.Add(txtTk.Text);                     // Tài khoản
params.Add(txtMa_Nt.Text);                  // Mã ngoại tệ
```

## Formula Fields

```csharp
base.MyFomularFields.Add("strTK", "Tài khoản :" + txtTk.Text + "- " + lblTen_Tk.Text);
```

## Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Base form báo cáo của Asia ERP
- Sử dụng `ArrayList` để truyền tham số cho stored procedure
- AutoComplete cho trường tài khoản (LookupCodeName = "TK")
- Validation dữ liệu đầu vào (AutoValid, AutoLookup)

## Dependencies

- AsiaErp.Framework
- System.Data
- System.Drawing
- System.Windows.Forms
- Microsoft.VisualBasic
