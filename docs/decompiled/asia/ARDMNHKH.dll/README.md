# ARDMNHKH.dll - Danh mục nhóm khách hàng

## Tổng quan

DLL quản lý danh mục nhóm khách hàng (Accounts Receivable Customer Group) trong module AR. Cho phép phân loại khách hàng theo nhóm để dễ dàng quản lý và báo cáo.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaErp.UserInterface` |
| Assembly | `Asia Enterprise` |
| Version | `9.1.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © AsiaSoft 2010` |

## Forms chính

### frmARDMNHKH
- **Kế thừa**: `frmDmView`
- **Mô tả**: Form xem danh mục nhóm khách hàng
- **Chức năng**:
  - Hiển thị danh sách nhóm khách hàng
  - Tìm kiếm nhóm
  - Phân trang

### frmARDMNHKHEdit
- **Kế thừa**: `frmDmEdit`
- **Mô tả**: Form thêm/sửa nhóm khách hàng
- **Chức năng**:
  - Nhập mã và tên nhóm khách hàng
  - Mô tả nhóm

## Cấu trúc dữ liệu nhóm khách hàng

| Trường | Mô tả |
|--------|-------|
| ma_nhkh | Mã nhóm khách hàng (khóa chính) |
| ten_nhkh | Tên nhóm khách hàng |
| ghi_chu | Ghi chú |
| ksd | Khóa sử dụng |

## Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| dgvDM | `DataGridView` | Lưới hiển thị danh mục |
| txtMa_NhKh | `AsTextBox` | Mã nhóm khách hàng |
| txtTen_NhKh | `TextBox` | Tên nhóm khách hàng |
| txtGhi_Chu | `TextBox` | Ghi chú |
| chkKsd | `AsCheckBox` | Khóa sử dụng |

## Business Logic

### Validate
- Mã nhóm không được trống
- Mã nhóm không được trùng
- Tên nhóm bắt buộc nhập

### Lookup
- Được sử dụng trong form khách hàng (ARDMKH) để chọn nhóm

## Dependencies

- `AsiaErp.Framework`
- `System.Windows.Forms`

## Ghi chú

- Danh mục đơn giản, chỉ có mã và tên
- Được sử dụng để phân loại khách hàng trong các báo cáo công nợ
