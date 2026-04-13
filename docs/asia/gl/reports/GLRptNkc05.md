# GlRptNkc05

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo nhật ký chung (NKC) - Mẫu 05 cho chi phí (NVL, hàng hóa, kho khác, phải trả)

## Forms

### frmGlRptNkc05.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo nhật ký chung chi phí với filter theo 4 loại tài khoản chi phí

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
| txtDs_Tk_hh | AsTextBox | TK hàng hóa | AutoLookup |
| txtDs_Tk_nvl | AsTextBox | TK NVL | AutoLookup |
| txtDs_Tk_khac | AsTextBox | TK kho khác | AutoLookup |
| txtDs_Tk_pt | AsTextBox | TK phải trả | AutoLookup |
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
| lblDs_Tk_nvl_Click | sender, EventArgs | void | Event handler (empty) |

## Data Access

Không có DAO riêng - sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| SP từ ReportInfo | Lấy dữ liệu NKC Chi phí | @pMa_cty, @pNgay1, @pNgay2, @pTk_Pt, @pTk_Hh, @pTk_Nvl, @pTk_Khac, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc) -> Tự động tính ngày bắt đầu/kết thúc
2. Nhập các tài khoản chi phí:
   - TK hàng hóa (txtDs_Tk_hh)
   - TK NVL (txtDs_Tk_nvl)
   - TK kho khác (txtDs_Tk_khac)
   - TK phải trả (txtDs_Tk_pt)
3. Chọn loại tiền và mã ngoại tệ
4. Click cmdOk để thực thi
5. Gọi LoadData() với 8 tham số

### Parameters truyền vào SP
1. CompanyID - Mã công ty
2. Ngày bắt đầu (txtNgay1.Value)
3. Ngày kết thúc (txtNgay2.Value)
4. TK phải trả (txtDs_Tk_pt.Text)
5. TK hàng hóa (txtDs_Tk_hh.Text)
6. TK NVL (txtDs_Tk_nvl.Text)
7. TK kho khác (txtDs_Tk_khac.Text)
8. Mã ngoại tệ (txtMa_Nt.Text)

### Khởi tạo giá trị mặc định
- txtDs_Tk_pt: Lấy từ MyMenuInfo.par2
- txtDs_Tk_hh: Lấy từ MyMenuInfo.par3
- txtDs_Tk_nvl: Lấy từ MyMenuInfo.par4
- txtDs_Tk_khac: Lấy từ MyMenuInfo.par5

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GlNkc | Nhật ký chung | R |
| DmTk | Danh mục tài khoản | R |
| DmNt | Danh mục ngoại tệ | R |

## Mapping sang PHP

### Controller
```php
class GlRptNkc05Controller extends ReportController {
    public function index() {
        $kyBaoCaoOptions = $this->getKyBaoCaoOptions();
        $mauBaoCaoOptions = $this->getReportTemplates('GlRptNkc05');
        return view('gl.rpt_nkc_05', compact('kyBaoCaoOptions', 'mauBaoCaoOptions'));
    }
    
    public function generate(Request $request) {
        $params = [
            'ma_cty' => session('company_id'),
            'ngay1' => $request->ngay1,
            'ngay2' => $request->ngay2,
            'tk_pt' => $request->ds_tk_pt,
            'tk_hh' => $request->ds_tk_hh,
            'tk_nvl' => $request->ds_tk_nvl,
            'tk_khac' => $request->ds_tk_khac,
            'ma_nt' => $request->ma_nt
        ];
        $data = $this->reportService->getNkc05Data($params);
        return $this->exportReport($data, $request->mau_bc);
    }
}
```

### Repository
```php
class GlRptNkc05Repository {
    public function getData($params) {
        return DB::select('EXEC [sp_GetNkc05Data] ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['tk_pt'],
            $params['tk_hh'],
            $params['tk_nvl'],
            $params['tk_khac'],
            $params['ma_nt']
        ]);
    }
}
```

### View (Blade)
```php
<form id="rptNkc05Form">
    <select name="ky_bc" id="cboKyBc">
        @foreach($kyBaoCaoOptions as $option)
            <option value="{{ $option->ma }}">{{ $option->ten_ky }}</option>
        @endforeach
    </select>
    
    <input type="date" name="ngay1" id="txtNgay1">
    <input type="date" name="ngay2" id="txtNgay2">
    
    <div class="form-group">
        <label>TK hàng hóa</label>
        <input type="text" name="ds_tk_hh" id="txtDsTkHh" 
               data-lookup="TK">
    </div>
    
    <div class="form-group">
        <label>TK NVL</label>
        <input type="text" name="ds_tk_nvl" id="txtDsTkNvl" 
               data-lookup="TK">
    </div>
    
    <div class="form-group">
        <label>TK kho khác</label>
        <input type="text" name="ds_tk_khac" id="txtDsTkKhac" 
               data-lookup="TK">
    </div>
    
    <div class="form-group">
        <label>TK phải trả</label>
        <input type="text" name="ds_tk_pt" id="txtDsTkPt" 
               data-lookup="TK">
    </div>
    
    <button type="submit">Xem báo cáo</button>
</form>
```

## Ghi chú
- Đây là báo cáo chuyên biệt cho chi phí với 4 loại tài khoản
- Có lblDs_Tk_nvl_Click event nhưng không có xử lý (empty method)
- Sử dụng AutoLookup cho tất cả các trường tài khoản
- Thứ tự parameters: TK phải trả, TK hàng hóa, TK NVL, TK kho khác
- Khác với NKC04 (doanh thu), báo cáo này không có validation bắt buộc
