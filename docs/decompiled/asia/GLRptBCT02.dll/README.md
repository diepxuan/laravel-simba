# Báo cáo Phân tích DLL: GLRptBCT02.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLRptBCT02 |
| Assembly Title | Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ bán ra |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptBCT02.dll/
├── GLRptBCT02.csproj              # Project file
├── app.ico                          # Application icon
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGLRptBCT02.cs           # Main report form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Drawing | Graphics rendering |
| System.Windows.Forms | UI framework |
| AsiaErp.Framework | Asia ERP Framework base classes |
| Microsoft.Office.Interop.Excel | Excel export functionality |
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.Office.Interop.Excel`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptBCT02` | `frmReport` | Form báo cáo bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ bán ra |

---

## Controls và UI Components

### Input Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `txtThue_suat` | AsTextNumeric | Thuế suất |
| `txtTk` | AsTextBox | Tài khoản thuế |
| `lblTen_Tk` | Label | Tên tài khoản thuế |
| `txtTk_Du` | AsTextBox | Tài khoản đối ứng |
| `lblTen_Tk_Du` | Label | Tên tài khoản đối ứng |
| `txtMa_Bp` | AsTextBox | Mã bộ phận |
| `lblTen_Bp` | Label | Tên bộ phận |
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Từ ngày, đến ngày |
| `cboKyBc` | ComboBox | Kỳ báo cáo |
| `cboMau_bc` | ComboBox | Mẫu báo cáo |
| `optVND`, `optNt` | RadioButton | Lựa chọn tiền tệ (VND/Ngoại tệ) |
| `txtTieu_De` | TextBox | Tiêu đề báo cáo |

### Action Buttons

| Button | Mục đích |
|--------|----------|
| `cmdOk` | Thực hiện báo cáo |
| `cmdCancel` | Hủy bỏ |
| `cmdExcel` | Xuất Excel |
| `cmdModifyReport` | Sửa mẫu báo cáo |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ bán ra" - Tên chức năng chính
- "Thuế suất" - Tỷ lệ thuế GTGT
- "Tài khoản thuế" - TK thuế GTGT đầu ra
- "Tài khoản đ/ư" - Tài khoản đối ứng
- "Mã bộ phận" - Phân loại theo bộ phận

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `thue_suat` | Thuế suất GTGT |
| `tk` | Tài khoản thuế GTGT |
| `tk_du` | Tài khoản đối ứng |
| `ma_bp` | Mã bộ phận |
| `ngay1`, `ngay2` | Khoảng thời gian báo cáo |

### Export Excel HTKK

- "BangKeThueRa_Thang{Month}_Nam_{Year}.xls" - Pattern file export
- Template: `uTaOut.xls` - Mẫu Excel HTKK cho thuế đầu ra

---

## Mục đích sử dụng

**GLRptBCT02.dll là module báo cáo "Bảng kê hóa đơn, chứng từ hàng hóa, dịch vụ bán ra"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Lọc và truy vấn dữ liệu
- Lọc theo khoảng thời gian (từ ngày - đến ngày)
- Lọc theo thuế suất GTGT
- Lọc theo tài khoản thuế và tài khoản đối ứng
- Lọc theo mã bộ phận
- Lựa chọn mẫu báo cáo (cboMau_bc)

#### 2. Báo cáo thuế GTGT đầu ra
- Liệt kê hóa đơn bán hàng hóa, dịch vụ
- Phân loại theo thuế suất
- Tính toán thuế GTGT phải nộp
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ)

#### 3. Export Excel HTKK
- Xuất dữ liệu sang Excel theo mẫu HTKK (Hỗ trợ kê khai thuế)
- Template: `uTaOut.xls`
- File output: `BangKeThueRa_Thang{X}_Nam_{YYYY}.xls`

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Base form báo cáo của Asia ERP
- Sử dụng `ArrayList` để truyền tham số cho stored procedure
- Tích hợp Microsoft Excel Interop để export dữ liệu
- AutoComplete cho các trường tài khoản, bộ phận
- Validation dữ liệu đầu vào (AutoValid, AutoLookup)

### Tham số truy vấn

```csharp
ArrayList params = new ArrayList();
params.Add(CompanyInformations.CompanyID);  // Mã công ty
params.Add(txtNgay1.Value);                 // Từ ngày
params.Add(txtNgay2.Value);                 // Đến ngày
params.Add(txtThue_suat.Value);             // Thuế suất
params.Add(txtTk.Text);                     // TK thuế
params.Add(txtTk_Du.Text);                  // TK đối ứng
params.Add(txtMa_Bp.Text);                  // Mã bộ phận
params.Add(cboMau_bc.SelectedIndex);        // Mẫu báo cáo
```

---

## Kết luận

Đây là module báo cáo thuế GTGT đầu ra trong hệ thống ERP Asia Enterprise, phục vụ cho việc kê khai thuế GTGT theo quy định của Tổng cục Thuế Việt Nam. Module hỗ trợ export dữ liệu sang Excel theo mẫu HTKK để nộp thuế.

---

*Ngày phân tích: 2026-03-29*
