# ARRptBCCN01a

## Tổng quan
- **Module**: AR (Accounts Receivable)
- **Loại**: Report
- **Chức năng**: Báo cáo bảng cân đối công nợ khách hàng (dạng Excel nâng cao với nhiều khách hàng)

## Forms

### frmARRptBCCN01a.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo công nợ với khả năng xuất Excel nâng cao cho nhiều khách hàng

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| txtTk | AsTextBox | TK (tk_cn=1) | Lookup, AutoComplete |
| lblTen_Tk | Label | Hiển thị tên TK | - |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu | - |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc | - |
| cboKyBc | ComboBox | Kỳ báo cáo | - |
| cboMau_bc | ComboBox | Mẫu báo cáo | - |
| optVND | RadioButton | Loại tiền VND | - |
| optNt | RadioButton | Loại tiền ngoại tệ | - |
| txtMa_Nt | AsTextBox | Mã ngoại tệ | Lookup |
| dgvBC | AsDataGridView | Danh sách khách hàng | CellContentClick |

#### Properties
| Property | Type | Purpose |
|----------|------|---------|
| _selectedAll | bool | Trạng thái chọn tất cả |
| colIndex | int | Vị trí cột hiện tại (Excel) |
| rowIndex | int | Vị trí dòng hiện tại (Excel) |
| maxColIndex | int | Số cột tối đa |
| maxRowIndex | int | Số dòng tối đa |
| hasSUM | bool | Có cột tổng |
| hasBoldColumn | bool | Có cột in đậm |
| hasFormulaColumn | bool | Có cột công thức |
| hasCodeColumn | bool | Có cột mã |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| ValidData | - | bool | Validate dữ liệu đầu vào |
| ViewCrystalBySource | - | void | Xem báo cáo Crystal |
| CreateDrilldownArgument | drilldownInfo, sDrilldownMenuId, keycode, modifierKeys, filterCondition4title, datasource | ArrayList | Tạo tham số drill-down |
| LoadDataToCry | - | DataTable | Load dữ liệu cho Crystal Report |
| ValidateData | - | bool | Kiểm tra dữ liệu hợp lệ |
| Ex2Excel | - | void | Xuất Excel |
| ThreadProcessEx2Excel | - | void | Xử lý xuất Excel (thread) |
| InitHeader | f_rptInfo, f_sFilterTitle, f_sNhan_in | void | Khởi tạo header Excel |
| InitDataHeader | f_dgvBC, f_oTblPrint, f_oTblFilter, sTieu_De_Khach_Hang | void | Khởi tạo header dữ liệu |
| E2E | f_dgvBC, f_oTblPrint | void | Export to Excel |
| Convert2ExcelFormula | sFormula, myIndex, oDic | string | Chuyển đổi công thức sang Excel |
| ConvertNumericFormat | dgvFormat | string | Chuyển đổi định dạng số |
| dgvBC_CellContentClick | sender, e | void | Xử lý click cell |

### frmExport2Excel1.cs
- **Kế thừa**: Form
- **Chức năng**: Form cấu hình xuất Excel

#### Controls
- f_dgvBC: AsDataGridView - Grid hiển thị
- f_oTblPrint: DataTable - Dữ liệu in
- f_oTblFilter: DataTable - Dữ liệu filter
- f_rptInfo: ReportInformation - Thông tin báo cáo
- f_RptFormularFields: AsDictionary - Các trường công thức

## Data Access

Không có DAO riêng, sử dụng controller từ base class frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| asARRptBCCN01a_Crys | Lấy dữ liệu báo cáo chi tiết | @pMa_cty, @pNgay1, @pNgay2, @pTk, @pMa_kh, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. Người dùng nhập tài khoản công nợ và kỳ báo cáo
2. Load danh sách khách hàng có phát sinh trên DataGridView
3. Người dùng chọn khách hàng cần xuất (có thể chọn nhiều)
4. Gọi SP asARRptBCCN01a_Crys cho từng khách hàng được chọn
5. Xuất dữ liệu ra Excel với mỗi khách hàng một sheet hoặc nhiều khách hàng trên cùng sheet

### Validation rules
- Tài khoản (txtTk) bắt buộc phải nhập
- Phải chọn ít nhất một khách hàng để xuất

### Calculation logic
- Tính toán số dư đầu kỳ, phát sinh trong kỳ, số dư cuối kỳ cho từng khách hàng
- Hỗ trợ xuất nhiều khách hàng cùng lúc
- Có thể xuất theo mẫu định sẵn với công thức tính toán

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
class ARRptBCCN01aController extends ReportController {
    public function index(Request $request) {
        // Hiển thị form filter
    }
    
    public function getData(Request $request) {
        $params = [
            'ma_cty' => $request->company_id,
            'ngay1' => $request->date_from,
            'ngay2' => $request->date_to,
            'tk' => $request->account,
            'ma_nt' => $request->currency
        ];
        return $this->service->getReportData($params);
    }
    
    public function exportExcel(Request $request) {
        $selectedCustomers = $request->selected_customers;
        $exporter = new ARRptBCCN01aExporter();
        return $exporter->export($selectedCustomers, $request->all());
    }
}
```

### Repository
```php
class ARRptBCCN01aRepository {
    public function getReportData($params) {
        return DB::select('EXEC asARRptBCCN01a_Crys ?, ?, ?, ?, ?, ?', [
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
class ARRptBCCN01aExporter {
    public function export($customers, $params) {
        $spreadsheet = new Spreadsheet();
        
        foreach ($customers as $customer) {
            $data = $this->repository->getReportData(array_merge($params, ['ma_kh' => $customer]));
            $this->addCustomerSheet($spreadsheet, $customer, $data);
        }
        
        return $spreadsheet->export('xlsx');
    }
    
    private function addCustomerSheet($spreadsheet, $customer, $data) {
        // Tạo sheet mới cho mỗi khách hàng
        // Format header, data theo mẫu
    }
}
```

## Ghi chú
- Đây là báo cáo nâng cao hỗ trợ xuất Excel cho nhiều khách hàng
- Sử dụng Microsoft.Office.Interop.Excel để xuất Excel
- Có thể tùy chỉnh mẫu xuất qua form frmExport2Excel1
- Hỗ trợ công thức tính toán trong Excel
