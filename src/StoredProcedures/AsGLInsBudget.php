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
 * Class AsGLInsBudget
 * 
 * Stored procedure: asGLInsBudget
 * Purpose: 
 * 
 * Parameters:
 * - @pStt_rec (NVARCHAR(20)): input parameter.
 * - @pMa_cty (NVARCHAR(3)): input parameter.
 * - @pNam (INT): input parameter.
 * - @pTk (NVARCHAR(20)): input parameter.
 * - @pTk_du (NVARCHAR(20)): input parameter.
 * - @pTtps_no_co (NVARCHAR(10)): input parameter.
 * - @pMa_bp (NVARCHAR(20)): input parameter.
 * - @pMa_phi (NVARCHAR(20)): input parameter.
 * - @pMa_spct (NVARCHAR(20)): input parameter.
 * - @pUser (NVARCHAR(20)): input parameter.
 * - @pT1 (DECIMAL(19, 4)): input parameter.
 * - @pT2 (DECIMAL(19, 4)): input parameter.
 * - @pT3 (DECIMAL(19, 4)): input parameter.
 * - @pT4 (DECIMAL(19, 4)): input parameter.
 * - @pT5 (DECIMAL(19, 4)): input parameter.
 * - @pT6 (DECIMAL(19, 4)): input parameter.
 * - @pT7 (DECIMAL(19, 4)): input parameter.
 * - @pT8 (DECIMAL(19, 4)): input parameter.
 * - @pT9 (DECIMAL(19, 4)): input parameter.
 * - @pT10 (DECIMAL(19, 4)): input parameter.
 * - @pT11 (DECIMAL(19, 4)): input parameter.
 * - @pT12 (DECIMAL(19, 4)): input parameter.
 * - @pRet (INT OUT): input parameter.
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
 * $result = AsGLInsBudget::call($params);
 * ```
 */
class AsGLInsBudget
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsBudget', [
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? 0,
            'pTk' => $params['pTk'] ?? null,
            'pTk_du' => $params['pTk_du'] ?? null,
            'pTtps_no_co' => $params['pTtps_no_co'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pUser' => $params['pUser'] ?? null,
            'pT1' => $params['pT1'] ?? 0.0,
            'pT2' => $params['pT2'] ?? 0.0,
            'pT3' => $params['pT3'] ?? 0.0,
            'pT4' => $params['pT4'] ?? 0.0,
            'pT5' => $params['pT5'] ?? 0.0,
            'pT6' => $params['pT6'] ?? 0.0,
            'pT7' => $params['pT7'] ?? 0.0,
            'pT8' => $params['pT8'] ?? 0.0,
            'pT9' => $params['pT9'] ?? 0.0,
            'pT10' => $params['pT10'] ?? 0.0,
            'pT11' => $params['pT11'] ?? 0.0,
            'pT12' => $params['pT12'] ?? 0.0,
            'pRet' => $params['pRet'] ?? 0,
        ], $connection);
    }
}
