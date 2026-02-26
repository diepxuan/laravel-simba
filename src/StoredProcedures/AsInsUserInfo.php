<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 06:51:37
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInsUserInfo.
 *
 * Stored procedure: asInsUserInfo
 * Mục đích: Thêm mới một user vào bảng sysUserInfo.
 * Bảng này lưu thông tin người dùng hệ thống, bao gồm tên đăng nhập, họ tên, mật khẩu (hash), quyền admin, grand, trạng thái disabled.
 * Procedure tự động gán thời gian tạo/cập nhật (CDate, LDate) và người tạo/cập nhật (CUser, LUser) bằng @pUser.
 *
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên đăng nhập (20 ký tự). Không được trùng.
 * - @pFullName (string, bắt buộc): Họ tên đầy đủ (50 ký tự, Unicode).
 * - @pPassword (string, bắt buộc): Mật khẩu (đã hash) (255 ký tự). Có thể là chuỗi mã hóa.
 * - @pIsAdmin (bool, bắt buộc): Cờ admin (bit). 1 = user có quyền quản trị hệ thống.
 * - @pGrand (bool, bắt buộc): Cờ grand (bit). 1 = user có quyền đặc biệt (có thể vượt quyền nhóm).
 * - @pDisabled (bool, bắt buộc): Cờ vô hiệu hóa (bit). 1 = user bị khóa, không thể đăng nhập.
 * - @pUser (string, bắt buộc): Tên người dùng thực hiện thao tác (20 ký tự). Sẽ được lưu vào CUser và LUser.
 * - @pRet (int, output): Kết quả trả về. 0 = thành công, khác 0 = lỗi (mã lỗi SQL).
 *
 * Giá trị mặc định:
 * - Không có.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - @pRet = 0 nếu INSERT thành công, khác 0 là mã lỗi SQL.
 *
 * Logic chi tiết:
 * 1. Khởi tạo @pRet = 0.
 * 2. INSERT vào sysUserInfo với các giá trị truyền vào, CUser = LUser = @pUser, CDate = LDate = GETDATE().
 * 3. Gán @pRet = @@ERROR.
 *
 * Lưu ý:
 * - Bảng sysUserInfo có khóa chính là UserName (hoặc có thể có ID tự tăng).
 * - Mật khẩu được lưu dưới dạng đã hash (có thể dùng thuật toán MD5, SHA1, bcrypt). Cần đảm bảo độ dài cột đủ.
 * - Cột Disabled dùng để tạm khóa tài khoản thay vì xóa.
 * - Cột Grand có thể cấp quyền đặc biệt (vượt trên cả admin?).
 * - Nếu đã tồn tại user với cùng UserName, INSERT sẽ gây lỗi vi phạm khóa chính.
 * - Procedure không kiểm tra trùng lặp trước khi INSERT.
 * - Nên đảm bảo @pUser tồn tại trong hệ thống (người tạo user).
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsInsUserInfo::call([
 *     'pUserName' => 'newuser',
 *     'pFullName' => 'Nguyễn Văn A',
 *     'pPassword' => 'hashed_password',
 *     'pIsAdmin' => false,
 *     'pGrand' => false,
 *     'pDisabled' => false,
 *     'pUser' => 'admin',
 * ]);
 * $ret = $result['pRet'] ?? null;
 * if ($ret === 0) {
 *     // Thêm thành công
 * } else {
 *     // Lỗi, mã lỗi SQL là $ret
 * }
 * ```
 *
 * Liên quan:
 * - Bảng sysUserInfo: lưu thông tin người dùng.
 * - Các procedure khác: asGetUserInfo, asUpdUserInfo, asDelUserInfo.
 */
class AsInsUserInfo
{
    /**
     * Gọi stored procedure asInsUserInfo.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter @pRet)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsUserInfo', $params, $connection);
    }

    /**
     * Call stored procedure asInsUserInfo with named parameters.
     */
    public static function callWithParams(?string $UserName = null, ?string $FullName = null, ?string $Password = null, ?bool $IsAdmin = null, ?bool $Grand = null, ?bool $Disabled = null, ?string $User = null, ?int $Ret = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pFullName' => $FullName,
            'pPassword' => $Password,
            'pIsAdmin'  => $IsAdmin,
            'pGrand'    => $Grand,
            'pDisabled' => $Disabled,
            'pUser'     => $User,
            'pRet'      => $Ret,
        ];

        return self::call($params);
    }
}
