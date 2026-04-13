# ARRptBCCN03

## Tổng quan
- **Module**: AR (Accounts Receivable)
- **Loại**: Report
- **Chức năng**: Báo cáo bảng cân đối công nợ khách hàng tổng hợp theo phân loại

## Forms

### frmARRptBCCN03.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo công nợ tổng hợp theo phân loại khách hàng

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMa_Tk | AsTextBox | TK (tk_cn=1) | Lookup, AutoComplete |
| txtMa_Kh | AsTextBox | MA_KH | Lookup, AutoComplete |
| txtMa_plkh1 | AsTextBox | MA_PLKH (loai='1') | Lookup, AutoComplete |
| txtMa_plkh2 | AsTextBox | MA_PLKH (loai='2') | Lookup, AutoComplete |
| txtMa_plkh3 | AsTextBox | MA_PLKH (loai='3') | Lookup, AutoComplete |
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

## Data Access

Không có DAO riêng, sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| asARRptBCCN03 | Lấy dữ liệu báo cáo | @pMa_cty, @pNgay1, @pNgay2, @pTk, @pMa_kh, @pMa_plkh1, @pMa_plkh2, @pMa_plkh3, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng nhập tài khoản công nợ (bắt buộc)
2. Có thể lọc theo khách hàng và 3 cấp phân loại khách hàng
3. Gọi SP asARRptBCCN03 để lấy dữ liệu
4. Hiển thị báo cáo tổng hợp theo các tiêu chí đã chọn

### Validation rules
- Tài khoản (txtMa_Tk) bắt buộc phải nhập
- Tài khoản phải là tài khoản công nợ (tk_cn=1)

### Calculation logic
- Tính toán số dư đầu kỳ, phát sinh trong kỳ, số dư cuối kỳ
- Tổng hợp theo các cấp phân loại khách hàng
- Phân biệt VND và ngoại tệ

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
class ARRptBCCN03Controller extends ReportController {
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
            'ma_nt' => $request->currency
        ];
        return $this->service->getReportData($params);
    }
}
```

### Repository
```php
class ARRptBCCN03Repository {
    public function getReportData($params) {
        return DB::select('EXEC asARRptBCCN03 ?, ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['tk'],
            $params['ma_kh'],
            $params['ma_plkh1'],
            $params['ma_plkh2'],
            $params['ma_plkh3'],
            $params['ma_nt']
        ]);
    }
}
```

### Model
```php
class ARDCTT extends Model {
    protected $table = 'ARDCTT';
}

class ARTT extends Model {
    protected $table = 'ARTT';
}

class DMPLKH extends Model {
    protected $table = 'DMPLKH';
}
```

## Ghi chú
- Báo cáo tổng hợp công nợ theo phân loại khách hàng
- Đơn giản hơn ARRptBCCN02, không có tùy chọn sắp xếp thứ tự
- Phù hợp để xem tổng quan công nợ theo nhóm khách hàng
