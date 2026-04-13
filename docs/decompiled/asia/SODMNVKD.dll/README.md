# SODMNVKD.dll - Danh mục nhân viên kinh doanh

## Tổng quan

DLL quản lý danh mục nhân viên kinh doanh (Salesperson Category) trong module Sales Order (SO) của hệ thống Asia ERP.

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SODMNVKD.dll |
| **Mô tả** | Danh mục nhân viên kinh doanh |
| **Namespace** | AsiaErp.UserInterface |
| **Phiên bản** | 9.1.0.0 |
| **Copyright** | Asia Software Development JSC |

## Cấu trúc Namespace

### AsiaErp.UserInterface

| Form | Mô tả |
|------|-------|
| `frmSODMNVKD` | Form danh sách nhân viên kinh doanh, kế thừa từ `frmCategoryList` |
| `frmSODMNVKDEdit` | Form chỉnh sửa nhân viên kinh doanh, kế thừa từ `frmCategoryEdit` |

## Controls chính trong frmSODMNVKD

### DataGridView Columns
- `dgvcMa_Nvkd` - Mã nhân viên kinh doanh
- `dgvcTen_Nvkd` - Tên nhân viên
- `dgvcMa_Bp` - Mã bộ phận
- `dgvcTen_Bp` - Tên bộ phận
- `dgvcDien_Thoai` - Số điện thoại
- `dgvcEmail` - Email

### Toolbar Actions
- Thêm mới, Sửa, Xóa, Làm tươi
- Tìm kiếm theo mã/tên nhân viên

## Controls chính trong frmSODMNVKDEdit

| Control | Loại | Mô tả |
|---------|------|-------|
| `txtMa_Nvkd` | AsTextBox | Mã nhân viên KD (khóa chính) |
| `txtTen_Nvkd` | TextBox | Tên nhân viên |
| `txtMa_Bp` | AsTextBox | Mã bộ phận (lookup) |
| `lblTen_Bp` | Label | Tên bộ phận |
| `txtDien_Thoai` | TextBox | Số điện thoại |
| `txtEmail` | TextBox | Email |
| `txtDia_Chi` | TextBox | Địa chỉ |
| `chkHoat_Dong` | AsCheckBox | Trạng thái hoạt động |

## Business Logic

### Lookup/Validation
- `txtMa_Bp`: Lookup từ bảng bộ phận (dmbp)
- `txtEmail`: Validate định dạng email
- `txtDien_Thoai`: Validate số điện thoại

### Phân quyền
- Nhân viên kinh doanh chỉ xem được đơn hàng của mình
- Quản lý xem được đơn hàng của team

### Báo cáo
- Doanh số theo nhân viên
- Tỷ lệ chuyển đổi đơn hàng
- Công nợ khách hàng phụ trách

## Cấu trúc bảng dữ liệu (dự kiến)

```sql
-- Bảng dmnvkd (Danh mục nhân viên kinh doanh)
CREATE TABLE dmnvkd (
    Ma_Nvkd VARCHAR(20) PRIMARY KEY,
    Ten_Nvkd NVARCHAR(255),
    Ma_Bp VARCHAR(20),
    Dien_Thoai VARCHAR(20),
    Email VARCHAR(100),
    Dia_Chi NVARCHAR(500),
    Hoat_Dong BIT DEFAULT 1,
    Ma_User VARCHAR(50),  -- Liên kết với user hệ thống
    -- ... các trường khác
);
```

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls

## Ghi chú

- Nhân viên kinh doanh được gán cho khách hàng để phụ trách
- Theo dõi doanh số và chỉ tiêu bán hàng
- Hỗ trợ phân quyền xem dữ liệu theo nhân viên
