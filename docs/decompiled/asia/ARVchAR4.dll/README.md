# ARVchAR4.dll - Chứng từ hạch toán công nợ

## Tổng quan

DLL chứng từ hạch toán công nợ (Accounts Receivable Voucher). Xử lý các nghiệp vụ hạch toán công nợ phải thu, bù trừ công nợ.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| Namespace | `AsiaErp.UserInterface` |
| Assembly | `UI.GlVouchers` |
| Version | `1.0.0.0` |
| Company | `Asia Software Development JSC` |
| Copyright | `Copyright © Asia 2010` |
| Title | `Bù trừ công nợ phải thu` |

## Forms chính

### frmArVchAR4
- **Kế thừa**: `frmVoucher`
- **Mô tả**: Form chứng từ hạch toán công nợ
- **Chức năng**:
  - Nhập chứng từ hạch toán công nợ
  - Bù trừ công nợ phải thu
  - Hạch toán nhiều dòng với nhiều tài khoản

### frmArVchAR4Find
- **Kế thừa**: Không xác định
- **Mô tả**: Form tìm kiếm chứng từ

## Controls chính

### Phần thông tin chung (gbPH)
| Control | Type | Mô tả |
|---------|------|-------|
| txtNgay_Ct | `AsMaskedTextBox` | Ngày chứng từ |
| txtSo_Ct | `TextBox` | Số chứng từ |
| txtNgay_lct | `AsMaskedTextBox` | Ngày lập chứng từ |
| cboMa_NT | `AsComboBoxNT` | Mã ngoại tệ |
| txtTy_gia | `AsTextNumeric` | Tỷ giá |
| chkNt_Ph | `AsCheckBox` | Ngoại tệ chung |

### Phần chi tiết (adgvDetail)
| Column | Type | Mô tả |
|--------|------|-------|
| dgvcTk | `DataGridViewAsTextBoxColumn` | Tài khoản |
| dgvcTen_tk | `DataGridViewTextBoxColumn` | Tên TK |
| dgvcMa_kh | `DataGridViewAsTextBoxColumn` | Mã KH |
| dgvcTen_Kh | `DataGridViewTextBoxColumn` | Tên KH |
| dgvcMa_nt | `DataGridViewComboBoxColumn` | Ngoại tệ |
| dgvcTy_gia | `DataGridViewAsTextNumericColumn` | Tỷ giá |
| dgvcPs_no_nt | `DataGridViewAsTextNumericColumn` | Ps nợ NT |
| dgvcPs_co_nt | `DataGridViewAsTextNumericColumn` | Ps có NT |
| dgvcPs_no | `DataGridViewAsTextNumericColumn` | Ps nợ VND |
| dgvcPs_co | `DataGridViewAsTextNumericColumn` | Ps có VND |
| dgvcDien_giai | `DataGridViewTextBoxColumn` | Diễn giải |
| dgvcMa_bp | `DataGridViewAsTextBoxColumn` | Bộ phận |
| dgvcMa_phi | `DataGridViewAsTextBoxColumn` | Phí |
| dgvcMa_hd | `DataGridViewAsTextBoxColumn` | Hợp đồng |
| dgvcMa_spct | `DataGridViewAsTextBoxColumn` | SPCT |
| dgvcNh_dk | `DataGridViewTextBoxColumn` | Nhóm ĐK |

## Business Logic

### Ngoại tệ chung
```csharp
if (chkNt_Ph.Checked) {
    // Ẩn cột ngoại tệ và tỷ giá trên lưới
    dgvcMa_nt.Visible = false;
    dgvcTy_gia.Visible = false;
    // Sử dụng ngoại tệ chung từ phần header
} else {
    // Hiển thị cột ngoại tệ, cho phép nhập từng dòng
}
```

### Tính toán phát sinh
```csharp
// Khi nhập ps nợ NT
dr["ps_no"] = Round(ps_no_nt * ty_gia, Round);

// Khi nhập ps có NT
dr["ps_co"] = Round(ps_co_nt * ty_gia, Round);
```

### Validate
- Tài khoản bắt buộc nhập
- Nếu TK có công nợ (tk_cn=1) thì phải nhập mã KH
- Tổng ps nợ = Tổng ps có (cân đối)
- Kiểm tra nhóm định khoản (nh_dk)

### Kiểm tra nhóm định khoản
```csharp
// Kiểm tra mỗi nhóm định khoản phải cân đối
// Không được có nhiều dòng nợ và nhiều dòng có trong cùng nhóm
```

## Events

| Event | Mô tả |
|-------|-------|
| adgvDetail_CellValueChanged | Xử lý khi thay đổi giá trị cell |
| adgvDetail_CellEnter | Xử lý khi vào cell |
| cboMa_NT_SelectedValueChanged | Thay đổi ngoại tệ |
| txtTy_gia_Validated | Validate tỷ giá |
| chkNt_Ph_CheckedChanged | Thay đổi ngoại tệ chung |

## Dependencies

- `AsiaErp.Framework`
- `System.Data`
- `System.Linq`
- `Microsoft.VisualBasic`

## Ghi chú

- Chứng từ hạch toán tổng hợp công nợ
- Hỗ trợ nhập liệu đa tiền tệ (chung hoặc riêng từng dòng)
- Kiểm soát chặt chẽ việc cân đối nợ/có
- Hỗ trợ nhiều thông tin phân tích (bộ phận, phí, hợp đồng...)
