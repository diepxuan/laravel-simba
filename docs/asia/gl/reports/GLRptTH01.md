# GLRptTH01

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo tổng hợp (TH01) với nhiều điều kiện lọc và nhóm theo

## Forms

### frmGLRptTH01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo tổng hợp với nhiều filter và khả năng nhóm theo nhiều tiêu chí

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
| cboNhom_Theo | ComboBox | Nhóm theo | SelectedIndexChanged |
| txtSo_Ct1 | TextBox | Số chứng từ từ | TextChanged |
| txtSo_Ct2 | TextBox | Số chứng từ đến | TextChanged |
| txtTk | AsTextBox | Tài khoản | AutoLookup |
| lblTen_Tk | Label | Tên tài khoản | - |
| lblTk | Label | Label "Tài khoản" | - |
| cboNo_Co | ComboBox | Nợ/Có | SelectedIndexChanged |
| txtTk_Du | AsTextBox | Tài khoản đối ứng | AutoLookup |
| lblTen_Tk_Du | Label | Tên TK đối ứng | - |
| lblTk_Du | Label | Label "TK đ/ư" | - |
| txtMa_Kh | AsTextBox | Mã khách hàng | AutoLookup |
| lblTen_Kh | Label | Tên khách hàng | - |
| lblMa_Kh | Label | Label "Mã khách hàng" | - |
| txtMa_plkh1 | AsTextBox | Phân loại KH 1 | AutoLookup |
| lblTen_plkh1 | Label | Tên PLKH 1 | - |
| lblMa_plkh1 | Label | Label "P.loại KH1" | - |
| txtMa_plkh2 | AsTextBox | Phân loại KH 2 | AutoLookup |
| lblTen_plkh2 | Label | Tên PLKH 2 | - |
| lblMa_plkh2 | Label | Label "P.loại KH2" | - |
| txtMa_plkh3 | AsTextBox | Phân loại KH 3 | AutoLookup |
| lblTen_plkh3 | Label | Tên PLKH 3 | - |
| lblMa_plkh3 | Label | Label "P.loại KH3" | - |
| txtMa_Bp | AsTextBox | Mã bộ phận | AutoLookup |
| lblTen_Bp | Label | Tên bộ phận | - |
| lblMa_Bp | Label | Label "Mã bộ phận" | - |
| txtMa_Phi | AsTextBox | Mã phí | AutoLookup |
| lblTen_Phi | Label | Tên phí | - |
| lblMa_Phi | Label | Label "Mã phí" | - |
| txtMa_Hd | AsTextBox | Mã hợp đồng | AutoLookup |
| lblTen_Hd | Label | Tên hợp đồng | - |
| lblMa_Hd | Label | Label "Mã hợp đồng" | - |
| txtMa_nhhd | AsTextBox | Mã nhóm HĐ | AutoLookup |
| lblTen_nhhd | Label | Tên nhóm HĐ | - |
| lblMa_nhhd | Label | Label "Mã nhóm HĐ" | - |
| txtMa_Spct | AsTextBox | Mã SPCT | AutoLookup |
| lblTen_Spct | Label | Tên SPCT | - |
| lblMa_Spct | Label | Label "Mã SPCT" | - |
| txtMa_Ct | AsTextBox | Mã chứng từ | AutoLookup |
| lblTen_Ct | Label | Tên chứng từ | - |
| lblMa_Ct | Label | Label "Mã chứng từ" | - |
| txtMa_lo | AsTextBox | Mã lô | AutoLookup |
| lblTen_lo | Label | Tên lô | - |
| lblMa_lo | Label | Label "Mã lô" | - |
| txtDien_giai | TextBox | Diễn giải | TextChanged |
| lblDien_giai | Label | Label "Diễn giải" | - |
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
| LoadData | none | bool | Tải dữ liệu báo cáo với 22 tham số |
| InitOtherComponents | none | void | Khởi tạo combo nhóm theo và cboNo_Co |
| GetFilterTitle | none | string | Tạo chuỗi tiêu đề filter |
| CreateDrilldownArgument | drilldownInfo, sDrilldownMenuId, keycode, modifierKeys, filterCondition4title, datasource | ArrayList | Tạo tham số cho drill-down report |

## Data Access

Không có DAO riêng - sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| SP từ ReportInfo | Lấy dữ liệu tổng hợp | 22 params | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (cboKyBc) -> Tự động tính ngày bắt đầu/kết thúc
2. Chọn tiêu chí nhóm theo (cboNhom_Theo): Khách hàng, Tài khoản, Tài khoản đối ứng, Bộ phận, Hợp đồng, Phí, Sản phẩm
3. Nhập các điều kiện lọc: Số CT, TK, TK đối ứng, KH, PLKH, BP, Phí, HĐ, SPCT, CT, Lô, Diễn giải
4. Chọn Nợ/Có (cboNo_Co): 0-Tất cả, 1-Nợ, 2-Có
5. Chọn loại tiền và mã ngoại tệ
6. Click cmdOk để thực thi
7. Gọi LoadData() với 22 tham số

