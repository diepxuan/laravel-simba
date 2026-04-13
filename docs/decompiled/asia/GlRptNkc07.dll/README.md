# Báo cáo Phân tích DLL: GlRptNkc07.dll

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
| Assembly Name | GlRptNkc07 |
| Assembly Title | Sổ cái chữ T của một tài khoản |
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
GlRptNkc07.dll/
├── GlRptNkc07.csproj            # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGlRptNkc07.cs         # Main report form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| AsiaErp.Framework | Asia ERP Framework |
| Microsoft.VisualBasic.CompilerServices | VB runtime support |
| System | Base system classes |
| System.Data | Data access |
| System.Drawing | Graphics and drawing |
| System.Windows.Forms | Windows Forms UI |
| System.Runtime.InteropServices | Interop services |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `Microsoft.VisualBasic.CompilerServices`
- `System`, `System.Collections`, `System.Collections.Generic`
- `System.ComponentModel`, `System.Data`, `System.Diagnostics`
- `System.Drawing`, `System.Runtime.CompilerServices`
- `System.Runtime.InteropServices`, `System.Windows.Forms`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptNkc07` | `frmReport` | Form báo cáo Sổ cái chữ T |

---

## Controls và UI

### Form chính (frmGlRptNkc07)

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
| `LoadData()` | Tải dữ liệu báo cáo, tính toán số dư đầu/cuối kỳ |
| `ValidData()` | Kiểm tra tính hợp lệ dữ liệu - bắt buộc nhập tài khoản |
| `InitOtherComponents()` | Khởi tạo các thành phần bổ sung |
| `CreateDrilldownArgument()` | Tạo tham số drill-down khi nhấn F5 trên dòng có tk_du |

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
| `TK` | Mã tài khoản + Tên tài khoản |
| `Du_Co_Cky` | Dư có cuối kỳ |
| `Du_No_Cky` | Dư nợ cuối kỳ |
| `Du_Co_Dky` | Dư có đầu kỳ |
| `Du_No_Dky` | Dư nợ đầu kỳ |

### Drill-down Functionality

| Phím | Chức năng |
|------|-----------|
| F5 | Drill-down xem chi tiết theo tài khoản đối ứng (tk_du) |

**Điều kiện drill-down:**
- Phải nhấn phím F5
- Dòng hiện tại phải có giá trị `tk_du` không rỗng

**Tham số drill-down:**
```csharp
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(((TextBox)txtTk).Text);           // TK chính
arrayList.Add(dataRowView["tk_du"].ToString()); // TK đối ứng
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
arrayList.Add(((TextBox)txtMa_Nt).Text);
```

---

## Mục đích sử dụng

**GlRptNkc07.dll là module báo cáo "Sổ cái chữ T của một tài khoản" (NKC07)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo Sổ cái chữ T
- Hiển thị sổ cái theo định dạng chữ T (T-Account)
- Tổng hợp phát sinh theo tài khoản đối ứng
- Hiển thị số dư đầu kỳ và cuối kỳ

#### 2. Tính toán số dư
- **Dư đầu kỳ**: Lấy từ dòng 0 của DataSource
- **Dư cuối kỳ**: Lấy từ dòng 2 của DataSource
- TK hiển thị dạng: "Mã TK - Tên TK"

#### 3. Drill-down (F5)
- Cho phép xem chi tiết theo tài khoản đối ứng
- Chỉ hoạt động khi dòng có `tk_du` khác rỗng
- Filter condition title: "TK/Tk_du"

#### 4. Validation
- Bắt buộc nhập mã tài khoản
- Sử dụng `ChkEmtyTextBox` để kiểm tra
- AutoValid = true cho txtTk

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` base class
- Sử dụng `AsTextBox` với AutoLookup cho trường tài khoản
- LookupCodeName = "TK"
- Form size: 564 x 260
- Hỗ trợ drill-down qua phím F5

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `txtTk` | Mã tài khoản |
| `lblTen_Tk` | Tên tài khoản |
| `tk_du` | Tài khoản đối ứng |
| `Du_Co_Dky` | Dư có đầu kỳ |
| `Du_No_Dky` | Dư nợ đầu kỳ |
| `Du_Co_Cky` | Dư có cuối kỳ |
| `Du_No_Cky` | Dư nợ cuối kỳ |

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in Sổ cái chữ T - báo cáo tổng hợp phát sinh của một tài khoản theo định dạng chữ T, có hỗ trợ drill-down xem chi tiết theo tài khoản đối ứng.

---

*Ngày phân tích: 2026-03-29*
