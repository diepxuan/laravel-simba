# GLRptBCTCCR04.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo tài chính - Bảng cân đối tài chính so sánh kỳ trước (BCTCCR04)

## Forms

### frmGLRptBCTCCR04.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng cân đối tài chính so sánh với kỳ trước (dạng khác)

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cboKyTruoc | ComboBox | KyBaoCao | SelectedValueChanged |
| txtNgay01 | AsMaskedTextBox | Date | - |
| txtNgay02 | AsMaskedTextBox | Date | - |
| cboKyBc | ComboBox | KyBaoCao | - |
| txtNgay1 | AsMaskedTextBox | Date | - |
| txtNgay2 | AsMaskedTextBox | Date | - |
| cmdCF | Button | - | cmdCF_Click |
| cboMau_bc | ComboBox | ReportTemplate | - |
| txtMa_Nt | AsTextBox | Currency | - |
| optVND | RadioButton | CurrencyType | - |
| optNt | RadioButton | CurrencyType | - |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Tải dữ liệu báo cáo |
| GetFilterCondiction | - | string | Lấy chuỗi điều kiện filter |
| InitKyBaoCaoTruoc | - | void | Khởi tạo kỳ báo cáo trước |
| cboKyTruoc_SelectedValueChanged | sender, EventArgs | void | Xử lý chọn kỳ trước |
| cmdCF_Click | sender, EventArgs | void | Mở form khai báo công thức |
| CreateDrilldownArgument | ReportDrillDownInfo, Keys, Keys | ArrayList | Tạo tham số drill-down |

### frmGLMauCF01.cs
- **Kế thừa**: frmBase
- **Chức năng**: Form khai báo mẫu công thức

### frmGLMauCF01Edit.cs
- **Kế thừa**: frmBase
- **Chức năng**: Form chỉnh sửa mẫu công thức

## Data Access

### GLRptBCTCCR04Controller
- **Interface**: IReportController
- **Implementation**: MssqlReportController

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetData | sp_GL_Rpt_BCTCCR04 | company_id, year, ngay1, ngay2, ngay01, ngay02, ma_mau, ma_nt | DataTable | Lấy dữ liệu báo cáo |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_GL_Rpt_BCTCCR04 | Lấy dữ liệu báo cáo so sánh | @company_id, @year, @ngay1, @ngay2, @ngay01, @ngay02, @ma_mau, @ma_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo hiện tại (cboKyBc)
2. Người dùng chọn kỳ báo cáo trước (cboKyTruoc)
3. Hệ thống tự động tính ngày cho kỳ trước (txtNgay01, txtNgay02)
4. Người dùng chọn loại tiền tệ
5. Nhấn OK để tải dữ liệu
6. Hệ thống gọi SP sp_GL_Rpt_BCTCCR04
7. Hiển thị dữ liệu so sánh giữa 2 kỳ

### Drill-down logic
- F5: Drill-down xem chi tiết công thức
- Ctrl+F5: Drill-down xem sổ chi tiết

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_BCTCCR04 | Mẫu báo cáo | R |
| GL_TK | Tài khoản | R |
| GL_SOCT | Sổ chứng từ | R |

## Mapping sang PHP

### Controller
```php
class BCTCCR04Controller extends Controller {
    public function index() {
        // Hiển thị form filter
    }
    
    public function getData(Request $request) {
        $params = [
            $request->input('company_id'),
            $request->input('year'),
            $request->input('ngay1'),
            $request->input('ngay2'),
            $request->input('ngay01'),
            $request->input('ngay02'),
            $request->input('ma_mau'),
            $request->input('ma_nt')
        ];
        
        $data = DB::select('sp_GL_Rpt_BCTCCR04', $params);
        return response()->json($data);
    }
}
```

## Ghi chú
- Báo cáo so sánh giữa kỳ hiện tại và kỳ trước (dạng khác với BCTCCR03)
- Hỗ trợ khai báo công thức thông qua nút "KB Công thức"
