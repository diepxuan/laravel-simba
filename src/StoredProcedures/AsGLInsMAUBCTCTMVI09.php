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

class AsGLInsMAUBCTCTMVI09
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsMAUBCTCTMVI09', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pChi_tieu' => $paramObj->pChi_tieu ?? null,
            'pNd_chtieu' => $paramObj->pNd_chtieu ?? null,
            'pCach_tinh' => $paramObj->pCach_tinh ?? null,
            'pLoai_ps' => $paramObj->pLoai_ps ?? null,
            'pTk_01' => $paramObj->pTk_01 ?? null,
            'pTk_02' => $paramObj->pTk_02 ?? null,
            'pTk_03' => $paramObj->pTk_03 ?? null,
            'pTk_04' => $paramObj->pTk_04 ?? null,
            'pTk_05' => $paramObj->pTk_05 ?? null,
            'pTk_06' => $paramObj->pTk_06 ?? null,
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
            'pTong' => $paramObj->pTong ?? null,
            'pUserData' => $paramObj->pUserData ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }
}
