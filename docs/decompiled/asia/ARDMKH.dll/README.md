# ARDMKH.dll - Danh mục khách hàng

## Tổng quan

DLL quản lý danh mục khách hàng (Accounts Receivable Customer List) trong module AR. Cung cấp chức năng thêm, sửa, xóa và quản lý thông tin khách hàng.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaErp.UserInterface` |
| Assembly | `Asia Enterprise` |
| Version | `9.1.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © AsiaSoft 2010` |

## Forms chính

### frmARDMKH
- **Kế thừa**: `frmDmView`
- **Mô tả**: Form xem danh mục khách hàng
- **Chức năng**:
  - Hiển thị danh sách khách hàng dạng lưới (DataGridView)
  - Tìm kiếm khách hàng
  - Phân trang dữ liệu
  - Điều hướng (First, Previous, Next, Last)

### frmARDMKHEdit
- **Kế thừa**: `frmDmEdit`
- **Mô tả**: Form thêm/sửa thông tin khách hàng
- **Chức năng**:
  - Nhập thông tin khách hàng mới
  - Chỉnh sửa thông tin khách hàng hiện có
  - Validate dữ liệu trước khi lưu

## Cấu trúc dữ liệu khách hàng

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

## Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| dgvDM | `DataGridView` | Lưới hiển thị danh mục |
| txtMa_Kh | `AsTextBox` | Mã khách hàng |
| txtTen_Kh | `TextBox` | Tên khách hàng |
| txtDia_Chi | `TextBox` | Địa chỉ |
| txtMa_So_Thue | `TextBox` | Mã số thuế |
| txtMa_PlKh1/2/3 | `AsTextBox` | Phân loại khách hàng |
| txtMa_NhKh | `AsTextBox` | Nhóm khách hàng |

## Business Logic

### Validate
- Mã khách hàng không được trống
- Mã khách hàng không được trùng
- Tên khách hàng bắt buộc nhập

### Lookup
- `txtMa_PlKh1/2/3`: Lookup phân loại khách hàng (MA_PLKH)
- `txtMa_NhKh`: Lookup nhóm khách hàng (MA_NHKH)
- `txtTK_cn`: Lookup tài khoản công nợ (TK với điều kiện tk_cn=1)

## Dependencies

- `AsiaErp.Framework`
- `System.Windows.Forms`
- `System.Data`

## Ghi chú

- Kế thừa từ các form danh mục chuẩn (`frmDmView`, `frmDmEdit`)
- Sử dụng BindingSource để binding dữ liệu
- Hỗ trợ chức năng khóa sử dụng (ksd)
