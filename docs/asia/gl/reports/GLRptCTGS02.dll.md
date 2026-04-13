# GLRptCTGS02.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Chứng từ ghi sổ (CTGS02) - Dạng có chọn lọc

## Forms

### frmGLRptCTGS02.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form in chứng từ ghi sổ với khả năng chọn lọc

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtTu_so | AsTextBox | So_Ct | - |
| txtDen_so | AsTextBox | So_Ct | - |
| lblTu_so | Label | - | - |
| lblDen_so | Label | - | - |
| cboKyBc | ComboBox | KyBaoCao | - |
| txtNgay1 | AsMaskedTextBox | Date | - |
| txtNgay2 | AsMaskedTextBox | Date | - |
| cboMau_bc | ComboBox | ReportTemplate | - |
| txtMa_Nt | AsTextBox | Currency | - |
| optVND | RadioButton | CurrencyType | - |
| optNt | RadioButton | CurrencyType | - |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Tải dữ liệu chứng từ |
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |
| FormatGridView | - | void | Định dạng DataGridView |
| dgvBC_CellEnter | sender, DataGridViewCellEventArgs | void | Xử lý cell enter |
| CreateDrilldownArgument | ReportDrillDownInfo, Keys, Keys | ArrayList | Tạo tham số drill-down |
| LoadDataToCrystal | - | DataTable | Tải dữ liệu cho Crystal Report |
| ViewCrystalBySource | - | void | Xem Crystal Report |

## Data Access

### GLRptCTGS02Controller
- **Interface**: IReportController
- **Implementation**: MssqlReportController

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetData | sp_GL_Rpt_CTGS02 | company_id, ngay1, ngay2, tu_so, den_so, ma_nt | DataTable | Lấy dữ liệu chứng từ |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_GL_Rpt_CTGS02 | Lấy dữ liệu CTGS | @company_id, @ngay1, @ngay2, @tu_so, @den_so, @ma_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc)
2. Người dùng nhập số chứng từ từ (txtTu_so) đến (txtDen_so)
3. Người dùng chọn mẫu in (cboMau_bc)
4. Người dùng chọn loại tiền tệ
5. Nhấn OK để tải dữ liệu
6. Hệ thống gọi SP sp_GL_Rpt_CTGS02
7. Hiển thị dữ liệu chứng từ với cột TAG để chọn in

### Validation rules
- Phải chọn mẫu báo cáo

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_SOCT | Sổ chứng từ | R |
| GL_CTGS | Chứng từ ghi sổ | R |

## Mapping sang PHP

### Controller
```php
class CTGS02Controller extends Controller {
    public function index() {
        // Hiển thị form filter
    }
    
    public function getData(Request $request) {
        $params = [
            $request->input('company_id'),
            $request->input('ngay1'),
            $request->input('ngay2'),
            $request->input('tu_so'),
            $request->input('den_so'),
            $request->input('ma_nt')
        ];
        
        $data = DB::select('sp_GL_Rpt_CTGS02', $params);
        return response()->json($data);
    }
}
```

## Ghi chú
- Cho phép chọn lọc chứng từ theo số
- Có cột TAG để đánh dấu chứng từ cần in
- Hỗ trợ in qua Crystal Report
