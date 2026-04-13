# FADMNV - Danh mục nguồn vốn

## Mô tả

Module quản lý danh mục nguồn vốn trong hệ thống ERP. Đây là danh mục hệ thống/cố định, chỉ cho phép chỉnh sửa thông tin mô tả.

## Đặc điểm

Module này có **hạn chế các thao tác thêm/xóa/đổi mã**:
- `cmdAdd.Visible = false` - Không cho phép thêm mới
- `cmdDel.Visible = false` - Không cho phép xóa
- `cmdChgCode.Visible = false` - Không cho phép đổi mã

Điều này cho thấy danh mục nguồn vốn là danh mục **hệ thống** hoặc **cố định**, chỉ cho phép chỉnh sửa thông tin mô tả.

## Chức năng

### 1. Quản lý danh mục nguồn vốn
- Xem danh sách nguồn vốn
- **Sửa** thông tin nguồn vốn (chức năng chính)
- Tìm kiếm nguồn vốn
- In danh sách nguồn vốn

### 2. Hạn chế chức năng
Chỉ cho phép Edit, Search, Print - không cho phép Add, Delete, ChangeCode.

### 3. Thông tin quản lý
- Mã nguồn vốn: Định danh duy nhất (không đổi)
- Tên nguồn vốn: Mô tả nguồn vốn (có thể sửa)
- Trạng thái sử dụng: Kích hoạt/Không sử dụng

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFADMNV` | `frmDMView` | Form danh sách nguồn vốn |
| `frmFADMNVEdit` | `frmDMEdit` | Form thêm/sửa nguồn vốn |

## UI Controls - frmFADMNV (View)

| Control | Type | Mục đích | Visible |
|---------|------|----------|---------|
| `dgvDM` | AsDataGridView | Grid hiển thị danh sách | Yes |
| `cmdAdd` | Button | Thêm mới | **No** |
| `cmdEdit` | Button | Sửa | Yes |
| `cmdDel` | Button | Xóa | **No** |
| `cmdChgCode` | Button | Đổi mã | **No** |
| `cmdSearch` | Button | Tìm kiếm | Yes |
| `cmdPrint` | Button | In | Yes |
| `cmdClose` | Button | Đóng | Yes |

## UI Controls - frmFADMNVEdit (Edit)

| Control | Type | Mục đích |
|---------|------|----------|
| `txtMa_nv` | TextBox | Mã nguồn vốn |
| `txtTen_nv` | TextBox | Tên nguồn vốn |
| `chkKsd` | AsCheckBox | Checkbox "Không sử dụng" |
| `cmdSave` | Button | Lưu |
| `cmdCancel` | Button | Hủy |

## Data Binding

| Control | Field | Type |
|---------|-------|------|
| txtMa_nv | ma_nv | String |
| txtTen_nv | ten_nv | String |
| chkKsd | ksd | Boolean (checked) |

## Validation

- `ChkEmtyTextBox(txtMa_nv)`: Kiểm tra mã nguồn vốn không được rỗng
- `ChkEmtyTextBox(txtTen_nv)`: Kiểm tra tên nguồn vốn không được rỗng

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nv` | Mã nguồn vốn |
| `ten_nv` | Tên nguồn vốn |
| `ksd` | Không sử dụng (trạng thái) |

## Dependencies

- `AsiaErp.Framework`
- `System.Windows.Forms`
- `System.Drawing`

## Xem thêm

- [FADGTS.md](../vouchers/FADGTS.md) - Đánh giá lại tài sản (chi tiết nguồn vốn)
- [FADMTS.md](FADMTS.md) - Danh mục tài sản
