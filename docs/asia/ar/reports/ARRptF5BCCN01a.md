# ArRptF5BCCN01a

## Tổng quan
- **Module**: AR (Accounts Receivable)
- **Loại**: Report (Drill-down)
- **Chức năng**: Báo cáo chi tiết công nợ khách hàng (drill-down từ ARRptBCCN01a)

## Forms

### frmArRptF5BCCN01a.cs
- **Kế thừa**: frmDrilldownReport
- **Chức năng**: Form báo cáo chi tiết công nợ khi drill-down từ báo cáo tổng hợp

#### Controls
Không có controls đặc biệt, kế thừa từ frmDrilldownReport.

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| motherReportInfo | ReportInformation | Thông tin báo cáo mẹ |
| drilldownMenuId | string | ID menu drill-down |
| formularFields | AsDictionary | Các trường công thức |
| isNT | bool | Có phải ngoại tệ |
| nhan_in | string | Nhãn in |
| filter4Tilte | string | Filter cho tiêu đề |
| formatedColList | string | Danh sách cột đã format |
| datasource | object | Nguồn dữ liệu |
| arg | object[] | Tham số truyền vào |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |
| CreateDrilldownArgument | drilldownInfo, sDrilldownMenuId, keycode, modifierKeys, filterCondition4title, datasource | ArrayList | Tạo tham số drill-down (trả về null - không drill-down thêm) |

## Data Access

Không có DAO riêng, sử dụng controller từ base class frmDrilldownReport.

## Stored Procedures được gọi

Không gọi SP trực tiếp, dữ liệu được truyền từ báo cáo mẹ (ARRptBCCN01a).

## Business Logic

### Luồng xử lý chính
1. Được gọi khi người dùng nhấn F5 từ ARRptBCCN01a
2. Nhận tham số từ báo cáo mẹ (mã khách hàng, tài khoản, ngày...)
3. Hiển thị chi tiết công nợ của khách hàng đã chọn
4. Không hỗ trợ drill-down thêm (CreateDrilldownArgument trả về null)

### Validation rules
Không có validation đặc biệt.

### Calculation logic
- Hiển thị chi tiết các phát sinh công nợ của khách hàng
- Tính toán số dư đầu kỳ, phát sinh, số dư cuối kỳ chi tiết

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| ARDCTT | Chi tiết công nợ | R |
| ARTT | Tổng hợp công nợ | R |
| DMKH | Danh mục khách hàng | R |

## Mapping sang PHP

### Controller
```php
class ArRptF5BCCN01aController extends DrilldownReportController {
    public function index(Request $request) {
        // Nhận tham số từ báo cáo mẹ
        $params = [
            'ma_cty' => $request->company_id,
            'tk' => $request->account,
            'ma_kh' => $request->customer_id,
            'ngay1' => $request->date_from,
            'ngay2' => $request->date_to,
            'ma_nt' => $request->currency
        ];
        
        $data = $this->service->getDetailData($params);
        return view('ar.reports.f5bccn01a', [
            'data' => $data,
            'filter_title' => $request->filter_title
        ]);
    }
}
```

### Repository
```php
class ArRptF5BCCN01aRepository {
    public function getDetailData($params) {
        // Lấy chi tiết công nợ từ ARDCTT
        return DB::table('ARDCTT')
            ->where('ma_cty', $params['ma_cty'])
            ->where('tk', $params['tk'])
            ->where('ma_kh', $params['ma_kh'])
            ->whereBetween('ngay_ct', [$params['ngay1'], $params['ngay2']])
            ->when($params['ma_nt'], function($query, $ma_nt) {
                return $query->where('ma_nt', $ma_nt);
            })
            ->orderBy('ngay_ct')
            ->orderBy('so_ct')
            ->get();
    }
}
```

## Ghi chú
- Đây là báo cáo drill-down, không độc lập
- Chỉ được gọi từ ARRptBCCN01a khi người dùng nhấn F5
- Hiển thị chi tiết công nợ của một khách hàng cụ thể
- Không hỗ trợ drill-down thêm
