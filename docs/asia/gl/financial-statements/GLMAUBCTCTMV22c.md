# GLMAUBCTCTMV22c - Mẫu báo cáo tài chính V22c

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLMAUBCTCTMV22c.dll |
| Loại | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Chức năng | Quản lý mẫu báo cáo tài chính V22c |

## Chức năng chính

### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu (ma_so)
- Nhập tên chỉ tiêu và nội dung chi tiết
- Thiết lập công thức tính toán

### 2. Liên kết tài khoản kế toán
- Gán một tài khoản
- Hỗ trợ lookup tài khoản từ danh mục TK

### 3. Phân loại phát sinh
- Chọn loại phát sinh: Dư nợ/có đầu kỳ, Dư nợ/có cuối kỳ, Phát sinh nợ/có

### 4. Định dạng in ấn
- Tùy chọn in đậm, in nghiêng
- Có in hay không

## Loại phát sinh (LoaiPS)

| Mã | Ý nghĩa |
|----|---------|
| NODK | Dư nợ đầu kỳ |
| CODK | Dư có đầu kỳ |
| NOCK | Dư nợ cuối kỳ |
| COCK | Dư có cuối kỳ |
| PSNO | Phát sinh nợ |
| PSCo | Phát sinh có |

## Thuật ngữ kế toán

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

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmGLMAUBCTCTMV22c` | `frmDMComplexView` | Form xem danh mục mẫu BCTC V22c |
| `frmGLMAUBCTCTMV22cEdit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu BCTC |

## So sánh các phiên bản V22

| Đặc điểm | V22A | V22b | V22c |
|----------|------|------|------|
| Số TK | 12 TK | 1 TK | 1 TK |
| Loại PS | 1 combo | 2 combo (DK/CK) | 1 combo |
| Năm PS | Có | Không | Không |
| Công nợ | Không | Có | Không |

## Dependencies

- `Microsoft.VisualBasic` - Visual Basic runtime support
- `Framework` - Asia ERP Framework
- `Helper` - Asia ERP Helper

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLMAUBCTCTMV22c |
| Assembly Title | GLBCTC07V22c |
| Assembly Product | GLBCTC07V22c |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| GUID | a2b24e06-0f51-43c3-b68d-1830bf1c7689 |

---

*Ngày cập nhật: 2026-03-29*
