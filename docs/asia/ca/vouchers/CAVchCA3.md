# Phân tích DLL: CAVchCA3.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CAVchCA3.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCaVchCA3, frmCaVchCA3Find |
| **Kế thừa** | frmVoucher |
| **Chức năng** | Voucher báo nợ ngân hàng (UNC) |
| **Mã CT** | CA3 |

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

| Event | Mô tả |
|-------|-------|
| cboMa_NT_SelectedValueChanged | Cập nhật tỷ giá, ẩn/hiện cột VND |
| txtMa_Kh_AfterCodeValidating | Load thông tin KH (địa chỉ, người GD) |
| txtTy_gia_ValueChanged | Tính lại PS có VND = PS có NT × Tỷ giá |
| txtDien_giai_Validated | Copy diễn giải xuống dòng chi tiết |
| adgvDetail_CellValueChanged | Xử lý thay đổi giá trị cell |
| adgvDetail_CellEnter | Hiển thị tooltip khi focus vào cell |
| RefreshDGVInput | Ẩn/hiện cột VND, cập nhật header theo loại tiền |
| ValidData | Validate dữ liệu (TK nợ, KH, TK có, PS có > 0) |
| PHDataBinding | Bind dữ liệu PH |
| SetPHDefaultValues | Set TK nợ mặc định từ DMCT |

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
| SP_CA3_GET | Lấy chứng từ CA3 |
| SP_CA3_INSERT | Thêm mới CA3 |
| SP_CA3_UPDATE | Cập nhật CA3 |
| SP_CA3_DELETE | Xóa CA3 |
| SP_CA3_FIND | Tìm kiếm CA3 |

## 4. Mapping PHP

### 4.1 Model

```php
class CA3 extends Model
{
    protected $table = 'CA3PH';
    protected $primaryKey = 'stt_rec';
    
    protected $fillable = [
        'ma_ct', 'ngay_ct', 'so_ct', 'ngay_lct',
        'ma_kh', 'dia_chi', 'nguoi_gd', 'dien_giai',
        'tk_no', 'ma_nt', 'ty_gia', 't_tien_nt', 't_tien'
    ];
    
    public function details()
    {
        return $this->hasMany(CA3CT::class, 'stt_rec', 'stt_rec');
    }
    
    public function khachHang()
    {
        return $this->belongsTo(DMKH::class, 'ma_kh', 'ma_kh');
    }
}

class CA3CT extends Model
{
    protected $table = 'CA3CT';
    protected $primaryKey = 'stt_rec0';
    
    protected $fillable = [
        'stt_rec', 'tk', 'ps_co_nt', 'ps_co', 'ma_kh',
        'dien_giai', 'ma_bp', 'ma_phi', 'ma_hd', 
        'ma_ku', 'ma_spct'
    ];
}
```

### 4.2 Controller

```php
class CA3Controller extends Controller
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
        $sttRec = $this->generateSttRec('CA3');
        
        // Save header
        $ca3 = CA3::create([
            'stt_rec' => $sttRec,
            'ma_ct' => 'CA3',
            ...$validated
        ]);
        
        // Save details
        foreach ($request->details as $detail) {
            $ca3->details()->create($detail);
        }
        
        return response()->json(['success' => true, 'stt_rec' => $sttRec]);
    }
}
```

## 5. Tables

| Table | Mô tả |
|-------|-------|
| CA3PH | Báo nợ NH header |
| CA3CT | Báo nợ NH chi tiết |

---

**Lưu ý:** 
- Mã chứng từ: CA3
- Loại chứng từ: Báo nợ ngân hàng (Ủy nhiệm chi)
- Chỉ xử lý giao dịch ngân hàng (không có tiền mặt)
- Thường dùng cho việc thu tiền qua ngân hàng (báo nợ TK NH)
