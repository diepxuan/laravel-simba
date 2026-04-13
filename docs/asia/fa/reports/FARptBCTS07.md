# FARptBCTS07.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FARptBCTS07.dll |
| **Form Class** | frmFARptBCTS07 |
| **Namespace** | AsiaErp.UserInterface |
| **Inheritance** | frmReport |
| **Module** | Fixed Assets (FA) - Báo cáo tình hình tài sản 07 |

## 2. Chức năng

Báo cáo tình hình tài sản cố định tại một ngày cụ thể, với khả năng nhóm theo 3 cấp độ.

## 3. Form Controls

### 3.1 Input Controls

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_TS | AsTextBox | MA_TS | Mã tài sản |
| txtMa_nhts1 | AsTextBox | MA_NHTS (loai_nh=1) | Mã nhóm tài sản 1 |
| txtMa_nhts2 | AsTextBox | MA_NHTS (loai_nh=2) | Mã nhóm tài sản 2 |
| txtMa_nhts3 | AsTextBox | MA_NHTS (loai_nh=3) | Mã nhóm tài sản 3 |
| txtMa_Bp | AsTextBox | MA_BPSD | Mã bộ phận sử dụng |
| txtMa_Phi | AsTextBox | MA_PHI | Mã phí |
| txtMa_Spct | AsTextBox | MA_SPCT | Mã sản phẩm công trình |
| cboNhom_cap1 | AsComboBox | - | Nhóm cấp 1 |
| cboNhom_cap2 | AsComboBox | - | Nhóm cấp 2 |
| cboNhom_cap3 | AsComboBox | - | Nhóm cấp 3 |
| txtNgay | AsMaskedTextBox | - | Tại ngày |

## 4. Business Logic

### 4.1 ValidData Method

```csharp
protected override bool ValidData()
{
    if (Operators.CompareString(((MaskedTextBox)txtNgay).Text.ToString().Replace("/", "").Trim(), "", false) == 0)
    {
        epNotice.SetError((Control)(object)txtNgay, Helper.GetMess(50002).Description);
        ((Control)txtNgay).Select();
        return false;
    }
    return base.ValidData();
}
```

### 4.2 LoadData Method

```csharp
protected override bool LoadData()
{
    if (ValidData())
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(CompanyInformations.CompanyID);
        arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay.Value));
        arrayList.Add(((TextBox)txtMa_TS).Text);
        arrayList.Add(((TextBox)txtMa_nhts1).Text);
        arrayList.Add(((TextBox)txtMa_nhts2).Text);
        arrayList.Add(((TextBox)txtMa_nhts3).Text);
        arrayList.Add(((TextBox)txtMa_Bp).Text);
        arrayList.Add(((TextBox)txtMa_Phi).Text);
        arrayList.Add(((TextBox)txtMa_Spct).Text);
        arrayList.Add(cap1);
        arrayList.Add(cap2);
        arrayList.Add(cap3);
        set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
        base.ViewCrystalBySource();
        base.MyFomularFields.Clear();
        
        DateTime dateTime = Conversions.ToDate(txtNgay.Value);
        base.MyFomularFields.Add("strSubTitle", "Ngày " + dateTime.Day + " tháng " + DateAndTime.Month(dateTime) + " năm " + DateAndTime.Year(dateTime));
        base.MyFomularFields.Add("strFilterTitle", GetFilterTitle());
        return true;
    }
    return true;
}
```

## 5. Stored Procedures

| SP Name | Purpose | Parameters |
|---------|---------|------------|
| sp_FARptBCTS07_GetData | Lấy dữ liệu báo cáo | @Ma_cty, @Ngay, @Ma_ts, @Ma_nhts1, @Ma_nhts2, @Ma_nhts3, @Ma_bp, @Ma_phi, @Ma_spct, @Cap1, @Cap2, @Cap3 |

## 6. PHP Mapping

```php
<?php
namespace App\Http\Controllers\FA\Reports;

class BCTS07Controller extends Controller
{
    public function getData(Request $request)
    {
        $validated = $request->validate([
            'ngay' => 'required|date',
        ]);
        
        $params = [
            session('company_id'),
            $request->ngay,
            $request->ma_ts ?? '',
            $request->ma_nhts1 ?? '',
            $request->ma_nhts2 ?? '',
            $request->ma_nhts3 ?? '',
            $request->ma_bp ?? '',
            $request->ma_phi ?? '',
            $request->ma_spct ?? '',
            $request->cap1 ?? '',
            $request->cap2 ?? '',
            $request->cap3 ?? ''
        ];
        
        $data = DB::select('EXEC sp_FARptBCTS07_GetData ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', $params);
        
        $date = Carbon::parse($request->ngay);
        $subTitle = "Ngày {$date->day} tháng {$date->month} năm {$date->year}";
        
        return response()->json([
            'data' => $data,
            'sub_title' => $subTitle
        ]);
    }
}
```

## 7. Notes

- Báo cáo tại một ngày cụ thể (không phải khoảng thời gian)
- Có validation bắt buộc nhập ngày
- Hỗ trợ nhóm theo 3 cấp độ
- Hiển thị subtitle với định dạng "Ngày X tháng Y năm Z"
