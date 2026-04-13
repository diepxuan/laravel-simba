# FARptBCTS06.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FARptBCTS06.dll |
| **Form Class** | frmFARptBCTS06 |
| **Namespace** | AsiaErp.UserInterface |
| **Inheritance** | frmReport |
| **Module** | Fixed Assets (FA) - Báo cáo tình hình tài sản 06 |

## 2. Chức năng

Báo cáo tình hình tài sản cố định theo bộ phận sử dụng, phí, và sản phẩm công trình.

## 3. Form Controls

### 3.1 Input Controls

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_Bp | AsTextBox | MA_BPSD | Mã bộ phận sử dụng |
| txtMa_Phi | AsTextBox | MA_PHI | Mã phí |
| txtMa_Spct | AsTextBox | MA_SPCT | Mã sản phẩm công trình |
| txtNgay1 | AsMaskedTextBox | - | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | - | Ngày kết thúc |
| cboKyBc | ComboBox | - | Kỳ báo cáo |

## 4. Business Logic

### 4.1 LoadData Method

```csharp
protected override bool LoadData()
{
    ArrayList arrayList = new ArrayList();
    arrayList.Add(CompanyInformations.CompanyID);
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
    arrayList.Add(((TextBox)txtMa_Bp).Text);
    arrayList.Add(((TextBox)txtMa_Phi).Text);
    arrayList.Add(((TextBox)txtMa_Spct).Text);
    set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
    base.ViewCrystalBySource();
    base.MyFomularFields.Clear();
    base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
    return true;
}
```

## 5. Stored Procedures

| SP Name | Purpose | Parameters |
|---------|---------|------------|
| sp_FARptBCTS06_GetData | Lấy dữ liệu báo cáo | @Ma_cty, @Ngay1, @Ngay2, @Ma_bp, @Ma_phi, @Ma_spct |

## 6. PHP Mapping

```php
<?php
namespace App\Http\Controllers\FA\Reports;

class BCTS06Controller extends Controller
{
    public function getData(Request $request)
    {
        $params = [
            session('company_id'),
            $request->ngay1,
            $request->ngay2,
            $request->ma_bp ?? '',
            $request->ma_phi ?? '',
            $request->ma_spct ?? ''
        ];
        
        $data = DB::select('EXEC sp_FARptBCTS06_GetData ?, ?, ?, ?, ?, ?', $params);
        return response()->json(['data' => $data]);
    }
}
```

## 7. Notes

- Tương tự BCTS05 nhưng khác tên biến (txtMa_Bp thay vì txtMa_BPSD)
- Có gọi base.ViewCrystalBySource() sau khi load data
