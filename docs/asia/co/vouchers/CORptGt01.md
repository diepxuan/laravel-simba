# CORptGt01 - Báo cáo giá thành 01

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CORptGt01.dll |
| Assembly Title | Sổ cái |
| Loại | Báo cáo |
| Framework | .NET Framework 3.5 |

## Mô tả

Module báo cáo **Giá thành 01** trong hệ thống ERP Asia Enterprise. Đây là báo cáo tổng hợp chi phí giá thành với tùy chọn xem chi tiết vật tư.

## Chức năng chính

1. **Báo cáo Giá thành 01**
   - Báo cáo tổng hợp chi phí giá thành
   - Phân tích chi phí theo tài khoản
   - Theo dõi chi phí theo sản phẩm chi tiết

2. **Tham số báo cáo**
   - Chọn tài khoản chi phí
   - Chọn sản phẩm chi tiết (SPCT)
   - Lọc theo khoảng thời gian (tháng/năm)
   - Tùy chọn xem chi tiết vật tư

3. **Tích hợp module giá thành**
   - Cung cấp dữ liệu cho phân tích giá thành
   - Liên kết với định mức BOM
   - Hỗ trợ đánh giá hiệu quả sản xuất

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| tk | Tài khoản kế toán |
| nam | Năm báo cáo |
| thang1 | Tháng bắt đầu |
| thang2 | Tháng kết thúc |
| ma_spct | Mã sản phẩm chi tiết |
| ct_vt | Chi tiết vật tư |
| ten_tk | Tên tài khoản |

## Forms

- `frmCORptGt01`: Form báo cáo Giá thành 01 (kế thừa frmReport)

## UI Components

- `txtTk`: Mã tài khoản
- `txtMA_SPCT`: Mã sản phẩm chi tiết
- `chkCt_vt`: CheckBox chi tiết vật tư
- `txtNam`: Năm báo cáo
- `txtThang1`, `txtThang2`: Tháng bắt đầu/kết thúc

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data
