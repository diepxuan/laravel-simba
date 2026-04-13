# GLRptF5CTGS03.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Drill-down chứng từ ghi sổ CTGS03

## Forms

### frmGLRptF5CTGS03.cs
- **Kế thừa**: frmDrilldownReport
- **Chức năng**: Form drill-down từ CTGS03

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |

## Data Access

### GLRptF5CTGS03Controller
- **Interface**: IReportController
- **Implementation**: MssqlReportController

## Business Logic

### Drill-down logic
- Form drill-down đơn giản, không có logic drill-down phức tạp

## Mapping sang PHP

### Controller
```php
class F5CTGS03Controller extends Controller {
    public function drilldown(Request $request) {
        // Drill-down đơn giản từ CTGS03
        return response()->json(['data' => $request->all()]);
    }
}
```

## Ghi chú
- Form drill-down đơn giản
- Chủ yếu hiển thị dữ liệu đã được truyền từ form mẹ
