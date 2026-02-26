<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 15:35:59
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsChangePassword.
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
     * Gọi stored procedure asChangePassword.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể là số dòng bị ảnh hưởng)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asChangePassword', [
        ], $connection);
    }
}
