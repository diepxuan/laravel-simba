<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsDelUserGroup
 *
 * Stored procedure: asDelUserGroup
 * Mục đích: Xóa liên kết người dùng - nhóm (user group membership) từ bảng sysUsergroup dựa trên tên đăng nhập.
 * Procedure thực hiện DELETE từ bảng sysUsergroup với điều kiện khớp username.
 * 
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên đăng nhập người dùng (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả thực thi: luôn gán 0 (thành công). Không dùng @@error.
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra thành công (luôn là 0 nếu không có lỗi runtime).
 * 
 * Logic chi tiết:
 * - DELETE FROM sysUsergroup WHERE username = @pUserName
 * - SET @pRet = 0 (luôn thành công)
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsDelUserGroup::call([
 *     'pUserName' => 'user001',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Xóa thành công (hoặc không có bản ghi nào bị xóa)
 * }
 * ```
 * 
 * Lưu ý:
 * - Tham số @pUserName bắt buộc, không có giá trị mặc định.
 * - Điều kiện xóa khớp chính xác trên cột username.
 * - Bảng sysUsergroup lưu danh sách người dùng thuộc các nhóm (quan hệ nhiều-nhiều giữa user và group).
 * - Procedure luôn trả về @pRet = 0, không phản ánh lỗi SQL (nếu có lỗi runtime sẽ ném exception?).
 * - Xóa liên kết user-group không xóa chính người dùng hay nhóm.
 * - Cần đảm bảo tính nhất quán phân quyền sau khi xóa.
 */
class AsDelUserGroup
{
    /**
     * Gọi stored procedure asDelUserGroup
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể chứa output parameter).
     */
    public static function call(array $params = [])
    {
        // Tham số output @pRet sẽ được tự động xử lý bởi ProcedureCaller nếu được định nghĩa.
        return ProcedureCaller::call('asDelUserGroup', $params);
    }
}