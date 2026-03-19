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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsMAUBCTCTMVI15a', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pChi_tieu' => $paramObj->pChi_tieu ?? null,
            'pNd_chtieu' => $paramObj->pNd_chtieu ?? null,
            'pcach_tinh' => $paramObj->pcach_tinh ?? null,
            'pTk_01' => $paramObj->pTk_01 ?? null,
            'pIsPrint' => $paramObj->pIsPrint ?? false,
            'pIsItalic' => $paramObj->pIsItalic ?? false,
            'pBold' => $paramObj->pBold ?? false,
            'pModify' => $paramObj->pModify ?? false,
            'pgia_tri_dk' => $paramObj->pgia_tri_dk ?? 0.0,
            'pton_dk' => $paramObj->pton_dk ?? 0.0,
            'pps_tang' => $paramObj->pps_tang ?? 0.0,
            'pps_giam' => $paramObj->pps_giam ?? 0.0,
            'pgia_tri_ck' => $paramObj->pgia_tri_ck ?? 0.0,
            'pton_ck' => $paramObj->pton_ck ?? 0.0,
            'pUserData' => $paramObj->pUserData ?? false,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
        ], $connection);
    }
}
