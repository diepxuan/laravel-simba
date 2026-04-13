# Báo cáo Phân tích DLL: GlRptNkc02.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GlRptNkc02 |
| Assembly Title | Sổ nhật ký chung |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
GlRptNkc02.dll/
├── GlRptNkc02.csproj              # Project file
├── app.ico                        # Application icon
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGlRptNkc02.cs           # Main report form class
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.Collections.Generic`
- `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`
- `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptNkc02` | `frmReport` | Form báo cáo Sổ nhật ký chung |

---

## Controls và UI Components

### Form chính (frmGlRptNkc02)

| Control | Loại | Mục đích |
|---------|------|----------|
| `AsTabControl` | TabControl | Tab container chính |
| `tabFilter` | TabPage | Tab lọc dữ liệu báo cáo |
| `tabGrid` | TabPage | Tab hiển thị dữ liệu dạng lưới |
| `cboKyBc` | ComboBox | Chọn kỳ báo cáo |
| `lblKyBc` | Label | Nhãn "Kỳ báo cáo" |
| `txtNgay1` | AsMaskedTextBox | Ngày bắt đầu |
| `txtNgay2` | AsMaskedTextBox | Ngày kết thúc |
| `lbl2` | Label | Nhãn phân cách ngày |
| `cboMau_bc` | ComboBox | Chọn mẫu báo cáo |
| `lblMau_bc` | Label | Nhãn "Mẫu báo cáo" |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ |
| `lblMa_nt` | Label | Nhãn "Mã ngoại tệ" |
| `lblMauBC` | Label | Nhãn hiển thị mã ngoại tệ |
| `optVND` | RadioButton | Tùy chọn hiển thị VNĐ |
| `optNt` | RadioButton | Tùy chọn hiển thị ngoại tệ |
| `txtTieu_De` | TextBox | Tiêu đề báo cáo |
| `lblTieu_de` | Label | Nhãn "Tiêu đề" |
| `cmdOk` | Button | Nút OK - thực hiện báo cáo |
| `cmdCancel` | Button | Nút Cancel - hủy bỏ |
| `cmdExcel` | Button | Nút xuất Excel |
| `cmdModifyReport` | Button | Nút chỉnh sửa mẫu báo cáo |
| `epNotice` | ErrorProvider | Hiển thị thông báo lỗi |

---

## Phương thức chính

| Phương thức | Mô tả |
|-------------|-------|
| `LoadData()` | Tải dữ liệu báo cáo từ controller với các tham số: CompanyID, Ngày bắt đầu, Ngày kết thúc, Mã ngoại tệ |
| `InitOtherComponents()` | Khởi tạo các component bổ sung |
| `InitializeComponent()` | Khởi tạo layout và vị trí các controls |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `Sổ nhật ký chung` | General Journal - Sổ ghi chép tất cả các nghiệp vụ kế toán |
| `Ky_bc` | Kỳ báo cáo |
| `Mau_bc` | Mẫu báo cáo |
| `Ma_nt` | Mã ngoại tệ |
| `VND` | Đồng Việt Nam |
| `Nt` | Ngoại tệ |

---

## Mục đích sử dụng

**GlRptNkc02.dll là module báo cáo "Sổ nhật ký chung"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Lọc và tìm kiếm dữ liệu
- Chọn kỳ báo cáo (kỳ kế toán)
- Xác định khoảng thời gian (từ ngày - đến ngày)
- Lọc theo mã ngoại tệ

#### 2. Tùy chọn hiển thị
- Hiển thị theo VNĐ hoặc ngoại tệ (RadioButton optVND/optNt)
- Chọn mẫu báo cáo khác nhau
- Tùy chỉnh tiêu đề báo cáo

#### 3. Xuất dữ liệu
- Xem dữ liệu dạng lưới (tabGrid)
- Xuất ra Excel (cmdExcel)
- Chỉnh sửa mẫu báo cáo (cmdModifyReport)

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - base form cho các báo cáo trong hệ thống
- Sử dụng `AsTabControl` - custom tab control của Asia ERP
- Sử dụng `AsMaskedTextBox` cho nhập liệu ngày tháng
- Tích hợp với `MyController.GetData()` để lấy dữ liệu từ database
- Hỗ trợ đa tiền tệ (VND và ngoại tệ)

### Tham số truy vấn dữ liệu

Hàm `LoadData()` truyền các tham số sau vào stored procedure:
1. `CompanyID` - ID công ty
2. `txtNgay1.Value` - Ngày bắt đầu
3. `txtNgay2.Value` - Ngày kết thúc
4. `txtMa_Nt.Text` - Mã ngoại tệ

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và xuất báo cáo **Sổ nhật ký chung** - một báo cáo kế toán tổng hợp quan trọng ghi nhận toàn bộ nghiệp vụ kinh tế phát sinh của doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
