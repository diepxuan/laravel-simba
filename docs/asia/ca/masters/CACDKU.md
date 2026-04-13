# Phân tích DLL: CACDKU.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CACDKU.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCACDKU, frmCACDKUEdit |
| **Kế thừa** | frmOBView, frmOBEdit |
| **Chức năng** | Quản lý số dư đầu kỳ khế ước vay |

## 2. Forms chi tiết

### frmCACDKU (View Form)

**Controls:**
- Kế thừa từ frmOBView (Open Balance View)
- Ẩn nút Print
- Điều chỉnh vị trí các nút: Add, Edit, Del

**Chức năng:**
- Hiển thị danh sách số dư đầu kỳ khế ước
- Cho phép thêm, sửa, xóa số dư đầu kỳ

### frmCACDKUEdit (Edit Form)

**Controls:**

| Control | Type | DataField | Mô tả |
|---------|------|-----------|-------|
| txtYear | AsTextNumeric | nam | Năm tài chính |
| txtMa_ku | AsTextBox | ma_ku | Mã khế ước |
| lblTen_ku | Label | ten_ku | Tên khế ước |
| txtMa_tk | AsTextBox | tk | Mã tài khoản |
| lblTen_tk | Label | ten_tk | Tên tài khoản |
| txtNgayKu | AsMaskedTextBox | ngay_ku | Ngày khế ước |
| txtNgayTT | AsMaskedTextBox | ngay_tt | Ngày thanh toán |
| txtMa_nt | TextBox | ma_nt | Mã ngoại tệ |
| txtTiendvNT | AsTextNumeric | da_vay_nt | Tiền đã vay NT |
| txtTiendvVND | AsTextNumeric | da_vay | Tiền đã vay VND |
| txtTiendattNT | AsTextNumeric | da_tt_nt | Tiền đã TT NT |
| txtTiendattVND | AsTextNumeric | da_tt | Tiền đã TT VND |
| chkKsd | AsCheckBox | ksd | Không sử dụng |

**Events:**

| Event | Mô tả |
|-------|-------|
| txtMa_ku_AfterCodeValidating | Load thông tin khế ước (ngày vay, TK vay, mã NT) |
| txtMa_nt_TextChanged | Ẩn/hiện các trường tiền VND/NT tùy theo loại tiền |
| InitAfterGetData | Set năm tài chính mặc định khi thêm mới |
| DisableFields | Khóa mã khế ước khi sửa |
| ValidData | Kiểm tra bắt buộc nhập mã KU, mã TK |
| InsertToDB/UpdateDB | Cập nhật dữ liệu |

**Business Logic:**

- Nếu là ngoại tệ (khác VND): hiển thị cả 2 cột NT và VND
- Nếu là VND: chỉ hiển thị cột VND, ẩn cột NT
- Tự động load thông tin khế ước khi chọn mã
- Validate bắt buộc: Mã KU, Mã TK

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CACDKU_GET | Lấy danh sách số dư đầu kỳ KU |
| SP_CACDKU_INSERT | Insert số dư đầu kỳ KU |
| SP_CACDKU_UPDATE | Update số dư đầu kỳ KU |
| SP_CACDKU_DELETE | Delete số dư đầu kỳ KU |

## 4. Tables

| Table | Mô tả |
|-------|-------|
| CADKU | Công nợ đầu kỳ khế ước |

---

**Lưu ý:** 
- Form sử dụng bảng: CADKU (Công nợ đầu kỳ khế ước)
- Kế thừa từ frmOBView/frmOBEdit - framework quản lý số dư đầu kỳ
- Không áp dụng mapping PHP (đây là form số dư đầu kỳ, không phải voucher)
