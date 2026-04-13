# APRptBK02

## Tổng quan
- **Module**: AP (Accounts Payable)
- **Loại**: Report (Báo cáo)
- **Chức năng**: Báo cáo bảng kê công nợ phải trả theo hạn thanh toán (Aging Report)

## Forms

### frmAPRptBK02.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng kê công nợ phải trả theo hạn thanh toán

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMa_Kh | AsTextBox | MA_KH | AutoLookup, AutoComplete |
| lblTen_Kh | Label | ten_kh | Display only |
| txtMa_NhKh | AsTextBox | MA_NHKH | AutoLookup |
| lblTen_NhKh | Label | ten_nhkh | Display only |
| txtNgay_Ss | AsMaskedTextBox | ngay_ss | Date input (ngày so sánh) |
| lblNgay_Ss | Label | - | Label "Ngày so sánh" |
| txtHan_ky1 | AsTextNumeric | han_ky1 | Numeric input, Validated event |
| lblHan_ky1 | Label | - | Label "Hạn kỳ 1" |
| txtHan_ky2 | AsTextNumeric | han_ky2 | Numeric input, Validated event |
| lblHan_ky2 | Label | - | Label "Hạn kỳ 2" |
| txtHan_ky3 | AsTextNumeric | han_ky3 | Numeric input, Validated event |
| lblHan_ky3 | Label | - | Label "Hạn kỳ 3" |
| ChkSap_xep | AsCheckBox | sap_xep | Check "Nhà cung cấp" |
| lblSap_xep | Label | - | Label "Sắp xếp" |
| cboChi_xem | ComboBox | chi_xem | Dropdown: Chưa tất toán/Đã tất toán/Tất cả |
| lblChi_xem | Label | - | Label "Chỉ xem" |
| txtMa_Nt | AsTextBox | ma_nt | Currency |
| optVND | RadioButton | loai_tien | VND option |
| optNt | RadioButton | loai_tien | Foreign currency option |
| cboKyBc | ComboBox | ky_bao_cao | Period selection |
| cboMau_bc | ComboBox | mau_bao_cao | Report template |
| txtTieu_De | TextBox | tieu_de | Report title |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| MenuId | string | ID menu của báo cáo |
| CompanyID | string | ID công ty |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitializeComponent | - | void | Khởi tạo UI components |
| InitOtherComponents | - | void | Khởi tạo giá trị mặc định cho hạn kỳ từ SOConfiguration |
| LoadData | - | bool | Load dữ liệu báo cáo từ database |
| GetFilterTitle | - | string | Tạo chuỗi tiêu đề filter cho báo cáo |
| txtHan_ky1_Validated | object sender, EventArgs e | void | Validate hạn kỳ 1 >= 0 |
| txtHan_ky2_Validated | object sender, EventArgs e | void | Validate hạn kỳ 2 >= 0 |
| lblHan_ky3_Validated | object sender, EventArgs e | void | Validate hạn kỳ 3 >= 0 |

## Data Access

### Report Controller (kế thừa từ frmReport)
- **Interface**: IReportController
- **Implementation**: MssqlReportController

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetData | sp_rpt_ap_bk02 | ArrayList params | DataTable | Lấy dữ liệu báo cáo |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_rpt_ap_bk02 | Lấy dữ liệu bảng kê công nợ theo hạn | @company_id, @ngay_ss, @han_ky1, @han_ky2, @han_ky3, @ma_kh, @ma_nhkh, @sap_xep, @chi_xem, @ma_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn ngày so sánh (thường là ngày hiện tại)
2. Nhập 3 hạn kỳ thanh toán (số ngày) - mặc định lấy từ SOConfiguration
3. Lọc theo nhà cung cấp, nhóm NCC
4. Chọn chế độ xem (chưa tất toán/đã tất toán/tất cả)
5. Chọn sắp xếp theo nhà cung cấp
6. Chọn loại tiền (VND/ngoại tệ)
7. Click OK để tạo báo cáo

### Aging buckets
Báo cáo phân loại công nợ theo các khoảng thời gian:
- **Chưa đến hạn**: Ngày đến hạn >= Ngày so sánh
- **Hạn kỳ 1**: Quá hạn 1 đến [han_ky1] ngày
- **Hạn kỳ 2**: Quá hạn [han_ky1+1] đến [han_ky2] ngày
- **Hạn kỳ 3**: Quá hạn [han_ky2+1] đến [han_ky3] ngày
- **Quá hạn**: Quá hạn > [han_ky3] ngày

### Validation rules
- Hạn kỳ 1, 2, 3 phải >= 0
- Ngày so sánh phải hợp lệ
- Mã khách hàng, nhóm KH phải tồn tại trong danh mục

