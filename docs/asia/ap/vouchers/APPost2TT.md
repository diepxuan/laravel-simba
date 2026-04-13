# Phân tích DLL: APPost2TT.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | APPost2TT.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmAPPost2TT, frmAPPost2TTFind, frmAPPost2TTResult |
| **Kế thừa** | frmAsiaRoot |
| **Chức năng** | Phân bổ thanh toán công nợ phải trả |

## 2. Forms

### 2.1 frmAPPost2TT (Main Form)

**Mô tả:** Form phân bổ tiền thanh toán cho hóa đơn

**Controls:**

| Control | Type | Mô tả |
|---------|------|-------|
| txtMa_Kh | TextBox | Mã khách hàng/NCC |
| lblTen_Kh | Label | Tên khách hàng |
| txtLoai_Ct | TextBox | Loại chứng từ |
| txtDien_Giai | TextBox | Diễn giải |
| txtNgay_Ct | MaskedTextBox | Ngày chứng từ |
| txtSo_Ct | TextBox | Số chứng từ |
| txtMa_NT | ComboBox | Mã ngoại tệ |
| txtTy_Gia | TextNumeric | Tỷ giá |
| txtT_Tien | TextNumeric | Tổng tiền VND |
| txtT_Tien_Nt | TextNumeric | Tổng tiền NT |
| txtTien_Con_Lai | TextNumeric | Tiền phân bổ còn lại VND |
| txtTien_Con_Lai_Nt | TextNumeric | Tiền phân bổ còn lại NT |
| adgvDetail | DataGridView | Grid hóa đơn được phân bổ |

**Cột DataGridView:**

| Cột | Ý nghĩa |
|-----|---------|
| stt_rec | Số thứ tự record |
| stt_rec_hd | Số thứ tự hóa đơn |
| so_ct | Số hóa đơn |
| ngay_ct | Ngày hóa đơn |
| tk_pt | Tài khoản phải trả |
| ma_kh | Mã khách hàng |
| ma_nt | Mã ngoại tệ |
| ty_gia | Tỷ giá |
| t_tt | Tổng tiền VND |
| t_tt_nt | Tiền hóa đơn NT |
| tien_tt_nt | Đã thanh toán NT |
| du_hd_nt | Còn phải thanh toán |
| thanhtoan | Thanh toán |
| tien_tt_qd | Thanh toán quy đổi |
| dien_giai | Diễn giải |
| nguoi_gd | Người giao dịch |

**Business Logic:**

```csharp
// Phân bổ thanh toán cho hóa đơn
private void PhanBoThanhToan(DataRowView oDv)
{
    // Tính tiền thanh toán quy đổi
    if (txtTy_gia.Value != 0)
    {
        oDv["tien_tt_qd"] = Math.Round(
            Helper.Repl_Null(oDv["thanhtoan_nt"], true) * txtTy_gia.Value,
            Environment.GetSIConfiguration().Round,
            MidpointRounding.AwayFromZero
        );
    }
    
    // Cập nhật tiền còn lại
    UpdateTienConLai();
}

// Cập nhật tiền phân bổ còn lại
private void UpdateTienConLai()
{
    decimal totalPhanBo = 0;
    decimal totalPhanBoNt = 0;
    
    foreach (DataRow row in DetailTable.Rows)
    {
        totalPhanBo += Convert.ToDecimal(row["tien_tt_qd"]);
        totalPhanBoNt += Convert.ToDecimal(row["thanhtoan_nt"]);
    }
    
    txtTien_Con_Lai.Value = txtT_Tien.Value - totalPhanBo;
    txtTien_Con_Lai_Nt.Value = txtT_Tien_Nt.Value - totalPhanBoNt;
}

// Validate dữ liệu
protected override bool ValidData()
{
    if (!base.ValidData()) return false;
    
    // Kiểm tra tổng phân bổ không vượt quá tổng tiền
    if (txtTien_Con_Lai.Value < 0)
    {
        MessageBox.Show("Tổng tiền phân bổ vượt quá số tiền chứng từ!");
        return false;
    }
    
    return true;
}
```

