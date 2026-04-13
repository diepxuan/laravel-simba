# GLTransferGLCDTK - Chuyển số dư tài khoản sang năm sau

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLTransferGLCDTK.dll |
| Loại | Form xử lý (Voucher) |
| Kế thừa | `frmCalc` |
| Namespace | `AsiaERP.UserInterface` |

---

## Chức năng

Chuyển số dư tài khoản từ năm hiện tại sang năm sau - thao tác kế toán cuối năm quan trọng.

---

## Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `lblSure` | Label | Cảnh báo (màu đỏ) |
| `lblFinal_day` | Label | Ngày cuối năm |
| `lblConfirm` | Label | Xác nhận |
| `lblMa_so` | Label | Mã số |
| `txtMa_so` | TextBox | Mã số ngẫu nhiên (readonly) |
| `txtConfirm` | TextBox | Nhập mã xác nhận |
| `txtFinal_day` | AsMaskedTextBox | Ngày cuối năm (readonly) |
| `bgWork` | BackgroundWorker | Xử lý nền |
| `cmdOK` | Button | Thực hiện |
| `cmdCancel` | Button | Hủy bỏ |

---

## Methods

| Method | Mục đích |
|--------|----------|
| `InitComponents()` | Khởi tạo mã số ngẫu nhiên, ngày cuối năm |
| `Execute()` | Bắt đầu quá trình chuyển số dư |
| `txtConfirm_TextChanged()` | Validate mã xác nhận |
| `bgWork_DoWork()` | Thực hiện chuyển số dư trên background thread |
| `bgWork_RunWorkerCompleted()` | Xử lý kết quả |

---

## Logic xử lý

### Xác thực an toàn
- Tạo số ngẫu nhiên làm mã xác nhận
- Yêu cầu nhập lại đúng mã để thực hiện
- Tránh thao tác nhầm quan trọng

### Background Processing
- Sử dụng `BackgroundWorker` để không block UI
- Parameters: `CompanyID`, `FinalDay`
- Gọi `MyController.Execute()` để thực hiện

---

## Messages

| Code | Ý nghĩa |
|------|---------|
| 50015 | Thực hiện thành công |
| 50010 | Thực hiện thất bại |

---

## Quy trình sử dụng

1. Mở form từ menu
2. Xem ngày cuối năm hiện thời
3. Ghi nhớ mã số được hiển thị
4. Nhập mã số vào ô xác nhận
5. Click "OK" khi mã khớp
6. Chờ quá trình xử lý hoàn tất

---

## Dependencies

- `AsiaErp.Framework`
- `System.Windows.Forms`
- `Microsoft.VisualBasic`

---

*Ngày tạo: 2026-03-29*
