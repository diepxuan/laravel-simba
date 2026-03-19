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
use Diepxuan\Simba\Helper\ParamHelper;
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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsBudget', [
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNam' => $paramObj->pNam ?? 0,
            'pTk' => $paramObj->pTk ?? null,
            'pTk_du' => $paramObj->pTk_du ?? null,
            'pTtps_no_co' => $paramObj->pTtps_no_co ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pUser' => $paramObj->pUser ?? null,
            'pT1' => $paramObj->pT1 ?? 0.0,
            'pT2' => $paramObj->pT2 ?? 0.0,
            'pT3' => $paramObj->pT3 ?? 0.0,
            'pT4' => $paramObj->pT4 ?? 0.0,
            'pT5' => $paramObj->pT5 ?? 0.0,
            'pT6' => $paramObj->pT6 ?? 0.0,
            'pT7' => $paramObj->pT7 ?? 0.0,
            'pT8' => $paramObj->pT8 ?? 0.0,
            'pT9' => $paramObj->pT9 ?? 0.0,
            'pT10' => $paramObj->pT10 ?? 0.0,
            'pT11' => $paramObj->pT11 ?? 0.0,
            'pT12' => $paramObj->pT12 ?? 0.0,
            'pRet' => $paramObj->pRet ?? 0,
        ], $connection);
    }
}
