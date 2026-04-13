# SORptLaiLo

## Tổng quan
- **Module**: SO (Sales Order)
- **Loại**: Report
- **Chức năng**: Báo cáo lãi lỗ

## Forms

### frmSORptLaiLo.cs
- **Kế thừa**: frmReport
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _txtMa_HD | AsTextBox |
| _txtMa_KH | AsTextBox |
| txtMa_HD | AsTextBox |
| txtMa_KH | AsTextBox |
| asTextBox | AsTextBox |
| asTextBox2 | AsTextBox |
| asTextBox3 | AsTextBox |
| asTextBox4 | AsTextBox |
| asTextBox5 | AsTextBox |
| _lblTen_HD | Label |
| _lblMa_TD | Label |
| _lblMa_KH | Label |
| _Label4 | Label |
| _Label1 | Label |
| _Label2 | Label |
| _Label3 | Label |
| _Label5 | Label |
| _Label7 | Label |
| _Label6 | Label |
| lblTen_HD | Label |
| lblMa_TD | Label |
| lblMa_KH | Label |
| Label4 | Label |
| Label1 | Label |
| Label2 | Label |
| Label3 | Label |
| Label5 | Label |
| Label7 | Label |
| Label6 | Label |
| obj4 | Label |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| LoadData | bool |  |
| GetFilterTitle | string |  |
| ValidData | bool |  |
| frmSORptLaiLo_Load | void | object sender, EventArgs e |
| rbDT_No_CheckedChanged | void | object sender, EventArgs e |
| tbCP_No_CheckedChanged | void | object sender, EventArgs e |
| CreateDrilldownArgument | ArrayList | ReportDrillDownInfo drilldownInfo, ref string sDri... |

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
// Tương đương frmSORptLaiLo.cs
class SORptLaiLoController extends Controller {
    // TODO: Implement
}
```

### Repository
```php
// Tương đương DAO
class SORptLaiLoRepository {
    // TODO: Implement
}
```

### Model
```php
// Tương đương DataTable
class SORptLaiLo extends Model {
    // TODO: Implement
}
```

## Ghi chú
- Document được tạo tự động từ code decompile
- Cần review và bổ sung chi tiết business logic
