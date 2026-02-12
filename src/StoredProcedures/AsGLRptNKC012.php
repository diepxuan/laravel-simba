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
 * Class AsGLRptNKC012
 * 
 * Stored procedure: asGLRptNKC012
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (NVARCHAR(3)): input parameter.
 * - @pNgay_Ct1 (SMALLDATETIME): input parameter.
 * - @pNgay_Ct2 (SMALLDATETIME): input parameter.
 * - @pTk (NVARCHAR(20)): input parameter.
 * - @pMa_Nt (NVARCHAR(3)): input parameter.
 * - @pStt_dong_nkc (BIT): input parameter.
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
 * $result = AsGLRptNKC012::call($params);
 * ```
 */
class AsGLRptNKC012
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptNKC012', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay_Ct1' => $params['pNgay_Ct1'] ?? null,
            'pNgay_Ct2' => $params['pNgay_Ct2'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pMa_Nt' => $params['pMa_Nt'] ?? null,
            'pStt_dong_nkc' => $params['pStt_dong_nkc'] ?? false,
        ], $connection);
    }
}
