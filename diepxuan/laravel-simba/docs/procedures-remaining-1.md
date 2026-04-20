# Remaining Procedures (Nhóm chưa phân loại) - Part 1

## Giới thiệu

Nhóm này bao gồm các stored procedure chưa thuộc các nhóm prefix đã xác định (asAP, asAR, asGL, asSI, asIN, asPO, asHR, asFA, asCA, asSA, asCO, asGet, asDel, asPost, asRpt, asUpd, asIns, asCal, asChuyen, asFilt, asReCal, asCrt, asCopy, asCheck, asChk). Các procedure này thường là các hàm hệ thống, dashboard, công cụ, hoặc các hàm đặc thù khác.

## Danh sách procedures đã chuyển đổi

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asChangePassword | `AsChangePassword` | `@pUserName`, `@pPassword` | Thay đổi mật khẩu người dùng trong bảng sysUserInfo. |
| asDashDemoChart | `AsDashDemoChart` | `@pUserName`, `@pMa_kh`, `@pMa_bp` | Lấy top 6 người giao dịch có tổng tiền lớn nhất cho biểu đồ dashboard. |
| asDashExample | `AsDashExample` | `@pMa_cty`, `@pNam`, `@pTopSelect` | Ví dụ lấy top tài khoản có tổng phát sinh cao nhất (dynamic SQL). |
| asDashGLKetQuaKinhDoanh | `AsDashGLKetQuaKinhDoanh` | `@pMa_cty`, `@pNam` | Tính kết quả kinh doanh tạm thời (doanh thu, giá vốn, chi phí, lợi nhuận, tồn quỹ). |
| asDashGLSoSanhKH_TT | `AsDashGLSoSanhKH_TT` | `@pMa_cty`, `@pNam` | So sánh thực tế và kế hoạch ngân sách (budget) theo tài khoản. |
| asDashGetParameter | `AsDashGetParameter` | `@pSp_name` | Lấy danh sách tham số và mô tả của một stored procedure khác. |

## Chi tiết từng procedure

### asChangePassword
- **Mục đích**: Cập nhật mật khẩu mới cho người dùng.
- **Tham số**:
  - `@pUserName`: Tên đăng nhập (20 ký tự).
  - `@pPassword`: Mật khẩu mới (255 ký tự).
- **Giá trị trả về**: Không có resultset, chỉ cập nhật bảng.
- **Lưu ý**: Mật khẩu lưu plain text, cần mã hóa trước khi gọi.

### asDashDemoChart
- **Mục đích**: Cung cấp dữ liệu cho biểu đồ demo trên dashboard.
- **Tham số**:
  - `@pUserName`: Tên người dùng (không dùng trong lọc).
  - `@pMa_kh`: Mã khách hàng (tùy chọn).
  - `@pMa_bp`: Mã bộ phận (tùy chọn, chưa dùng).
- **Kết quả**: Top 6 người giao dịch với tổng tiền lớn nhất từ bảng ARPH3.
- **Lưu ý**: Không có ORDER BY, thứ tự có thể thay đổi.

### asDashExample
- **Mục đích**: Ví dụ về hàm cung cấp dữ liệu dashboard.
- **Tham số**:
  - `@pMa_cty`: Mã công ty (không dùng trong lọc).
  - `@pNam`: Năm (không dùng trong lọc).
  - `@pTopSelect`: Số dòng trả về (mặc định 5).
- **Kết quả**: Top N tài khoản có tổng phát sinh (ps_no+ps_co) cao nhất.
- **Lưu ý**: Sử dụng dynamic SQL, không lọc theo công ty/năm.

### asDashGLKetQuaKinhDoanh
- **Mục đích**: Tính toán chỉ tiêu kết quả kinh doanh tạm thời.
- **Tham số**:
  - `@pMa_cty`: Mã công ty.
  - `@pNam`: Năm (không dùng, lấy năm hiện tại).
- **Kết quả**: Bảng các chỉ tiêu Doanh thu, Giá vốn, CP bán hàng, CP QLDN, Lợi nhuận, Tồn quỹ với giá trị trong kỳ và lũy kế.
- **Lưu ý**: Sử dụng ngày hệ thống GETDATE(), tài khoản mặc định 511,632,641,642.

### asDashGLSoSanhKH_TT
- **Mục đích**: So sánh thực tế và kế hoạch ngân sách.
- **Tham số**:
  - `@pMa_cty`: Mã công ty.
  - `@pNam`: Năm (không dùng, lấy năm hiện tại).
- **Kết quả**: Tài khoản, tên, kế hoạch, thực tế, % hoàn thành.
- **Lưu ý**: Dữ liệu kế hoạch lấy từ GLBudget, thực tế từ GLCT.

### asDashGetParameter
- **Mục đích**: Lấy thông tin tham số của stored procedure khác.
- **Tham số**:
  - `@pSp_name`: Tên stored procedure cần phân tích.
- **Kết quả**: Danh sách tham số với tên, kiểu dữ liệu, độ dài, mô tả.
- **Lưu ý**: Sử dụng INFORMATION_SCHEMA, trích xuất comment từ mã nguồn.

## Hướng dẫn sử dụng

Các class đều nằm trong namespace `Diepxuan\LaravelSimba\StoredProcedures`. Gọi static method `::call()` với mảng tham số.

Ví dụ:
```php
use Diepxuan\LaravelSimba\StoredProcedures\AsDashGLKetQuaKinhDoanh;

$result = AsDashGLKetQuaKinhDoanh::call([
    'pMa_cty' => '901',
    'pNam' => 2023,
]);
```

## Tiếp theo

Cần tiếp tục chuyển đổi các procedure còn lại trong nhóm remaining, ưu tiên các procedure có tên ngắn và ít tham số.