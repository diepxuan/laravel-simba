# CoNgungKHCPTT - Ngừng phân bổ chi phí tập trung

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| DLL | CoNgungKHCPTT.dll |
| Assembly Title | FADMCC |
| Loại | Danh mục |
| Framework | .NET Framework 3.5 |

## Mô tả

Module quản lý **Ngừng phân bổ chi phí trực tiếp** trong hệ thống ERP Asia Enterprise. Đây là module đánh dấu thời điểm ngừng phân bổ khấu hao cho các chi phí tập trung.

## Chức năng chính

1. **Quản lý ngừng phân bổ chi phí**
   - Xem danh sách các chi phí trực tiếp đã ngừng phân bổ
   - Thêm mới thông tin ngừng phân bổ cho chi phí
   - Sửa thông tin ngừng phân bổ (tháng ngừng, phân bổ nốt số dư)
   - Xóa thông tin ngừng phân bổ

2. **Thông tin quản lý**
   - **Mã chi phí**: Lookup từ danh mục chi phí trực tiếp
   - **Tên chi phí**: Hiển thị tự động từ lookup
   - **Nguyên giá**: Read-only, lấy từ danh mục
   - **Ngày bắt đầu phân bổ**: Read-only, lấy từ danh mục
   - **Tháng ngừng phân bổ**: Chọn tháng/năm (MM/yyyy)
   - **Phân bổ nốt số dư**: Option để phân bổ hết số dư vào tháng cuối

3. **Validation và Business Logic**
   - Kiểm tra mã chi phí không được để trống
   - Kiểm tra ngày tháng ngừng phân bổ hợp lệ
   - Lookup tự động thông tin chi phí khi nhập mã
   - Format ngày tháng theo định dạng MM/yyyy

## Các trường dữ liệu

| Field | Mô tả |
|-------|---------|
| ma_cptt | Mã chi phí trực tiếp |
| ten_cptt | Tên chi phí trực tiếp |
| ng_gia | Nguyên giá |
| ngay_bdkh | Ngày bắt đầu khấu hao/phân bổ |
| ngay_tkh | Ngày tháng ngừng khấu hao |
| kh_so_du | Khấu hao số dư (phân bổ nốt) |

## Forms

- `frmCoNgungKhCPTT`: Form danh sách (kế thừa frmDMComplexView)
- `frmCoNgungKhCPTTEdit`: Form chỉnh sửa (kế thừa frmDMComplexEdit)

## Data Access Layer

### Stored Procedures

| Stored Procedure | Mô tả |
|------------------|-------|
| asCoUpdNgungKH_CPTT | Thêm mới hoặc cập nhật thông tin ngừng phân bổ |
| asCoDelNgungKH_CPTT | Xóa thông tin ngừng phân bổ |

### Parameters cho asCoUpdNgungKH_CPTT

| Parameter | Mô tả |
|-----------|-------|
| @pMa_cty | Mã công ty |
| @pMa_cptt | Mã chi phí |
| @pNgay_tkh | Ngày tháng ngừng phân bổ |
| @pKh_so_du | Có phân bổ nốt số dư không |
| @pIsUpd | Flag insert (false) hay update (true) |
| @pRet | Output parameter (return code) |

## Dependencies

- Framework.dll
- Helper.dll
- Microsoft.VisualBasic
- System.Data
- System.Xml.Linq
- System.Core
