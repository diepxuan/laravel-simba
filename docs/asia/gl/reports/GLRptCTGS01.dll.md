# GLRptCTGS01.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Chứng từ ghi sổ (CTGS01)

## Forms

### frmGLRptCTGS01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form in chứng từ ghi sổ

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cboKyBc | ComboBox | KyBaoCao | - |
| txtNgay1 | AsMaskedTextBox | Date | - |
| txtNgay2 | AsMaskedTextBox | Date | - |
| cboMau_bc | ComboBox | ReportTemplate | - |
| txtMa_Nt | AsTextBox | Currency | - |
| optVND | RadioButton | CurrencyType | - |
| optNt | RadioButton | CurrencyType | - |
| cmdOk | Button | - | - |
| cmdCancel | Button | - | - |
| cmdExcel | Button | - | - |
| cmdModifyReport | Button | - | - |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Tải dữ liệu chứng từ |
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |
| CreateDrilldownArgument | ReportDrillDownInfo, Keys, Keys | ArrayList | Tạo tham số drill-down |

## Data Access

### GLRptCTGS01Controller
- **Interface**: IReportController
- **Implementation**: MssqlReportController

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetData | sp_GL_Rpt_CTGS01 | company_id, ngay1, ngay2, ma_nt | DataTable | Lấy dữ liệu chứng từ |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_GL_Rpt_CTGS01 | Lấy dữ liệu CTGS | @company_id, @ngay1, @ngay2, @ma_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc)
2. Người dùng chọn mẫu in (cboMau_bc)
3. Người dùng chọn loại tiền tệ
4. Nhấn OK để tải dữ liệu
5. Hệ thống gọi SP sp_GL_Rpt_CTGS01
6. Hiển thị dữ liệu chứng từ

### Drill-down logic
- F5: Drill-down xem chi tiết chứng từ

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_SOCT | Sổ chứng từ | R |
| GL_CTGS | Chứng từ ghi sổ | R |

## Mapping sang PHP

### Controller
```php
class CTGS01Controller extends Controller {
    public function index() {
        // Hiển thị form filter
    }
    
    public function getData(Request $request) {
        $params = [
            $request->input('company_id'),
            $request->input('ngay1'),
            $request->input('ngay2'),
            $request->input('ma_nt')
        ];
        
        $data = DB::select('sp_GL_Rpt_CTGS01', $params);
        return response()->json($data);
    }
}
```

## Ghi chú
- Báo cáo in chứng từ ghi sổ theo kỳ
- Hỗ trợ drill-down để xem chi tiết từng chứng từ
