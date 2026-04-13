# GLVchGL1 - Voucher ghi sổ chung

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLVchGL1.dll |
| Loại | Form nhập liệu (Voucher) |
| Kế thừa | `frmVoucher` |
| Namespace | `AsiaErp.UserInterface` |
| Mã chứng từ | **GL1** |

---

## Chức năng

Nhập liệu và quản lý chứng từ ghi sổ chung (General Ledger Voucher) - loại chứng từ tổng hợp cho các nghiệp vụ kế toán.

---

## Forms

| Form | Mục đích |
|------|----------|
| `frmGlVchGL1` | Form nhập liệu chính |
| `frmGlVchGL1Find` | Form tìm kiếm chứng từ |

---

## Controls chính

### Thông tin chung
- Ngày LCT (Ngày lập chứng từ)
- Tổng tiền nợ / Tổng tiền có
- Thuế GTGT

### Chi tiết chứng từ (DataGridView)

| Cột | Ý nghĩa |
|-----|---------|
| TK | Tài khoản |
| Tên TK | Tên tài khoản |
| Mã KH | Mã khách hàng |
| Tên KH | Tên khách hàng |
| Mã NT | Mã ngoại tệ |
| Tỷ giá | Tỷ giá |
| Ps nợ NT | Phát sinh nợ ngoại tệ |
| Ps có NT | Phát sinh có ngoại tệ |
| Ps nợ | Phát sinh nợ |
| Ps có | Phát sinh có |
| Diễn giải | Diễn giải |
| B. phận | Bộ phận |
| Phí | Phí |
| H. đồng | Hợp đồng |
| SPCT | Sản phẩm chi tiết |
| Nh. DK | Nhóm điều khoản |

### Tab Control

| Tab | Mục đích |
|-----|----------|
| `tabTaIn` | Thuế GTGT đầu vào |
| `tabTaOut` | Thuế GTGT đầu ra |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `ps_no` | Phát sinh nợ |
| `ps_co` | Phát sinh có |
| `ps_no_nt` | Phát sinh nợ ngoại tệ |
| `ps_co_nt` | Phát sinh có ngoại tệ |
| `t_tien` | Tổng tiền |
| `t_thue` | Tổng thuế |
| `t_tt` | Tổng thanh toán |
| `t_tien_nt` | Tổng tiền ngoại tệ |
| `t_thue_nt` | Tổng thuế ngoại tệ |
| `t_tt_nt` | Tổng thanh toán ngoại tệ |
| `ma_kh` | Mã khách hàng |
| `ma_bp` | Mã bộ phận |
| `ma_phi` | Mã phí |
| `ma_hd` | Mã hợp đồng |
| `ma_spct` | Mã sản phẩm chi tiết |
| `nh_dk` | Nhóm điều khoản |

---

## Chức năng chi tiết

### 1. Nhập liệu chứng từ
- Nhập chứng từ phát sinh nghiệp vụ kế toán
- Quản lý thông tin: ngày, số chứng từ, diễn giải
- Xử lý đa tiền tệ (VND và ngoại tệ)

### 2. Chi tiết phát sinh
- Nhập nhiều dòng phát sinh nợ/có
- Hỗ trợ lookup: TK, KH, BP, Phí, HĐ, SPCT
- Tính toán tự động theo tỷ giá

### 3. Quản lý thuế GTGT
- Tab thuế đầu vào (`ctlTaIn`)
- Tab thuế đầu ra (`ctlTaOut`)
- Tính toán thuế tự động

### 4. Tính toán tổng hợp
- Tổng phát sinh nợ/có
- Tổng tiền ngoại tệ
- Tổng thuế GTGT
- Tổng thanh toán

---

## Đặc điểm kỹ thuật

- Kế thừa từ `frmVoucher` - Form chứng từ chuẩn
- Sử dụng `AsInputDGV` cho nhập liệu chi tiết
- DataBinding với BindingSource
- Hỗ trợ nhiều loại tiền tệ với tỷ giá động
- Tích hợp control thuế GTGT

---

## Dependencies

- `AsiaErp.Framework`
- `System.Data`
- `System.Drawing`
- `System.Linq`
- `Microsoft.VisualBasic`

---

*Ngày tạo: 2026-03-29*
