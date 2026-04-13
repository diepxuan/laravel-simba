# Báo cáo Phân tích DLL: GLMAUBCTCTMVI29B.dll

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
| Assembly Name | GLMAUBCTCTMVI29B |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 9.1.0.0 |

---

## Cấu trúc File

```
GLMAUBCTCTMVI29B.dll/
├── GLMAUBCTCTMVI29B.csproj              # Project file
├── app.ico                                # Application icon
├── Properties/
│   └── AssemblyInfo.cs                    # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmGLMAUBCTCTMVI29B.cs           # Main view form
    └── frmGLMAUBCTCTMVI29BEdit.cs       # Edit form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML LINQ support |
| System.Core | .NET Core features |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `System.Xml.Linq`, `System.Core`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMVI29B` | `frmDMComplexView` | Form xem danh mục mẫu báo cáo I29B |
| `frmGLMAUBCTCTMVI29BEdit` | `frmDMComplexEdit` | Form chỉnh sửa mẫu báo cáo |

---

## Các control trên form Edit

| Control | Loại | Mục đích |
|---------|------|----------|
| txtMa_chtieu | AsTextBox | Mã chỉ tiêu |
| txtChi_tieu | TextBox | Tên chỉ tiêu |
| txtNd_chtieu | TextBox | Nội dung chỉ tiêu (multiline) |
| txtMauQD | AsTextBox | Mẫu quyết định |
| ChkIs_print | CheckBox | Có in hay không |
| ChkIs_italic | CheckBox | In nghiêng |
| chkKsd | AsCheckBox | In đậm |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã chỉ tiêu" - Nhãn mã chỉ tiêu
- "Chỉ tiêu" - Nhãn tên chỉ tiêu
- "Nội dung chỉ tiêu" - Nhãn nội dung
- "Có in" - Checkbox in báo cáo
- "In nghiêng" - Checkbox định dạng nghiêng
- "In đậm" - Checkbox định dạng đậm

### Thuật ngữ kỹ thuật

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã số chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu |
| `nd_chtieu` | Nội dung chỉ tiêu |
| `mau` | Mẫu quyết định |
| `IsPrint` | Có in hay không |
| `IsItalic` | In nghiêng |
| `bold` | In đậm |
| `Qd_cdkt` | Quyết định chế độ kế toán |

---

## Mục đích sử dụng

**GLMAUBCTCTMVI29B.dll là module quản lý mẫu báo cáo tài chính I29B** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý mẫu báo cáo I29B
- Xem danh sách các chỉ tiêu báo cáo
- Thêm mới chỉ tiêu
- Chỉnh sửa chỉ tiêu hiện có
- Xóa chỉ tiêu

#### 2. Định nghĩa chỉ tiêu
- Mã chỉ tiêu (ma_so)
- Tên chỉ tiêu (chi_tieu)
- Nội dung chi tiết (nd_chtieu)
- Mẫu quyết định áp dụng (mau)

#### 3. Tùy chọn định dạng
- Có in hay không (IsPrint)
- In nghiêng (IsItalic)
- In đậm (bold)

#### 4. Validation
- Kiểm tra mã chỉ tiêu không được rỗng
- Kiểm tra tên chỉ tiêu không được rỗng
- Tự động gán mẫu quyết định mặc định nếu chưa có

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMComplexView` và `frmDMComplexEdit` - form danh mục chuẩn
- Sử dụng DataBinding với BindingSource (bsDanhMuc)
- Hỗ trợ validation dữ liệu đầu vào
- Tích hợp với cấu hình công ty (CompanyInformations.Qd_cdkt)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý mẫu báo cáo tài chính I29B - cho phép định nghĩa và tùy chỉnh các chỉ tiêu báo cáo theo quyết định chế độ kế toán.

---

*Ngày phân tích: 2026-03-29*
