# GLRptCTGS05.dll

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Chứng từ ghi sổ (CTGS05) - Dạng đầy đủ với nhiều điều kiện lọc

## Forms

### frmGLRptCTGS05.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form in chứng từ ghi sổ với nhiều điều kiện lọc

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtSo_Ct1 | TextBox | So_Ct | - |
| txtSo_Ct2 | TextBox | So_Ct | - |
| txtSo_lo1 | TextBox | So_Lo | - |
| txtSo_lo2 | TextBox | So_Lo | - |
| cboNgay_lo | AsComboBox | KyBaoCao | SelectedValueChanged |
| txtNgay_lo1 | AsMaskedTextBox | Date | - |
| txtNgay_lo2 | AsMaskedTextBox | Date | - |
| txtTk | AsTextBox | TK | - |
| lblTen_Tk | Label | - | - |
| txtTk_Du | AsTextBox | TK_DU | - |
| lblTen_Tk_Du | Label | - | - |
| txtMa_Kh | AsTextBox | MA_KH | - |
| lblTen_Kh | Label | - | - |
| txtMa_NhKh | AsTextBox | MA_NHKH | - |
| lblTen_NhKh | Label | - | - |
| txtMa_Plkh1 | AsTextBox | MA_PLKH | - |
| txtMa_Plkh2 | AsTextBox | MA_PLKH | - |
| txtMa_Plkh3 | AsTextBox | MA_PLKH | - |
| txtMa_Bp | AsTextBox | MA_BP | - |
| lblTen_Bp | Label | - | - |
| txtMa_Phi | AsTextBox | MA_PHI | - |
| lblTen_Phi | Label | - | - |
| txtMa_Hd | AsTextBox | MA_HD | - |
| lblTen_Hd | Label | - | - |
| txtMa_Ku | AsTextBox | MA_KU | - |
| lblTen_Ku | Label | - | - |
| txtMa_Spct | AsTextBox | MA_SPCT | - |
| lblTen_Spct | Label | - | - |
| txtMa_Ct | AsTextBoxMulti | MA_CT | - |
| lblTen_Ct | Label | - | - |
| txtDien_giai | TextBox | Dien_Giai | - |
| cboKyBc | ComboBox | KyBaoCao | - |
| txtNgay1 | AsMaskedTextBox | Date | - |
| txtNgay2 | AsMaskedTextBox | Date | - |
| txtMa_Nt | AsTextBox | Currency | - |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Tải dữ liệu chứng từ |
| GetFilterTitle | - | string | Lấy chuỗi tiêu đề filter |
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |
| InitNgayLo | - | void | Khởi tạo ngày lô |
| cboKyTruoc_SelectedValueChanged | sender, EventArgs | void | Xử lý chọn kỳ |

## Data Access

### GLRptCTGS05Controller
- **Interface**: IReportController
- **Implementation**: MssqlReportController

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| GetData | sp_GL_Rpt_CTGS05 | company_id, ngay1, ngay2, ngay_lo1, ngay_lo2, ma_ct, tk, tk_du, ma_nhkh, ma_plkh1, ma_plkh2, ma_plkh3, ma_kh, so_ct1, so_ct2, so_lo1, so_lo2, ma_nt, ma_hd, ma_phi, dien_giai, ma_bp, ma_spct, ma_ku | DataTable | Lấy dữ liệu chứng từ |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| sp_GL_Rpt_CTGS05 | Lấy dữ liệu CTGS đầy đủ | @company_id, @ngay1, @ngay2, @ngay_lo1, @ngay_lo2, @ma_ct, @tk, @tk_du, @ma_nhkh, @ma_plkh1, @ma_plkh2, @ma_plkh3, @ma_kh, @so_ct1, @so_ct2, @so_lo1, @so_lo2, @ma_nt, @ma_hd, @ma_phi, @dien_giai, @ma_bp, @ma_spct, @ma_ku | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc)
2. Người dùng chọn ngày lô (cboNgay_lo)
3. Người dùng nhập số lô (txtSo_lo1, txtSo_lo2)
4. Người dùng nhập số chứng từ (txtSo_Ct1, txtSo_Ct2)
5. Người dùng nhập các điều kiện lọc khác: TK, TK_DU, MA_KH, MA_NHKH, MA_PLKH1-3, MA_BP, MA_PHI, MA_HD, MA_KU, MA_SPCT, MA_CT, DIEN_GIAI
6. Người dùng chọn loại tiền tệ
7. Nhấn OK để tải dữ liệu
8. Hệ thống gọi SP sp_GL_Rpt_CTGS05

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_SOCT | Sổ chứng từ | R |
| GL_CTGS | Chứng từ ghi sổ | R |
| GL_TK | Tài khoản | R |
| DM_KH | Danh mục khách hàng | R |
| DM_NHKH | Danh mục nhóm KH | R |
| DM_PLKH | Danh mục phân loại KH | R |
| DM_BP | Danh mục bộ phận | R |
| DM_PHI | Danh mục phí | R |
| DM_HD | Danh mục hợp đồng | R |
| DM_KU | Danh mục khế ước | R |
| DM_SPCT | Danh mục sản phẩm | R |

## Mapping sang PHP

### Controller
```php
class CTGS05Controller extends Controller {
    public function index() {
        // Hiển thị form filter
    }
    
    public function getData(Request $request) {
        $params = [
            $request->input('company_id'),
            $request->input('ngay1'),
            $request->input('ngay2'),
            $request->input('ngay_lo1'),
            $request->input('ngay_lo2'),
            $request->input('ma_ct'),
            $request->input('tk'),
            $request->input('tk_du'),
            $request->input('ma_nhkh'),
            $request->input('ma_plkh1'),
            $request->input('ma_plkh2'),
            $request->input('ma_plkh3'),
            $request->input('ma_kh'),
            $request->input('so_ct1'),
            $request->input('so_ct2'),
            $request->input('so_lo1'),
            $request->input('so_lo2'),
            $request->input('ma_nt'),
            $request->input('ma_hd'),
            $request->input('ma_phi'),
            $request->input('dien_giai'),
            $request->input('ma_bp'),
            $request->input('ma_spct'),
            $request->input('ma_ku')
        ];
        
        $data = DB::select('sp_GL_Rpt_CTGS05', $params);
        return response()->json($data);
    }
}
```

## Ghi chú
- Báo cáo đầy đủ nhất trong các dạng CTGS
- Hỗ trợ lọc theo ngày lô, số lô
- Hỗ trợ phân loại khách hàng 3 cấp (PLKH1, PLKH2, PLKH3)
