# PORptBK02 - Bao Cao Bien Dong Kho 02

## 1. Thong tin chung

| Thuoc tinh | Gia tri |
|------------|---------|
| Ten DLL | PORptBK02 |
| Form chinh | frmPORptBK02 |
| Loai | Report |
| Module | PO (Purchasing) |
| Mo ta | Bao cao bien dong kho 02 - Bao cao nhap xuat ton chi tiet |

## 2. Cau truc Form

### 2.1. Form Class

```csharp
public class frmPORptBK02 : frmReport
{
    // Ke thua tu frmReport
    // Form bao cao bien dong kho 02
}
```

### 2.2. Controls tren Form

| Control | Type | Mo ta |
|---------|------|-------|
| txtNgay1 | AsMaskedTextBox | Tu ngay |
| txtNgay2 | AsMaskedTextBox | Den ngay |
| cboKyBc | ComboBox | Ky bao cao |
| txtMa_ncc | AsTextBox | Ma nha cung cap |
| txtMa_nh_ncc | AsTextBox | Ma nhom NCC |
| txtMa_vt | AsTextBox | Ma vat tu |
| txtMa_nh_vt | AsTextBox | Ma nhom vat tu |
| txtMa_kho | AsTextBox | Ma kho |
| txtMa_hd | AsTextBox | Ma hop dong |
| txtMa_nhhd | AsTextBox | Ma nhom hop dong |
| txtPl_ncc1-3 | AsTextBox | Phan loai NCC |
| txtMaPhi | AsTextBox | Ma phi |
| txtMa_spct | AsTextBox | Ma san pham cong trinh |
| txtMA_HTTT | AsTextBox | Ma hinh thuc thanh toan |
| txtMA_DKTT | AsTextBox | Ma dieu khoan thanh toan |
| txtMaLo | AsTextBox | Ma lo |
| txtMa_vtri | AsTextBox | Ma vi tri |

### 2.3. Lookup Codes

| Control | LookupCodeName | LookupWhereCondition |
|---------|---------------|---------------------|
| txtMa_ncc | MA_NCC | isNcc=1 |
| txtMa_nh_ncc | MA_NHKH | - |
| txtMa_vt | MA_VT | - |
| txtMa_nh_vt | MA_NHVT | - |
| txtMa_kho | MA_KHO | - |
| txtMa_hd | MA_HD | - |
| txtMa_nhhd | MA_NHHD | - |
| txtPl_ncc1-3 | MA_PLKH | loai = 1/2/3 |
| txtMaPhi | MA_PHI | - |
| txtMa_spct | MA_SPCT | - |
| txtMA_HTTT | MA_HTTT | moduleid='po' |
| txtMA_DKTT | MA_TT_PO | - |
| txtMaLo | MA_LO | - |
| txtMa_vtri | MA_VITRI | - |

## 3. Stored Procedures

### 3.1. SP duoc goi

| SP Name | Parameters | Mo ta |
|---------|------------|-------|
| asPOGetBK02 | @Ma_dvcs, @Ngay1, @Ngay2, @Ma_ncc, @Ma_nh_ncc, @Ma_vt, @Ma_nh_vt, @Ma_kho, @Ma_hd, @Ma_nhhd, @Pl_ncc1, @Pl_ncc2, @Pl_ncc3, @Ma_phi, @Ma_spct, @Ma_HTTT, @Ma_DKTT, @Ma_lo, @Ma_vitri, @Ma_nt | Lay du lieu bao cao bien dong kho 02 |

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
    arrayList.Add(((TextBox)txtMa_vt).Text);
    arrayList.Add(((TextBox)txtMa_nh_vt).Text);
    arrayList.Add(((TextBox)txtMa_kho).Text);
    arrayList.Add(((TextBox)txtMa_hd).Text);
    arrayList.Add(((TextBox)txtMa_nhhd).Text);
    arrayList.Add(((TextBox)txtPl_ncc1).Text);
    arrayList.Add(((TextBox)txtPl_ncc2).Text);
    arrayList.Add(((TextBox)txtPl_ncc3).Text);
    arrayList.Add(((TextBox)txtMaPhi).Text);
    arrayList.Add(((TextBox)txtMa_spct).Text);
    arrayList.Add(((TextBox)txtMA_HTTT).Text);
    arrayList.Add(((TextBox)txtMA_DKTT).Text);
    arrayList.Add(((TextBox)txtMaLo).Text);
    arrayList.Add(((TextBox)txtMa_vtri).Text);
    arrayList.Add(((TextBox)txtMa_Nt).Text);
    
    set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
    base.MyFomularFields.Clear();
    base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
    return true;
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

class BK02Controller extends Controller
{
    public function getData(Request $request)
    {
        $data = DB::select('EXEC asPOGetBK02 ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', [
            auth()->user()->company_id,
            $request->input('ngay1'),
            $request->input('ngay2'),
            $request->input('ma_ncc', ''),
            $request->input('ma_nh_ncc', ''),
            $request->input('ma_vt', ''),
            $request->input('ma_nh_vt', ''),
            $request->input('ma_kho', ''),
            $request->input('ma_hd', ''),
            $request->input('ma_nhhd', ''),
            $request->input('pl_ncc1', ''),
            $request->input('pl_ncc2', ''),
            $request->input('pl_ncc3', ''),
            $request->input('ma_phi', ''),
            $request->input('ma_spct', ''),
            $request->input('ma_httt', ''),
            $request->input('ma_dktt', ''),
            $request->input('ma_lo', ''),
            $request->input('ma_vitri', ''),
            $request->input('ma_nt', '')
        ]);
        
        return response()->json($data);
    }
}
```

## 6. Luu y

- BK02 co nhieu tham so loc hon BK01
- Co them loc theo Hinh thuc TT, Dieu khoan TT, Ma lo, Ma vi tri
