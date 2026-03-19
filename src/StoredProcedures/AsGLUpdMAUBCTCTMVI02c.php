<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLUpdMAUBCTCTMVI02c
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMAUBCTCTMVI02c', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMau' => $paramObj->pMau ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pChi_tieu' => $paramObj->pChi_tieu ?? null,
            'pNd_chtieu' => $paramObj->pNd_chtieu ?? null,
            'pCach_tinh' => $paramObj->pCach_tinh ?? null,
            'pTk_01' => $paramObj->pTk_01 ?? null,
            'pGia_goc_dk' => $paramObj->pGia_goc_dk ?? null,
            'pGia_hl_dk' => $paramObj->pGia_hl_dk ?? null,
            'pGia_dp_dk' => $paramObj->pGia_dp_dk ?? null,
            'pGia_goc_ck' => $paramObj->pGia_goc_ck ?? null,
            'pGia_hl_ck' => $paramObj->pGia_hl_ck ?? null,
            'pGia_dp_ck' => $paramObj->pGia_dp_ck ?? null,
            'pIsprint' => $paramObj->pIsprint ?? null,
            'pIsitalic' => $paramObj->pIsitalic ?? null,
            'pBold' => $paramObj->pBold ?? null,
            'pModify' => $paramObj->pModify ?? null
        ], $connection);
    }
}
