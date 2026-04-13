# ARRptBCCN02

## Tổng quan
- **Module**: AR (Accounts Receivable)
- **Loại**: Report
- **Chức năng**: Báo cáo bảng cân đối công nợ khách hàng theo phân loại (3 cấp)

## Forms

### frmARRptBCCN02.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo công nợ khách hàng theo phân loại với khả năng sắp xếp thứ tự

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMa_Tk | AsTextBox | TK (tk_cn=1) | Lookup, AutoComplete |
| txtMa_Kh | AsTextBox | MA_KH (isKh=1) | Lookup, AutoComplete |
| txtMa_plkh1 | AsTextBox | MA_PLKH (loai=1) | Lookup, AutoComplete |
| txtMa_plkh2 | AsTextBox | MA_PLKH (loai=2) | Lookup, AutoComplete |
| txtMa_plkh3 | AsTextBox | MA_PLKH (loai=3) | Lookup, AutoComplete |
| txtOrder1 | AsTextNumeric | Thứ tự phân loại 1 | - |
| txtOrder2 | AsTextNumeric | Thứ tự phân loại 2 | - |
| txtOrder3 | AsTextNumeric | Thứ tự phân loại 3 | - |
| lblTen_Tk | Label | Hiển thị tên TK | - |
| lblTen_Kh | Label | Hiển thị tên KH | - |
| lblTen_plkh1 | Label | Hiển thị tên PLKH1 | - |
| lblTen_plkh2 | Label | Hiển thị tên PLKH2 | - |
| lblTen_plkh3 | Label | Hiển thị tên PLKH3 | - |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu | - |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc | - |
| cboKyBc | ComboBox | Kỳ báo cáo | - |
| cboMau_bc | ComboBox | Mẫu báo cáo | - |
| optVND | RadioButton | Loại tiền VND | - |
| optNt | RadioButton | Loại tiền ngoại tệ | - |
| txtMa_Nt | AsTextBox | Mã ngoại tệ | Lookup |
| crvReportViewer | CrystalReportViewer | Viewer báo cáo | - |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| MenuId | string | ID menu báo cáo |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| ValidData | - | bool | Validate dữ liệu đầu vào |
| GetFilterTitle | - | string | Lấy tiêu đề filter |
| CreateDrilldownArgument | drilldownInfo, sDrilldownMenuId, keycode, modifierKeys, filterCondition4title, datasource | ArrayList | Tạo tham số drill-down |

## Data Access

Không có DAO riêng, sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| asARRptBCCN02 | Lấy dữ liệu báo cáo | @pMa_cty, @pNgay1, @pNgay2, @pTk, @pMa_kh, @pMa_plkh1, @pMa_plkh2, @pMa_plkh3, @pMa_nt, @pOrder1, @pOrder2, @pOrder3 | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng nhập tài khoản công nợ (bắt buộc)
2. Có thể lọc theo khách hàng và 3 cấp phân loại khách hàng
3. Cấu hình thứ tự sắp xếp theo phân loại (1-3)
4. Gọi SP asARRptBCCN02 để lấy dữ liệu
5. Hiển thị báo cáo với khả năng drill-down (F5)

### Validation rules
- Tài khoản (txtMa_Tk) bắt buộc phải nhập
- Thứ tự phân loại (txtOrder1, txtOrder2, txtOrder3) phải từ 0-3
- Các thứ tự phân loại không được trùng nhau (nếu khác 0)

### Calculation logic
- Sắp xếp dữ liệu theo thứ tự phân loại đã chọn
- Tính toán số dư đầu kỳ, phát sinh, số dư cuối kỳ theo nhóm phân loại
- Hỗ trợ drill-down xuống chi tiết từng khách hàng (F5)

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| ARDCTT | Chi tiết công nợ | R |
| ARTT | Tổng hợp công nợ | R |
| DMTK | Danh mục tài khoản | R |
| DMKH | Danh mục khách hàng | R |
| DMPLKH | Danh mục phân loại khách hàng | R |

## Mapping sang PHP

### Controller
```php
class ARRptBCCN02Controller extends ReportController {
    public function index(Request $request) {
        // Hiển thị form filter
    }
    
    public function getData(Request $request) {
        $params = [
            'ma_cty' => $request->company_id,
            'ngay1' => $request->date_from,
            'ngay2' => $request->date_to,
            'tk' => $request->account,
            'ma_kh' => $request->customer_id,
            'ma_plkh1' => $request->plkh1,
            'ma_plkh2' => $request->plkh2,
            'ma_plkh3' => $request->plkh3,
            'ma_nt' => $request->currency,
            'order1' => $request->order1,
            'order2' => $request->order2,
            'order3' => $request->order3
        ];
        return $this->service->getReportData($params);
    }
}
```

### Repository
```php
class ARRptBCCN02Repository {
    public function getReportData($params) {
        return DB::select('EXEC asARRptBCCN02 ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['tk'],
            $params['ma_kh'],
            $params['ma_plkh1'],
            $params['ma_plkh2'],
            $params['ma_plkh3'],
            $params['ma_nt'],
            $params['order1'],
            $params['order2'],
            $params['order3']
        ]);
    }
}
```

### Validation
```php
class ARRptBCCN02Request extends FormRequest {
    public function rules() {
        return [
            'account' => 'required',
            'order1' => 'integer|between:0,3',
            'order2' => 'integer|between:0,3',
            'order3' => 'integer|between:0,3',
        ];
    }
    
    public function withValidator($validator) {
        $validator->after(function ($validator) {
            $orders = [$this->order1, $this->order2, $this->order3];
            $nonZeroOrders = array_filter($orders);
            if (count($nonZeroOrders) != count(array_unique($nonZeroOrders))) {
                $validator->errors()->add('order', 'Thứ tự phân loại không được trùng nhau');
            }
        });
    }
}
```

## Ghi chú
- Báo cáo này hỗ trợ phân loại khách hàng 3 cấp
- Có thể tùy chỉnh thứ tự sắp xếp theo các cấp phân loại
- Hỗ trợ drill-down (F5) xuống chi tiết công nợ từng khách hàng
- Thường dùng để phân tích công nợ theo nhóm khách hàng
