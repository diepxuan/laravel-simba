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

class AsGLUpdDMTK
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdDMTK', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pTk' => $paramObj->pTk ?? null,
            'pTen_tk' => $paramObj->pTen_tk ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pChi_tiet' => $paramObj->pChi_tiet ?? null,
            'pTk_me' => $paramObj->pTk_me ?? null,
            'pBac_tk' => $paramObj->pBac_tk ?? null,
            'pTk_sc' => $paramObj->pTk_sc ?? null,
            'pTk_cn' => $paramObj->pTk_cn ?? null,
            'pPp_tinh_tggs_no' => $paramObj->pPp_tinh_tggs_no ?? null,
            'pPp_tinh_tggs_co' => $paramObj->pPp_tinh_tggs_co ?? null,
            'pKieu_sd' => $paramObj->pKieu_sd ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pMa_ngh' => $paramObj->pMa_ngh ?? null,
            'pSo_tk' => $paramObj->pSo_tk ?? null,
            'pTen_ngh' => $paramObj->pTen_ngh ?? null,
            'pTinh_tp' => $paramObj->pTinh_tp ?? null
        ], $connection);
    }
}
