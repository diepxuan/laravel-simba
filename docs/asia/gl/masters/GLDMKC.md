# GLDMKC - Khai báo các bút toán kết chuyển tự động

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | GLDMKC.dll |
| Loại | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Chức năng | Khai báo các bút toán kết chuyển tự động |

## Chức năng chính

### 1. Quản lý danh mục kết chuyển
- Xem danh sách các bút toán kết chuyển tự động
- Thêm, sửa, xóa bút toán kết chuyển
- Sắp xếp theo số thứ tự

### 2. Cấu hình kết chuyển
- Thiết lập các bút toán kết chuyển cuối kỳ
- Cấu hình tài khoản nguồn và đích
- Thiết lập điều kiện kết chuyển

### 3. Tham số hóa
- Nhận tham số `par1` để phân loại kết chuyển
- Lọc dữ liệu theo công ty và loại kết chuyển

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `stt` | Số thứ tự |
| `ma_cty` | Mã công ty |
| `par1` | Tham số 1 (loại kết chuyển) |

## Forms

| Form | Kế thừa | Mục đích |
|------|---------|----------|
| `frmGLDMKC` | `frmDMComplexView` | Form xem danh mục kết chuyển |
| `frmGLDMKCEdit` | - | Form nhập liệu kết chuyển |

## Dependencies

- `System.Data` - Data access
- `AsiaErp.Framework` - Asia ERP Framework

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GLDMKC |
| Assembly Title | Khai báo các bút toán kết chuyển tự động |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Version | 9.1.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |

---

*Ngày cập nhật: 2026-03-29*
