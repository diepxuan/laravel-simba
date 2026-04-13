# SIDMOpt9.dll - Danh mục tùy chọn 9

## Tổng quan

DLL quản lý danh mục tùy chọn 9 (Option 9) trong hệ thống AsiaERP.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| **Namespace** | `AsiaErp.UserInterface` |
| **Assembly** | `SIDMOpt9` |
| **Version** | `1.0.0.0` |
| **Company** | ASIASOFT |
| **Product** | AsiaERP |
| **Copyright** | Copyright © ASIASOFT 2010 |

## Forms chính

### 1. frmSIDMOpt9
- **Mục đích**: Form danh sách danh mục tùy chọn 9
- **Kế thừa**: `frmAsiaRoot`
- **Chức năng**:
  - Hiển thị danh sách các mã tùy chọn 9
  - Tìm kiếm và lọc dữ liệu
  - Điều hướng đến form thêm/sửa/xóa

### 2. frmSIDMOpt9Edit
- **Mục đích**: Form chi tiết chỉnh sửa danh mục tùy chọn 9
- **Kế thừa**: `frmAsiaRoot`
- **Controls chính**:
  - `txtMa`: TextBox nhập mã
  - `txtTen`: TextBox nhập tên
  - `txtTen2`: TextBox nhập tên tiếng Anh
  - `txtGhiChu`: TextBox ghi chú
  - `chkStatus`: CheckBox trạng thái

## Business Logic

### Lớp DAO
- **SIDMOpt9DAO**: Data Access Object cho danh mục tùy chọn 9
- **Interface**: `ISIDMOpt9DAO`

### Các phương thức chính
1. **GetList()**: Lấy danh sách tất cả các mã tùy chọn 9
2. **GetById(string id)**: Lấy thông tin theo mã
3. **Insert/Update/Delete**: CRUD operations

## Events

| Event | Mô tả |
|-------|-------|
| `Form_Load` | Khởi tạo dữ liệu khi mở form |
| `btnAdd_Click` | Thêm mới danh mục |
| `btnEdit_Click` | Sửa danh mục đang chọn |
| `btnDelete_Click` | Xóa danh mục đang chọn |
| `btnSearch_Click` | Tìm kiếm theo điều kiện |

## Dependencies

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `AsiaErp.UserInterface.Common`

## Lưu ý

- Danh mục tùy chọn 9 được sử dụng để mở rộng thông tin cho các chứng từ
- Hỗ trợ đa ngôn ngữ (tiếng Việt và tiếng Anh)
- Có kiểm tra trùng lặp mã khi thêm mới
- Thường được dùng cho phân loại bổ sung trong các chứng từ kế toán
