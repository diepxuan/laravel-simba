# GlRptBctc03

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo kết quả hoạt động kinh doanh (Income Statement)
- **Assembly**: GlRptBctc03.dll
- **Version**: 9.1.0.0
- **Framework**: .NET Framework 3.5
- **Company**: Asia Software Development JSC

## Forms

### frmGlRptBctc03.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo kết quả hoạt động kinh doanh

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cboKyTruoc | ComboBox | - | cboKyTruoc_SelectedValueChanged |
| txtNgay01 | AsMaskedTextBox | - | - |
| txtNgay02 | AsMaskedTextBox | - | - |
| txtMa_Bp | AsTextBox | Lookup MA_BP | - |
| lblTen_Bp | Label | - | - |
| cmdPL | Button | - | cmdPL_Click |
| Label1 | Label | - | - |
| cboKyBc | ComboBox | - | - |
| cboMau_bc | ComboBox | - | - |
| txtNgay1 | AsMaskedTextBox | - | - |
| txtNgay2 | AsMaskedTextBox | - | - |
| txtMa_Nt | AsTextBox | - | - |
| optVND | RadioButton | - | - |
| optNt | RadioButton | - | - |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| InitOtherComponents | - | void | Khởi tạo components |
| InitKyBaoCaoTruoc | - | void | Khởi tạo kỳ báo cáo trước |
| cboKyTruoc_SelectedValueChanged | sender, e | void | Xử lý chọn kỳ trước |
| GetFilterCondiction | - | string | Lấy điều kiện filter |
| cmdPL_Click | sender, e | void | Mở form khai báo công thức |
| CreateDrilldownArgument | drilldownInfo, sDrilldownMenuId, keycode, modifierKeys, filterCondition4title, datasource | ArrayList | Xử lý drill-down |

### frmGLMauPL01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form quản lý mẫu báo cáo KQKD - Khai báo công thức

### frmGLMauPL01Edit.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form chỉnh sửa mẫu báo cáo

## Data Access

Không có DAO riêng - sử dụng controller mặc định.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| (Sử dụng SP từ controller base) | Lấy dữ liệu báo cáo KQKD | @pMa_cty, @pQd_cdkt, @pNgay1, @pNgay2, @pNgay01, @pNgay02, @pMa_mau, @pMa_Bp, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. User chọn kỳ báo cáo hiện tại
2. User chọn kỳ báo cáo trước (cboKyTruoc)
3. User nhập mã bộ phận (txtMa_Bp) - optional
4. User chọn loại tiền
5. Click OK để xem báo cáo so sánh

### InitKyBaoCaoTruoc
Khởi tạo danh sách kỳ báo cáo trước:
1. Lấy danh sách kỳ từ `Environment.GetKyBaoCao`
2. Thiết lập ValueMember = "ma", DisplayMember = "ten_ky"
3. Tự động chọn kỳ từ PublicVariables nếu có

### cboKyTruoc_SelectedValueChanged
Xử lý khi chọn kỳ trước:
- Nếu chọn "NGAY": Cho phép nhập ngày thủ công
- Nếu chọn kỳ khác: Tự động tính ngày kỳ trước (trừ 1 năm)

### LoadData
Phương thức `LoadData` thực hiện:
1. Tạo ArrayList với các tham số:
   - CompanyID
   - Qd_cdkt
   - Ngày kỳ này (txtNgay1, txtNgay2)
   - Ngày kỳ trước (txtNgay01, txtNgay02)
   - Mã mẫu báo cáo
   - Mã bộ phận (txtMa_Bp)
   - Mã ngoại tệ (txtMa_Nt)
2. Gọi `base.MyController.GetData` để lấy dữ liệu
3. Thiết lập FilterTitle và Quy vào FomularFields

### GetFilterCondiction
Tạo chuỗi điều kiện lọc hiển thị trên báo cáo:
- Kỳ báo cáo
- Kỳ trước (nếu có)
- Mã bộ phận (nếu có)
- Mã ngoại tệ (nếu có)

### cmdPL_Click
Mở form `frmGLMauPL01` để khai báo công thức tính các chỉ tiêu báo cáo KQKD.

### Drill-down
Hỗ trợ drill-down với phím F5:
- Nếu có `cach_tinh`: Drill-down xem chi tiết công thức
- Nếu có `tk_no` hoặc `tk_co`: Drill-down đến báo cáo chi tiết

### Tham số truyền vào stored procedure

| Thứ tự | Tham số | Ý nghĩa |
|--------|---------|---------|
| 1 | CompanyID | Mã công ty |
| 2 | Qd_cdkt | Quyết định chế độ kế toán |
| 3 | Ngay1 | Ngày bắt đầu kỳ này |
| 4 | Ngay2 | Ngày kết thúc kỳ này |
| 5 | Ngay01 | Ngày bắt đầu kỳ trước |
| 6 | Ngay02 | Ngày kết thúc kỳ trước |
| 7 | ma_mau | Mã mẫu báo cáo |
| 8 | ma_bp | Mã bộ phận |
| 9 | ma_nt | Mã ngoại tệ |

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_bctc03 | Dữ liệu báo cáo KQKD | R |
| GL_bctc03ct | Chi tiết công thức | R |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `Qd_cdkt` | Quyết định chế độ kế toán |
| `ma_so` | Mã số chỉ tiêu |
| `cach_tinh` | Cách tính chỉ tiêu |
| `tk_no` | Tài khoản nợ |
| `tk_co` | Tài khoản có |
| `chi_tieu` | Tên chỉ tiêu báo cáo |
| `ma_bp` | Mã bộ phận |
| `KyBaoCao` | Kỳ báo cáo |

## Phím tắt

| Phím | Chức năng |
|------|------------|
| F5 | Chi tiết công thức / Sổ chữ T |
| Ctrl+F5 | Sổ chi tiết |
| Shift+F5 | Cân đối phát sinh công nợ |
| F7 | Xem báo cáo |
| F9 | In báo cáo |

## Mapping sang PHP

### Controller
```php
class GlRptBctc03Controller extends ReportController {
    public function getData(Request $request) {
        $params = [
            'ma_cty' => $request->company_id,
            'qd_cdkt' => $request->accounting_standard,
            'ngay1' => $request->date_from,
            'ngay2' => $request->date_to,
            'ngay01' => $request->prev_date_from,
            'ngay02' => $request->prev_date_to,
            'ma_mau' => $request->template_code,
            'ma_bp' => $request->dept_code,
            'ma_nt' => $request->currency_code
        ];
        return $this->service->getIncomeStatement($params);
    }
    
    public function initPreviousPeriod(Request $request) {
        $currentPeriod = $request->current_period;
        // Tính ngày kỳ trước (trừ 1 năm)
        $prevDateFrom = Carbon::parse($currentPeriod['date_from'])->subYear();
        $prevDateTo = Carbon::parse($currentPeriod['date_to'])->subYear();
        return response()->json([
            'date_from' => $prevDateFrom,
            'date_to' => $prevDateTo
        ]);
    }
}
```

## Ghi chú
- Báo cáo kết quả hoạt động kinh doanh theo Thông tư 200/2014/TT-BTC
- Hỗ trợ so sánh với kỳ trước (cùng kỳ năm trước)
- Hỗ trợ lọc theo bộ phận (profit center)
- Sử dụng `KyBaoCao` để quản lý các kỳ báo cáo
- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Tích hợp với module khai báo mẫu báo cáo (`frmGLMauPL01`)