### Các tiêu chí nhóm theo
| Key | Value |
|-----|-------|
| MA_KH | Khách hàng |
| TK | Tài khoản |
| TK_DU | Tài khoản đối ứng |
| MA_BP | Bộ phận |
| MA_HD | Hợp đồng |
| MA_PHI | Phí |
| MA_SPCT | Sản phẩm |

### Parameters truyền vào SP (22 params)
1. CompanyID - Mã công ty
2. Ngày bắt đầu
3. Ngày kết thúc
4. Mã chứng từ (txtMa_Ct)
5. Tài khoản (txtTk)
6. Tài khoản đối ứng (txtTk_Du)
7. Phân loại KH 1 (txtMa_plkh1)
8. Phân loại KH 2 (txtMa_plkh2)
9. Phân loại KH 3 (txtMa_plkh3)
10. Mã khách hàng (txtMa_Kh)
11. Số chứng từ từ (txtSo_Ct1)
12. Số chứng từ đến (txtSo_Ct2)
13. Nợ/Có (cboNo_Co - lấy ký tự đầu)
14. Mã ngoại tệ (txtMa_Nt)
15. Mã hợp đồng (txtMa_Hd)
16. Mã phí (txtMa_Phi)
17. Diễn giải (txtDien_giai)
18. Mã bộ phận (txtMa_Bp)
19. Mã SPCT (txtMa_Spct)
20. Mã nhóm HĐ (txtMa_nhhd)
21. Mã lô (txtMa_lo)
22. Nhóm theo (cboNhom_Theo.SelectedItem.Key)

### Drill-down functionality
- Khi nhấn F5 trên một dòng:
  - Tạo tham số drill-down với 22 params tương tự
  - Nếu nhóm theo là TK/TK_DU/MA_KH/MA_HD/MA_PHI/MA_BP/MA_SPCT -> lấy giá trị từ dòng được chọn
  - filterCondition4title = ma_group từ dòng được chọn

### Tạo tiêu đề filter
Hàm GetFilterTitle() tạo chuỗi mô tả các điều kiện lọc đã chọn để hiển thị trên báo cáo.

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GlNkc | Nhật ký chung | R |
| DmTk | Danh mục tài khoản | R |
| DmKh | Danh mục khách hàng | R |
| DmBp | Danh mục bộ phận | R |
| DmPhi | Danh mục phí | R |
| DmHd | Danh mục hợp đồng | R |
| DmSpct | Danh mục SPCT | R |
| DmPlkh | Danh mục phân loại KH | R |
| DmNt | Danh mục ngoại tệ | R |

## Mapping sang PHP

### Controller
```php
class GLRptTH01Controller extends ReportController {
    public function index() {
        $kyBaoCaoOptions = $this->getKyBaoCaoOptions();
        $mauBaoCaoOptions = $this->getReportTemplates('GLRptTH01');
        $nhomTheoOptions = [
            ['key' => 'MA_KH', 'value' => 'Khách hàng'],
            ['key' => 'TK', 'value' => 'Tài khoản'],
            ['key' => 'TK_DU', 'value' => 'Tài khoản đối ứng'],
            ['key' => 'MA_BP', 'value' => 'Bộ phận'],
            ['key' => 'MA_HD', 'value' => 'Hợp đồng'],
            ['key' => 'MA_PHI', 'value' => 'Phí'],
            ['key' => 'MA_SPCT', 'value' => 'Sản phẩm']
        ];
        $noCoOptions = [
            ['key' => '0', 'value' => 'Tất cả'],
            ['key' => '1', 'value' => 'Nợ'],
            ['key' => '2', 'value' => 'Có']
        ];
        return view('gl.rpt_th01', compact('kyBaoCaoOptions', 'mauBaoCaoOptions', 'nhomTheoOptions', 'noCoOptions'));
    }
    
    public function generate(Request $request) {
        $params = [
            'ma_cty' => session('company_id'),
            'ngay1' => $request->ngay1,
            'ngay2' => $request->ngay2,
            'ma_ct' => $request->ma_ct ?? '',
            'tk' => $request->tk ?? '',
            'tk_du' => $request->tk_du ?? '',
            'ma_plkh1' => $request->ma_plkh1 ?? '',
            'ma_plkh2' => $request->ma_plkh2 ?? '',
            'ma_plkh3' => $request->ma_plkh3 ?? '',
            'ma_kh' => $request->ma_kh ?? '',
            'so_ct1' => $request->so_ct1 ?? '',
            'so_ct2' => $