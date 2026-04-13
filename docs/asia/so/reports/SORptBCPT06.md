# SORptBCPT06

## Tổng quan
- **Module**: SO (Sales Order)
- **Loại**: Report
- **Chức năng**: Báo cáo chi phí theo nhân viên kinh doanh

## Forms

### frmSORptBCPT06.cs
- **Kế thừa**: frmReport
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _txtMa_Plvt1 | AsTextBox |
| _txtMa_Plvt2 | AsTextBox |
| _txtMa_plvt3 | AsTextBox |
| _txtMa_Plkh1 | AsTextBox |
| _txtMa_Plkh2 | AsTextBox |
| _txtMa_Plkh3 | AsTextBox |
| _txtMa_kho | AsTextBox |
| _txtMa_bp | AsTextBox |
| _txtMa_nvkd | AsTextBox |
| _txtMa_hd | AsTextBox |
| _txtMa_nhhd | AsTextBox |
| _txtMa_kh | AsTextBox |
| _txtMa_Nhkh | AsTextBox |
| _txtMa_vt | AsTextBox |
| _txtMa_nhvt | AsTextBox |
| _txtMa_HTTT | AsTextBox |
| txtMa_Plvt1 | AsTextBox |
| txtMa_Plvt2 | AsTextBox |
| txtMa_plvt3 | AsTextBox |
| txtMa_Plkh1 | AsTextBox |
| txtMa_Plkh2 | AsTextBox |
| txtMa_Plkh3 | AsTextBox |
| txtMa_kho | AsTextBox |
| txtMa_bp | AsTextBox |
| txtMa_nvkd | AsTextBox |
| txtMa_hd | AsTextBox |
| txtMa_nhhd | AsTextBox |
| txtMa_kh | AsTextBox |
| txtMa_Nhkh | AsTextBox |
| txtMa_vt | AsTextBox |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| InitOtherComponents | void |  |
| LoadData | bool |  |
| CreateDrilldownArgument | ArrayList | ReportDrillDownInfo drilldownInfo, ref string sDri... |
| convertoToInt | object | bool ck |
| GetFilterTitle | string |  |
| cboChi_Tiet_Theo_GotFocus | void | object sender, EventArgs e |
| cboNhom_Theo_SelectedIndexChanged | void | object sender, EventArgs e |

## Other Classes

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
// Tương đương frmSORptBCPT06.cs
class SORptBCPT06Controller extends Controller {
    // TODO: Implement
}
```

### Repository
```php
// Tương đương DAO
class SORptBCPT06Repository {
    // TODO: Implement
}
```

### Model
```php
// Tương đương DataTable
class SORptBCPT06 extends Model {
    // TODO: Implement
}
```

## Ghi chú
- Document được tạo tự động từ code decompile
- Cần review và bổ sung chi tiết business logic
