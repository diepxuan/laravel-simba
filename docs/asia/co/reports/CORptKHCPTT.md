# CoRptKHCPTT

## Tổng quan
- **Module**: CO (Cost)
- **Loại**: Report
- **Chức năng**: Báo cáo kế hoạch chi phí thành phẩm (KHCPTT - Ke Hoach Chi Phi Thanh Pham)

## Forms

### frmCoRptCTPBCPTT.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo kế hoạch chi phí thành phẩm

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMa_bpsd | AsTextBox | MA_BPSD | AutoLookup |
| lblTen_bpsd | Label | Hiển thị tên BPSD | - |
| lblMa_bpsd | Label | Label "Mã BPSD" | - |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu | - |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc | - |
| cboKyBc | ComboBox | Kỳ báo cáo | - |
| cboMau_bc | ComboBox | Mẫu báo cáo | - |
| txtTieu_De | TextBox | Tiêu đề báo cáo | - |
| cmdOk | Button | Thực hiện báo cáo | - |
| cmdCancel | Button | Hủy | - |
| cmdExcel | Button | Xuất Excel | - |
| cmdModifyReport | Button | Sửa báo cáo | - |
| lblTieu_de | Label | Label "Tiêu đề" | - |
| lblKyBc | Label | Label "Kỳ báo cáo" | - |
| lblMau_bc | Label | Label "Mẫu báo cáo" | - |
| lbl2 | Label | Label "-" (ẩn) | - |
| lblMauBC | Label | Label mẫu BC (ẩn) | - |
| lblMa_nt | Label | Label mã NT (ẩn) | - |
| optVND | RadioButton | Loại tiền VND (ẩn) | - |
| optNt | RadioButton | Loại tiền ngoại tệ (ẩn) | - |
| txtMa_Nt | AsTextBox | Mã ngoại tệ (ẩn) | - |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| sTabName | string | Tên tab |
| sMenuID | string | Menu ID |
| DataLoading | bool | Trạng thái loading dữ liệu |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo với try-catch xử lý lỗi |
| GetFilterTitle | - | string | Tạo chuỗi mô tả điều kiện lọc |
| InitializeComponent | - | void | Khởi tạo UI |

## Data Access

### LoadData Method
```csharp
protected override bool LoadData()
{
    try
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(CompanyInformations.CompanyID);
        arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay1.Value)));
        arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay2.Value)));
        arrayList.Add(((TextBox)txtMa_bpsd).Text);
        set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
    }
    catch (Exception ex)
    {
        ProjectData.SetProjectError(ex);
        Exception ex2 = ex;
        Interaction.MsgBox((object)("Lỗi lọc  dữ liệu: " + ex2.Message), (MsgBoxStyle)48, (object)"Thông báo");
        ProjectData.ClearProjectError();
    }
    return true;
}
```

### GetFilterTitle Method
```csharp
private string GetFilterTitle()
{
    string text = "";
    if (Operators.CompareString(((TextBox)txtMa_bpsd).Text.Trim(), "", false) != 0)
    {
        text = text + "Bộ phận sử dụng:" + lblTen_bpsd.Text + ";";
    }
    return text;
}
```

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| (Từ base.MyController.GetData) | Lấy dữ liệu kế hoạch chi phí | @CompanyID, @Ngay1, @Ngay2, @Ma_bpsd | DataTable |

## Business Logic

### Luồng xử lý chính
1. User nhập điều kiện lọc (BPSD - optional)
2. Chọn kỳ báo cáo và mẫu báo cáo
3. Click cmdOk để thực hiện báo cáo
4. LoadData() lấy dữ liệu với xử lý lỗi try-catch
5. Dữ liệu được truyền vào DataGridView để hiển thị
6. Có thể xuất Excel hoặc in báo cáo

### Error Handling
- Sử dụng try-catch để bắt lỗi khi load dữ liệu
- Hiển thị MessageBox với thông báo "Lỗi lọc dữ liệu: [message]"
- Luôn return true dù có lỗi hay không

### Filter logic
- Chỉ có 1 điều kiện lọc chính: Mã BPSD (optional)
- Ngày bắt đầu và kết thúc qua txtNgay1, txtNgay2

