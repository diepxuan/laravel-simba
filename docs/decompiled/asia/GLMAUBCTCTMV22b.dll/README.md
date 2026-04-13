# Báo cáo Phân tích DLL: GLMAUBCTCTMV22b.dll

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
| Assembly Name | GLMAUBCTCTMV22b |
| Assembly Title | GLBCTC07V22b |
| Assembly Product | GLBCTC07V22b |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 266c71a2-799f-472e-8413-01cf7007e143 |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV22b.dll/
├── GLMAUBCTCTMV22b.csproj       # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmGLMAUBCTCTMV22b.cs    # Main form class
    └── frmGLMAUBCTCTMV22bEdit.cs # Edit form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMV22b` | `frmDMComplexView` | Form xem danh mục mẫu báo cáo tài chính V22b |
| `frmGLMAUBCTCTMV22bEdit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu báo cáo tài chính |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã chỉ tiêu" - Mã số chỉ tiêu báo cáo
- "Chỉ tiêu" - Tên chỉ tiêu
- "Nội dung chỉ tiêu" - Nội dung chi tiết
- "Công thức" - Cách tính chỉ tiêu
- "Tài khoản" - TK liên quan
- "Loại phát sinh đầu kỳ" - Loại PS đầu kỳ
- "Loại phát sinh cuối kỳ" - Loại PS cuối kỳ
- "In đậm", "In nghiêng", "Có in" - Tùy chọn in ấn

### Loại phát sinh đầu kỳ (LoaiPS_DK)

| Mã | Ý nghĩa |
|----|---------|
| NODK | Dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ |
| NODKCN | Dư nợ đầu kỳ công nợ |
| CODKCN | Dư có đầu kỳ công nợ |

### Loại phát sinh cuối kỳ (LoaiPS_CK)

| Mã | Ý nghĩa |
|----|---------|
| NOCK | Dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ |
| NOCKCN | Dư nợ cuối kỳ công nợ |
| COCKCN | Dư có cuối kỳ công nợ |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu |
| `nd_chtieu` | Nội dung chỉ tiêu |
| `cach_tinh` | Công thức tính |
| `tk_01` | Tài khoản |
| `loai_ps_dk` | Loại phát sinh đầu kỳ |
| `loai_ps_ck` | Loại phát sinh cuối kỳ |
| `IsItalic` | In nghiêng |
| `IsPrint` | Có in |
| `bold` | In đậm |

---

## Mục đích sử dụng

**GLMAUBCTCTMV22b.dll là module quản lý mẫu báo cáo tài chính V22b** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu (ma_so)
- Nhập tên chỉ tiêu và nội dung chi tiết
- Thiết lập công thức tính toán

#### 2. Liên kết tài khoản kế toán
- Gán một tài khoản
- Hỗ trợ lookup tài khoản từ danh mục TK

#### 3. Phân loại phát sinh đầu/cuối kỳ riêng biệt
- Loại phát sinh đầu kỳ: Dư nợ/có đầu kỳ (có/không công nợ)
- Loại phát sinh cuối kỳ: Dư nợ/có cuối kỳ (có/không công nợ)

#### 4. Định dạng in ấn
- Tùy chọn in đậm, in nghiêng
- Có in hay không

### Đặc điểm kỹ thuật

- Kế thừa từ frmDMComplexEdit/frmDMComplexView
- DataBinding với DataTable
- Validation dữ liệu đầu vào
- Hỗ trợ chế độ thêm mới và chỉnh sửa

### Đặc trưng V22b

| Đặc điểm | Mô tả |
|----------|-------|
| PS đầu kỳ | 4 loại (có công nợ) |
| PS cuối kỳ | 4 loại (có công nợ) |
| Công nợ | Hỗ trợ cả TK công nợ |
| Mục đích | Báo cáo so sánh đầu/cuối kỳ |

### Mẫu báo cáo

**V22b** - Mẫu báo cáo tài chính với phân loại phát sinh đầu/cuối kỳ riêng biệt, hỗ trợ cả tài khoản công nợ.

---

## Kết luận

Đây là module Windows Forms quản lý mẫu chỉ tiêu báo cáo tài chính V22b, đặc biệt ở khả năng phân loại phát sinh đầu kỳ và cuối kỳ riêng biệt với hỗ trợ tài khoản công nợ.

---

*Ngày phân tích: 2026-03-29*
