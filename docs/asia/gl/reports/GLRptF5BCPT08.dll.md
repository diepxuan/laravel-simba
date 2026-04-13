# GLRptF5BCPT08.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Drill-down báo cáo F5 BCPT08 (Bảng kê phân tích 08)
- **Framework**: .NET Framework 3.5
- **Base Class**: frmDrilldownReport

## Forms

### frmGLRptF5BCPT08.cs
- **Kế thừa**: frmDrilldownReport
- **Chức năng**: Form drill-down từ báo cáo BCPT08

#### Constructors
| Constructor | Tham số | Mục đích |
|-------------|---------|----------|
| `frmGLRptF5BCPT08()` | Không tham số | Khởi tạo form mặc định |
| `frmGLRptF5BCPT08(...)` | motherReportInfo, drilldownMenuId, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, datasource, arg | Khởi tạo form drilldown với tham số từ báo cáo mẹ |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitOtherComponents | - | void | Khởi tạo các thành phần khác, select vào dgvBC |
| CreateDrilldownArgument | ReportDrillDownInfo, Keys, Keys | ArrayList | Tạo tham số drill-down với 3 chế độ modifier keys |

## Data Access

### GLRptF5BCPT08Controller
- **Interface**: IReportController
- **Implementation**: MssqlReportController

## Business Logic

### Drill-down logic (F7)

#### Modifier Keys = 0 (F7 thường)
| Điều kiện | Hành động |
|-----------|-----------|
| `cach_tinh` rỗng VÀ `tk` rỗng | Hủy drilldown |
| `cach_tinh` KHÔNG rỗng | Drilldown theo công thức tính:<br>- sDrilldownMenuId = drilldown_menuid<br>- Lọc các ma_so trong cach_tinh (replace +,- bằng ',')<br>- Filter: "ma_so = cach_tinh" |
| `tk` KHÔNG rỗng | Drilldown theo tài khoản:<br>- sDrilldownMenuId = drilldown_menuid1<br>- Tham số: CompanyID, tk, ngay_ct1, ngay_ct2, ma_nt<br>- Filter: tk |

#### Modifier Keys = Ctrl (131072)
| Điều kiện | Hành động |
|-----------|-----------|
| `tk` rỗng | Hủy drilldown |
| `tk` KHÔNG rỗng | Drilldown theo tk/tk_du:<br>- Tham số: CompanyID, tk, tk_du, ngay_ct1, ngay_ct2, ma_nt<br>- Filter: "tk/tk_du" |

#### Modifier Keys = Shift (65536)
| Điều kiện | Hành động |
|-----------|-----------|
| `tk` rỗng HOẶC `cong_no` != "1" | Hủy drilldown |
| `tk` KHÔNG rỗng VÀ `cong_no` = "1" | Drilldown công nợ:<br>- Tham số: CompanyID, tk, ngay_ct1, ngay_ct2<br>- Filter: tk |

### Các trường dữ liệu quan trọng
| Trường | Ý nghĩa |
|--------|---------|
| `cach_tinh` | Công thức tính (chứa các ma_so cách nhau bởi +,-) |
| `tk` | Tài khoản |
| `tk_du` | Tài khoản đối ứng |
| `ma_so` | Mã số |
| `cong_no` | Cờ công nợ (1 = có công nợ) |
| `ngay_ct1`, `ngay_ct2` | Khoảng ngày chứng từ |
| `ma_nt` | Mã ngoại tệ |

## Mapping sang PHP

### Controller
```php
class F5BCPT08Controller extends Controller {
    public function drilldown(Request $request) {
        $keycode = $request->input('keycode');
        $modifierKeys = $request->input('modifierKeys');
        $dataRow = $request->input('dataRow');
        
        if ($keycode == 116) { // F7
            if ($modifierKeys == 0) {
                // F7 thường - Drill-down công thức hoặc sổ chi tiết
                if (!empty($dataRow['cach_tinh'])) {
                    $maSoList = str_replace(['+', '-'], ',', $dataRow['cach_tinh']);
                    return $this->drilldownCongThuc($dataRow, $maSoList);
                } elseif (!empty($dataRow['tk'])) {
                    $params = [
                        'company_id' => $request->input('company_id'),
                        'tk' => $dataRow['tk'],
                        'ngay_ct1' => $dataRow['ngay_ct1'],
                        'ngay_ct2' => $dataRow['ngay_ct2'],
                        'ma_nt' => $dataRow['ma_nt'] ?? ''
                    ];
                    return redirect()->route('sochitiet', $params);
                }
            } elseif ($modifierKeys == 131072) { // Ctrl+F7
                // Drill-down sổ chi tiết TK/TK_DU
                if (!empty($dataRow['tk'])) {
                    $params = [
                        'company_id' => $request->input('company_id'),
                        'tk' => $dataRow['tk'],
                        'tk_du' => $dataRow['tk_du'],
                        'ngay_ct1' => $dataRow['ngay_ct1'],
                        'ngay_ct2' => $dataRow['ngay_ct2'],
                        'ma_nt' => $dataRow['ma_nt'] ?? ''
                    ];
                    return redirect()->route('sochitiet.tk_du', $params);
                }
            } elseif ($modifierKeys == 65536) { // Shift+F7
                // Drill-down cân đối PS công nợ
                if (!empty($dataRow['tk']) && $dataRow['cong_no'] == '1') {
                    $params = [
                        'company_id' => $request->input('company_id'),
                        'tk' => $dataRow['tk'],
                        'ngay_ct1' => $dataRow['ngay_ct1'],
                        'ngay_ct2' => $dataRow['ngay_ct2']
                    ];
                    return redirect()->route('candoi.congno', $params);
                }
            }
        }
        
        return response()->json(['cancel' => true]);
    }
}
```

## Ghi chú
- Hỗ trợ 3 chế độ drill-down: F7 (thường), Ctrl+F7, Shift+F7
- Drill-down theo công thức tính: lọc các ma_so trong cach_tinh
- Drill-down theo tài khoản: xem sổ chi tiết TK hoặc TK/TK_DU
- Drill-down công nợ: chỉ khi cong_no = "1"
- Đây là form drill-down, không có form filter riêng
- Nhận dữ liệu từ báo cáo mẹ thông qua constructor
- Kế thừa từ frmDrilldownReport, sử dụng dgvBC từ form mẹ
- Hỗ trợ 3 loại drilldown menuid: drilldown_menuid, drilldown_menuid1
