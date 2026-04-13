# Báo cáo Phân tích DLL: GLRptNKC08.dll

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
| Assembly Name | GLRptNKC08 |
| Assembly Title | GLRptNKC08 |
| Assembly Company | (không có) |
| Assembly Product | GLRptNKC08 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Trademark | (không có) |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 4f6fe48a-cfb5-4a89-b28c-669aa1500b43 |
| ComVisible | false |

---

## Cấu trúc File

```
GLRptNKC08.dll/
├── GLRptNKC08.csproj            # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmGLRptNKC08.cs         # Main report form
└── AsiaErp.UserInterface.My/
    └── Resources/               # Resources folder
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| AsiaErp.Framework | Asia ERP Framework |
| Microsoft.VisualBasic.CompilerServices | VB runtime support |
| System | Base system classes |
| System.Drawing | Graphics and drawing |
| System.Windows.Forms | Windows Forms UI |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `Microsoft.VisualBasic.CompilerServices`
- `System.Collections`, `System.ComponentModel`
- `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`
- `System.Windows.Forms`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptNKC08` | `frmReport` | Form báo cáo NKC08 |

---

## Controls và UI

### Form chính (frmGLRptNKC08)

| Control | Loại | Mục đích |
|---------|------|----------|
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| cboMau_bc | ComboBox | Mẫu báo cáo |
| txtTk | AsTextBox | Tài khoản |
| lblTk | Label | Tên tài khoản |
| txtMa_Nt | AsTextBox | Mã ngoại tệ (hidden) |
| optVND | RadioButton | Tùy chọn VNĐ (hidden) |
| optNt | RadioButton | Tùy chọn ngoại tệ (hidden) |
| lblMa_nt | Label | Nhãn mã ngoại tệ (hidden) |
| lblMauBC | Label | Nhãn mẫu BC (hidden) |
| cmdOk | Button | Xác nhận |
| cmdCancel | Button | Hủy bỏ |
| cmdExcel | Button | Xuất Excel |
| cmdModifyReport | Button | Chỉnh sửa báo cáo |

---

## Business Logic

### Phương thức chính

| Phương thức | Mô tả |
|-------------|-------|
| `LoadData()` | Tải dữ liệu báo cáo với các tham số: CompanyID, Ngày bắt đầu, Ngày kết thúc, Tài khoản |
| `ValidData()` | Kiểm tra tính hợp lệ dữ liệu - bắt buộc nhập tài khoản |

### Tham số truy vấn dữ liệu

```csharp
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
arrayList.Add(((TextBox)txtTk).Text);       // Tài khoản
```

### Validation

```csharp
if (Operators.CompareString(((TextBox)txtTk).Text, "", false) == 0)
{
    epNotice.SetError((Control)(object)txtTk, Helper.GetMess(50002).Description);
    ((Control)txtTk).Select();
    return false;
}
```

---

## Mục đích sử dụng

**GLRptNKC08.dll là module báo cáo "NKC08"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo NKC08
- Hiển thị báo cáo theo tài khoản cụ thể
- Lọc theo khoảng thời gian (ngày bắt đầu - kết thúc)
- Form size lớn hơn các NKC khác: 790 x 510

#### 2. Đặc điểm khác biệt
- **Không hiển thị** các controls liên quan đến ngoại tệ:
  - `txtMa_Nt` - Ẩn (Visible = false)
  - `optVND` - Ẩn
  - `optNt` - Ẩn
  - `lblMa_nt` - Ẩn
  - `lblMauBC` - Ẩn
- Báo cáo này chỉ làm việc với một loại tiền tệ (có thể là VNĐ mặc định)
- Constructor protected (khác với các NKC khác là public)

#### 3. Validation
- Bắt buộc nhập mã tài khoản
- Sử dụng ErrorProvider (`epNotice`) để hiển thị lỗi
- Message lỗi từ `Helper.GetMess(50002)`

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` base class
- Sử dụng `AsTextBox` với AutoLookup và AutoComplete
- LookupCodeName = "TK"
- Form size: 790 x 510 (lớn hơn các form NKC khác)
- Constructor: `protected` thay vì `public`
- UseAutoCompleteSource = true cho txtTk

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `txtTk` | Mã tài khoản |
| `lblTk` | Tên tài khoản |
| `txtMa_Nt` | Mã ngoại tệ (hidden) |

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in báo cáo NKC08. Khác với các module NKC khác, báo cáo này có form lớn hơn và ẩn các tùy chọn ngoại tệ, có thể là báo cáo chuyên dụng cho một mục đích cụ thể.

**Lưu ý:** Metadata cho thấy đây là phiên bản 2012 (khác với các NKC khác là 2010), có thể là module được phát triển hoặc cập nhật sau.

---

*Ngày phân tích: 2026-03-29*
