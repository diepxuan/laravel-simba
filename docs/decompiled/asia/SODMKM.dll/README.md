# SODMKM.dll - Danh mục khuyến mãi

## Tổng quan

DLL quản lý danh mục khuyến mãi (Promotion Category) trong module Sales Order (SO) của hệ thống Asia ERP.

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SODMKM.dll |
| **Mô tả** | Danh mục khuyến mãi |
| **Namespace** | AsiaERP.UserInterface |
| **Phiên bản** | 9.1.0.0 |
| **Copyright** | Asia Software Development JSC |

## Cấu trúc Namespace

### AsiaERP.UserInterface

| Form | Mô tả |
|------|-------|
| `frmSODMKM` | Form danh sách khuyến mãi, kế thừa từ `frmCategoryList` |
| `frmSODMKMEdit` | Form chỉnh sửa khuyến mãi, kế thừa từ `frmCategoryEdit` |

## Controls chính trong frmSODMKM

### DataGridView Columns
- `dgvcMa_Ct` - Mã chương trình khuyến mãi
- `dgvcTen_Ct` - Tên chương trình
- `dgvcNgay_Bd` - Ngày bắt đầu
- `dgvcNgay_Kt` - Ngày kết thúc
- `dgvcTrang_Thai` - Trạng thái (Hoạt động/Kết thúc)
- `dgvcLoai_Km` - Loại khuyến mãi

### Toolbar Actions
- Thêm mới, Sửa, Xóa, Làm tươi
- Tìm kiếm theo mã/tên chương trình

## Controls chính trong frmSODMKMEdit

| Control | Loại | Mô tả |
|---------|------|-------|
| `txtMa_Ct` | AsTextBox | Mã chương trình khuyến mãi (khóa chính) |
| `txtTen_Ct` | TextBox | Tên chương trình |
| `txtNgay_Bd` | AsMaskedTextBox | Ngày bắt đầu |
| `txtNgay_Kt` | AsMaskedTextBox | Ngày kết thúc |
| `cboLoai_Km` | ComboBox | Loại khuyến mãi |
| `txtGia_Tri` | AsTextNumeric | Giá trị khuyến mãi (%, số tiền) |
| `txtDieu_Kien` | TextBox | Điều kiện áp dụng |
| `chkHoat_Dong` | AsCheckBox | Trạng thái hoạt động |

## Business Logic

### Loại khuyến mãi
| Loại | Mô tả |
|------|-------|
| `CK` | Chiết khấu % trên đơn hàng |
| `TIEN` | Giảm số tiền cố định |
| `TANG` | Tặng hàng/sản phẩm |
| `FREE_SHIP` | Miễn phí vận chuyển |
| `COMBO` | Giá combo ưu đãi |

### Điều kiện áp dụng
- Theo giá trị đơn hàng tối thiểu
- Theo số lượng sản phẩm
- Theo khách hàng/nhóm khách hàng cụ thể
- Theo thời gian (ngày bắt đầu - kết thúc)
- Theo khu vực địa lý

### Validation
- Kiểm tra ngày bắt đầu < ngày kết thúc
- Kiểm tra trùng lặp chương trình trong cùng thời gian

## Cấu trúc bảng dữ liệu (dự kiến)

```sql
-- Bảng dmkm (Danh mục khuyến mãi)
CREATE TABLE dmkm (
    Ma_Ct VARCHAR(20) PRIMARY KEY,
    Ten_Ct NVARCHAR(255),
    Ngay_Bd DATE,
    Ngay_Kt DATE,
    Loai_Km VARCHAR(10),
    Gia_Tri DECIMAL(18,2),
    Dieu_Kien NVARCHAR(500),
    Hoat_Dong BIT DEFAULT 1,
    Ma_Nh_Kh VARCHAR(20),  -- Nhóm khách hàng áp dụng
    Gia_Tri_Min DECIMAL(18,2), -- Giá trị đơn hàng tối thiểu
    -- ... các trường khác
);
```

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls

## Ghi chú

- Một chương trình khuyến mãi có thể áp dụng cho nhiều sản phẩm
- Có thể thiết lập độ ưu tiên cho các chương trình khuyến mãi
- Tự động kiểm tra và áp dụng khi lập đơn hàng
