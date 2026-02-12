<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 13:17:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsDelGroupRight
 * 
 * Stored procedure: asSIDelGroupRight
 * Purpose: Xoá phân quyền nhóm (sysGroupRight) trong module Sales & Inventory.
 * 
 * Tham số:
 * - @pGroupName (nvarchar(20)): Tên nhóm cần xoá phân quyền. Bắt buộc.
 * - @pMenuID (nvarchar(8)): Mã menu cần xoá phân quyền. Bắt buộc.
 * - @pRet (int output): Tham số output trả về mã lỗi:
 *     - 0: được xoá thành công.
 * 
 * Giá trị mặc định:
 * - pGroupName: không có mặc định, phải cung cấp.
 * - pMenuID: không có mặc định, phải cung cấp.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
 *     'pGroupName' => 'Admin',
 *     'pMenuID' => 'SI001',
 * ];
 * $result = AsDelGroupRight::call($params);
 * ```
 */
class AsDelGroupRight
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIDelGroupRight', [
            'pGroupName' => $params['pGroupName'] ?? null,
            'pMenuID'    => $params['pMenuID'] ?? null,
            // pRet là output parameter, không truyền vào.
        ], $connection);
    }
}
