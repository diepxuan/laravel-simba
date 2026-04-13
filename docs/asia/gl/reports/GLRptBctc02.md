# GlRptBctc02

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Bảng cân đối kế toán (Balance Sheet)
- **Assembly**: GlRptBctc02.dll
- **Version**: 9.1.0.0
- **Framework**: .NET Framework 3.5
- **Company**: Asia Software Development JSC

## Forms

### frmGlRptBctc02.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo bảng cân đối kế toán

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cmdBS | Button | - | cmdBS_Click |
| chkChiTieuCoSoLieu | CheckBox | - | - |
| cboMau_bc | ComboBox | - | - |
| txtNgay2 | AsMaskedTextBox | - | - |
| cboKyBc | ComboBox | - | - |
| txtTieu_De | TextBox | - | - |
| txtMa_Nt | AsTextBox | - | - (ẩn) |
| optVND | RadioButton | - | - (ẩn) |
| optNt | RadioButton | - | - (ẩn) |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| InitOtherComponents | - | void | Khởi tạo components |
| AsTabControl_SelectedIndexChanged | sender, e | void | Xử lý tab change |
| cmdBS_Click | sender, e | void | Mở form khai báo công thức BS |
| CreateDrilldownArgument | drilldownInfo, sDrilldownMenuId, keycode, modifierKeys, filterCondition4title, datasource | ArrayList | Xử lý drill-down |

### frmGLMauBS01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form mẫu bảng cân đối kế toán - Khai báo công thức

### frmGLMauBS01Edit.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form chỉnh sửa mẫu báo cáo

## Data Access

Không có DAO riêng - sử dụng controller mặc định.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| (Sử dụng SP từ controller base) | Lấy dữ liệu cân đối kế toán | @pMa_cty, @pQd_cdkt, @pNgay, @pChiTieuCoSoLieu, @pMa_mau | DataTable |

## Business Logic

### Luồng xử lý chính
1. User chọn kỳ báo cáo
2. User chọn mẫu báo cáo
3. User chọn ngày báo cáo (txtNgay2)
4. User chọn "Chỉ lên các chỉ tiêu có số liệu" (chkChiTieuCoSoLieu)
5. Click OK để xem báo cáo

### LoadData
Phương thức `LoadData` thực hiện:
1. Tạo ArrayList với các tham số:
   - CompanyID
   - Qd_cdkt (chế độ kế toán)
   - Ngày báo cáo (txtNgay2)
   - Checkbox chỉ tiêu có số liệu
   - Mã mẫu báo cáo
2. Gọi `base.MyController.GetData` để lấy dữ liệu
3. Thiết lập subtitle với ngày lập báo cáo
4. Kiểm tra cân đối tài sản = nguồn vốn (mã số 270 và 440)
5. Hiển thị cảnh báo nếu không cân đối

### Kiểm tra cân đối
Sau khi load dữ liệu, hệ thống tự động kiểm tra:
- Tổng tài sản (mã số 270) phải bằng Tổng nguồn vốn (mã số 440)
- Nếu không cân đối, hiển thị thông báo lỗi với số chênh lệch

### cmdBS_Click
Mở form `frmGLMauBS01` để khai báo công thức tính các chỉ tiêu bảng cân đối kế toán.

### Drill-down
Hỗ trợ drill-down với phím F5:
- Nếu có `cach_tinh`: Drill-down xem chi tiết công thức
- Nếu có `tk`: Drill-down đến sổ chữ T
- Ctrl+F5: Drill-down đến sổ chi tiết
- Shift+F5: Drill-down đến cân đối phát sinh công nợ (nếu cong_no = 1)

### Tham số truyền vào stored procedure

| Thứ tự | Tham số | Ý nghĩa |
|--------|---------|---------|
| 1 | CompanyID | Mã công ty |
| 2 | Qd_cdkt | Quyết định chế độ kế toán |
| 3 | Ngay | Ngày báo cáo |
| 4 | ChiTieuCoSoLieu | Chỉ lên chỉ tiêu có số liệu |
| 5 | ma_mau | Mã mẫu báo cáo |

## Cấu trúc bảng cân đối kế toán

Báo cáo bao gồm các phần:
1. **TÀI SẢN NGẮN HẠN** (mã số 100)
2. **TÀI SẢN DÀI HẠN** (mã số 200)
3. **TỔNG CỘNG TÀI SẢN** (mã số 270)
4. **NỢ PHẢI TRẢ** (mã số 300)
5. **VỐN CHỦ SỞ HỮU** (mã số 400)
6. **TỔNG CỘNG NỢ PHẢI TRẢ VÀ VỐN CHỦ SỞ HỮU** (mã số 440)

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_bctc02 | Dữ liệu báo cáo tài chính | R |
| GL_bctc02ct | Chi tiết công thức | R |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `Qd_cdkt` | Quyết định chế độ kế toán |
| `ma_so` | Mã số chỉ tiêu (ví dụ: 270, 440) |
| `tien0` | Số tiền kỳ trước |
| `tien` | Số tiền kỳ này |
| `cach_tinh` | Cách tính chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu báo cáo |
| `cong_no` | Công nợ |

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
class GlRptBctc02Controller extends ReportController {
    public function getData(Request $request) {
        $params = [
            'ma_cty' => $request->company_id,
            'qd_cdkt' => $request->accounting_standard,
            'ngay' => $request->report_date,
            'chi_tieu_co_so_lieu' => $request->has_data_only,
            'ma_mau' => $request->template_code
        ];
        $data = $this->service->getBalanceSheetData($params);
        
        // Kiểm tra cân bằng
        $this->validateBalance($data);
        
        return $data;
    }
    
    private function validateBalance($data) {
        $taiSan = $data->where('ma_so', '270')->first();
        $nguonVon = $data->where('ma_so', '440')->first();
        
        if ($taiSan->tien != $nguonVon->tien) {
            // Hiển thị cảnh báo
        }
    }
}
```

## Ghi chú
- Bảng cân đối kế toán theo Thông tư 200/2014/TT-BTC
- Tự động kiểm tra cân bằng tài sản = nguồn vốn
- Hỗ trợ khai báo công thức linh hoạt
- Ẩn các tùy chọn tiền tệ (chỉ hiển thị VND)
- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Tích hợp với module khai báo mẫu báo cáo (`frmGLMauBS01`)
