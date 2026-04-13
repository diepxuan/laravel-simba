# GlRptNkc02

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo nhật ký chung (NKC) - Mẫu 02

## Forms

### frmGlRptNkc02.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo nhật ký chung với các tham số cơ bản

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
| InitOtherComponents | none | void | Khởi tạo thêm components |

## Data Access

Không có DAO riêng - sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| SP từ ReportInfo | Lấy dữ liệu NKC | @pMa_cty, @pNgay1, @pNgay2, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc) -> Tự động tính ngày bắt đầu/kết thúc
2. Chọn mẫu báo cáo (cboMau_bc)
3. Chọn loại tiền (VND/Ngoại tệ)
4. Nhập mã ngoại tệ nếu chọn ngoại tệ
5. Click cmdOk để thực thi
6. Gọi LoadData() để lấy dữ liệu từ database
7. Hiển thị báo cáo

### Parameters truyền vào SP
1. CompanyID - Mã công ty
2. Ngày bắt đầu (txtNgay1.Value)
3. Ngày kết thúc (txtNgay2.Value)
4. Mã ngoại tệ (txtMa_Nt.Text)

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GlNkc | Nhật ký chung | R |
| DmNt | Danh mục ngoại tệ | R |
| DmTk | Danh mục tài khoản | R |

## Mapping sang PHP

### Controller
```php
class GlRptNkc02Controller extends ReportController {
    public function index() {
        $kyBaoCaoOptions = $this->getKyBaoCaoOptions();
        $mauBaoCaoOptions = $this->getReportTemplates('GlRptNkc02');
        return view('gl.rpt_nkc_02', compact('kyBaoCaoOptions', 'mauBaoCaoOptions'));
    }
    
    public function generate(Request $request) {
        $params = [
            'ma_cty' => session('company_id'),
            'ngay1' => $request->ngay1,
            'ngay2' => $request->ngay2,
            'ma_nt' => $request->ma_nt
        ];
        $data = $this->reportService->getNkc02Data($params);
        return $this->exportReport($data, $request->mau_bc);
    }
}
```

### Repository
```php
class GlRptNkc02Repository {
    public function getData($params) {
        return DB::select('EXEC [sp_GetNkc02Data] ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['ma_nt']
        ]);
    }
}
```

### View (Blade)
```php
<form id="rptNkc02Form">
    <select name="ky_bc" id="cboKyBc">
        @foreach($kyBaoCaoOptions as $option)
            <option value="{{ $option->ma }}">{{ $option->ten_ky }}</option>
        @endforeach
    </select>
    
    <input type="date" name="ngay1" id="txtNgay1">
    <input type="date" name="ngay2" id="txtNgay2">
    
    <select name="mau_bc" id="cboMauBc">
        @foreach($mauBaoCaoOptions as $mau)
            <option value="{{ $mau->ma_mau }}">{{ $mau->ten_mau }}</option>
        @endforeach
    </select>
    
    <input type="text" name="ma_nt" id="txtMaNt" maxlength="3">
    
    <input type="radio" name="loai_tien" value="VND" checked> VND
    <input type="radio" name="loai_tien" value="NT"> Ngoại tệ
    
    <button type="submit">Xem báo cáo</button>
</form>
```

## Ghi chú
- Đây là báo cáo nhật ký chung cơ bản với filter đơn giản
- Không có DAO riêng, sử dụng cơ chế report chung của framework
- Hỗ trợ xuất Excel và in ấn qua Crystal Reports
