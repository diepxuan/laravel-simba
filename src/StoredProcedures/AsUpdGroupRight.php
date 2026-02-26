<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-25 15:31:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsUpdGroupRight.
 *
 * Stored procedure: asUpdGroupRight
 * Mục đích: Cập nhật tên nhóm trong bảng quyền nhóm (sysGroupRight).
 * Procedure thay đổi tên nhóm (groupname) từ giá trị cũ sang giá trị mới trong bảng phân quyền nhóm.
 *
 * Tham số:
 * - @pGroupName (string, bắt buộc): Tên nhóm mới (NVARCHAR(20)).
 * - @pGroupName_Old (string, bắt buộc): Tên nhóm cũ (NVARCHAR(20)).
 * - @pRet (int, output): Kết quả thực thi. 0 thành công, khác 0 là mã lỗi SQL.
 *
 * Giá trị trả về:
 * - Procedure không trả về resultset, chỉ thiết lập giá trị output parameter @pRet.
 * - Cần đọc giá trị @pRet sau khi gọi để kiểm tra lỗi.
 *
 * Logic chi tiết:
 * - Khởi tạo @pRet = 0.
 * - UPDATE bảng sysGroupRight: cập nhật cột groupname = @pGroupName với điều kiện groupname = @pGroupName_Old.
 * - Bắt lỗi: SET @pRet = @@error.
 *
 * Ví dụ gọi:
 * ```php
 * $result = AsUpdGroupRight::call([
 *     'pGroupName' => 'newgroup',
 *     'pGroupName_Old' => 'oldgroup',
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
 * - Tham số @pGroupName_Old là tên nhóm hiện tại trong bảng sysGroupRight, dùng làm điều kiện WHERE.
 * - Tham số @pGroupName là tên mới sẽ thay thế.
 * - Nếu không có bản ghi nào khớp điều kiện, UPDATE không ảnh hưởng dòng nào, nhưng không gây lỗi.
 * - Lỗi @@error có thể là lỗi ràng buộc (constraint), kiểu dữ liệu, hoặc lỗi truy cập.
 * - Procedure không cập nhật các cột khác như LUser, LDate (nếu có). Cần kiểm tra bảng gốc.
 * - Bảng sysGroupRight lưu trữ phân quyền chi tiết cho từng nhóm người dùng. Việc thay đổi tên nhóm cần đồng bộ với các bảng khác như sysGroupInfo, sysUserGroup.
 * - Nên đảm bảo tên nhóm mới đã tồn tại trong bảng sysGroupInfo trước khi thực hiện.
 */
class AsUpdGroupRight
{
    /**
     * Gọi stored procedure asUpdGroupRight.
     *
     * @param array $params mảng tham số với các khóa tương ứng tên tham số (có thể có tiền tố '@' hoặc không)
     *
     * @return mixed kết quả trả về từ procedure (có thể chứa output parameter)
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdGroupRight', [
            'pGroupName'     => $params['pGroupName'] ?? null,
            'pGroupName_Old' => $params['pGroupName_Old'] ?? null,
            'pRet'           => $params['pRet'] ?? null,
        ], $connection);
    }

    /**
     * Call stored procedure asUpdGroupRight with named parameters.
     */
    public static function callWithParams(?string $GroupName = null, ?string $GroupName_Old = null, ?int $Ret = null): Collection
    {
        $params = [
            'pGroupName'     => $GroupName,
            'pGroupName_Old' => $GroupName_Old,
            'pRet'           => $Ret,
        ];

        return self::call($params);
    }
}
