# FARptBCPT10.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FARptBCPT10.dll |
| **Form Class** | frmFARptBCPT10 |
| **Namespace** | AsiaErp.UserInterface |
| **Inheritance** | frmReport |
| **Module** | Fixed Assets (FA) - Báo cáo phân tích tài sản 10 |

## 2. Chức năng

Báo cáo phân tích tài sản cố định theo tài khoản chi phí và tài khoản phân bổ. Hỗ trợ lọc theo công cụ dụng cụ.

## 3. Form Controls

### 3.1 Input Controls

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_BPSD | AsTextBox | MA_BPSD | Mã bộ phận sử dụng |
| txtMa_cc | AsTextBox | MA_CC | Mã công cụ |
| txtMa_phi | AsTextBox | MA_PHI | Mã phí |
| txtMa_spct | AsTextBox | MA_SPCT | Mã sản phẩm công trình |
| txtTK_PB | AsTextBox | TK | TK phân bổ |
| txtTK_CP | AsTextBox | TK | TK chi phí |
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
    arrayList.Add(((TextBox)txtMa_cc).Text.Trim());
    arrayList.Add(((TextBox)txtMa_phi).Text.Trim());
    arrayList.Add(((TextBox)txtMa_spct).Text.Trim());
    arrayList.Add(((TextBox)txtTK_PB).Text.Trim());
    arrayList.Add(((TextBox)txtTK_CP).Text.Trim());
    set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
    base.MyFomularFields.Clear();
    base.MyFomularFields.Add("strSubTitle1", GetFilterTitle());
    return true;
}
```

### 4.3 GetFilterTitle Method

```csharp
private string GetFilterTitle()
{
    string text = string.Empty;
    if (Operators.CompareString(((TextBox)txtMa_BPSD).Text.Trim(), "", false) != 0)
    {
        text = text + lblMa_BPSD.Text + ": " + ((TextBox)txtMa_BPSD).Text;
    }
    return text;
}
```

## 5. Stored Procedures

| SP Name | Purpose | Parameters |
|---------|---------|------------|
| sp_FARptBCPT10_GetData | Lấy dữ liệu báo cáo | @Ma_cty, @Ngay1, @Ngay2, @Ma_bpsd, @Ma_cc, @Ma_phi, @Ma_spct, @TK_PB, @TK_CP |

## 6. PHP Mapping

```php
<?php
namespace App\Http\Controllers\FA\Reports;

class BCPT10Controller extends Controller
{
    public function getData(Request $request)
    {
        $params = [
            session('company_id'),
            $request->ngay1,
            $request->ngay2,
            $request->ma_bpsd ?? '',
            $request->ma_cc ?? '',
            $request->ma_phi ?? '',
            $request->ma_spct ?? '',
            $request->tk_pb ?? '',
            $request->tk_cp ?? ''
        ];
        
        $data = DB::select('EXEC sp_FARptBCPT10_GetData ?, ?, ?, ?, ?, ?, ?, ?, ?', $params);
        return response()->json(['data' => $data]);
    }
}
```

## 7. Notes

- Báo cáo đặc biệt với 7 tham số filter
- Có thêm filter theo tài khoản phân bổ và tài khoản chi phí
- Hỗ trợ lọc theo công cụ dụng cụ (MA_CC)
- ComboBox cboTheo_nhom hiện tại đang hidden (Visible = false)
