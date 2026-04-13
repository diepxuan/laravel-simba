# PORptBCPT03 - Bao Cao Phan Tich Chi Phi Thanh Pham

## 1. Thong tin chung

| Thuoc tinh | Gia tri |
|------------|---------|
| Ten DLL | PORptBCPT03 |
| Form chinh | frmPORptBCPT03 |
| Loai | Report |
| Module | PO (Purchasing) |
| Mo ta | Bao cao phan tich chi phi thanh pham |

## 2. Cau truc Form

### 2.1. Form Class

```csharp
public class frmPORptBCPT03 : frmReport
{
    // Ke thua tu frmReport
    // Form bao cao phan tich chi phi thanh pham
}
```

### 2.2. Controls tren Form

| Control | Type | Mo ta |
|---------|------|-------|
| txtNgay1 | AsMaskedTextBox | Tu ngay |
| txtNgay2 | AsMaskedTextBox | Den ngay |
| txtMa_ncc | AsTextBox | Ma nha cung cap |
| lblTen_ncc | Label | Ten nha cung cap |
| txtMa_nh_ncc | AsTextBox | Ma nhom NCC |
| lblTen_nh_ncc | Label | Ten nhom NCC |
| txtMa_vt | AsTextBox | Ma vat tu |
| lblTen_vt | Label | Ten vat tu |
| txtMa_nh_vt | AsTextBox | Ma nhom vat tu |
| lblTen_nh_vt | Label | Ten nhom vat tu |
| txtMa_kho | AsTextBox | Ma kho |
| lblTen_kho | Label | Ten kho |
| cboMau_bc | ComboBox | Mau bao cao |
| cmdOk | Button | Xem bao cao |
| cmdExcel | Button | Xuat Excel |

### 2.3. DataGridView Columns

| Column | DataPropertyName | Mo ta |
|--------|-----------------|-------|
| (Bao cao phan tich chi phi thanh pham) | - | - |

## 3. Stored Procedures

### 3.1. SP duoc goi

| SP Name | Parameters | Mo ta |
|---------|------------|-------|
| asPOGetBCPT03 | @Ma_dvcs, @Ngay1, @Ngay2, @Ma_ncc, @Ma_nh_ncc, @Ma_vt, @Ma_nh_vt, @Ma_kho | Lay du lieu bao cao phan tich chi phi thanh pham |

### 3.2. Parameters chi tiet

```sql
asPOGetBCPT03(
    @Ma_dvcs VARCHAR(20),      -- Ma don vi co so
    @Ngay1 DATETIME,            -- Tu ngay
    @Ngay2 DATETIME,            -- Den ngay
    @Ma_ncc VARCHAR(20),        -- Ma nha cung cap
    @Ma_nh_ncc VARCHAR(20),     -- Ma nhom nha cung cap
    @Ma_vt VARCHAR(20),         -- Ma vat tu
    @Ma_nh_vt VARCHAR(20),      -- Ma nhom vat tu
    @Ma_kho VARCHAR(20)         -- Ma kho
)
```

## 4. Business Logic

### 4.1. LoadData Method

```csharp
protected override bool LoadData()
{
    ArrayList arrayList = new ArrayList();
    arrayList.Add(CompanyInformations.CompanyID);  // Ma cong ty
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));  // Tu ngay
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));  // Den ngay
    arrayList.Add(((TextBox)txtMa_ncc).Text);      // Ma NCC
    arrayList.Add(((TextBox)txtMa_nh_ncc).Text);   // Ma nhom NCC
    arrayList.Add(((TextBox)txtMa_vt).Text);       // Ma vat tu
    arrayList.Add(((TextBox)txtMa_nh_vt).Text);    // Ma nhom vat tu
    arrayList.Add(((TextBox)txtMa_kho).Text);      // Ma kho
    
    set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
    base.MyFomularFields.Clear();
    base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
    return true;
}
```

### 4.2. Filter Title

