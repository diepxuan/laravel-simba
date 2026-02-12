<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:36:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsDelOpeningBlanceInfo
 * 
 * Stored procedure: asDelOpeningBlanceInfo
 * Purpose: No description
 * 
 * Tham số:
 * - @pCode_name (NVARCHAR(50)): Tham số đầu vào.
 * - @pRet (INT OUTPUT): Tham số output (không được xử lý bởi ProcedureCaller hiện tại).
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện delete).
 * 
 * Example call:
 * ```php
 * $params = [
            'pCode_name' => '',
 * ];
 * $result = AsDelOpeningBlanceInfo::call($params);
 * ```
 */
class AsDelOpeningBlanceInfo
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asDelOpeningBlanceInfo', [
            'pCode_name' => $params['pCode_name'] ?? null,
        ], $connection);
    }
}
