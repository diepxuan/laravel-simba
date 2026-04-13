# GLMAUBCTCTMV22b - Mẫu báo cáo tài chính V22b

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLMAUBCTCTMV22b.dll |
| Loại | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Chức năng | Quản lý mẫu báo cáo tài chính V22b |

## Chức năng chính

### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu (ma_so)
- Nhập tên chỉ tiêu và nội dung chi tiết
- Thiết lập công thức tính toán

### 2. Liên kết tài khoản kế toán
- Gán một tài khoản
- Hỗ trợ lookup tài khoản từ danh mục TK

### 3. Phân loại phát sinh đầu/cuối kỳ riêng biệt
- Loại phát sinh đầu kỳ: Dư nợ/có đầu kỳ (có/không công nợ)
- Loại phát sinh cuối kỳ: Dư nợ/có cuối kỳ (có/không công nợ)

### 4. Định dạng in ấn
- Tùy chọn in đậm, in nghiêng
- Có in hay không

## Loại phát sinh đầu kỳ (LoaiPS_DK)

| Mã | Ý nghĩa |
|----|---------|
| NODK | Dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ |
| NODKCN | Dư nợ đầu kỳ công nợ |
| CODKCN | Dư có đầu kỳ công nợ |

## Loại phát sinh cuối kỳ (LoaiPS_CK)

| Mã | Ý nghĩa |
|----|---------|
| NOCK | Dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ |
| NOCKCN | Dư nợ cuối kỳ công nợ |
| COCKCN | Dư có cuối kỳ công nợ |

## Thuật ngữ kế toán

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

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmGLMAUBCTCTMV22b` | `frmDMComplexView` | Form xem danh mục mẫu BCTC V22b |
| `frmGLMAUBCTCTMV22bEdit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu BCTC |

## Đặc trưng V22b

| Đặc điểm | Mô tả |
|----------|-------|
| PS đầu kỳ | 4 loại (có công nợ) |
| PS cuối kỳ | 4 loại (có công nợ) |
| Công nợ | Hỗ trợ cả TK công nợ |
| Mục đích | Báo cáo so sánh đầu/cuối kỳ |

## Dependencies

- `Microsoft.VisualBasic` - Visual Basic runtime support
- `Framework` - Asia ERP Framework
- `Helper` - Asia ERP Helper

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLMAUBCTCTMV22b |
| Assembly Title | GLBCTC07V22b |
| Assembly Product | GLBCTC07V22b |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| GUID | 266c71a2-799f-472e-8413-01cf7007e143 |

---

*Ngày cập nhật: 2026-03-29*
