# FARptBCTS04.dll - Phân tích chi tiết

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **DLL Name** | FARptBCTS04.dll |
| **Form Class** | frmFARptBCTS04 |
| **Namespace** | AsiaErp.UserInterface |
| **Inheritance** | frmReport |
| **Module** | Fixed Assets (FA) - Báo cáo tình hình tài sản 04 |

## 2. Chức năng

Báo cáo tình hình tài sản cố định với khả năng nhóm theo 3 cấp độ (nhóm cấp 1, 2, 3). Hỗ trợ nhiều tiêu chí nhóm: BPSD, Phí, SPCT, Nhóm TS.

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
| cboNhom_cap1 | AsComboBox | - | Nhóm cấp 1 |
| cboNhom_cap2 | AsComboBox | - | Nhóm cấp 2 |
| cboNhom_cap3 | AsComboBox | - | Nhóm cấp 3 |
| txtNgay1 | AsMaskedTextBox | - | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | - | Ngày kết thúc |
| cboKyBc | ComboBox | - | Kỳ báo cáo |

### 3.2 GroupItem Class

```csharp
internal class GroupItem
{
    private string mtext;
    private string mvalue;

    public object Text { get; set; }
    public object Value { get; set; }

    public GroupItem(string value, string text)
    {
        mtext = text;
        mvalue = value;
    }
}
```

## 4. Business Logic

### 4.1 InitOtherComponents

```csharp
protected override void InitOtherComponents()
{
    base.InitOtherComponents();
    ((Control)cboKyBc).Select();
    
    GroupItem groupItem = new GroupItem("", "");
    ar[0] = groupItem;
    groupItem = new GroupItem("Ma_bpsd", "Bộ phận sử dụng");
    ar[1] = groupItem;
    groupItem = new GroupItem("ma_phi", "Phí");
    ar[2] = groupItem;
    groupItem = new GroupItem("ma_spct", "Sản phẩm công trình");
    ar[3] = groupItem;
    groupItem = new GroupItem("ma_nhts1", "Nhóm tài sản 1");
    ar[4] = groupItem;
    groupItem = new GroupItem("ma_nhts2", "Nhóm tài sản 2");
    ar[5] = groupItem;
    groupItem = new GroupItem("ma_nhts3", "Nhóm tài sản 3");
    ar[6] = groupItem;
    
    ((ComboBox)cboNhom_cap1).Items.Clear();
    for (int i = 0; i < ar.Length; i++)
    {
        ((ComboBox)cboNhom_cap1).Items.Add(RuntimeHelpers.GetObjectValue(ar[i]));
    }
    ((ListControl)cboNhom_cap1).ValueMember = "Value";
    ((ListControl)cboNhom_cap1).DisplayMember = "Text";
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
    arrayList.Add(((TextBox)txtMa_ts).Text.Trim());
    arrayList.Add(((TextBox)txtMa_Nhts1).Text.Trim());
    arrayList.Add(((TextBox)txtMa_Nhts2).Text.Trim());
    arrayList.Add(((TextBox)txtMa_Nhts3).Text.Trim());
    arrayList.Add(((TextBox)txtMa_BPSD).Text.Trim());
    arrayList.Add(((TextBox)txtMa_Phi).Text.Trim());
    arrayList.Add(((TextBox)txtMa_SPCT).Text.Trim());
    arrayList.Add(cap1);
    arrayList.Add(cap2);
    arrayList.Add(cap3);
    set_MyDGVSource(isSet2Print: true, base.MyController.GetData(arrayList.ToArray()));
    base.MyFomularFields.Clear();
    base.MyFomularFields.Add("strSubTitle1", GetFilterTitle());
    return true;
}
```

### 4.3 cboNhom_cap1_SelectedIndexChanged

```csharp
private void cboNhom_cap1_SelectedIndexChanged(object sender, EventArgs e)
{
    cap1 = Conversions.ToString((((ComboBox)cboNhom_cap1).SelectedItem as GroupItem).Value);
    ((ComboBox)cboNhom_cap2).Items.Clear();
    ((ComboBox)cboNhom_cap3).Items.Clear();
    
    for (int i = 0; i < ar.Length; i++)
    {
        if (!Conversions.ToBoolean(Operators.AndObject(
            Operators.CompareObjectEqual((ar[i] as GroupItem).Value, (object)cap1, false),
            Operators.CompareObjectNotEqual((ar[i] as GroupItem).Value, (object)"", false))))
        {
            ((ComboBox)cboNhom_cap2).Items.Add(RuntimeHelpers.GetObjectValue(ar[i]));
        }
    }
    ((ListControl)cboNhom_cap2).ValueMember = "Value";
    ((ListControl)cboNhom_cap2).DisplayMember = "Text";
}
```

## 5. Stored Procedures

| SP Name | Purpose | Parameters |
|---------|---------|------------|
| sp_FARptBCTS04_GetData | Lấy dữ liệu báo cáo | @Ma_cty, @Ngay1, @Ngay2, @Ma_ts, @Ma_nhts1, @Ma_nhts2, @Ma_nhts3, @Ma_bpsd, @Ma_phi, @Ma_spct, @Cap1, @Cap2, @Cap3 |

## 6. PHP Mapping

```php
<?php
namespace App\Http\Controllers\FA\Reports;

class BCTS04Controller extends Controller
{
    private $groupOptions = [
        ['value' => '', 'text' => ''],
        ['value' => 'Ma_bpsd', 'text' => 'Bộ phận sử dụng'],
        ['value' => 'ma_phi', 'text' => 'Phí'],
        ['value' => 'ma_spct', 'text' => 'Sản phẩm công trình'],
        ['value' => 'ma_nhts1', 'text' => 'Nhóm tài sản 1'],
        ['value' => 'ma_nhts2', 'text' => 'Nhóm tài sản 2'],
        ['value' => 'ma_nhts3', 'text' => 'Nhóm tài sản 3'],
    ];
    
    public function index()
    {
        return view('fa.reports.bcts04', ['groupOptions' => $this->groupOptions]);
    }
    
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
            $request->ma_spct ?? '',
            $request->cap1 ?? '',
            $request->cap2 ?? '',
            $request->cap3 ?? ''
        ];
        
        $data = DB::select('EXEC sp_FARptBCTS04_GetData ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', $params);
        return response()->json(['data' => $data]);
    }
    
    public function getGroupOptions(Request $request)
    {
        $selected = $request->input('selected', []);
        $options = array_filter($this->groupOptions, function($opt) use ($selected) {
            return !in_array($opt['value'], $selected) || $opt['value'] === '';
        });
        return response()->json(['options' => array_values($options)]);
    }
}
```

## 7. Notes

- Báo cáo hỗ trợ nhóm theo 3 cấp độ
- Có 7 tiêu chí nhóm: BPSD, Phí, SPCT, Nhóm TS 1/2/3, và không nhóm
- Khi chọn nhóm cấp 1, các nhóm cấp 2/3 sẽ loại bỏ lựa chọn đã chọn ở cấp trên
- Có thể kết hợp filter theo nhiều tiêu chí cùng lúc
