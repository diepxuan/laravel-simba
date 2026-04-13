# CAVchCA3.dll - Voucher báo nợ ngân hàng

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CAVchCA3.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCaVchCA3, frmCaVchCA3Find |
| **Kế thừa** | frmVoucher |
| **Chức năng** | Voucher báo nợ ngân hàng (UNC) |

## 2. Forms chi tiết

### frmCaVchCA3 (Voucher Form)

**Controls - Header (gbPH):**
| Control | Type | DataField | Mô tả |
|---------|------|-----------|-------|
| txtMa_Kh | AsTextBox | Ma_Kh | Mã khách hàng |
| lblTen_Kh | Label | Ten_Kh | Tên khách hàng |
| txtDia_chi | TextBox | Dia_chi | Địa chỉ |
| txtNguoi_Gd | TextBox | Nguoi_Gd | Người giao dịch |
| txtDien_giai | TextBox | Dien_Giai | Diễn giải |
| txtTk_No | AsTextBox | tk_no | TK nợ (NH) |
| lblTen_Tk_No | Label | ten_tk_no | Tên TK nợ |
| txtNgay_lct | AsMaskedTextBox | ngay_lct | Ngày lập CT |
| cboMa_NT | AsComboBoxNT | ma_nt | Mã ngoại tệ |
| txtTy_gia | AsTextNumeric | ty_gia | Tỷ giá |
| txtT_Tien | AsTextNumeric | t_tien | Tổng tiền |
| txtT_tien_Nt | AsTextNumeric | t_tien_nt | Tổng tiền NT |
| lblT_Tien | Label | - | Nhãn "Tổng tiền" |
| chkTg_gs_dd | CheckBox | tg_gs_dd | Tỷ giá ghi sổ đích danh |

**Controls - Detail Grid (adgvDetail):**
| Column | Type | DataField | Mô tả |
|--------|------|-----------|-------|
| dgvcTk | DataGridViewAsTextBoxColumn | tk | TK có |
| dgvcTen_tk | DataGridViewTextBoxColumn | ten_tk | Tên TK |
| dgvcPs_co_nt | DataGridViewAsTextNumericColumn | ps_co_nt | PS có NT |
| dgvcPs_co | DataGridViewAsTextNumericColumn | ps_co | PS có VND |
| dgvcMa_kh | DataGridViewAsTextBoxColumn | ma_kh | Mã KH |
| dgvcTen_kh | DataGridViewTextBoxColumn | ten_kh | Tên KH |
| dgvcDu13 | DataGridViewTextBoxColumn | du13 | Dư |
| dgvcDien_giai | DataGridViewTextBoxColumn | dien_giai | Diễn giải |
| dgvcMa_bp | DataGridViewAsTextBoxColumn | ma_bp | Mã bộ phận |
| dgvcMa_phi | DataGridViewAsTextBoxColumn | ma_phi | Mã phí |
| dgvcMa_hd | DataGridViewAsTextBoxColumn | ma_hd | Mã hợp đồng |
| dgvcMa_ku | DataGridViewAsTextBoxColumn | ma_ku | Mã khế ước |
| dgvcMa_spct | DataGridViewAsTextBoxColumn | ma_spct | Mã SP chi tiết |

**Events:**
- `cboMa_NT_SelectedValueChanged`: Cập nhật tỷ giá, ẩn/hiện cột VND
- `txtMa_Kh_AfterCodeValidating`: Load thông tin KH (địa chỉ, người GD)
- `txtTy_gia_ValueChanged`: Tính lại PS có VND = PS có NT × Tỷ giá
- `txtDien_giai_Validated`: Copy diễn giải xuống dòng chi tiết
- `adgvDetail_CellValueChanged`: Xử lý thay đổi giá trị cell
- `adgvDetail_CellEnter`: Hiển thị tooltip khi focus vào cell
- `RefreshDGVInput()`: Ẩn/hiện cột VND, cập nhật header theo loại tiền
- `ValidData()`: Validate dữ liệu (TK nợ, KH, TK có, PS có > 0)
- `PHDataBinding()`: Bind dữ liệu PH
- `SetPHDefaultValues()`: Set TK nợ mặc định từ DMCT

**Business Logic:**
- **TK Nợ:** TK ngân hàng (112) - mặc định từ DMCT
- **TK Có:** Các TK công nợ, doanh thu...
- **Loại chứng từ:** Báo nợ ngân hàng (Ủy nhiệm chi)
- **Tỷ giá:** Tự động lấy theo ngày CT, có thể sửa
- **Tính tiền:** PS có VND = PS có NT × Tỷ giá
- **Dư công nợ:** Auto hiển thị khi chọn TK có công nợ + KH
- **Validate:** TK nợ, Mã KH, TK có, PS có > 0

### frmCaVchCA3Find (Find Form)

**Chức năng:** Form tìm kiếm voucher UNC

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| (Theo cấu hình Controller) | Lấy danh sách voucher UNC |
| (Theo cấu hình Controller) | Insert/Update voucher UNC |
| (Theo cấu hình Controller) | Delete voucher UNC |

## 4. Mapping PHP

| Layer | File | Mô tả |
|-------|------|-------|
| **Model** | `app/Models/CA/CAVchCA3.php` | Model voucher UNC |
| **Controller** | `app/Http/Controllers/CA/CAVchCA3Controller.php` | Controller xử lý UNC |
| **View** | `resources/views/ca/vouchers/ca3_*.blade.php` | Giao diện voucher UNC |
| **Route** | `routes/web.php` | Route cho UNC |

**Bảng dữ liệu:**
- PH: `CA3PH` (Báo nợ NH header)
- CT: `CA3CT` (Báo nợ NH chi tiết)

---

**Lưu ý:** 
- Mã chứng từ: CA3
- Loại chứng từ: Báo nợ ngân hàng (Ủy nhiệm chi)
- Chỉ xử lý giao dịch ngân hàng (không có tiền mặt)
- Thường dùng cho việc thu tiền qua ngân hàng (báo nợ TK NH)
