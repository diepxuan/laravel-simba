# SOVchSO3.dll - Voucher hóa đơn bán hàng

## Tổng quan

DLL quản lý voucher hóa đơn bán hàng (Sales Invoice Voucher) trong module Sales Order (SO) của hệ thống Asia ERP.

## Thông tin cơ bản

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên DLL** | SOVchSO3.dll |
| **Mô tả** | Hóa đơn bán hàng |
| **Namespace** | AsiaErp.UserInterface |
| **Phiên bản** | 9.1.0.0 |
| **Copyright** | Asia Software Development JSC |

## Cấu trúc Namespace

### AsiaErp.UserInterface

| Form | Mô tả |
|------|-------|
| `frmSoVchSO3` | Form voucher hóa đơn bán hàng, kế thừa từ `frmVoucher` |

## Controls chính trong frmSoVchSO3

### Phần thông tin chung (gbPH)
| Control | Loại | Mô tả |
|---------|------|-------|
| `txtMa_Kh` | AsTextBox | Mã khách hàng (lookup) |
| `lblTen_Kh` | Label | Tên khách hàng |
| `txtTen_Kh` | TextBox | Tên khách hàng (editable) |
| `txtDia_Chi_Vat` | TextBox | Địa chỉ xuất hóa đơn |
| `txtNguoi_Gd` | TextBox | Người mua |
| `txtMa_So_Thue` | TextBox | Mã số thuế KH |
| `txtSo_Seri` | TextBox | Số seri hóa đơn |
| `txtSo_Ct` | TextBox | Số hóa đơn |
| `txtNgay_Ct` | AsMaskedTextBox | Ngày hóa đơn |
| `txtNgay_Lct` | AsMaskedTextBox | Ngày lập chứng từ |
| `cboMa_NT` | AsComboBoxNT | Mã ngoại tệ |
| `txtTy_Gia` | AsTextNumeric | Tỷ giá |
| `txtMa_Httt` | AsTextBox | Mã hình thức thanh toán |
| `cboHttt` | ComboBox | Hình thức thanh toán (TM/CK) |
| `txtTk_Pt` | AsTextBox | Tài khoản phải thu |
| `txtTk_Thue` | AsTextBox | Tài khoản thuế GTGT |
| `txtSo_Px` | TextBox | Số phiếu xuất kho liên quan |
| `txtGh_No` | AsTextNumeric | Giới hạn công nợ |
| `txtDu13` | AsTextNumeric | Dư hiện thời của KH |

### TabControl
| Tab | Mô tả |
|-----|-------|
| `tabDetail` | Chi tiết hàng hóa/dịch vụ |
| `tabHach_Toan` | Thông tin hạch toán kế toán |
| `tabOptFields` | Trường tùy chọn |

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
| `dgvcTs_Gtgt` | Thuế suất GTGT |
| `dgvcThue_Gtgt_Nt` | Thuế GTGT ngoại tệ |
| `dgvcGia2` | Giá bán VND |
| `dgvcTien2` | Tiền hàng VND |
| `dgvcMa_Nvkd` | Mã nhân viên KD |
| `dgvcTk_Dt` | TK doanh thu |
| `dgvcTk_Gv` | TK giá vốn |
| `dgvcTk_Vt` | TK kho |
| `dgvcTk_Ck` | TK chiết khấu |

### Tổng cộng (Footer)
| Control | Mô tả |
|---------|-------|
| `txtT_So_Luong` | Tổng số lượng |
| `txtT_Tien_Nt2` | Tổng tiền hàng NT |
| `txtT_Tien2` | Tổng tiền hàng VND |
| `txtT_Ck_Nt` | Tổng chiết khấu NT |
| `txtT_Ck` | Tổng chiết khấu VND |
| `txtT_Thue_Nt` | Tổng thuế GTGT NT |
| `txtT_Thue` | Tổng thuế GTGT VND |
| `txtT_Tt_Nt` | Tổng thanh toán NT |
| `txtT_Tt` | Tổng thanh toán VND |
| `txtTl_Ck_Ds` | Tỷ lệ CK doanh số |
| `txtT_Ck_Ds_Nt` | Tiền CK doanh số NT |
| `txtT_Ck_Ds` | Tiền CK doanh số VND |

## Business Logic

### Loại hóa đơn
```csharp
private const string HOA_DON_KIEM_PHIEU_XUAT = "1";  // Hóa đơn kiêm phiếu xuất
private const string HOA_DON = "2";                   // Chỉ là hóa đơn
```

### Events chính
- `txtMa_Kh.AfterCodeValidating`: Điền thông tin KH (tên, địa chỉ, MST, người GD, HTTT)
- `txtMa_Httt.AfterCodeValidating`: Điền TK phải thu, TK thuế, TK chiết khấu
- `txtTy_Gia.ValueChanged`: Quy đổi ngoại tệ sang VND
- `adgvDetail.CellValueChanged`: Tính toán tiền hàng, chiết khấu, thuế
- `adgvDetail.CellValidating`: Kiểm tra tồn kho
- `txtTl_Ck_Ds.ValueChanged`: Tính chiết khấu doanh số

