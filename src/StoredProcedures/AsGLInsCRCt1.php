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

class AsGLInsCRCt1
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsCRCt1', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pStt_rec0' => $paramObj->pStt_rec0 ?? null,
            'pMa_dv' => $paramObj->pMa_dv ?? null,
            'pTk' => $paramObj->pTk ?? null,
            'pMa_so' => $paramObj->pMa_so ?? null,
            'pMa_bang' => $paramObj->pMa_bang ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pTy_gia' => $paramObj->pTy_gia ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pDien_giai' => $paramObj->pDien_giai ?? null,
            'pPs_co' => $paramObj->pPs_co ?? null,
            'pPs_co_nt' => $paramObj->pPs_co_nt ?? null,
            'pPs_no' => $paramObj->pPs_no ?? null,
            'pPs_no_nt' => $paramObj->pPs_no_nt ?? null,
            'pNh_dk' => $paramObj->pNh_dk ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pMa_ku' => $paramObj->pMa_ku ?? null
        ], $connection);
    }
}
