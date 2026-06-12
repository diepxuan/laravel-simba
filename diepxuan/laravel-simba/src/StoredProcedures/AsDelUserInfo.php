<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelUserInfo
 *
 * Stored procedure: asDelUserInfo
 * Mục đích: Xóa người dùng khỏi danh mục người dùng (sysUserInfo) và đồng thời xóa tất cả các quyền, liên kết nhóm liên quan đến người dùng đó.
 * Procedure thực hiện DELETE tuần tự từ các bảng:
 * 1. sysUserCompanyRight (quyền theo công ty)
 * 2. sysUserright (quyền tổng quát)
 * 3. sysUserGroup (liên kết người dùng - nhóm)
 * 4. sysUserInfo (danh mục người dùng)
 * 
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên đăng nhập người dùng cần xóa (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả thực thi: luôn gán 0 (thành công). Không dùng @@error.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công (luôn là 0 nếu không có lỗi runtime).
 * 
 * Logic chi tiết:
 * - DELETE FROM sysUserCompanyRight WHERE username = @pUserName
 * - DELETE FROM sysUserright WHERE username = @pUsername
 * - DELETE FROM dbo.sysUserGroup WHERE username = @pUsername
 * - DELETE FROM sysUserInfo WHERE username = @pUserName
 * - SET @pRet = 0 (luôn thành công)
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelUserInfo::call([
 *     'pUserName' => 'user001',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công (người dùng và tất cả quyền, nhóm liên quan)
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pUserName bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên cột username ở tất cả các bảng.
 * - Procedure này xóa toàn bộ dấu vết của người dùng trong hệ thống (quyền, nhóm, danh mục).
 * - Procedure luôn trả về @pRet = 0, không phản ánh lỗi SQL (nếu có lỗi runtime sẽ ném exception?).
 * - Cần đảm bảo không còn dữ liệu phụ thuộc khác (ví dụ: chứng từ, nhật ký) trước khi xóa.
 * - Việc xóa người dùng có thể ảnh hưởng đến tính toàn vẹn dữ liệu nếu có khóa ngoại không được định nghĩa.
 */
class AsDelUserInfo
{
    /**
     * Gọi stored procedure asDelUserInfo
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelUserInfo', $params);
    }
}