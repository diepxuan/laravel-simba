# ARRptBK02

## Tổng quan
- **Module**: AR (Accounts Receivable)
- **Loại**: Report
- **Chức năng**: Báo cáo bảng kê công nợ theo hạn kỳ

## Forms

### frmARRptBK02.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng kê công nợ phân loại theo hạn kỳ thanh toán

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMa_Kh | AsTextBox | MA_KH | Lookup, AutoComplete |
| txtMa_NhKh | AsTextBox | MA_NHKH | Lookup, AutoComplete |
| txtNgay_Ss | AsMaskedTextBox | Ngày so sánh | - |
| txtHan_ky1 | AsTextNumeric | Hạn kỳ 1 | Validated |
| txtHan_ky2 | AsTextNumeric | Hạn kỳ 2 | - |
| txtHan_ky3 | AsTextNumeric | Hạn kỳ 3 | - |
| txtMaTT | AsTextBox | MA_TT | Lookup, AutoComplete |
| lblTen_Kh | Label | Hiển thị tên KH | - |
| lblTen_NhKh | Label | Hiển thị tên nhóm KH | - |
| lblTen_dktt | Label | Hiển thị tên ĐKTT | - |
| cboChi_xem | ComboBox | Chỉ xem | - |
| ChkSap_xep | AsCheckBox | Sắp xếp | - |
| lblSap_xep | Label | Label sắp xếp | - |
| lblChi_xem | Label | Label chỉ xem | - |
| cboMau_bc | ComboBox | Mẫu báo cáo | - |
| optVND | RadioButton | Loại tiền VND | - |
| optNt | RadioButton | Loại tiền ngoại tệ | - |
| txtMa_Nt | AsTextBox | Mã ngoại tệ | Lookup |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| MenuId | string | ID menu báo cáo |

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
| asARRptBK02 | Lấy dữ liệu báo cáo | @pMa_cty, @pNgay_Ss, @pHan_ky1, @pHan_ky2, @pHan_ky3, @pMa_kh, @pMa_nhkh, @pMa_nt, @pMa_tt, @pChi_xem, @pSap_xep | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng nhập ngày so sánh (mặc định là ngày hiện tại)
2. Nhập các kỳ hạn thanh toán (hạn kỳ 1, 2, 3) - lấy từ cấu hình hệ thống
3. Có thể lọc theo khách hàng, nhóm khách hàng, điều khoản thanh toán
4. Chọn tùy chọn chỉ xem và sắp xếp
5. Gọi SP asARRptBK02 để lấy dữ liệu
6. Hiển thị báo cáo phân loại công nợ theo các kỳ hạn

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
- Sắp xếp dữ liệu nếu được chọn

### Xử lý đặc biệt
- Lấy giá trị hạn kỳ mặc định từ cấu hình hệ thống
- Tùy chọn chỉ xem cho phép lọc dữ liệu hiển thị
- Tùy chọn sắp xếp để sắp xếp dữ liệu theo tiêu chí

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
class ARRptBK02Controller extends ReportController {
    public function index(Request $request) {
        $config = $this->getSOConfiguration();
        return view('ar.reports.bk02', [
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
            'ma_tt' => $request->payment_term,
            'chi_xem' => $request->view_option,
            'sap_xep' => $request->sort_option
        ];
        return $this->service->getReportData($params);
    }
}
```

### Repository
```php
class ARRptBK02Repository {
    public function getReportData($params) {
        return DB::select('EXEC asARRptBK02 ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay_ss'],
            $params['han_ky1'],
            $params['han_ky2'],
            $params['han_ky3'],
            $params['ma_kh'],
            $params['ma_nhkh'],
            $params['ma_nt'],
            $params['ma_tt'],
            $params['chi_xem'],
            $params['sap_xep']
        ]);
    }
}
```

## Ghi chú
- Báo cáo bảng kê công nợ theo độ tuổi (aging report)
- Tương tự ARRptBCCN06 nhưng dạng bảng kê
- Hỗ trợ tùy chọn chỉ xem và sắp xếp
- Thường dùng để theo dõi công nợ và quản lý thu nợ
