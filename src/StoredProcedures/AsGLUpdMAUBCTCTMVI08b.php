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
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMAUBCTCTMVI08b', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pNd_chtieu' => $params['pNd_chtieu'] ?? null,
            'pCach_tinh' => $params['pCach_tinh'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
            'pIsPrint' => $params['pIsPrint'] ?? false,
            'pIsItalic' => $params['pIsItalic'] ?? false,
            'pBold' => $params['pBold'] ?? false,
            'pRet' => $params['pRet'] ?? 0,
        ], $connection);
    }
}
