# PORptTH02 - Bao Cao Tong Hop 02

## 1. Thong tin chung

| Thuoc tinh | Gia tri |
|------------|---------|
| Ten DLL | PORptTH02 |
| Form chinh | frmPORptTH02 |
| Loai | Report |
| Module | PO (Purchasing) |
| Mo ta | Bao cao tong hop mua hang theo ky (thang/quy/nam) |

## 2. Cau truc Form

### 2.1. Form Class

```csharp
public class frmPORptTH02 : frmReport
{
    // Ke thua tu frmReport
    // Form bao cao tong hop theo ky
}
```

### 2.2. Controls tren Form

| Control | Type | Mo ta |
|---------|------|-------|
| cboLoai | ComboBox | Loai thoi gian (Thang/Quy/Nam) |
| cboLoaiPhieu | AsComboBox | Loai phieu |
| cboLoai_ct | ComboBox | Loai chung tu |
| txtTu_thang | AsTextNumeric | Tu thang |
| txtSo_ky | AsTextNumeric | So ky |
| txtNam | AsTextNumeric | Nam |
| txtMa_Nt | AsTextBox | Ma ngoai te |
| optVND | RadioButton | Tien VND |
| optNt | RadioButton | Tien ngoai te |

### 2.3. Constants

```csharp
private const string THANG = "THANG";
private const string QUY = "QUY";
private const string NAM = "NAM";
```

### 2.4. Loai thoi gian Options

| Value | Display |
|-------|---------|
| THANG | Theo thang |
| QUY | Theo quy |
| NAM | Theo nam |

### 2.5. Loai phieu Options

| Value | Display |
|-------|---------|
| - | Tat ca |
| PO1 | Phieu de nghi mua hang |
| PO2 | Don hang mua |
| PO3 | Phieu nhap mua |
| PO4 | Hoa don mua hang |
| PO5 | Phieu chi phi mua hang |
| PO6 | Phieu xuat tra lai NCC |
| PO7 | Hoa don mua dich vu |
| PO8 | Hoa don mua hang nhap khau |

## 3. Stored Procedures

### 3.1. SP duoc goi

| SP Name | Parameters | Mo ta |
|---------|------------|-------|
| asPOGetTH02 | @Ma_dvcs, @Loai, @Loai_phieu, @Tu_thang, @Nam, @So_ky, @Ma_nt, @Is_nt | Lay du lieu bao cao tong hop theo ky |

## 4. Business Logic

### 4.1. InitOtherComponents

```csharp
protected override void InitOtherComponents()
{
    base.InitOtherComponents();
    
    // Setup loai thoi gian
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    ComboBox val = cboLoai;
    dictionary.Add("THANG", Conversions.ToString(val.Items[0]));
    dictionary.Add("QUY", Conversions.ToString(val.Items[1]));
    dictionary.Add("NAM", Conversions.ToString(val.Items[2]));
    
    BindingSource dataSource = new BindingSource((object)dictionary, (string)null);
    val.DataSource = dataSource;
    ((ListControl)val).DisplayMember = "value";
    ((ListControl)val).ValueMember = "key";
    val.SelectedIndex = 0;
    
    // Load loai phieu
    ArrayList arrayList = new ArrayList();
    arrayList.Add(CompanyInformations.CompanyID);
    arrayList.Add(MyMenuInfo.moduleid);
    arrayList.Add("0");
    arrayList.Add(SystemInformations.CurrentCultureName);
    
    ArrayList arrayList2 = CBO<lstVoucherInfo>.FillCollection(
        Commons.GetDataReader("asSIGetDmSo_ct", arrayList.ToArray())
    );
    arrayList2.Add(new lstVoucherInfo("", AsiaErp.Framework.Environment.getLangSysMessageResX("#SYS_ALL").value));
    
    ((ComboBox)cboLoaiPhieu).DataSource = arrayList2;
    ((ListControl)cboLoaiPhieu).DisplayMember = "TEN_CT";
    ((ListControl)cboLoaiPhieu).ValueMember = "MA_CT";
    ((ListControl)cboLoaiPhieu).SelectedValue = base.MyReportInfo.par0;
    
    // Set nam mac dinh
    ((TextBox)txtNam).Text = Conversions.ToString(SystemInformations.FinancialYear);
}
```

