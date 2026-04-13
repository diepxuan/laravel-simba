# PORptTH03 - Bao Cao Tong Hop 03

## 1. Thong tin chung

| Thuoc tinh | Gia tri |
|------------|---------|
| Ten DLL | PORptTH03 |
| Form chinh | frmPORptTH03 |
| Loai | Report |
| Module | PO (Purchasing) |
| Mo ta | Bao cao tong hop mua hang theo nha cung cap |

## 2. Cau truc Form

### 2.1. Form Class

```csharp
public class frmPORptTH03 : frmReport
{
    // Ke thua tu frmReport
    // Form bao cao tong hop theo nha cung cap
}
```

### 2.2. Controls tren Form

| Control | Type | Mo ta |
|---------|------|-------|
| txtNgay1 | AsMaskedTextBox | Tu ngay |
| txtNgay2 | AsMaskedTextBox | Den ngay |
| txtCT1 | TextBox | Chung tu so tu |
| txtCT2 | TextBox | Chung tu so den |
| txtMa_ncc | AsTextBox | Ma nha cung cap |
| txtMa_nh_ncc | AsTextBox | Ma nhom NCC |
| txtPl_ncc1-3 | AsTextBox | Phan loai NCC |
| txtMa_hd | AsTextBox | Ma hop dong |
| txtMa_nhhd | AsTextBox | Ma nhom hop dong |
| txtMa_kho | AsTextBox | Ma kho |
| txtMa_vtri | AsTextBox | Ma vi tri |
| txtMa_vt | AsTextBox | Ma vat tu |
| txtMa_nh_vt | AsTextBox | Ma nhom vat tu |
| txtMa_spct | AsTextBox | Ma san pham cong trinh |
| txtMaPhi | AsTextBox | Ma phi |
| txtMA_HTTT | AsTextBox | Ma hinh thuc thanh toan |
| txtMA_DKTT | AsTextBox | Ma dieu khoan thanh toan |
| txtMaLo | AsTextBox | Ma lo |
| txtMa_Plvt1-3 | AsTextBox | Phan loai vat tu |
| txtMa_Nt | AsTextBox | Ma ngoai te |
| optVND | RadioButton | Tien VND |
| optNt | RadioButton | Tien ngoai te |

## 3. Stored Procedures

### 3.1. SP duoc goi

| SP Name | Parameters | Mo ta |
|---------|------------|-------|
| asPOGetTH03 | @Ma_dvcs, @Ngay1, @Ngay2, @Ma_ncc, @Ma_nh_ncc, @Pl_ncc1, @Pl_ncc2, @Pl_ncc3, @Ma_hd, @Ma_kho, @Ma_vtri, @Ma_vt, @Ma_nh_vt, @Ma_nt, @Ma_nhhd, @Ma_Plvt1, @Ma_Plvt2, @Ma_plvt3, @Ma_lo, @Ma_phi, @Ma_HTTT, @Ma_DKTT, @Ma_spct, @So_ct1, @So_ct2 | Lay du lieu bao cao tong hop 03 |

## 4. Business Logic

### 4.1. LoadData Method

```csharp
protected override bool LoadData()
{
    ArrayList arrayList = new ArrayList();
    arrayList.Add(CompanyInformations.CompanyID);
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
    arrayList.Add(((TextBox)txtMa_ncc).Text);
    arrayList.Add(((TextBox)txtMa_nh_ncc).Text);
    arrayList.Add(((TextBox)txtPl_ncc1).Text);
    arrayList.Add(((TextBox)txtPl_ncc2).Text);
    arrayList.Add(((TextBox)txtPl_ncc3).Text);
    arrayList.Add(((TextBox)txtMa_hd).Text);
    arrayList.Add(((TextBox)txtMa_kho).Text);
    arrayList.Add(((TextBox)txtMa_vtri).Text);
    arrayList.Add(((TextBox)txtMa_vt).Text);
    arrayList.Add(((TextBox)txtMa_nh_vt).Text);
    arrayList.Add(((TextBox)txtMa_Nt).Text);
    arrayList.Add(((TextBox)txtMa_nhhd).Text);
    arrayList.Add(((TextBox)txtMa_Plvt1).Text);
    arrayList.Add(((TextBox)txtMa_Plvt2).Text);
    arrayList.Add(((TextBox)txtMa_plvt3).Text);
    arrayList.Add(((TextBox)txtMaLo).Text);
    arrayList.Add(((TextBox)txtMaPhi).Text);
    arrayList.Add(((TextBox)txtMA_HTTT).Text);
    arrayList.Add(((TextBox)txtMA_DKTT).Text);
    arrayList.Add(((TextBox)txtMa_spct).Text);
    arrayList.Add(txtCT1.Text);
    arrayList.Add(txtCT2.Text);
    
    set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
    base.MyFomularFields.Clear();
    base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
    
    return true;
}
```

