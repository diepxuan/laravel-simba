# CAVchCA2.dll - Voucher chi tiền mặt/chuyển khoản

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CAVchCA2.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCaVchCA2, frmCaVchCA2Find, frmCaVchCa2FindPO7TAIN |
| **Kế thừa** | frmVoucher |
| **Chức năng** | Voucher chi tiền mặt/chuyển khoản (PC) |

## 2. Forms chi tiết

### frmCaVchCA2 (Voucher Form)

**Controls - Header (gbPH):**
| Control | Type | DataField | Mô tả |
|---------|------|-----------|-------|
| txtMa_Kh | AsTextBox | Ma_Kh | Mã khách hàng |
| lblTen_Kh | Label | Ten_Kh | Tên khách hàng |
| txtDia_chi | TextBox | Dia_chi | Địa chỉ |
| txtNguoi_Gd | TextBox | Nguoi_Gd | Người giao dịch |
| txtDien_giai | TextBox | Dien_Giai | Diễn giải |
| txtTk_Co | AsTextBox | tk_co | TK có (TM/NH) |
| lblTen_Tk_Co | Label | ten_tk_co | Tên TK có |
| txtNgay_lct | AsMaskedTextBox | ngay_lct | Ngày lập CT |
| cboMa_NT | AsComboBoxNT | ma_nt | Mã ngoại tệ |
| txtTy_gia | AsTextNumeric | ty_gia | Tỷ giá |
| txtT_tien_Nt | AsTextNumeric | t_tien_nt | Tổng tiền NT |
| txtT_Tien | AsTextNumeric | t_tien | Tổng tiền |
| txtT_thue_Nt | AsTextNumeric | t_thue_nt | Tổng thuế NT |
| txtT_Thue | AsTextNumeric | t_thue | Tổng thuế |
| txtT_tt_Nt | AsTextNumeric | t_tt_nt | Tổng TT NT |
| txtT_Tt | AsTextNumeric | t_tt | Tổng TT |
| tabTax | TabPage | - | Tab thuế |
| ctlTaIn | ctlTaIn | - | Control thuế đầu vào |
| cmdGetTaInFromDetail | Button | - | Lấy thuế từ chi tiết |
| btnVAT_NK | Button | - | Xử lý VAT NK |
| chkTg_gs_dd | CheckBox | tg_gs_dd | Tỷ giá ghi sổ đích danh |

**Controls - Detail Grid (adgvDetail):**
| Column | Type | DataField | Mô tả |
|--------|------|-----------|-------|
| dgvcTk | DataGridViewAsTextBoxColumn | tk | TK nợ |
| dgvcTen_tk | DataGridViewTextBoxColumn | ten_tk | Tên TK |
| dgvcPs_no_nt | DataGridViewAsTextNumericColumn | ps_no_nt | PS nợ NT |
| dgvcPs_no | DataGridViewAsTextNumericColumn | ps_no | PS nợ VND |
| dgvcMa_kh | DataGridViewAsTextBoxColumn | ma_kh | Mã KH |
| dgvcTen_kh | DataGridViewTextBoxColumn | ten_kh | Tên KH |
| dgvcDu13 | DataGridViewTextBoxColumn | du13 | Dư |
| dgvcDien_giai | DataGridViewTextBoxColumn | dien_giai | Diễn giải |
| dgvcSn_hu | DataGridViewAsTextNumericColumn | sn_hu | Số nhà/HD |
| dgvcMa_bp | DataGridViewAsTextBoxColumn | ma_bp | Mã bộ phận |
| dgvcMa_phi | DataGridViewAsTextBoxColumn | ma_phi | Mã phí |
| dgvcMa_hd | DataGridViewAsTextBoxColumn | ma_hd | Mã hợp đồng |
| dgvcMa_ku | DataGridViewAsTextBoxColumn | ma_ku | Mã khế ước |
| dgvcMa_spct | DataGridViewAsTextBoxColumn | ma_spct | Mã SP chi tiết |

**Events:**
- `cboMa_NT_SelectedValueChanged`: Cập nhật tỷ giá, ẩn/hiện cột VND
- `txtMa_Kh_AfterCodeValidating`: Load thông tin KH (địa chỉ, người GD)
- `txtTy_gia_ValueChanged`: Tính lại PS nợ VND = PS nợ NT × Tỷ giá
- `txtDien_giai_Validated`: Copy diễn giải xuống dòng chi tiết
- `txtTk_Co_Validated`: Validate TK có
- `adgvDetail_CellValueChanged`: Xử lý thay đổi giá trị cell
- `adgvDetail_CellEnter`: Hiển thị tooltip khi focus vào cell
- `RefreshDGVInput()`: Ẩn/hiện cột VND, cập nhật header
- `cmdGetTaInFromDetail_Click