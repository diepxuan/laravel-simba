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
 * Class AsGLInsMAUBCTCTMVI13
 * 
 * Stored procedure: asGLInsMAUBCTCTMVI13
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (NVARCHAR(3)): input parameter.
 * - @pMau (NVARCHAR(10)): input parameter.
 * - @pma_so (NVARCHAR(10)): input parameter.
 * - @pChi_tieu (NVARCHAR(255)): input parameter.
 * - @pNd_chtieu (NVARCHAR(MAX)): input parameter.
 * - @pCach_tinh (NVARCHAR(50)): input parameter.
 * - @pTk_01 (NVARCHAR(10)): input parameter.
 * - @pIsPrint (BIT): input parameter.
 * - @pIsItalic (BIT): input parameter.
 * - @pBold (BIT): input parameter.
 * - @pModify (BIT): input parameter.
 * - @pcuoi_ky (DECIMAL(19,4)): input parameter.
 * - @pDau_ky (DECIMAL(19,4)): input parameter.
 * - @pUserData (BIT): input parameter.
 * - @pGhi_chu (NVARCHAR(MAX)): input parameter.
 * - @pNgay1 (SMALLDATETIME): input parameter.
 * - @pNgay2 (SMALLDATETIME): input parameter.
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
 * $result = AsGLInsMAUBCTCTMVI13::call($params);
 * ```
 */
class AsGLInsMAUBCTCTMVI13
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsMAUBCTCTMVI13', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pma_so' => $params['pma_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pNd_chtieu' => $params['pNd_chtieu'] ?? null,
            'pCach_tinh' => $params['pCach_tinh'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
            'pIsPrint' => $params['pIsPrint'] ?? false,
            'pIsItalic' => $params['pIsItalic'] ?? false,
            'pBold' => $params['pBold'] ?? false,
            'pModify' => $params['pModify'] ?? false,
            'pcuoi_ky' => $params['pcuoi_ky'] ?? 0.0,
            'pDau_ky' => $params['pDau_ky'] ?? 0.0,
            'pUserData' => $params['pUserData'] ?? false,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
        ], $connection);
    }
}
