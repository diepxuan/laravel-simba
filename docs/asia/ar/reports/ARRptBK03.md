# ARRptBK03

## Tổng quan
- **Module**: AR (Accounts Receivable)
- **Loại**: Report
- **Chức năng**: Báo cáo bảng kê chứng từ thanh toán

## Forms

### frmARRptBK03.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng kê các chứng từ thanh toán

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMa_Kh | AsTextBox | MA_KH | Lookup, AutoComplete |
| txtMa_NhKh | AsTextBox | MA_NHKH | Lookup, AutoComplete |
| txtMa_plkh1 | AsTextBox | MA_PLKH (loai=1) | Lookup, AutoComplete |
| txtMa_plkh2 | AsTextBox | MA_PLKH (loai=2) | Lookup, AutoComplete |
| txtMa_plkh3 | AsTextBox | MA_PLKH (loai=3) | Lookup, AutoComplete |
| txtSo_Ct1 | TextBox | Số chứng từ từ | - |
| txtSo_Ct2 | TextBox | Số chứng từ đến | - |
| cboChi_xem | ComboBox | Chỉ xem | - |
| ChkSap_xep | AsCheckBox | Sắp xếp | - |
| cboGiao_dich | ComboBox | Giao dịch | - |
| lblTen_Kh | Label | Hiển thị tên KH | - |
| lblTen_NhKh | Label | Hiển thị tên nhóm KH | - |
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

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| MenuId | string | ID menu báo cáo |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| GetFilterTitle | - | string | Lấy tiêu đề filter |

## Data Access

Không có DAO riêng, sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| asARRptBK03 | Lấy dữ liệu báo cáo | @pMa_cty, @pNgay1, @pNgay2, @pMa_kh, @pMa_nhkh, @pMa_plkh1, @pMa_plkh2, @pMa_plkh3, @pSo_Ct1, @pSo_Ct2, @pChi_xem, @pSap_xep, @pGiao_dich, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (ngày)
2. Có thể lọc theo khách hàng, nhóm khách hàng, phân loại khách hàng
3. Có thể lọc theo số chứng từ (từ số - đến số)
4. Chọn loại giao dịch (thu/chi/both)
5. Chọn tùy chọn chỉ xem và sắp xếp
6. Gọi SP asARRptBK03 để lấy dữ liệu
7. Hiển thị báo cáo bảng kê chứng từ thanh toán

### Validation rules
- Ngày bắt đầu <= Ngày kết thúc
- Số chứng từ từ <= Số chứng từ đến (nếu cả hai đều nhập)

### Calculation logic
- Tổng hợp các chứng từ thanh toán theo các tiêu chí đã chọn
- Tính tổng tiền thu, tiền chi
- Phân biệt VND và ngoại tệ
- Sắp xếp dữ liệu nếu được chọn

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| ARCT | Chi tiết chứng từ | R |
| ARDCTT | Chi tiết công nợ | R |
| DMKH | Danh mục khách hàng | R |
| DMNHKH | Danh mục nhóm khách hàng | R |
| DMPLKH | Danh mục phân loại khách hàng | R |

## Mapping sang PHP

### Controller
```php
class ARRptBK03Controller extends ReportController {
    public function index(Request $request) {
        return view('ar.reports.bk03');
    }
    
    public function getData(Request $request) {
        $params = [
            'ma_cty' => $request->company_id,
            'ngay1' => $request->date_from,
            'ngay2' => $request->date_to,
            'ma_kh' => $request->customer_id,
            'ma_nhkh' => $request->customer_group,
            'ma_plkh1' => $request->plkh1,
            'ma_plkh2' => $request->plkh2,
            'ma_plkh3' => $request->plkh3,
            'so_ct1' => $request->doc_no_from,
            'so_ct2' => $request->doc_no_to,
            'chi_xem' => $request->view_option,
            'sap_xep' => $request->sort_option,
            'giao_dich' => $request->transaction_type,
            'ma_nt' => $request->currency
        ];
        return $this->service->getReportData($params);
    }
}
```

### Repository
```php
class ARRptBK03Repository {
    public function getReportData($params) {
        return DB::select('EXEC asARRptBK03 ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['ma_kh'],
            $params['ma_nhkh'],
            $params['ma_plkh1'],
            $params['ma_plkh2'],
            $params['ma_plkh3'],
            $params['so_ct1'],
            $params['so_ct2'],
            $params['chi_xem'],
            $params['sap_xep'],
            $params['giao_dich'],
            $params['ma_nt']
        ]);
    }
}
```

## Ghi chú
- Báo cáo bảng kê chứng từ thanh toán
- Hỗ trợ lọc theo số chứng từ và loại giao dịch
- Tương tự ARRptBK01 nhưng tập trung vào chứng từ thanh toán
- Thường dùng để kiểm tra các giao dịch thu/chi tiền
