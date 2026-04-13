# SODMHHKM.dll - Danh mục hàng hóa khuyến mãi

## Tổng quan

DLL quản lý danh mục hàng hóa khuyến mãi (Promotional Items Category) trong module Sales Order (SO) của hệ thống Asia ERP.

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SODMHHKM.dll |
| **Mô tả** | Danh mục hàng hóa khuyến mãi |
| **Namespace** | AsiaERP.UserInterface |
| **Phiên bản** | 9.1.0.0 |
| **Copyright** | Asia Software Development JSC |

## Cấu trúc Namespace

### AsiaERP.UserInterface

| Form | Mô tả |
|------|-------|
| `frmSODMHHKM` | Form danh sách hàng hóa khuyến mãi, kế thừa từ `frmCategoryList` |
| `frmSODMHHKMEdit` | Form chỉnh sửa hàng hóa khuyến mãi, kế thừa từ `frmCategoryEdit` |

## Controls chính trong frmSODMHHKM

### DataGridView Columns
- `dgvcMa_Km` - Mã khuyến mãi
- `dgvcTen_Km` - Tên chương trình khuyến mãi
- `dgvcMa_Vt` - Mã vật tư khuyến mãi
- `dgvcTen_Vt` - Tên vật tư
- `dgvcSo_Luong` - Số lượng khuyến mãi
- `dgvcDieu_Kien` - Điều kiện áp dụng

### Toolbar Actions
- Thêm mới, Sửa, Xóa, Làm tươi
- Tìm kiếm theo mã/tên khuyến mãi

## Controls chính trong frmSODMHHKMEdit

| Control | Loại | Mô tả |
|---------|------|-------|
| `txtMa_Km` | AsTextBox | Mã khuyến mãi (khóa chính) |
| `txtTen_Km` | TextBox | Tên chương trình khuyến mãi |
| `txtMa_Vt` | AsTextBox | Mã vật tư khuyến mãi (lookup) |
| `lblTen_Vt` | Label | Tên vật tư |
| `txtSo_Luong` | AsTextNumeric | Số lượng khuyến mãi |
| `txtDieu_Kien` | TextBox | Điều kiện áp dụng (mô tả) |
| `txtNgay_Bd` | AsMaskedTextBox | Ngày bắt đầu |
| `txtNgay_Kt` | AsMaskedTextBox | Ngày kết thúc |

## Business Logic

### Loại hình khuyến mãi
- **Tặng hàng**: Mua X tặng Y
- **Giảm giá**: Chiết khấu % hoặc số tiền
- **Combo**: Mua combo giá ưu đãi

### Điều kiện áp dụng
- Theo số lượng mua tối thiểu
- Theo giá trị đơn hàng
- Theo thời gian (ngày bắt đầu - kết thúc)
- Theo khách hàng/nhóm khách hàng

## Cấu trúc bảng dữ liệu (dự kiến)

```sql
-- Bảng dmhhkm (Danh mục hàng hóa khuyến mãi)
CREATE TABLE dmhhkm (
    Ma_Km VARCHAR(20) PRIMARY KEY,
    Ten_Km NVARCHAR(255),
    Ma_Vt VARCHAR(20),
    So_Luong DECIMAL(18,2),
    Dieu_Kien NVARCHAR(500),
    Ngay_Bd DATE,
    Ngay_Kt DATE,
    Loai_Km VARCHAR(10),  -- Loại hình khuyến mãi
    Gia_Tri DECIMAL(18,2), -- Giá trị chiết khấu
    -- ... các trường khác
);
```

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls

## Ghi chú

- Hàng hóa khuyến mãi được tự động đề xuất khi lập đơn hàng đủ điều kiện
- Có thể thiết lập nhiều chương trình khuyến mãi đồng thời
- Ưu tiên áp dụng khuyến mãi có lợi nhất cho khách hàng
