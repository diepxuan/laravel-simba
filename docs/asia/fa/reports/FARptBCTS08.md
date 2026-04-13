# FARptBCTS08.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FARptBCTS08.dll |
| **Form Class** | frmFARptBCTS08 |
| **Namespace** | AsiaErp.UserInterface |
| **Inheritance** | frmReport |
| **Module** | Fixed Assets (FA) - Báo cáo tình hình tài sản 08 |

## 2. Chức năng

Báo cáo tình hình tài sản cố định theo tài sản, nhóm tài sản và bộ phận sử dụng.

## 3. Form Controls

### 3.1 Input Controls

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_ts | AsTextBox | MA_TS | Mã tài sản |
| txtMa_nhts | AsTextBox | MA_NHTS | Mã nhóm tài sản |
| txtMa_bpsd | AsTextBox | MA_BPSD | Mã bộ phận sử dụng |
| txtNgay1 | AsMaskedTextBox | - | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | - | Ngày kết thúc |
| cboKyBc | ComboBox | - | Kỳ báo cáo |

## 4. Business Logic

### 4.1 LoadData Method

```csharp
protected override bool LoadData()
{
    try
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(CompanyInformations.CompanyID);
        arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay1.Value)));
        arrayList.Add(DateAndTime.DateValue(Conversions.ToString(txtNgay2.Value)));
        arrayList.Add(((TextBox)txtMa_ts).Text);
        arrayList.Add(((TextBox)txtMa_nhts).Text);
        arrayList.Add(((TextBox)txtMa_bpsd).Text);
        set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
        base.MyFomularFields.Clear();
        base.MyFomularFields.Add("strSubTitle1", GetFilterTitle());
    }
    catch (Exception ex)
    {
        Interaction.MsgBox("Lỗi lọc dữ liệu: " + ex.Message, MsgBoxStyle.Critical, "Thông báo");
    }
    return true;
}
```

## 5. Stored Procedures

| SP Name | Purpose | Parameters |
|---------|---------|------------|
| sp_FARptBCTS08_GetData | Lấy dữ liệu báo cáo | @Ma_cty, @Ngay1, @Ngay2, @Ma_ts, @Ma_nhts, @Ma_bpsd |

## 6. PHP Mapping

```php
<?php
namespace App\Http\Controllers\FA\Reports;

class BCTS08Controller extends Controller
{
    public function getData(Request $request)
    {
        try {
            $params = [
                session('company_id'),
                $request->ngay1,
                $request->ngay2,
                $request->ma_ts ?? '',
                $request->ma_nhts ?? '',
                $request->ma_bpsd ?? ''
            ];
            
            $data = DB::select('EXEC sp_FARptBCTS08_GetData ?, ?, ?, ?, ?, ?', $params);
            return response()->json(['data' => $data]);
        } catch (Exception $e) {
            return response()->json(['error' => 'Lỗi lọc dữ liệu: ' . $e->getMessage()], 500);
        }
    }
}
```

## 7. Notes

- Báo cáo đơn giản với 3 tham số filter
- Có xử lý exception khi lọc dữ liệu
- Sử dụng DateAndTime.DateValue để chuyển đổi ngày
