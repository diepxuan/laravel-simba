# GlRptBctc04

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp (Cash Flow Statement - Direct Method)
- **Assembly**: GlRptBctc04.dll
- **Version**: 9.1.0.0
- **Framework**: .NET Framework 3.5
- **Company**: Asia Software Development JSC

## Forms

### frmGlRptBctc04.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cboKyTruoc | ComboBox | - | cboKyTruoc_SelectedValueChanged |
| txtNgay01 | AsMaskedTextBox | - | - |
| txtNgay02 | AsMaskedTextBox | - | - |
| cmdCF | Button | - | cmdCF_Click |
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
| cmdCF_Click | sender, e | void | Mở form khai báo công thức |
| CreateDrilldownArgument | drilldownInfo, sDrilldownMenuId, keycode, modifierKeys, filterCondition4title, datasource | ArrayList | Xử lý drill-down |

### frmGLMauCF01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form quản lý mẫu báo cáo lưu chuyển tiền - Khai báo công thức

### frmGLMauCF01Edit.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form chỉnh sửa mẫu báo cáo

## Data Access

Không có DAO riêng - sử dụng controller mặc định.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| (Sử dụng SP từ controller base) | Lấy dữ liệu báo cáo lưu chuyển tiền | @pMa_cty, @pQd_cdkt, @pNgay1, @pNgay2, @pNgay01, @pNgay02, @pMa_mau, @pMa_nt | DataTable |

## Business Logic

### Luồng xử lý chính
1. User chọn kỳ báo cáo hiện tại
2. User chọn kỳ báo cáo trước (cboKyTruoc)
3. User chọn loại tiền
4. Click OK để xem báo cáo so sánh

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
   - Mã ngoại tệ (txtMa_Nt)
2. Gọi `base.MyController.GetData` để lấy dữ liệu
3. Thiết lập FilterTitle và Quy vào FomularFields

### GetFilterCondiction
Tạo chuỗi điều kiện lọc hiển thị trên báo cáo:
- Kỳ báo cáo
- Kỳ trước (nếu có)
- Mã ngoại tệ (nếu có)

### cmdCF_Click
Mở form `frmGLMauCF01` để khai báo công thức tính các chỉ tiêu báo cáo lưu chuyển tiền.

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
| 8 | ma_nt | Mã ngoại tệ |

## Cấu trúc báo cáo lưu chuyển tiền

Báo cáo bao gồm các phần:
1. **Lưu chuyển tiền từ hoạt động kinh doanh**
2. **Lưu chuyển tiền từ hoạt động đầu tư**
3. **Lưu chuyển tiền từ hoạt động tài chính**
4. **Tiền và tương đương tiền đầu kỳ/cuối kỳ**

## Phương pháp trực tiếp

- Thu thập thông tin trực tiếp từ các khoản thu/chi tiền
- Khác với phương pháp gián tiếp (điều chỉnh từ lợi nhuận)
- Theo chuẩn mực kế toán Việt Nam

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_bctc04 | Dữ liệu báo cáo lưu chuyển tiền | R |
| GL_bctc04ct | Chi tiết công thức | R |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `Qd_cdkt` | Quyết định chế độ kế toán |
| `ma_so` | Mã số chỉ tiêu |
| `cach_tinh` | Cách tính chỉ tiêu |
| `tk_no` | Tài khoản nợ |
| `tk_co` | Tài khoản có |
| `chi_tieu` | Tên chỉ tiêu báo cáo |
| `KyBaoCao` | Kỳ báo cáo |
| `luu_chuyen_tien` | Luồng tiền (cash flow) |

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
class GlRptBctc04Controller extends ReportController {
    public function getData(Request $request) {
        $params = [
            'ma_cty' => $request->company_id,
            'qd_cdkt' => $request->accounting_standard,
            'ngay1' => $request->date_from,
            'ngay2' => $request->date_to,
            'ngay01' => $request->prev_date_from,
            'ngay02' => $request->prev_date_to,
            'ma_mau' => $request->template_code,
            'ma_nt' => $request->currency_code
        ];
        return $this->service->getCashFlowStatement($params);
    }
}
```

## Ghi chú
- Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp theo chuẩn mực kế toán Việt Nam
- Hỗ trợ so sánh với kỳ trước (cùng kỳ năm trước)
- Phương pháp trực tiếp (Direct Method) - khác với phương pháp gián tiếp
- Sử dụng `KyBaoCao` để quản lý các kỳ báo cáo
- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Tích hợp với module khai báo mẫu báo cáo (`frmGLMauCF01`)
