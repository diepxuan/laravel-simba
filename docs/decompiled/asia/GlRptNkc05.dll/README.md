# Báo cáo Phân tích DLL: GlRptNkc05.dll

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
| Assembly Name | GlRptNkc05 |
| Assembly Title | Sổ nhật ký mua hàng |
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
GlRptNkc05.dll/
├── GlRptNkc05.csproj            # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGlRptNkc05.cs         # Main report form
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
- `System`, `System.Collections`, `System.ComponentModel`
- `System.Diagnostics`, `System.Drawing`, `System.Runtime.CompilerServices`
- `System.Windows.Forms`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptNkc05` | `frmReport` | Form báo cáo Sổ nhật ký mua hàng |

---

## Controls và UI

### Form chính (frmGlRptNkc05)

| Control | Loại | Mục đích |
|---------|------|----------|
| cboKyBc | ComboBox | Chọn kỳ báo cáo |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc |
| txtTieu_De | TextBox | Tiêu đề báo cáo |
| cboMau_bc | ComboBox | Mẫu báo cáo |
| txtDs_Tk_hh | AsTextBox | TK hàng hóa |
| txtDs_Tk_nvl | AsTextBox | TK NVL (Nguyên vật liệu) |
| txtDs_Tk_khac | AsTextBox | TK kho khác |
| txtDs_Tk_pt | AsTextBox | TK phải trả |
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
| `LoadData()` | Tải dữ liệu báo cáo với các tham số: CompanyID, Ngày bắt đầu, Ngày kết thúc, TK phải trả, TK hàng hóa, TK NVL, TK kho khác, Mã ngoại tệ |
| `InitOtherComponents()` | Khởi tạo giá trị mặc định cho các trường từ MyMenuInfo (par2-par5) |
| `lblDs_Tk_nvl_Click()` | Event handler click (hiện tại rỗng) |

### Tham số truy vấn dữ liệu

```csharp
arrayList.Add(CompanyInformations.CompanyID);
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay1.Value));
arrayList.Add(RuntimeHelpers.GetObjectValue(txtNgay2.Value));
arrayList.Add(((TextBox)txtDs_Tk_pt).Text);       // TK phải trả
arrayList.Add(((TextBox)txtDs_Tk_hh).Text);       // TK hàng hóa
arrayList.Add(((TextBox)txtDs_Tk_nvl).Text);      // TK NVL
arrayList.Add(((TextBox)txtDs_Tk_khac).Text);     // TK kho khác
arrayList.Add(((TextBox)txtMa_Nt).Text);          // Mã ngoại tệ
```

---

## Mục đích sử dụng

**GlRptNkc05.dll là module báo cáo "Sổ nhật ký mua hàng" (NKC05)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo Sổ nhật ký mua hàng
- Hiển thị các giao dịch mua hàng trong kỳ
- Phân loại theo các nhóm kho/nguyên liệu khác nhau
- Liên kết với tài khoản phải trả cho nhà cung cấp

#### 2. Phân loại tài khoản kho
| Trường | Mô tả |
|--------|-------|
| TK hàng hóa | Tài khoản kho hàng hóa |
| TK NVL | Tài khoản nguyên vật liệu |
| TK kho khác | Tài khoản các kho khác |
| TK phải trả | Tài khoản phải trả nhà cung cấp |

#### 3. Cấu hình mặc định
- Các giá trị mặc định được load từ `MyMenuInfo.par2` đến `par5`
- LookupCodeName = "TK" cho các trường tài khoản
- Sử dụng AutoCompleteSource cho các trường nhập liệu

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` base class
- Sử dụng `AsTextBox` với AutoLookup và AutoComplete
- Tag `@pTK` cho các trường tham số
- Form size: 564 x 334
- CharacterCasing = Upper cho các trường mã

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `txtDs_Tk_hh` | TK Hàng hóa |
| `txtDs_Tk_nvl` | TK Nguyên vật liệu |
| `txtDs_Tk_khac` | TK Kho khác |
| `txtDs_Tk_pt` | TK Phải trả |

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in Sổ nhật ký mua hàng - báo cáo chi tiết các giao dịch mua hàng phân loại theo nhóm kho (hàng hóa, nguyên vật liệu, kho khác).

---

*Ngày phân tích: 2026-03-29*
