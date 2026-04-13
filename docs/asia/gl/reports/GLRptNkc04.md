# GlRptNkc04

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo nhật ký chung (NKC) - Mẫu 04 cho doanh thu (hàng hóa, thành phẩm, dịch vụ, phải thu)

## Forms

### frmGlRptNkc04.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo nhật ký chung doanh thu với filter theo 4 loại tài khoản doanh thu

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
| txtDs_Tk_Dt_hh | AsTextBox | TK doanh thu hàng hóa | AutoLookup |
| txtDs_Tk_Dt_tp | AsTextBox | TK doanh thu thành phẩm | AutoLookup |
| txtDs_Tk_Dt_dv | AsTextBox | TK doanh thu dịch vụ | AutoLookup |
| txtDs_Tk_pt | AsTextBox | TK phải thu | AutoLookup |
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
| LoadData | none | bool | Tải dữ liệu báo cáo |
| InitOtherComponents | none | void | Khởi tạo thêm components, set giá trị mặc định |
| ValidData | none | bool | Validate dữ liệu đầu vào - kiểm tra các trường bắt buộc |

## Data Access

Không có DAO riêng - sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| SP từ ReportInfo | Lấy dữ liệu NKC Doanh thu | @pMa_cty, @pNgay1, @pNgay2, @pTk_Pt, @pTk_Dt_Hh, @pTk_Dt_Tp, @pTk_Dt_Dv, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc) -> Tự động tính ngày bắt đầu/kết thúc
2. Nhập các tài khoản doanh thu:
   - TK doanh thu hàng hóa (txtDs_Tk_Dt_hh)
   - TK doanh thu thành phẩm (txtDs_Tk_Dt_tp)
   - TK doanh thu dịch vụ (txtDs_Tk_Dt_dv)
   - TK phải thu (txtDs_Tk_pt)
3. Chọn loại tiền và mã ngoại tệ
4. Click cmdOk để thực thi
5. Validate tất cả các trường bắt buộc phải có giá trị
6. Gọi LoadData() với 8 tham số

### Validation rules
- Tất cả 4 trường tài khoản là bắt buộc:
  - txtDs_Tk_Dt_dv (TK doanh thu dịch vụ)
  - txtDs_Tk_Dt_hh (TK doanh thu hàng hóa)
  - txtDs_Tk_Dt_tp (TK doanh thu thành phẩm)
  - txtDs_Tk_pt (TK phải thu)
- Sử dụng Commons.ChkEmtyTextBoxAndShowMessageBox() để kiểm tra

### Parameters truyền vào SP
1. CompanyID - Mã công ty
2. Ngày bắt đầu (txtNgay1.Value)
3. Ngày kết thúc (txtNgay2.Value)
4. TK phải thu (txtDs_Tk_pt.Text)
5. TK doanh thu hàng hóa (txtDs_Tk_Dt_hh.Text)
6. TK doanh thu thành phẩm (txtDs_Tk_Dt_tp.Text)
7. TK doanh thu dịch vụ (txtDs_Tk_Dt_dv.Text)
8. Mã ngoại tệ (txtMa_Nt.Text)

### Khởi tạo giá trị mặc định
- txtDs_Tk_pt: Lấy từ MyMenuInfo.par2
- txtDs_Tk_Dt_hh: Lấy từ MyMenuInfo.par3
- txtDs_Tk_Dt_tp: Lấy từ MyMenuInfo.par4
- txtDs_Tk_Dt_dv: Lấy từ MyMenuInfo.par5

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GlNkc | Nhật ký chung | R |
| DmTk | Danh mục tài khoản | R |
| DmNt | Danh mục ngoại tệ | R |

## Mapping sang PHP

### Controller
```php
class GlRptNkc04Controller extends ReportController {
    public function index() {
        $kyBaoCaoOptions = $this->getKyBaoCaoOptions();
        $mauBaoCaoOptions = $this->getReportTemplates('GlRptNkc04');
        return view('gl.rpt_nkc_04', compact('kyBaoCaoOptions', 'mauBaoCaoOptions'));
    }
    
    public function generate(Request $request) {
        $validator = Validator::make($request->all(), [
            'ds_tk_pt' => 'required|string|max:20',
            'ds_tk_dt_hh' => 'required|string|max:20',
            'ds_tk_dt_tp' => 'required|string|max:20',
            'ds_tk_dt_dv' => 'required|string|max:20',
        ], [
            'required' => 'Trường :attribute không được để trống'
        ]);
        
        if ($validator->fails()) {
            return response()->json(['errors' => $validator->errors()], 422);
        }
        
        $params = [
            'ma_cty' => session('company_id'),
            'ngay1' => $request->ngay1,
            'ngay2' => $request->ngay2,
            'tk_pt' => $request->ds_tk_pt,
            'tk_dt_hh' => $request->ds_tk_dt_hh,
            'tk_dt_tp' => $request->ds_tk_dt_tp,
            'tk_dt_dv' => $request->ds_tk_dt_dv,
            'ma_nt' => $request->ma_nt
        ];
        $data = $this->reportService->getNkc04Data($params);
        return $this->exportReport($data, $request->mau_bc);
    }
}
```

### Repository
```php
class GlRptNkc04Repository {
    public function getData($params) {
        return DB::select('EXEC [sp_GetNkc04Data] ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['tk_pt'],
            $params['tk_dt_hh'],
            $params['tk_dt_tp'],
            $params['tk_dt_dv'],
            $params['ma_nt']
        ]);
    }
}
```

### View (Blade)
```php
<form id="rptNkc04Form">
    <select name="ky_bc" id="cboKyBc">
        @foreach($kyBaoCaoOptions as $option)
            <option value="{{ $option->ma }}">{{ $option->ten_ky }}</option>
        @endforeach
    </select>
    
    <input type="date" name="ngay1" id="txtNgay1">
    <input type="date" name="ngay2" id="txtNgay2">
    
    <div class="form-group required">
        <label>TK doanh thu hàng hóa</label>
        <input type="text" name="ds_tk_dt_hh" id="txtDsTkDtHh" 
               required data-lookup="TK">
    </div>
    
    <div class="form-group required">
        <label>TK doanh thu thành phẩm</label>
        <input type="text" name="ds_tk_dt_tp" id="txtDsTkDtTp" 
               required data-lookup="TK">
    </div>
    
    <div class="form-group required">
        <label>TK doanh thu dịch vụ</label>
        <input type="text" name="ds_tk_dt_dv" id="txtDsTkDtDv" 
               required data-lookup="TK">
    </div>
    
    <div class="form-group required">
        <label>TK phải thu</label>
        <input type="text" name="ds_tk_pt" id="txtDsTkPt" 
               required data-lookup="TK">
    </div>
    
    <button type="submit">Xem báo cáo</button>
</form>
```

## Ghi chú
- Đây là báo cáo chuyên biệt cho doanh thu với 4 loại tài khoản
- Tất cả 4 trường tài khoản là bắt buộc (required)
- Sử dụng AutoLookup cho tất cả các trường tài khoản
- Thứ tự parameters: TK phải thu, TK DT hàng hóa, TK DT thành phẩm, TK DT dịch vụ
