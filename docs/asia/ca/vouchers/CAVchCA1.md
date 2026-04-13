# Phân tích DLL: CAVchCA1.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CAVchCA1.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmCaVchCA1, frmCAVchCA1Find |
| **Kế thừa** | frmVoucher, frmVoucherFind |
| **Chức năng** | Chứng từ thu tiền mặt/chuyển khoản (CA1) |

## 2. Forms

### 2.1 frmCaVchCA1 (Voucher Form)

**Mô tả:** Form nhập chứng từ thu tiền mặt/chuyển khoản

**Controls - Phần Header (gbPH):**

| Control | Type | DataBinding | Mô tả |
|---------|------|-------------|-------|
| txtMa_Kh | AsTextBox | Ma_Kh | Mã khách hàng |
| lblTen_Kh | Label | Ten_Kh | Tên KH |
| txtDia_chi | TextBox | Dia_chi | Địa chỉ |
| txtNguoi_Gd | TextBox | Nguoi_Gd | Người giao dịch |
| txtDien_giai | TextBox | Dien_Giai | Diễn giải |
| txtTk_No | AsTextBox | tk_no | Tài khoản nợ |
| lblTen_Tk_No | Label | ten_tk_no | Tên TK nợ |
| txtNgay_lct | AsMaskedTextBox | ngay_lct (Value) | Ngày lập CT |
| txtNgay_Ct | AsMaskedTextBox | ngay_ct (Value) | Ngày CT |
| txtSo_Ct | TextBox | so_ct | Số CT |
| cboMa_NT | AsComboBoxNT | ma_nt (MA_NT) | Mã ngoại tệ |
| txtTy_gia | AsTextNumeric | ty_gia (Value) | Tỷ giá |
| txtT_tien_Nt | AsTextNumeric | t_tien_nt (Value) | Tổng tiền NT |
| txtT_Tien | AsTextNumeric | t_tien (Value) | Tổng tiền |
| chkTg_gs_dd | CheckBox | - | Tỷ giá ghi sổ đích danh |

**Controls - Grid Detail (adgvDetail):**

| Column | Type | DataPropertyName | Mô tả |
|--------|------|------------------|-------|
| dgvcTk | DataGridViewAsTextBoxColumn | tk | TK có |
| dgvcTen_tk | DataGridViewTextBoxColumn | ten_tk | Tên TK |
| dgvcPs_co_nt | DataGridViewAsTextNumericColumn | ps_co_nt | PS có NT |
| dgvcPs_co | DataGridViewAsTextNumericColumn | ps_co | PS có |
| dgvcTy_gia_gs | DataGridViewAsTextNumericColumn | ty_gia_gs | Tỷ giá GS |
| dgvcMa_kh | DataGridViewAsTextBoxColumn | ma_kh | Mã KH |
| dgvcTen_kh | DataGridViewTextBoxColumn | ten_kh | Tên KH |
| dgvcDu13 | DataGridViewTextBoxColumn | du13 | Dư |
| dgvcDien_giai | DataGridViewTextBoxColumn | dien_giai | Diễn giải |
| dgvcMa_bp | DataGridViewAsTextBoxColumn | ma_bp | Bộ phận |
| dgvcMa_phi | DataGridViewAsTextBoxColumn | ma_phi | Phí |
| dgvcMa_hd | DataGridViewAsTextBoxColumn | ma_hd | Hợp đồng |
| dgvcMa_ku | DataGridViewAsTextBoxColumn | ma_ku | Khế ước |
| dgvcMa_spct | DataGridViewAsTextBoxColumn | ma_spct | SPCT |

**Events:**

| Event | Mô tả |
|-------|-------|
| cboMa_NT_SelectedValueChanged | Thay đổi mã NT, cập nhật tỷ giá |
| txtMa_Kh_AfterCodeValidating | Sau validate KH, load địa chỉ, người GD |
| txtTy_gia_ValueChanged | Thay đổi tỷ giá, tính lại PS có |
| txtDien_giai_Validated | Copy diễn giải xuống dòng đầu |
| adgvDetail_CellValueChanged | Cell value changed - tính toán |
| adgvDetail_CellEnter | Hiển thị tooltip |

**Business Logic:**

