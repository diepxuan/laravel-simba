# Báo cáo Phân tích DLL: GLMAUBCTCTMV22A.dll

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
| Assembly Name | GLMAUBCTCTMV22A |
| Assembly Title | GLBCTC07V22a |
| Assembly Product | GLBCTC07V22a |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 5951348d-6e49-4ee9-88ac-3c639132f138 |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV22A.dll/
├── GLMAUBCTCTMV22A.csproj       # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmGLMAUBCTCTMV22A.cs    # Main form class
    └── frmGLMAUBCTCTMV22AEdit.cs # Edit form
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
| `frmGLMAUBCTCTMV22A` | `frmDMComplexView` | Form xem danh mục mẫu báo cáo tài chính V22A |
| `frmGLMAUBCTCTMV22AEdit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu báo cáo tài chính |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã chỉ tiêu" - Mã số chỉ tiêu báo cáo
- "Chỉ tiêu" - Tên chỉ tiêu
- "Nội dung chỉ tiêu" - Nội dung chi tiết
- "Công thức" - Cách tính chỉ tiêu
- "Tài khoản 1" đến "Tài khoản 12" - 12 TK liên quan
- "Loại phát sinh" - Loại PS kế toán
- "Năm phát sinh" - Năm PS
- "In đậm", "In nghiêng", "Có in" - Tùy chọn in ấn

### Loại phát sinh (LoaiPS)

| Mã | Ý nghĩa |
|----|---------|
| NODK | Dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ |
| NOCK | Dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ |
| PSNO | Phát sinh nợ |
| PSCo | Phát sinh có |

### Năm phát sinh (NamPS)

| Mã | Ý nghĩa |
|----|---------|
| Năm nay | Phát sinh năm hiện tại |
| Năm trước | Phát sinh năm trước |

### Thuật ngữ kế toán

| Thuộc tính | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu |
| `nd_chtieu` | Nội dung chỉ tiêu |
| `cach_tinh` | Công thức tính |
| `tk_01` đến `tk_12` | 12 tài khoản |
| `loai_ps` | Loại phát sinh |
| `nam_ps` | Năm phát sinh |
| `IsItalic` | In nghiêng |
| `IsPrint` | Có in |
| `bold` | In đậm |

---

## Mục đích sử dụng

**GLMAUBCTCTMV22A.dll là module quản lý mẫu báo cáo tài chính V22A** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu (ma_so)
- Nhập tên chỉ tiêu và nội dung chi tiết
- Thiết lập công thức tính toán

#### 2. Liên kết nhiều tài khoản kế toán
- Hỗ trợ lên đến 12 tài khoản (tk_01 đến tk_12)
- Lookup tài khoản từ danh mục TK

#### 3. Phân loại phát sinh
- Chọn loại phát sinh: Dư nợ/có đầu kỳ, Dư nợ/có cuối kỳ, Phát sinh nợ/có
- Chọn năm phát sinh: Năm nay/Năm trước

#### 4. Định dạng in ấn
- Tùy chọn in đậm, in nghiêng
- Có in hay không

### Đặc điểm kỹ thuật

- Kế thừa từ frmDMComplexEdit/frmDMComplexView
- DataBinding với DataTable
- Validation dữ liệu đầu vào
- Hỗ trợ chế độ thêm mới và chỉnh sửa

### Đặc trưng V22A

| Đặc điểm | Mô tả |
|----------|-------|
| Số TK | 12 TK (tk_01 đến tk_12) |
| Loại PS | Có combo chọn |
| Năm PS | Có combo chọn |
| Mục đích | Báo cáo phức tạp với nhiều TK và so sánh năm |

### So sánh các phiên bản V22

| Đặc điểm | V22A | V22b | V22c |
|----------|------|------|------|
| Số TK | 12 TK | 1 TK | 1 TK |
| Loại PS | 1 combo | 2 combo (DK/CK) | 1 combo |
| Năm PS | Có | Không | Không |
| Công nợ | Không | Có | Không |

### Mẫu báo cáo

**V22A** - Mẫu báo cáo tài chính phức tạp nhất trong dòng V22, hỗ trợ 12 tài khoản và phân loại theo năm.

---

## Kết luận

Đây là module Windows Forms quản lý mẫu chỉ tiêu báo cáo tài chính V22A, phiên bản nâng cao với khả năng liên kết 12 tài khoản và phân loại phát sinh theo năm.

---

*Ngày phân tích: 2026-03-29*
