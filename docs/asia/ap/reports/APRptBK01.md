# APRptBK01

## Tổng quan
- **Module**: AP (Accounts Payable)
- **Loại**: Report (Báo cáo)
- **Chức năng**: Báo cáo bảng kê chứng từ mua hàng (Purchase Invoice Register)

## Forms

### frmAPRptBK01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng kê chứng từ mua hàng với nhiều điều kiện lọc

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMa_Kh | AsTextBox | MA_KH | AutoLookup, AutoComplete |
| lblTen_Kh | Label | ten_kh | Display only |
| txtMa_vt | AsTextBox | MA_VT | AutoLookup |
| lblTen_vt | Label | ten_vt | Display only |
| txtMa_nhvt | AsTextBox | MA_NHVT | AutoLookup |
| lblTen_nhvt | Label | ten_nhvt | Display only |
| txtMa_kho | AsTextBox | MA_KHO | AutoLookup |
| lblTen_kho | Label | ten_kho | Display only |
| txtMa_Bp | AsTextBox | MA_BP | AutoLookup |
| lblTen_Bp | Label | ten_bp | Display only |
| txtMa_Hd | AsTextBox | MA_HD | AutoLookup |
| lblTen_Hd | Label | ten_hd | Display only |
| txtMa_phi | AsTextBox | MA_PHI | AutoLookup |
| lblTen_phi | Label | ten_phi | Display only |
| txtMa_lo | AsTextBox | MA_LO | AutoLookup |
| lblTen_lo | Label | ten_lo | Display only |
| txtma_spct | AsTextBox | MA_SPCT | AutoLookup |
| lblTen_SPCT | Label | ten_spct | Display only |
| txtMa_plkh1 | AsTextBox | MA_PLKH | AutoLookup (loai=1) |
| lblTen_plkh1 | Label | ten_plkh1 | Display only |
| txtMa_plkh2 | AsTextBox | MA_PLKH | AutoLookup (loai=2) |
| lblTen_plkh2 | Label | ten_plkh2 | Display only |
| txtMa_plkh3 | AsTextBox | MA_PLKH | AutoLookup (loai=3) |
| lblTen_plkh3 | Label | ten_plkh3 | Display only |
| txtSo_Ct1 | TextBox | so_ct_from | Input |
| txtSo_Ct2 | TextBox | so_ct_to | Input |
| txtSo_PX | TextBox | so_px | Input |
| txtNgay1 | AsMaskedTextBox | ngay_ct_from | Date input |
| txtNgay2 | AsMaskedTextBox | ngay_ct_to | Date input |
| cboKyBc | ComboBox | ky_bao_cao | Period selection |
| cboMau_bc | ComboBox | mau_bao_cao | Report template |
| txtMa_Nt | AsTextBox | ma_nt | Currency |
| optVND | RadioButton | loai_tien | VND option |
| optNt | RadioButton | loai_tien | Foreign currency option |
| crvReportViewer | CrystalReportViewer | - | Report display |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| MenuId | string | ID menu của báo cáo |
| CompanyID | string | ID công ty |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitializeComponent | - | void | Khởi tạo UI components |
| InitOtherComponents | - | void | Thiết lập max length cho các trường số |
| LoadData | - | bool | Load dữ liệu báo cáo từ database |
| GetFilterTitle | - | string | Tạo chuỗi tiêu đề filter cho báo cáo |

## Data Access

### Report Controller (kế thừa từ frmReport)
- **Interface**: IReportController
- **Implementation**: MssqlReportController

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetDataSet | sp_rpt_ap_bk01 | ArrayList params | DataSet | Lấy dữ liệu báo cáo |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_rpt_ap_bk01 | Lấy dữ liệu bảng kê chứng từ mua hàng | @company_id, @ngay1, @ngay2, @ma_kh, @ma_vt, @ma_nhvt, @ma_kho, @ma_lo, @ma_phi, @ma_spct, @ma_bp, @ma_nt, @ma_hd, @so_px, @so_ct1, @so_ct2, @ma_plkh1, @ma_plkh2, @ma_plkh3 | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng nhập các điều kiện lọc (khách hàng, vật tư, kho, bộ phận, hợp đồng, phí, lô, SPCT, phân loại KH)
2. Chọn kỳ báo cáo (ngày bắt đầu - kết thúc)
3. Chọn mẫu báo cáo
4. Click nút OK để tạo báo cáo
5. Hệ thống gọi SP sp_rpt_ap_bk01 với các tham số
6. Hiển thị kết quả trên Crystal Report Viewer

### Validation rules
- Ngày bắt đầu <= Ngày kết thúc
- Số chứng từ từ <= Số chứng từ đến
- Mã khách hàng, vật tư, kho... phải tồn tại trong danh mục (qua AutoLookup)

### Calculation logic
- Tính toán các cột tổng tiền theo điều kiện lọc
- Chuyển đổi tiền tệ theo tỷ giá nếu chọn ngoại tệ

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| dmkh | Danh mục khách hàng/NCC | R |
| dmvt | Danh mục vật tư | R |
| dmnhvt | Danh mục nhóm vật tư | R |
| dmkho | Danh mục kho | R |
| dmbp | Danh mục bộ phận | R |
| dmhd | Danh mục hợp đồng | R |
| dmphi | Danh mục phí | R |
| dmlo | Danh mục lô | R |
| dmspct | Danh mục SPCT | R |
| dmplkh | Danh mục phân loại KH | R |
| apbk01 | Dữ liệu bảng kê chứng từ mua hàng | R |

## Mapping sang PHP

### Controller
```php
// Tương đương frmAPRptBK01.cs
class APRptBK01Controller extends ReportController 
{
    public function index()
    {
        // Load filter form
        return view('ap.reports.bk01');
    }
    
    public function generate(Request $request)
    {
        $params = $request->validate([
            'ngay1' => 'required|date',
            'ngay2' => 'required|date',
            'ma_kh' => 'nullable|string',
            'ma_vt' => 'nullable|string',
            // ... other params
        ]);
        
        $data = $this->repository->getReportData($params);
        return $this->generateReport('ap_bk01', $data);
    }
}
```

### Repository
```php
// Tương đương Data Access
class APRptBK01Repository 
{
    public function getReportData(array $params): Collection
    {
        return DB::select('EXEC sp_rpt_ap_bk01 ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['company_id'],
            $params['ngay1'],
            $params['ngay2'],
            $params['ma_kh'] ?? '',
            $params['ma_vt'] ?? '',
            // ... other params
        ]);
    }
}
```

### Model
```php
// Tương đương DataTable
class APBk01 extends Model
{
    protected $table = 'apbk01';
    protected $fillable = [
        'ngay_ct', 'so_ct', 'ma_kh', 'ten_kh',
        'ma_vt', 'ten_vt', 'so_luong', 'gia',
        'tien', 'tien_nt', 'ma_nt', 'ty_gia'
    ];
}
```

## Ghi chú
- Báo cáo sử dụng Crystal Reports để hiển thị
- Có hỗ trợ xuất Excel qua nút cmdExcel
- Có thể chỉnh sửa mẫu báo cáo qua nút cmdModifyReport
- Các trường mã (ma_kh, ma_vt...) đều có chức năng AutoLookup để tra cứu từ danh mục
- Hỗ trợ lọc theo 3 cấp phân loại khách hàng (plkh1, plkh2, plkh3)
