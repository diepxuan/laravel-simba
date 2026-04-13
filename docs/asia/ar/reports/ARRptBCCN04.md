# ARRptBCCN04

## Tổng quan
- **Module**: AR (Accounts Receivable)
- **Loại**: Report
- **Chức năng**: Báo cáo bảng cân đối công nợ khách hàng theo nhóm và chi tiết

## Forms

### frmARRptBCCN04.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo công nợ với khả năng nhóm và chi tiết theo nhiều tiêu chí

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMa_Tk | AsTextBox | TK (tk_cn=1) | Lookup, AutoComplete |
| txtMa_Kh | AsTextBox | MA_KH (isKh=1) | Lookup, AutoComplete |
| txtMa_plkh1 | AsTextBox | MA_PLKH (loai=1) | Lookup, AutoComplete |
| txtMa_plkh2 | AsTextBox | MA_PLKH (loai=2) | Lookup, AutoComplete |
| txtMa_plkh3 | AsTextBox | MA_PLKH (loai=3) | Lookup, AutoComplete |
| txtMa_hd | AsTextBox | MA_HD | Lookup, AutoComplete |
| txtMa_bp | AsTextBox | MA_BP | Lookup, AutoComplete |
| txtMa_spct | AsTextBox | MA_SPCT | Lookup, AutoComplete |
| txtMa_nvkd | AsTextBox | MA_NVKD | Lookup (hidden) |
| cboNhomTheo | ComboBox | Nhóm theo | SelectedIndexChanged |
| cboChi_tiet | ComboBox | Chi tiết theo | SelectedIndexChanged |
| lblTen_Tk | Label | Hiển thị tên TK | - |
| lblTen_Kh | Label | Hiển thị tên KH | - |
| lblTen_plkh1 | Label | Hiển thị tên PLKH1 | - |
| lblTen_plkh2 | Label | Hiển thị tên PLKH2 | - |
| lblTen_plkh3 | Label | Hiển thị tên PLKH3 | - |
| lblTen_hd | Label | Hiển thị tên HD | - |
| lblTen_bp | Label | Hiển thị tên BP | - |
| lblTen_SPCT | Label | Hiển thị tên SPCT | - |
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
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |
| cboNhomTheo_SelectedIndexChanged | sender, e | void | Xử lý thay đổi nhóm |
| cboChi_tiet_SelectedIndexChanged | sender, e | void | Xử lý thay đổi chi tiết |

## Data Access

Không có DAO riêng, sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| asARRptBCCN04 | Lấy dữ liệu báo cáo | @pMa_cty, @pNgay1, @pNgay2, @pTk, @pNhomTheo, @pChiTiet, @pMa_hd, @pMa_kh, @pMa_plkh1, @pMa_plkh2, @pMa_plkh3, @pMa_bp, @pMa_nvkd, @pMa_spct, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng nhập tài khoản công nợ (bắt buộc)
2. Chọn tiêu chí nhóm: Khách hàng, Hợp đồng, Công trình, hoặc Bộ phận
3. Chọn tiêu chí chi tiết (khác với nhóm)
4. Có thể lọc thêm theo khách hàng, phân loại, hợp đồng, bộ phận, công trình
5. Gọi SP asARRptBCCN04 để lấy dữ liệu
6. Hiển thị báo cáo với khả năng drill-down (F5)

### Validation rules
- Tài khoản (txtMa_Tk) bắt buộc phải nhập
- Tiêu chí nhóm và chi tiết không được trùng nhau (trừ khi cả hai đều là Khách hàng)

### Calculation logic
- Nhóm dữ liệu theo tiêu chí đã chọn
- Hiển thị chi tiết theo tiêu chí chi tiết
- Tính toán số dư đầu kỳ, phát sinh, số dư cuối kỳ theo nhóm
- Hỗ trợ drill-down xuống chi tiết từng đối tượng (F5)

