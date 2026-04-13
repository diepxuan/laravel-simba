# COLK - Liên kết

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | COLK.dll |
| Assembly Title | Khai báo các bút toán kết chuyển tự động |
| Loại | Danh mục |
| Framework | .NET Framework 3.5 |

## Mô tả

Module quản lý **Liên kết** trong hệ thống ERP Asia Enterprise. Đây là module khai báo các liên kết dữ liệu hỗ trợ cho bút toán kết chuyển tự động.

## Chức năng chính

1. **Khai báo liên kết dữ liệu**
   - Thiết lập các liên kết giữa các danh mục
   - Cấu hình mapping cho bút toán kết chuyển
   - Quản lý quan hệ giữa các đối tượng kế toán

2. **Tích hợp kết chuyển**
   - Hỗ trợ bút toán kết chuyển tự động
   - Liên kết dữ liệu giữa các module
   - Cung cấp dữ liệu cho quá trình kết chuyển cuối kỳ

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| lk | Liên kết |
| nam | Năm tài chính |

## Forms

- `frmCoLk`: Form danh mục liên kết (kế thừa frmDMComplexView)
- `frmCoLkEdit`: Form chỉnh sửa liên kết
- `frmCOLKFilter`: Form lọc dữ liệu

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
