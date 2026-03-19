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
 * Class AsARRptBK03
 *
 * Stored procedure: asARRptBK03
 * Purpose:
 *
 * Parameters:
 * - @pMa_cty (NVARCHAR(3)): input parameter.
 * - @pNgay1 (SMALLDATETIME): input parameter.
 * - @pNgay2 (SMALLDATETIME): input parameter.
 * - @pMa_gd (NVARCHAR(8)): input parameter.
 * - @pSoct1 (NVARCHAR(12)): input parameter.
 * - @pSoct2 (NVARCHAR(12)): input parameter.
 * - @pMa_kh (NVARCHAR(20)): input parameter.
 * - @pMa_nhkh (NVARCHAR(8)): input parameter.
 * - @pMa_plkh1 (NVARCHAR(8)): input parameter.
 * - @pMa_plkh2 (NVARCHAR(8)): input parameter.
 * - @pMa_plkh3 (NVARCHAR(8)): input parameter.
 * - @pSap_xep (NVARCHAR(1)): input parameter.
 * - @pTat_toan (NVARCHAR(1)): input parameter.
 * - @pMa_NT (NVARCHAR(3)): input parameter.
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
 * $result = AsARRptBK03::call($params);
 * ```
 */
class AsARRptBK03
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBK03', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pMa_gd' => $paramObj->pMa_gd ?? null,
            'pSoct1' => $paramObj->pSoct1 ?? null,
            'pSoct2' => $paramObj->pSoct2 ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_nhkh' => $paramObj->pMa_nhkh ?? null,
            'pMa_plkh1' => $paramObj->pMa_plkh1 ?? null,
            'pMa_plkh2' => $paramObj->pMa_plkh2 ?? null,
            'pMa_plkh3' => $paramObj->pMa_plkh3 ?? null,
            'pSap_xep' => $paramObj->pSap_xep ?? null,
            'pTat_toan' => $paramObj->pTat_toan ?? null,
            'pMa_NT' => $paramObj->pMa_NT ?? null,
        ], $connection);
    }
}
