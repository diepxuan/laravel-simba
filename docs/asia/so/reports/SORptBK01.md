# SORptBK01

## Tổng quan
- **Module**: SO (Sales Order)
- **Loại**: Report
- **Chức năng**: Sổ chi tiết bán hàng

## Forms

### frmSORptBK01.cs
- **Kế thừa**: frmReport2DGV
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _txtMa_vitri | AsTextBox |
| _txtMA_DKTT | AsTextBox |
| _txtMA_HTTT | AsTextBox |
| _txtMa_nhhd | AsTextBox |
| _txtMaLo | AsTextBox |
| _txtMa_kh | AsTextBox |
| _txtMa_hd | AsTextBox |
| _txtMa_vt | AsTextBox |
| _txtMa_nhvt | AsTextBox |
| _txtMa_kho | AsTextBox |
| _txtMa_Nhkh | AsTextBox |
| _txtMa_spct | AsTextBox |
| _txtMa_Plkh3 | AsTextBox |
| _txtMa_Plkh2 | AsTextBox |
| _txtMa_Plkh1 | AsTextBox |
| _txtMa_Plvt1 | AsTextBox |
| _txtMa_plvt3 | AsTextBox |
| _txtMa_Plvt2 | AsTextBox |
| _txtMa_bp | AsTextBox |
| _txtMa_nvkd | AsTextBox |
| txtMa_vitri | AsTextBox |
| txtMA_DKTT | AsTextBox |
| txtMA_HTTT | AsTextBox |
| txtMa_nhhd | AsTextBox |
| txtMaLo | AsTextBox |
| txtMa_kh | AsTextBox |
| txtMa_hd | AsTextBox |
| txtMa_vt | AsTextBox |
| txtMa_nhvt | AsTextBox |
| txtMa_kho | AsTextBox |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| InitOtherComponents | void |  |
| LoadData | bool |  |
| GetFilterTitle | string |  |
| dgvBCPh_RowEnter | void | object sender, DataGridViewCellEventArgs e |
| cboMau_bc_SelectedIndexChanged | void | object sender, EventArgs e |

## Other Classes

### lstVoucherInfo.cs
- **Class**: lstVoucherInfo
- **Inherits**: N/A

### InternalXmlHelper.cs
- **Class**: 
- **Inherits**: N/A

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
// Tương đương frmSORptBK01.cs
class SORptBK01Controller extends Controller {
    // TODO: Implement
}
```

### Repository
```php
// Tương đương DAO
class SORptBK01Repository {
    // TODO: Implement
}
```

### Model
```php
// Tương đương DataTable
class SORptBK01 extends Model {
    // TODO: Implement
}
```

## Ghi chú
- Document được tạo tự động từ code decompile
- Cần review và bổ sung chi tiết business logic
