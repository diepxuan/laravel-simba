# Phân tích DLL: CAVchCA5.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | CAVchCA5.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Forms** | frmCaVchCA5, frmCaVchCA5Find, frmCaVchCA5FindCA2, frmCaVchCA5Print |
| **Kế thừa** | frmVoucher |
| **Chức năng** | Voucher khế ước vay (giải ngân, trả gốc, trả lãi) |
| **Mã CT** | CA5 (CA51, CA52, CA53) |

## 2. Forms chi tiết

### frmCaVchCA5 (Voucher Form)

**Controls - Header (gbPH):**

| Control | Type | DataField | Mô tả |
|---------|------|-----------|-------|
| txtMa_Kh | AsTextBox | Ma_Kh | Mã khách hàng (Ngân hàng) |
| lblTen_Kh | Label | Ten_Kh | Tên ngân hàng |
| txtDia_chi | TextBox | Dia_chi | Địa chỉ |
| txtNguoi_Gd | TextBox | Nguoi_Gd | Người giao dịch |
| txtDien_giai | TextBox | Dien_Giai | Diễn giải |
| txtTk_Co | AsTextBox | tk_co | TK có (NH) |
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
| chkTg_gs_dd | CheckBox | tg_gs_dd | Tỷ giá ghi sổ đích danh |
| cmdGetTaInFromDetail | Button | - | Lấy thuế từ chi tiết |

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
| dgvcSo_pc | DataGridViewTextBoxColumn | so_pc | Số PC |
| dgvcNgay_pc | DataGridViewTextBoxColumn | ngay_pc | Ngày PC |
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
| txtTy_gia_ValueChanged | Tính lại PS nợ VND = PS nợ NT × Tỷ giá |
| txtDien_giai_Validated | Copy diễn giải xuống dòng chi tiết |
| txtTk_Co_Validated | Validate TK có |
| adgvDetail_CellValueChanged | Xử lý thay đổi giá trị cell |
| adgvDetail_CellEnter | Hiển thị tooltip khi focus vào cell |
| adgvDetail_KeyDown | Xử lý phím tắt (F4 tìm kiếm) |
| RefreshDGVInput | Ẩn/hiện cột VND, cập nhật header |
| cmdGetTaInFromDetail_Click | Lấy thuế từ chi tiết lên tab thuế |
| ValidData | Validate dữ liệu (TK có, KH, TK nợ, PS nợ > 0) |
| PHDataBinding | Bind dữ liệu PH |
| SetPHDefaultValues | Set TK có mặc định từ DMCT |

**Business Logic:**

- **TK Có:** TK ngân hàng (112) - mặc định từ DMCT
- **TK Nợ:** 
  - Vay ngắn hạn (311) - Giải ngân
  - Vay dài hạn (315) - Giải ngân
  - Chi phí lãi vay (635) - Trả lãi
- **Loại chứng từ:** 
  - CA51: Giải ngân vay
  - CA52: Trả gốc vay
  - CA53: Trả lãi vay
- **Tỷ giá:** Tự động lấy theo ngày CT, có thể sửa
- **Tính tiền:** PS nợ VND = PS nợ NT × Tỷ giá
- **Liên kết PC:** Có thể liên kết với phiếu chi (số PC, ngày PC)
- **Validate:** TK có, Mã KH, TK nợ, PS nợ > 0

### frmCaVchCA5Find (Find Form)

**Chức năng:** Form tìm kiếm voucher KU

### frmCaVchCA5FindCA2 (Find Form)

**Chức năng:** Form tìm kiếm và liên kết với phiếu chi (CA2)

### frmCaVchCA5Print (Print Form)

**Chức năng:** Form in chứng từ khế ước

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| SP_CA5_GET | Lấy chứng từ KU |
| SP_CA5_INSERT | Thêm mới KU |
| SP_CA5_UPDATE | Cập nhật KU |
| SP_CA5_DELETE | Xóa KU |
| SP_CA5_FIND | Tìm kiếm KU |
| SP_CACALKU | Tính lãi khế ước |

## 4. Mapping PHP

### 4.1 Model

```php
class CA5 extends Model
{
    protected $table = 'CA5PH';
    protected $primaryKey = 'stt_rec';
    
    protected $fillable = [
        'ma_ct', 'ngay_ct', 'so_ct', 'ngay_lct',
        'ma_kh', 'dia_chi', 'nguoi_gd', 'dien_giai',
        'tk_co', 'ma_nt', 'ty_gia', 't_tien_nt', 't_tien',
        't_thue_nt', 't_thue', 't_tt_nt', 't_tt'
    ];
    
    public function details()
    {
        return $this->hasMany(CA5CT::class, 'stt_rec', 'stt_rec');
    }
    
    public function khachHang()
    {
        return $this->belongsTo(DMKH::class, 'ma_kh', 'ma_kh');
    }
}

class CA5CT extends Model
{
    protected $table = 'CA5CT';
    protected $primaryKey = 'stt_rec0';
    
    protected $fillable = [
        'stt_rec', 'tk', 'ps_no_nt', 'ps_no', 'ma_kh',
        'dien_giai', 'so_pc', 'ngay_pc', 'ma_bp', 'ma_phi', 
        'ma_hd', 'ma_ku', 'ma_spct'
    ];
}
```

### 4.2 Controller

```php
class CA5Controller extends Controller
{
    public function store(Request $request)
    {
        $validated = $request->validate([
            'ngay_ct' => 'required|date',
            'so_ct' => 'required',
            'ma_kh' => 'required|exists:DMKH,ma_kh',
            'tk_co' => 'required|exists:DMTK,tk',
            'ma_nt' => 'required',
            'ty_gia' => 'numeric',
            'details' => 'required|array',
            'details.*.tk' => 'required|exists:DMTK,tk',
            'details.*.ps_no_nt' => 'required|numeric|min:0',
        ]);
        
        // Generate stt_rec
        $sttRec = $this->generateSttRec($request->ma_ct); // CA51/CA52/CA53
        
        // Save header
        $ca5 = CA5::create([
            'stt_rec' => $sttRec,
            'ma_ct' => $request->ma_ct,
            ...$validated
        ]);
        
        // Save details
        foreach ($request->details as $detail) {
            $ca5->details()->create($detail);
        }
        
        return response()->json(['success' => true, 'stt_rec' => $sttRec]);
    }
}
```

## 5. Tables

| Table | Mô tả |
|-------|-------|
| CA5PH | Khế ước header |
| CA5CT | Khế ước chi tiết |
| CA5TAIN | Thuế đầu vào |

---

**Lưu ý:** 
- Mã chứng từ: CA5 (CA51, CA52, CA53)
- Loại chứng từ: 
  - CA51: Giải ngân vay
  - CA52: Trả gốc vay  
  - CA53: Trả lãi vay
- Có liên kết với danh mục khế ước (DMKU)
- Có liên kết với phiếu chi (CA2)
- Có xử lý thuế đầu vào (VAT)
