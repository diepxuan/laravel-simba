# Phân tích DLL: ARDMKH.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ARDMKH.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmARDMKH, frmARDMKHEdit |
| **Kế thừa** | frmDmView, frmDmEdit |
| **Chức năng** | Danh mục khách hàng (Accounts Receivable Customer List) |

## 2. Forms

### 2.1 frmARDMKH (View Form)

**Mô tả:** Form xem danh mục khách hàng

**Chức năng:**
- Hiển thị danh sách khách hàng dạng lưới (DataGridView)
- Tìm kiếm khách hàng
- Phân trang dữ liệu
- Điều hướng (First, Previous, Next, Last)

### 2.2 frmARDMKHEdit (Edit Form)

**Mô tả:** Form thêm/sửa thông tin khách hàng

**Chức năng:**
- Nhập thông tin khách hàng mới
- Chỉnh sửa thông tin khách hàng hiện có
- Validate dữ liệu trước khi lưu

## 3. Cấu trúc dữ liệu khách hàng

| Trường | Mô tả |
|--------|-------|
| ma_kh | Mã khách hàng (khóa chính) |
| ten_kh | Tên khách hàng |
| dia_chi | Địa chỉ |
| ma_so_thue | Mã số thuế |
| dien_thoai | Điện thoại |
| fax | Fax |
| email | Email |
| ma_nt | Mã ngoại tệ mặc định |
| tk_cn | Tài khoản công nợ |
| ma_plkh1/2/3 | Mã phân loại khách hàng |
| ma_nhkh | Mã nhóm khách hàng |
| isKh | Là khách hàng (flag) |

## 4. Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| dgvDM | DataGridView | Lưới hiển thị danh mục |
| txtMa_Kh | AsTextBox | Mã khách hàng |
| txtTen_Kh | TextBox | Tên khách hàng |
| txtDia_Chi | TextBox | Địa chỉ |
| txtMa_So_Thue | TextBox | Mã số thuế |
| txtMa_PlKh1/2/3 | AsTextBox | Phân loại khách hàng |
| txtMa_NhKh | AsTextBox | Nhóm khách hàng |

## 5. Business Logic

### Validate
- Mã khách hàng không được trống
- Mã khách hàng không được trùng
- Tên khách hàng bắt buộc nhập

### Lookup
- `txtMa_PlKh1/2/3`: Lookup phân loại khách hàng (MA_PLKH)
- `txtMa_NhKh`: Lookup nhóm khách hàng (MA_NHKH)
- `txtTK_cn`: Lookup tài khoản công nợ (TK với điều kiện tk_cn=1)

## 6. Dependencies

- `AsiaErp.Framework`
- `System.Windows.Forms`
- `System.Data`

## 7. Ghi chú

- Kế thừa từ các form danh mục chuẩn (`frmDmView`, `frmDmEdit`)
- Sử dụng BindingSource để binding dữ liệu
- Hỗ trợ chức năng khóa sử dụng (ksd)