### 4.2. LoadData Method

```csharp
protected override bool LoadData()
{
    ArrayList arrayList = new ArrayList();
    arrayList.Add(CompanyInformations.CompanyID);
    arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoai).SelectedValue));
    arrayList.Add(RuntimeHelpers.GetObjectValue(((ListControl)cboLoaiPhieu).SelectedValue));
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtTu_thang.Value));
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNam.Value));
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtSo_ky.Value));
    arrayList.Add(((TextBox)txtMa_Nt).Text);
    arrayList.Add(optNt.Checked);
    
    DataSet dataSet = new DataSet();
    dataSet = base.MyController.GetDataSet(arrayList.ToArray());
    
    set_MyDGVSource(isSet2Print: true, dataSet.Tables[1]);
    base.MyCrystalSource = dataSet.Tables[0];
    base.MyFomularFields.Clear();
    base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
    
    return true;
}
```

### 4.3. Validation

```csharp
protected override bool ValidData()
{
    // Validate tu thang
    if (Operators.ConditionalCompareObjectLess(txtTu_thang.Value, (object)1, false))
    {
        epNotice.SetError((Control)(object)txtTu_thang, Helper.GetMessContent(50034));
        ((Control)txtTu_thang).Focus();
        return false;
    }
    
    // Validate nam (1900-2079)
    if (Conversions.ToBoolean(Operators.OrObject(
        Operators.CompareObjectLess(txtNam.Value, (object)1900, false), 
        Operators.CompareObjectGreater(txtNam.Value, (object)2079, false)
    )))
    {
        epNotice.SetError((Control)(object)txtNam, Helper.GetMessContent(50034));
        ((Control)txtNam).Focus();
        return false;
    }
    
    // Validate so ky
    if (Operators.ConditionalCompareObjectLess(txtSo_ky.Value, (object)1, false))
    {
        epNotice.SetError((Control)(object)txtSo_ky, Helper.GetMessContent(50034));
        ((Control)txtSo_ky).Focus();
        return false;
    }
    
    return base.ValidData();
}

private bool ValidateSoKy()
{
    bool flag = false;
    object selectedValue = ((ListControl)cboLoai).SelectedValue;
    
    if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"THANG", false))
    {
        flag = Conversions.ToBoolean(Operators.AndObject(
            Operators.CompareObjectGreaterEqual(txtSo_ky.Value, (object)1, false),
            Operators.CompareObjectLessEqual(txtSo_ky.Value, (object)12, false)
        ));
    }
    else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"QUY", false))
    {
        flag = Conversions.ToBoolean(Operators.AndObject(
            Operators.CompareObjectGreaterEqual(txtSo_ky.Value, (object)1, false),
            Operators.CompareObjectLessEqual(txtSo_ky.Value, (object)4, false)
        ));
    }
    else if (Operators.ConditionalCompareObjectEqual(selectedValue, (object)"NAM", false))
    {
        flag = Operators.ConditionalCompareObjectEqual(txtSo_ky.Value, (object)1, false);
    }
    
    if (!flag)
    {
        SetControlError((Control)(object)txtSo_ky, Helper.GetMessContent(50034));
    }
    
    return flag;
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
use Illuminate\Support\Facades\Validator;

class TH02Controller extends Controller
{
    public function index()
    {
        return view('po.reports.th02');
    }
    
    public function getData(Request $request)
    {
        // Validation
        $validator = Validator::make($request->all(), [
            'loai' => 'required|in:THANG,QUY,NAM',
            'tu_thang' => 'required|integer|min:1',
            'nam' => 'required|integer|between:1900,2079',
            'so_ky' => 'required|integer|min:1'
        ]);
        
        if ($validator->fails()) {
            return response()->json(['errors' => $validator->errors()], 422);
        }
        
        // Validate so ky theo loai
        $maxKy = match($request->loai) {
            'THANG' => 12,
            'QUY' => 4,
            'NAM' => 1,
            default => 12
        };
        
        if ($request->so_ky > $maxKy) {
            return response()->json([
                'error' => "So ky toi da cho {$request->loai} la {$maxKy}"
            ], 422);
        }
        
        $data = DB::