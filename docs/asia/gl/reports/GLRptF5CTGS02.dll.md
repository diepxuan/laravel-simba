# GLRptF5CTGS02.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Drill-down chứng từ ghi sổ CTGS02

## Forms

### frmGLRptF5CTGS02.cs
- **Kế thừa**: frmDrilldownReport
- **Chức năng**: Form drill-down từ CTGS02

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |
| CreateDrilldownArgument | ReportDrillDownInfo, Keys, Keys | ArrayList | Tạo tham số drill-down |

## Data Access

### GLRptF5CTGS02Controller
- **Interface**: IReportController
- **Implementation**: MssqlReportController

## Business Logic

### Drill-down logic
- F5: Drill-down xem chi tiết chứng từ

### Luồng xử lý
1. Kiểm tra keycode == 116 (F5)
2. Lấy dòng dữ liệu hiện tại
3. Tạo tham số drill-down với ngay_lo, so_lo

## Mapping sang PHP

### Controller
```php
class F5CTGS02Controller extends Controller {
    public function drilldown(Request $request) {
        $keycode = $request->input('keycode');
        $modifierKeys = $request->input('modifierKeys');
        
        if ($keycode != 116) {
            return response()->json(['cancel' => true]);
        }
        
        if ($modifierKeys == 0) {
            $dataRow = $request->input('dataRow');
            
            $params = [
                'company_id' => $request->input('company_id'),
                'ngay1' => $request->input('ngay1'),
                'ngay2' => $request->input('ngay2'),
                'ngay_lo' => $dataRow['ngay_lo'],
                'so_lo' => $dataRow['so_lo'],
                'tk' => $dataRow['tk'],
                'tk_du' => $dataRow['tk_du']
            ];
            
            return redirect()->route('chitietctgs', $params);
        }
    }
}
```

## Ghi chú
- Drill-down xem chi tiết chứng từ ghi sổ
- Truyền thêm thông tin TK và TK_DU
