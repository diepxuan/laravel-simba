# APRptBK03

## Tổng quan
- **Module**: AP (Accounts Payable)
- **Loại**: Report (Báo cáo)
- **Chức năng**: Báo cáo bảng kê chi tiết công nợ phải trả (Detailed AP Balance Report)

## Forms

### frmAPRptBK03.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo chi tiết công nợ phải trả

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMa_Kh | AsTextBox | MA_KH | AutoLookup, AutoComplete |
| lblTen_Kh | Label | ten_kh | Display only |
| txtMa_NhKh | AsTextBox | MA_NHKH | AutoLookup |
| lblTen_NhKh | Label | ten_nhkh | Display only |
| txtMa_plkh1 | AsTextBox | MA_PLKH | AutoLookup (loai=1) |
| lblTen_plkh1 | Label | ten_plkh1 | Display only |
| txtMa_plkh2 | AsTextBox | MA_PLKH | AutoLookup (loai=2) |
| lblTen_plkh2 | Label | ten_plkh2 | Display only |
| txtMa_plkh3 | AsTextBox | MA_PLKH | AutoLookup (loai=3) |
| lblTen_plkh3 | Label | ten_plkh3 | Display only |
| cboGiao_dich | ComboBox | ma_gd | Dropdown: Tất cả/Hóa đơn/Đơn hàng |
| lblGiao_dich | Label | - | Label "Giao dịch" |
| txtSo_Ct1 | TextBox | so_ct_from | Input |
| txtSo_Ct2 | TextBox | so_ct_to | Input |
| ChkSap_xep | AsCheckBox | sap_xep | Check "Khách hàng" |
| lblSap_xep | Label | - | Label "Sắp xếp" |
| cboChi_xem | ComboBox | chi_xem | Dropdown: Tất toán/Chưa tất toán/Tất cả |
| lblChi_xem | Label | - | Label "Chỉ xem" |
| txtNgay1 | AsMaskedTextBox | ngay_ct_from | Date input |
| txtNgay2 | AsMaskedTextBox | ngay_ct_to | Date input |
| cboKyBc | ComboBox | ky_bao_cao | Period selection |
| cboMau_bc | ComboBox | mau_bao_cao | Report template |
| txtMa_Nt | AsTextBox | ma_nt | Currency |
| optVND | RadioButton | loai_tien | VND option |
| optNt | RadioButton | loai_tien | Foreign currency option |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| MenuId | string | ID menu của báo cáo |
| CompanyID | string | ID công ty |
| oToolTip | ToolTip | Hiển thị tooltip cho combobox |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitializeComponent | - | void | Khởi tạo UI components |
| InitOtherComponents | - | void | Khởi tạo datasource cho giao dịch, thiết lập mặc định |
| LoadData | - | bool | Load dữ liệu báo cáo từ database |
| GetFilterTitle | - | string | Tạo chuỗi tiêu đề filter cho báo cáo |
| cboChi_xem_GotFocus | object sender, EventArgs e | void | Hiển thị tooltip nếu text dài |
| cboChi_xem_SelectedIndexChanged | object sender, EventArgs e | void | Xử lý khi thay đổi lựa chọn |
| cboGiao_dich_GotFocus | object sender, EventArgs e | void | Hiển thị tooltip nếu text dài |
| cboGiao_dich_SelectedIndexChanged | object sender, EventArgs e | void | Xử lý khi thay đổi lựa chọn |

## Data Access

### Report Controller (kế thừa từ frmReport)
- **Interface**: IReportController
- **Implementation**: MssqlReportController

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetData | sp_rpt_ap_bk03 | ArrayList params | DataTable | Lấy dữ liệu báo cáo |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_rpt_ap_bk03 | Lấy dữ liệu chi tiết công nợ | @company_id, @ngay1, @ngay2, @ma_gd, @so_ct1, @so_ct2, @ma_kh, @ma_nhkh, @ma_plkh1, @ma_plkh2, @ma_plkh3, @sap_xep, @chi_xem, @ma_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn loại giao dịch (Tất cả/Hóa đơn/Đơn hàng)
2. Nhập khoảng số chứng từ (từ - đến)
3. Chọn kỳ báo cáo (ngày bắt đầu - kết thúc)
4. Lọc theo khách hàng, nhóm KH, phân loại KH (3 cấp)
5. Chọn chế độ xem (tất toán/chưa/tất cả)
6. Chọn sắp xếp theo khách hàng
7. Click OK để tạo báo cáo