```csharp
// Sau validate mã KH
private void txtMa_Kh_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
{
    if (e.ValidatedRow == null) return;
    
    txtDia_chi.Text = e.ValidatedRow["dia_chi"].ToString();
    txtNguoi_Gd.Text = e.ValidatedRow["nguoi_gd"].ToString();
    
    // Auto fill dòng đầu nếu chưa có dữ liệu
    if (adgvDetail.RowCount == 1)
    {
        // Lấy TK từ MA_HTTT
        DataRow pDrw, pDrw2;
        if (Commons.ValidMa(ref pDrw, "MA_HTTT", e.ValidatedRow["ma_httt"].ToString(), 
            "moduleid='SO'", "tk", true) && pDrw != null)
        {
            if (Commons.ValidMa(ref pDrw2, "TK", pDrw["tk"].ToString(), 
                "chi_tiet=1", "ten_tk,tk_cn", true))
            {
                adgvDetail[dgvcTk.Name, 0].Value = pDrw["Tk"];
                adgvDetail[dgvcTen_tk.Name, 0].Value = pDrw2["ten_tk"];
                CT1Voucher[0]["tk_cn"] = pDrw2["tk_cn"];
            }
        }
        
        adgvDetail[dgvcMa_kh.Name, 0].Value = txtMa_Kh.Text;
        adgvDetail[dgvcTen_kh.Name, 0].Value = lblTen_Kh.Text;
    }
}

// Tính PS có từ PS có NT
private void V_Ps_Co_Nt(DataRowView oDv)
{
    if (txtTy_gia.Value != 0)
    {
        oDv["ps_co"] = Math.Round(
            Helper.Repl_Null(oDv["ps_co_nt"], true) * txtTy_gia.Value,
            Environment.GetSIConfiguration().Round,
            MidpointRounding.AwayFromZero
        );
    }
    UpdateList();
}

// Tính dư KH
private void V_Ma_KhI(DataRowView oDv)
{
    if (!string.IsNullOrEmpty(oDv["ma_kh"].ToString()) && 
        !string.IsNullOrEmpty(oDv["tk"].ToString()) &&
        oDv["Tk_Cn"] != DBNull.Value && 
        Convert.ToBoolean(oDv["Tk_Cn"]))
    {
        oDv["Du13"] = Commons.GetDuArkh(
            oDv["ma_kh"].ToString(),
            oDv["tk"].ToString(),
            Convert.ToDateTime(txtNgay_Ct.Value)
        );
    }
    else
    {
        oDv["Du13"] = 0;
    }
}

// Validate dữ liệu
protected override bool ValidData()
{
    if (!base.ValidData()) return false;
    if (string.IsNullOrEmpty(txtTk_No.Text) || string.IsNullOrEmpty(txtMa_Kh.Text))
        return false;
    
    foreach (var item in CT1Voucher)
    {
        // Validate TK có
        if (string.IsNullOrEmpty(item["Tk"].ToString()))
            return false;
        
        // Validate PS có NT
        if (Convert.ToDecimal(item["Ps_Co_Nt"]) == 0)
            return false;
        
        // Validate KH nếu TK công nợ
        if (item["Tk_Cn"].ToString() == "1" && string.IsNullOrEmpty(item["Ma_Kh"].ToString()))
            return false;
    }
    
    return true;
}
```

### 2.2 frmCAVchCA1Find (Find Form)

**Mô tả:** Form tìm kiếm chứng từ CA1

**Controls:**

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_Kh | AsTextBox | MA_KH | Mã KH |
| txtTk_No | AsTextBox | TK | TK nợ |
| txtNguoi_Gd | TextBox | - | Người GD |
| txtTk | AsTextBox | TK | TK có |
| txtMa_Bp | AsTextBox | MA_BP | Bộ phận |
| txtMa_Phi | AsTextBox | MA_PHI | Phí |
| txtMa_Hd | AsTextBox | MA_HD | Hợp đồng |
| txtMa_Ku | AsTextBox | MA_KU | Khế ước (ẩn) |
| txtMa_Spct | AsTextBox | MA_SPCT | SPCT |
| txtDien_giai | TextBox | - | Diễn giải |

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CA1_GET | Lấy chứng từ |
| SP_CA1_INSERT | Thêm mới |
| SP_CA1_UPDATE | Cập nhật |
| SP_CA1_DELETE | Xóa |
| SP_CA1_FIND | Tìm kiếm |

## 4. Mapping PHP

### 4.1 Model

```php
class CA1 extends Model
{
    protected $table = 'CA1';
    protected $primaryKey = 'stt_rec';
    
    protected $fillable = [
        'ma_ct', 'ngay_ct', 'so_ct', 'ngay_lct',
        'ma_kh', 'dia_chi', 'nguoi_gd', 'dien_giai',
        'tk_no', 'ma_nt', 'ty_gia', 't_tien_nt', 't_tien'
    ];
    
    public function details()
    {
        return $this->hasMany(CA1CT::class, 'stt_rec', 'stt_rec');
    }
    
    public function khachHang()
    {
        return $this->belongsTo(DMKH::class, 'ma_kh', 'ma_kh');
    }
}

class CA1CT extends Model
{
    protected $table = 'CA1CT';
    protected $primaryKey = 'stt_rec0';
    
    protected $fillable = [
        'stt_rec', 'tk', 'ps_co_nt', 'ps_co', 'ty_gia_gs',
        'ma_kh', 'dien_giai', 'ma_bp', 'ma_phi', 'ma_hd', 
        'ma_ku', 'ma_spct'
    ];
}
```

### 4.2 Controller

```php
class CA1Controller extends Controller
{
    public function store(Request $request)
    {
        $validated = $request->validate([
            'ngay_ct' => 'required|date',
            'so_ct' => 'required',
            'ma_kh' => 'required|exists:DMKH,ma_kh',
            'tk_no' => 'required|exists:DMTK,tk',
            'ma_nt' => 'required',
            'ty_gia' => 'numeric',
            'details' => 'required|array',
            'details.*.tk' => 'required|exists:DMTK,tk',
            'details.*.ps_co_nt' => 'required|numeric|min:0',
        ]);
        
        // Generate stt_rec
        $sttRec = $this->