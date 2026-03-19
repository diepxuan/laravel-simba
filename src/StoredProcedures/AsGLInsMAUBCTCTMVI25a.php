<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLInsMAUBCTCTMVI25a
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsMAUBCTCTMVI25a', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pChi_tieu' => $paramObj->pChi_tieu ?? null,
            'pNd_chtieu' => $paramObj->pNd_chtieu ?? null,
            'pCach_tinh' => $paramObj->pCach_tinh ?? null,
            'pLoai_ps' => $paramObj->pLoai_ps ?? null,
            'pNam_ps' => $paramObj->pNam_ps ?? null,
            'pTk_01' => $paramObj->pTk_01 ?? null,
            'pTk_02' => $paramObj->pTk_02 ?? null,
            'pTk_03' => $paramObj->pTk_03 ?? null,
            'pTk_04' => $paramObj->pTk_04 ?? null,
            'pTk_05' => $paramObj->pTk_05 ?? null,
            'pTk_06' => $paramObj->pTk_06 ?? null,
            'pTk_07' => $paramObj->pTk_07 ?? null,
            'pTk_08' => $paramObj->pTk_08 ?? null,
            'pTk_09' => $paramObj->pTk_09 ?? null,
            'pTk_10' => $paramObj->pTk_10 ?? null,
            'pTk_11' => $paramObj->pTk_11 ?? null,
            'pTk_12' => $paramObj->pTk_12 ?? null,
            'pIsPrint' => $paramObj->pIsPrint ?? null,
            'pIsItalic' => $paramObj->pIsItalic ?? null,
            'pBold' => $paramObj->pBold ?? null,
            'pModify' => $paramObj->pModify ?? null,
            'pTien_01' => $paramObj->pTien_01 ?? null,
            'pTien_02' => $paramObj->pTien_02 ?? null,
            'pTien_03' => $paramObj->pTien_03 ?? null,
            'pTien_04' => $paramObj->pTien_04 ?? null,
            'pTien_05' => $paramObj->pTien_05 ?? null,
            'pTien_06' => $paramObj->pTien_06 ?? null,
            'pTien_07' => $paramObj->pTien_07 ?? null,
            'pTien_08' => $paramObj->pTien_08 ?? null,
            'pTien_09' => $paramObj->pTien_09 ?? null,
            'pTien_10' => $paramObj->pTien_10 ?? null,
            'pTien_11' => $paramObj->pTien_11 ?? null,
            'pTien_12' => $paramObj->pTien_12 ?? null,
            'pTong' => $paramObj->pTong ?? null,
            'pUserData' => $paramObj->pUserData ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null
        ], $connection);
    }
}
