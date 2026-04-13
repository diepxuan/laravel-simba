# GlRptF5Bctc03.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Drill-down báo cáo tài chính BCTC03 (Báo cáo kết quả hoạt động kinh doanh)
- **Framework**: .NET Framework 3.5
- **Base Class**: frmDrilldownReport
- **AllowUnsafeBlocks**: True

## Forms

### frmGlRptF5Bctc03.cs
- **Kế thừa**: frmDrilldownReport
- **Chức năng**: Form báo cáo drilldown cho BCTC03 - Báo cáo kết quả hoạt động kinh doanh

#### Constructors
| Constructor | Tham số | Mục đích |
|-------------|---------|----------|
| `frmGlRptF5Bctc03(...)` | ReportInformation, drilldownMenuId, AsDictionary, isNT, nhan_in, filter4Tilte, formatedColList, datasource, arg | Khởi tạo form drilldown với thông tin báo cáo mẹ |

#### Controls
| Control | Loại | Mục đích |
|---------|------|----------|
| `epNotice` | ErrorProvider | Hiển thị thông báo lỗi |
| `AsTabControl` | TabControl | Tab container |
| `dgvBC` | DataGridView | Grid hiển thị dữ liệu báo cáo |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |
| CreateDrilldownArgument | ReportDrillDownInfo, Keys, Keys | ArrayList | Tạo tham số drill-down |
| frmGlRptF5Bctc03_KeyDown | sender, KeyEventArgs | void | Xử lý phím tắt (F5) |

## Data Access

### GlRptF5Bctc03Controller
- **Interface**: IReportController
- **Implementation**: MssqlReportController

## Business Logic

### Drill-down logic (F5)

1. **Kiểm tra phím**: Chỉ xử lý khi nhấn F5 (KeyCode = 116)
2. **Lấy dòng hiện tại**: Từ DataGridView `dgvBC`
3. **Kiểm tra điều kiện drilldown**:
   - Nếu `cach_tinh`, `tk_no`, `tk_co` đều rỗng → Cancel drilldown

4. **Drilldown theo cách tính** (ưu tiên):
   - Nếu `cach_tinh` không rỗng
   - Drilldown vào menu `drilldown_menuid`
   - Filter theo các mã số trong `cach_tinh` (phân tách bởi `+` hoặc `-`)
   - Hiển thị chi tiết công thức tính

5. **Drilldown theo tài khoản**:
   - Nếu `tk_no` hoặc `tk_co` không rỗng
   - Drilldown vào menu `drilldown_menuid1`
   - Truyền tham số: CompanyID, tk_no, tk_co, null, ngay_ct1, ngay_ct2

### Các trường dữ liệu quan trọng
| Trường | Ý nghĩa |
|--------|---------|
| `cach_tinh` | Cách tính/Chỉ tiêu (công thức tính toán) |
| `tk_no` | Tài khoản nợ |
| `tk_co` | Tài khoản có |
| `ma_so` | Mã số chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu |
| `ngay_ct1` | Ngày bắt đầu |
| `ngay_ct2` | Ngày kết thúc |

## Mapping sang PHP

### Controller
```php
class F5BCTC03Controller extends Controller {
    public function drilldown(Request $request) {
        $keycode = $request->input('keycode');
        $dataRow = $request->input('dataRow');
        
        if ($keycode != 116) {
            return response()->json(['cancel' => true]);
        }
        
        if (empty($dataRow['cach_tinh']) && empty($dataRow['tk_no']) && empty($dataRow['tk_co'])) {
            return response()->json(['cancel' => true]);
        }
        
        if (!empty($dataRow['cach_tinh'])) {
            // Drill-down công thức
            // Lọc các ma_so trong cach_tinh
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
        
        return response()->json(['cancel' => true]);
    }
}
```

## Ghi chú
- Drill-down từ BCTC03 (báo cáo kết quả kinh doanh)
- Xử lý cả TK_NO và TK_CO (cặp tài khoản nợ/có)
- Hỗ trợ drilldown theo công thức tính (cach_tinh)
- Kích thước form: 792 x 512 pixels
- Font mặc định: 6f x 13f (AutoScaleDimensions)
- Key handling: Phím F5 để drilldown
- Data binding: Sử dụng DataView từ DataGridView
