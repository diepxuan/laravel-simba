# GLDKCTGS - Đăng ký chứng từ ghi sổ

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLDKCTGS.dll |
| Loại | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Chức năng | Đăng ký chứng từ ghi sổ (Chứng từ ghi sổ - CTGS) |

## Chức năng chính

### 1. Đăng ký chứng từ ghi sổ
- Liệt kê các loại chứng từ cần đăng ký
- Chọn kỳ báo cáo (tháng/quý/năm)
- Chọn khoảng thời gian (từ ngày - đến ngày)
- Chọn chứng từ để đăng ký

### 2. Quản lý danh sách chứng từ
- Hiển thị danh sách chứng từ theo kỳ
- Chọn/tích chọn từng chứng từ hoặc tất cả
- Hiển thị thông tin: Mã CT, TK, Tên CTGS, Số hiệu, Ngày

### 3. Thực hiện đăng ký
- Xử lý đăng ký các chứng từ đã chọn
- Cập nhật trạng thái đăng ký vào hệ thống

## Cột DataGridView (Danh sách chứng từ)

| Cột | Ý nghĩa |
|-----|---------|
| Chọn | Checkbox chọn chứng từ |
| Mã CT | Mã chứng từ |
| TK | Tài khoản |
| Tên CTGS | Tên chứng từ ghi sổ |
| Số hiệu | Số hiệu chứng từ |
| Ngày | Ngày chứng từ |

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_ct` | Mã chứng từ |
| `tk` | Tài khoản |
| `ten_ctgs` | Tên chứng từ ghi sổ |
| `so_hieu` | Số hiệu |
| `ngay` | Ngày chứng từ |
| `ky_bc` | Kỳ báo cáo |

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmGLDKCTGS` | `frmAsiaRoot` | Form đăng ký chứng từ ghi sổ |

## Dependencies

- `System.Data` - Data access
- `AsiaErp.Framework` - Asia ERP Framework
- `AsiaErp.DataAccess` - Data Access Layer

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLDKCTGS |
| Assembly Title | GLDKCTGS |
| Assembly Company | - |
| Assembly Product | GLDKCTGS |
| Assembly Copyright | Copyright © 2013 |
| Assembly Version | 1.0.0.0 |
| GUID | 35b6e3ad-f6c4-4b51-a0a9-70286c509bf8 |

---

*Ngày cập nhật: 2026-03-29*
