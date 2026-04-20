<?php

namespace Diepxuan\LaravelSimba\StoredProcedures;

use Diepxuan\LaravelSimba\ProcedureCaller;

/**
 * Class AsChangePassword
 *
 * Stored procedure: asChangePassword
 * Mục đích: Thay đổi mật khẩu người dùng trong hệ thống.
 * Procedure cập nhật mật khẩu của người dùng trong bảng sysUserInfo dựa trên tên đăng nhập.
 * 
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên đăng nhập của người dùng (tối đa 20 ký tự).
 * - @pPassword (string, bắt buộc): Mật khẩu mới (tối đa 255 ký tự).
 * 
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thực hiện cập nhật.
 * - Số dòng bị ảnh hưởng có thể lấy qua kết quả execute.
 * 
 * Ví dụ gọi:
 * ```php
 * $result = AsChangePassword::call([
 *     'pUserName' => 'admin',
 *     'pPassword' => 'newpassword123',
 * ]);
 * // $result chứa thông tin về số dòng bị ảnh hưởng (tùy driver).
 * ```
 * 
 * Lưu ý:
 * - Mật khẩu được lưu dưới dạng plain text (cần xem xét mã hóa trước khi lưu).
 * - Procedure không kiểm tra tính hợp lệ của mật khẩu cũ, chỉ cập nhật trực tiếp.
 * - Nên kết hợp với xác thực trước khi gọi procedure này.
 */
class AsChangePassword
{
    /**
     * Gọi stored procedure asChangePassword
     *
     * @param array $params Mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không).
     * @return mixed Kết quả trả về từ procedure (có thể là số dòng bị ảnh hưởng).
     */
    public static function call(array $params = [])
    {
        return ProcedureCaller::call('asChangePassword', $params);
    }
}