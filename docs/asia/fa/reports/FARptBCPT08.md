# FARptBCPT08.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FARptBCPT08.dll |
| **Form Class** | frmFARptBCPT08 |
| **Namespace** | AsiaErp.UserInterface |
| **Inheritance** | frmReport |
| **Module** | Fixed Assets (FA) - Báo cáo phân tích tài sản 08 |

## 2. Chức năng

Báo cáo phân tích tài sản cố định chi tiết theo nhiều tiêu chí: tài sản, nhóm tài sản, bộ phận sử dụng, phí, SPCT.

## 3. Form Controls

### 3.1 Input Controls

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_ts | AsTextBox | MA_TS | Mã tài sản |
| txtMa_Nhts1 | AsTextBox | MA_NHTS (loai_nh=1) | Mã nhóm tài sản 1 |
| txtMa_Nhts2 | AsTextBox | MA_NHTS (loai_nh=2) | Mã nhóm tài sản 2 |
| txtMa_Nhts3 | AsTextBox | MA_NHTS (loai_nh=3) | Mã nhóm tài sản 3 |
| txtMa_BPSD | AsTextBox | MA_BPSD | Mã bộ phận sử dụng |
| txtMa_Phi | AsTextBox | MA_PHI | Mã phí |
| txtMa_SPCT | AsTextBox | MA_SPCT | Mã sản phẩm công trình |
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
    arrayList.Add(((TextBox)txtMa_ts).Text.Trim());
    arrayList.Add(((TextBox)txtMa_Nhts1).Text.Trim());
    arrayList.Add(((TextBox)txtMa_Nhts2).Text.Trim());
    arrayList.Add(((TextBox)txtMa_Nhts3).Text.Trim());
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
| sp_FARptBCPT08_GetData | Lấy dữ liệu báo cáo | @Ma_cty, @Ngay1, @Ngay2, @Ma_ts, @Ma_nhts1, @Ma_nhts2, @Ma_nhts3, @Ma_bpsd, @Ma_phi, @Ma_spct |

## 6. PHP Mapping

```php
<?php
namespace App\Http\Controllers\FA\Reports;

class BCPT08Controller extends Controller
{
    public function getData(Request $request)
    {
        $params = [
            session('company_id'),
            $request->ngay1,
            $request->ngay2,
            $request->ma_ts ?? '',
            $request->ma_nhts1 ?? '',
            $request->ma_nhts2 ?? '',
            $request->ma_nhts3 ?? '',
            $request->ma_bpsd ?? '',
            $request->ma_phi ?? '',
            $request->ma_spct ?? ''
        ];
        
        $data = DB::select('EXEC sp_FARptBCPT08_GetData ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', $params);
        return response()->json(['data' => $data]);
    }
}
```

## 7. Notes

- Báo cáo chi tiết với 7 tham số filter
- Tương tự BCPT03 nhưng không lấy thông tin nguồn vốn
