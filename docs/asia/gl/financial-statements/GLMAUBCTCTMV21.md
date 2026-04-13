# GLMAUBCTCTMV21 - Mẫu báo cáo tài chính V21

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLMAUBCTCTMV21.dll |
| Loại | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Chức năng | Quản lý mẫu báo cáo tài chính V21 |

## Chức năng chính

### 1. Quản lý chỉ tiêu báo cáo tài chính
- Định nghĩa mã chỉ tiêu (ma_so)
- Nhập tên chỉ tiêu và nội dung chi tiết
- Thiết lập công thức tính toán

### 2. Liên kết tài khoản kế toán
- Gán một tài khoản duy nhất (đơn giản hơn V20C)
- Hỗ trợ lookup tài khoản từ danh mục TK

### 3. Định dạng in ấn
- Tùy chọn in đậm, in nghiêng
- Có in hay không
- Mẫu quyết định (Qd_cdkt)

## Thuật ngữ kế toán

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

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmGLMAUBCTCTMV21` | `frmDMComplexView` | Form xem danh mục mẫu BCTC V21 |
| `frmGLMAUBCTCTMV21Edit` | `frmDMComplexEdit` | Form chỉnh sửa chỉ tiêu BCTC |

## So sánh với V20C

| Đặc điểm | V20C | V21 |
|----------|------|-----|
| Số TK | 2 TK (tk_01, tk_02) | 1 TK |
| Loại PS | Có combo | Không có |
| Độ phức tạp | Cao | Đơn giản |

## Dependencies

- `Microsoft.VisualBasic` - Visual Basic runtime support
- `Framework` - Asia ERP Framework
- `Helper` - Asia ERP Helper

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLMAUBCTCTMV21 |
| Assembly Title | GLBCTC07V21 |
| Assembly Product | GLBCTC07V21 |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| GUID | ca85ec56-3c3a-4c21-af73-ae1efd352415 |

---

*Ngày cập nhật: 2026-03-29*
