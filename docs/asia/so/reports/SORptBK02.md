# SORptBK02

## Tổng quan
- **Module**: SO (Sales Order)
- **Loại**: Report
- **Chức năng**: Sổ chi tiết bán hàng theo chứng từ

## Forms

### frmSORptBK02.cs
- **Kế thừa**: frmReport
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _txtMa_spct | AsTextBox |
| _txtMA_DKTT | AsTextBox |
| _txtMA_HTTT | AsTextBox |
| _txtMa_Lo | AsTextBox |
| _txtMa_vitri | AsTextBox |
| _txtMa_nvkd | AsTextBox |
| _txtMa_bp | AsTextBox |
| _txtMa_kho | AsTextBox |
| _txtMa_plvt3 | AsTextBox |
| _txtMa_plvt2 | AsTextBox |
| _txtMa_plvt1 | AsTextBox |
| _txtMa_nhvt | AsTextBox |
| _txtMa_vt | AsTextBox |
| _txtMa_nhhd | AsTextBox |
| _txtMa_hd | AsTextBox |
| _txtMa_plkh3 | AsTextBox |
| _txtMa_plkh2 | AsTextBox |
| _txtMa_plkh1 | AsTextBox |
| _txtMa_nhkh | AsTextBox |
| _txtMa_kh | AsTextBox |
| txtMa_spct | AsTextBox |
| txtMA_DKTT | AsTextBox |
| txtMA_HTTT | AsTextBox |
| txtMa_Lo | AsTextBox |
| txtMa_vitri | AsTextBox |
| txtMa_nvkd | AsTextBox |
| txtMa_bp | AsTextBox |
| txtMa_kho | AsTextBox |
| txtMa_plvt3 | AsTextBox |
| txtMa_plvt2 | AsTextBox |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| InitOtherComponents | void |  |
| LoadData | bool |  |
| GetFilterTitle | string |  |
| cboMau_bc_SelectedIndexChanged | void | object sender, EventArgs e |

## Other Classes

### lstVoucherInfo.cs
- **Class**: lstVoucherInfo
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
// Tương đương frmSORptBK02.cs
class SORptBK02Controller extends Controller {
    // TODO: Implement
}
```

### Repository
```php
// Tương đương DAO
class SORptBK02Repository {
    // TODO: Implement
}
```

### Model
```php
// Tương đương DataTable
class SORptBK02 extends Model {
    // TODO: Implement
}
```

## Ghi chú
- Document được tạo tự động từ code decompile
- Cần review và bổ sung chi tiết business logic
