# CORptGt02

## Tổng quan
- **Module**: CO (Cost)
- **Loại**: Report
- **Chức năng**: Báo cáo giá thành 02 - Chi tiết chi phí theo tài khoản và sản phẩm chi tiết

## Forms

### frmCORptGt02.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo giá thành chi tiết

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtTk | AsTextBox | TK | AutoLookup, ValidReturnFieldList="TEN_TK" |
| txtMA_SPCT | AsTextBox | MA_SPCT | AutoLookup, ValidReturnFieldList="TEN_SPCT" |
| lblTen_Tk | Label | Hiển thị tên TK | - |
| lblTen_SPCT | Label | Hiển thị tên SPCT | - |
| lblTk | Label | Label "Tài khoản" | - |
| lblMa_SPCT | Label | Label "Mã SPCT" | - |
| txtThang1 | AsTextNumeric | Từ tháng (ẩn) | - |
| txtThang2 | AsTextNumeric | Đến tháng (ẩn) | - |
| txtNam | AsTextNumeric | Năm (ẩn) | - |
| Label1 | Label | Label "Từ tháng" (ẩn) | - |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu | - |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc | - |
| cboKyBc | ComboBox | Kỳ báo cáo | - |
| cboMau_bc | ComboBox | Mẫu báo cáo | - |
| txtTieu_De | TextBox | Tiêu đề báo cáo | - |
| cmdOk | Button | Thực hiện báo cáo | - |
| cmdCancel | Button | Hủy | - |
| cmdExcel | Button | Xuất Excel | - |
| cmdModifyReport | Button | Sửa báo cáo | - |
| optVND | RadioButton | Loại tiền VND (ẩn) | - |
| optNt | RadioButton | Loại tiền ngoại tệ (ẩn) | - |
| txtMa_Nt | AsTextBox | Mã ngoại tệ (ẩn) | - |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| Ten_tk | string | Lưu tên tài khoản |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo với filter title |
| ValidData | - | bool | Validate dữ liệu đầu vào (bắt buộc nhập txtTk) |
| frmCOGDBGT_Load | sender, EventArgs | void | Event load form, set giá trị mặc định cho txtTk từ MyMenuInfo.par1 |
| GetFilterTitle | - | string | Tạo chuỗi mô tả điều kiện lọc |
| InitializeComponent | - | void | Khởi tạo UI |

## Data Access

### LoadData Method
```csharp
ArrayList arrayList = new ArrayList();
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
arrayList.Add(((TextBox)txtMA_SPCT).Text);
arrayList.Add(((TextBox)txtTk).Text);
set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
base.MyFomularFields.Clear();
base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
return true;
```

### GetFilterTitle Method
```csharp
private string GetFilterTitle()
{
    string text = string.Empty;
    if (Operators.CompareString(((TextBox)txtTk).Text.Trim(), "", false) != 0)
    {
        text = text + lblTk.Text + ": [" + ((TextBox)txtTk).Text + " - " + lblTen_Tk.Text + "]; ";
    }
    if (Operators.CompareString(((TextBox)txtMA_SPCT).Text.Trim(), "", false) != 0)
    {
        text = text + lblMa_SPCT.Text + ": [" + ((TextBox)txtMA_SPCT).Text + " - " + lblTen_SPCT.Text + "]; ";
    }
    return text;
}
```

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| (Từ base.MyController.GetData) | Lấy dữ liệu báo cáo giá thành chi tiết | @CompanyID, @Ngay1, @Ngay2, @Ma_SPCT, @Tk | DataTable |

## Business Logic

### Luồng xử lý chính
1. Form load: Set giá trị mặc định cho txtTk từ MyMenuInfo.par1
2. User nhập điều kiện lọc (Tài khoản - bắt buộc, SPCT - optional)
3. Click cmdOk để thực hiện báo cáo
4. System validate dữ liệu (bắt buộc có TK)
5. LoadData() lấy dữ liệu, tạo filter title và hiển thị

### Validation rules
- **Bắt buộc**: Tài khoản (txtTk) phải được nhập
- **Optional**: Mã SPCT

### Filter Title Generation
- Nếu có nhập TK: hiển thị "Tài khoản: [Mã TK - Tên TK]"
- Nếu có nhập SPCT: hiển thị "Mã SPCT: [Mã SPCT - Tên SPCT]"
- Filter title được truyền vào báo cáo qua MyFomularFields

### Lookup codes
| Field | LookupCodeName | ValidReturnFieldList |
|-------|----------------|---------------------|
| txtTk | TK | TEN_TK |
| txtMA_SPCT | MA_SPCT | TEN_SPCT |

