<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsChkUserLogin
 *
 * Stored procedure: asChkUserLogin
 * Mục đích: Kiểm tra thông tin đăng nhập của người dùng và trả về các quyền liên quan.
 * Procedure kiểm tra username và password có khớp trong bảng sysUSERINFO không (và tài khoản không bị disabled).
 * Nếu đúng, trả về các cờ quyền: IsAdmin (quyền quản trị), IsGrand (quyền ủy quyền), và Ok (xác thực thành công).
 * 
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên đăng nhập của người dùng (nvarchar(20)).
 *   Không có giá trị mặc định.
 * - @pPassword (string, bắt buộc): Mật khẩu người dùng (nvarchar(255)).
 *   Không có giá trị mặc định.
 * - @pIsGrand (int, output): Tham số đầu ra, cho biết người dùng có quyền "Grand" (ủy quyền) hay không.
 *   Giá trị trả về: 
 *     - 0: không có quyền Grand.
 *     - >0: có quyền Grand (thường là 1).
 * - @pIsAdmin (int, output): Tham số đầu ra, cho biết người dùng có quyền quản trị (admin) hay không.
 *   Giá trị trả về:
 *     - 0: không phải admin.
 *     - >0: là admin (thường là 1).
 * - @pOk (int, output): Tham số đầu ra, cho biết việc xác thực có thành công không.
 *   Giá trị trả về:
 *     - 0: username/password không khớp hoặc tài khoản bị disabled.
 *     - >0: xác thực thành công (thường là 1).
 * - @pMa_cty (string, tùy chọn): Mã công ty (nvarchar(3)).
 *   Giá trị mặc định: '' (chuỗi rỗng). Hiện tại không được sử dụng trong logic chính (phần kiểm tra quyền công ty bị comment).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ trả về giá trị qua các tham số output @pOk, @pIsAdmin, @pIsGrand.
 * - Để lấy giá trị output parameters, cần sử dụng phương thức hỗ trợ output (DB::statement với binding OUTPUT).
 * 
 * Logic chi tiết:
 * 1. Kiểm tra username và password:
 *    - Đếm số bản ghi trong sysUSERINFO thỏa: USERNAME = @pUserName, PASSWORD = @pPassword, disabled = '0'.
 *    - Gán kết quả cho @pOk.
 * 2. Nếu @pOk = 0 (không có người dùng hợp lệ), procedure RETURN ngay (không tính các quyền).
 * 3. Lấy quyền admin:
 *    - Tính tổng (SUM) của cột ISADMIN (chuyển thành int) của người dùng khớp.
 *    - Gán cho @pIsAdmin (thường là 0 hoặc 1).
 * 4. Lấy quyền Grand:
 *    - Tính tổng (SUM) của cột GRAND (chuyển thành int) của người dùng khớp.
 *    - Gán cho @pIsGrand (thường là 0 hoặc 1).
 * 5. Phần kiểm tra quyền của người dùng trên công ty và nhóm trên công ty hiện đang bị comment (không thực thi).
 * 
 * Kết quả cuối cùng:
 * - @pOk = 1: đăng nhập thành công.
 * - @pIsAdmin = 1: người dùng có quyền admin.
 * - @pIsGrand = 1: người dùng có quyền ủy quyền (grant).
 * 
 * Ví dụ gọi (sử dụng DB facade trực tiếp):
 * ```php
 * $pOk = 0;
 * $pIsAdmin = 0;
 * $pIsGrand = 0;
 * DB::statement('EXEC dbo.asChkUserLogin @pUserName = ?, @pPassword = ?, @pIsGrand = ? OUTPUT, @pIsAdmin = ? OUTPUT, @pOk = ? OUTPUT, @pMa_cty = ?',
 *     ['admin', 'password123', $pIsGrand, $pIsAdmin, $pOk, '001']);
 * // Sau khi gọi, các biến $pOk, $pIsAdmin, $pIsGrand sẽ chứa giá trị output.
 * 
 * if ($pOk > 0) {
 *     echo "Đăng nhập thành công.";
 *     if ($pIsAdmin > 0) echo " Người dùng là admin.";
 *     if ($pIsGrand > 0) echo " Người dùng có quyền Grand.";
 * } else {
 *     echo "Sai tên đăng nhập hoặc mật khẩu.";
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pUserName và @pPassword bắt buộc, không có giá trị mặc định.
 * - Tham số @pMa_cty tùy chọn, hiện không ảnh hưởng đến kết quả (phần kiểm tra quyền công ty bị comment).
 * - Mật khẩu được lưu dưới dạng plain text? (nvarchar(255)). Có thể đã được mã hóa ở tầng ứng dụng.
 * - Tài khoản bị disabled (disabled = '1') sẽ không được phép đăng nhập.
 * - Procedure trả về nhiều output parameters, cần xử lý đặc biệt do ProcedureCaller hiện tại chưa hỗ trợ output parameters.
 * - Quyền Grand có thể cho phép người dùng ủy quyền (grant) quyền của mình cho người khác.
 * - Quyền Admin có thể cho phép truy cập tất cả chức năng quản trị.
 */
class AsChkUserLogin
{
    /**
     * Gọi stored procedure asChkUserLogin
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     *   Đối với các output parameters (@pIsGrand, @pIsAdmin, @pOk), truyền giá trị null (sẽ không nhận được giá trị trả về).
     * @return mixed Kết quả trả về từ procedure (thường là null hoặc mảng rỗng do output parameters).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asChkUserLogin', $params);
    }
}