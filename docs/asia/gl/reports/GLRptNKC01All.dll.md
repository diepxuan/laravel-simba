# GlRptNKC01All.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo nhật ký chung tổng hợp (NKC01All)

## Forms

### frmGlRptNKC01All.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo nhật ký chung tổng hợp với nhiều tùy chọn

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtTk | AsTextBox | TK | - |
| lblten_tk | Label | - | - |
| lblTk | Label | - | - |
| txtBac | AsTextNumeric | Bac | - |
| lblbac | Label | - | - |
| chkTK_sc | CheckBox | - | - |
| chkSTT_NKC | CheckBox | - | - |
| cboMau_bc | ComboBox | ReportTemplate | SelectedIndexChanged |
| cboKyBc | ComboBox | KyBaoCao | - |
| txtNgay1 | AsMaskedTextBox | Date | - |
| txtNgay2 | AsMaskedTextBox | Date | - |
| txtMa_Nt | AsTextBox | Currency | - |
| optVND | RadioButton | CurrencyType | - |
| optNt | RadioButton | CurrencyType | - |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Tải dữ liệu báo cáo |
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |
| cboMau_bc_SelectedIndexChanged | sender, EventArgs | void | Xử lý chọn mẫu |
| AsTabControl_SelectedIndexChanged | sender, EventArgs | void | Xử lý chuyển tab |
| CreateDrilldownArgument | ReportDrillDownInfo, Keys, Keys | ArrayList | Tạo tham số drill-down |
| dgvBC_KeyDown | sender, KeyEventArgs | void | Xử lý phím tắt trên grid |
| dgvBC_CellContentClick | sender, DataGridViewCellEventArgs | void | Xử lý click cell |
| LoadDataToCrystal | - | DataTable | Tải dữ liệu cho Crystal Report |
| ViewCrystalBySource | - | void | Xem Crystal Report |
| ValidData | - | bool | Kiểm tra dữ liệu hợp lệ |

## Data Access

### GlRptNKC01AllController
- **Interface**: IReportController
- **Implementation**: MssqlReportController

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetData | sp_GL_Rpt_NKC01All | company_id, ngay1, ngay2, tk, bac, chkTK_sc, ma_nt | DataTable | Lấy dữ liệu báo cáo (mẫu 02) |
| GetData | sp_GL_Rpt_NKC01All_01 | company_id, ngay1, ngay2, tk, ma_nt, chkSTT_NKC | DataTable | Lấy dữ liệu báo cáo (mẫu 01) |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_GL_Rpt_NKC01All | Lấy dữ liệu NKC (mẫu 02) | @company_id, @ngay1, @ngay2, @tk, @bac, @chkTK_sc, @ma_nt | DataTable |
| sp_GL_Rpt_NKC01All_01 | Lấy dữ liệu NKC (mẫu 01) | @company_id, @ngay1, @ngay2, @tk, @ma_nt, @chkSTT_NKC | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn mẫu báo cáo (cboMau_bc):
   - Mẫu 01: Nhật ký chung
   - Mẫu 02: Nhật ký chung tổng hợp theo bậc
2. Nếu mẫu 02:
   - Nhập tài khoản (txtTk)
   - Nhập bậc (txtBac, mặc định 9)
   - Chọn "Lên cho tk sổ cái" (chkTK_sc)
3. Nếu mẫu 01:
   - Nhập tài khoản (txtTk)
   - Chọn "Đánh STT theo sổ NKC" (chkSTT_NKC)
4. Người dùng chọn kỳ báo cáo
5. Người dùng chọn loại tiền tệ
6. Nhấn OK để tải dữ liệu
7. Hệ thống gọi SP tương ứng
8. Hiển thị dữ liệu

### Validation rules
- Mẫu 01: Phải nhập tài khoản
- Mẫu 02: Không bắt buộc nhập tài khoản

### Drill-down logic
- F5: Drill-down xem sổ chi tiết
- Ctrl+F5: Drill-down xem sổ chi tiết (TK/TK_DU)
- Shift+F5: Drill-down xem cân đối PS công nợ

### Chức năng đặc biệt
- Space: Toggle chọn/bỏ chọn tất cả các dòng
- Click vào cột TAG: Chọn/bỏ chọn dòng hiện tại
- Nếu dòng là TK sổ cái (bold=1), chọn/bỏ chọn tất cả các dòng cùng TK

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_SOCT | Sổ chứng từ | R |
| GL_TK | Tài khoản | R |

## Mapping sang PHP

### Controller
```php
class NKC01AllController extends Controller {
    public function index() {
        // Hiển thị form filter
    }
    
    public function getData(Request $request) {
        $mau = $request->input('ma_mau');
        
        if ($mau == '02') {
            $params = [
                $request->input('company_id'),
                $request->input('ngay1'),
                $request->input('ngay2'),
                $request->input('tk'),
                $request->input('bac'),
                $request->input('chkTK_sc'),
                $request->input('ma_nt')
            ];
            $data = DB::select('sp_GL_Rpt_NKC01All', $params);
        } else {
            $params = [
                $request->input('company_id'),
                $request->input('ngay1'),
                $request->input('ngay2'),
                $request->input('tk'),
                $request->input('ma_nt'),
                $request->input('chkSTT_NKC')
            ];
            $data = DB::select('sp_GL_Rpt_NKC01All_01', $params);
        }
        
        return response()->json($data);
    }
    
    public function toggleAll(Request $request) {
        // Toggle chọn/bỏ chọn tất cả
    }
    
    public function toggleRow(Request $request) {
        // Toggle chọn/bỏ chọn dòng
        // Nếu là TK sổ cái, toggle cả các dòng cùng TK
    }
}
```

## Ghi chú
- Hỗ trợ 2 mẫu báo cáo khác nhau
- Mẫu 02 cho phép chọn nhiều TK để in
- Có chức năng đánh STT theo sổ NKC