### Calculation logic
- **Số ngày quá hạn** = Ngày so sánh - Ngày đến hạn
- **Phân loại bucket** dựa vào số ngày quá hạn và 3 hạn kỳ
- **Tổng cộng** = Tổng các cột trong từng bucket

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| dmkh | Danh mục khách hàng/NCC | R |
| dmnhkh | Danh mục nhóm khách hàng | R |
| dmnt | Danh mục ngoại tệ | R |
| soconfig | Tham số hệ thống (hạn kỳ mặc định) | R |
| apbk02 | Dữ liệu bảng kê công nợ | R |

## Mapping sang PHP

### Controller
```php
// Tương đương frmAPRptBK02.cs
class APRptBK02Controller extends ReportController 
{
    public function index()
    {
        // Lấy giá trị mặc định từ config
        $soConfig = SOConfiguration::get();
        $defaultHanKy = [
            'han_ky1' => $soConfig->han_tt_ss1 ?? 30,
            'han_ky2' => $soConfig->han_tt_ss2 ?? 60,
            'han_ky3' => $soConfig->han_tt_ss3 ?? 90,
        ];
        
        return view('ap.reports.bk02', compact('defaultHanKy'));
    }
    
    public function generate(Request $request)
    {
        $params = $request->validate([
            'ngay_ss' => 'required|date',
            'han_ky1' => 'required|numeric|min:0',
            'han_ky2' => 'required|numeric|min:0',
            'han_ky3' => 'required|numeric|min:0',
            'ma_kh' => 'nullable|string',
            'ma_nhkh' => 'nullable|string',
            'sap_xep' => 'nullable|boolean',
            'chi_xem' => 'required|in:1,2,3',
            'ma_nt' => 'nullable|string',
        ]);
        
        $data = $this->repository->getReportData($params);
        return $this->generateReport('ap_bk02', $data);
    }
}
```

### Repository
```php
// Tương đương Data Access
class APRptBK02Repository 
{
    public function getReportData(array $params): Collection
    {
        return DB::select('EXEC sp_rpt_ap_bk02 ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['company_id'],
            $params['ngay_ss'],
            $params['han_ky1'],
            $params['han_ky2'],
            $params['han_ky3'],
            $params['ma_kh'] ?? '',
            $params['ma_nhkh'] ?? '',
            $params['sap_xep'] ? '1' : '0',
            $params['chi_xem'],
            $params['ma_nt'] ?? '',
        ]);
    }
    
    // Calculate aging buckets
    public function calculateAging($ngayDenHan, $ngaySs, $hanKy1, $hanKy2, $hanKy3)
    {
        $soNgayQuaHan = $ngaySs->diffInDays($ngayDenHan, false);
        
        if ($soNgayQuaHan < 0) {
            return 'chua_den_han';
        } elseif ($soNgayQuaHan <= $hanKy1) {
            return 'han_ky_1';
        } elseif ($soNgayQuaHan <= $hanKy2) {
            return 'han_ky_2';
        } elseif ($soNgayQuaHan <= $hanKy3) {
            return 'han_ky_3';
        } else {
            return 'qua_han';
        }
    }
}
```

### Model
```php
// Tương đương DataTable
class APBk02 extends Model
{
    protected $table = 'apbk02';
    protected $fillable = [
        'ma_kh', 'ten_kh', 'ma_nhkh',
        'chua_den_han', 'han_ky_1', 'han_ky_2', 'han_ky_3', 'qua_han',
        'tong_cong', 'ma_nt', 'ty_gia'
    ];
    
    // Get aging status
    public function getAgingStatus($ngaySs, $hanKy1, $hanKy2, $hanKy3)
    {
        $soNgayQuaHan = $ngaySs->diffInDays($this->ngay_den_han, false);
        
        if ($soNgayQuaHan < 0) return 'Chưa đến hạn';
        if ($soNgayQuaHan <= $hanKy1) return "Quá hạn 1-{$hanKy1} ngày";
        if ($soNgayQuaHan <= $hanKy2) return "Quá hạn {$hanKy1}-{$hanKy2} ngày";
        if ($soNgayQuaHan <= $hanKy3) return "Quá hạn {$hanKy2}-{$hanKy3} ngày";
        return "Quá hạn > {$hanKy3} ngày";
    }
}
```

## Ghi chú
- APRptBK02 là báo cáo Aging (phân tích tuổi nợ) cho công nợ phải trả
- Hỗ trợ 3 khoảng hạn kỳ tùy chỉnh, mặc định lấy từ SOConfiguration
- Có thể lọc theo trạng thái tất toán
- Sắp xếp theo nhà cung cấp để nhóm dữ liệu
- Sử dụng Crystal Reports để hiển thị
- Validate hạn kỳ phải >= 0
- Báo cáo hiển thị số dư công nợ phân loại theo từng khoảng thời gian quá hạn
