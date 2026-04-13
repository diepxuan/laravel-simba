# CoDelPostCP2GL - Xóa post chi phí sang GL

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CoDelPostCP2GL.dll |
| Assembly Title | Phân bổ công cụ dụng cụ |
| Loại | Nghiệp vụ |
| Framework | .NET Framework 3.5 |

## Mô tả

Module **Xóa post chi phí sang GL (General Ledger)** trong hệ thống ERP Asia Enterprise. Đây là module dùng để xóa bỏ các bút toán post chi phí đã được chuyển sang sổ cái.

## Chức năng chính

1. **Xóa post chi phí sang sổ cái (GL)**
   - Xóa bỏ các bút toán post chi phí đã được chuyển sang sổ cái
   - Thường dùng khi cần tính toán lại hoặc có sai sót trong việc post chi phí

2. **Kiểm soát kỳ**
   - Chọn tháng và năm cần xóa post
   - Kiểm tra ngày khóa sổ để đảm bảo an toàn dữ liệu

3. **Tích hợp với module phân bổ công cụ dụng cụ**
   - Liên quan đến việc phân bổ công cụ dụng cụ (CCDC)
   - Xóa post chi phí khi cần tính toán lại phân bổ CCDC

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| KyBc | Kỳ báo cáo |
| nam | Năm |
| ngay_ks | Ngày khóa sổ |
| par1 | Tham số 1 từ menu |

## Forms

- `frmCoDelPostCP2GL`: Form xóa post chi phí (kế thừa frmCalc)

## UI Components

- `cboKyBc`: ComboBox chọn kỳ báo cáo (Tháng)
- `txtNam`: TextBox nhập năm
- `cmdOK`: Nút OK thực hiện xóa post
- `cmdCancel`: Nút Cancel hủy

## Business Logic

### Methods

| Phương thức | Mô tả |
|-------------|-------|
| Execute() | Thực hiện xóa post chi phí sang GL |
| ValidData() | Kiểm tra dữ liệu hợp lệ |
| InitKyBaoCao() | Khởi tạo danh sách kỳ báo cáo |

### Xử lý chính

1. **Kiểm tra ngày khóa sổ**: Đảm bảo kỳ xóa post sau ngày khóa sổ
2. **Gọi stored procedure**: Thực hiện xóa post chi phí sang GL
3. **Truyền tham số**: CompanyID, par1, Năm, Tháng

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
