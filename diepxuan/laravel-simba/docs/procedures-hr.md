# Human Resources (asHR*) Stored Procedures

Danh sách các stored procedure thuộc nhóm Human Resources (asHR*) đã được chuyển đổi sang class PHP.

Tổng số procedures trong nhóm: 172 (ước lượng).  
Số procedures đã chuyển đổi: 10 (tính đến 2026-02-11).

## Bảng liệt kê

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| `asHrDelChamCong` | `AsHrDelChamCong` | `@pMa_cty` (string), `@pNam` (int), `@pThang` (int), `@pId` (string), `@pRet` (int, output) | Xóa dữ liệu chấm công nhân viên theo mã công ty, năm, tháng và ID. |
| `asHrDelChamCongKhac` | `AsHrDelChamCongKhac` | `@pMa_cty` (string), `@pNam` (int), `@pThang` (int), `@pNgay` (int), `@pId` (string), `@pRet` (int, output) | Xóa dữ liệu chấm công khác (ngoài giờ) của nhân viên. |
| `asHrGetChamCong` | `AsHrGetChamCong` | `@pMa_cty` (string, default '001'), `@pNam` (int, default 2014), `@pThang` (int, default 7), `@pId` (string, default '') | Lấy dữ liệu chấm công nhân viên theo điều kiện. |
| `asHrDelDTHocVien` | `AsHrDelDTHocVien` | `@pMa_cty` (string), `@pMa_kdt` (string), `@pMa_ldt` (string), `@pId` (string), `@pRet` (int, output) | Xóa nhân viên tham gia lớp đào tạo (học viên). |
| `asHrGetChamCongKhac` | `AsHrGetChamCongKhac` | `@pMa_cty` (string, default '001'), `@pNam` (int, default 2014), `@pThang` (int, default 7), `@pNgay` (int, default 2), `@pId` (string, default '') | Lấy dữ liệu chấm công khác (ngoài giờ) của nhân viên. |
| `asHrGetDTHocVien` | `AsHrGetDTHocVien` | `@pMa_cty` (string, default '001'), `@pMa_kdt` (string, default ''), `@pMa_ldt` (string, default ''), `@pId` (string, default '') | Lấy danh sách nhân viên tham gia lớp đào tạo (học viên). |
| `asHrDelDTKhoa` | `AsHrDelDTKhoa` | `@pMa_cty` (string), `@pMa_kdt` (string), `@pRet` (int, output) | Xóa khóa đào tạo. |
| `asHrGetDTKhoa` | `AsHrGetDTKhoa` | `@pMa_cty` (string, default '001'), `@pMa_kdt` (string, default '') | Lấy danh sách khóa đào tạo theo mã công ty và mã khóa đào tạo (prefix). |
| `asHrDelDTLop` | `AsHrDelDTLop` | `@pMa_cty` (string), `@pMa_kdt` (string), `@pMa_ldt` (string), `@pRet` (int, output) | Xóa lớp đào tạo. |
| `asHrGetDTLop` | `AsHrGetDTLop` | `@pMa_cty` (string, default '001'), `@pMa_kdt` (string, default ''), `@pMa_ldt` (string, default '') | Lấy danh sách lớp đào tạo theo mã công ty, mã khóa đào tạo và mã lớp đào tạo (prefix). |

## Chi tiết từng procedure

### asHrDelChamCong
- **Mục đích**: Xóa dữ liệu chấm công nhân viên theo mã công ty, năm, tháng và ID nhân viên.
- **Tham số**:
  - `pMa_cty`: Mã công ty (NVARCHAR(3)), bắt buộc.
  - `pNam`: Năm chấm công (INT), bắt buộc.
  - `pThang`: Tháng chấm công (INT), bắt buộc.
  - `pId`: ID nhân viên (NVARCHAR(20)), bắt buộc.
  - `pRet`: Output parameter trả về mã lỗi (0 thành công, khác 0 lỗi).
- **Ví dụ**:
```php
$result = AsHrDelChamCong::call([
    'pMa_cty' => '001',
    'pNam' => 2025,
    'pThang' => 2,
    'pId' => 'NV001',
]);
```

### asHrDelChamCongKhac
- **Mục đích**: Xóa dữ liệu chấm công khác (ngoài giờ) của nhân viên.
- **Tham số**: Tương tự `asHrDelChamCong` nhưng có thêm `pNgay`.
- **Ví dụ**: (xem class tương ứng).

### asHrGetChamCong
- **Mục đích**: Lấy dữ liệu chấm công nhân viên theo điều kiện.
- **Tham số**: Có giá trị mặc định, tìm kiếm theo prefix của ID.
- **Ví dụ**: (xem class tương ứng).

### asHrDelDTHocVien
- **Mục đích**: Xóa nhân viên tham gia lớp đào tạo (học viên).
- **Tham số**: Mã công ty, mã khóa đào tạo, mã lớp đào tạo, ID nhân viên (prefix).
- **Ví dụ**: (xem class tương ứng).

### asHrGetChamCongKhac
- **Mục đích**: Lấy dữ liệu chấm công khác (ngoài giờ) của nhân viên.
- **Tham số**: Có giá trị mặc định, tìm kiếm theo prefix của ID.
- **Ví dụ**: (xem class tương ứng).

### asHrGetDTHocVien
- **Mục đích**: Lấy danh sách nhân viên tham gia lớp đào tạo (học viên).
- **Tham số**: Mã công ty, mã khóa đào tạo, mã lớp đào tạo, ID nhân viên (prefix).
- **Ví dụ**: (xem class tương ứng).

### asHrDelDTKhoa
- **Mục đích**: Xóa khóa đào tạo.
- **Tham số**: Mã công ty, mã khóa đào tạo.
- **Ví dụ**: (xem class tương ứng).

### asHrGetDTKhoa
- **Mục đích**: Lấy danh sách khóa đào tạo theo mã công ty và mã khóa đào tạo (prefix).
- **Tham số**: Mã công ty, mã khóa đào tạo (có thể rỗng).
- **Ví dụ**: (xem class tương ứng).

### asHrDelDTLop
- **Mục đích**: Xóa lớp đào tạo.
- **Tham số**: Mã công ty, mã khóa đào tạo, mã lớp đào tạo.
- **Ví dụ**: (xem class tương ứng).

### asHrGetDTLop
- **Mục đích**: Lấy danh sách lớp đào tạo theo mã công ty, mã khóa đào tạo và mã lớp đào tạo (prefix).
- **Tham số**: Mã công ty, mã khóa đào tạo, mã lớp đào tạo (có thể rỗng).
- **Ví dụ**: (xem class tương ứng).

## Hướng dẫn sử dụng
Tất cả các class đều nằm trong namespace `Diepxuan\LaravelSimba\StoredProcedures` và cung cấp phương thức tĩnh `call()`.

```php
use Diepxuan\LaravelSimba\StoredProcedures\AsHrGetChamCong;

$data = AsHrGetChamCong::call(['pMa_cty' => '001', 'pNam' => 2025]);
```

## Tiến độ chuyển đổi
- Cập nhật lần cuối: 2026-02-11
- Số lượng còn lại: 162 procedures.

## Ghi chú
- Các procedure có output parameter `@pRet` trả về mã lỗi SQL (`@@ERROR`). Giá trị 0 thành công.
- Các procedure `Get` trả về resultset dạng collection hoặc array tùy cấu hình.
- Đối với các procedure có tham số tìm kiếm prefix (`LIKE @pId + '%'`), có thể truyền chuỗi rỗng để lấy tất cả.