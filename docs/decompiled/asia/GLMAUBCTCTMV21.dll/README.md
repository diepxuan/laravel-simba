# Báo cáo Phân tích DLL: GLMAUBCTCTMV21.dll

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
| Assembly Name | GLMAUBCTCTMV21 |
| Assembly Title | GLBCTC07V21 |
| Assembly Product | GLBCTC07V21 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | ca85ec56-3c3a-4c21-af73-ae1efd352415 |
| ComVisible | false |

---

## Cấu trúc File

```
GLMAUBCTCTMV21.dll/
├── GLMAUBCTCTMV21.csproj        # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmGLMAUBCTCTMV21.cs     # Main form class
    └── frmGLMAUBCTCTMV21Edit.cs # Edit form
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
| `frmGLMAUBCTCTMV21` | `frmDMComplexView` | Form xem danh mục mẫu báo cáo tài chính V21 |
| `frmGLMAUBCTCTMV21Edit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu báo cáo tài chính |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã chỉ tiêu" - Mã số chỉ tiêu báo cáo
- "Chỉ tiêu" - Tên chỉ tiêu
- "Nội dung chỉ tiêu" - Nội dung chi tiết
- "Công thức" - Cách tính chỉ tiêu
- "Tài khoản" - TK liên quan
- "In đậm", "In nghiêng", "Có in" - Tùy chọn in ấn

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_so` | Mã chỉ tiêu |
| `chi_tieu` | Tên chỉ tiêu |
| `nd_chtieu` | Nội dung chỉ tiêu |
| `cach_tinh` | Công thức tính |
| `tk_01` | Tài khoản |
| `IsItalic` | In nghiêng |
| `IsPrint` | Có in |
| `bold` | In đậm |
| `mau` | Mẫu quyết định |

---

## Mục đích sử dụng

**GLMAUBCTCTMV21.dll là module quản lý mẫu báo cáo tài chính V21** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu (ma_so)
- Nhập tên chỉ tiêu và nội dung chi tiết
- Thiết lập công thức tính toán

#### 2. Liên kết tài khoản kế toán
- Gán một tài khoản duy nhất (đơn giản hơn V20C)
- Hỗ trợ lookup tài khoản từ danh mục TK

#### 3. Định dạng in ấn
- Tùy chọn in đậm, in nghiêng
- Có in hay không
- Mẫu quyết định (Qd_cdkt)

### Đặc điểm kỹ thuật

- Kế thừa từ frmDMComplexEdit/frmDMComplexView
- DataBinding với DataTable
- Validation dữ liệu đầu vào
- Hỗ trợ chế độ thêm mới và chỉnh sửa

### So sánh với V20C

| Đặc điểm | V20C | V21 |
|----------|------|-----|
| Số TK | 2 TK (tk_01, tk_02) | 1 TK |
| Loại PS | Có combo | Không có |
| Độ phức tạp | Cao | Đơn giản |

### Mẫu báo cáo

**V21** - Một trong các mẫu báo cáo tài chính theo quy định

---

## Kết luận

Đây là module Windows Forms quản lý mẫu chỉ tiêu báo cáo tài chính V21, đơn giản hơn V20C với chỉ một tài khoản và không có phân loại phát sinh.

---

*Ngày phân tích: 2026-03-29*
