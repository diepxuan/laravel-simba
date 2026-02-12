<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsDelVoucherInfo
 * 
 * Stored procedure: asDelVoucherInfo
 * Purpose: 
 * 
 * Parameters:
 * - @pVoucher_code (NVARCHAR(50)): input parameter.
 * - @pRet (INT): output parameter.
 * 
 * Default values: 
 * 
 * Returns: Collection of query results.
 * 
 * Example call:
 * ```php
 * $params = [
 *     // Provide parameter values
 * ];
 * $result = AsDelVoucherInfo::call($params);
 * ```
 */
class AsDelVoucherInfo
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asDelVoucherInfo', [
            'pVoucher_code' => $params['pVoucher_code'] ?? null,
        ], $connection);
    }
}
