# GLRptBCPT02 - Bảng cân đối phát sinh một tài khoản theo ngày

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Mã báo cáo | BCPT02 |
| Tên báo cáo | Bảng cân đối phát sinh một tài khoản theo ngày |
| Module | GL (General Ledger) |
| Loại | Báo cáo cân đối phát sinh |
| Framework | .NET Framework 3.5 |

## Chức năng

Báo cáo hiển thị chi tiết phát sinh của một tài khoản cụ thể theo từng ngày, cho phép theo dõi biến động số dư qua từng ngày.

## Tham số đầu vào

| Tham số | Kiểu | Mô tả |
|---------|------|-------|
| txtTk | string | Tài khoản cần xem |
| txtNgay1 | DateTime | Từ ngày |
| txtNgay2 | DateTime | Đến ngày |
| cboKyBc | string | Kỳ báo cáo |
| cboMau_bc | int | Mẫu báo cáo |
| txtMa_Nt | string | Mã ngoại tệ |
| optVND/optNt | bool | Lựa chọn tiền tệ |
| txtTieu_De | string | Tiêu đề báo cáo |

## Cấu trúc báo cáo

### Cột dữ liệu

| Cột | Mô tả |
|-----|-------|
| Ngày | Ngày giao dịch |
| Số chứng từ | Số hiệu chứng từ |
| Diễn giải | Nội dung giao dịch |
| Phát sinh nợ | Phát sinh bên Nợ |
| Phát sinh có | Phát sinh bên Có |
| Số dư | Số dư sau giao dịch |

### Đặc điểm

- Hiển thị chi tiết phát sinh theo từng ngày
- Tính số dư lũy kế sau mỗi giao dịch
- Hỗ trợ xem theo ngoại tệ (nếu có)

## Ví dụ sử dụng

Xem chi tiết phát sinh của tài khoản 111 (Tiền mặt) trong tháng 3/2025:
- Tài khoản: 111
- Từ ngày: 01/03/2025
- Đến ngày: 31/03/2025
- Tiền tệ: VND

## Dependencies

- `AsiaErp.Framework`
- `System.Data`
- `System.Windows.Forms`

## Business Logic

### LoadData

```csharp
ArrayList params = new ArrayList();
params.Add(CompanyInformations.CompanyID);  // Mã công ty
params.Add(txtTk.Text);                     // Tài khoản
params.Add(txtNgay1.Value);                 // Từ ngày
params.Add(txtNgay2.Value);                 // Đến ngày
params.Add(txtMa_Nt.Text);                  // Mã ngoại tệ
```

### AutoComplete

- Trường tài khoản (txtTk) có AutoLookup với LookupCodeName = "TK"
- Tự động hiển thị tên tài khoản (lblTen_Tk)

## Lưu ý

- Báo cáo này khác với BCPT04: BCPT02 xem theo ngày, BCPT04 xem theo chứng từ
- Phù hợp cho việc đối chiếu sổ quỹ, sổ ngân hàng theo từng ngày
