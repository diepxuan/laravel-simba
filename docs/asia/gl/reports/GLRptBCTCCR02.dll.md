# GLRptBCTCCR02.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo tài chính - Bảng cân đối tài chính (BCTCCR02)

## Forms

### frmGLRptBCTCCR02.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng cân đối tài chính với khả năng khai báo công thức

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cmdBS | Button | - | cmdBS_Click |
| chkChiTieuCoSoLieu | CheckBox | - | - |
| cboKyBc | ComboBox | KyBaoCao | SelectedValueChanged |
| txtNgay1 | AsMaskedTextBox | Date | - |
| txtNgay2 | AsMaskedTextBox | Date | - |
| cboMau_bc | ComboBox | ReportTemplate | - |
| txtMa_Nt | AsTextBox | Currency | - |
| optVND | RadioButton | CurrencyType | - |
| optNt | RadioButton | CurrencyType | - |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| MyReportInfo | ReportInformation | Thông tin báo cáo |
| MyController | IReportController | Controller xử lý dữ liệu |
| Parameters4DrillDown | AsDictionary | Tham số drill-down |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Tải dữ liệu báo cáo |
| CreateDrilldownArgument | ReportDrillDownInfo, Keys, Keys | ArrayList | Tạo tham số drill-down |
| cmdBS_Click | sender, EventArgs | void | Mở form khai báo công thức |
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |

### frmGLMauBS01.cs
- **Kế thừa**: frmBase
- **Chức năng**: Form khai báo mẫu công thức tính toán

### frmGLMauBS01Edit.cs
- **Kế thừa**: frmBase
- **Chức năng**: Form chỉnh sửa mẫu công thức

## Data Access

### GLRptBCTCCR02Controller
- **Interface**: IReportController
- **Implementation**: MssqlReportController

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetData | sp_GL_Rpt_BCTCCR02 | company_id, year, ngay2, chkCoSoLieu, ma_mau | DataTable | Lấy dữ liệu báo cáo |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_GL_Rpt_BCTCCR02 | Lấy dữ liệu báo cáo | @company_id, @year, @ngay2, @chkCoSoLieu, @ma_mau | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc)
2. Người dùng chọn ngày báo cáo (txtNgay2)
3. Người dùng chọn mẫu báo cáo (cboMau_bc)
4. Người dùng chọn loại tiền tệ (optVND/optNt)
5. Người dùng tick "Chỉ lên cho các chỉ tiêu có số liệu" (chkChiTieuCoSoLieu)
6. Nhấn OK để tải dữ liệu
7. Hệ thống gọi SP sp_GL_Rpt_BCTCCR02
8. Hiển thị dữ liệu lên DataGridView

### Validation rules
- Ngày báo cáo phải hợp lệ
- Phải chọn mẫu báo cáo

### Drill-down logic
- F5: Drill-down xem chi tiết công thức
- Ctrl+F5: Drill-down xem sổ chi tiết
- Shift+F5: Drill-down xem cân đối phát sinh công nợ

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_BCTCCR02 | Mẫu báo cáo | R |
| GL_TK | Tài khoản | R |
| GL_SOCT | Sổ chứng từ | R |

## Mapping sang PHP

### Controller
```php
class BCTCCR02Controller extends Controller {
    public function index() {
        // Hiển thị form filter
    }
    
    public function getData(Request $request) {
        $company_id = $request->input('company_id');
        $year = $request->input('year');
        $ngay2 = $request->input('ngay2');
        $chkCoSoLieu = $request->input('chkCoSoLieu');
        $ma_mau = $request->input('ma_mau');
        
        $data = DB::select('sp_GL_Rpt_BCTCCR02', [
            $company_id, $year, $ngay2, $chkCoSoLieu, $ma_mau
        ]);
        
        return response()->json($data);
    }
}
```

### Repository
```php
class BCTCCR02Repository {
    public function getReportData($params) {
        return DB::select('sp_GL_Rpt_BCTCCR02', $params);
    }
}
```

### Model
```php
class BCTCCR02 extends Model {
    protected $table = 'GL_BCTCCR02';
}
```

## Ghi chú
- Báo cáo này hỗ trợ khai báo công thức tính toán thông qua nút "KB Công thức"
- Hỗ trợ drill-down để xem chi tiết các chỉ tiêu
- Có thể lọc chỉ hiển thị các chỉ tiêu có số liệu
