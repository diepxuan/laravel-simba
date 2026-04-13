# PORptBK01 - Bao Cao Bien Dong Kho 01

## 1. Thong tin chung

| Thuoc tinh | Gia tri |
|------------|---------|
| Ten DLL | PORptBK01 |
| Form chinh | frmPORptBK01 |
| Loai | Report |
| Module | PO (Purchasing) |
| Mo ta | Bao cao bien dong kho 01 - Bao cao nhap xuat ton |

## 2. Cau truc Form

### 2.1. Form Class

```csharp
public class frmPORptBK01 : frmReport
{
    // Ke thua tu frmReport
    // Form bao cao bien dong kho 01
}
```

### 2.2. Controls tren Form

| Control | Type | Mo ta |
|---------|------|-------|
| txtNgay1 | AsMaskedTextBox | Tu ngay |
| txtNgay2 | AsMaskedTextBox | Den ngay |
| cboKyBc | ComboBox | Ky bao cao |
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
| txtMa_hd | AsTextBox | Ma hop dong |
| lblTen_hd | Label | Ten hop dong |
| txtMa_nhhd | AsTextBox | Ma nhom hop dong |
| lblTen_Nhhd | Label | Ten nhom hop dong |
| txtPl_ncc1 | AsTextBox | Phan loai NCC 1 |
| txtPl_ncc2 | AsTextBox | Phan loai NCC 2 |
| txtPl_ncc3 | AsTextBox | Phan loai NCC 3 |
| txtMaPhi | AsTextBox | Ma phi |
| lblTenPhi | Label | Ten phi |
| txtMa_spct | AsTextBox | Ma san pham cong trinh |
| lblTen_spct | Label | Ten san pham cong trinh |
| cboMau_bc | ComboBox | Mau bao cao |
| optVND | RadioButton | Tien VND |
| optNt | RadioButton | Tien ngoai te |

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
| txtPl_ncc1 | MA_PLKH | loai = 1 |
| txtPl_ncc2 | MA_PLKH | loai = 2 |
| txtPl_ncc3 | MA_PLKH | loai = 3 |
| txtMaPhi | MA_PHI | - |
| txtMa_spct | MA_SPCT | - |

## 3. Stored Procedures

### 3.1. SP duoc goi

| SP Name | Parameters | Mo ta |
|---------|------------|-------|
| asPOGetBK01 | @Ma_dvcs, @Ngay1, @Ngay2, @Ma_ncc, @Ma_nh_ncc, @Ma_vt, @Ma_nh_vt, @Ma_kho, @Ma_hd, @Ma_nhhd, @Pl_ncc1, @Pl_ncc2, @Pl_ncc3, @Ma_phi, @Ma_spct, @Ma_nt | Lay du lieu bao cao bien dong kho 01 |

### 3.2. Parameters chi tiet

```sql
asPOGetBK01(
    @Ma_dvcs VARCHAR(20),      -- Ma don vi co so
    @Ngay1 DATETIME,            -- Tu ngay
    @Ngay2 DATETIME,            -- Den ngay
    @Ma_ncc VARCHAR(20),        -- Ma nha cung cap
    @Ma_nh_ncc VARCHAR(20),     -- Ma nhom nha cung cap
    @Ma_vt VARCHAR(20),         -- Ma vat tu
    @Ma_nh_vt VARCHAR(20),      -- Ma nhom vat tu
    @Ma_kho VARCHAR(20),        -- Ma kho
    @Ma_hd VARCHAR(20),         -- Ma hop dong
    @Ma_nhhd VARCHAR(20),       -- Ma nhom hop dong
    @Pl_ncc1 VARCHAR(20),       -- Phan loai NCC 1
    @Pl_ncc2 VARCHAR(20),       -- Phan loai NCC 2
    @Pl_ncc3 VARCHAR(20),       -- Phan loai NCC 3
    @Ma_phi VARCHAR(20),        -- Ma phi
    @Ma_spct VARCHAR(20),       -- Ma san pham cong trinh
    @Ma_nt VARCHAR(20)          -- Ma ngoai te
)
```

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
    arrayList.Add(((TextBox)txtMa_Nt).Text);
    
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
    if (Operators.CompareString(((TextBox)txtPl_ncc1).Text, "", false) != 0)
    {
        text = text + lblPl_ncc1.Text + ": " + ((TextBox)txtPl_ncc1).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtPl_ncc2).Text, "", false) != 0)
    {
        text = text + lblPl_ncc2.Text + ": " + ((TextBox)txtPl_ncc2).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtPl_ncc3).Text, "", false) != 0)
    {
        text = text + lblPl_ncc3.Text + ": " + ((TextBox)txtPl_ncc3).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_hd).Text, "", false) != 0)
    {
        text = text + lblMa_hd.Text + ": " + ((TextBox)txtMa_hd).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_nhhd).Text.Trim(), "", false) != 0)
    {
        text = text + lblMa_nhhd.Text + ": " + ((TextBox)txtMa_nhhd).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_kho).Text, "", false) != 0)
    {
        text = text + lblMa_kho.Text + ": " + ((TextBox)txtMa_kho).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_vt).Text, "", false) != 0)
    {
        text = text + lblMa_vt.Text + ": " + ((TextBox)txtMa_vt).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_nh_vt).Text, "", false) != 0)
    {
        text = text + lblMa_nh_vt.Text + ": " + ((TextBox)txtMa_nh_vt).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMaPhi).Text.Trim(), "", false) != 0)
    {
        text = text + lblTenPhi.Text + ": " + ((TextBox)txtMaPhi).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_spct).Text.Trim(), "", false) != 0)
    {
        text = text + lblTen_spct.Text + ": " + ((TextBox)txtMa_spct).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_Nt).Text, "", false) != 0)
    {
        text = text + lblMa_nt.Text + ": " + ((TextBox)txtMa_Nt).Text + "; ";
    }
    return text;
}
```

## 5. Mapping sang PHP

### 5.1. Controller (BK01Controller.php)

```php
<?php
namespace App\Http\Controllers\PO;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class BK01Controller extends Controller
{
    public function index()
    {
        return view('po.reports.bk01');
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
            'Ma_kho' => $request->input('ma_kho', ''),
            'Ma_hd' => $request->input('ma_hd', ''),
            'Ma_nhhd' => $request->input('ma_nhhd', '