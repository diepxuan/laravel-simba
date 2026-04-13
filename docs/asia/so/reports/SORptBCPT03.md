# SORptBCPT03

## Tổng quan
- **Module**: SO (Sales Order)
- **Loại**: Report
- **Chức năng**: Báo cáo chi phí theo vật tư, khách hàng

## Forms

### frmSORptBCPT03.cs
- **Kế thừa**: frmReport
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _txtMa_nhhd | AsTextBox |
| _txtMa_hd | AsTextBox |
| _txtMa_plkh3 | AsTextBox |
| _txtMa_plkh2 | AsTextBox |
| _txtMa_plkh1 | AsTextBox |
| _txtMa_NhKh | AsTextBox |
| _txtMa_Kh | AsTextBox |
| _txtMa_plvt3 | AsTextBox |
| _txtMa_plvt2 | AsTextBox |
| _txtMa_plvt1 | AsTextBox |
| _txtMa_nhvt | AsTextBox |
| _txtMa_vt | AsTextBox |
| _txtMa_kho | AsTextBox |
| _txtMa_Nvkd | AsTextBox |
| _txtMa_Bp | AsTextBox |
| _txtTK_QL | AsTextBox |
| _txtTk_BH | AsTextBox |
| _txtTK_QKDN_DU | AsTextBox |
| _txtTK_CPBH_DU | AsTextBox |
| txtMa_nhhd | AsTextBox |
| txtMa_hd | AsTextBox |
| txtMa_plkh3 | AsTextBox |
| txtMa_plkh2 | AsTextBox |
| txtMa_plkh1 | AsTextBox |
| txtMa_NhKh | AsTextBox |
| txtMa_Kh | AsTextBox |
| txtMa_plvt3 | AsTextBox |
| txtMa_plvt2 | AsTextBox |
| txtMa_plvt1 | AsTextBox |
| txtMa_nhvt | AsTextBox |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| InitOtherComponents | void |  |
| LoadData | bool |  |
| CreateDrilldownArgument | ArrayList | ReportDrillDownInfo drilldownInfo, ref string sDri... |
| rbDT_No_CheckedChanged | void | object sender, EventArgs e |
| rbCP_No_CheckedChanged | void | object sender, EventArgs e |
| GetFilterTitle | string |  |

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
// Tương đương frmSORptBCPT03.cs
class SORptBCPT03Controller extends Controller {
    // TODO: Implement
}
```

### Repository
```php
// Tương đương DAO
class SORptBCPT03Repository {
    // TODO: Implement
}
```

### Model
```php
// Tương đương DataTable
class SORptBCPT03 extends Model {
    // TODO: Implement
}
```

## Ghi chú
- Document được tạo tự động từ code decompile
- Cần review và bổ sung chi tiết business logic