### Validation rules
- Ngày bắt đầu <= Ngày kết thúc
- Số chứng từ từ <= Số chứng từ đến
- Mã giao dịch phải hợp lệ

### Calculation logic
- Tính số dư đầu kỳ, phát sinh trong kỳ, số dư cuối kỳ
- Phân loại theo trạng thái tất toán
- Tính tổng theo từng nhóm (nếu sắp xếp)

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| dmkh | Danh mục khách hàng/NCC | R |
| dmnhkh | Danh mục nhóm khách hàng | R |
| dmplkh | Danh mục phân loại KH | R |
| dmgd | Danh mục giao dịch | R |
| apbk03 | Dữ liệu chi tiết công nợ | R |

## Mapping sang PHP

### Controller
```php
// Tương đương frmAPRptBK03.cs
class APRptBK03Controller extends ReportController 
{
    public function index()
    {
        // Load danh mục giao dịch
        $dmGiaoDich = DMGiaoDich::where('par1', $this->menuInfo->par1)->get();
        
        return view('ap.reports.bk03', compact('dmGiaoDich'));
    }
    
    public function generate(Request $request)
    {
        $params = $request->validate([
            'ngay1' => 'required|date',
            'ngay2' => 'required|date',
            'ma_gd' => 'nullable|string',
            'so_ct1' => 'nullable|string',
            'so_ct2' => 'nullable|string',
            'ma_kh' => 'nullable|string',
            'ma_nhkh' => 'nullable|string',
            'ma_plkh1' => 'nullable|string',
            'ma_plkh2' => 'nullable|string',
            'ma_plkh3' => 'nullable|string',
            'sap_xep' => 'nullable|boolean',
            'chi_xem' => 'required|in:1,2,3', // 1=Tất toán, 2=Chưa TT, 3=Tất cả
            'ma_nt' => 'nullable|string',
        ]);
        
        $data = $this->repository->getReportData($params);
        return $this->generateReport('ap_bk03', $data);
    }
}
```

### Repository
```php
// Tương đương Data Access
class APRptBK03Repository 
{
    public function getReportData(array $params): Collection
    {
        return DB::select('EXEC sp_rpt_ap_bk03 ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['company_id'],
            $params['ngay1'],
            $params['ngay2'],
            $params['ma_gd'] ?? '',
            $params['so_ct1'] ?? '',
            $params['so_ct2'] ?? '',
            $params['ma_kh'] ?? '',
            $params['ma_nhkh'] ?? '',
            $params['ma_plkh1'] ?? '',
            $params['ma_plkh2'] ?? '',
            $params['ma_plkh3'] ?? '',
            $params['sap_xep'] ? '1' : '0',
            $params['chi_xem'],
            $params['ma_nt'] ?? '',
        ]);
    }
}
```

### Model
```php
// Tương đương DataTable
class APBk03 extends Model
{
    protected $table = 'apbk03';
    protected $fillable = [
        'ma_kh', 'ten_kh', 'ma_gd', 'ten_gd',
        'so_ct', 'ngay_ct', 'tien', 'tien_nt',
        'da_tt', 'con_lai', 'trang_thai',
        'ma_nt', 'ty_gia'
    ];
    
    // Check if fully paid
    public function isFullyPaid(): bool
    {
        return $this->con_lai <= 0;
    }
}
```

## Ghi chú
- Báo cáo chi tiết hiển thị từng chứng từ công nợ
- Có thể lọc theo loại giao dịch (lấy từ dmGiaoDich)
- Hỗ trợ tooltip cho các combobox dài
- Có thể lọc theo 3 cấp phân loại khách hàng
- Chế độ xem cho phép lọc theo trạng thái tất toán
- Sắp xếp theo khách hàng để nhóm dữ liệu
- Sử dụng Crystal Reports để hiển thị
