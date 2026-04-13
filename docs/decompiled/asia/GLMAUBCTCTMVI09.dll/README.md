# Báo cáo Phân tích DLL: GLMAUBCTCTMVI09.dll

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
| Assembly Name | GLMAUBCTCTMVI09 |
| Assembly Title | GLBCTC07V08 |
| Assembly Product | GLBCTC07V08 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 76235428-9a04-4384-9205-c595568c4e32 |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMVI09.dll/
├── GLMAUBCTCTMVI09.csproj       # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmGLMAUBCTCTMVI09.cs    # Main form class
│   └── frmGLMAUBCTCTMVI09Edit.cs # Edit form
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs             # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML LINQ support |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.UserInterface`
- `System`, `System.Collections`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMVI09` | `frmDMComplexView` | Form xem danh sách mẫu báo cáo tài chính I09 |
| `frmGLMAUBCTCTMVI09Edit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu báo cáo tài chính I09 |
| `Resources` | - | Resource manager cho localization |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã chỉ tiêu" - Mã số chỉ tiêu báo cáo
- "Chỉ tiêu" - Tên chỉ tiêu
- "Nội dung chỉ tiêu" - Nội dung chi tiết
- "Công thức" - Cách tính chỉ tiêu
- "Tài khoản 1" đến "Tài khoản 6" - Các tài khoản liên quan
- "Loại phát sinh" - Loại phát sinh kế toán
- "Có in" - Cho phép in
- "In nghiêng" - In nghiêng
- "In đậm" - In đậm

### Loại phát sinh (LoaiPS)

| Mã | Ý nghĩa |
|----|---------|
| NODK | Dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ |
| NOCK | Dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ |
| PSNO | Phát sinh nợ |
| PSCO | Phát sinh có |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã chỉ tiêu |
| `chi_tieu` | Chỉ tiêu |
| `nd_chtieu` | Nội dung chỉ tiêu |
| `cach_tinh` | Cách tính/công thức |
| `tk_01` đến `tk_06` | Tài khoản 1-6 |
| `loai_ps` | Loại phát sinh |
| `mau` | Mẫu quyết định |
| `IsPrint` | Có in không |
| `IsItalic` | In nghiêng |
| `bold` | In đậm |

---

## Mục đích sử dụng

**GLMAUBCTCTMVI09.dll là module quản lý mẫu báo cáo tài chính I09** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính I09
- Quản lý mã chỉ tiêu (ma_so) theo mẫu quyết định
- Quản lý tên chỉ tiêu và nội dung chi tiết
- Hỗ trợ công thức tính toán (cach_tinh)
- Liên kết với tối đa 6 tài khoản kế toán (tk_01 đến tk_06)

#### 2. Cấu hình loại phát sinh
- Hỗ trợ 6 loại phát sinh: Dư nợ/có đầu kỳ, Dư nợ/có cuối kỳ, Phát sinh nợ/có
- Tích hợp dropdown chọn loại phát sinh

#### 3. Tùy chọn in ấn
- Chọn có in hay không (IsPrint)
- Tùy chọn in nghiêng (IsItalic)
- Tùy chọn in đậm (bold)

#### 4. Validation dữ liệu
- Kiểm tra mã chỉ tiêu không được rỗng
- Kiểm tra tên chỉ tiêu không được rỗng
- Tự động gán mẫu quyết định mặc định nếu chưa có

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Kế thừa từ frmDMComplexView/frmDMComplexEdit của Framework
- Sử dụng AsTextBox với AutoLookup cho tài khoản
- ComboBox binding với ArrayList DictionaryEntry
- Kiểm tra validation dữ liệu đầu vào

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc cấu hình và quản lý mẫu báo cáo tài chính I09 - một loại báo cáo tài chính theo quy định của Bộ Tài chính Việt Nam.

---

*Ngày phân tích: 2026-03-29*
