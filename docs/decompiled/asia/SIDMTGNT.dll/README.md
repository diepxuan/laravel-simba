# SIDMTGNT.dll - Danh mục tỷ giá ngoại tệ

## Tổng quan

DLL quản lý danh mục tỷ giá ngoại tệ (Foreign Exchange Rate) trong hệ thống AsiaERP.

## Thông tin kỹ thuật

| Thuộc tính | Giá trị |
|------------|---------|
| **Namespace** | `AsiaErp.UserInterface` |
| **Assembly** | `SIDMTGNT` |
| **Version** | `1.0.0.0` |
| **Company** | ASIASOFT |
| **Product** | AsiaERP |
| **Copyright** | Copyright © ASIASOFT 2010 |

## Forms chính

### 1. frmSIDMTGNT
- **Mục đích**: Form danh sách tỷ giá ngoại tệ
- **Kế thừa**: `frmAsiaRoot`
- **Chức năng**:
  - Hiển thị danh sách các loại ngoại tệ và tỷ giá
  - Tìm kiếm và lọc dữ liệu theo ngày
  - Điều hướng đến form thêm/sửa/xóa
  - Hỗ trợ cập nhật tỷ giá theo thời gian

### 2. frmSIDMTGNTEdit
- **Mục đích**: Form chi tiết chỉnh sửa tỷ giá ngoại tệ
- **Kế thừa**: `frmAsiaRoot`
- **Controls chính**:
  - `txtMa_nt`: TextBox nhập mã ngoại tệ
  - `txtTen_nt`: TextBox nhập tên ngoại tệ
  - `txtTyGia`: TextBox nhập tỷ giá
  - `txtNgay`: DateTimePicker chọn ngày áp dụng
  - `txtGhiChu`: TextBox ghi chú

## Business Logic

### Lớp DAO
- **SIDMTGNTDAO**: Data Access Object cho tỷ giá ngoại tệ
- **Interface**: `ISIDMTGNTDAO`

### Các phương thức chính
1. **GetList(DateTime fromDate, DateTime toDate)**: Lấy danh sách tỷ giá theo khoảng thời gian
2. **GetCurrentRate(string currencyCode)**: Lấy tỷ giá hiện tại của một loại tiền
3. **GetRateByDate(string currencyCode, DateTime date)**: Lấy tỷ giá theo ngày cụ thể
4. **Insert/Update/Delete**: CRUD operations

### Xử lý nghiệp vụ
- Tự động lấy tỷ giá mới nhất nếu không có tỷ giá cho ngày chỉ định
- Hỗ trợ tính toán quy đổi tiền tệ trong các chứng từ
- Lưu lịch sử thay đổi tỷ giá

## Events

| Event | Mô tả |
|-------|-------|
| `Form_Load` | Khởi tạo dữ liệu khi mở form |
| `btnAdd_Click` | Thêm mới tỷ giá |
| `btnEdit_Click` | Sửa tỷ giá đang chọn |
| `btnDelete_Click` | Xóa tỷ giá đang chọn |
| `btnSearch_Click` | Tìm kiếm theo khoảng thời gian |
| `cboCurrency_SelectedIndexChanged` | Lọc theo loại tiền |

## Dependencies

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `AsiaErp.UserInterface.Common`

## Lưu ý

- Tỷ giá ngoại tệ quan trọng cho việc hạch toán các chứng từ có liên quan đến ngoại tệ
- Hệ thống tự động lấy tỷ giá mới nhất khi nhập chứng từ
- Cần cập nhật tỷ giá thường xuyên để đảm bảo tính chính xác của số liệu kế toán
