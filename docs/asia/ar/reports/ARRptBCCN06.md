# ARRptBCCN06

## Tổng quan
- **Module**: AR (Accounts Receivable)
- **Loại**: Report
- **Chức năng**: Báo cáo so sánh công nợ khách hàng theo hạn kỳ

## Forms

### frmARRptBCCN06.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo so sánh công nợ theo các kỳ hạn thanh toán

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtNgay_Ss | AsMaskedTextBox | Ngày so sánh | - |
| txtHan_ky1 | AsTextNumeric | Hạn kỳ 1 | Validated |
| txtHan_ky2 | AsTextNumeric | Hạn kỳ 2 | - |
| txtHan_ky3 | AsTextNumeric | Hạn kỳ 3 | - |
| txtMa_Kh | AsTextBox | MA_KH (isKh=1) | Lookup, AutoComplete |
| txtMa_NhKh | AsTextBox | MA_NHKH | Lookup, AutoComplete |
| txtMaTT | AsTextBox | MA_TT (điều khoản TT) | Lookup, AutoComplete |
| lblTen_Kh | Label | Hiển thị tên KH | - |
| lblTen_NhKh | Label | Hiển thị tên nhóm KH | - |
| lblTen_dktt | Label | Hiển thị tên ĐKTT | - |
| cboMau_bc | ComboBox | Mẫu báo cáo | - |
| optVND | RadioButton | Loại tiền VND | - |
| optNt | RadioButton | Loại tiền ngoại tệ | - |
| txtMa_Nt | AsTextBox | Mã ngoại tệ | Lookup |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| MenuId | string | ID menu bááo cáo |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| GetFilterTitle | - | string | Lấy tiêu đề filter |
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |
| txtHan_ky1_Validated | sender, e | void | Validate hạn kỳ 1 |
| lblHan_ky2_Validated | sender, e | void | Validate hạn kỳ 2 |
| lblHan_ky3_Validated | sender, e | void | Validate hạn kỳ 3 |

## Data Access

Không có DAO riêng, sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| asARRptBCCN06 | Lấy dữ liệu báo cáo | @pMa_cty, @pNgay_Ss, @pHan_ky1, @pHan_ky2, @pHan_ky3, @pMa_kh, @pMa_nhkh, @pMa_nt, @pMa_tt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng nhập ngày so sánh (mặc định là ngày hiện tại)
2. Nhập các kỳ hạn thanh toán (hạn kỳ 1, 2, 3) - lấy từ cấu hình hệ thống
3. Có thể lọc theo khách hàng, nhóm khách hàng, điều khoản thanh toán
4. Gọi SP asARRptBCCN06 để lấy dữ liệu
5. Hiển thị báo cáo phân loại công nợ theo các kỳ hạn

### Validation rules
- Hạn kỳ phải >= 0
- Ngày so sánh phải hợp lệ

### Calculation logic
- Phân loại công nợ theo các kỳ hạn:
  - Kỳ 1: Công nợ <= hạn kỳ 1
  - Kỳ 2: Công nợ từ hạn kỳ 1 đến hạn kỳ 2
  - Kỳ 3: Công nợ từ hạn kỳ 2 đến hạn kỳ 3
  - Quá hạn: Công nợ > hạn kỳ 3
- Tính tổng công nợ theo từng kỳ
- So sánh với ngày so sánh đã chọn

### Xử lý đặc biệt
- Lấy giá trị hạn kỳ mặc định từ cấu hình hệ thống (GetSOConfiguration)
- Có thể tùy chỉnh các kỳ hạn theo nhu cầu

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| ARDCTT | Chi tiết công nợ | R |
| ARTT | Tổng hợp công nợ | R |
| DMKH | Danh mục khách hàng | R |
| DMNHKH | Danh mục nhóm khách hàng | R |
| DMTT | Danh mục điều khoản thanh toán | R |

## Mapping sang PHP

### Controller
```php
class ARRptBCCN06Controller extends ReportController {
    public function index(Request $request) {
        // Lấy cấu hình hạn kỳ mặc định
        $config = $this->getSOConfiguration();
        return view('ar.reports.bccn06', [
            'default_han_ky1' => $config->han_tt_ss1,
            'default_han_ky2' => $config->han_tt_ss2,
            'default_han_ky3' => $config->han_tt_ss3
        ]);
    }
    
    public function getData(Request $request) {
        $params = [
            'ma_cty' => $request->company_id,
            'ngay_ss' => $request->compare_date,
            'han_ky1' => $request->term1,
            'han_ky2' => $request->term2,
            'han_ky3' => $request->term3,
            'ma_kh' => $request->customer_id,
            'ma_nhkh' => $request->customer_group,
            'ma_nt' => $request->currency,
            'ma_tt' => $request->payment_term
        ];
        return $this->service->getReportData($params);
    }
}
```

### Repository
```php
class ARRptBCCN06Repository {
    public function getReportData($params) {
        return DB::select('EXEC asARRptBCCN06 ?, ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay_ss'],
            $params['han_ky1'],
            $params['han_ky2'],
            $params['han_ky3'],
            $params['ma_kh'],
            $params['ma_nhkh'],
            $params['ma_nt'],
            $params['ma_tt']
        ]);
    }
}
```

### Validation
```php
class ARRptBCCN06Request extends FormRequest {
    public function rules() {
        return [
            'compare_date' => 'required|date',
            'term1' => 'required|numeric|min:0',
            'term2' => 'required|numeric|min:0',
            'term3' => 'required|numeric|min:0',
        ];
    }
}
```

## Ghi chú
- Báo cáo phân tích công nợ theo độ tuổi (aging report)
- Hỗ trợ 3 kỳ hạn thanh toán tùy chỉnh
- Có thể lọc theo điều khoản thanh toán
- Thường dùng để đánh giá chất lượng công nợ và theo dõi công nợ quá hạn
