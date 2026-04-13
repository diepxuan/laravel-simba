# SODMHTTT.dll - Danh mục hình thức thanh toán

## Tổng quan

DLL quản lý danh mục hình thức thanh toán (Payment Method Category) trong module Sales Order (SO) của hệ thống Asia ERP.

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SODMHTTT.dll |
| **Mô tả** | Danh mục hình thức thanh toán |
| **Namespace** | AsiaErp.UserInterface |
| **Phiên bản** | 9.1.0.0 |
| **Copyright** | Asia Software Development JSC |

## Cấu trúc Namespace

### AsiaErp.UserInterface

| Form | Mô tả |
|------|-------|
| `frmSODMHTTT` | Form danh sách hình thức thanh toán, kế thừa từ `frmCategoryList` |
| `frmSODMHTTTEdit` | Form chỉnh sửa hình thức thanh toán, kế thừa từ `frmCategoryEdit` |

## Controls chính trong frmSODMHTTT

### DataGridView Columns
- `dgvcMa_Httt` - Mã hình thức thanh toán
- `dgvcTen_Httt` - Tên hình thức thanh toán
- `dgvcTk` - Tài khoản kế toán
- `dgvcTk_Thue_Gtgt_Ban` - TK thuế GTGT bán
- `dgvcTk_Ck` - Tài khoản chiết khấu

### Toolbar Actions
- Thêm mới, Sửa, Xóa, Làm tươi
- Tìm kiếm theo mã/tên hình thức

## Controls chính trong frmSODMHTTTEdit

| Control | Loại | Mô tả |
|---------|------|-------|
| `txtMa_Httt` | AsTextBox | Mã hình thức thanh toán (khóa chính) |
| `txtTen_Httt` | TextBox | Tên hình thức thanh toán |
| `txtTk` | AsTextBox | Tài khoản phải thu (lookup TK) |
| `lblTen_Tk` | Label | Tên tài khoản |
| `txtTk_Thue_Gtgt_Ban` | AsTextBox | TK thuế GTGT bán |
| `txtTk_Ck` | AsTextBox | TK chiết khấu thanh toán |
| `cboLoai` | ComboBox | Loại hình thức (TM/CK/...) |

## Business Logic

### Các hình thức thanh toán
| Mã | Tên | Mô tả |
|----|-----|-------|
| TM | Tiền mặt | Thanh toán bằng tiền mặt |
| CK | Chuyển khoản | Thanh toán qua ngân hàng |
| TM/CK | Tiền mặt/Chuyển khoản | Kết hợp cả hai |

### Lookup/Validation
- `txtTk`: Lookup từ bảng TK, điều kiện `chi_tiet=1`
- `txtTk_Thue_Gtgt_Ban`: Lookup TK thuế GTGT
- `txtTk_Ck`: Lookup TK chiết khấu

### Tài khoản kế toán
- Khi chọn hình thức thanh toán trên hóa đơn, hệ thống tự động lấy:
  - TK phải thu khách hàng
  - TK thuế GTGT bán hàng
  - TK chiết khấu thanh toán (nếu có)

## Cấu trúc bảng dữ liệu (dự kiến)

```sql
-- Bảng dmhttt (Danh mục hình thức thanh toán)
CREATE TABLE dmhttt (
    Ma_Httt VARCHAR(20) PRIMARY KEY,
    Ten_Httt NVARCHAR(255),
    Tk VARCHAR(20),              -- TK phải thu
    Tk_Thue_Gtgt_Ban VARCHAR(20), -- TK thuế GTGT bán
    Tk_Ck VARCHAR(20),           -- TK chiết khấu
    Loai VARCHAR(10),            -- Loại HTTT
    ModuleId VARCHAR(10),        -- Module áp dụng (SO)
    -- ... các trường khác
);
```

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls

## Ghi chú

- Hình thức thanh toán được gán cho khách hàng mặc định
- Có thể thay đổi khi lập hóa đơn
- Ảnh hưởng đến việc hạch toán kế toán và công nợ
