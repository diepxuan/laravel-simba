# SODMDGVT.dll - Danh mục đơn giá vật tư

## Tổng quan

DLL quản lý danh mục đơn giá vật tư (Item Unit Price Category) trong module Sales Order (SO) của hệ thống Asia ERP.

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SODMDGVT.dll |
| **Mô tả** | Danh mục đơn giá vật tư |
| **Namespace** | AsiaERP.UserInterface |
| **Phiên bản** | 9.1.0.0 |
| **Copyright** | Asia Software Development JSC |

## Cấu trúc Namespace

### AsiaERP.UserInterface

| Form | Mô tả |
|------|-------|
| `frmSODMDGVT` | Form danh sách đơn giá vật tư, kế thừa từ `frmCategoryList` |
| `frmSODMDGVTEdit` | Form chỉnh sửa đơn giá vật tư, kế thừa từ `frmCategoryEdit` |

## Controls chính trong frmSODMDGVT

### DataGridView Columns
- `dgvcMa_Vt` - Mã vật tư
- `dgvcTen_Vt` - Tên vật tư
- `dgvcMa_Dv` - Mã đơn vị
- `dgvcGia` - Đơn giá
- `dgvcNgay_Ap` - Ngày áp dụng
- `dgvcMa_Nt` - Mã ngoại tệ

### Toolbar Actions
- Thêm mới, Sửa, Xóa, Làm tươi
- Tìm kiếm theo mã/tên vật tư

## Controls chính trong frmSODMDGVTEdit

| Control | Loại | Mô tả |
|---------|------|-------|
| `txtMa_Vt` | AsTextBox | Mã vật tư (lookup từ dmvt) |
| `lblTen_Vt` | Label | Tên vật tư (hiển thị) |
| `txtMa_Dv` | AsTextBox | Mã đơn vị tính |
| `txtGia` | AsTextNumeric | Đơn giá |
| `txtNgay_Ap` | AsMaskedTextBox | Ngày áp dụng |
| `cboMa_Nt` | AsComboBoxNT | Mã ngoại tệ |

## Business Logic

### Lookup/Validation
- `txtMa_Vt`: Lookup từ bảng vật tư (dmvt), tự động điền tên vật tư
- `cboMa_Nt`: Danh sách ngoại tệ từ hệ thống

### Tính toán
- Hỗ trợ đơn giá theo nhiều loại tiền tệ
- Quản lý lịch sử đơn giá theo ngày áp dụng

## Cấu trúc bảng dữ liệu (dự kiến)

```sql
-- Bảng dmdgvt (Danh mục đơn giá vật tư)
CREATE TABLE dmdgvt (
    Ma_Vt VARCHAR(20),
    Ma_Dv VARCHAR(20),
    Ngay_Ap DATE,
    Gia DECIMAL(18,2),
    Ma_Nt VARCHAR(3),
    PRIMARY KEY (Ma_Vt, Ma_Dv, Ngay_Ap)
);
```

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls

## Ghi chú

- Đơn giá vật tư được sử dụng khi lập đơn hàng bán
- Có thể thiết lập đơn giá theo từng đơn vị tính khác nhau
- Hỗ trợ đơn giá theo thời gian (lịch sử giá)
