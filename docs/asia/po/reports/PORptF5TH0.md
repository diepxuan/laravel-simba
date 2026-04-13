# PORptF5TH0 - Bao Cao Drilldown F5 Tong Hop

## 1. Thong tin chung

| Thuoc tinh | Gia tri |
|------------|---------|
| Ten DLL | PORptF5TH0 |
| Form chinh | frmPORptF5TH0 |
| Loai | Drilldown Report |
| Module | PO (Purchasing) |
| Mo ta | Form drilldown khi nhan F5 tu bao cao tong hop |

## 2. Cau truc Form

### 2.1. Form Class

```csharp
public class frmPORptF5TH0 : frmDrilldownReport
{
    // Ke thua tu frmDrilldownReport
    // Form hien thi chi tiet khi drilldown tu bao cao tong hop
}
```

### 2.2. Constructors

```csharp
// Constructor chinh voi day du tham so
public frmPORptF5TH0(
    ReportInformation motherReportInfo, 
    string drilldown_menuid, 
    AsDictionary formularFields, 
    bool isNT, 
    string nhan_in, 
    string filter4Tilte, 
    string formatedColList, 
    ref object datasource, 
    params object[] arg
) : base(motherReportInfo, drilldown_menuid, formularFields, isNT, nhan_in, filter4Tilte, formatedColList, RuntimeHelpers.GetObjectValue(datasource), arg)
{
    InitializeComponent();
}

// Constructor mac dinh
public frmPORptF5TH0()
{
    InitializeComponent();
}
```

### 2.3. Methods

```csharp
protected override ArrayList CreateDrilldownArgument(
    ReportDrillDownInfo drilldownInfo, 
    ref string sDrilldownMenuId, 
    Keys keycode, 
    Keys modifierKeys, 
    ref string filterCondition4title, 
    [Optional][DefaultParameterValue(null)] ref object datasource
)
{
    // Goi phuong thuc base
    return base.CreateDrilldownArgument(drilldownInfo, ref sDrilldownMenuId, keycode, modifierKeys, ref filterCondition4title, ref datasource);
}
```

## 3. Business Logic

### 3.1. Chuc nang

- Form nay duoc su dung de hien thi chi tiet khi nguoi dung nhan F5 tu cac bao cao tong hop
- Nhan du lieu tu bao cao cha (mother report) thong qua drilldown mechanism
- Hien thi thong tin chi tiet theo dieu kien loc tu bao cao goc

### 3.2. Drilldown Flow

1. Nguoi dung nhan F5 tren dong du lieu trong bao cao tong hop
2. He thong goi `CreateDrilldownArgument` de tao tham so drilldown
3. Form PORptF5TH0 duoc mo voi du lieu chi tiet tuong ung
4. Hien thi thong tin chi tiet theo ma vat tu, nha cung cap, hoac cac tieu chi khac

## 4. Mapping sang PHP

### 4.1. Controller

```php
<?php
namespace App\Http\Controllers\PO;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class DrilldownController extends Controller
{
    /**
     * Hien thi chi tiet drilldown tu bao cao tong hop
     */
    public function detail(Request $request)
    {
        $params = $request->input('params', []);
        $filterTitle = $request->input('filter_title', '');
        
        // Lay du lieu chi tiet
        $data = $this->getDrilldownData($params);
        
        return view('po.reports.drilldown', [
            'data' => $data,
            'filterTitle' => $filterTitle
        ]);
    }
    
    private function getDrilldownData($params)
    {
        // Logic lay du lieu chi tiet
        // Su dung SP tuong ung voi bao cao goc
    }
}
```

### 4.2. JavaScript xu ly F5

```javascript
$(document).on('keydown', '#reportTable', function(e) {
    if (e.keyCode === 116) { // F5 key
        e.preventDefault();
        
        var row = $(this).find('tr.selected');
        var rowData = getRowData(row);
        
        $.ajax({
            url: '/po/drilldown/detail',
            type: 'POST',
            data: {
                params: rowData,
                filter_title: getCurrentFilterTitle()
            },
            success: function(response) {
                openDrilldownModal(response);
            }
        });
    }
});
```

## 5. Luu y chuyen doi

1. Drilldown trong web thuong su dung modal hoac tab moi
2. Can truyen du tham so tu bao cao goc sang bao cao chi tiet
3. Xu ly phim tat F5 can tranh conflict voi refresh trang
