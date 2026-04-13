# FARptBCPT07.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FARptBCPT07.dll |
| **Form Class** | frmFARptBCPT07 |
| **Namespace** | AsiaErp.UserInterface |
| **Inheritance** | frmReport |
| **Module** | Fixed Assets (FA) - Báo cáo phân tích tài sản 07 |

## 2. Chức năng

Báo cáo phân tích tài sản cố định theo bộ phận sử dụng, phí, và sản phẩm công trình (phiên bản 7). Có lấy thêm thông tin nguồn vốn.

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
    
    // Lấy tên nguồn vốn
    DataTable dataTable = Commons.FAGetTenNguonVon(CompanyInformations.CompanyID);
    if (dataTable.Rows.Count == 0)
    {
        return false;
    }
    base.MyFomularFields.Add("strNV1", RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["ten_nv"]));
    base.MyFomularFields.Add("strNV2", RuntimeHelpers.GetObjectValue(dataTable.Rows[1]["ten_nv"]));
    base.MyFomularFields.Add("strNV3", RuntimeHelpers.GetObjectValue(dataTable.Rows[2]["ten_nv"]));
    base.MyFomularFields.Add("strNV4", RuntimeHelpers.GetObjectValue(dataTable.Rows[3]["ten_nv"]));
    return true;
}
```

## 5. Stored Procedures

| SP Name | Purpose | Parameters |
|---------|---------|------------|
| sp_FARptBCPT07_GetData | Lấy dữ liệu báo cáo | @Ma_cty, @Ngay1, @Ngay2, @Ma_bpsd, @Ma_phi, @Ma_spct |
| sp_FAGetTenNguonVon | Lấy tên nguồn vốn | @Ma_cty |

## 6. PHP Mapping

```php
<?php
namespace App\Http\Controllers\FA\Reports;

class BCPT07Controller extends Controller
{
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
        
        $data = DB::select('EXEC sp_FARptBCPT07_GetData ?, ?, ?, ?, ?, ?', $params);
        
        // Lấy tên nguồn vốn
        $nguonVon = DB::select('EXEC sp_FAGetTenNguonVon ?', [session('company_id')]);
        
        return response()->json([
            'data' => $data,
            'nguon_von' => $nguonVon
        ]);
    }
}
```

## 7. Notes

- Tương tự BCPT06 nhưng có thêm lấy thông tin nguồn vốn
- Hiển thị 4 nguồn vốn trong báo cáo
