# SORptTH01

## Tổng quan
- **Module**: SO (Sales Order)
- **Loại**: Report
- **Chức năng**: Tổng hợp bán hàng

## Forms

### frmSORptTH01.cs
- **Kế thừa**: frmReport
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _txtMa_nvkd | AsTextBox |
| _txtMa_bp | AsTextBox |
| _txtMA_DKTT | AsTextBox |
| _txtMA_HTTT | AsTextBox |
| _txtMa_nhvt | AsTextBox |
| _txtMa_vt | AsTextBox |
| _txtMa_nhhd | AsTextBox |
| _txtMa_hd | AsTextBox |
| _txtMa_NhKh | AsTextBox |
| _txtMa_Kh | AsTextBox |
| _txtMa_plkh1 | AsTextBox |
| _txtMa_spct | AsTextBox |
| _txtMa_plkh2 | AsTextBox |
| _txtMa_plkh3 | AsTextBox |
| _txtMa_plvt1 | AsTextBox |
| _txtMa_plvt2 | AsTextBox |
| _txtMaLo | AsTextBox |
| _txtMa_plvt3 | AsTextBox |
| _txtMa_vitri | AsTextBox |
| _txtMa_kho | AsTextBox |
| txtMa_nvkd | AsTextBox |
| txtMa_bp | AsTextBox |
| txtMA_DKTT | AsTextBox |
| txtMA_HTTT | AsTextBox |
| txtMa_nhvt | AsTextBox |
| txtMa_vt | AsTextBox |
| txtMa_nhhd | AsTextBox |
| txtMa_hd | AsTextBox |
| txtMa_NhKh | AsTextBox |
| txtMa_Kh | AsTextBox |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| InitOtherComponents | void |  |
| LoadData | bool |  |
| GetFilterTitle | string |  |
| CreateDrilldownArgument | ArrayList | ReportDrillDownInfo drilldownInfo, ref string sDri... |
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
// Tương đương frmSORptTH01.cs
class SORptTH01Controller extends Controller {
    // TODO: Implement
}
```

### Repository
```php
// Tương đương DAO
class SORptTH01Repository {
    // TODO: Implement
}
```

### Model
```php
// Tương đương DataTable
class SORptTH01 extends Model {
    // TODO: Implement
}
```

## Ghi chú
- Document được tạo tự động từ code decompile
- Cần review và bổ sung chi tiết business logic