### 2.2 frmAPPost2TTFind (Find Form)

**Mô tả:** Form tìm kiếm chứng từ phân bổ

**Controls:**

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_Kh | AsTextBox | MA_KH | Mã KH/NCC |
| txtNgay_Ct1 | DateTimePicker | - | Từ ngày |
| txtNgay_Ct2 | DateTimePicker | - | Đến ngày |
| txtSo_Ct | TextBox | - | Số chứng từ |

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asAPGetMaCT | Lấy danh sách chứng từ |
| asAPGetPost2TT_APTT | Lấy dữ liệu thanh toán |
| asAPGetPost2TT | Lấy chi tiết thanh toán |
| asAPInsPost2TT_APTT | Thêm phân bổ thanh toán |
| asAPDelPost2TT_APTT | Xóa phân bổ thanh toán |

## 4. Mapping PHP

### 4.1 Model

```php
class APPost2TT extends Model
{
    protected $table = 'APPost2TT';
    protected $primaryKey = 'stt_rec';
    
    protected $fillable = [
        'ma_ct', 'ngay_ct', 'so_ct', 'ngay_lct',
        'ma_kh', 'dien_giai', 'ma_nt', 'ty_gia',
        't_tien', 't_tien_nt'
    ];
    
    public function details()
    {
        return $this->hasMany(APPost2TTCT::class, 'stt_rec', 'stt_rec');
    }
    
    public function khachHang()
    {
        return $this->belongsTo(DMKH::class, 'ma_kh', 'ma_kh');
    }
}

class APPost2TTCT extends Model
{
    protected $table = 'APPost2TTCT';
    protected $primaryKey = 'stt_rec0';
    
    protected $fillable = [
        'stt_rec', 'stt_rec_hd', 'so_ct', 'ngay_ct',
        'tk_pt', 'ma_kh', 'ma_nt', 'ty_gia',
        't_tt', 't_tt_nt', 'tien_tt_nt', 'du_hd_nt',
        'thanhtoan', 'tien_tt_qd', 'dien_giai'
    ];
}
```

### 4.2 Controller

```php
class APPost2TTController extends Controller
{
    public function store(Request $request)
    {
        $validated = $request->validate([
            'ngay_ct' => 'required|date',
            'so_ct' => 'required',
            'ma_kh' => 'required|exists:DMKH,ma_kh',
            'ma_nt' => 'required',
            'ty_gia' => 'numeric',
            't_tien' => 'numeric',
            'details' => 'required|array',
            'details.*.stt_rec_hd' => 'required',
            'details.*.thanhtoan' => 'required|numeric|min:0',
        ]);
        
        // Generate stt_rec
        $sttRec = $this->generateSttRec('APPost2TT');
        
        // Save header
        $header = APPost2TT::create([
            'stt_rec' => $sttRec,
            ...$validated
        ]);
        
        // Save details
        foreach ($validated['details'] as $index => $detail) {
            APPost2TTCT::create([
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

### 5.1 Payment Allocation Pattern

- Tìm chứng từ thanh toán (phiếu chi, ủy nhiệm chi)
- Load danh sách hóa đơn chưa thanh toán hết của NCC
- Nhập số tiền thanh toán cho từng hóa đơn
- Tính tiền thanh toán quy đổi = Tiền NT × Tỷ giá
- Validate: Tổng tiền TT không vượt quá số tiền chứng từ

### 5.2 Công thức tính toán

```
Tiền thanh toán quy đổi = Tiền thanh toán NT × Tỷ giá
Tiền còn lại = Tổng tiền - Tổng phân bổ
Dư hóa đơn = Tổng hóa đơn - Đã thanh toán
```

## 6. Tables liên quan

| Table | Mô tả |
|-------|-------|
| APPost2TT | Header phân bổ thanh toán |
| APPost2TTCT | Chi tiết phân bổ thanh toán |
| DMKH | Danh mục khách hàng/NCC |
| DMTK | Danh mục tài khoản |
| DMNT | Danh mục ngoại tệ |
