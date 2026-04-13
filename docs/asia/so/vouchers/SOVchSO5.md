# SOVchSO5

## Tổng quan
- **Module**: SO (Sales Order)
- **Loại**: Voucher
- **Chức năng**: Chứng từ chiết khấu hàng bán

## Forms

### frmSoVchSO5.cs
- **Kế thừa**: frmVoucher
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _txtMa_Kh | AsTextBox |
| _txtTk_pt | AsTextBox |
| _txtTk_thue | AsTextBox |
| _txtMa_Httt | AsTextBox |
| txtMa_Kh | AsTextBox |
| txtTk_pt | AsTextBox |
| txtTk_thue | AsTextBox |
| txtMa_Httt | AsTextBox |
| asTextBox | AsTextBox |
| asTextBox2 | AsTextBox |
| asTextBox3 | AsTextBox |
| asTextBox4 | AsTextBox |
| asTextBox5 | AsTextBox |
| asTextBox6 | AsTextBox |
| asTextBox7 | AsTextBox |
| asTextBox8 | AsTextBox |
| _chkSua_ck | AsCheckBox |
| _chkSua_thue | AsCheckBox |
| chkSua_ck | AsCheckBox |
| chkSua_thue | AsCheckBox |
| asCheckBox | AsCheckBox |
| asCheckBox2 | AsCheckBox |
| asCheckBox3 | AsCheckBox |
| asCheckBox4 | AsCheckBox |
| _lblDien_giai | Label |
| _lblSo_seri | Label |
| _lblNgay_Lct | Label |
| _lblMa_Nt | Label |
| _lblT_Tt | Label |
| _lblT_Thue | Label |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| cboMa_NT_SelectedValueChanged | void | object sender, EventArgs e |
| txtMa_Kh_AfterCodeValidating | void | object sender, AfterCodeValidatingCancelEventArgs ... |
| txtMa_Httt_AfterCodeValidating | void | object sender, AfterCodeValidatingCancelEventArgs ... |
| txtTy_gia_Validated | void | object sender, EventArgs e |
| chkSua_thue_CheckedChanged | void | object sender, EventArgs e |
| chkSua_ck_CheckedChanged | void | object sender, EventArgs e |
| adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged | void | object sender, SetDependentFieldsWhenCellValueChan... |
| adgvDetail_CellValueChanged | void | object sender, DataGridViewCellEventArgs e |
| adgvDetail_CellEnter | void | object sender, DataGridViewCellEventArgs e |
| adgvHach_toan_CellEnter | void | object sender, DataGridViewCellEventArgs e |
| cmdThanh_toan_Click | void | object sender, EventArgs e |
| W_Gia2 | bool | DataRowView oDv |
| W_Tien2 | bool | DataRowView oDv |
| W_Tien_Ck_Nt | bool | DataRowView oDv |
| W_Thue_Gtgt_Nt | bool | DataRowView oDv |
| W_Tien_Ck | bool | DataRowView oDv |
| W_Thue_Gtgt | bool | DataRowView oDv |
| V_Ma_Vt | void | DataRowView oDv, DataRow oDrValidated |

### frmSoVchSo5Print.cs
- **Kế thừa**: frmVoucherPrint
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _Label1 | Label |
| Label1 | Label |
| obj3 | Label |
| obj4 | Label |
| label | Label |
| label2 | Label |
| _cmbHTTT | ComboBox |
| cmbHTTT | ComboBox |
| obj9 | ComboBox |
| obj10 | ComboBox |
| obj2 | Button |
| obj5 | Button |
| obj6 | Button |
| obj7 | Button |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| InitOtherComponent | void |  |
| SetExtensionFormulaField | void |  |

### frmSoVchSO5Find.cs
- **Kế thừa**: frmVoucherFind
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _txtMa_Kh | AsTextBox |
| _txtMa_vt | AsTextBox |
| _txtMa_Hd | AsTextBox |
| _txtMa_Kho | AsTextBox |
| _txtMa_Bp | AsTextBox |
| _txtTk_dt | AsTextBox |
| _txtMa_Nvkd | AsTextBox |
| _txtTk_ck | AsTextBox |
| _txtMa_Httt | AsTextBox |
| _txtMa_Lo | AsTextBox |
| txtMa_Kh | AsTextBox |
| txtMa_vt | AsTextBox |
| txtMa_Hd | AsTextBox |
| txtMa_Kho | AsTextBox |
| txtMa_Bp | AsTextBox |
| txtTk_dt | AsTextBox |
| txtMa_Nvkd | AsTextBox |
| txtTk_ck | AsTextBox |
| txtMa_Httt | AsTextBox |
| txtMa_Lo | AsTextBox |
| asTextBox | AsTextBox |
| asTextBox2 | AsTextBox |
| asTextBox3 | AsTextBox |
| asTextBox4 | AsTextBox |
| asTextBox5 | AsTextBox |
| asTextBox6 | AsTextBox |
| asTextBox7 | AsTextBox |
| asTextBox8 | AsTextBox |
| asTextBox9 | AsTextBox |
| asTextBox10 | AsTextBox |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |

## Other Classes

### VB-AnonymousType_3.cs
- **Class**: 
- **Inherits**: N/A

### VB-AnonymousType_2.cs
- **Class**: 
- **Inherits**: N/A

### VB-AnonymousType_0.cs
- **Class**: 
- **Inherits**: N/A

## Tables liên quan

| Table | Mục đích |
|-------|----------|
| row | |
| _0024VB_0024It | |

## Business Logic

### Luồng xử lý chính
1. [Cần phân tích thêm từ code]

### Validation rules
- [Cần phân tích thêm từ code]

### Calculation logic
- [Cần phân tích thêm từ code]

## Mapping sang PHP

### Controller
```php
// Tương đương frmSoVchSO5.cs
class SOVchSO5Controller extends Controller {
    // TODO: Implement
}
```

### Repository
```php
// Tương đương DAO
class SOVchSO5Repository {
    // TODO: Implement
}
```

### Model
```php
// Tương đương DataTable
class SOVchSO5 extends Model {
    // TODO: Implement
}
```

## Ghi chú
- Document được tạo tự động từ code decompile
- Cần review và bổ sung chi tiết business logic
