# Báo cáo Phân tích DLL: GLRptBCTCCDTF03C.dll

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
| Assembly Name | GLRptBCTCCDTF03C |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 9.1.0.0 |

---

## Cấu trúc File

```
GLRptBCTCCDTF03C.dll/
├── GLRptBCTCCDTF03C.csproj      # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGLRptBCTCCDTF03C.cs   # Main report form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLRptBCTCCDTF03C` | `frmReport` | Form báo cáo tài chính chi tiết F03C |

---

## Các tham số báo cáo

| Control | Loại | Mục đích |
|---------|------|----------|
| txtTk | AsTextBox | Tài khoản lọc báo cáo |
| lblTen_Tk | Label | Hiển thị tên tài khoản |
| lblTk | Label | Nhãn "Tài khoản" |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Tài khoản" - Nhãn chọn tài khoản

### Thuật ngữ kỹ thuật

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `txtTk` | TextBox nhập mã tài khoản |
| `LookupCodeName = "TK"` | Mã lookup cho danh mục tài khoản |
| `AutoLookup = true` | Tự động tìm kiếm khi nhập |

---

## Mục đích sử dụng

**GLRptBCTCCDTF03C.dll là module báo cáo tài chính chi tiết F03C** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo tài chính chi tiết F03C
- Báo cáo chi tiết theo tài khoản
- Lọc theo kỳ báo cáo
- Hiển thị thông tin tài khoản được chọn

#### 2. Tham số hóa báo cáo
- Nhận tham số từ menu thông qua MyMenuInfo.par1
- Cho phép chọn một tài khoản cụ thể
- Tự động hiển thị tên tài khoản khi chọn mã

#### 3. Xuất dữ liệu
- Hỗ trợ xuất Excel
- In ấn báo cáo
- Tùy chỉnh tiêu đề báo cáo

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của framework
- Sử dụng `AsTextBox` với AutoLookup cho tài khoản
- DataBinding với DataTable
- Form đơn giản, tập trung vào một tham số tài khoản

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in báo cáo tài chính chi tiết F03C - báo cáo phân tích theo tài khoản trong kế toán doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
