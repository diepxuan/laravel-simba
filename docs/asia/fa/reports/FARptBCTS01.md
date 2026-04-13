# FARptBCTS01.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FARptBCTS01.dll |
| **Form Class** | frmFARptBCTS01 |
| **Namespace** | AsiaERp.UserInterface |
| **Inheritance** | frmReport2DGV |
| **Module** | Fixed Assets (FA) - Báo cáo tình hình tài sản 01 |

## 2. Chức năng

Báo cáo tình hình tài sản cố định với 2 DataGridView (master-detail). Hiển thị danh sách tài sản và chi tiết theo từng tài sản.

## 3. Form Controls

### 3.1 Input Controls

| Control | Type | Lookup | Mô tả |
|---------|------|--------|-------|
| txtMa_ts | AsTextBox | MA_TS | Mã tài sản |
| txtNgay2 | AsMaskedTextBox | - | Tại ngày |
| cboMau_bc | ComboBox | - | Mẫu báo cáo |
| optVND | RadioButton | - | Tiền VND |
| optNt | RadioButton | - | Tiền ngoại tệ |

### 3.2 Grid Controls

| Control | Type | Mô tả |
|---------|------|-------|
| dgvBCPh | AsDataGridView | Grid phần header (master) |
| dgvBCCt | AsDataGridView | Grid phần chi tiết (detail) |

## 4. Business Logic

### 4.1 LoadData Method

```csharp
protected override bool LoadData()
{
    ArrayList arrayList = new ArrayList();
    arrayList.Add(CompanyInformations.CompanyID);
    arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
    arrayList.Add(((TextBox)txtMa_ts).Text.Trim());
    arrayList.Add("");
    DataSet dataSet = base.MyController.GetDataSet(arrayList.ToArray());
    set_MyDGVPhSource(isSet2Print: false, dataSet.Tables[1]);
    set_MyDGVCtSource(isSet2Print: true, dataSet.Tables[0]);
    base.MyFomularFields.Clear();
    base.MyFomularFields.Add("strSubTitle", GetFilterTitle());
    return true;
}
```

### 4.2 CellContentClick Event

```csharp
private void dgvBC_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex != -1 && !base.IsLoading && 0 == 0 && e.ColumnIndex == ((DataGridViewBand)((DataGridView)dgvBCPh).Columns["colPHTAG"]).Index)
    {
        get_MyDGVPhSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBCPh).CurrentRow).Index]["TAG"] = Operators.NotObject(get_MyDGVPhSource(isSet2Print: true).Rows[((DataGridViewBand)((DataGridView)dgvBCPh).CurrentRow).Index]["TAG"]);
    }
}
```

### 4.3 CurrentCellChanged Event

```csharp
private void dgvBCPh_CurrentCellChanged(object sender, EventArgs e)
{
    if (base.IsLoading || ((DataGridView)dgvBCPh).CurrentCell == null)
    {
        return;
    }
    try
    {
        if (get_MyDGVCtSource(isSet2Print: true).Rows.Count > 0)
        {
            get_MyDGVCtSource(isSet2Print: true).DefaultView.RowFilter = Conversions.ToString(Operators.AddObject(Operators.AddObject((object)"ma_ts= '", Helper.Repl_Null(RuntimeHelpers.GetObjectValue(get_MyDGVPhSource(isSet2Print: true).DefaultView[((DataGridViewBand)((DataGridView)dgvBCPh).CurrentRow).Index]["ma_ts"]), isNum: false)), (object)"'"));
        }
    }
    catch (Exception ex)
    {
        ProjectData.SetProjectError(ex);
        Exception ex2 = ex;
        Helper.ProcessError(ex2.ToString());
        ProjectData.ClearProjectError();
    }
}
```

### 4.4 ViewCrystalByConnection

```csharp
protected override void ViewCrystalByConnection()
{
    string text = "";
    DataRow[] array = get_MyDGVPhSource(isSet2Print: true).Select("tag=1");
    foreach (DataRow dataRow in array)
    {
        text = Conversions.ToString(Operators.AddObject((object)text, Operators.AddObject(Operators.AddObject((object)",", dataRow["ma_ts"]), (object)",")));
    }
    if (text.Length != 0)
    {
        base.Parameters4StoredProcedure.Clear();
        base.Parameters4StoredProcedure.Add("@pMa_cty", CompanyInformations.CompanyID);
        base.Parameters4StoredProcedure.Add("@pNgay", RuntimeHelpers.GetObjectValue(txtNgay2.Value));
        base.Parameters4StoredProcedure.Add("@pMa_ts", "");
        base.Parameters4StoredProcedure.Add("@pMa_ts_all", text);
        base.ViewCrystalByConnection();
    }
}
```

## 5. Stored Procedures

| SP Name | Purpose | Parameters |
|---------|---------|------------|
| sp_FARptBCTS01_GetDataSet | Lấy dữ liệu báo cáo (DataSet 2 bảng) | @Ma_cty, @Ngay, @Ma_ts, @Ma_ts_all |

## 6. PHP Mapping

```php
<?php
namespace App\Http\Controllers\FA\Reports;

class BCTS01Controller extends Controller
{
    public function getData(Request $request)
    {
        $params = [
            session('company_id'),
            $request->ngay,
            $request->ma_ts ?? '',
            '' // Ma_ts_all
        ];
        
        // Trả về DataSet với 2 bảng
        $result = DB::select('EXEC sp_FARptBCTS01_GetDataSet ?, ?, ?, ?', $params);
        
        // Tách thành 2 bảng
        $phData = []; // Master data
        $ctData = []; // Detail data
        
        return response()->json([
            'ph' => $phData,
            'ct' => $ctData
        ]);
    }
    
    public function print(Request $request)
    {
        // Lấy danh sách tài sản được chọn (tag=1)
        $selectedTs = $request->input('selected_ts', []);
        $maTsAll = ',' . implode(',', $selectedTs) . ',';
        
        $params = [
            session('company_id'),
            $request->ngay,
            '',
            $maTsAll
        ];
        
        $data = DB::select('EXEC sp_FARptBCTS01_GetDataSet ?, ?, ?, ?', $params);
        return response()->json(['data' => $data]);
    }
}
```

## 7. Notes

- Form kế thừa từ `frmReport2DGV` nên có 2 grid (master-detail)
- Grid phần header có cột checkbox (colPHTAG) để chọn tài sản in
- Khi click vào dòng trên grid master, grid detail sẽ lọc theo ma_ts
- Có chức năng in Crystal Report theo các tài sản được chọn
- Send2CrystalByConnection = true
