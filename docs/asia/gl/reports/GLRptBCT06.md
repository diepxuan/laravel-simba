# GlRptBCT06

## Tổng quan
- **Module**: GL (General Ledger)
- **Loại**: Report
- **Chức năng**: Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp (Direct Method Cash Flow Statement) - Phiên bản 6
- **Assembly**: GlRptBCT06.dll
- **Version**: 9.1.0.0
- **Framework**: .NET Framework 3.5

## Forms

### frmGlRptBCT06.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form báo cáo lưu chuyển tiền tệ - Phiên bản đơn giản

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
| InitOtherComponents | - | void | Khởi tạo components |

### frmTATNDN031A.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form mẫu TATNDN031A - Khai báo công thức

### frmTATNDN031AEdit.cs
- **Kế thừa**: frmReport
- **Chức năng**: Form chỉnh sửa dữ liệu

## Data Access

Không có DAO riêng - sử dụng controller mặc định.

## Stored Procedures được gọi

| SP | Purpose | Input Params | Output |
|----|---------|--------------|--------|
| (Sử dụng SP từ controller base) | Lấy dữ liệu tờ khai | @pMa_cty, @pNgay1, @pNgay2, @pMa_mau | DataTable |

## Business Logic

### Luồng xử lý chính
1. User chọn kỳ báo cáo
2. Chọn mẫu báo cáo
3. Chọn loại tiền tệ (VND/ngoại tệ)
4. Load dữ liệu báo cáo lưu chuyển tiền tệ
5. Hiển thị dữ liệu báo cáo
6. Có thể mở form khai báo công thức

### Khai báo công thức
- Nút "KB Công thức" mở form `frmTATNDN031A`
- Cho phép định nghĩa công thức tính toán các chỉ tiêu lưu chuyển tiền

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
| GL_tatndn031a | Dữ liệu tờ khai TATNDN031A | R |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã số chỉ tiêu |
| `cach_tinh` | Cách tính (công thức) |
| `tien` | Số tiền |

## So sánh với các phiên bản khác

| Phiên bản | Đặc điểm |
|-----------|----------|
| BCT04 | Có nhập liệu trực tiếp, tầng Data Access riêng |
| BCT05 | Có nhập liệu trực tiếp, tầng Data Access riêng |
| BCT06 | Đơn giản, chỉ hiển thị, không nhập liệu trực tiếp |

## Mapping sang PHP

### Controller
```php
class GlRptBCT06Controller extends ReportController {
    public function index() {
        return view('reports.tatndn031a');
    }
}
```

## Ghi chú
- Báo cáo lưu chuyển tiền tệ theo phương pháp trực tiếp - Phiên bản 6
- Đơn giản hơn BCT04 và BCT05
- Không có tính năng nhập liệu trực tiếp trên grid
- Tập trung vào việc hiển thị và xuất báo cáo
- Kế thừa từ `frmReport` - Form báo cáo chuẩn
