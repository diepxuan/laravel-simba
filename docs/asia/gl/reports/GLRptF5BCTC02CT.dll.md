# GLRptF5BCTC02CT.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Drill-down báo cáo tài chính BCTC02 chi tiết (Bảng cân đối kế toán chi tiết)
- **Framework**: .NET Framework 3.5
- **Base Class**: frmDrilldownReport

## Forms

### frmGLRptF5BCTC02CT.cs
- **Kế thừa**: frmDrilldownReport
- **Chức năng**: Form drill-down chi tiết từ BCTC02

#### Constructors
| Constructor | Tham số | Mục đích |
|-------------|---------|----------|
| `frmGLRptF5BCTC02CT()` | Không tham số | Khởi tạo form mặc định |
| `frmGLRptF5BCTC02CT(...)` | motherReportInfo, drilldownMenuId, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, datasource, arg | Khởi tạo form drilldown với tham số từ báo cáo mẹ |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitOtherComponents | - | void | Khởi tạo các thành phần khác, select vào dgvBC |
| CreateDrilldownArgument | ReportDrillDownInfo, Keys, Keys | ArrayList | Tạo tham số drill-down theo tk_du |

## Data Access

### GLRptF5BCTC02CTController
- **Interface**: IReportController
- **Implementation**: MssqlReportController

## Business Logic

### Drill-down logic (F7)

#### Modifier Keys = 0 (F7 thường)
| Điều kiện | Hành động |
|-----------|-----------|
| `tk_du` rỗng | Hủy drilldown |
| `tk_du` KHÔNG rỗng | Drilldown theo tài khoản đối ứng:<br>- Tham số: CompanyID, "" (tk_no rỗng), tk_du, ngay_dau_nam, ngay_ct2<br>- Filter: tk_du<br>- ngay_dau_nam = ngày 01/01 của năm báo cáo |

#### Modifier Keys khác (Ctrl, Shift, Alt)
| Điều kiện | Hành động |
|-----------|-----------|
| Bất kỳ | Hủy drilldown |

### Các trường dữ liệu quan trọng
| Trường | Ý nghĩa |
|--------|---------|
| `tk_du` | Tài khoản đối ứng |
| `ngay_ct2` | Ngày đến của báo cáo |
| `ngay_dau_nam` | Ngày 01/01 của năm báo cáo (tự động tính) |

## Mapping sang PHP

### Controller
```php
class F5BCTC02CTController extends Controller {
    public function drilldown(Request $request) {
        $keycode = $request->input('keycode');
        $modifierKeys = $request->input('modifierKeys');
        
        if ($keycode == 116 && $modifierKeys == 0) {
            $dataRow = $request->input('dataRow');
            
            if (!empty($dataRow['tk_du'])) {
                // Tính ngày đầu năm từ ngay_ct2
                $ngayDauNam = date('Y-01-01', strtotime($dataRow['ngay_ct2']));
                
                $params = [
                    'company_id' => $request->input('company_id'),
                    'tk' => '',  // tk_no rỗng
                    'tk_du' => $dataRow['tk_du'],
                    'ngay_ct1' => $ngayDauNam,
                    'ngay_ct2' => $dataRow['ngay_ct2'],
                    'ma_nt' => ''
                ];
                
                return redirect()->route('sochitiet', $params);
            }
        }
        
        return response()->json(['cancel' => true]);
    }
}
```

## Ghi chú
- Drill-down từ BCTC02 để xem chi tiết TK đối ứng
- Tính ngày đầu năm từ ngày báo cáo: `new DateTime(dateTime.Year, 1, 1)`
- Chỉ hỗ trợ F7 thường, không hỗ trợ Ctrl+F7 hay Shift+F7
- tk_no luôn rỗng khi drilldown
- Filter hiển thị: tk_du (tài khoản đối ứng)
- Xem chi tiết phát sinh của tài khoản đối ứng từ đầu năm đến ngày báo cáo
- Kế thừa từ frmDrilldownReport, sử dụng __ENCList cho list weak reference (VB compatibility)
