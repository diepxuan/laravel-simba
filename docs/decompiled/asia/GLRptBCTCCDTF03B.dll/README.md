# Báo cáo Phân tích DLL: GLRptBCTCCDTF03B.dll

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
| Assembly Name | GLRptBCTCCDTF03B |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 9.1.0.0 |

---

## Cấu trúc File

```
GLRptBCTCCDTF03B.dll/
├── GLRptBCTCCDTF03B.csproj      # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGLRptBCTCCDTF03B.cs   # Main report form
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
| `frmGLRptBCTCCDTF03B` | `frmReport` | Form báo cáo tài chính chi tiết F03B |

---

## Các tham số báo cáo

| Control | Loại | Mục đích |
|---------|------|----------|
| txtTk_xaylap | AsTextBox | Tài khoản xây lắp |
| txtTk_Thietbi | AsTextBox | Tài khoản thiết bị |
| txtTk_boithuong | AsTextBox | Tài khoản bồi thường |
| txtTk_QLDA | AsTextBox | Tài khoản quản lý dự án |
| txtTk_TuVan | AsTextBox | Tài khoản tư vấn |
| txtTk_Khac | AsTextBox | Tài khoản khác |
| txtMa_SPCT | AsTextBox | Mã sản phẩm chi tiết |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Tk xây lắp" - Nhãn tài khoản xây lắp
- "Tk thiết bị" - Nhãn tài khoản thiết bị
- "Tk bồi thường" - Nhãn tài khoản bồi thường
- "Tk QLDA" - Nhãn tài khoản quản lý dự án
- "Tk tư vấn" - Nhãn tài khoản tư vấn
- "Tk khác" - Nhãn tài khoản khác
- "Mã SPCT" - Nhãn mã sản phẩm chi tiết

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `tk_xaylap` | Tài khoản xây lắp |
| `tk_thietbi` | Tài khoản thiết bị |
| `tk_boithuong` | Tài khoản bồi thường |
| `tk_qlda` | Tài khoản quản lý dự án |
| `tk_tuvan` | Tài khoản tư vấn |
| `tk_khac` | Tài khoản khác |
| `ma_spct` | Mã sản phẩm chi tiết |

---

## Mục đích sử dụng

**GLRptBCTCCDTF03B.dll là module báo cáo tài chính chi tiết F03B** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo tài chính chi tiết F03B
- Báo cáo chi tiết theo các tài khoản: xây lắp, thiết bị, bồi thường, quản lý dự án, tư vấn, khác
- Lọc theo mã sản phẩm chi tiết (SPCT)
- Hỗ trợ kỳ báo cáo tùy chọn

#### 2. Tham số hóa báo cáo
- Nhận tham số từ menu thông qua MyMenuInfo.par1-par6
- Cho phép chọn nhiều tài khoản đồng thời
- Tự động hiển thị tên tài khoản khi chọn mã

#### 3. Xuất dữ liệu
- Hỗ trợ xuất Excel
- In ấn báo cáo
- Drill-down để xem chi tiết

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của framework
- Sử dụng `AsTextBox` với AutoLookup cho tài khoản
- DataBinding với DataTable
- Hỗ trợ đa tiền tệ (ẩn theo mặc định)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in báo cáo tài chính chi tiết F03B - báo cáo phân tích theo nhiều loại tài khoản khác nhau trong kế toán doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
