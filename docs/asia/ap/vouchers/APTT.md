# Phân tích DLL: APTT.dll

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | APTT.dll |
| **Namespace** | AsiaErp.UserInterface |
| **Form chính** | frmAPTT, frmAPTTEdit |
| **Kế thừa** | frmOBView, frmOBEdit |
| **Chức năng** | Danh mục điều khoản thanh toán mua hàng |

## 2. Forms

### 2.1 frmAPTT (View Form)

**Mô tả:** Form xem danh mục điều khoản thanh toán

**Kế thừa:** frmOBView

### 2.2 frmAPTTEdit (Edit Form)

**Mô tả:** Form nhập/sửa điều khoản thanh toán

**Controls - Phần Thông tin chung:**

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_NCC | AsTextBox | DMKH | Mã nhà cung cấp |
| txtTK_pt | AsTextBox | DMTK | Tài khoản phải trả (tk_cn=1) |
| txtMa_tt_po | AsTextBox | DMTT | Mã điều khoản thanh toán |
| txtMa_hd | AsTextBox | DMHD | Mã hợp đồng |
| txtNgay_ct | MaskedTextBox | - | Ngày chứng từ |
| txtSo_ct | TextBox | - | Số chứng từ |
| txtHan_ck | TextNumeric | - | Hạn chiết khấu (ngày) |
| txtHan_tt | TextNumeric | - | Hạn thanh toán (ngày) |
| txttl_ck | TextNumeric | - | Tỷ lệ chiết khấu (%) |
| txtls_qh | TextNumeric | - | Lãi suất quá hạn (%) |
| txtdien_giai | TextBox | - | Diễn giải |
| cboNgoai_te | ComboBox | DMNT | Mã ngoại tệ |
| txtty_gia | TextNumeric | - | Tỷ giá |
| txtNgay_ct_tt | DateTimePicker | - | Ngày thanh toán |
| txtSo_ct_tt | TextBox | - | Số chứng từ thanh toán |

**Controls - Phần Chi tiết (tiền tệ):**

| Control NT | Control VND | Ý nghĩa |
|------------|-------------|---------|
| txtTien_hang_nt | txtTien_hang | Tiền hàng |
| txtTien_thue_nt | txtTien_thue | Tiền thuế |
| txtTong_tt_nt | txtTong_tt | Tổng thanh toán |
| txtTien_tt_nt | txtTien_tt | Đã thanh toán |
| txtDu_hd_nt | txtDu_hd | Còn phải thanh toán |

**Events:**

| Event | Mô tả |
|-------|-------|
| txtMa_tt_po_AfterCodeValidating | Sau validate mã TT, load hạn CK, hạn TT, tỷ lệ CK, lãi suất QH |
| cboNgoai_te_SelectedValueChanged | Thay đổi mã NT, cập nhật tỷ giá |
| txtty_gia_ValueChanged | Thay đổi tỷ giá, tính lại tiền VND |

## 3. Stored Procedures

| SP Name | Mô tả |
|---------|-------|
| asAPGetAPTT | Lấy danh sách điều khoản thanh toán |
| asAPInsAPTT | Thêm điều khoản thanh toán |
| asAPUpdAPTT | Cập nhật điều khoản thanh toán |
| asAPDelAPTT | Xóa điều khoản thanh toán |

## 4. Business Logic

### 4.1 Tính toán tự động

```csharp
// Sau validate mã điều khoản thanh toán
private void txtMa_tt_po_AfterCodeValidating(object sender, AfterCodeValidatingCancelEventArgs e)
{
    if (e.ValidatedRow == null) return;
    
    txtHan_ck.Value = e.ValidatedRow["han_ck"];
    txtHan_tt.Value = e.ValidatedRow["han_tt"];
    txttl_ck.Value = e.ValidatedRow["tl_ck"];
    txtls_qh.Value = e.ValidatedRow["ls_qh"];
}

// Tính tổng thanh toán
private void TinhTongThanhToan()
{
    txtTong_tt_nt.Value = txtTien_hang_nt.Value + txtTien_thue_nt.Value;
    txtTong_tt.Value = txtTien_hang.Value + txtTien_thue.Value;
}

// Tính dư còn phải thanh toán
private void TinhDuThanhToan()
{
    txtDu_hd_nt.Value = txtTong_tt_nt.Value - txtTien_tt_nt.Value;
    txtDu_hd.Value = txtTong_tt.Value - txtTien_tt.Value;
}

// Chuyển đổi ngoại tệ
private void ChuyenDoiNgoaiTe(DataRowView oDv)
{
    if (txtty_gia.Value != 0)
    {
        oDv["tien_hang"] = Math.Round(
            oDv["tien_hang_nt"] * txtty_gia.Value,
            Environment.GetSIConfiguration().Round,
            MidpointRounding.AwayFromZero
        );
    }
}
```

### 4.2 Công thức tính toán

```
Tổng thanh toán NT = Tiền hàng NT + Tiền thuế NT
Tổng thanh toán VND = Tiền hàng VND + Tiền thuế VND
Dư NT = Tổng NT - Đã thanh toán NT
Dư VND = Tổng VND - Đã thanh toán VND
Chuyển đổi: VND = NT × Tỷ giá
```

### 4.3 Validation

- Kiểm tra mã NCC, TK phải trả bắt buộc
- Kiểm tra số chứng từ thanh toán
- Kiểm tra ngày không được trước ngày khóa sổ
- Kiểm tra số liệu cân đối (cảnh báo điều chỉnh)

## 5. Mapping PHP

### 5.1 Model

```php
class APTT extends Model
{
    protected $table = 'APTT';
    protected $primaryKey = 'stt_rec';
    
    protected $fillable = [
        'ma_ncc', 'tk_pt', 'ma_tt_po', 'ma_hd',
        'ngay_ct', 'so_ct', 'han_ck', 'han_tt',
        'tl_ck', 'ls_qh', 'dien_giai', 'ma_nt',
        'ty_gia', 'tien_hang', 'tien_hang_nt',
        'tien_thue', 'tien_thue_nt', 'tong_tt',
        'tong_tt_nt', 'tien_tt', 'tien_tt_nt',
        'du_hd', 'du_hd_nt', 'ngay_ct_tt', 'so_ct_tt'
    ];
    
    public function nhaCungCap()
    {
        return $this->belongsTo(DMKH::class, 'ma_ncc', 'ma_kh');
    }
    
    public function taiKhoan()
    {
        return $this->belongsTo(DMTK::class, 'tk_pt', 'tk');
    }
    
    public function dieuKhoanTT()
    {
        return $this->belongsTo(DMTT::class, 'ma_tt_po', 'ma_tt');
    }
}
```

## 6. Tables liên quan

| Table | Mô tả |
|-------|-------|
| APTT | Điều khoản thanh toán mua hàng |
| DMKH | Danh mục nhà cung cấp |
| DMTK | Danh mục tài khoản |
| DMTT | Danh mục điều khoản thanh toán |
| DMHD | Danh mục hợp đồng |
| DMNT | Danh mục ngoại tệ |
