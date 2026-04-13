# FARptSoTSCD.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FARptSoTSCD.dll |
| **Form Class** | frmFARptSoTSCD |
| **Namespace** | AsiaErp.UserInterface |
| **Inheritance** | frmReport |
| **Module** | Fixed Assets (FA) - Sổ tài sản cố định |

## 2. Chức năng

Sổ theo dõi tài sản cố định theo nhóm tài sản và bộ phận sử dụng.

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
    }
    catch (Exception ex)
    {
        Interaction.MsgBox("Lỗi lọc dữ liệu: " + ex.Message, MsgBoxStyle.Critical, "Thông báo");
    }
    return true;
}
```

### 4.2 GetFilterTitle Method

```csharp
private string GetFilterTitle()
{
    string text = "";
    if (Operators.CompareString(((TextBox)txtMa_ts).Text.Trim(), "", false) != 0)
    {
        text = text + "Bộ phận sử dụng:" + lblTen_ts.Text + ";";
    }
    return text;
}
```

## 5. Stored Procedures

| SP Name | Purpose | Parameters |
|---------|---------|------------|
| sp_FARptSoTSCD_GetData | Lấy dữ liệu sổ | @Ma_cty, @Ngay1, @Ngay2, @Ma_ts, @Ma_nhts, @Ma_bpsd |

## 6. PHP Mapping

```php
<?php
namespace App\Http\Controllers\FA\Reports;

class SoTSCDController extends Controller
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
            
            $data = DB::select('EXEC sp_FARptSoTSCD_GetData ?, ?, ?, ?, ?, ?', $params);
            return response()->json(['data' => $data]);
        } catch (Exception $e) {
            return response()->json(['error' => 'Lỗi lọc dữ liệu: ' . $e->getMessage()], 500);
        }
    }
}
```

## 7. Notes

- Sổ chuyên dụng cho tài sản cố định (không bao gồm công cụ)
- Có thể lọc theo nhóm tài sản
- GetFilterTitle chỉ xử lý filter theo tài sản (có thể là bug hoặc chưa hoàn thiện)
