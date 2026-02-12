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
 * Class AsGLRptCheckCashFlow
 * 
 * Stored procedure: asGLRptCheckCashFlow
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (nvarchar(3)): input parameter.
 * - @pNgay_ct1 (smalldatetime): input parameter.
 * - @pNgay_ct2 (smalldatetime): input parameter.
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
 * $result = AsGLRptCheckCashFlow::call($params);
 * ```
 */
class AsGLRptCheckCashFlow
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptCheckCashFlow', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay_ct1' => $params['pNgay_ct1'] ?? null,
            'pNgay_ct2' => $params['pNgay_ct2'] ?? null,
        ], $connection);
    }
}
