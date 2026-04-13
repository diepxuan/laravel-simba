# CoPostCPTT2GL - Post chi phí tập trung sang GL

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CoPostCPTT2GL.dll |
| Assembly Title | Phân bổ công cụ dụng cụ |
| Loại | Nghiệp vụ |
| Framework | .NET Framework 3.5 |

## Mô tả

Module thực hiện **Post chi phí tập trung sang Tổng hợp (GL)** trong hệ thống ERP Asia Enterprise. Đây là bước quan trọng trong quy trình kế toán cuối kỳ để phân bổ chi phí gián tiếp vào chi phí sản xuất kinh doanh.

## Chức năng chính

1. **Post chi phí tập trung**
   - Tính toán giá trị phân bổ chi phí tập trung cho kỳ được chọn
   - Tạo các bút toán phân bổ từ TK phân bổ sang TK chi phí
   - Ghi nhận vào sổ Tổng hợp (GL)

2. **Kiểm soát kỳ**
   - Chỉ cho phép post các kỳ sau ngày khóa sổ
   - Đảm bảo tính toàn vẹn dữ liệu kế toán

3. **Tích hợp hệ thống**
   - Sử dụng Controller pattern để thực hiện nghiệp vụ
   - Tích hợp với module CO (Cost Accounting) và GL (General Ledger)

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| KyBc | Kỳ báo cáo |
| nam | Năm |
| ngay_ks | Ngày khóa sổ |
| par1 | Tham số bổ sung từ MenuInfo |

## Forms

- `frmCoPostCPTT2GL`: Form post chi phí (kế thừa frmCalc)

## UI Components

- `cboKyBc`: ComboBox chọn kỳ báo cáo (tháng)
- `txtNam`: TextBox năm báo cáo (readonly)
- `cmdOK`: Button thực hiện post
- `cmdCancel`: Button hủy bỏ

## Business Logic

### Quy trình Post

1. **Chọn kỳ**: Người dùng chọn tháng và năm cần post
2. **Validate**: Kiểm tra ngày kỳ báo cáo > ngày khóa sổ
3. **Execute**: Gọi controller thực hiện post chi phí
4. **Kết quả**: Hiển thị thông báo thành công/thất bại

### Methods

| Method | Mô tả |
|--------|-------|
| Execute() | Thực hiện post chi phí tập trung sang GL |
| ValidData() | Validate dữ liệu trước khi post |
| InitKyBaoCao() | Load danh sách kỳ báo cáo |

### Error Handling

| Mã lỗi | Mô tả |
|--------|-------|
| 50010 | Lỗi không xác định |
| 50015 | Thực hiện thành công |
| 50136 | Ngày kỳ báo cáo phải sau ngày khóa sổ |

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data
