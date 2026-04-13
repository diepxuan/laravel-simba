# SODMCK.dll - Danh mục chuyển khoản

## Tổng quan

DLL quản lý danh mục chuyển khoản (Transfer/Remittance Category) trong module Sales Order (SO) của hệ thống Asia ERP.

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SODMCK.dll |
| **Mô tả** | Danh mục chuyển khoản |
| **Namespace** | AsiaErp.UserInterface, AsiaErp.DataAccess |
| **Phiên bản** | 9.1.0.0 |
| **Copyright** | Asia Software Development JSC |

## Cấu trúc Namespace

### AsiaErp.UserInterface

| Form | Mô tả |
|------|-------|
| `frmSODMCK` | Form danh sách danh mục chuyển khoản, kế thừa từ `frmCategoryList` |
| `frmSODMCKEdit` | Form chỉnh sửa danh mục chuyển khoản, kế thừa từ `frmCategoryEdit` |

### AsiaErp.DataAccess

| Class | Mô tả |
|-------|-------|
| `SODMCKDAO` | Interface định nghĩa các phương thức truy cập dữ liệu |
| `MssqlSODMCKDAO` | Triển khai DAO cho SQL Server, kế thừa từ `MssqlCategoryBaseDAO` |

## Controls chính trong frmSODMCK

### DataGridView Columns
- `dgvcMa_Ck` - Mã chuyển khoản
- `dgvcTen_Ck` - Tên chuyển khoản
- `dgvcTk_Ck` - Tài khoản chuyển khoản
- `dgvcTen_Tk_Ck` - Tên tài khoản
- `dgvcMa_Nh` - Mã nhóm

### Toolbar Actions
- Thêm mới, Sửa, Xóa, Làm tươi
- Tìm kiếm nhanh trên lưới

## Controls chính trong frmSODMCKEdit

| Control | Loại | Mô tả |
|---------|------|-------|
| `txtMa_Ck` | AsTextBox | Mã chuyển khoản (khóa chính) |
| `txtTen_Ck` | TextBox | Tên chuyển khoản |
| `txtTk_Ck` | AsTextBox | Tài khoản kế toán (lookup TK) |
| `lblTen_Tk_Ck` | Label | Tên tài khoản (hiển thị) |
| `txtMa_Nh` | AsTextBox | Mã nhóm chuyển khoản |

## Business Logic

### Lookup/Validation
- `txtTk_Ck`: Lookup từ bảng TK (tài khoản kế toán), điều kiện `chi_tiet=1`
- `txtMa_Nh`: Lookup từ bảng nhóm chuyển khoản

### Events
- `AfterCodeValidating`: Tự động điền tên tài khoản khi chọn mã TK

## Cấu trúc bảng dữ liệu (dự kiến)

```sql
-- Bảng dmcK (Danh mục chuyển khoản)
CREATE TABLE dmcK (
    Ma_Ck VARCHAR(20) PRIMARY KEY,
    Ten_Ck NVARCHAR(255),
    Tk_Ck VARCHAR(20),
    Ma_Nh VARCHAR(20),
    -- ... các trường khác
);
```

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls

## Ghi chú

- Module thuộc nhóm danh mục (Category) của Sales Order
- Sử dụng pattern DAO để truy cập dữ liệu
- Hỗ trợ đa ngôn ngữ thông qua resource files
