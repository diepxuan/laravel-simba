# Báo cáo Phân tích DLL: GLMAUBCTCTMV22c.dll

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
| Assembly Name | GLMAUBCTCTMV22c |
| Assembly Title | GLBCTC07V22c |
| Assembly Product | GLBCTC07V22c |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | a2b24e06-0f51-43c3-b68d-1830bf1c7689 |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV22c.dll/
├── GLMAUBCTCTMV22c.csproj       # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmGLMAUBCTCTMV22c.cs    # Main form class
    └── frmGLMAUBCTCTMV22cEdit.cs # Edit form
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
| `frmGLMAUBCTCTMV22c` | `frmDMComplexView` | Form xem danh mục mẫu báo cáo tài chính V22c |
| `frmGLMAUBCTCTMV22cEdit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu báo cáo tài chính |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã chỉ tiêu" - Mã số chỉ tiêu báo cáo
- "Chỉ tiêu" - Tên chỉ tiêu
- "Nội dung chỉ tiêu" - Nội dung chi tiết
- "Công thức" - Cách tính chỉ tiêu
- "Tài khoản" - TK liên quan
- "Loại phát sinh" - Loại PS kế toán
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

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu |
| `nd_chtieu` | Nội dung chỉ tiêu |
| `cach_tinh` | Công thức tính |
| `tk_01` | Tài khoản |
| `loai_ps` | Loại phát sinh |
| `IsItalic` | In nghiêng |
| `IsPrint` | Có in |
| `bold` | In đậm |

---

## Mục đích sử dụng

**GLMAUBCTCTMV22c.dll là module quản lý mẫu báo cáo tài chính V22c** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu (ma_so)
- Nhập tên chỉ tiêu và nội dung chi tiết
- Thiết lập công thức tính toán

#### 2. Liên kết tài khoản kế toán
- Gán một tài khoản
- Hỗ trợ lookup tài khoản từ danh mục TK

#### 3. Phân loại phát sinh
- Chọn loại phát sinh: Dư nợ/có đầu kỳ, Dư nợ/có cuối kỳ, Phát sinh nợ/có

#### 4. Định dạng in ấn
- Tùy chọn in đậm, in nghiêng
- Có in hay không

### Đặc điểm kỹ thuật

- Kế thừa từ frmDMComplexEdit/frmDMComplexView
- DataBinding với DataTable
- Validation dữ liệu đầu vào
- Hỗ trợ chế độ thêm mới và chỉnh sửa

### So sánh các phiên bản V22

| Đặc điểm | V22A | V22b | V22c |
|----------|------|------|------|
| Số TK | 12 TK | 1 TK | 1 TK |
| Loại PS | 1 combo | 2 combo (DK/CK) | 1 combo |
| Năm PS | Có | Không | Không |
| Công nợ | Không | Có | Không |

### Mẫu báo cáo

**V22c** - Mẫu báo cáo tài chính đơn giản với một tài khoản và một loại phát sinh.

---

## Kết luận

Đây là module Windows Forms quản lý mẫu chỉ tiêu báo cáo tài chính V22c, phiên bản cơ bản trong dòng V22 với cấu hình đơn giản nhất.

---

*Ngày phân tích: 2026-03-29*
