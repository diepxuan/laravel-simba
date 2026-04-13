# Báo cáo Phân tích DLL: GLRptBCTCCR01.dll

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
| Assembly Name | GLRptBCTCCR01 |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Version | 9.1.0.0 |

---

## Cấu trúc File

```
GLRptBCTCCR01.dll/
├── GLRptBCTCCR01.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGLRptBCTCCR01.cs      # Main report form
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
| `frmGLRptBCTCCR01` | `frmReport` | Form báo cáo tài chính CCR01 |

---

## Các tham số báo cáo

| Control | Loại | Mục đích |
|---------|------|----------|
| txtTk | AsTextBox | Tài khoản lọc báo cáo |
| txtBac | AsTextNumeric | Số bậc hiển thị (mặc định: 9) |
| chkTK_sc | CheckBox | Lên cho tài khoản sổ cái |
| lblTk | Label | Nhãn "Tài khoản" |
| lblbac | Label | Nhãn "In đến bậc" |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Tài khoản" - Nhãn chọn tài khoản
- "In đến bậc" - Nhãn số bậc hiển thị
- "Lên cho tk sổ cái" - Checkbox lên sổ cái

### Thuật ngữ kỹ thuật

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `txtTk` | TextBox nhập mã tài khoản |
| `txtBac` | Số bậc cấp tài khoản |
| `chkTK_sc` | Checkbox tài khoản sổ cái |
| `LookupCodeName = "TK"` | Mã lookup cho danh mục tài khoản |

---

## Mục đích sử dụng

**GLRptBCTCCR01.dll là module báo cáo tài chính CCR01** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Báo cáo tài chính CCR01
- Báo cáo cân đối phát sinh theo tài khoản
- Hỗ trợ hiển thị theo cấp bậc tài khoản
- Tùy chọn lên sổ cái

#### 2. Drill-down (F5)
- **F5**: Xem sổ chi tiết của tài khoản
- **Ctrl+F5**: Xem sổ chi tiết
- **Shift+F5**: Cân đối phát sinh công nợ
- **F7**: Xem
- **F9**: In

#### 3. Tham số hóa báo cáo
- Chọn tài khoản cụ thể
- Chọn số bậc hiển thị (1-9)
- Tùy chọn lên sổ cái

#### 4. Xuất dữ liệu
- Hỗ trợ xuất Excel
- In ấn báo cáo
- Drill-down để xem chi tiết

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của framework
- Sử dụng `AsTextBox` với AutoLookup cho tài khoản
- Sử dụng `AsTextNumeric` cho số bậc
- DataBinding với DataTable
- Hỗ trợ đa tiền tệ (VND/NT)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in báo cáo tài chính CCR01 - báo cáo cân đối phát sinh theo tài khoản với khả năng drill-down chi tiết.

---

*Ngày phân tích: 2026-03-29*
