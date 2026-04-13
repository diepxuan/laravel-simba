# SODMGIABAN.dll - Danh mục giá bán

## Tổng quan

DLL quản lý danh mục giá bán (Sales Price Category) trong module Sales Order (SO) của hệ thống Asia ERP.

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SODMGIABAN.dll |
| **Mô tả** | Danh mục giá bán |
| **Namespace** | AsiaErp.UserInterface |
| **Phiên bản** | 9.1.0.0 |
| **Copyright** | Asia Software Development JSC |

## Cấu trúc Namespace

### AsiaErp.UserInterface

| Form | Mô tả |
|------|-------|
| `frmSODMGIABAN` | Form danh sách giá bán, kế thừa từ `frmCategoryList` |
| `frmSODMGIABANEdit` | Form chỉnh sửa giá bán, kế thừa từ `frmCategoryEdit` |

## Controls chính trong frmSODMGIABAN

### DataGridView Columns
- `dgvcMa_Vt` - Mã vật tư
- `dgvcTen_Vt` - Tên vật tư
- `dgvcMa_Kh` - Mã khách hàng (nếu có)
- `dgvcTen_Kh` - Tên khách hàng
- `dgvcGia_Nt2` - Giá bán ngoại tệ
- `dgvcGia2` - Giá bán VND
- `dgvcMa_Nt` - Mã ngoại tệ
- `dgvcNgay_Ap` - Ngày áp dụng

### Toolbar Actions
- Thêm mới, Sửa, Xóa, Làm tươi
- Tìm kiếm theo mã/tên vật tư

## Controls chính trong frmSODMGIABANEdit

| Control | Loại | Mô tả |
|---------|------|-------|
| `txtMa_Vt` | AsTextBox | Mã vật tư (lookup) |
| `lblTen_Vt` | Label | Tên vật tư |
| `txtMa_Kh` | AsTextBox | Mã khách hàng (lookup, optional) |
| `lblTen_Kh` | Label | Tên khách hàng |
| `txtGia_Nt2` | AsTextNumeric | Giá bán ngoại tệ |
| `txtGia2` | AsTextNumeric | Giá bán VND |
| `cboMa_Nt` | AsComboBoxNT | Mã ngoại tệ |
| `txtTy_Gia` | AsTextNumeric | Tỷ giá |
| `txtNgay_Ap` | AsMaskedTextBox | Ngày áp dụng |
| `txtNgay_Hh` | AsMaskedTextBox | Ngày hết hạn |

## Business Logic

### Loại giá bán
| Loại | Mô tả |
|------|-------|
| `GIABAN_CHUNG` | Giá bán chung cho tất cả KH |
| `GIABAN_KH` | Giá bán riêng cho từng KH |
| `GIABAN_NHOM` | Giá bán theo nhóm KH |

### Tính toán giá
```csharp
// Quy đổi giá theo tỷ giá
Gia2 = Gia_Nt2 * Ty_Gia

// Lấy giá bán mặc định từ danh mục
Gia_Ban = GetGiaBan(Ma_Vt, Ma_Kh, Ngay_Ap, Ma_Nt)
```

### Lookup/Validation
- `txtMa_Vt`: Lookup từ bảng vật tư (dmvt)
- `txtMa_Kh`: Lookup từ bảng khách hàng (dmkh), có thể để trống cho giá chung
- `cboMa_Nt`: Danh sách ngoại tệ từ hệ thống

### Ưu tiên lấy giá
1. Giá bán riêng của khách hàng + vật tư
2. Giá bán theo nhóm khách hàng + vật tư
3. Giá bán chung của vật tư
4. Giá từ bảng giá mặc định

## Cấu trúc bảng dữ liệu (dự kiến)

```sql
-- Bảng dmgiaban (Danh mục giá bán)
CREATE TABLE dmgiaban (
    Ma_Vt VARCHAR(20),
    Ma_Kh VARCHAR(20),      -- NULL nếu là giá chung
    Ma_Nh_Kh VARCHAR(20),   -- Nhóm KH (nếu có)
    Ngay_Ap DATE,
    Ngay_Hh DATE,           -- Ngày hết hạn
    Gia_Nt2 DECIMAL(18,2),
    Gia2 DECIMAL(18,2),
    Ma_Nt VARCHAR(3),
    Ty_Gia DECIMAL(18,2),
    PRIMARY KEY (Ma_Vt, Ma_Kh, Ngay_Ap)
);
```

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls

## Ghi chú

- Giá bán được tự động lấy khi lập đơn hàng/hóa đơn
- Có thể thiết lập giá theo từng khách hàng riêng biệt
- Hỗ trợ giá theo thời gian (có ngày bắt đầu - kết thúc)
- Hỗ trợ đa tiền tệ
