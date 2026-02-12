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
 * Class AsGLInsMAUBCTCTMVI15a
 * 
 * Stored procedure: asGLInsMAUBCTCTMVI15a
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (NVARCHAR(3)): input parameter.
 * - @pMau (NVARCHAR(10)): input parameter.
 * - @pMa_so (NVARCHAR(10)): input parameter.
 * - @pChi_tieu (NVARCHAR(255)): input parameter.
 * - @pNd_chtieu (NVARCHAR(MAX)): input parameter.
 * - @pcach_tinh (NVARCHAR(50)): input parameter.
 * - @pTk_01 (NVARCHAR(10)): input parameter.
 * - @pIsPrint (BIT): input parameter.
 * - @pIsItalic (BIT): input parameter.
 * - @pBold (BIT): input parameter.
 * - @pModify (BIT): input parameter.
 * - @pgia_tri_dk (DECIMAL): input parameter.
 * - @pton_dk (DECIMAL): input parameter.
 * - @pps_tang (DECIMAL): input parameter.
 * - @pps_giam (DECIMAL): input parameter.
 * - @pgia_tri_ck (DECIMAL): input parameter.
 * - @pton_ck (DECIMAL): input parameter.
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
 * $result = AsGLInsMAUBCTCTMVI15a::call($params);
 * ```
 */
class AsGLInsMAUBCTCTMVI15a
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsMAUBCTCTMVI15a', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau' => $params['pMau'] ?? null,
            'pMa_so' => $params['pMa_so'] ?? null,
            'pChi_tieu' => $params['pChi_tieu'] ?? null,
            'pNd_chtieu' => $params['pNd_chtieu'] ?? null,
            'pcach_tinh' => $params['pcach_tinh'] ?? null,
            'pTk_01' => $params['pTk_01'] ?? null,
            'pIsPrint' => $params['pIsPrint'] ?? false,
            'pIsItalic' => $params['pIsItalic'] ?? false,
            'pBold' => $params['pBold'] ?? false,
            'pModify' => $params['pModify'] ?? false,
            'pgia_tri_dk' => $params['pgia_tri_dk'] ?? 0.0,
            'pton_dk' => $params['pton_dk'] ?? 0.0,
            'pps_tang' => $params['pps_tang'] ?? 0.0,
            'pps_giam' => $params['pps_giam'] ?? 0.0,
            'pgia_tri_ck' => $params['pgia_tri_ck'] ?? 0.0,
            'pton_ck' => $params['pton_ck'] ?? 0.0,
            'pUserData' => $params['pUserData'] ?? false,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
        ], $connection);
    }
}
