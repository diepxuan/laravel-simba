<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-26 06:52:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsInsUserRight.
 *
 * Stored procedure: asInsUserRight
 * Mục đích: Thêm mới một bản ghi quyền user vào bảng sysUserRight.
 * Bảng này lưu quyền chi tiết của user đối với các menu/chức năng (view, insert, update, delete) và giới hạn in (LimitedPrint).
 *
 * Tham số:
 * - @pUserName (string, bắt buộc): Tên đăng nhập của user (20 ký tự). Phải tồn tại trong sysUserInfo.
 * - @pMenuID (string, bắt buộc): Mã menu (8 ký tự). Menu/chức năng cần cấp quyền.
 * - @pViewRight (string, bắt buộc): Quyền xem (1 ký tự). 'Y' = cho phép, 'N' = không.
 * - @pInsertRight (string, bắt buộc): Quyền thêm mới (1 ký tự). 'Y' hoặc 'N'.
 * - @pUpdateRight (string, bắt buộc): Quyền sửa (1 ký tự). 'Y' hoặc 'N'.
 * - @pDeleteRight (string, bắt buộc): Quyền xóa (1 ký tự). 'Y' hoặc 'N'.
 * - @pLimitedPrint (int, bắt buộc): Giới hạn in (integer). Số lần in tối đa? Có thể là số lượng bản in cho phép, 0 = không giới hạn.
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
 * 2. INSERT vào sysUserRight với các giá trị truyền vào.
 * 3. Gán @pRet = @@ERROR.
 *
 * Lưu ý:
 * - Bảng sysUserRight có khóa chính có thể là (username, menuid).
 * - Các quyền được lưu dưới dạng ký tự 'Y'/'N' (có thể là '1'/'0' nhưng kiểu NVARCHAR(1)).
 * - LimitedPrint có thể dùng để giới hạn số lần in chứng từ cho user đối với menu đó. Giá trị nguyên, ý nghĩa tùy hệ thống.
 * - Nên đảm bảo username tồn tại trong sysUserInfo và menuid tồn tại trong sysMenu.
 * - Nếu đã có bản ghi quyền cho cùng user và menu, INSERT sẽ gây lỗi vi phạm khóa chính.
 * - Procedure không kiểm tra trùng lặp trước khi INSERT.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsInsUserRight::call([
 *     'pUserName' => 'user1',
 *     'pMenuID' => 'MN001',
 *     'pViewRight' => 'Y',
 *     'pInsertRight' => 'N',
 *     'pUpdateRight' => 'Y',
 *     'pDeleteRight' => 'N',
 *     'pLimitedPrint' => 10,
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
 * - Bảng sysUserRight: lưu quyền chi tiết của user.
 * - Bảng sysUserInfo: thông tin user.
 * - Các procedure khác: asGetUserRight, asUpdUserRight, asDelUserRight.
 */
class AsInsUserRight
{
    /**
     * Gọi stored procedure asInsUserRight.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     * @param array $params Procedure parameters
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter @pRet)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsUserRight', [
            'pUserName'     => $params['pUserName'] ?? null,
            'pMenuID'       => $params['pMenuID'] ?? null,
            'pViewRight'    => $params['pViewRight'] ?? null,
            'pInsertRight'  => $params['pInsertRight'] ?? null,
            'pUpdateRight'  => $params['pUpdateRight'] ?? null,
            'pDeleteRight'  => $params['pDeleteRight'] ?? null,
            'pLimitedPrint' => $params['pLimitedPrint'] ?? null,
            'pRet'          => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asInsUserRight with named parameters.
     */
    public static function callWithParams(?string $UserName = null, ?string $MenuID = null, ?string $ViewRight = null, ?string $InsertRight = null, ?string $UpdateRight = null, ?string $DeleteRight = null, ?int $LimitedPrint = null, ?int $Ret = null): Collection
    {
        $params = [
            'pUserName'     => $UserName,
            'pMenuID'       => $MenuID,
            'pViewRight'    => $ViewRight,
            'pInsertRight'  => $InsertRight,
            'pUpdateRight'  => $UpdateRight,
            'pDeleteRight'  => $DeleteRight,
            'pLimitedPrint' => $LimitedPrint,
            'pRet'          => $Ret,
        ];

        return self::call($params);
    }
}
