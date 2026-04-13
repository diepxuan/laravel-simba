# CODMSPCT - Danh mục sản phẩm công trình

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CODMSPCT.dll |
| Assembly Title | Danh mục công trình |
| Loại | Danh mục |
| Framework | .NET Framework 3.5 |

## Mô tả

Module quản lý **Danh mục sản phẩm công trình** trong hệ thống ERP Asia Enterprise. Đây là module khai báo các sản phẩm/công trình là đối tượng tính giá thành chính.

## Chức năng chính

1. **Quản lý sản phẩm công trình**
   - Khai báo danh mục các sản phẩm/công trình
   - Phân loại theo nhóm (liên kết CODMNHSPCT)
   - Quản lý thông tin cơ bản của sản phẩm

2. **Chế độ xem linh hoạt**
   - Chế độ quản lý đầy đủ (thêm/sửa/xóa)
   - Chế độ chỉ xem (par1 = "1") - dùng cho báo cáo/lookup
   - Hỗ trợ phím tắt cho tra cứu nhanh

3. **Tích hợp module giá thành**
   - Cung cấp dữ liệu cho tính giá thành
   - Liên kết với định mức BOM (CODMBOM)
   - Hỗ trợ phân bổ chi phí theo SPCT

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| ma_spct | Mã sản phẩm chi tiết |
| ten_spct | Tên sản phẩm chi tiết |
| par1 | Tham số 1 ("1" = chế độ chỉ xem) |
| menuid | Mã menu (16.90.02) |

## Forms

- `frmCODMSPCT`: Form danh mục SPCT (kế thừa frmDMView)

## Dependencies

- Framework.dll
- Microsoft.VisualBasic
- System.Data
