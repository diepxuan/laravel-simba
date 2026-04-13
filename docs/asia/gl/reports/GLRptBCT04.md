# GlRptBCT04

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp (Direct Method Cash Flow Statement)
- **Assembly**: GlRptBCT04.dll
- **Version**: 9.1.0.0
- **Framework**: .NET Framework 3.5

## Forms

### frmGlRptBCT04.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp

#### Controls
| Control | Type | Data Binding | Events |
|---------|------|--------------|--------|
| cmdCF | Button | - | cmdCF_Click |
| cboKyBc | ComboBox | - | - |
| cboMau_bc | ComboBox | - | - |
| txtNgay1 | AsMaskedTextBox | - | - |
| txtNgay2 | AsMaskedTextBox | - | - |
| txtMa_Nt | AsTextBox | - | - |

#### Methods
| Method | Params | Return | Purpose |
|--------|--------|--------|---------|
| LoadData | - | bool | Load dữ liệu báo cáo |
| cmdCF_Click | sender, e | void | Mở form khai báo công thức |
| FormatGridView | - | void | Format grid cho phép edit |
| CellEnter | sender, e | void | Xử lý khi enter cell |
| CellValidated | sender, e | void | Xử lý khi validate cell |
| UpdateDataCell | maSo, tien, stt | int | Cập nhật dữ liệu cell |
| UpdateList | - | void | Cập nhật danh sách tính toán |
| ValidChiTieu | strList, strChitieu | bool | Validate chỉ tiêu |

### frmGLMauCF01.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form mẫu công thức 01 - Khai báo công thức tính toán các chỉ tiêu lưu chuyển tiền

### frmTATNDN01AEdit.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form chỉnh sửa dữ liệu

## Data Access

### IGlRptBCT04.cs
- **Interface**: IGlRptBCT04
- **Method**: UpdateDataCell

### MsSqlGlRptBCT04.cs
- **Implementation**: MsSqlGlRptBCT04
- **SP**: asRptUpdTATNDN01A_DC

#### Methods
| Method | SP Called | Input | Output | Purpose |
|--------|-----------|-------|--------|---------|
| UpdateDataCell | asRptUpdTATNDN01A_DC | @pMa_cty, @pNgay1, @pNgay2, @pMau, @pMa_So, @pTien, @pStt | @pRet | Cập nhật dữ liệu điều chỉnh |

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| asRptUpdTATNDN01A_DC | Cập nhật dữ liệu điều chỉnh | @pMa_cty, @pNgay1, @pNgay2, @pMau, @pMa_So, @pTien, @pStt | @pRet |

## Business Logic

### Luồng xử lý chính
1. User chọn kỳ báo cáo (từ ngày đến ngày)
2. Chọn mẫu báo cáo
3. Load dữ liệu báo cáo lưu chuyển tiền tệ
4. Hiển thị dữ liệu với các chỉ tiêu luồng tiền
5. User có thể chỉnh sửa các chỉ tiêu cho phép (modify = true)
6. Tự động tính toán các chỉ tiêu theo công thức

### Khai báo công thức
- Nút "KB Công thức" mở form `frmGLMauCF01`
- Cho phép định nghĩa công thức tính toán các chỉ tiêu lưu chuyển tiền

### Edit cell
- Chỉ cho phép edit cột `tien` khi `modify = true`
- Format số tiền theo cấu hình hệ thống
- Sau khi edit, cập nhật vào `_sourceCalc` và gọi SP lưu DB

### Tính toán công thức
- Các chỉ tiêu có `cach_tinh` chứa công thức tính
- Công thức chứa các phép toán: +, -, *, /
- Ví dụ: `A+B-C`, `D*E/F`
- Khi một chỉ tiêu thay đổi, tự động tính lại các chỉ tiêu liên quan
- Parse công thức: `A+B-C` → `sum([A])+sum([B])-sum([C])`
- Tính toán qua `DataTable.Compute`

### Validate chỉ tiêu
- Kiểm tra mã chỉ tiêu trong công thức có tồn tại trong `_sourceCalc.Columns`
- Thay thế mã chỉ tiêu bằng `sum([ma_chi_tieu])`

### Tham số truyền vào stored procedure

| Thứ tự | Tham số | Ý nghĩa |
|--------|---------|---------|
| 1 | CompanyID | Mã công ty |
| 2 | Ngay1 | Ngày bắt đầu |
| 3 | Ngay2 | Ngày kết thúc |
| 4 | ma_mau | Mã mẫu báo cáo |

## Cấu trúc báo cáo lưu chuyển tiền

Báo cáo bao gồm các phần:
1. **Lưu chuyển tiền từ hoạt động kinh doanh**
2. **Lưu chuyển tiền từ hoạt động đầu tư**
3. **Lưu chuyển tiền từ hoạt động tài chính**
4. **Tiền và tương đương tiền đầu kỳ/cuối kỳ**

## Tables liên quan

| Table | Purpose | CRUD |
|-------|---------|------|
| GL_tatndn01a | Dữ liệu báo cáo | R/U |
| GL_tatndn01act | Chi tiết công thức | R |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã số chỉ tiêu |
| `cach_tinh` | Cách tính (công thức) |
| `tien` | Số tiền |
| `stt` | Số thứ tự |
| `modify` | Cho phép sửa đổi |
| `luu_chuyen_tien` | Luồng tiền (cash flow) |

## Mapping sang PHP

### Controller
```php
class GlRptBCT04Controller extends ReportController {
    public function updateCell(Request $request) {
        $result = $this->service->updateDataCell($request->all());
        return response()->json(['success' => $result]);
    }
}
```

### Repository
```php
class GlRptBCT04Repository {
    public function updateDataCell($params) {
        return DB::select('EXEC asRptUpdTATNDN01A_DC ?, ?, ?, ?, ?, ?, ?', [
            $params['company_id'],
            $params['date_from'],
            $params['date_to'],
            $params['template_code'],
            $params['ma_so'],
            $params['tien'],
            $params['stt']
        ]);
    }
}
```

## Ghi chú
- Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp theo chuẩn mực kế toán Việt Nam
- Hỗ trợ khai báo công thức tính toán linh hoạt
- Cho phép điều chỉnh số liệu trực tiếp trên grid
- Tự động tính toán các chỉ tiêu phụ thuộc
- Kế thừa từ `frmReport` - Form báo cáo chuẩn
- Tầng Data Access với Interface `IGlRptBCT04`
