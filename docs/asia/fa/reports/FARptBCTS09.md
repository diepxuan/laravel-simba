# FARptBCTS09.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FARptBCTS09.dll |
| **Form Class** | frmFARptBCTS09 |
| **Namespace** | AsiaErp.UserInterface |
| **Inheritance** | frmReport |
| **Module** | Fixed Assets (FA) - Báo cáo tình hình tài sản 09 |

## 2. Chức năng

Báo cáo tình hình tài sản/công cụ theo loại (tất cả/tài sản/công cụ), tài sản, công cụ và bộ phận sử dụng.

## 3. Form Controls

### 3.1 Input Controls

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_ts | AsTextBox | MA_TS | Mã tài sản |
| txtMa_cc | AsTextBox | MA_CC | Mã công cụ |
| txtMa_bpsd | AsTextBox | MA_BPSD | Mã bộ phận sử dụng |
| cboLoai | ComboBox | - | Loại (Tất cả/Tài sản/Công cụ) |
| txtNgay1 | AsMaskedTextBox | - | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | - | Ngày kết thúc |
| cboKyBc | ComboBox | - | Kỳ báo cáo |

### 3.2 ComboBox Items

```csharp
cboLoai.Items.AddRange(new object[3] { "Tất cả", "Tài sản", "Công cụ" });
```

## 4. Business Logic

### 4.1 InitOtherComponents

```csharp
protected override void InitOtherComponents()
{
    base.InitOtherComponents();
    cboLoai.SelectedIndex = 0;
}
```

### 4.2 LoadData Method

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
        arrayList.Add(cboLoai.SelectedIndex);
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

### 4.3 cboLoai_SelectedIndexChanged

```csharp
private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
{
    if (cboLoai.SelectedIndex == 0)
    {
        ((Control)txtMa_cc).Enabled = true;
        ((Control)txtMa_ts).Enabled = true;
    }
    else if (cboLoai.SelectedIndex == 1)
    {
        ((TextBox)txtMa_cc).Text = "";
        ((Control)txtMa_cc).Enabled = false;
        ((Control)txtMa_ts).Enabled = true;
    }
    else
    {
        ((Control)txtMa_cc).Enabled = true;
        ((Control)txtMa_ts).Enabled = false;
        ((TextBox)txtMa_ts).Text = "";
    }
}
```

## 5. Stored Procedures

| SP Name | Purpose | Parameters |
|---------|---------|------------|
| sp_FARptBCTS09_GetData | Lấy dữ liệu báo cáo | @Ma_cty, @Ngay1, @Ngay2, @Ma_ts, @Ma_cc, @Ma_bpsd, @Loai |

## 6. PHP Mapping

```php
<?php
namespace App\Http\Controllers\FA\Reports;

class BCTS09Controller extends Controller
{
    public function index()
    {
        $loaiOptions = [
            ['value' => 0, 'text' => 'Tất cả'],
            ['value' => 1, 'text' => 'Tài sản'],
            ['value' => 2, 'text' => 'Công cụ']
        ];
        return view('fa.reports.bcts09', compact('loaiOptions'));
    }
    
    public function getData(Request $request)
    {
        try {
            $params = [
                session('company_id'),
                $request->ngay1,
                $request->ngay2,
                $request->ma_ts ?? '',
                $request->ma_cc ?? '',
                $request->ma_bpsd ?? '',
                $request->loai ?? 0
            ];
            
            $data = DB::select('EXEC sp_FARptBCTS09_GetData ?, ?, ?, ?, ?, ?, ?', $params);
            return response()->json(['data' => $data]);
        } catch (Exception $e) {
            return response()->json(['error' => 'Lỗi lọc dữ liệu: ' . $e->getMessage()], 500);
        }
    }
}
```

## 7. Notes

- Báo cáo hỗ trợ lọc theo loại: Tất cả, Tài sản, hoặc Công cụ
- Khi chọn "Tài sản": disable field công cụ
- Khi chọn "Công cụ": disable field tài sản
- Tham số Loại được truyền vào SP dạng số (0, 1, 2)
