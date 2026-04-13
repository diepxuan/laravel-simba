# Báo cáo Phân tích DLL: GlRptNkc03.dll

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
| Assembly Name | GlRptNkc03 |
| Assembly Title | Sổ nhật ký thu tiền |
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
GlRptNkc03.dll/
├── GlRptNkc03.csproj            # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGlRptNkc03.cs         # Main report form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| AsiaErp.Framework | Asia ERP Framework |
| Microsoft.VisualBasic | Visual Basic runtime support |
| System | Base system classes |
| System.Drawing | Graphics and drawing |
| System.Windows.Forms | Windows Forms UI |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`
- `System`, `System.Collections`, `System.Collections.Generic`
- `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`
- `System.Runtime.CompilerServices`, `System.Windows.Forms`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptNkc03` | `frmReport` | Form báo cáo Sổ nhật ký thu tiền |

---

## Controls và UI

### Form chính (frmGlRptNkc03)

| Control | Loại | Mục đích |
|---------|------|----------|
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| cboMau_bc | ComboBox | Mẫu báo cáo |
| txtDs_Tk | AsTextBox | Danh sách tài khoản nợ |
| txtDs_Tk_Du | AsTextBox | Danh sách tài khoản có |
| txtMa_Bp | AsTextBox | Mã bộ phận |
| lblTen_Bp | Label | Tên bộ phận |
| txtMa_Nt | AsTextBox | Mã ngoại tệ |
| optVND | RadioButton | Tùy chọn VNĐ |
| optNt | RadioButton | Tùy chọn ngoại tệ |
| cmdOk | Button | Xác nhận |
| cmdCancel | Button | Hủy bỏ |
| cmdExcel | Button | Xuất Excel |
| cmdModifyReport | Button | Chỉnh sửa báo cáo |

---

## Business Logic

### Phương thức chính

| Phương thức | Mô tả |
|-------------|-------|
| `LoadData()` | Tải dữ liệu báo cáo với các tham số: CompanyID, Ngày bắt đầu, Ngày kết thúc, DS TK nợ, DS TK có, Mã bộ phận, Mã ngoại tệ |
| `InitOtherComponents()` | Khởi tạo giá trị mặc định cho txtDs_Tk và txtDs_Tk_Du từ MyMenuInfo |
| `ValidData()` | Kiểm tra tính hợp lệ dữ liệu đầu vào |
| `txtDs_Tk_Validated()` | Validation định dạng danh sách tài khoản (chỉ cho phép số và dấu phẩy) |
| `frmGlRptNkc03_FormClosing()` | Xử lý khi đóng form |

### Tham số truy vấn dữ liệu

```csharp
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
arrayList.Add(((TextBox)txtDs_Tk).Text);      // Danh sách TK nợ
arrayList.Add(((TextBox)txtDs_Tk_Du).Text);   // Danh sách TK có
arrayList.Add(((TextBox)txtMa_Bp).Text);      // Mã bộ phận
arrayList.Add(((TextBox)txtMa_Nt).Text);      // Mã ngoại tệ
```

---

## Mục đích sử dụng

**GlRptNkc03.dll là module báo cáo "Sổ nhật ký thu tiền" (NKC03)** trong hệ thống ERP