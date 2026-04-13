# COGDBGT - Giá định biên giá thành

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | COGDBGT.dll |
| Assembly Title | Sổ cái |
| Loại | Báo cáo |
| Framework | .NET Framework 3.5 |

## Mô tả

Module báo cáo **Giá định biên giá thành** trong hệ thống ERP Asia Enterprise. Đây là module theo dõi giá định biên theo tài khoản chi phí.

## Chức năng chính

1. **Báo cáo Giá định biên giá thành**
   - Theo dõi giá định biên theo tài khoản chi phí
   - Phân tích biến động giá thành theo thời gian
   - Đối chiếu giá định biên với giá thực tế

2. **Tham số báo cáo**
   - Chọn tài khoản chi phí cần phân tích
   - Lọc theo khoảng thời gian (tháng/năm)
   - Xuất báo cáo theo định dạng chuẩn

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| tk | Tài khoản kế toán |
| nam | Năm báo cáo |
| thang1 | Tháng bắt đầu |
| thang2 | Tháng kết thúc |
| ten_tk | Tên tài khoản |

## Forms

- `frmCOGDBGT`: Form báo cáo Giá định biên (kế thừa frmReport)

## UI Components

- `txtTk`: Mã tài khoản
- `lblTen_Tk`: Tên tài khoản
- `txtNam`: Năm báo cáo
- `txtThang1`: Tháng bắt đầu
- `txtThang2`: Tháng kết thúc

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data
