# CoRptCTPBCPTT

## Tổng quan
- **Module**: CO (Cost)
- **Loại**: Report
- **Chức năng**: Báo cáo chi tiết phân bổ chi phí theo thành phẩm (CTPBCPTT - Chi Tiet Phan Bo Chi Phi Thanh Pham)

## Forms

### frmCoRptCTPBCPTT.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo chi tiết phân bổ chi phí với nhiều điều kiện lọc

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMa_bpsd | AsTextBox | MA_BPSD | AutoLookup |
| txtMa_cp | AsTextBox | MA_CPTT | AutoLookup, LookupWhereCondition="MODULEID = 'CO'" |
| txtTk_pb | AsTextBox | TK | AutoLookup |
| txtTk_cp | AsTextBox | TK | AutoLookup |
| txtMa_phi | AsTextBox | MA_PHI | AutoLookup |
| txtMa_spct | AsTextBox | MA_SPCT | AutoLookup |
| lblTen_bpsd | Label | Hiển thị tên BPSD | - |
| lblTen_cp | Label | Hiển thị tên chi phí | - |
| lblTen_tkpb | Label | Hiển thị tên TK phân bổ | - |
| lblTen_tkcp | Label | Hiển thị tên TK chi phí | - |
| lblTen_phi | Label | Hiển thị tên phí | - |
| lblTen_spct | Label | Hiển thị tên SPCT | - |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu | - |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc | - |
| cboKyBc | ComboBox | Kỳ báo cáo | - |
| cboMau_bc | ComboBox | Mẫu báo cáo | - |
| txtTieu_De | TextBox | Tiêu đề báo cáo | - |
| cmdOk | Button | Thực hiện báo cáo | - |
| cmdCancel | Button | Hủy | - |
| cmdExcel | Button | Xuất Excel | - |
| cmdModifyReport | Button | Sửa báo cáo | - |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| sTabName | string | Tên tab |
| sMenuID | string | Menu ID |
| DataLoading | bool | Trạng thái loading dữ liệu |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo với các tham số filter |
| GetFilterTitle | - | string | Tạo chuỗi mô tả điều kiện lọc |
| InitializeComponent | - | void | Khởi tạo UI |

## Data Access

Không có file DAO riêng - sử dụng controller kế thừa từ frmReport.

### LoadData Method
```csharp
ArrayList arrayList = new ArrayList();
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay1.Value)));
arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay2.Value)));
arrayList.Add(((TextBox)txtMa_bpsd).Text);
arrayList.Add(((TextBox)txtMa_cp).Text);
arrayList.Add(((TextBox)txtTk_pb).Text);
arrayList.Add(((TextBox)txtTk_cp).Text);
arrayList.Add(((TextBox)txtMa_phi).Text);
arrayList.Add(((TextBox)txtMa_spct).Text);
set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
```

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| (Từ base.MyController.GetData) | Lấy dữ liệu báo cáo | @CompanyID, @Ngay1, @Ngay2, @Ma_bpsd, @Ma_cp, @Tk_pb, @Tk_cp, @Ma_phi, @Ma_spct | DataTable |

## Business Logic

### Luồng xử lý chính
1. User nhập các điều kiện lọc (BPSD, chi phí, TK phân bổ, TK chi phí, phí, SPCT)
2. Click cmdOk để thực hiện báo cáo
3. System gọi LoadData() để lấy dữ liệu
4. Dữ liệu được truyền vào DataGridView để hiển thị
5. Có thể xuất Excel hoặc in báo cáo

### Filter logic
- Tất cả các trường filter đều optional
- Có thể lọc theo nhiều điều kiện kết hợp
- Ngày bắt đầu và kết thúc bắt buộc (qua txtNgay1, txtNgay2)

### Lookup codes
| Field | LookupCodeName | Condition |
|-------|----------------|-----------|
| txtMa_bpsd | MA_BPSD | - |
| txtMa_cp | MA_CPTT | MODULEID = 'CO' |
| txtTk_pb | TK | - |
| txtTk_cp | TK | - |
| txtMa_phi | MA_PHI | - |
| txtMa_spct | MA_SPCT | - |

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| CODMBPSD | Danh mục bộ phận sử dụng | R |
| CoDMCPTT | Danh mục chi phí | R |
| GLDMTK | Danh mục tài khoản | R |
| CODMPHI | Danh mục phí | R |
| CODMSPCT | Danh mục sản phẩm chi tiết | R |
| (Table phân bổ chi phí) | Dữ liệu phân bổ | R |

## Mapping sang PHP

### Controller
```php
class CoRptCTPBCPTTController extends ReportController {
    public function index() {
        return view('co.reports.ctpbcptt');
    }
    
    public function getData(Request $request) {
        $params = [
            $request->company_id,
            $request->ngay1,
            $request->ngay2,
            $request->ma_bpsd ?? '',
            $request->ma_cp ?? '',
            $request->tk_pb ?? '',
            $request->tk_cp ?? '',
            $request->ma_phi ?? '',
            $request->ma_spct ?? ''
        ];
        
        $data = DB::select('EXEC sp_CoRptCTPBCPTT ?, ?, ?, ?, ?, ?, ?, ?, ?', $params);
        return response()->json($data);
    }
}
```

### Repository
```php
class CoRptCTPBCPTTRepository {
    public function getReportData($filters) {
        return DB::table('co_phan_bo_chi_phi')
            ->where('company_id', $filters['company_id'])
            ->whereBetween('ngay_ct', [$filters['ngay1'], $filters['ngay2']])
            ->when($filters['ma_bpsd'], fn($q) => $q->where('ma_bpsd', $filters['ma_bpsd']))
            ->when($filters['ma_cp'], fn($q) => $q->where('ma_cp', $filters['ma_cp']))
            ->when($filters['tk_pb'], fn($q) => $q->where('tk_pb', $filters['tk_pb']))
            ->when($filters['tk_cp'], fn($q) => $q->where('tk_cp', $filters['tk_cp']))
            ->when($filters['ma_phi'], fn($q) -> $q->where('ma_phi', $filters['ma_phi']))
            ->when($filters['ma_spct'], fn($q) => $q->where('ma_spct', $filters['ma_spct']))
            ->get();
    }
}
```

### View (Blade)
```php
@extends('layouts.report')

@section('content')
<form id="filterForm">
    <div class="row">
        <div class="col-md-4">
            <x-lookup name="ma_bpsd" code="MA_BPSD" label="Mã BPSD" />
        </div>
        <div class="col-md-4">
            <x-lookup name="ma_cp" code="MA_CPTT" label="Mã chi phí" 
                      where="MODULEID = 'CO'" />
        </div>
        <div class="col-md-4">
            <x-lookup name="tk_pb" code="TK" label="TK phân bổ" />
        </div>
    </div>
    <!-- ... other filters ... -->
</form>
@endsection
```

## Ghi chú
- Form kế thừa từ frmReport nên sử dụng các chức năng cơ bản của báo cáo
- Có 6 điều kiện lọc chính, tất cả đều optional
- Sử dụng AutoLookup để tra cứu danh mục
- Báo cáo chi tiết phân bổ chi phí theo nhiều chiều (BPSD, chi phí, TK, phí, SPCT)
