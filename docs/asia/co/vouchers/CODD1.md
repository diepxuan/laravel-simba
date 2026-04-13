# CODD1 - Định mức chi tiết

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CODD1.dll |
| Assembly Title | Khai báo các bút toán kết chuyển tự động |
| Loại | Danh mục |
| Framework | .NET Framework 3.5 |

## Mô tả

Module quản lý **Định mức chi tiết** trong hệ thống ERP Asia Enterprise. Đây là module khai báo định mức chi phí theo sản phẩm chi tiết (SPCT).

## Chức năng chính

1. **Quản lý định mức chi tiết**
   - Khai báo định mức chi phí theo sản phẩm chi tiết (SPCT)
   - Gán tài khoản kế toán cho từng định mức
   - Quản lý số lượng và giá trị định mức

2. **Phân loại theo thời gian**
   - Lọc dữ liệu theo năm tài chính
   - Lọc theo tháng (1-12)
   - Kiểm tra tính hợp lệ của dữ liệu với ngày khóa sổ

3. **Tích hợp với module khác**
   - Liên kết với danh mục sản phẩm chi tiết (MA_SPCT)
   - Liên kết với hệ thống tài khoản kế toán
   - Hỗ trợ AutoLookup cho mã SPCT và TK

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| ma_spct | Mã sản phẩm chi tiết |
| tk | Tài khoản kế toán |
| so_luong | Số lượng định mức |
| tien | Giá trị/Chi phí định mức |
| nam | Năm tài chính |
| thang | Tháng áp dụng |

## Forms

- `frmCoDD1`: Form danh mục chính (kế thừa frmDMComplexView)
- `frmCoDD1Edit`: Form nhập liệu chỉnh sửa (kế thừa frmDMComplexEdit)
- `frmCoDD1Filter`: Form lọc dữ liệu (kế thừa frmDMComplexFilter)

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data
