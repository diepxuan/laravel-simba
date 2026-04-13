# SODMDKTT.dll - Danh mục điều khoản thanh toán

## Tổng quan

DLL quản lý danh mục điều khoản thanh toán (Payment Terms Category) trong module Sales Order (SO) của hệ thống Asia ERP.

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SODMDKTT.dll |
| **Mô tả** | Danh mục điều khoản thanh toán |
| **Namespace** | AsiaErp.UserInterface |
| **Phiên bản** | 9.1.0.0 |
| **Copyright** | Asia Software Development JSC |

## Cấu trúc Namespace

### AsiaErp.UserInterface

| Form | Mô tả |
|------|-------|
| `frmSODMDKTT` | Form danh sách điều khoản thanh toán, kế thừa từ `frmCategoryList` |
| `frmSODMTTEdit` | Form chỉnh sửa điều khoản thanh toán, kế thừa từ `frmCategoryEdit` |

## Controls chính trong frmSODMDKTT

### DataGridView Columns
- `dgvcMa_Tt` - Mã điều khoản thanh toán
- `dgvcTen_Tt` - Tên điều khoản
- `dgvcHan_Ck` - Hạn chiết khấu (ngày)
- `dgvcTl_Ck` - Tỷ lệ chiết khấu (%)
- `dgvcHan_Tt` - Hạn thanh toán (ngày)
- `dgvcLs_Qh` - Lãi suất quá hạn

### Toolbar Actions
- Thêm mới, Sửa, Xóa, Làm tươi
- Tìm kiếm theo mã/tên điều khoản

## Controls chính trong frmSODMTTEdit

| Control | Loại | Mô tả |
|---------|------|-------|
| `txtMa_Tt` | AsTextBox | Mã điều khoản thanh toán (khóa chính) |
| `txtTen_Tt` | TextBox | Tên điều khoản |
| `txtHan_Ck` | AsTextNumeric | Hạn chiết khấu (số ngày) |
| `txtTl_Ck` | AsTextNumeric | Tỷ lệ chiết khấu (%) |
| `txtHan_Tt` | AsTextNumeric | Hạn thanh toán (số ngày) |
| `txtLs_Qh` | AsTextNumeric | Lãi suất quá hạn (%) |
| `txtMo_Ta` | TextBox | Mô tả chi tiết |

## Business Logic

### Tính toán hạn thanh toán
```csharp
// Tính ngày hết hạn thanh toán
Ngay_Hh = Ngay_Ct + Han_Tt

// Tính ngày hết hạn chiết khấu
Ngay_Hh_Ck = Ngay_Ct + Han_Ck
```

### Chiết khấu thanh toán
- Tính chiết khấu dựa trên tỷ lệ % và hạn chiết khấu
- Tự động tính toán khi thanh toán trước hạn

## Cấu trúc bảng dữ liệu (dự kiến)

```sql
-- Bảng dmtt (Danh mục điều khoản thanh toán)
CREATE TABLE dmtt (
    Ma_Tt VARCHAR(20) PRIMARY KEY,
    Ten_Tt NVARCHAR(255),
    Han_Ck INT,          -- Hạn chiết khấu (ngày)
    Tl_Ck DECIMAL(5,2),  -- Tỷ lệ chiết khấu
    Han_Tt INT,          -- Hạn thanh toán (ngày)
    Ls_Qh DECIMAL(5,2),  -- Lãi suất quá hạn
    Mo_Ta NVARCHAR(500),
    -- ... các trường khác
);
```

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls

## Ghi chú

- Điều khoản thanh toán được gán cho khách hàng và áp dụng khi lập hóa đơn
- Hỗ trợ chiết khấu sớm cho thanh toán trước hạn
- Tính lãi quá hạn cho thanh toán trễ
