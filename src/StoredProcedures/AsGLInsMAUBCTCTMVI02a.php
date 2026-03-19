<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLInsMAUBCTCTMVI02a
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsMAUBCTCTMVI02a', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pChi_tieu' => $paramObj->pChi_tieu ?? null,
            'pNd_chtieu' => $paramObj->pNd_chtieu ?? null,
            'pcach_tinh' => $paramObj->pcach_tinh ?? null,
            'pTk_01' => $paramObj->pTk_01 ?? null,
            'pIsPrint' => $paramObj->pIsPrint ?? null,
            'pIsItalic' => $paramObj->pIsItalic ?? null,
            'pBold' => $paramObj->pBold ?? null,
            'pModify' => $paramObj->pModify ?? null,
            'pgia_goc_dk' => $paramObj->pgia_goc_dk ?? null,
            'pgia_hl_dk' => $paramObj->pgia_hl_dk ?? null,
            'pgia_dp_dk' => $paramObj->pgia_dp_dk ?? null,
            'pgia_goc_ck' => $paramObj->pgia_goc_ck ?? null,
            'pgia_hl_ck' => $paramObj->pgia_hl_ck ?? null,
            'pgia_dp_ck' => $paramObj->pgia_dp_ck ?? null,
            'pUserData' => $paramObj->pUserData ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
        ], $connection);
    }
}
