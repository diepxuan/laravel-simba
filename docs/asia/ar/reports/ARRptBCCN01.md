# ARRptBCCN01

## Tổng quan
- **Module**: AR (Accounts Receivable)
- **Loại**: Report
- **Chức năng**: Báo cáo bảng cân đối công nợ khách hàng theo tài khoản và khách hàng

## Forms

### frmARRptBCCN01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng cân đối công nợ khách hàng

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtTk | AsTextBox | TK (tk_cn=1) | Lookup, AutoComplete |
| txtMa_Kh | AsTextBox | MA_KH | Lookup, AutoComplete |
| lblTen_Tk | Label | Hiển thị tên TK | - |
| lblTen_Kh | Label | Hiển thị tên KH | - |
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
| ValidData | - | bool | Validate dữ liệu đầu vào |
| GetFilterTitle | - | string | Lấy tiêu đề filter |

## Data Access

Không có DAO riêng, sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| asARRptBCCN01 | Lấy dữ liệu báo cáo | @pMa_cty, @pNgay1, @pNgay2, @pTk, @pMa_kh, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng nhập thông tin filter (tài khoản, khách hàng, kỳ báo cáo)
2. Validate dữ liệu đầu vào
3. Gọi SP asARRptBCCN01 để lấy dữ liệu
4. Hiển thị dữ liệu trên DataGridView
5. Cho phép xuất Excel hoặc in báo cáo

### Validation rules
- Tài khoản (txtTk) phải là tài khoản công nợ (tk_cn=1)
- Ngày bắt đầu phải <= ngày kết thúc

### Calculation logic
- Tính toán số dư đầu kỳ, phát sinh trong kỳ, số dư cuối kỳ
- Phân biệt VND và ngoại tệ

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| ARDCTT | Chi tiết công nợ | R |
| ARTT | Tổng hợp công nợ | R |
| DMTK | Danh mục tài khoản | R |
| DMKH | Danh mục khách hàng | R |

## Mapping sang PHP

### Controller
```php
class ARRptBCCN01Controller extends ReportController {
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
            'ma_nt' => $request->currency
        ];
        return $this->service->getReportData($params);
    }
}
```

### Repository
```php
class ARRptBCCN01Repository {
    public function getReportData($params) {
        return DB::select('EXEC asARRptBCCN01 ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['tk'],
            $params['ma_kh'],
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
```

## Ghi chú
- Báo cáo này là báo cáo cơ bản về công nợ khách hàng
- Hỗ trợ drill-down xuống chi tiết (F5)
- Có thể xuất Excel