### Filter params
| Param | Source | Description |
|-------|--------|-------------|
| @CompanyID | CompanyInformations.CompanyID | Mã công ty |
| @Ngay1 | txtNgay1.Value | Ngày bắt đầu |
| @Ngay2 | txtNgay2.Value | Ngày kết thúc |
| @Ma_SPCT | txtMA_SPCT.Text | Mã sản phẩm chi tiết |
| @Tk | txtTk.Text | Tài khoản |

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GLDMTK | Danh mục tài khoản | R |
| CODMSPCT | Danh mục sản phẩm chi tiết | R |
| (Table giá thành chi tiết) | Dữ liệu giá thành chi tiết | R |

## Mapping sang PHP

### Controller
```php
class CORptGt02Controller extends ReportController {
    public function index() {
        return view('co.reports.gt02');
    }
    
    public function getData(Request $request) {
        $validated = $request->validate([
            'tk' => 'required',
            'ngay1' => 'required|date',
            'ngay2' => 'required|date',
        ]);
        
        $params = [
            $request->company_id,
            $request->ngay1,
            $request->ngay2,
            $request->ma_spct ?? '',
            $request->tk
        ];
        
        $data = DB::select('EXEC sp_CORptGt02 ?, ?, ?, ?, ?', $params);
        
        // Generate filter title
        $filterTitle = $this->generateFilterTitle($request);
        
        return response()->json([
            'data' => $data,
            'filter_title' => $filterTitle
        ]);
    }
    
    private function generateFilterTitle($request) {
        $title = '';
        
        if (!empty($request->tk)) {
            $tenTk = DB::table('gldmtk')->where('tk', $request->tk)->value('ten_tk');
            $title .= "Tài khoản: [{$request->tk} - {$tenTk}]; ";
        }
        
        if (!empty($request->ma_spct)) {
            $tenSpct = DB::table('codmspct')->where('ma_spct', $request->ma_spct)->value('ten_spct');
            $title .= "Mã SPCT: [{$request->ma_spct} - {$tenSpct}]; ";
        }
        
        return $title;
    }
}
```

### Repository
```php
class CORptGt02Repository {
    public function getGiaThanhChiTiet($filters) {
        return DB::table('co_gia_thanh_chi_tiet')
            ->where('company_id', $filters['company_id'])
            ->whereBetween('ngay_ct', [$filters['ngay1'], $filters['ngay2']])
            ->where('tk', $filters['tk'])
            ->when(!empty($filters['ma_spct']), function($q) use ($filters) {
                $q->where('ma_spct', $filters['ma_spct']);
            })
            ->orderBy('ngay_ct')
            ->orderBy('so_ct')
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
        <div class="col-md-6">
            <x-lookup name="tk" code="TK" label="Tài khoản" 
                      required="true"
                      valid-return="TEN_TK" />
        </div>
        <div class="col-md-6">
            <x-lookup name="ma_spct" code="MA_SPCT" label="Mã SPCT"
                      valid-return="TEN_SPCT" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <x-date-range name="ngay" label="Kỳ báo cáo" required="true" />
        </div>
    </div>
</form>

<div id="reportContainer">
    <div class="filter-title" id="filterTitle"></div>
    <table id="reportTable" class="table table-bordered">
        <!-- Data will be loaded here -->
    </table>
</div>
@endsection

@push('scripts')
<script>
$(document).ready(function() {
    // Set default value for TK from menu param
    $('#tk').val(menuParams.par1 || '');
    
    // Lookup handlers
    initLookup('#tk', 'TK', 'TEN_TK');
    initLookup('#ma_spct', 'MA_SPCT', 'TEN_SPCT');
    
    // Form submit
    $('#filterForm').on('submit', function(e) {
        e.preventDefault();
        loadReportData();
    });
});

function loadReportData() {
    $.ajax({
        url: '/co/reports/gt02/data',
        data: $('#filterForm').serialize(),
        success: function(response) {
            $('#filterTitle').text(response.filter_title);
            renderTable(response.data);
        }
    });
}
</script>
@endpush
```

## Ghi chú
- Báo cáo giá thành 02 là báo cáo chi tiết chi phí theo tài khoản
- Có thể lọc theo sản phẩm chi tiết (SPCT)
- Form tự động tạo filter title để hiển thị trên báo cáo
- Khác với CORptGt01: không có checkbox "Chi tiết theo VT"
- Các control tháng/năm bị ẩn, chỉ sử dụng ngày
