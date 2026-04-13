# SORptTH02

## Tổng quan
- **Module**: SO (Sales Order)
- **Loại**: Report
- **Chức năng**: Tổng hợp bán hàng theo khách hàng

## Forms

### frmSORptTH02.cs
- **Kế thừa**: frmReport
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| asTextBox | AsTextBox |
| _lblLoai_CT | Label |
| _lblLoai | Label |
| _lblTu_Thang | Label |
| _lblSo_Ky | Label |
| _lblNam | Label |
| lblLoai_CT | Label |
| lblLoai | Label |
| lblTu_Thang | Label |
| lblSo_Ky | Label |
| lblNam | Label |
| obj2 | Label |
| obj6 | Label |
| obj7 | Label |
| obj10 | Label |
| obj19 | Label |
| obj20 | Label |
| obj21 | Label |
| obj22 | Label |
| obj23 | Label |
| obj24 | Label |
| obj25 | Label |
| obj26 | Label |
| obj27 | Label |
| obj28 | Label |
| obj8 | RadioButton |
| obj9 | RadioButton |
| _cboLoai_CT | ComboBox |
| _cboLoai | ComboBox |
| cboMau_bc | ComboBox |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| cboMau_bc_SelectedIndexChanged | void | object sender, EventArgs e |
| InitOtherComponents | void |  |
| ValidData | bool |  |
| LoadData | bool |  |
| GetFilterTitle | string |  |
| ValidateSoKy | bool |  |
| CreateDrilldownArgument | ArrayList | ReportDrillDownInfo drilldownInfo, ref string sDri... |

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
// Tương đương frmSORptTH02.cs
class SORptTH02Controller extends Controller {
    // TODO: Implement
}
```

### Repository
```php
// Tương đương DAO
class SORptTH02Repository {
    // TODO: Implement
}
```

### Model
```php
// Tương đương DataTable
class SORptTH02 extends Model {
    // TODO: Implement
}
```

## Ghi chú
- Document được tạo tự động từ code decompile
- Cần review và bổ sung chi tiết business logic
