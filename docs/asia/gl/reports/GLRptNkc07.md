# GlRptNkc07

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo nhật ký chung (NKC) - Mẫu 07 cho một tài khoản với chức năng drill-down

## Forms

### frmGlRptNkc07.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo nhật ký chung chi tiết cho một tài khoản với khả năng drill-down sang chi tiết

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cboKyBc | ComboBox | Kỳ báo cáo | SelectedIndexChanged |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu | ValueChanged |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc | ValueChanged |
| cboMau_bc | ComboBox | Mẫu báo cáo | SelectedIndexChanged |
| txtMa_Nt | AsTextBox | Mã ngoại tệ | TextChanged |
| optVND | RadioButton | Loại tiền VND | CheckedChanged |
| optNt | RadioButton | Loại tiền ngoại tệ | CheckedChanged |
| txtTk | AsTextBox | Tài khoản | AutoLookup, Validated |
| lblTen_Tk | Label | Tên tài khoản | - |
| lblTk | Label | Label "Tài khoản" | - |
| txtTieu_De | TextBox | Tiêu đề báo cáo | TextChanged |
| cmdOk | Button | Thực thi báo cáo | Click |
| cmdCancel | Button | Hủy | Click |
| cmdExcel | Button | Xuất Excel | Click |
| cmdModifyReport | Button | Sửa mẫu báo cáo | Click |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| components | IContainer | Container cho components |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| InitializeComponent | none | void | Khởi tạo UI |
| LoadData | none | bool | Tải dữ liệu báo cáo và tính toán dư đầu/cuối kỳ |
| ValidData | none | bool | Validate dữ liệu đầu vào - kiểm tra tài khoản bắt buộc |
| InitOtherComponents | none | void | Khởi tạo thêm components |
| CreateDrilldownArgument | drilldownInfo, sDrilldownMenuId, keycode, modifierKeys, filterCondition4title, datasource | ArrayList | Tạo tham số cho drill-down report |

## Data Access

Không có DAO riêng - sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| SP từ ReportInfo | Lấy dữ liệu NKC theo TK | @pMa_cty, @pNgay1, @pNgay2, @pTk, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc) -> Tự động tính ngày bắt đầu/kết thúc
2. Nhập tài khoản (txtTk) với AutoLookup
3. Chọn loại tiền và mã ngoại tệ
4. Click cmdOk để thực thi
5. Validate tài khoản bắt buộc phải có giá trị
6. Gọi LoadData() với 5 tham số
7. Tính toán và lưu các trường công thức (FomularFields):
   - TK: Mã tài khoản + Tên tài khoản
   - Du_Co_Cky: Dư có cuối kỳ (từ row 2)
   - Du_No_Cky: Dư nợ cuối kỳ (từ row 2)
   - Du_Co_Dky: Dư có đầu kỳ (từ row 0)
   - Du_No_Dky: Dư nợ đầu kỳ (từ row 0)

### Validation rules
- txtTk: Bắt buộc phải nhập
- Sử dụng ChkEmtyTextBox() để kiểm tra

### Parameters truyền vào SP
1. CompanyID - Mã công ty
2. Ngày bắt đầu (txtNgay1.Value)
3. Ngày kết thúc (txtNgay2.Value)
4. Tài khoản (txtTk.Text)
5. Mã ngoại tệ (txtMa_Nt.Text)

### Tính toán dư đầu/cuối kỳ
```csharp
base.MyFomularFields.Add("TK", ((TextBox)txtTk).Text + " - " + lblTen_Tk.Text);
base.MyFomularFields.Add("Du_Co_Cky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[2]["ps_co"]));
base.MyFomularFields.Add("Du_No_Cky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[2]["ps_no"]));
base.MyFomularFields.Add("Du_Co_Dky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[0]["ps_co"]));
base.MyFomularFields.Add("Du_No_Dky", RuntimeHelpers.GetObjectValue(get_MyDGVSource(isSet2Print: true).Rows[0]["ps_no"]));
```