### Xử lý đặc biệt
- Nếu nhóm theo Khách hàng và chi tiết theo Khách hàng -> tự động chuyển chi tiết sang mục tiếp theo
- Nếu nhóm không phải Khách hàng và chi tiết không phải Khách hàng -> tự động chuyển nhóm về Khách hàng

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| ARDCTT | Chi tiết công nợ | R |
| ARTT | Tổng hợp công nợ | R |
| DMTK | Danh mục tài khoản | R |
| DMKH | Danh mục khách hàng | R |
| DMPLKH | Danh mục phân loại khách hàng | R |
| DMHD | Danh mục hợp đồng | R |
| DMBP | Danh mục bộ phận | R |
| DMSPCT | Danh mục công trình | R |

## Mapping sang PHP

### Controller
```php
class ARRptBCCN04Controller extends ReportController {
    protected $groupOptions = [
        'MA_KH' => 'Khách hàng',
        'MA_HD' => 'Hợp đồng',
        'MA_SPCT' => 'Công trình',
        'MA_BP' => 'Bộ phận'
    ];
    
    public function index(Request $request) {
        // Hiển thị form filter
        return view('ar.reports.bccn04', [
            'groupOptions' => $this->groupOptions
        ]);
    }
    
    public function getData(Request $request) {
        $params = [
            'ma_cty' => $request->company_id,
            'ngay1' => $request->date_from,
            'ngay2' => $request->date_to,
            'tk' => $request->account,
            'nhom_theo' => $request->group_by,
            'chi_tiet' => $request->detail_by,
            'ma_hd' => $request->contract_id,
            'ma_kh' => $request->customer_id,
            'ma_plkh1' => $request->plkh1,
            'ma_plkh2' => $request->plkh2,
            'ma_plkh3' => $request->plkh3,
            'ma_bp' => $request->department_id,
            'ma_nvkd' => $request->sales_id,
            'ma_spct' => $request->project_id,
            'ma_nt' => $request->currency
        ];
        return $this->service->getReportData($params);
    }
}
```

### Repository
```php
class ARRptBCCN04Repository {
    public function getReportData($params) {
        return DB::select('EXEC asARRptBCCN04 ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['tk'],
            $params['nhom_theo'],
            $params['chi_tiet'],
            $params['ma_hd'],
            $params['ma_kh'],
            $params['ma_plkh1'],
            $params['ma_plkh2'],
            $params['ma_plkh3'],
            $params['ma_bp'],
            $params['ma_nvkd'],
            $params['ma_spct'],
            $params['ma_nt']
        ]);
    }
}
```

### JavaScript (xử lý nhóm/chi tiết)
```javascript
$(document).ready(function() {
    $('#cboNhomTheo').on('change', function() {
        var nhomTheo = $(this).val();
        var chiTiet = $('#cboChi_tiet').val();
        
        if (nhomTheo === chiTiet && nhomTheo === 'MA_KH') {
            // Tự động chuyển chi tiết sang mục tiếp theo
            var nextIndex = $('#cboChi_tiet option:selected').index() + 1;
            $('#cboChi_tiet').prop('selectedIndex', nextIndex);
        }
        
        if (nhomTheo !== 'MA_KH' && chiTiet !== 'MA_KH') {
            $('#cboNhomTheo').val('MA_KH');
        }
    });
    
    $('#cboChi_tiet').on('change', function() {
        var nhomTheo = $('#cboNhomTheo').val();
        var chiTiet = $(this).val();
        
        if (nhomTheo === chiTiet && nhomTheo === 'MA_KH') {
            var nextIndex = $('#cboNhomTheo option:selected').index() + 1;
            $('#cboNhomTheo').prop('selectedIndex', nextIndex);
        }
        
        if (nhomTheo !== 'MA_KH' && chiTiet !== 'MA_KH') {
            $('#cboNhomTheo').val('MA_KH');
        }
    });
});
```

## Ghi chú
- Báo cáo nâng cao cho phép nhóm và chi tiết theo nhiều tiêu chí
- Hỗ trợ drill-down (F5) xuống chi tiết công nợ
- Có validation đặc biệt để đảm bảo nhóm và chi tiết hợp lý
- Phù hợp cho việc phân tích công nợ theo nhiều chiều
