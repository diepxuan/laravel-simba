# GLRptF5BCTC03CT.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Drill-down báo cáo tài chính BCTC03 chi tiết (Báo cáo kết quả hoạt động kinh doanh chi tiết)
- **Framework**: .NET Framework 3.5
- **Base Class**: frmDrilldownReport

## Forms

### frmGLRptF5BCTC03CT.cs
- **Kế thừa**: frmDrilldownReport
- **Chức năng**: Form drill-down chi tiết từ BCTC03

#### Constructors
| Constructor | Tham số | Mục đích |
|-------------|---------|----------|
| `frmGLRptF5BCTC03CT()` | Không tham số | Khởi tạo form mặc định |
| `frmGLRptF5BCTC03CT(...)` | motherReportInfo, drilldownMenuId, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, datasource, arg | Khởi tạo form drilldown với tham số từ báo cáo mẹ |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitOtherComponents | - | void | Khởi tạo các thành phần khác, select vào dgvBC |
| CreateDrilldownArgument | ReportDrillDownInfo, Keys, Keys | ArrayList | Tạo tham số drill-down với 2 chế độ: cach_tinh, tk_no/tk_co |

## Data Access

### GLRptF5BCTC03CTController
- **Interface**: IReportController
- **Implementation**: MssqlReportController

## Business Logic

### Drill-down logic (F7)

#### Modifier Keys = 0 (F7 thường)
| Điều kiện | Hành động |
|-----------|-----------|
| `cach_tinh`, `tk_no`, `tk_co` đều rỗng | Hủy drilldown |
| `cach_tinh` KHÔNG rỗng | Drilldown theo công thức tính:<br>- sDrilldownMenuId = drilldown_menuid<br>- Lọc các ma_so trong cach_tinh (replace +,- bằng ',')<br>- Filter: "ma_so = cach_tinh" |
| `tk_no` HOẶC `tk_co` KHÔNG rỗng | Drilldown theo tk_no/tk_co:<br>- sDrilldownMenuId = drilldown_menuid1<br>- Tham số: CompanyID, tk_no, tk_co, null, ngay_ct1, ngay_ct2<br>- Filter: chi_tieu (tên chỉ tiêu) |

#### Modifier Keys khác (Ctrl, Shift, Alt)
| Điều kiện | Hành động |
|-----------|-----------|
| Bất kỳ | Hủy drilldown |

### Xử lý ngoại lệ
```csharp
try
{
    dataRowView = new DataView((DataTable)((DataGridView)base.dgvBC).DataSource)[...]
}
catch (Exception ex)
{
    base.CancelDrilldown = true;
    result = null;
    ProjectData.ClearProjectError();
}
```
- Try-catch khi lấy DataRowView từ DataSource
- Nếu có lỗi: hủy drilldown, clear error

### Các trường dữ liệu quan trọng
| Trường | Ý nghĩa |
|--------|---------|
| `cach_tinh` | Công thức tính (chứa các ma_so cách nhau bởi +,-) |
| `tk_no` | Tài khoản nợ |
| `tk_co` | Tài khoản có |
| `chi_tieu` | Tên chỉ tiêu báo cáo |
| `ma_so` | Mã số |
| `ngay_ct1`, `ngay_ct2` | Khoảng ngày chứng từ |

## Mapping sang PHP

### Controller
```php
class F5BCTC03CTController extends Controller {
    public function drilldown(Request $request) {
        $keycode = $request->input('keycode');
        $modifierKeys = $request->input('modifierKeys');
        
        if ($keycode != 116 || $modifierKeys != 0) {
            return response()->json(['cancel' => true]);
        }
        
        $dataRow = $request->input('dataRow');
        
        try {
            if (!empty($dataRow['cach_tinh'])) {
                // Drill-down công thức
                $maSoList = str_replace(['+', '-'], ',', $dataRow['cach_tinh']);
                return $this->drilldownCongThuc($dataRow, $maSoList);
            } elseif (!empty($dataRow['tk_no']) || !empty($dataRow['tk_co'])) {
                // Drill-down sổ chi tiết theo cặp TK nợ/TK có
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
        } catch (Exception $e) {
            return response()->json(['cancel' => true]);
        }
        
        return response()->json(['cancel' => true]);
    }
}
```

## Ghi chú
- Drill-down từ BCTC03 (báo cáo kết quả hoạt động kinh doanh)
- Xử lý cả TK_NO và TK_CO (cặp tài khoản nợ/có)
- Chỉ hỗ trợ F7 thường, không hỗ trợ Ctrl+F7 hay Shift+F7
- Có try-catch khi lấy DataRowView để tránh crash
- Filter khi drilldown theo cach_tinh: "ma_so = cach_tinh"
- Filter khi drilldown theo tk_no/tk_co: tên chỉ tiêu (chi_tieu)
- tk_no và tk_co dùng để lọc theo bút toán (nợ/có)
