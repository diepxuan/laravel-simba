# FARptBCPT01.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FARptBCPT01.dll |
| **Form Class** | frmFARptBCPT01 |
| **Namespace** | AsiaErp.UserInterface |
| **Inheritance** | frmReport |
| **Module** | Fixed Assets (FA) - Báo cáo phân tích tài sản 01 |

## 2. Chức năng

Báo cáo phân tích tài sản cố định theo bộ phận sử dụng, phí, và sản phẩm công trình.

## 3. Form Controls

### 3.1 Input Controls

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_BPSD | AsTextBox | MA_BPSD | Mã bộ phận sử dụng |
| txtMa_Phi | AsTextBox | MA_PHI | Mã phí |
| txtMa_SPCT | AsTextBox | MA_SPCT | Mã sản phẩm công trình |
| txtNgay1 | AsMaskedTextBox | - | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | - | Ngày kết thúc |
| cboKyBc | ComboBox | - | Kỳ báo cáo |
| cboMau_bc | ComboBox | - | Mẫu báo cáo |

### 3.2 Label Controls

| Control | Mô tả |
|---------|-------|
| lblTen_BPSD | Tên bộ phận sử dụng |
| lblTen_Phi | Tên phí |
| lblTen_SPCT | Tên sản phẩm công trình |

## 4. Business Logic

### 4.1 LoadData Method

```csharp
protected override bool LoadData()
{
    ArrayList arrayList = new ArrayList();
    arrayList.Add(CompanyInformations.CompanyID);
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
    arrayList.Add(((TextBox)txtMa_BPSD).Text.Trim());
    arrayList.Add(((TextBox)txtMa_Phi).Text.Trim());
    arrayList.Add(((TextBox)txtMa_SPCT).Text.Trim());
    set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
    base.MyFomularFields.Clear();
    base.MyFomularFields.Add("strSubTitle1", GetFilterTitle());
    return true;
}
```

### 4.2 GetFilterTitle Method

```csharp
private string GetFilterTitle()
{
    string text = string.Empty;
    if (Operators.CompareString(((TextBox)txtMa_BPSD).Text.Trim(), "", false) != 0)
    {
        text = text + lblMa_BPSD.Text + ": " + ((TextBox)txtMa_BPSD).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_Phi).Text.Trim(), "", false) != 0)
    {
        text = text + lblMa_Phi.Text + ": " + ((TextBox)txtMa_Phi).Text + "; ";
    }
    if (Operators.CompareString(((TextBox)txtMa_SPCT).Text.Trim(), "", false) != 0)
    {
        text = text + lblMa_SPCT.Text + ": " + ((TextBox)txtMa_SPCT).Text + "; ";
    }
    return text;
}
```

## 5. Stored Procedures

| SP Name | Purpose | Parameters |
|---------|---------|------------|
| sp_FARptBCPT01_GetData | Lấy dữ liệu báo cáo | @Ma_cty, @Ngay1, @Ngay2, @Ma_bpsd, @Ma_phi, @Ma_spct |

## 6. PHP Mapping

### 6.1 Controller

```php
<?php
namespace App\Http\Controllers\FA\Reports;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class BCPT01Controller extends Controller
{
    public function index()
    {
        return view('fa.reports.bcpt01');
    }
    
    public function getData(Request $request)
    {
        $params = [
            session('company_id'),
            $request->ngay1,
            $request->ngay2,
            $request->ma_bpsd ?? '',
            $request->ma_phi ?? '',
            $request->ma_spct ?? ''
        ];
        
        $data = DB::select('EXEC sp_FARptBCPT01_GetData ?, ?, ?, ?, ?, ?', $params);
        
        return response()->json(['data' => $data]);
    }
}
```

## 7. Notes

- Báo cáo phân tích tài sản theo 3 tiêu chí: BPSD, Phí, SPCT
- Form đơn giản, chỉ có 3 filter chính
- Kế thừa từ frmReport nên có đầy đủ chức năng xuất Excel, in ấn
