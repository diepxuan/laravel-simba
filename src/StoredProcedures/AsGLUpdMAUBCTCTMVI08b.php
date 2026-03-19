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
 * Class AsGLUpdMAUBCTCTMVI08b
 *
 * Stored procedure: asGLUpdMAUBCTCTMVI08b
 * Purpose:
 *
 * Parameters:
 * - @pMa_cty (NVARCHAR(3)): input parameter.
 * - @pMau (NVARCHAR(10)): input parameter.
 * - @pMa_so (NVARCHAR(10)): input parameter.
 * - @pChi_tieu (NVARCHAR(255)): input parameter.
 * - @pNd_chtieu (NVARCHAR(MAX)): input parameter.
 * - @pCach_tinh (NVARCHAR(50)): input parameter.
 * - @pTk_01 (NVARCHAR(10)): input parameter.
 * - @pIsPrint (BIT): input parameter.
 * - @pIsItalic (BIT): input parameter.
 * - @pBold (BIT): input parameter.
 * - @pRet (INT): input parameter.
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
 * $result = AsGLUpdMAUBCTCTMVI08b::call($params);
 * ```
 */
class AsGLUpdMAUBCTCTMVI08b
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMAUBCTCTMVI08b', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pChi_tieu' => $paramObj->pChi_tieu ?? null,
            'pNd_chtieu' => $paramObj->pNd_chtieu ?? null,
            'pCach_tinh' => $paramObj->pCach_tinh ?? null,
            'pTk_01' => $paramObj->pTk_01 ?? null,
            'pIsPrint' => $paramObj->pIsPrint ?? false,
            'pIsItalic' => $paramObj->pIsItalic ?? false,
            'pBold' => $paramObj->pBold ?? false,
            'pRet' => $paramObj->pRet ?? 0,
        ], $connection);
    }
}
