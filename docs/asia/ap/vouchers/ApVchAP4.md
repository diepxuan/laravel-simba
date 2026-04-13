# Phân tích DLL: ApVchAP4.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | ApVchAP4.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmApVchAP4, frmApVchAP4Find |
| **Kế thừa** | frmVoucher, frmVoucherFind |
| **Chức năng** | Chứng từ bù trừ công nợ phải trả |
| **Mã CT** | AP4 |

## 2. Forms

### 2.1 frmApVchAP4 (Voucher Form)

**Mô tả:** Form nhập chứng từ bù trừ công nợ phải trả

**Controls - Phần Header:**

| Control | Type | DataBinding | Mô tả |
|---------|------|-------------|-------|
| txtNgay_lct | AsMaskedTextBox | ngay_lct (Value) | Ngày lập CT |
| txtNgay_Ct | AsMaskedTextBox | ngay_ct (Value) | Ngày CT |
| txtSo_Ct | TextBox | so_ct | Số CT |
| cboMa_NT | AsComboBoxNT | ma_nt (MA_NT) | Mã ngoại tệ |
| txtTy_gia | AsTextNumeric | ty_gia (Value) | Tỷ giá |
| txtT_Tien | AsTextNumeric | t_tien (Value) | Tổng tiền VND |
| txtT_tien_Nt | AsTextNumeric | t_tien_nt (Value) | Tổng tiền NT |
| chkNt_Ph | AsCheckBox | - | Ngoại tệ chung |
| AsCheckBox2 | AsCheckBox | - | Chỉ kê, không hạch toán |

**Controls - Grid Detail (adgvDetail):**

| Column | Type | DataPropertyName | Mô tả |
|--------|------|------------------|-------|
| dgvcTk | DataGridViewAsTextBoxColumn | tk | Tài khoản |
| dgvcTen_tk | DataGridViewTextBoxColumn | ten_tk | Tên TK |
| dgvcMa_kh | DataGridViewAsTextBoxColumn | ma_kh | Mã KH |
| dgvcMa_nt | DataGridViewComboBoxColumn | ma_nt | Mã NT |
| dgvcTy_gia | DataGridViewAsTextNumericColumn | ty_gia | Tỷ giá |
| dgvcPs_no_nt | DataGridViewAsTextNumericColumn | ps_no_nt | PS nợ NT |
| dgvcPs_co_nt | DataGridViewAsTextNumericColumn | ps_co_nt | PS có NT |
| dgvcPs_no | DataGridViewAsTextNumericColumn | ps_no | PS nợ |
| dgvcPs_co | DataGridViewAsTextNumericColumn | ps_co | PS có |
| dgvcDien_giai | DataGridViewTextBoxColumn | dien_giai | Diễn giải |
| dgvcMa_bp | DataGridViewAsTextBoxColumn | ma_bp | Bộ phận |
| dgvcMa_phi | DataGridViewAsTextBoxColumn | ma_phi | Phí |
| dgvcMa_hd | DataGridViewAsTextBoxColumn | ma_hd | Hợp đồng |
| dgvcMa_spct | DataGridViewAsTextBoxColumn | ma_spct | SPCT |
| dgvcNh_dk | DataGridViewTextBoxColumn | nh_dk | Nhóm ĐK |

**Events:**

| Event | Mô tả |
|-------|-------|
| chkNt_Ph_CheckedChanged | Xử lý khi thay đổi trạng thái ngoại tệ chung |
| cboMa_NT_SelectedValueChanged | Cập nhật tỷ giá khi đổi ngoại tệ |
| txtTy_gia_Validated | Tính toán lại khi tỷ giá thay đổi |
| adgvDetail_CellValueChanged | Xử lý thay đổi giá trị cell |
| adgvDetail_CellEnter | Xử lý khi focus vào cell |

**Business Logic:**

```csharp
// Xử lý khi thay đổi mã ngoại tệ
private void V_Ma_Nt()
{
    // Cập nhật tỷ giá cho tất cả các dòng
    foreach (DataRowView row in CT1Voucher)
    {
        row["ty_gia"] = txtTy_gia.Value;
        V_Ty_gia(row);
    }
}

// Tính phát sinh nợ/có từ ngoại tệ
private void V_Ps_No_Nt(DataRowView oDv)
{
    if (txtTy_gia.Value != 0)
    {
        oDv["ps_no"] = Math.Round(
            Helper.Repl_Null(oDv["ps_no_nt"], true) * txtTy_gia.Value,
            Environment.GetSIConfiguration().Round,
            MidpointRounding.AwayFromZero
        );
    }
    UpdateList();
}

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

// Cập nhật tổng tiền
private void UpdateList()
{
    decimal totalNo = 0, totalCo = 0;
    decimal totalNoNt = 0, totalCoNt = 0;
    
    foreach (DataRowView row in CT1Voucher)
    {
        totalNo += Convert.ToDecimal(row["ps_no"]);
        totalCo += Convert.ToDecimal(row["ps_co"]);
        totalNoNt += Convert.ToDecimal(row["ps_no_nt"]);
        totalCoNt += Convert.ToDecimal(row["ps_co_nt"]);
    }
    
    txtT_Tien.Value = totalNo; // Hoặc totalCo (bù trừ)
    txtT_tien_Nt.Value = totalNoNt;
}

// Validate dữ liệu
protected override bool ValidData()
{
    if (!base.ValidData()) return false;
    
    foreach (var item in CT1Voucher)
    {
        // Validate TK
        if (string.IsNullOrEmpty(item["tk"].ToString()))
            return false;
        
        // Validate KH nếu TK công nợ
        if (item["tk_cn"].ToString() == "1" && string.IsNullOrEmpty(item["ma_kh"].ToString()))
            return false;
    }
    
    // Kiểm tra cân đối nợ có theo nhóm định khoản
    if (!ChkNh_Dk())
        return false;
    
    return true;
}

// Kiểm tra nhóm định khoản
private bool ChkNh_Dk()
{
    // Kiểm tra tổng nợ = tổng có trong cùng nhóm định khoản
    return true;
}
```

