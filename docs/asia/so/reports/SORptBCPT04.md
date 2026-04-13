# SORptBCPT04

## Tổng quan
- **Module**: SO (Sales Order)
- **Loại**: Report
- **Chức năng**: Báo cáo chi phí theo bộ phận, vật tư

## Forms

### frmSORptBCPT04.cs
- **Kế thừa**: frmReport
- **Namespace**: AsiaErp.UserInterface

#### Controls
| Control | Type |
|---------|------|
| _txtMa_vitri | AsTextBox |
| _txtMaLo | AsTextBox |
| _txtMA_DKTT | AsTextBox |
| _txtMA_HTTT | AsTextBox |
| _txtMa_Nvkd | AsTextBox |
| _txtMa_Bp | AsTextBox |
| _txtMa_kho | AsTextBox |
| _txtMa_nhvt | AsTextBox |
| _txtMa_vt | AsTextBox |
| _txtMa_nhhd | AsTextBox |
| _txtMa_hd | AsTextBox |
| _txtMa_NhKh | AsTextBox |
| _txtMa_Kh | AsTextBox |
| _txtMa_Plkh1 | AsTextBox |
| _txtMa_Plkh3 | AsTextBox |
| _txtMa_Plkh2 | AsTextBox |
| _txtMa_plvt1 | AsTextBox |
| _txtMa_plvt2 | AsTextBox |
| _txtMa_plvt3 | AsTextBox |
| _txtMa_spct | AsTextBox |
| txtMa_vitri | AsTextBox |
| txtMaLo | AsTextBox |
| txtMA_DKTT | AsTextBox |
| txtMA_HTTT | AsTextBox |
| txtMa_Nvkd | AsTextBox |
| txtMa_Bp | AsTextBox |
| txtMa_kho | AsTextBox |
| txtMa_nhvt | AsTextBox |
| txtMa_vt | AsTextBox |
| txtMa_nhhd | AsTextBox |

#### Methods
| Method | Return | Params |
|--------|--------|--------|
| Dispose | void | bool disposing |
| InitializeComponent | void |  |
| LoadData | bool |  |
| CreateDrilldownArgument | ArrayList | ReportDrillDownInfo drilldownInfo, ref string sDri... |
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
// Tương đương frmSORptBCPT04.cs
class SORptBCPT04Controller extends Controller {
    // TODO: Implement
}
```

### Repository
```php
// Tương đương DAO
class SORptBCPT04Repository {
    // TODO: Implement
}
```

### Model
```php
// Tương đương DataTable
class SORptBCPT04 extends Model {
    // TODO: Implement
}
```

## Ghi chú
- Document được tạo tự động từ code decompile
- Cần review và bổ sung chi tiết business logic
