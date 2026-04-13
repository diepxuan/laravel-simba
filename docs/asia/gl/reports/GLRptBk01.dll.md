# GlRptBk01.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo bảng kê chứng từ (BK01)

## Forms

### frmGlRptBk01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng kê chứng từ với nhiều điều kiện lọc

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtSo_Ct1 | TextBox | So_Ct | - |
| txtSo_Ct2 | TextBox | So_Ct | - |
| lblSo_Ct1 | Label | - | - |
| lblSo_Ct2 | Label | - | - |
| cboNhom_Theo | ComboBox | NhomTheo | - |
| lblNhom_theo | Label | - | - |
| txtTk | AsTextBox | TK | - |
| lblTen_Tk | Label | - | - |
| lblTk | Label | - | - |
| cboNo_Co | ComboBox | NoCo | - |
| lblNo_Co | Label | - | - |
| txtTk_Du | AsTextBox | TK_DU | - |
| lblTen_Tk_Du | Label | - | - |
| lblTk_Du | Label | - | - |
| txtMa_Kh | AsTextBox | MA_KH | - |
| lblTen_Kh | Label | - | - |
| lblMa_Kh | Label | - | - |
| txtMa_lo | AsTextBox | MA_LO | - |
| lblTen_lo | Label | - | - |
| lblMa_lo | Label | - | - |
| txtMa_Bp | AsTextBox | MA_BP | - |
| lblTen_Bp | Label | - | - |
| lblMa_Bp | Label | - | - |
| txtMa_Phi | AsTextBox | MA_PHI | - |
| lblTen_Phi | Label | - | - |
| lblMa_Phi | Label | - | - |
| txtMa_Hd | AsTextBox | MA_HD | - |
| lblTen_Hd | Label | - | - |
| lblMa_Hd | Label | - | - |
| txtMa_Ku | AsTextBox | MA_KU | - |
| lblTen_Ku | Label | - | - |
| lblMa_Ku | Label | - | - |
| txtMa_Spct | AsTextBox | MA_SPCT | - |
| lblTen_Spct | Label | - | - |
| lblMa_Spct | Label | - | - |
| txtMa_Ct | AsTextBoxMulti | MA_CT | - |
| lblTen_Ct | Label | - | - |
| lblMa_Ct | Label | - | - |
| txtDien_giai | TextBox | Dien_Giai | - |
| lblDien_giai | Label | - | - |
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
| GetFilterTitle | - | string | Lấy chuỗi tiêu đề filter |
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |

## Data Access

### GlRptBk01Controller
- **Interface**: IReportController
- **Implementation**: MssqlReportController

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetData | sp_GL_Rpt_Bk01 | company_id, ngay1, ngay2, nhom_theo, so_ct1, so_ct2, tk, no_co, tk_du, ma_kh, ma_lo, ma_bp, ma_phi, ma_hd, ma_ku, ma_spct, ma_ct, dien_giai, ma_nt | DataTable | Lấy dữ liệu báo cáo |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_GL_Rpt_Bk01 | Lấy dữ liệu bảng kê | @company_id, @ngay1, @ngay2, @nhom_theo, @so_ct1, @so_ct2, @tk, @no_co, @tk_du, @ma_kh, @ma_lo, @ma_bp, @ma_phi, @ma_hd, @ma_ku, @ma_spct, @ma_ct, @dien_giai, @ma_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc)
2. Người dùng chọn nhóm theo (cboNhom_Theo): Khách hàng, Tài khoản, Tài khoản đối ứng, Bộ phận, Hợp đồng, Phí, Sản phẩm
3. Người dùng nhập các điều kiện lọc: Số CT, Tài khoản, Nợ/Có, TK đối ứng, Mã KH, Mã lô, Mã BP, Mã phí, Mã HĐ, Mã KU, Mã SPCT, Mã CT, Diễn giải
4. Người dùng chọn loại tiền tệ
5. Nhấn OK để tải dữ liệu
6. Hệ thống gọi SP sp_GL_Rpt_Bk01
7. Hiển thị dữ liệu theo nhóm đã chọn

### Validation rules
- Ngày báo cáo phải hợp lệ
- Nếu nhập tài khoản thì phải tồn tại trong danh mục

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_SOCT | Sổ chứng từ | R |
| GL_TK | Tài khoản | R |
| DM_KH | Danh mục khách hàng | R |
| DM_BP | Danh mục bộ phận | R |
| DM_PHI | Danh mục phí | R |
| DM_HD | Danh mục hợp đồng | R |
| DM_KU | Danh mục khế ước | R |
| DM_SPCT | Danh mục sản phẩm | R |

## Mapping sang PHP

### Controller
```php
class Bk01Controller extends Controller {
    public function index() {
        // Hiển thị form filter
    }
    
    public function getData(Request $request) {
        $params = [
            $request->input('company_id'),
            $request->input('ngay1'),
            $request->input('ngay2'),
            $request->input('nhom_theo'),
            $request->input('so_ct1'),
            $request->input('so_ct2'),
            $request->input('tk'),
            $request->input('no_co'),
            $request->input('tk_du'),
            $request->input('ma_kh'),
            $request->input('ma_lo'),
            $request->input('ma_bp'),
            $request->input('ma_phi'),
            $request->input('ma_hd'),
            $request->input('ma_ku'),
            $request->input('ma_spct'),
            $request->input('ma_ct'),
            $request->input('dien_giai'),
            $request->input('ma_nt')
        ];
        
        $data = DB::select('sp_GL_Rpt_Bk01', $params);
        return response()->json($data);
    }
}
```

## Ghi chú
- Báo cáo hỗ trợ nhóm theo nhiều tiêu chí khác nhau
- Có nhiều điều kiện lọc linh hoạt
- Sử dụng AsTextBoxMulti cho mã chứng từ để chọn nhiều mã