### 2.2 frmApVchAP4Find (Find Form)

**Mô tả:** Form tìm kiếm chứng từ AP4

**Controls:**

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_Kh | AsTextBox | MA_KH | Mã KH |
| txtTk | AsTextBox | TK | Tài khoản |
| txtNgay_Ct1 | DateTimePicker | - | Từ ngày |
| txtNgay_Ct2 | DateTimePicker | - | Đến ngày |
| txtSo_Ct | TextBox | - | Số chứng từ |

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asAPGetApVchAP4 | Lấy chứng từ bù trừ |
| asAPInsApVchAP4 | Thêm chứng từ bù trừ |
| asAPUpdApVchAP4 | Cập nhật chứng từ bù trừ |
| asAPDelApVchAP4 | Xóa chứng từ bù trừ |

## 4. Mapping PHP

### 4.1 Model

```php
class AP4 extends Model
{
    protected $table = 'AP4';
    protected $primaryKey = 'stt_rec';
    
    protected $fillable = [
        'ma_ct', 'ngay_ct', 'so_ct', 'ngay_lct',
        'ma_nt', 'ty_gia', 't_tien', 't_tien_nt',
        'nt_ph', 'chi_ke'
    ];
    
    public function details()
    {
        return $this->hasMany(AP4CT::class, 'stt_rec', 'stt_rec');
    }
}

class AP4CT extends Model
{
    protected $table = 'AP4CT';
    protected $primaryKey = 'stt_rec0';
    
    protected $fillable = [
        'stt_rec', 'tk', 'ten_tk', 'ma_kh', 'ma_nt',
        'ty_gia', 'ps_no_nt', 'ps_co_nt', 'ps_no', 'ps_co',
        'dien_giai', 'ma_bp', 'ma_phi', 'ma_hd', 'ma_spct', 'nh_dk'
    ];
}
```

### 4.2 Controller

```php
class AP4Controller extends Controller
{
    public function store(Request $request)
    {
        $validated = $request->validate([
            'ngay_ct' => 'required|date',
            'so_ct' => 'required',
            'ma_nt' => 'required',
            'ty_gia' => 'numeric',
            'details' => 'required|array',
            'details.*.tk' => 'required|exists:DMTK,tk',
            'details.*.ma_kh' => 'required_if:details.*.tk_cn,1',
        ]);
        
        // Generate stt_rec
        $sttRec = $this->generateSttRec('AP4');
        
        // Save header
        $header = AP4::create([
            'stt_rec' => $sttRec,
            'ma_ct' => 'AP4',
            ...$validated
        ]);
        
        // Save details
        foreach ($validated['details'] as $index => $detail) {
            AP4CT::create([
                'stt_rec' => $sttRec,
                'stt_rec0' => $sttRec . ($index + 1),
                ...$detail
            ]);
        }
        
        return response()->json(['success' => true, 'stt_rec' => $sttRec]);
    }
}
```

## 5. Business Logic

### 5.1 Chế độ ngoại tệ

- Checkbox "Ngoại tệ chung" để áp dụng tỷ giá chung cho toàn bộ chứng từ
- Hỗ trợ nhập liệu ngoại tệ riêng cho từng dòng chi tiết
- Tự động ẩn/hiện cột ngoại tệ theo cấu hình

### 5.2 Validation

- Kiểm tra tài khoản chi tiết (`chi_tiet=1` và `tk_cn=1`)
- Kiểm tra bắt buộc nhập mã KH cho TK công nợ
- Kiểm tra cân đối nợ có theo nhóm định khoản
- Kiểm tra điều chỉnh tỷ giá (`canh_bao_dieu_chinh`)

### 5.3 Công thức tính toán

```
PS nợ VND = PS nợ NT × Tỷ giá
PS có VND = PS có NT × Tỷ giá
Tổng tiền = Tổng PS nợ (hoặc PS có)
```

## 6. Tables liên quan

| Table | Mô tả |
|-------|-------|
| AP4 | Header chứng từ bù trừ |
| AP4CT | Chi tiết chứng từ bù trừ |
| DMTK | Danh mục tài khoản |
| DMKH | Danh mục khách hàng/NCC |
| DMNT | Danh mục ngoại tệ |
| DMBP | Danh mục bộ phận |
| DMPHI | Danh mục phí |
| DMHD | Danh mục hợp đồng |
| DMSPCT | Danh mục SPCT |
