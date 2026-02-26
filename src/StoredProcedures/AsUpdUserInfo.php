<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 06:55:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsUpdUserInfo.
 *
 * Stored procedure: asUpdUserInfo
 * Mục đích: Cập nhật thông tin người dùng trong hệ thống.
 * Procedure cập nhật thông tin cơ bản của người dùng (tên đầy đủ, quyền admin, quyền grand, trạng thái vô hiệu hóa) và xóa nhóm người dùng nếu là admin.
 *
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên đăng nhập của người dùng (NVARCHAR(20)).
 * - @pFullName (string, bắt buộc): Tên đầy đủ của người dùng (NVARCHAR(50)).
 * - @pIsAdmin (bool, bắt buộc): Cờ chỉ định người dùng có quyền admin (BIT). Giá trị 1 = admin, 0 = không phải admin.
 * - @pGrand (bool, bắt buộc): Cờ chỉ định người dùng có quyền grand (BIT). Ý nghĩa tùy hệ thống.
 * - @pDisabled (bool, bắt buộc): Cờ chỉ định người dùng bị vô hiệu hóa (BIT). 1 = vô hiệu hóa, 0 = hoạt động.
 * - @pUser (string, bắt buộc): Tên người dùng thực hiện cập nhật (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL (thông qua @@error).
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Logic chi tiết:
 * - Khởi tạo @pRet = 0.
 * - UPDATE bảng sysUserInfo: cập nhật FullName, isAdmin, Grand, Disabled, LUser, LDate (ngày hiện tại) với điều kiện UserName = @pUserName.
 * - Nếu @pIsAdmin = 1 (true): DELETE từ bảng sysUserGroup nơi UserName (sau khi trim) khớp với @pUserName (người dùng admin không thuộc nhóm?).
 * - Bắt lỗi: SET @pRet = @@error (lỗi của lệnh SQL cuối cùng).
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdUserInfo::call([
 *     'pUserName' => 'john.doe',
 *     'pFullName' => 'John Doe',
 *     'pIsAdmin' => true,
 *     'pGrand' => false,
 *     'pDisabled' => false,
 *     'pUser' => 'admin',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Cập nhật thành công
 * } else {
 *     // Có lỗi xảy ra
 * }
 * ```
 *
 * Lưu ý:
 * - Tham số @pIsAdmin là BIT, trong PHP có thể truyền true/false hoặc 1/0.
 * - Nếu người dùng được đánh dấu là admin, tất cả bản ghi trong sysUserGroup liên quan đến người dùng đó sẽ bị xóa (có thể để đảm bảo admin không thuộc nhóm nào).
 * - Ngày cập nhật (LDate) được tự động đặt bằng thời gian hiện tại của server (GETDATE()).
 * - Lỗi được bắt bằng @@error, có thể là lỗi của lệnh UPDATE hoặc DELETE (lệnh sau cùng).
 * - Cần đảm bảo người dùng tồn tại trước khi cập nhật, nếu không có bản ghi nào khớp, UPDATE không ảnh hưởng dòng nào nhưng không gây lỗi (trừ ràng buộc khác).
 */
class AsUpdUserInfo
{
    /**
     * Gọi stored procedure asUpdUserInfo.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdUserInfo', [
            'pUserName' => $params['pUserName'] ?? null,
            'pFullName' => $params['pFullName'] ?? null,
            'pIsAdmin'  => $params['pIsAdmin'] ?? null,
            'pGrand'    => $params['pGrand'] ?? null,
            'pDisabled' => $params['pDisabled'] ?? null,
            'pUser'     => $params['pUser'] ?? null,
            'pRet'      => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asUpdUserInfo with named parameters.
     */
    public static function callWithParams(?string $UserName = null, ?string $FullName = null, ?bool $IsAdmin = null, ?bool $Grand = null, ?bool $Disabled = null, ?string $User = null, ?int $Ret = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pFullName' => $FullName,
            'pIsAdmin'  => $IsAdmin,
            'pGrand'    => $Grand,
            'pDisabled' => $Disabled,
            'pUser'     => $User,
            'pRet'      => $Ret,
        ];

        return self::call($params);
    }
}
