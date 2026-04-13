# FARptSoSD.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FARptSoSD.dll |
| **Form Class** | frmFARptSoSD |
| **Namespace** | AsiaErp.UserInterface |
| **Inheritance** | frmReport |
| **Module** | Fixed Assets (FA) - Sổ sử dụng tài sản/công cụ |

## 2. Chức năng

Sổ theo dõi sử dụng tài sản và công cụ dụng cụ theo bộ phận sử dụng.

## 3. Form Controls

### 3.1 Input Controls

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_ts | AsTextBox | MA_TS | Mã tài sản |
| txtMa_cc | AsTextBox | MA_CC | Mã công cụ |
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
        arrayList.Add(((TextBox)txtMa_cc).Text);
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

## 5. Stored Procedures

| SP Name | Purpose | Parameters |
|---------|---------|------------|
| sp_FARptSoSD_GetData | Lấy dữ liệu sổ | @Ma_cty, @Ngay1, @Ngay2, @Ma_ts, @Ma_cc, @Ma_bpsd |

## 6. PHP Mapping

```php
<?php
namespace App\Http\Controllers\FA\Reports;

class SoSDController extends Controller
{
    public function getData(Request $request)
    {
        try {
            $params = [
                session('company_id'),
                $request->ngay1,
                $request->ngay2,
                $request->ma_ts ?? '',
                $request->ma_cc ?? '',
                $request->ma_bpsd ?? ''
            ];
            
            $data = DB::select('EXEC sp_FARptSoSD_GetData ?, ?, ?, ?, ?, ?', $params);
            return response()->json(['data' => $data]);
        } catch (Exception $e) {
            return response()->json(['error' => 'Lỗi lọc dữ liệu: ' . $e->getMessage()], 500);
        }
    }
}
```

## 7. Notes

- Sổ theo dõi sử dụng tài sản và công cụ
- Có thể lọc theo cả tài sản và công cụ cùng lúc
- Không có phân biệt loại như BCTS09
