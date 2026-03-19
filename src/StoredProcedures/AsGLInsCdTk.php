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
 * Class AsGLInsCdTk
 *
 * Stored procedure: asGLInsCdTk
 * Purpose:
 *
 * Parameters:
 * - @pMa_cty (nvarchar(3)): input parameter.
 * - @pTk (nvarchar(20)): input parameter.
 * - @pNam (int): input parameter.
 * - @pMa_nt (nvarchar(3)): input parameter.
 * - @pDu_no_nt00 (decimal(19,4)): input parameter.
 * - @pDu_co_nt00 (decimal(19,4)): input parameter.
 * - @pDu_no00 (decimal(19,4)): input parameter.
 * - @pDu_co00 (decimal(19,4)): input parameter.
 * - @pDu_no_nt (decimal(19,4)): input parameter.
 * - @pDu_co_nt (decimal(19,4)): input parameter.
 * - @pDu_no (decimal(19,4)): input parameter.
 * - @pDu_co (decimal(19,4)): input parameter.
 * - @pLUser (nvarchar(20)): input parameter.
 * - @pRet (int): output parameter.
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
 * $result = AsGLInsCdTk::call($params);
 * ```
 */
class AsGLInsCdTk
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsCdTk', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pTk' => $paramObj->pTk ?? null,
            'pNam' => $paramObj->pNam ?? 0,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pDu_no_nt00' => $paramObj->pDu_no_nt00 ?? 0.0,
            'pDu_co_nt00' => $paramObj->pDu_co_nt00 ?? 0.0,
            'pDu_no00' => $paramObj->pDu_no00 ?? 0.0,
            'pDu_co00' => $paramObj->pDu_co00 ?? 0.0,
            'pDu_no_nt' => $paramObj->pDu_no_nt ?? 0.0,
            'pDu_co_nt' => $paramObj->pDu_co_nt ?? 0.0,
            'pDu_no' => $paramObj->pDu_no ?? 0.0,
            'pDu_co' => $paramObj->pDu_co ?? 0.0,
            'pLUser' => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
