# FARptBCPT09.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FARptBCPT09.dll |
| **Form Class** | frmFARptBCPT09 |
| **Namespace** | AsiaErp.UserInterface |
| **Inheritance** | frmReport |
| **Module** | Fixed Assets (FA) - Báo cáo phân tích tài sản 09 |

## 2. Chức năng

Báo cáo phân tích tài sản cố định theo nhóm (có thể chọn nhóm theo BPSD, Phí, hoặc SPCT).

## 3. Form Controls

### 3.1 Input Controls

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_BPSD | AsTextBox | MA_BPSD | Mã bộ phận sử dụng |
| txtMa_Phi | AsTextBox | MA_PHI | Mã phí |
| txtMa_SPCT | AsTextBox | MA_SPCT | Mã sản phẩm công trình |
| cboTheo_nhom | ComboBox | - | Theo nhóm (BP sử dụng/Mã phí/Mã SPCT) |
| txtNgay1 | AsMaskedTextBox | - | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | - | Ngày kết thúc |
| cboKyBc | ComboBox | - | Kỳ báo cáo |

### 3.2 ComboBox Items

```csharp
cboTheo_nhom.Items.AddRange(new object[3] { "BP sử dụng", "Mã phí", "Mã SPCT" });
```

## 4. Business Logic

### 4.1 InitOtherComponents

```csharp
protected override void InitOtherComponents()
{
    base.InitOtherComponents();
    ((Control)cboKyBc).Select();
    cboTheo_nhom.SelectedIndex = 0;
}
```

### 4.2 LoadData Method

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

## 5. Stored Procedures

| SP Name | Purpose | Parameters |
|---------|---------|------------|
| sp_FARptBCPT09_GetData | Lấy dữ liệu báo cáo | @Ma_cty, @Ngay1, @Ngay2, @Ma_bpsd, @Ma_phi, @Ma_spct |

## 6. PHP Mapping

```php
<?php
namespace App\Http\Controllers\FA\Reports;

class BCPT09Controller extends Controller
{
    public function index()
    {
        $groupOptions = [
            ['value' => 'bpsd', 'text' => 'BP sử dụng'],
            ['value' => 'phi', 'text' => 'Mã phí'],
            ['value' => 'spct', 'text' => 'Mã SPCT']
        ];
        return view('fa.reports.bcpt09', compact('groupOptions'));
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
        
        $data = DB::select('EXEC sp_FARptBCPT09_GetData ?, ?, ?, ?, ?, ?', $params);
        return response()->json(['data' => $data]);
    }
}
```

## 7. Notes

- Tương tự BCPT05 nhưng khác về cách tổ chức code
- Có thêm tùy chọn nhóm báo cáo (theo BPSD/Phí/SPCT)
- ComboBox cboTheo_nhom hiện tại đang hidden (Visible = false)
