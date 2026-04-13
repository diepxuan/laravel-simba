# ARRptBCCN05

## Tổng quan
- **Module**: AR (Accounts Receivable)
- **Loại**: Report
- **Chức năng**: Báo cáo đối chiếu công nợ khách hàng (in thư đối chiếu)

## Forms

### frmARRptBCCN05.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo đối chiếu công nợ, hỗ trợ in thư đối chiếu gửi khách hàng

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtMa_Tk | AsTextBox | TK (tk_cn=1) | Lookup, AutoComplete |
| txtMa_Kh | AsTextBox | MA_KH (ksd=0) | Lookup, AutoComplete, AfterCodeValidating |
| lblTen_Tk | Label | Hiển thị tên TK | - |
| lblTenKH | Label | Hiển thị tên KH | - |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu | - |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc | - |
| txtNgay_lp | AsMaskedTextBox | Ngày lập đối chiếu | - |
| txtMa_khs | TextBox | Danh sách mã KH đã chọn (hidden) | - |
| cboKyBc | ComboBox | Kỳ báo cáo | - |
| cboMau_bc | ComboBox | Mẫu báo cáo | - |
| optVND | RadioButton | Loại tiền VND | - |
| optNt | RadioButton | Loại tiền ngoại tệ | - |
| txtMa_Nt | AsTextBox | Mã ngoại tệ | Lookup |
| dgvBC | AsDataGridView | Danh sách khách hàng | CellContentClick |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| MenuId | string | ID menu báo cáo |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| ValidData | - | bool | Validate dữ liệu đầu vào |
| GetFilterTitle | - | string | Lấy tiêu đề filter |
| ViewCrystalBySource | - | void | Xem báo cáo Crystal |
| CreateDrilldownArgument | drilldownInfo, sDrilldownMenuId, keycode, modifierKeys, filterCondition4title, datasource | ArrayList | Tạo tham số drill-down |
| LoadDataToCry | - | DataTable | Load dữ liệu cho Crystal Report |
| ValidateData | - | bool | Kiểm tra dữ liệu hợp lệ |
| txtMa_Kh_AfterCodeValidating | sender, e | void | Xử lý sau khi validate mã KH |
| dgvBC_CellContentClick | sender, e | void | Xử lý click cell |
| frmARRptBCCN05_KeyDown | sender, e | void | Xử lý phím tắt (F4) |

### frmInputInfo.cs
- **Kế thừa**: Form
- **Chức năng**: Form nhập thông tin cho thư đối chiếu

#### Controls
| Control | Type | Purpose |
|---------|------|---------|
| txtTenKh | TextBox | Tên khách hàng |
| txtDiaChiKh | TextBox | Địa chỉ khách hàng |
| txtDienThoaiKh | TextBox | Điện thoại khách hàng |
| txtKh1 | TextBox | Người đại diện KH 1 |
| txtkh2 | TextBox | Người đại diện KH 2 |
| txtCvKh1 | TextBox | Chức vụ KH 1 |
| txtCvKh2 | TextBox | Chức vụ KH 2 |
| txtTenCty | TextBox | Tên công ty |
| txtDiaChiCty | TextBox | Địa chỉ công ty |
| txtDienThoaiCty | TextBox | Điện thoại công ty |
| txtCty1 | TextBox | Người đại diện CTY 1 |
| txtCty2 | TextBox | Người đại diện CTY 2 |
| txtCvCty1 | TextBox | Chức vụ CTY 1 |
| txtCvCty2 | TextBox | Chức vụ CTY 2 |

## Data Access

Không có DAO riêng, sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| asARRptBCCN05 | Lấy dữ liệu báo cáo | @pMa_cty, @pNgay1, @pNgay2, @pTk, @pMa_kh, @pMa_nt | DataTable |
| asARRptBCCN05_Crys | Lấy dữ liệu cho Crystal Report | @pMa_cty, @pNgay1, @pNgay2, @pTk, @pMa_kh, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng nhập tài khoản công nợ (bắt buộc)
2. Chọn khách hàng cần đối chiếu (có thể chọn nhiều)
3. Nhập ngày lập thư đối chiếu
4. Load dữ liệu công nợ lên DataGridView
5. Chọn khách hàng cần in thư đối chiếu (checkbox TAG)
6. Nhấn F4 hoặc nút In để mở form nhập thông tin thư
7. Nhập thông tin người đại diện, chức vụ hai bên
8. In thư đối chiếu với đầy đủ thông tin

