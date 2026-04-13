# SOVchSO1.dll - Voucher đơn hàng bán

## Tổng quan

DLL quản lý voucher đơn hàng bán (Sales Order Voucher) trong module Sales Order (SO) của hệ thống Asia ERP.

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SOVchSO1.dll |
| **Mô tả** | Đơn hàng bán |
| **Namespace** | AsiaErp.UserInterface |
| **Phiên bản** | 9.1.0.0 |
| **Copyright** | Asia Software Development JSC |

## Cấu trúc Namespace

### AsiaErp.UserInterface

| Form | Mô tả |
|------|-------|
| `frmSoVchSO1` | Form voucher đơn hàng bán, kế thừa từ `frmVoucher` |
| `frmSoVchSO1Find` | Form tìm kiếm đơn hàng bán, kế thừa từ `frmVoucherFind` |

## Controls chính trong frmSoVchSO1

### Phần thông tin chung (gbPH)
| Control | Loại | Mô tả |
|---------|------|-------|
| `txtMa_Kh` | AsTextBox | Mã khách hàng (lookup) |
| `lblTen_Kh` | Label | Tên khách hàng |
| `txtDia_Chi` | TextBox | Địa chỉ giao hàng |
| `txtNguoi_Gd` | TextBox | Người giao dịch |
| `txtMa_Nvkd` | AsTextBox | Mã nhân viên KD (lookup) |
| `lblTen_Nvkd` | Label | Tên nhân viên KD |
| `txtMa_Httt` | AsTextBox | Mã hình thức thanh toán |
| `txtMa_Tt` | AsTextBox | Mã điều khoản thanh toán |
| `txtNgay_Hh` | AsMaskedTextBox | Ngày hết hạn giao hàng |
| `txtDien_Giai` | TextBox | Diễn giải |

### Phần chi tiết (TabControl)
- **Tab Chi tiết**: DataGridView nhập chi tiết đơn hàng
- **Tab Hạch toán**: Thông tin hạch toán kế toán

### DataGridView Columns (adgvDetail)
| Column | Mô tả |
|--------|-------|
| `dgvcMa_Vt` | Mã vật tư |
| `dgvcTen_Vt` | Tên vật tư |
| `dgvcDvt` | Đơn vị tính |
| `dgvcMa_Kho` | Mã kho |
| `dgvcTon` | Tồn kho |
| `dgvcSo_Luong` | Số lượng |
| `dgvcGia_Nt2` | Giá bán ngoại tệ |
| `dgvcTien_Nt2` | Tiền hàng ngoại tệ |
| `dgvcTl_Ck` | Tỷ lệ chiết khấu |
| `dgvcTien_Ck_Nt` | Tiền chiết khấu |
| `dgvcThue_Gtgt_Nt` | Thuế GTGT |
| `dgvcMa_Nvkd` | NVKD phụ trách dòng hàng |

## Controls chính trong frmSoVchSO1Find

| Control | Loại | Mô tả |
|---------|------|-------|
| `txtMa_Kh` | AsTextBox | Tìm theo mã khách hàng |
| `txtMa_Vt` | AsTextBox | Tìm theo mã vật tư |
| `txtMa_Kho` | AsTextBox | Tìm theo mã kho |
| `txtMa_Nvkd` | AsTextBox | Tìm theo NVKD |
| `txtngay_hh1/2` | AsMaskedTextBox | Tìm theo khoảng ngày hết hạn |
| `cboTrang_Thai` | AsComboBoxTT | Tìm theo trạng thái đơn hàng |

## Business Logic

### Trạng thái đơn hàng
| Trạng thái | Mô tả |
|------------|-------|
| `0` | Nháp |
| `1` | Chờ duyệt |
| `2` | Đã duyệt |
| `3` | Đang giao hàng |
| `4` | Hoàn thành |
| `5` | Hủy |

### Events chính
- `txtMa_Kh.AfterCodeValidating`: Tự động điền thông tin khách hàng
- `adgvDetail.CellValueChanged`: Tính toán tiền hàng, chiết khấu, thuế
- `adgvDetail.CellValidating`: Kiểm tra tồn kho khi nhập số lượng

### Tính toán
```csharp
// Tính tiền hàng
Tien_Nt2 = So_Luong * Gia_Nt2

// Tính chiết khấu
Tien_Ck_Nt = Tien_Nt2 * Tl_Ck / 100

// Tính thuế GTGT
Thue_Gtgt_Nt = (Tien_Nt2 - Tien_Ck_Nt) * Ts_Gtgt / 100

// Tính tổng thanh toán
T_Tt_Nt = Tien_Nt2 - Tien_Ck_Nt + Thue_Gtgt_Nt
```

## Cấu trúc bảng dữ liệu (dự kiến)

```sql
-- Bảng SO1 (Đơn hàng bán - Phần đầu)
CREATE TABLE SO1 (
    Stt_Rec VARCHAR(20) PRIMARY KEY,
    Ma_Ct VARCHAR(10),      -- Loại chứng từ (SO1)
    Ngay_Ct DATE,
    So_Ct VARCHAR(20),
    Ma_Kh VARCHAR(20),
    Ma_Nvkd VARCHAR(20),
    Ma_Httt VARCHAR(20),
    Ma_Tt VARCHAR(20),
    Ngay_Hh DATE,           -- Ngày hết hạn giao
    Dien_Giai NVARCHAR(500),
    T_Tien_Nt2 DECIMAL(18,2),
    T_Tien_Ck_Nt DECIMAL(18,2),
    T_Thue_Gtgt_Nt DECIMAL(18,2),
    T_Tt_Nt DECIMAL(18,2),
    Trang_Thai VARCHAR(1),
    -- ... các trường khác
);

-- Bảng SO2 (Đơn hàng bán - Chi tiết)
CREATE TABLE SO2 (
    Stt_Rec VARCHAR(20),
    Stt_Rec0 VARCHAR(5),    -- Số thứ tự dòng
    Ma_Vt VARCHAR(20),
    Ma_Kho VARCHAR(20),
    So_Luong DECIMAL(18,2),
    Gia_Nt2 DECIMAL(18,2),
    Tien_Nt2 DECIMAL(18,2),
    Tl_Ck DECIMAL(5,2),
    Tien_Ck_Nt DECIMAL(18,2),
    Ma_Thue VARCHAR(20),
    Thue_Gtgt_Nt DECIMAL(18,2),
    Ma_Nvkd VARCHAR(20),
    -- ... các trường khác
    PRIMARY KEY (Stt_Rec, Stt_Rec0)
);
```

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls
- AsiaErp.SOUtilities

## Ghi chú

- Đơn hàng bán là chứng từ nguồn cho phiếu xuất kho và hóa đơn bán hàng
- Hỗ trợ đa tiền tệ với tỷ giá tự động
- Kiểm tra tồn kho tức thời khi nhập liệu
