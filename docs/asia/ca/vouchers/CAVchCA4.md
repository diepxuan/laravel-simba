# Phân tích DLL: CAVchCA4.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CAVchCA4.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCaVchCA4, frmCaVchCA4Find, frmCaVchCA4Print |
| **Kế thừa** | frmVoucher, frmVoucherFind, frmVoucherPrint |
| **Chức năng** | Voucher báo có/Ủy nhiệm chi |
| **Mã CT** | CA4 |

## 2. Forms chi tiết

### frmCaVchCA4 (Voucher Form)

**Controls - Header (gbPH):**

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Kh | AsTextBox | Mã khách hàng |
| lblTen_Kh | Label | Tên khách hàng |
| txtDia_chi | TextBox | Địa chỉ |
| txtNguoi_Gd | TextBox | Người giao dịch |
| txtDien_giai | TextBox | Diễn giải |
| txtTk_Co | AsTextBox | TK có (NH) |
| lblTen_Tk_Co | Label | Tên TK có |
| txtNgay_lct | AsMaskedTextBox | Ngày lập CT |
| cboMa_NT | AsComboBoxNT | Mã ngoại tệ |
| txtTy_gia | AsTextNumeric | Tỷ giá |
| txtT_tien_Nt | AsTextNumeric | Tổng tiền NT |
| txtT_Tien | AsTextNumeric | Tổng tiền |
| txtT_thue_Nt | AsTextNumeric | Tổng thuế NT |
| txtT_Thue | AsTextNumeric | Tổng thuế |
| txtT_tt_Nt | AsTextNumeric | Tổng TT NT |
| txtT_Tt | AsTextNumeric | Tổng TT |
| tabTax | TabPage | Tab thuế |
| ctlTaIn | ctlTaIn | Control thuế đầu vào |
| chkTg_gs_dd | CheckBox | Tỷ giá ghi sổ đích danh |

**Controls - Detail Grid (adgvDetail):**

| Column | Type | Mô tả |
|--------|------|-------|
| dgvcTk | DataGridViewAsTextBoxColumn | TK nợ |
| dgvcTen_tk | DataGridViewTextBoxColumn | Tên TK |
| dgvcPs_no_nt | DataGridViewAsTextNumericColumn | PS nợ NT |
| dgvcPs_no | DataGridViewAsTextNumericColumn | PS nợ VNĐ |
| dgvcMa_kh | DataGridViewAsTextBoxColumn | Mã KH |
| dgvcTen_kh | DataGridViewTextBoxColumn | Tên KH |
| dgvcDu13 | DataGridViewTextBoxColumn | Dư |
| dgvcDien_giai | DataGridViewTextBoxColumn | Diễn giải |
| dgvcMa_bp | DataGridViewAsTextBoxColumn | Bộ phận |
| dgvcMa_phi | DataGridViewAsTextBoxColumn | Phí |
| dgvcMa_hd | DataGridViewAsTextBoxColumn | Hợp đồng |
| dgvcMa_ku | DataGridViewAsTextBoxColumn | Khế ước |
| dgvcMa_spct | DataGridViewAsTextBoxColumn | SPCT |

**Events:**

| Event | Mô tả |
|-------|-------|
| cboMa_NT_SelectedValueChanged | Cập nhật tỷ giá, ẩn/hiện cột VND |
| txtMa_Kh_AfterCodeValidating | Load thông tin KH |
| txtTy_gia_ValueChanged | Tính lại PS nợ VND |
| txtDien_giai_Validated | Copy diễn giải xuống dòng chi tiết |
| txtTk_Co_Validated | Validate TK có |
| adgvDetail_CellValueChanged | Xử lý thay đổi giá trị cell |
| ValidData | Validate dữ liệu |

**Business Logic:**

- **TK Có:** TK ngân hàng (112) - mặc định từ DMCT
- **TK Nợ:** Các TK công nợ, chi phí...
- **Loại chứng từ:** Báo có/Ủy nhiệm chi
- **Tỷ giá:** Tự động lấy theo ngày CT
- **Tính tiền:** PS nợ VND = PS nợ NT × Tỷ giá
- **Thuế:** Có tab thuế đầu vào (VAT)
- **Validate:** TK có, Mã KH, TK nợ, PS nợ > 0

### frmCaVchCA4Find (Find Form)

**Chức năng:** Form tìm kiếm chứng từ

### frmCaVchCA4Print (Print Form)

**Chức năng:** Form in ủy nhiệm chi với thông tin ngân hàng đầy đủ

**Thông tin in:**
- Đơn vị trả tiền / Đơn vị nhận tiền
- Số tài khoản / Tại ngân hàng / Tỉnh, thành phố

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CA4_GET | Lấy chứng từ CA4 |
| SP_CA4_INSERT | Thêm mới CA4 |
| SP_CA4_UPDATE | Cập nhật CA4 |
| SP_CA4_DELETE | Xóa CA4 |
| SP_CA4_FIND | Tìm kiếm CA4 |

## 4. Mapping PHP

### 4.1 Model

```php
class CA4 extends Model
{
    protected $table = 'CA4PH';
    protected $primaryKey = 'stt_rec';
    
    protected $fillable = [
        'ma_ct', 'ngay_ct', 'so_ct', 'ngay_lct',
        'ma_kh', 'dia_chi', 'nguoi_gd', 'dien_giai',
        'tk_co', 'ma_nt', 'ty_gia', 't_tien_nt', 't_tien',
        't_thue_nt', 't_thue', 't_tt_nt', 't_tt'
    ];
    
    public function details()
    {
        return $this->hasMany(CA4CT::class, 'stt_rec', 'stt_rec');
    }
}

class CA4CT extends Model
{
    protected $table = 'CA4CT';
    protected $primaryKey = 'stt_rec0';
    
    protected $fillable = [
        'stt_rec', 'tk', 'ps_no_nt', 'ps_no', 'ma_kh',
        'dien_giai', 'ma_bp', 'ma_phi', 'ma_hd', 
        'ma_ku', 'ma_spct'
    ];
}
```

## 5. Tables

| Table | Mô tả |
|-------|-------|
| CA4PH | Báo có/UNC header |
| CA4CT | Báo có/UNC chi tiết |
| CA4TAIN | Thuế đầu vào |

---

**Lưu ý:** 
- Mã chứng từ: CA4
- Loại chứng từ: Báo có/Ủy nhiệm chi
- Có xử lý thuế đầu vào (VAT)
- Có form in riêng với định dạng ủy nhiệm chi chuẩn
- Tích hợp với module CAVchCA2