### Validation rules
- Tài khoản (txtMa_Tk) bắt buộc phải nhập
- Phải chọn ít nhất một khách hàng để in thư đối chiếu
- Ngày lập phải hợp lệ

### Calculation logic
- Tính tổng nợ đầu kỳ (dn_ck) và có đầu kỳ (dc_ck) của khách hàng được chọn
- Tính chênh lệch công nợ
- Chuyển số tiền thành chữ (đồng)
- Format dữ liệu cho thư đối chiếu

### Xử lý đặc biệt
- Sau khi chọn mã khách hàng, tự động thêm vào danh sách txtMa_khs
- Hỗ trợ chọn nhiều khách hàng qua checkbox trên DataGridView
- Click vào dòng "Tổng cộng" để chọn/bỏ chọn tất cả
- Form nhập thông tin cho phép nhập thông tin người đại diện hai bên

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| ARDCTT | Chi tiết công nợ | R |
| ARTT | Tổng hợp công nợ | R |
| DMTK | Danh mục tài khoản | R |
| DMKH | Danh mục khách hàng | R |

## Mapping sang PHP

### Controller
```php
class ARRptBCCN05Controller extends ReportController {
    public function index(Request $request) {
        return view('ar.reports.bccn05');
    }
    
    public function getData(Request $request) {
        $params = [
            'ma_cty' => $request->company_id,
            'ngay1' => $request->date_from,
            'ngay2' => $request->date_to,
            'tk' => $request->account,
            'ma_kh' => $request->customer_id,
            'ma_nt' => $request->currency
        ];
        return $this->service->getReportData($params);
    }
    
    public function showInputForm(Request $request) {
        $customer = $request->customer;
        $data = $this->service->getCustomerInfo($customer);
        return view('ar.reports.bccn05_input', [
            'customer' => $data
        ]);
    }
    
    public function printLetter(Request $request) {
        $params = [
            'ma_cty' => $request->company_id,
            'ngay1' => $request->date_from,
            'ngay2' => $request->date_to,
            'tk' => $request->account,
            'ma_kh' => $request->customer_id,
            'ma_nt' => $request->currency,
            'ngay_lp' => $request->letter_date,
            'ten_kh' => $request->customer_name,
            'dia_chi_kh' => $request->customer_address,
            'tel_kh' => $request->customer_phone,
            'kh1' => $request->customer_rep1,
            'kh2' => $request->customer_rep2,
            'cvkh1' => $request->customer_title1,
            'cvkh2' => $request->customer_title2,
            'ten_cty' => $request->company_name,
            'dia_chi_cty' => $request->company_address,
            'tel_cty' => $request->company_phone,
            'cty1' => $request->company_rep1,
            'cty2' => $request->company_rep2,
            'cvcty1' => $request->company_title1,
            'cvcty2' => $request->company_title2
        ];
        
        $report = $this->service->generateLetter($params);
        return $report->output();
    }
}
```

### Repository
```php
class ARRptBCCN05Repository {
    public function getReportData($params) {
        return DB::select('EXEC asARRptBCCN05 ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['tk'],
            $params['ma_kh'],
            $params['ma_nt']
        ]);
    }
    
    public function getLetterData($params) {
        return DB::select('EXEC asARRptBCCN05_Crys ?, ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['tk'],
            $params['ma_kh'],
            $params['ma_nt']
        ]);
    }
}
```

### Service
```php
class ARRptBCCN05Service {
    public function generateLetter($params) {
        $data = $this->repository->getLetterData($params);
        
        // Tính tổng nợ
        $dn_ck = collect($data)->sum('dn_ck');
        $dc_ck = collect($data)->sum('dc_ck');
        $balance = abs($dn_ck - $dc_ck);
        
        // Chuyển số thành chữ
        $amountInWords = $this->numberToWords($balance, 'đồng');
        
        $reportData = [
            'data' => $data,
            'filter_title' => $this->buildFilterTitle($params),
            'tk'