# CODMNHSPCT - Danh mục nhóm sản phẩm công trình

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CODMNHSPCT.dll |
| Assembly Title | Danh mục nhóm sản phẩm công trình |
| Loại | Danh mục |
| Framework | .NET Framework 3.5 |

## Mô tả

Module quản lý **Danh mục nhóm sản phẩm công trình** trong hệ thống ERP Asia Enterprise. Đây là module phân loại sản phẩm công trình theo nhóm.

## Chức năng chính

1. **Phân loại sản phẩm công trình**
   - Tạo các nhóm phân loại cho sản phẩm công trình
   - Quản lý cấp độ phân nhóm (cấp 1, cấp 2...)
   - Sắp xếp theo số thứ tự nhóm

2. **Tích hợp với module khác**
   - Liên kết với danh mục sản phẩm chi tiết (CODMSPCT)
   - Hỗ trợ phân loại trong báo cáo giá thành
   - Phục vụ cho việc tổng hợp chi phí theo nhóm

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| cap | Cấp độ nhóm |
| stt_nhom | Số thứ tự nhóm |

## Forms

- `frmCODMNHSPCT`: Form danh mục nhóm SPCT (kế thừa frmDMView)
- `frmCODMNHSPCTEdit`: Form chỉnh sửa nhóm SPCT

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data
