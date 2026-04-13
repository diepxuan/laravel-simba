# GLRptBCPT04 - Bảng cân đối phát sinh một tài khoản theo ngày

## Mô tả

Module báo cáo hiển thị bảng cân đối phát sinh của một tài khoản theo từng ngày.

## Chức năng chính

### 1. Xem chi tiết theo ngày
- Chọn một tài khoản cụ thể
- Hiển thị chi tiết phát sinh theo từng ngày
- Theo dõi biến động số dư qua từng ngày

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
| Ngày | Ngày giao dịch |
| Số chứng từ | Số hiệu chứng từ |
| Diễn giải | Nội dung giao dịch |
| Phát sinh nợ | Phát sinh bên Nợ |
| Phát sinh có | Phát sinh bên Có |
| Số dư | Số dư sau giao dịch |

## Tham số truy vấn (Stored Procedure)

```csharp
ArrayList params = new ArrayList();
params.Add(CompanyInformations.CompanyID);  // Mã công ty
params.Add(txtTk.Text);                     // Tài khoản
params.Add(txtNgay1.Value);                 // Từ ngày
params.Add(txtNgay2.Value);                 // Đến ngày
params.Add(txtMa_Nt.Text);                  // Mã ngoại tệ
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
