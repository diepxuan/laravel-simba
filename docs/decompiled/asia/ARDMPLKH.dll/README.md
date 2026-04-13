# ARDMPLKH.dll - Danh mục phân loại khách hàng

## Tổng quan

DLL quản lý danh mục phân loại khách hàng (Accounts Receivable Customer Classification) trong module AR. Hỗ trợ phân loại khách hàng theo 3 cấp độ (PL1, PL2, PL3) để phân tích và báo cáo.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaErp.UserInterface` |
| Assembly | `Asia Enterprise` |
| Version | `9.1.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © AsiaSoft 2010` |

## Forms chính

### frmARDMPLKH
- **Kế thừa**: `frmDmView`
- **Mô tả**: Form xem danh mục phân loại khách hàng
- **Chức năng**:
  - Hiển thị danh sách phân loại
  - Lọc theo loại phân loại (1, 2, 3)

### frmARDMPLKHEdit
- **Kế thừa**: `frmDmEdit`
- **Mô tả**: Form thêm/sửa phân loại khách hàng
- **Chức năng**:
  - Nhập mã, tên phân loại
  - Chọn loại phân loại (1, 2, 3)

## Cấu trúc dữ liệu phân loại khách hàng

| Trường | Mô tả |
|--------|-------|
| ma_plkh | Mã phân loại khách hàng |
| ten_plkh | Tên phân loại |
| loai | Loại phân loại (1, 2, 3) |
| ghi_chu | Ghi chú |
| ksd | Khóa sử dụng |

## Phân loại theo cấp độ

| Loại | Ý nghĩa | Ví dụ |
|------|---------|-------|
| 1 | Phân loại chính | Ngành nghề, lĩnh vực kinh doanh |
| 2 | Phân loại phụ | Khu vực địa lý, thị trường |
| 3 | Phân loại bổ sung | Mức độ quan trọng, đánh giá |

## Controls chính

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_PlKh | `AsTextBox` | Mã phân loại KH |
| txtTen_PlKh | `TextBox` | Tên phân loại |
| cboLoai | `ComboBox` | Loại phân loại (1, 2, 3) |
| txtGhi_Chu | `TextBox` | Ghi chú |
| chkKsd | `AsCheckBox` | Khóa sử dụng |

## Business Logic

### Validate
- Mã phân loại không được trống
- Mã phân loại không được trùng trong cùng loại
- Loại phân loại phải là 1, 2 hoặc 3

### Lookup
- Được sử dụng trong form khách hàng (ARDMKH) để chọn phân loại
- Lookup condition: `loai=1`, `loai=2`, `loai=3` tương ứng

## Dependencies

- `AsiaErp.Framework`
- `System.Windows.Forms`

## Ghi chú

- Hỗ trợ phân loại đa chiều khách hàng
- Mỗi khách hàng có thể có 3 phân loại khác nhau
- Sử dụng trong các báo cáo phân tích công nợ
