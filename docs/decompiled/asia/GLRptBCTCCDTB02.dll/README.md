# Báo cáo Phân tích DLL: GLRptBCTCCDTB02.dll

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
| Assembly Name | GLRptBCTCCDTB02 |
| Assembly Title | GLRptKPDA01 |
| Assembly Product | GLRptKPDA01 |
| Assembly Company | - |
| Assembly Copyright | Copyright © 2013 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 9e59f574-a6c1-478e-8b30-0386e1a700c3 |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptBCTCCDTB02.dll/
├── GLRptBCTCCDTB02.csproj         # Project file
├── app.ico                          # Application icon
├── Properties/
│   └── AssemblyInfo.cs              # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptBCTCCDTB02.cs      # Main report form
└── AsiaErp.UserInterface.My/
    ├── MyProject.cs
    ├── MySettings.cs
    ├── MyApplication.cs
    ├── MyComputer.cs
    └── MySettingsProperty.cs
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs
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
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptBCTCCDTB02` | `frmReport` | Form báo cáo tài chính chi tiết B02 |

---

## Controls và UI Components

### Input Controls

| Control | Loại | Mục đích |
|---------|------|----------|
| `txtTk` | AsTextBox | Tài khoản |
| `lblTen_Tk` | Label | Tên tài khoản |
| `lblTk` | Label | Nhãn "Tài khoản" |
| `txtNgay1`, `txtNgay2` | AsMaskedTextBox | Từ ngày, đến ngày |
| `cboKyBc` | ComboBox | Kỳ báo cáo |
| `cboMau_bc` | ComboBox | Mẫu báo cáo |
| `txtMa_Nt` | AsTextBox | Mã ngoại tệ (ẩn) |
| `optVND`, `optNt` | RadioButton | Lựa chọn tiền tệ (ẩn) |
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

- "Tài khoản" - Tài khoản cần xem báo cáo chi tiết

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `tk` | Tài khoản |
| `ngay1`, `ngay2` | Khoảng thời gian báo cáo |
| `BCTCCDT` | Báo cáo tài chính chi tiết |
| `B02` | Mẫu báo cáo B02 |

### Cột báo cáo (dự kiến)

| Cột | Ý nghĩa |
|-----|----------|
| Chỉ tiêu | Tên chỉ tiêu báo cáo |
| Mã số | Mã số chỉ tiêu |
| Số năm nay | Số liệu năm hiện tại |
| Số năm trước | Số liệu năm trước |
| Chênh lệch | Chênh lệch giữa 2 năm |
| % | Tỷ lệ % thay đổi |

---

## Mục đích sử dụng

**GLRptBCTCCDTB02.dll là module báo cáo "Báo cáo tài chính chi tiết B02"** trong hệ thống ERP.

### Chức năng chính

#### 1. Báo cáo tài chính chi tiết
- Hiển thị báo cáo tài chính theo mẫu B02
- Chi tiết các chỉ tiêu tài chính
- So sánh số liệu giữa các kỳ/năm

#### 2. Lọc dữ liệu
- Lọc theo tài khoản (nếu có)
- Lọc theo khoảng thời gian
- Lọc theo kỳ báo cáo
- Lựa chọn mẫu báo cáo

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - Base form báo cáo của Asia ERP
- Sử dụng `ArrayList` để truyền tham số cho stored procedure
- AutoComplete cho trường tài khoản (LookupCodeName = "TK")
- Validation dữ liệu đầu vào (AutoValid = false cho txtTk)
- InitOtherComponents: Tự động điền tài khoản từ `MyMenuInfo.par1`

### Tham số truy vấn (dự kiến)

```csharp
ArrayList params = new ArrayList();
params.Add(CompanyInformations.CompanyID);  // Mã công ty
params.Add(txtNgay1.Value);                 // Từ ngày
params.Add(txtNgay2.Value);                 // Đến ngày
params.Add(txtTk.Text);                     // Tài khoản (nếu có)
params.Add(cboMau_bc.SelectedIndex);        // Mẫu báo cáo
```

---

## Kết luận

Đây là module báo cáo tài chính chi tiết (mẫu B02) trong hệ thống ERP Asia Enterprise, phục vụ cho việc lập và xem báo cáo tài chính chi tiết theo quy định của Bộ Tài chính Việt Nam.

---

*Ngày phân tích: 2026-03-29*