```csharp
private string GetFilterTitle()
{
    string text = "";
    if (Operators.CompareString(((TextBox)txtMa_ncc).Text, "", false) != 0)
    {
        text = text + lblMa_ncc.Text + " : " + ((TextBox)txtMa_ncc).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_nh_ncc).Text, "", false) != 0)
    {
        text = text + lblMa_nh_ncc.Text + ": " + ((TextBox)txtMa_nh_ncc).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
    {
        text = text + lblMa_vt.Text + ": " + ((TextBox)txtMa_vt).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_nh_vt).Text, "", false) != 0)
    {
        text = text + lblMa_nh_vt.Text + ": " + ((TextBox)txtMa_nh_vt).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_kho).Text, "", false) != 0)
    {
        text = text + lblMa_kho.Text + ": " + ((TextBox)txtMa_kho).Text + "; ";
    }
    return text;
}
```

## 5. Mapping sang PHP

### 5.1. Controller (ReportController.php)

```php
<?php
namespace App\Http\Controllers\PO;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class BCPT03Controller extends Controller
{
    public function index()
    {
        return view('po.reports.bcpt03');
    }
    
    public function getData(Request $request)
    {
        $params = [
            'Ma_dvcs' => auth()->user()->company_id,
            'Ngay1' => $request->input('ngay1'),
            'Ngay2' => $request->input('ngay2'),
            'Ma_ncc' => $request->input('ma_ncc', ''),
            'Ma_nh_ncc' => $request->input('ma_nh_ncc', ''),
            'Ma_vt' => $request->input('ma_vt', ''),
            'Ma_nh_vt' => $request->input('ma_nh_vt', ''),
            'Ma_kho' => $request->input('ma_kho', '')
        ];
        
        $data = DB::select('EXEC asPOGetBCPT03 ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['Ma_dvcs'],
            $params['Ngay1'],
            $params['Ngay2'],
            $params['Ma_ncc'],
            $params['Ma_nh_ncc'],
            $params['Ma_vt'],
            $params['Ma_nh_vt'],
            $params['Ma_kho']
        ]);
        
        return response()->json($data);
    }
    
    public function exportExcel(Request $request)
    {
        // Xuat Excel
    }
}
```

### 5.2. View (bcpt03.blade.php)

```php
@extends('layouts.report')

@section('content')
<div class="report-filter">
    <form id="frmBCPT03">
        <div class="row">
            <div class="col-md-3">
                <label>Tu ngay</label>
                <input type="date" name="ngay1" class="form-control" required>
            </div>
            <div class="col-md-3">
                <label>Den ngay</label>
                <input type="date" name="ngay2" class="form-control" required>
            </div>
            <div class="col-md-3">
                <label>Ma NCC</label>
                <input type="text" name="ma_ncc" class="form-control lookup" data-lookup="MA_NCC">
            </div>
            <div class="col-md-3">
                <label>Ma vat tu</label>
                <input type="text" name="ma_vt" class="form-control lookup" data-lookup="MA_VT">
            </div>
        </div>
        <div class="row mt-3">
            <div class="col-md-12">
                <button type="button" class="btn btn-primary" id="btnView">Xem bao cao</button>
                <button type="button" class="btn btn-success" id="btnExcel">Xuat Excel</button>
            </div>
        </div>
    </form>
</div>

<div class="report-content mt-4">
    <table class="table table-bordered" id="tblBCPT03">
        <thead>
            <!-- Headers -->
        </thead>
        <tbody></tbody>
    </table>
</div>
@endsection

@section('scripts')
<script>
$(document).ready(function() {
    $('#btnView').click(function() {
        loadData();
    });
    
    function loadData() {
        $.ajax({
            url: '{{ route("po.bcpt03.data") }}',
            type: 'POST',
            data: $('#frmBCPT03').serialize(),
            success: function(response) {
                renderTable(response);
            }
        });
    }
});
</script>
@endsection
```

### 5.3. Routes

```php
Route::prefix('po')->group(function() {
    Route::get('/bcpt03', [BCPT03Controller::class, 'index'])->name('po.bcpt03');
    Route::post('/bcpt03/data', [BCPT03Controller::class, 'getData'])->name('po.bcpt03.data');
    Route::post('/bcpt03/excel', [BCPT03Controller::class, 'exportExcel'])->name('po.bcpt03.excel');
});
```

## 6. Luu y chuyen doi

1. **Lookup fields**: Su dung component lookup chung cho cac truong MA_NCC, MA_VT, MA_KHO
2. **Date format**: Chuyen doi format ngay tu VB sang PHP (YYYY-MM-DD)
3. **Currency**: Xu ly tien te V