### Tính toán
```csharp
// Tính tiền hàng
Tien_Nt2 = So_Luong * Gia_Nt2
Tien2 = Tien_Nt2 * Ty_Gia

// Tính chiết khấu mặt hàng
Tien_Ck_Nt = Tien_Nt2 * Tl_Ck / 100

// Tính thuế GTGT
Thue_Gtgt_Nt = (Tien_Nt2 - Tien_Ck_Nt) * Ts_Gtgt / 100

// Tính chiết khấu doanh số
T_Ck_Ds_Nt = T_Tien_Nt2 * Tl_Ck_Ds / 100

// Tính tổng thanh toán
T_Tt_Nt = Tien_Nt2 - Tien_Ck_Nt + Thue_Gtgt_Nt - Ck_Ds
```

### Hạch toán kế toán
| Nợ | Có | Số tiền |
|----|----|---------|
| TK Phải thu KH | | T_Tt |
| | TK Doanh thu | T_Tien2 |
| | TK Thuế GTGT | T_Thue |
| TK Giá vốn | | T_Tien |
| | TK Kho | T_Tien |

## Cấu trúc bảng dữ liệu (dự kiến)

```sql
-- Bảng SO3 (Hóa đơn bán hàng - Phần đầu)
CREATE TABLE SO3 (
    Stt_Rec VARCHAR(20) PRIMARY KEY,
    Ma_Ct VARCHAR(10),      -- Loại chứng từ (SO3)
    Ngay_Ct DATE,
    So_Ct VARCHAR(20),      -- Số hóa đơn
    So_Seri VARCHAR(20),    -- Số seri hóa đơn
    Ma_Kh VARCHAR(20),
    Ten_Kh NVARCHAR(255),
    Dia_Chi_Vat NVARCHAR(500),
    Ma_So_Thue VARCHAR(20),
    Nguoi_Gd NVARCHAR(100),
    Ma_Httt VARCHAR(20),
    Ma_Nt VARCHAR(3),
    Ty_Gia DECIMAL(18,2),
    Tk_Pt VARCHAR(20),      -- TK phải thu
    Tk_Thue VARCHAR(20),    -- TK thuế GTGT
    Tk_Ck_Ds VARCHAR(20),   -- TK chiết khấu doanh số
    So_Px VARCHAR(20),      -- Số phiếu xuất liên quan
    T_Tien_Nt2 DECIMAL(18,2),
    T_Tien2 DECIMAL(18,2),
    T_Ck_Nt DECIMAL(18,2),
    T_Ck DECIMAL(18,2),
    T_Ck_Ds_Nt DECIMAL(18,2),
    T_Ck_Ds DECIMAL(18,2),
    T_Thue_Nt DECIMAL(18,2),
    T_Thue DECIMAL(18,2),
    T_Tt_Nt DECIMAL(18,2),
    T_Tt DECIMAL(18,2),
    -- ... các trường khác
);

-- Bảng SO4 (Hóa đơn bán hàng - Chi tiết)
CREATE TABLE SO4 (
    Stt_Rec VARCHAR(20),
    Stt_Rec0 VARCHAR(5),
    Ma_Vt VARCHAR(20),
    Ma_Kho VARCHAR(20),
    So_Luong DECIMAL(18,2),
    Gia_Nt2 DECIMAL(18,2),
    Tien_Nt2 DECIMAL(18,2),
    Gia2 DECIMAL(18,2),
    Tien2 DECIMAL(18,2),
    Tl_Ck DECIMAL(5,2),
    Tien_Ck_Nt DECIMAL(18,2),
    Tien_Ck DECIMAL(18,2),
    Ma_Thue VARCHAR(20),
    Ts_Gtgt DECIMAL(5,2),
    Thue_Gtgt_Nt DECIMAL(18,2),
    Thue_Gtgt DECIMAL(18,2),
    Ma_Nvkd VARCHAR(20),
    Tk_Dt VARCHAR(20),      -- TK doanh thu
    Tk_Gv VARCHAR(20),      -- TK giá vốn
    Tk_Vt VARCHAR(20),      -- TK kho
    Tk_Ck VARCHAR(20),      -- TK chiết khấu
    -- ... các trường khác
    PRIMARY KEY (Stt_Rec, Stt_Rec0)
);
```

## Dependencies

- AsiaErp.Framework
- AsiaErp.Commons
- AsiaErp.Controls
- AsiaErp.SOUtilities
- CrystalDecisions.Shared (báo cáo)

## Ghi chú

- Hóa đơn bán hàng có thể liên kết với phiếu xuất kho (So_Px)
- Hỗ trợ in hóa đơn VAT qua Crystal Reports
- Có thể tạo hóa đơn từ đơn hàng bán (SO1)
- Chiết khấu doanh số được phân bổ theo từng dòng hàng
- Kiểm tra giới hạn công nợ (Gh_No) và dư hiện thời (Du13) của khách hàng
