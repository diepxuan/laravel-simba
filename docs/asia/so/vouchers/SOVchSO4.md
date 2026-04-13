# SOVchSO4

## Tổng quan
- **Module**: SO (Sales Order)
- **Loại**: Voucher
- **Chức năng**: Chứng từ trả lại hàng bán

## Forms

### frmSoVchSO4.cs
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
| _chkGia_tb | AsCheckBox |
| _chkSua_thue | AsCheckBox |
| _chkSua_tien | AsCheckBox |
| chkGia_tb | AsCheckBox |
| chkSua_thue | AsCheckBox |
| chkSua_tien | AsCheckBox |
| asCheckBox | AsCheckBox |
| asCheckBox2 | AsCheckBox |
| asCheckBox3 | AsCheckBox |
| asCheckBox4 | AsCheckBox |
| asCheckBox5 | AsCheckBox |
| asCheckBox6 | AsCheckBox |
| _lblMa_Kh | Label |
| _lblNguoi_Gd | Label |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| cboMa_NT_SelectedValueChanged | void | object sender, EventArgs e |
| txtMa_Kh_AfterCodeValidating | void | object sender, AfterCodeValidatingCancelEventArgs ... |
| txtMa_Httt_AfterCodeValidating | void | object sender, AfterCodeValidatingCancelEventArgs ... |
| txtTy_gia_Validated | void | object sender, EventArgs e |
| chkSua_tien_CheckedChanged | void | object sender, EventArgs e |
| chkSua_thue_CheckedChanged | void | object sender, EventArgs e |
| adgvDetail_CellValueChanged | void | object sender, DataGridViewCellEventArgs e |
| adgvDetail_CellEnter | void | object sender, DataGridViewCellEventArgs e |
| adgvHach_toan_CellEnter | void | object sender, DataGridViewCellEventArgs e |
| cmdChon_px_Click | void | object sender, EventArgs e |
| cmdGetTaInFromDetail_Click | void | object sender, EventArgs e |
| ctlTaIn_TAINValueChanged | void | object sender, EventArgs e |
| adgvDetail_BeforeSetDependentFieldsWhenCellValueChanged | void | object sender, SetDependentFieldsWhenCellValueChan... |
| W_Ma_Vt | bool | DataRowView oDv |
| W_Tien_Nt2 | bool | DataRowView oDv |
| W_Tien2 | bool | DataRowView oDv |
| W_Gia2 | bool | DataRowView oDv |
| W_Tien_Nt | bool | DataRowView oDv |

### frmSoVchSo4FindSO3.cs
- **Kế thừa**: frmAsiaRoot
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _txtMa_Hd | AsTextBox |
| _txtTk_pt | AsTextBox |
| _txtMa_Kh | AsTextBox |
| txtMa_Hd | AsTextBox |
| txtTk_pt | AsTextBox |
| txtMa_Kh | AsTextBox |
| asTextBox | AsTextBox |
| asTextBox2 | AsTextBox |
| asTextBox3 | AsTextBox |
| asTextBox4 | AsTextBox |
| asTextBox5 | AsTextBox |
| asTextBox6 | AsTextBox |
| _Label1 | Label |
| _Label2 | Label |
| _Label3 | Label |
| _Label4 | Label |
| _lblDien_giai | Label |
| _lblTen_Hd | Label |
| _lblMa_Hd | Label |
| _lblTen_Tk_pt | Label |
| _lblTk_pt | Label |
| _lblNguoi_Gd | Label |
| _lblTen_Kh | Label |
| _lblMa_Kh | Label |
| Label1 | Label |
| Label2 | Label |
| Label3 | Label |
| Label4 | Label |
| lblDien_giai | Label |
| lblTen_Hd | Label |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| cmdOk_Click | void | object sender, EventArgs e |
| cmdCancel_Click | void | object sender, EventArgs e |
| frmArVchAr1FindSO3SO5_KeyDown | void | object sender, KeyEventArgs e |

