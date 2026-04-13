# GlRptNkc01.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo nhật ký chung (NKC01)

## Forms

### frmGlRptNkc01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo nhật ký chung theo tài khoản

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtTk | AsTextBox | TK | - |
| lblTen_Tk | Label | - | - |
| lblTk | Label | - | - |
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
| ValidData | - | bool | Kiểm tra dữ liệu hợp lệ |

## Data Access

### GlRptNkc01Controller
- **Interface**: IReportController
- **Implementation**: MssqlReportController

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetData | sp_GL_Rpt_NKC01 | company_id, ngay1, ngay2, tk, ma_nt | DataTable | Lấy dữ liệu báo cáo |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_GL_Rpt_NKC01 | Lấy dữ liệu NKC | @company_id, @ngay1, @ngay2, @tk, @ma_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc)
2. Người dùng nhập tài khoản (txtTk)
3. Người dùng chọn loại tiền tệ
4. Nhấn OK để tải dữ liệu
5. Hệ thống gọi SP sp_GL_Rpt_NKC01
6. Hiển thị dữ liệu nhật ký chung
7. Tính các giá trị công thức:
   - TK: Mã tài khoản
   - TEN_TK: Tên tài khoản
   - Du_Co_Cky: Dư có cuối kỳ (từ dòng 2)
   - Du_No_Cky: Dư nợ cuối kỳ (từ dòng 2)
   - Du_Co_Dky: Dư có đầu kỳ (từ dòng 0)
   - Du_No_Dky: Dư nợ đầu kỳ (từ dòng 0)

### Validation rules
- Phải nhập tài khoản

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_SOCT | Sổ chứng từ | R |
| GL_TK | Tài khoản | R |

## Mapping sang PHP

### Controller
```php
class NKC01Controller extends Controller {
    public function index() {
        // Hiển thị form filter
    }
    
    public function getData(Request $request) {
        $params = [
            $request->input('company_id'),
            $request->input('ngay1'),
            $request->input('ngay2'),
            $request->input('tk'),
            $request->input('ma_nt')
        ];
        
        $data = DB::select('sp_GL_Rpt_NKC01', $params);
        
        // Tính các giá trị công thức
        $formularFields = [
            'TK' => $request->input('tk'),
            'TEN_TK' => $data[0]->ten_tk ?? '',
            'Du_Co_Cky' => number_format($data[2]->ps_co ?? 0, 2),
            'Du_No_Cky' => $data[2]->ps_no ?? 0,
            'Du_Co_Dky' => $data[0]->ps_co ?? 0,
            'Du_No_Dky' => $data[0]->ps_no ?? 0
        ];
        
        return response()->json([
            'data' => $data,
            'formularFields' => $formularFields
        ]);
    }
}
```

## Ghi chú
- Báo cáo nhật ký chung theo một tài khoản cụ thể
- Tính toán các giá trị dư đầu kỳ, dư cuối kỳ
- Bắt buộc phải nhập tài khoản