### Drill-down functionality
- Khi nhấn F5 trên một dòng có tài khoản đối ứng (tk_du != ""):
  - Tạo tham số drill-down với: CompanyID, TK, TK đối ứng, Ngày 1, Ngày 2, Mã ngoại tệ
  - filterCondition4title = "TK/TK đối ứng"
- Nếu không có tk_du hoặc không phải F5 -> CancelDrilldown = true

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GlNkc | Nhật ký chung | R |
| DmTk | Danh mục tài khoản | R |
| DmNt | Danh mục ngoại tệ | R |

## Mapping sang PHP

### Controller
```php
class GlRptNkc07Controller extends ReportController {
    public function index() {
        $kyBaoCaoOptions = $this->getKyBaoCaoOptions();
        $mauBaoCaoOptions = $this->getReportTemplates('GlRptNkc07');
        return view('gl.rpt_nkc_07', compact('kyBaoCaoOptions', 'mauBaoCaoOptions'));
    }
    
    public function generate(Request $request) {
        $validator = Validator::make($request->all(), [
            'tk' => 'required|string|max:20'
        ]);
        
        if ($validator->fails()) {
            return response()->json(['errors' => $validator->errors()], 422);
        }
        
        $params = [
            'ma_cty' => session('company_id'),
            'ngay1' => $request->ngay1,
            'ngay2' => $request->ngay2,
            'tk' => $request->tk,
            'ma_nt' => $request->ma_nt
        ];
        $data = $this->reportService->getNkc07Data($params);
        
        // Tính toán dư đầu/cuối kỳ
        $tenTk = $data[0]->ten_tk ?? '';
        $fomularFields = [
            'TK' => $request->tk . ' - ' . $tenTk,
            'Du_Co_Cky' => $data[2]->ps_co ?? 0,
            'Du_No_Cky' => $data[2]->ps_no ?? 0,
            'Du_Co_Dky' => $data[0]->ps_co ?? 0,
            'Du_No_Dky' => $data[0]->ps_no ?? 0
        ];
        
        return $this->exportReport($data, $request->mau_bc, $fomularFields);
    }
    
    public function drillDown(Request $request) {
        // Xử lý drill-down khi click vào dòng có tk_du
        if ($request->keycode == 'F5' && !empty($request->tk_du)) {
            $params = [
                'ma_cty' => session('company_id'),
                'tk' => $request->tk,
                'tk_du' => $request->tk_du,
                'ngay1' => $request->ngay1,
                'ngay2' => $request->ngay2,
                'ma_nt' => $request->ma_nt
            ];
            $data = $this->reportService->getNkc07DrillDownData($params);
            $filterTitle = $request->tk . '/' . $request->tk_du;
            return $this->exportReport($data, 'drilldown', [], $filterTitle);
        }
        return response()->json(['error' => 'Invalid drill-down request'], 400);
    }
}
```

### Repository
```php
class GlRptNkc07Repository {
    public function getData($params) {
        return DB::select('EXEC [sp_GetNkc07Data] ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['tk'],
            $params['ma_nt']
        ]);
    }
    
    public function getDrillDownData($params) {
        return DB::select('EXEC [sp_GetNkc07DrillDown] ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['tk'],
            $params['tk_du'],
            $params['ngay1'],
            $params['ngay2'],
            $params['ma_nt']
        ]);
    }
}
```

### View (Blade)
```php
<form id="rptNkc07Form">
    <select name="ky_bc" id="cboKyBc">
        @foreach($kyBaoCaoOptions as $option)
            <option value="{{ $option->ma }}">{{ $option->ten_ky }}</option>
        @endforeach
    </select>
    
    <input type="date" name="ngay1" id="txtNgay1">
    <input type="date" name="ngay2" id="txtNgay2">
    
    <div class="form-group required">
        <label>Tài khoản</label>
        <input type="text" name="tk" id="txtTk" 
               required data-lookup="TK" data-name-control="lblTenTk">
        <span id="lblTenTk"></span>
    </div>
    
    <button type="submit">Xem báo cáo</button>
</form>

<script>
// Xử lý drill-down khi nhấn F5
document.addEventListener('keydown', function(e) {
    if (e.key === '