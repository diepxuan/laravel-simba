# GLRptF5CTGS01.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Drill-down chứng từ ghi sổ CTGS01
- **Framework**: .NET Framework 3.5
- **Base Class**: frmDrilldownReport
- **AllowUnsafeBlocks**: True

## Forms

### frmGLRptF5CTGS01.cs
- **Kế thừa**: frmDrilldownReport
- **Chức năng**: Form drill-down từ CTGS01 (Chứng từ ghi sổ)

#### Thuộc tính Form
| Thuộc tính | Giá trị |
|-------------|---------|
| AutoScaleMode | Font (1) |
| Text | frmGLRptF5CTGS01 |

#### Constructors
| Constructor | Tham số | Mục đích |
|-------------|---------|----------|
| `frmGLRptF5CTGS01()` | none | Default constructor |
| `frmGLRptF5CTGS01(...)` | ReportInformation, drilldownMenuId, AsDictionary, bool, string, string, string, object, params object[] | Constructor với thông tin báo cáo mẹ |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitOtherComponents | - | void | Khởi tạo thêm components, focus vào dgvBC |

## Data Access

### GLRptF5CTGS01Controller
- **Interface**: IReportController
- **Implementation**: MssqlReportController

## Business Logic

### Drill-down logic
- Form drill-down đơn giản, không override phương thức CreateDrilldownArgument
- Sử dụng drilldown logic mặc định từ base class frmDrilldownReport
- Không có logic drill-down phức tạp riêng

### CTGS (Chứng từ Ghi Sổ)
CTGS là viết tắt của "Chứng từ Ghi Sổ" - một loại chứng từ kế toán quan trọng trong hệ thống kế toán Việt Nam, dùng để ghi nhận các nghiệp vụ kinh tế phát sinh vào sổ kế toán.

## Mapping sang PHP

### Controller
```php
class F5CTGS01Controller extends Controller {
    public function drilldown(Request $request) {
        // Drill-down đơn giản từ CTGS01
        // Sử dụng logic mặc định từ base controller
        $dataRow = $request->input('dataRow');
        
        return response()->json([
            'data' => $dataRow,
            'view' => 'reports.ctgs01_detail'
        ]);
    }
}
```

## Ghi chú
- Form drill-down đơn giản
- Chủ yếu hiển thị dữ liệu đã được truyền từ form mẹ
- Không có UI controls riêng - sử dụng dgvBC từ form mẹ
- Sử dụng AutoScaleMode = Font cho scaling tự động
- Tích hợp với Asia ERP Framework
- Kế thừa từ frmDrilldownReport - form báo cáo có khả năng drilldown
