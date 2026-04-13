# Báo cáo Phân tích DLL: GlRptNkc04.dll

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
| Assembly Name | GlRptNkc04 |
| Assembly Title | Sổ nhật ký bán hàng |
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
GlRptNkc04.dll/
├── GlRptNkc04.csproj            # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGlRptNkc04.cs         # Main report form
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
- `System`, `System.Collections`, `System.Collections.Generic`
- `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`
- `System.Runtime.CompilerServices`, `System.Windows.Forms`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptNkc04` | `frmReport` | Form báo cáo Sổ nhật ký bán hàng |

---

## Controls và UI

### Form chính (frmGlRptNkc04)

| Control | Loại | Mục đích |
|---------|------|----------|
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| cboMau_bc | ComboBox | Mẫu báo cáo |
| txtDs_Tk_Dt_hh | AsTextBox | TK doanh thu hàng hóa |
| txtDs_Tk_Dt_tp | AsTextBox | TK doanh thu thành phẩm |
| txtDs_Tk_Dt_dv | AsTextBox | TK doanh thu dịch vụ |
| txtDs_Tk_pt | AsTextBox | TK phải thu |
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
| `LoadData()` | Tải dữ liệu báo cáo với các tham số: CompanyID, Ngày bắt đầu, Ngày kết thúc, TK phải thu, TKDT hàng hóa, TKDT thành phẩm, TKDT dịch vụ, Mã ngoại tệ |
| `InitOtherComponents()` | Khởi tạo giá trị mặc định cho các trường từ MyMenuInfo (par2-par5) |
| `ValidData()` | Kiểm tra tính hợp lệ dữ liệu - bắt buộc nhập đầy đủ các trường TK |

### Tham số truy vấn dữ liệu

```csharp
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
arrayList.Add(((TextBox)txtDs_Tk_pt).Text);       // TK phải thu
arrayList.Add(((TextBox)txtDs_Tk_Dt_hh).Text);    // TKDT hàng hóa
arrayList.Add(((TextBox)txtDs_Tk_Dt_tp).Text);    // TKDT thành phẩm
arrayList.Add(((TextBox)txtDs_Tk_Dt_dv).Text);    // TKDT dịch vụ
arrayList.Add(((TextBox)txtMa_Nt).Text);          // Mã ngoại tệ
```

---

## Mục đích sử dụng

**GlRptNkc04.dll là module báo cáo "Sổ nhật ký bán hàng" (NKC04)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo Sổ nhật ký bán hàng
- Hiển thị các giao dịch bán hàng trong kỳ
- Phân loại theo các nhóm doanh thu khác nhau
- Liên kết với tài khoản phải thu của khách hàng

#### 2. Phân loại tài khoản doanh thu
| Trường | Mô tả |
|--------|-------|
| TKDT hàng hóa | Tài khoản doanh thu từ bán hàng hóa |
| TKDT thành phẩm | Tài khoản doanh thu từ bán thành phẩm |
| TKDT dịch vụ | Tài khoản doanh thu từ cung cấp dịch vụ |
| TK phải thu | Tài khoản phải thu khách hàng |

#### 3. Validation dữ liệu
- Bắt buộc nhập đầy đủ 4 trường tài khoản
- Sử dụng `Commons.ChkEmtyTextBoxAndShowMessageBox` để kiểm tra

#### 4. Cấu hình mặc định
- Các giá trị mặc định được load từ `MyMenuInfo.par2` đến `par5`
- LookupCodeName = "TK" cho các trường tài khoản

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` base class
- Sử dụng `AsTextBox` với AutoLookup cho các trường tài khoản
- Tag `@pTK` cho các trường tham số
- Form size: 572 x 337

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `txtDs_Tk_Dt_hh` | TK Doanh thu hàng hóa |
| `txtDs_Tk_Dt_tp` | TK Doanh thu thành phẩm |
| `txtDs_Tk_Dt_dv` | TK Doanh thu dịch vụ |
| `txtDs_Tk_pt` | TK Phải thu |

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in Sổ nhật ký bán hàng - báo cáo chi tiết các giao dịch bán hàng phân loại theo nhóm doanh thu (hàng hóa, thành phẩm, dịch vụ).

---

*Ngày phân tích: 2026-03-29*
