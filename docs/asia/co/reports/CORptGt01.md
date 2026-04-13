# CORptGt01

## Tổng quan
- **Module**: CO (Cost)
- **Loại**: Report
- **Chức năng**: Báo cáo giá thành 01 - Tổng hợp chi phí theo tài khoản và sản phẩm chi tiết

## Forms

### frmCORptGt01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo giá thành tổng hợp

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtTk | AsTextBox | TK | AutoLookup, ValidReturnFieldList="TEN_TK" |
| txtMA_SPCT | AsTextBox | MA_SPCT | AutoLookup, ValidReturnFieldList="TEN_SPCT" |
| lblTen_Tk | Label | Hiển thị tên TK | - |
| Label2 | Label | Hiển thị tên SPCT | - |
| lblTk | Label | Label "Tài khoản" | - |
| Label3 | Label | Label "Mã SPCT" | - |
| chkCt_vt | CheckBox | Chi tiết theo VT | - |
| Label4 | Label | Label "Chi tiết theo VT" | - |
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
| LoadData | - | bool | Load dữ liệu báo cáo |
| ValidData | - | bool | Validate dữ liệu đầu vào (bắt buộc nhập txtTk) |
| frmCOGDBGT_Load | sender, EventArgs | void | Event load form, set giá trị mặc định cho txtTk từ MyMenuInfo.par1 |
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
arrayList.Add(chkCt_vt.Checked);
set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
base.MyFomularFields.Clear();
return true;
```

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| (Từ base.MyController.GetData) | Lấy dữ liệu báo cáo giá thành tổng hợp | @CompanyID, @Ngay1, @Ngay2, @Ma_SPCT, @Tk, @ChiTietVT | DataTable |

## Business Logic

### Luồng xử lý chính
1. Form load: Set giá trị mặc định cho txtTk từ MyMenuInfo.par1
2. User nhập điều kiện lọc (Tài khoản - bắt buộc, SPCT - optional)
3. Chọn có chi tiết theo vật tư hay không (chkCt_vt)
4. Click cmdOk để thực hiện báo cáo
5. System validate dữ liệu (bắt buộc có TK)
6. LoadData() lấy dữ liệu và hiển thị

### Validation rules
- **Bắt buộc**: Tài khoản (txtTk) phải được nhập
- **Optional**: Mã SPCT

### Filter params
| Param | Source | Description |
|-------|--------|-------------|
| @CompanyID | CompanyInformations.CompanyID | Mã công ty |
| @Ngay1 | txtNgay1.Value | Ngày bắt đầu |
| @Ngay2 | txtNgay2.Value | Ngày kết thúc |
| @Ma_SPCT | txtMA_SPCT.Text | Mã sản phẩm chi tiết |
| @Tk | txtTk.Text | Tài khoản |
| @ChiTietVT | chkCt_vt.Checked | Chi tiết theo vật tư |

### Lookup codes
| Field | LookupCodeName | ValidReturnFieldList |
|-------|----------------|---------------------|
| txtTk | TK | TEN_TK |
| txtMA_SPCT | MA_SPCT | TEN_SPCT |

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GLDMTK | Danh mục tài khoản | R |
| CODMSPCT | Danh mục sản phẩm chi tiết | R |
| (Table giá thành tổng hợp) | Dữ liệu giá thành tổng hợp | R |

## So sánh với CORptGt02, CORptGt03

| Đặc điểm | CORptGt01 | CORptGt02 | CORptGt03 |
|----------|-----------|-----------|-----------|
| Checkbox chi tiết VT | Có (chkCt_vt) | Không | Không |
| Filter title | Không | Có | Có |
| Params | 6 params | 5 params | 5 params |
| Mục đích | Tổng hợp + Chi tiết VT | Chi tiết | Chi tiết |

## Mapping sang PHP

### Controller
```php
class CORptGt01Controller extends ReportController {
    public function index() {
        return view('co.reports.gt01');
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
            $request->tk,
            $request->chi_tiet_vt ? 1 : 0
        ];
        
        $data = DB::select('EXEC sp_CORptGt01 ?, ?, ?, ?, ?, ?', $params);
        return response()->json($data);
    }
}
```

### Repository
```php
class CORptGt01Repository {
    public function getGiaThanhTongHop($filters) {
        $query = DB::table('co_gia_thanh_tong_hop')
            ->where('company_id', $filters['company_id'])
            ->whereBetween('ngay_ct', [$filters['ngay1'], $filters['ngay2']])
            ->where('tk', $filters['tk']);
            
        if (!empty($filters['ma_spct'])) {
            $query->where('ma_spct', $filters['ma_spct']);
        }
        
        if ($filters['chi_tiet_vt']) {
            $query->orderBy('ma_vt');
        }
        
        return $query->orderBy('ngay_ct')
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
        <div class="col-md-6">
            <x-checkbox name="chi_tiet_vt" label="Chi tiết theo VT" />
        </div>
    </div>
</form>

<div id="reportContainer">
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
    
    initLookup('#tk', 'TK', 'TEN_TK');
    initLookup('#ma_spct', 'MA_SPCT', 'TEN_SPCT');
});
</script>
@endpush
```

## Ghi chú
- CORptGt01 là báo cáo giá thành tổng hợp với tùy chọn chi tiết theo vật tư
- Có checkbox "Chi tiết theo VT" để người dùng chọn mức độ chi tiết của báo cáo
- Khác với Gt02 và Gt03: Gt01 không tạo filter title
- Các control tháng/năm bị ẩn, chỉ sử dụng ngày
- Form size: 564, 285
