# CAVchCA1.dll - Voucher thu tiền mặt/chuyển khoản

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CAVchCA1.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCaVchCA1, frmCAVchCA1Find |
| **Kế thừa** | frmVoucher |
| **Chức năng** | Voucher thu tiền mặt/chuyển khoản (PT) |

## 2. Forms chi tiết

### frmCaVchCA1 (Voucher Form)

**Controls - Header (gbPH):**
| Control | Type | DataField | Mô tả |
|---------|------|-----------|-------|
| txtMa_Kh | AsTextBox | Ma_Kh | Mã khách hàng |
| lblTen_Kh | Label | Ten_Kh | Tên khách hàng |
| txtDia_chi | TextBox | Dia_chi | Địa chỉ |
| txtNguoi_Gd | TextBox | Nguoi_Gd | Người giao dịch |
| txtDien_giai | TextBox | Dien_Giai | Diễn giải |
| txtTk_No | AsTextBox | tk_no | TK nợ (TM/NH) |
| lblTen_Tk_No | Label | ten_tk_no | Tên TK nợ |
| txtNgay_Ct | AsMaskedTextBox | ngay_ct | Ngày chứng từ |
| txtSo_Ct | TextBox | so_ct | Số chứng từ |
| txtNgay_lct | AsMaskedTextBox | ngay_lct | Ngày lập CT |
| cboMa_NT | AsComboBoxNT | ma_nt | Mã ngoại tệ |
| txtTy_gia | AsTextNumeric | ty_gia | Tỷ giá |
| txtT_tien_Nt | AsTextNumeric | t_tien_nt | Tổng tiền NT |
| txtT_Tien | AsTextNumeric | t_tien | Tổng tiền |
| chkTg_gs_dd | CheckBox | tg_gs_dd | Tỷ giá ghi sổ đích danh |

**Controls - Detail Grid (adgvDetail):**
| Column | Type | DataField | Mô tả |
|--------|------|-----------|-------|
| dgvcTk | DataGridViewAsTextBoxColumn | tk | TK có |
| dgvcTen_tk | DataGridViewTextBoxColumn | ten_tk | Tên TK |
| dgvcPs_co_nt | DataGridViewAsTextNumericColumn | ps_co_nt | PS có NT |
| dgvcPs_co | DataGridViewAsTextNumericColumn | ps_co | PS có VND |
| dgvcTy_gia_gs | DataGridViewAsTextNumericColumn | ty_gia_gs | Tỷ giá gs |
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
- `txtMa_Kh_AfterCodeValidating`: Load thông tin KH (địa chỉ, người GD), auto fill TK có từ HTTT
- `txtTy_gia_ValueChanged`: Tính lại PS có VND = PS có NT × Tỷ giá
- `txtDien_giai_Validated`: Copy diễn giải xuống dòng chi tiết đầu tiên
- `adgvDetail_CellValueChanged`: Xử lý thay đổi giá trị cell (PS có NT, PS có, TK, KH)
- `adgvDetail_CellEnter`: Hiển thị tooltip khi focus vào cell
- `RefreshDGVInput()`: Ẩn/hiện cột VND, cập nhật header theo loại tiền
- `V_Ps_Co_Nt()`: Tính PS có VND khi nhập PS có NT
- `V_Ma_KhI()`: Lấy dư công nợ khi nhập KH + TK có công nợ
- `ValidData()`: Validate dữ liệu (TK nợ, KH, TK có, PS có > 0)
- `PHDataBinding()`: Bind dữ liệu PH
- `SetPHDefaultValues()`: Set TK nợ mặc định từ DMCT
- `SetReportDataSource()`: Chuẩn bị dữ liệu in báo cáo

**Business Logic:**
- **TK Nợ:** TK tiền mặt (111) hoặc TK ngân hàng (112) - mặc định từ DMCT
- **TK Có:** Các TK doanh thu, công nợ, khác...
- **Đối tượng:** Khách hàng (có thể nhập trên header hoặc từng dòng)
- **Tỷ giá:** Tự động lấy theo ngày CT, có thể sửa
- **Tính tiền:** PS có VND = PS có NT × Tỷ giá (làm tròn theo cấu hình)
- **Dư công nợ:** Auto hiển thị khi chọn TK có công nợ + KH
- **Validate:** TK nợ, Mã KH, TK có, PS có > 0, cảnh báo điều chỉnh tỷ giá

### frmCAVchCA1Find (Find Form)

**Chức năng:** Form tìm kiếm voucher PT

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| (Theo cấu hình Controller) | Lấy danh sách voucher PT |
| (Theo cấu hình Controller) | Insert/Update voucher PT |
| (Theo cấu hình Controller) | Delete voucher PT |

## 4. Mapping PHP

| Layer | File | Mô tả |
|-------|------|-------|
| **Model** | `app/Models/CA/CAVchCA1.php` | Model voucher PT |
| **Controller** | `app/Http/Controllers/CA/CAVchCA1Controller.php` | Controller xử lý PT |
| **View** | `resources/views/ca/vouchers/ca1_*.blade.php` | Giao diện voucher PT |
| **Route** | `routes/web.php` | Route cho PT |

**Bảng dữ liệu:**
- PH: `CA1PH` (Phiếu thu header)
- CT: `CA1CT` (Phiếu thu chi tiết)

---

**Lưu ý:** 
- Mã chứng từ: CA1
- Loại chứng từ: Thu tiền
- Có thể thu tiền mặt hoặc thu qua ngân hàng