### Filter Title Generation
- Nếu có nhập BPSD: hiển thị "Bộ phận sử dụng: [Tên BPSD]"

### Lookup codes
| Field | LookupCodeName | Description |
|-------|----------------|-------------|
| txtMa_bpsd | MA_BPSD | Mã bộ phận sử dụng |

### Filter params
| Param | Source | Description |
|-------|--------|-------------|
| @CompanyID | CompanyInformations.CompanyID | Mã công ty |
| @Ngay1 | txtNgay1.Value | Ngày bắt đầu |
| @Ngay2 | txtNgay2.Value | Ngày kết thúc |
| @Ma_bpsd | txtMa_bpsd.Text | Mã bộ phận sử dụng |

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| CODMBPSD | Danh mục bộ phận sử dụng | R |
| (Table kế hoạch chi phí) | Dữ liệu kế hoạch chi phí | R |

## Mapping sang PHP

### Controller
```php
class CoRptKHCPTTController extends ReportController {
    public function index() {
        return view('co.reports.khcptt');
    }
    
    public function getData(Request $request) {
        try {
            $params = [
                $request->company_id,
                $request->ngay1,
                $request->ngay2,
                $request->ma_bpsd ?? ''
            ];
            
            $data = DB::select('EXEC sp_CoRptKHCPTT ?, ?, ?, ?', $params);
            
            return response()->json([
                'success' => true,
                'data' => $data
            ]);
        } catch (Exception $e) {
            return response()->json([
                'success' => false,
                'message' => 'Lỗi lọc dữ liệu: ' . $e->getMessage()
            ], 500);
        }
    }
}
```

### Repository
```php
class CoRptKHCPTTRepository {
    public function getKeHoachChiPhi($filters) {
        try {
            return DB::table('co_ke_hoach_chi_phi')
                ->where('company_id', $filters['company_id'])
                ->whereBetween('ngay', [$filters['ngay1'], $filters['ngay2']])
                ->when(!empty($filters['ma_bpsd']), function($q) use ($filters) {
                    $q->where('ma_bpsd', $filters['ma_bpsd']);
                })
                ->orderBy('ma_bpsd')
                ->orderBy('ma_cp')
                ->get();
        } catch (Exception $e) {
            Log::error('Error in CoRptKHCPTTRepository: ' . $e->getMessage());
            throw $e;
        }
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
            <x-lookup name="ma_bpsd" code="MA_BPSD" label="Mã BPSD" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <x-date-range name="ngay" label="Kỳ báo cáo" required="true" />
        </div>
        <div class="col-md-6">
            <x-select name="mau_bc" label="Mẫu báo cáo" :options="$mauBaoCaos" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <x-input name="tieu_de" label="Tiêu đề" />
        </div>
    </div>
</form>

<div id="reportContainer">
    <div class="filter-title" id="filterTitle"></div>
    <div id="errorMessage" class="alert alert-danger" style="display:none;"></div>
    <table id="reportTable" class="table table-bordered">
        <!-- Data will be loaded here -->
    </table>
</div>
@endsection

@push('scripts')
<script>
$(document).ready(function() {
    initLookup('#ma_bpsd', 'MA_BPSD', 'TEN_BPSD');
    
    $('#filterForm').on('submit', function(e) {
        e.preventDefault();
        loadReportData();
    });
});

function loadReportData() {
    $('#errorMessage').hide();
    
    $.ajax({
        url: '/co/reports/khcptt/data',
        data: $('#filterForm').serialize(),
        success: function(response) {
            if (response.success) {
                renderTable(response.data);
            } else {
                $('#errorMessage').text(response.message).show();
            }
        },
        error: function(xhr) {
            var message = xhr.responseJSON?.message || 'Lỗi không xác định';
            $('#errorMessage').text(message).show();
        }
    });
}
</script>
@endpush
```

## Ghi chú
- Báo cáo kế hoạch chi phí thành phẩm là báo cáo đơn giản với ít filter
- Chỉ có 1 điều kiện lọc chính: Mã BPSD
- Có xử lý lỗi try-catch khi load dữ liệu
- Form kế thừa từ frmReport nên sử dụng các chức năng cơ bản của báo cáo
- Các control tiền tệ (optVND, optNt, txtMa_Nt) bị ẩn
- Kích thước form lớn: 821, 579