### frmSoVchSo4FindSO2.cs
- **Kế thừa**: frmAsiaRoot
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _txtMa_Hd | AsTextBox |
| _txtMa_Kh | AsTextBox |
| txtMa_Hd | AsTextBox |
| txtMa_Kh | AsTextBox |
| asTextBox | AsTextBox |
| asTextBox2 | AsTextBox |
| asTextBox3 | AsTextBox |
| asTextBox4 | AsTextBox |
| _Label1 | Label |
| _Label2 | Label |
| _Label3 | Label |
| _Label4 | Label |
| _lblDien_giai | Label |
| _lblTen_Hd | Label |
| _lblMa_Hd | Label |
| _lblNguoi_Gd | Label |
| _lblTen_Kh | Label |
| _lblMa_Kh | Label |
| Label1 | Label |
| Label2 | Label |
| Label3 | Label |
| Label4 | Label |
| lblDien_giai | Label |
| lblTen_Hd | Label |
| lblMa_Hd | Label |
| lblNguoi_Gd | Label |
| lblTen_Kh | Label |
| lblMa_Kh | Label |
| label | Label |
| label2 | Label |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| cmdOk_Click | void | object sender, EventArgs e |
| cmdCancel_Click | void | object sender, EventArgs e |
| frmArVchAr1FindSO3SO5_KeyDown | void | object sender, KeyEventArgs e |

### frmSoVchSO4SeachSO2SO3.cs
- **Kế thừa**: frmAsiaRoot
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _tsslCountlbl | Label |
| _tsslOther | Label |
| _tsslCount | Label |
| tsslCountlbl | Label |
| tsslOther | Label |
| tsslCount | Label |
| obj3 | Label |
| obj4 | Label |
| obj5 | Label |
| _cmdChon | Button |
| cmdChon | Button |
| obj6 | Button |
| obj7 | Button |
| _dgvPh | DataGridView |
| _dgvCt | DataGridView |
| dgvPh | DataGridView |
| dgvCt | DataGridView |
| asDataGridView | DataGridView |
| asDataGridView2 | DataGridView |
| asDataGridView3 | DataGridView |
| asDataGridView4 | DataGridView |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| frmVoucherView_KeyDown | void | object sender, KeyEventArgs e |
| frmVoucherView_Load | void | object sender, EventArgs e |
| dgvPh_CellValueChanged | void | object sender, DataGridViewCellEventArgs e |
| dgvCt_CellValueChanged | void | object sender, DataGridViewCellEventArgs e |
| dgvPh_CurrentCellChanged | void | object sender, EventArgs e |
| FilterCt | void |  |
| SetStatusBar | void |  |

### frmSoVchSO4Find.cs
- **Kế thừa**: frmVoucherFind
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _txtMa_Kh | AsTextBox |
| _txtTk_vt | AsTextBox |
| _txtMa_vt | AsTextBox |
| _txtMa_Hd | AsTextBox |
| _txtMa_Kho | AsTextBox |
| _txtMa_Bp | AsTextBox |
| _txtTk_tl | AsTextBox |
| _txtTk_gv | AsTextBox |
| _txtMa_Nvkd | AsTextBox |
| _txtTk_ck | AsTextBox |
| _txtMa_Lo | AsTextBox |
| _txtMa_Httt | AsTextBox |
| txtMa_Kh | AsTextBox |
| txtTk_vt | AsTextBox |
| txtMa_vt | AsTextBox |
| txtMa_Hd | AsTextBox |
| txtMa_Kho | AsTextBox |
| txtMa_Bp | AsTextBox |
| txtTk_tl | AsTextBox |
| txtTk_gv | AsTextBox |
| txtMa_Nvkd | AsTextBox |
| txtTk_ck | AsTextBox |
| txtMa_Lo | AsTextBox |
| txtMa_Httt | AsTextBox |
| asTextBox | AsTextBox |
| asTextBox2 | AsTextBox |
| asTextBox3 | AsTextBox |
| asTextBox4 | AsTextBox |
| asTextBox5 | AsTextBox |
| asTextBox6 | AsTextBox |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |

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
// Tương đương frmSoVchSO4.cs
class SOVchSO4Controller extends Controller {
    // TODO: Implement
}
```

### Repository
```php
// Tương đương DAO
class SOVchSO4Repository {
    // TODO: Implement
}
```

### Model
```php
// Tương đương DataTable
class SOVchSO4 extends Model {
    // TODO: Implement
}
```

## Ghi chú
- Document được tạo tự động từ code decompile
- Cần review và bổ sung chi tiết business logic
