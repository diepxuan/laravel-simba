# ARRptBK01

## Tổng quan
- **Module**: AR (Accounts Receivable)
- **Loại**: Report
- **Chức năng**: Báo cáo bảng kê chứng từ bán hàng chi tiết

## Forms

### frmARRptBK01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng kê chứng từ bán hàng với nhiều tiêu chí lọc

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMa_Kh | AsTextBox | MA_KH | Lookup, AutoComplete |
| txtMa_vt | AsTextBox | MA_VT | Lookup, AutoComplete |
| txtMa_nhvt | AsTextBox | MA_NHVT | Lookup, AutoComplete |
| txtMa_kho | AsTextBox | MA_KHO | Lookup, AutoComplete |
| txtMa_lo | AsTextBox | MA_LO | Lookup, AutoComplete |
| txtMa_Bp | AsTextBox | MA_BP | Lookup, AutoComplete |
| txtMa_Hd | AsTextBox | MA_HD | Lookup, AutoComplete |
| txtMa_phi | AsTextBox | MA_PHI | Lookup, AutoComplete |
| txtMa_spct | AsTextBox | MA_SPCT | Lookup, AutoComplete |
| txtMa_Nvkd | AsTextBox | MA_NVKD | Lookup, AutoComplete |
| txtMa_plkh1 | AsTextBox | MA_PLKH (loai=1) | Lookup, AutoComplete |
| txtMa_plkh2 | AsTextBox | MA_PLKH (loai=2) | Lookup, AutoComplete |
| txtMa_plkh3 | AsTextBox | MA_PLKH (loai=3) | Lookup, AutoComplete |
| txtSo_Ct1 | TextBox | Số chứng từ từ | - |
| txtSo_Ct2 | TextBox | Số chứng từ đến | - |
| lblTen_Kh | Label | Hiển thị tên KH | - |
| lblTen_vt | Label | Hiển thị tên VT | - |
| lblTen_nhvt | Label | Hiển thị tên nhóm VT | - |
| lblTen_kho | Label | Hiển thị tên kho | - |
| lblTen_lo | Label | Hiển thị tên lô | - |
| lblTen_Bp | Label | Hiển thị tên BP | - |
| lblTen_Hd | Label | Hiển thị tên HD | - |
| lblTen_phi | Label | Hiển thị tên phí | - |
| lblTen_spct | Label | Hiển thị tên SPCT | - |
| lblTen_Nvkd | Label | Hiển thị tên NVKD | - |
| lblTen_plkh1 | Label | Hiển thị tên PLKH1 | - |
| lblTen_plkh2 | Label | Hiển thị tên PLKH2 | - |
| lblTen_plkh3 | Label | Hiển thị tên PLKH3 | - |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu | - |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc | - |
| cboKyBc | ComboBox | Kỳ báo cáo | - |
| cboMau_bc | ComboBox | Mẫu báo cáo | - |
| optVND | RadioButton | Loại tiền VND | - |
| optNt | RadioButton | Loại tiền ngoại tệ | - |
| txtMa_Nt | AsTextBox | Mã ngoại tệ | Lookup |
| crvReportViewer | CrystalReportViewer | Viewer báo cáo | - |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| MenuId | string | ID menu báo cáo |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| GetFilterTitle | - | string | Lấy tiêu đề filter |
| InitOtherComponents | - | void | Khởi tạo các thành phần khác |

## Data Access

Không có DAO riêng, sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| asARRptBK01 | Lấy dữ liệu báo cáo | @pMa_cty, @pNgay1, @pNgay2, @pMa_kh, @pMa_vt, @pMa_nhvt, @pMa_kho, @pMa_lo, @pMa_bp, @pMa_hd, @pMa_phi, @pMa_spct, @pMa_nvkd, @pMa_nt, @pSo_Ct1, @pSo_Ct2, @pMa_plkh1, @pMa_plkh2, @pMa_plkh3 | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng chọn kỳ báo cáo (ngày)
2. Có thể lọc theo nhiều tiêu chí: khách hàng, vật tư, nhóm vật tư, kho, lô, bộ phận, hợp đồng, phí, công trình, nhân viên kinh doanh, phân loại khách hàng
3. Có thể lọc theo số chứng từ (từ số - đến số)
4. Gọi SP asARRptBK01 để lấy dữ liệu
5. Hiển thị báo cáo bảng kê chi tiết

### Validation rules
- Ngày bắt đầu <= Ngày kết thúc
- Số chứng từ từ <= Số chứng từ đến (nếu cả hai đều nhập)

### Calculation logic
- Tổng hợp các chứng từ bán hàng theo các tiêu chí đã chọn
- Tính tổng số lượng, tổng tiền
- Phân biệt VND và ngoại tệ

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| ARCT | Chi tiết chứng từ bán hàng | R |
| ARDCTT | Chi tiết công nợ | R |
| DMKH | Danh mục khách hàng | R |
| DMVT | Danh mục vật tư | R |
| DMNHVT | Danh mục nhóm vật tư | R |
| DMKHO | Danh mục kho | R |
| DMLO | Danh mục lô | R |
| DMBP | Danh mục bộ phận | R |
| DMHD | Danh mục hợp đồng | R |
| DMPHI | Danh mục phí | R |
| DMSPCT | Danh mục công trình | R |
| DMNVKD | Danh mục nhân viên kinh doanh | R |
| DMPLKH | Danh mục phân loại khách hàng | R |

## Mapping sang PHP

### Controller
```php
class ARRptBK01Controller extends ReportController {
    public function index(Request $request) {
        return view('ar.reports.bk01');
    }
    
    public function getData(Request $request) {
        $params = [
            'ma_cty' => $request->company_id,
            'ngay1' => $request->date_from,
            'ngay2' => $request->date_to,
            'ma_kh' => $request->customer_id,
            'ma_vt' => $request->item_id,
            'ma_nhvt' => $request->item_group,
            'ma_kho' => $request->warehouse_id,
            'ma_lo' => $request->lot_id,
            'ma_bp' => $request->department_id,
            'ma_hd' => $request->contract_id,
            'ma_phi' => $request->fee_id,
            'ma_spct' => $request->project_id,
            'ma_nvkd' => $request->sales_id,
            'ma_nt' => $request->currency,
            'so_ct1' => $request->doc_no_from,
            'so_ct2' => $request->doc_no_to,
            'ma_plkh1' => $request->plkh1,
            'ma_plkh2' => $request->plkh2,
            'ma_plkh3' => $request->plkh3
        ];
        return $this->service->getReportData($params);
    }
}
```

### Repository
```php
class ARRptBK01Repository {
    public function getReportData($params) {
        return DB::select('EXEC asARRptBK01 ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['ma_kh'],
            $params['ma_vt'],
            $params['ma_nhvt'],
            $params['ma_kho'],
            $params['ma_lo'],
            $params['ma_bp'],
            $params['ma_hd'],
            $params['ma_phi'],
            $params['ma_spct'],
            $params['ma_nvkd'],
            $params['ma_nt'],
            $params['so_ct1'],
            $params['so_ct2'],
            $params['ma_plkh1'],
            $params['ma_plkh2'],
            $params['ma_plkh3']
        ]);
    }
}
```

## Ghi chú
- Báo cáo bảng kê chi tiết với nhiều tiêu chí lọc
- Hỗ trợ lọc theo số chứng từ
- Phù hợp để kiểm tra chi tiết các giao dịch bán hàng
- Có thể xuất Excel hoặc in báo cáo
