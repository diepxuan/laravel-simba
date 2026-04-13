# Báo cáo Phân tích DLL: GLMAUBCTCTMV20C.dll

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
| Assembly Name | GLMAUBCTCTMV20C |
| Assembly Title | GLBCTC07V20c |
| Assembly Product | GLBCTC07V20c |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 5e8ad7e7-0ac1-42c2-a0ef-61eace120003 |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV20C.dll/
├── GLMAUBCTCTMV20C.csproj       # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmGLMAUBCTCTMV20C.cs    # Main form class
    └── frmGLMAUBCTCTMV20CEdit.cs # Edit form
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
- `System`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLMAUBCTCTMV20C` | `frmDMComplexView` | Form xem danh mục mẫu báo cáo tài chính V20C |
| `frmGLMAUBCTCTMV20CEdit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu báo cáo tài chính |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã chỉ tiêu" - Mã số chỉ tiêu báo cáo
- "Chỉ tiêu" - Tên chỉ tiêu
- "Nội dung chỉ tiêu" - Nội dung chi tiết
- "Công thức" - Cách tính chỉ tiêu
- "Tài khoản 1", "Tài khoản 2" - TK liên quan
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
| `tk_01`, `tk_02` | Tài khoản 1, 2 |
| `loai_ps` | Loại phát sinh |
| `IsItalic` | In nghiêng |
| `IsPrint` | Có in |
| `bold` | In đậm |
| `mau` | Mẫu quyết định |

---

## Mục đích sử dụng

**GLMAUBCTCTMV20C.dll là module quản lý mẫu báo cáo tài chính V20C** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu (ma_so)
- Nhập tên chỉ tiêu và nội dung chi tiết
- Thiết lập công thức tính toán

#### 2. Liên kết tài khoản kế toán
- Gán tài khoản 1 và tài khoản 2
- Hỗ trợ lookup tài khoản từ danh mục

#### 3. Phân loại phát sinh
- Chọn loại phát sinh: Dư nợ/có đầu kỳ, Dư nợ/có cuối kỳ, Phát sinh nợ/có
- Tùy chỉnh theo nhu cầu báo cáo

#### 4. Định dạng in ấn
- Tùy chọn in đậm, in nghiêng
- Có in hay không
- Mẫu quyết định (Qd_cdkt)

### Đặc điểm kỹ thuật

- Kế thừa từ frmDMComplexEdit/frmDMComplexView
- DataBinding với DataTable
- Validation dữ liệu đầu vào
- Hỗ trợ chế độ thêm mới và chỉnh sửa

### Mẫu báo cáo

**V20C** - Một trong các mẫu báo cáo tài chính theo quy định (Thông tư 200/2014/TT-BTC)

---

## Kết luận

Đây là module Windows Forms quản lý mẫu chỉ tiêu báo cáo tài chính V20C, cho phép người dùng định nghĩa và cấu hình các chỉ tiêu báo cáo với công thức tính toán linh hoạt.

---

*Ngày phân tích: 2026-03-29*
