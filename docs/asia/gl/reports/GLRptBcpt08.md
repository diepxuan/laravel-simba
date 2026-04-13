# GlRptBcpt08

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo kết quả hoạt động sản xuất kinh doanh (Income Statement)
- **Assembly**: GlRptBcpt08.dll
- **Version**: 1.0.0.0
- **Framework**: .NET Framework
- **Company**: ASIASOFT

## Forms

### frmGlRptBcpt08.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo kết quả hoạt động sản xuất kinh doanh

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cmdPL | Button | - | cmdPL_Click |
| cboKyBc | ComboBox | - | - |
| cboMau_bc | ComboBox | - | - |
| txtNgay1 | AsMaskedTextBox | - | - |
| txtNgay2 | AsMaskedTextBox | - | - |
| txtMa_Nt | AsTextBox | - | - |
| txtTieu_De | TextBox | - | - |
| optVND | RadioButton | - | - |
| optNt | RadioButton | - | - |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| GetFilterCondiction | - | string | Lấy điều kiện filter |
| cmdPL_Click | sender, e | void | Mở form khai báo công thức |
| CreateDrilldownArgument | drilldownInfo, sDrilldownMenuId, keycode, modifierKeys, filterCondition4title, datasource | ArrayList | Xử lý drill-down (F5) |

### frmGLMauPL01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form mẫu phụ lục 01 - Khai báo công thức tính toán các chỉ tiêu

### frmGLMauPL01Edit.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form chỉnh sửa mẫu phụ lục

## Data Access

Không có DAO riêng - sử dụng controller mặc định của frmReport.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| (Sử dụng SP từ controller base) | Lấy dữ liệu báo cáo | @pMa_cty, @pNgay1, @pNgay2, @pMa_mau, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. User chọn kỳ báo cáo
2. User chọn mẫu báo cáo
3. User chọn loại tiền tệ (VND/ngoại tệ)
4. Click OK để xem báo cáo
5. Hệ thống gọi LoadData() để lấy dữ liệu
6. Hiển thị dữ liệu trên DataGridView

### Khai báo công thức
- Nút "KB Công thức" mở form `frmGLMauPL01`
- Cho phép định nghĩa công thức tính toán các chỉ tiêu báo cáo KQKD

### Drill-down (F5)
- **F5**: Drill-down đến báo cáo chi tiết theo công thức hoặc tài khoản
- **Shift+F5**: Xem sổ chi tiết tài khoản
- **Ctrl+F5**: Xem công nợ (chỉ cho TK công nợ)

### Xử lý công thức
- Parse công thức từ chuỗi `cach_tinh`
- Tính toán giá trị chỉ tiêu từ các mã số khác
- Hỗ trợ các phép toán: +, -, *, /

### Tham số truyền vào stored procedure

| Thứ tự | Tham số | Ý nghĩa |
|--------|---------|---------|
| 1 | CompanyID | Mã công ty |
| 2 | Ngay1 | Ngày bắt đầu |
| 3 | Ngay2 | Ngày kết thúc |
| 4 | ma_mau | Mã mẫu báo cáo |
| 5 | ma_nt | Mã ngoại tệ |

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_bcPL01 | Lưu cấu trúc báo cáo PL01 | R |
| GL_bcPL01ct | Chi tiết công thức báo cáo | R |
| Ct | Chứng từ | R |
| Ctgt | Chi tiết giá thành | R |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã số chỉ tiêu |
| `cach_tinh` | Cách tính (công thức) |
| `tk` | Tài khoản |
| `cong_no` | Công nợ |
| `tien` | Tiền |

## Mapping sang PHP

### Controller
```php
class GlRptBcpt08Controller extends ReportController {
    public function index() {
        // Hiển thị form filter
    }
    
    public function getData(Request $request) {
        // Lấy dữ liệu báo cáo
        $params = [
            'ma_cty' => $request->company_id,
            'ngay1' => $request->date_from,
            'ngay2' => $request->date_to,
            'ma_mau' => $request->report_template,
            'ma_nt' => $request->currency_code
        ];
        return $this->service->getReportData($params);
    }
}
```

### Repository
```php
class GlRptBcpt08Repository {
    public function getReportData($params) {
        return DB::select('EXEC sp_GetBcpt08Data ?, ?, ?, ?, ?', [
            $params['ma_cty'],
            $params['ngay1'],
            $params['ngay2'],
            $params['ma_mau'],
            $params['ma_nt']
        ]);
    }
}
```

## Ghi chú
- Báo cáo kết quả hoạt động sản xuất kinh doanh theo chế độ kế toán
- Hỗ trợ khai báo công thức tính toán linh hoạt
- Có thể drill-down để xem chi tiết chứng từ
- Hỗ trợ 3 loại drill-down khác nhau (F5, Shift+F5, Ctrl+F5)
- Tích hợp với `frmGLMauPL01` cho khai báo công thức
- Xử lý công thức tính toán động