### 4.2. Drilldown

```csharp
protected override ArrayList CreateDrilldownArgument(
    ReportDrillDownInfo drilldownInfo, 
    ref string sDrilldownMenuId, 
    Keys keycode, 
    Keys modifierKeys, 
    ref string filterCondition4title, 
    [Optional][DefaultParameterValue(null)] ref object datasource
)
{
    DataRowView dataRowView = get_MyDGVSource(isSet2Print: true).DefaultView[
        ((DataGridViewBand)((DataGridView)base.dgvBC).CurrentRow).Index
    ];
    
    if ((int)keycode != 116 || 
        (Operators.ConditionalCompareObjectEqual(
            Helper.Repl_Null(RuntimeHelpers.GetObjectValue(dataRowView["ma_vt"]), isNum: false), 
            (object)"", 
            false
        ) ? true : false))
    {
        base.CancelDrilldown = true;
        return null;
    }
    
    ArrayList arrayList = new ArrayList();
    arrayList.Add(CompanyInformations.CompanyID);
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
    arrayList.Add(MyMenuInfo.par1);
    arrayList.Add(((TextBox)txtMa_ncc).Text);
    arrayList.Add(((TextBox)txtMa_nh_ncc).Text);
    arrayList.Add(((TextBox)txtPl_ncc1).Text);
    arrayList.Add(((TextBox)txtPl_ncc2).Text);
    arrayList.Add(((TextBox)txtPl_ncc3).Text);
    arrayList.Add(RuntimeHelpers.GetObjectValue(dataRowView["Ma_vt"]));
    arrayList.Add(((TextBox)txtMa_nh_vt).Text);
    arrayList.Add("");
    arrayList.Add("");
    arrayList.Add("");
    arrayList.Add("");
    arrayList.Add(((TextBox)txtMa_kho).Text);
    arrayList.Add("");
    arrayList.Add("");
    arrayList.Add(((TextBox)txtMa_hd).Text);
    arrayList.Add("");
    arrayList.Add("");
    arrayList.Add(((TextBox)txtMa_vtri).Text);
    arrayList.Add(((TextBox)txtMa_Nt).Text);
    
    if (Information.IsDBNull((object)arrayList))
    {
        base.CancelDrilldown = true;
        return null;
    }
    
    filterCondition4title = dataRowView["ma_vt"].ToString() + ": " + dataRowView["ten_vt"].ToString();
    
    return arrayList;
}
```

## 5. Mapping sang PHP

### 5.1. Controller

```php
<?php
namespace App\Http\Controllers\PO;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class TH03Controller extends Controller
{
    public function index()
    {
        return view('po.reports.th03');
    }
    
    public function getData(Request $request)
    {
        $data = DB::select('EXEC asPOGetTH03 ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', [
            auth()->user()->company_id,
            $request->input('ngay1'),
            $request->input('ngay2'),
            $request->input('ma_ncc', ''),
            $request->input('ma_nh_ncc', ''),
            $request->input('pl_ncc1', ''),
            $request->input('pl_ncc2', ''),
            $request->input('pl_ncc3', ''),
            $request->input('ma_hd', ''),
            $request->input('ma_kho', ''),
            $request->input('ma_vtri', ''),
            $request->input('ma_vt', ''),
            $request->input('ma_nh_vt', ''),
            $request->input('ma_nt', ''),
            $request->input('ma_nhhd', ''),
            $request->input('ma_plvt1', ''),
            $request->input('ma_plvt2', ''),
            $request->input('ma_plvt3', ''),
            $request->input('ma_lo', ''),
            $request->input('ma_phi', ''),
            $request->input('ma_httt', ''),
            $request->input('ma_dktt', ''),
            $request->input('ma_spct', ''),
            $request->input('so_ct1', ''),
            $request->input('so_ct2', '')
        ]);
        
        return response()->json($data);
    }
    
    public function drilldown(Request $request)
    {
        // Xu ly drilldown khi nhan F5
        $params = $request->input('params');
        
        $data = DB::select('EXEC asPOGetTH03Detail ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', [
            // Tham so drilldown
        ]);
        
        return response()->json($data);
    }
}
```

## 6. Luu y

- TH03 co them loc theo so chung tu (tu so - den so)
- Ho tro drilldown xem chi tiet theo vat tu
- Bao cao tong hop theo nha cung cap
