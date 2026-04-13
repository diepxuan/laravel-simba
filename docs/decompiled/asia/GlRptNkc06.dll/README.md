# Báo cáo Phân tích DLL: GlRptNkc06.dll

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
| Assembly Name | GlRptNkc06 |
| Assembly Title | Sổ chi tiết các tài khoản |
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
GlRptNkc06.dll/
├── GlRptNkc06.csproj            # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGlRptNkc06.cs         # Main report form
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
| `frmGlRptNkc06` | `frmReport` | Form báo cáo Sổ chi tiết các tài khoản |

---

## Controls và UI

### Form chính (frmGlRptNkc06)

| Control | Loại | Mục đích |
|---------|------|----------|
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| cboMau_bc | ComboBox | Mẫu báo cáo |
| txtTk | AsTextBox | Tài khoản |
| lblTen_Tk | Label | Tên tài khoản |
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
| `LoadData()` | Tải dữ liệu báo cáo, tính toán số dư đầu kỳ và cuối kỳ |
| `ValidData()` | Kiểm tra tính hợp lệ dữ liệu - bắt buộc nhập tài khoản |
| `InitOtherComponents()` | Khởi tạo các thành phần bổ sung |

### Tham số truy vấn dữ liệu

```csharp
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
arrayList.Add(((TextBox)txtTk).Text);       // Tài khoản
arrayList.Add(((TextBox)txtMa_Nt).Text);    // Mã ngoại tệ
```

### Formula Fields

| Field | Mô tả |
|-------|-------|
| `TK` | Mã tài khoản |
| `TEN_TK` | Tên tài khoản |
| `Du_Co_Cky` | Dư có cuối kỳ (từ row 2 ps_co) |
| `Du_No_Cky` | Dư nợ cuối kỳ (từ row 2 ps_no) |
| `Du_Co_Dky` | Dư có đầu kỳ (từ row 0 ps_co) |
| `Du_No_Dky` | Dư nợ đầu kỳ (từ row 0 ps_no) |

---

## Mục đích sử dụng

**GlRptNkc06.dll là module báo cáo "Sổ chi tiết các tài khoản" (NKC06)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo Sổ chi tiết tài khoản
- Hiển thị chi tiết phát sinh của một tài khoản cụ thể
- Tính toán số dư đầu kỳ và cuối kỳ
- Hiển thị đầy đủ thông tin phát sinh nợ/có trong kỳ

#### 2. Tính toán số dư
- **Dư đầu kỳ**: Lấy từ dòng 0 của DataSource (ps_no, ps_co)
- **Dư cuối kỳ**: Lấy từ dòng 2 của DataSource (ps_no, ps_co)
- Các giá trị được đưa vào Formula Fields để hiển thị trên báo cáo

#### 3. Validation
- Bắt buộc nhập mã tài khoản
- Sử dụng `ChkEmtyTextBox` để kiểm tra

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` base class
- Sử dụng `AsTextBox` với AutoLookup cho trường tài khoản
- LookupCodeName = "TK"
- Form size: 555 x 259
- Tự động focus vào txtTk khi validation

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `txtTk` | Mã tài khoản |
| `lblTen_Tk` | Tên tài khoản |
| `Du_Co_Dky` | Dư có đầu kỳ |
| `Du_No_Dky` | Dư nợ đầu kỳ |
| `Du_Co_Cky` | Dư có cuối kỳ |
| `Du_No_Cky` | Dư nợ cuối kỳ |
| `ps_no` | Phát sinh nợ |
| `ps_co` | Phát sinh có |

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in Sổ chi tiết các tài khoản - báo cáo chi tiết phát sinh và số dư của một tài khoản kế toán cụ thể.

---

*Ngày phân tích: 2026-03-29*
