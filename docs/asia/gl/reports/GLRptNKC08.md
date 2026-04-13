# GLRptNKC08

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo nhật ký chung (NKC) - Mẫu 08 cho một tài khoản (dạng mở rộng)

## Forms

### frmGLRptNKC08.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo nhật ký chung chi tiết cho một tài khoản với giao diện mở rộng

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cboKyBc | ComboBox | Kỳ báo cáo | SelectedIndexChanged |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu | ValueChanged |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc | ValueChanged |
| cboMau_bc | ComboBox | Mẫu báo cáo | SelectedIndexChanged |
| txtMa_Nt | AsTextBox | Mã ngoại tệ | TextChanged (hidden) |
| optVND | RadioButton | Loại tiền VND | CheckedChanged (hidden) |
| optNt | RadioButton | Loại tiền ngoại tệ | CheckedChanged (hidden) |
| txtTk | AsTextBox | Tài khoản | AutoLookup |
| lblTk | Label | Tên tài khoản | - |
| Label1 | Label | Label "Tài khoản" | - |
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
| ValidData | none | bool | Validate dữ liệu đầu vào - kiểm tra tài khoản bắt buộc |

## Data Access

Không có DAO riêng - sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| SP từ ReportInfo | Lấy dữ liệu NKC theo TK | @pMa_cty, @pNgay1, @pNgay2, @pTk | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc) -> Tự động tính ngày bắt đầu/kết thúc
2. Nhập tài khoản (txtTk) với AutoLookup
3. Click cmdOk để thực thi
4. Validate tài khoản bắt buộc phải có giá trị
5. Gọi LoadData() với 4 tham số

### Validation rules
- txtTk: Bắt buộc phải nhập
- Sử dụng epNotice để hiển thị lỗi
- Mã lỗi 50002: "Trường bắt buộc"

### Parameters truyền vào SP
1. CompanyID - Mã công ty
2. Ngày bắt đầu (txtNgay1.Value)
3. Ngày kết thúc (txtNgay2.Value)
4. Tài khoản (txtTk.Text)

### Đặc điểm giao diện
- Các controls liên quan đến ngoại tệ (txtMa_Nt, optVND, optNt, lblMa_nt, lblMauBC) bị ẩn (Visible = false)
- Form có kích thước lớn hơn: 790x510
- txtTk có kích thước 90x20
- lblTk hiển thị tên tài khoản với kích thước 321x20

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GlNkc | Nhật ký chung | R |
| DmTk | Danh mục tài khoản | R |

## Mapping sang PHP

### Controller
```php
class GLRptNKC08Controller extends ReportController {
    public function index() {
        $kyBaoCaoOptions = $this->getKyBaoCaoOptions();
        $mauBaoCaoOptions = $this->getReportTemplates('GLRptNKC08');
        return view('gl.rpt_nkc_08', compact('kyBaoCaoOptions', 'mauBaoCaoOptions'));
    }
    
    public function generate(Request $request) {
        $validator = Validator::make($request->all(), [
            'tk' => 'required|string|max:20'
        ], [
            'required' => 'Tài khoản không được để trống'
        ]);
        
        if ($validator->fails()) {
            return response()->json(['errors' => $validator->errors()], 422);
        }
        
        $params = [
            'ma_cty' => session('company_id'),
            'ngay1' => $request->ngay1,
            'ngay2' => $request->ngay2,
            'tk' => $request->tk
        ];
        $data = $this->reportService->getNkc08Data($params);
        return $this->exportReport($data, $request->mau_bc);
    }
}
```

### Repository
```php
class GLRptNKC08Repository {
    public function getData($params) {
        return DB::select('EXEC [sp_GetNkc08Data] ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['tk']
        ]);
    }
}
```

### View (Blade)
```php
<form id="rptNkc08Form">
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
               required data-lookup="TK" data-name-control="lblTk">
        <span id="lblTk"></span>
    </div>
    
    <button type="submit">Xem báo cáo</button>
</form>
```

## Ghi chú
- Đây là báo cáo nhật ký chung dạng mở rộng (full size)
- Không hỗ trợ lọc theo ngoại tệ (các controls bị ẩn)
- Chỉ cần nhập tài khoản là đủ điều kiện báo cáo
- txtTk có AutoValid = true (bắt buộc validate)
- Constructor là protected (có thể dùng cho inheritance)
