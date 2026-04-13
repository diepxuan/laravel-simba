# GlRptF5Bctc04.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Drill-down báo cáo tài chính BCTC04

## Forms

### frmGlRptF5Bctc04.cs
- **Kế thừa**: frmDrilldownReport
- **Chức năng**: Form drill-down từ báo cáo BCTC04

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |
| CreateDrilldownArgument | ReportDrillDownInfo, Keys, Keys | ArrayList | Tạo tham số drill-down |

## Data Access

### GlRptF5Bctc04Controller
- **Interface**: IReportController
- **Implementation**: MssqlReportController

## Business Logic

### Drill-down logic
- F5: Drill-down xem chi tiết công thức hoặc sổ chi tiết (TK_NO/TK_CO)

### Luồng xử lý
1. Kiểm tra keycode == 116 (F5) và modifierKeys == 0
2. Lấy dòng dữ liệu hiện tại
3. Nếu có cach_tinh: drill-down xem công thức
4. Nếu có tk_no hoặc tk_co: drill-down xem sổ chi tiết

## Mapping sang PHP

### Controller
```php
class F5BCTC04Controller extends Controller {
    public function drilldown(Request $request) {
        $keycode = $request->input('keycode');
        $modifierKeys = $request->input('modifierKeys');
        
        if ($keycode != 116 || $modifierKeys != 0) {
            return response()->json(['cancel' => true]);
        }
        
        $dataRow = $request->input('dataRow');
        
        if (empty($dataRow['cach_tinh']) && empty($dataRow['tk_no']) && empty($dataRow['tk_co'])) {
            return response()->json(['cancel' => true]);
        }
        
        if (!empty($dataRow['cach_tinh'])) {
            // Drill-down công thức
            return $this->drilldownCongThuc($dataRow);
        } elseif (!empty($dataRow['tk_no']) || !empty($dataRow['tk_co'])) {
            // Drill-down sổ chi tiết
            $params = [
                'company_id' => $request->input('company_id'),
                'tk_no' => $dataRow['tk_no'],
                'tk_co' => $dataRow['tk_co'],
                'ma_vt' => null,
                'ngay_ct1' => $request->input('ngay_ct1'),
                'ngay_ct2' => $request->input('ngay_ct2')
            ];
            return redirect()->route('sochitiet', $params);
        }
    }
}
```

## Ghi chú
- Drill-down từ BCTC04 (báo cáo lưu chuyển tiền tệ)
- Xử lý cả TK_NO và TK_CO
