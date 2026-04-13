# FADMBPSD - Danh mục bộ phận sử dụng

## Mô tả

Module quản lý danh mục bộ phận sử dụng trong hệ thống ERP. Phục vụ cho việc quản lý bộ phận sử dụng tài sản trong hệ thống kế toán tài sản cố định.

## Chức năng

### 1. Quản lý danh mục bộ phận sử dụng
- Xem danh sách bộ phận sử dụng
- Thêm mới bộ phận sử dụng
- Sửa thông tin bộ phận sử dụng
- Xóa bộ phận sử dụng
- Đổi mã bộ phận sử dụng
- Tìm kiếm bộ phận sử dụng
- In danh sách bộ phận sử dụng

### 2. Thông tin quản lý
- Mã bộ phận: Định danh duy nhất
- Tên bộ phận: Mô tả bộ phận
- Trạng thái sử dụng: Kích hoạt/Không sử dụng

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmFADMBPSD` | `frmDMView` | Form danh sách bộ phận sử dụng |
| `frmFADMBPSDEdit` | `frmDMEdit` | Form thêm/sửa bộ phận sử dụng |

## UI Controls - frmFADMBPSD (View)

| Control | Type | Mục đích |
|---------|------|----------|
| `dgvDM` | AsDataGridView | Grid hiển thị danh sách |
| `cmdAdd` | Button | Thêm mới |
| `cmdEdit` | Button | Sửa |
| `cmdDel` | Button | Xóa |
| `cmdChgCode` | Button | Đổi mã |
| `cmdSearch` | Button | Tìm kiếm |
| `cmdPrint` | Button | In |
| `cmdClose` | Button | Đóng |
| `cboFilter` | ComboBox | Lọc dữ liệu |
| `txtValue` | TextBox | Giá trị tìm kiếm |
| `lblTen` | Label | Nhãn "Tên" |

## UI Controls - frmFADMBPSDEdit (Edit)

| Control | Type | Mục đích |
|---------|------|----------|
| `txtMa_Bp` | TextBox | Mã bộ phận |
| `txtTen_Bp` | TextBox | Tên bộ phận |
| `lblMa_Bp` | Label | Nhãn "Mã bộ phận" |
| `lblTen_Bp` | Label | Nhãn "Tên bộ phận" |
| `chkKsd` | AsCheckBox | Checkbox "Không sử dụng" |
| `cmdSave` | Button | Lưu |
| `cmdCancel` | Button | Hủy |

## Data Binding

| Control | Field | Type |
|---------|-------|------|
| txtMa_Bp | ma_bpsd | String |
| txtTen_Bp | ten_bpsd | String |
| chkKsd | ksd | Boolean (checked) |

## Validation

- `ChkEmtyTextBox(txtMa_Bp)`: Kiểm tra mã bộ phận không được rỗng
- `ChkEmtyTextBox(txtTen_Bp)`: Kiểm tra tên bộ phận không được rỗng

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_bpsd` | Mã bộ phận sử dụng |
| `ten_bpsd` | Tên bộ phận sử dụng |
| `ksd` | Không sử dụng (trạng thái) |

## Dependencies

- `AsiaErp.Framework`
- `System.Windows.Forms`
- `System.Drawing`

## Xem thêm

- [FADMTS.md](FADMTS.md) - Danh mục tài sản
- [FAChuyenTS.md](../vouchers/FAChuyenTS.md) - Chuyển tài sản
