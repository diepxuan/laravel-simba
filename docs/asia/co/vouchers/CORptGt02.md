# CORptGt02 - Báo cáo giá thành 02

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CORptGt02.dll |
| Assembly Title | Sổ cái |
| Loại | Báo cáo |
| Framework | .NET Framework 3.5 |

## Mô tả

Module báo cáo **Giá thành 02** trong hệ thống ERP Asia Enterprise. Đây là báo cáo phân tích giá thành theo SPCT với hiển thị tên SPCT đầy đủ.

## Chức năng chính

1. **Báo cáo Giá thành 02**
   - Báo cáo phân tích giá thành theo SPCT
   - Tổng hợp chi phí theo tài khoản và sản phẩm
   - Đánh giá giá thành thực tế

2. **Tham số báo cáo**
   - Chọn tài khoản chi phí
   - Chọn sản phẩm chi tiết (SPCT)
   - Lọc theo khoảng thời gian (tháng/năm)
   - Hiển thị tên SPCT đầy đủ

3. **Tích hợp module giá thành**
   - Cung cấp dữ liệu cho phân tích giá thành
   - Liên kết với danh mục SPCT (CODMSPCT)
   - Hỗ trợ đánh giá hiệu quả sản xuất

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| tk | Tài khoản kế toán |
| nam | Năm báo cáo |
| thang1 | Tháng bắt đầu |
| thang2 | Tháng kết thúc |
| ma_spct | Mã sản phẩm chi tiết |
| ten_spct | Tên sản phẩm chi tiết |
| ten_tk | Tên tài khoản |

## Forms

- `frmCORptGt02`: Form báo cáo Giá thành 02 (kế thừa frmReport)

## UI Components

- `txtTk`: Mã tài khoản
- `txtMA_SPCT`: Mã sản phẩm chi tiết
- `lblTen_SPCT`: Tên sản phẩm chi tiết
- `txtNam`: Năm báo cáo
- `txtThang1`, `txtThang2`: Tháng bắt đầu/kết thúc

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data
