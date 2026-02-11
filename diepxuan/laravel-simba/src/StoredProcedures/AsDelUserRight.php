<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelUserRight
 *
 * Stored procedure: asDelUserRight
 * Mục đích: Xóa một quyền cụ thể của người dùng từ bảng sysUserRight dựa trên tên đăng nhập và mã menu.
 * Procedure thực hiện DELETE từ bảng sysUserRight với điều kiện khớp username và menuid.
 * 
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên đăng nhập người dùng (NVARCHAR(20)).
 * - @pMenuID (string, bắt buộc): Mã menu/chức năng (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả thực thi: 0 nếu thành công, giá trị lỗi SQL Server nếu có lỗi (@@ERROR).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công.
 * 
 * Logic chi tiết:
 * - DELETE FROM sysUserRight WHERE username = @pUserName AND menuid = @pMenuID
 * - SET @pRet = @@Error
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelUserRight::call([
 *     'pUserName' => 'user001',
 *     'pMenuID' => 'MN001',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công
 * } else {
 *     // Xóa thất bại, có lỗi SQL
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pUserName và @pMenuID bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên hai cột username và menuid.
 * - Bảng sysUserRight lưu quyền chi tiết của từng người dùng trên các menu/chức năng.
 * - Giá trị @pRet được gán bằng @@error, nếu có lỗi sẽ khác 0.
 * - Procedure này xóa trực tiếp, cần đảm bảo quyền và ràng buộc khóa ngoại.
 */
class AsDelUserRight
{
    /**
     * Gọi stored procedure asDelUserRight
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelUserRight', $params);
    }
}