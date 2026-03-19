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

class AsGLInsDMKC
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsDMKC', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt' => $paramObj->pStt ?? null,
            'pTen_bt' => $paramObj->pTen_bt ?? null,
            'pLoai_kc' => $paramObj->pLoai_kc ?? null,
            'pKc_ps' => $paramObj->pKc_ps ?? null,
            'pTk' => $paramObj->pTk ?? null,
            'pTk_du' => $paramObj->pTk_du ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pModuleID' => $paramObj->pModuleID ?? null,
            'pKc_spct' => $paramObj->pKc_spct ?? null,
            'pKc_bp' => $paramObj->pKc_bp ?? null,
            'pKc_hd' => $paramObj->pKc_hd ?? null,
            'pKc_phi' => $paramObj->pKc_phi ?? null,
            'pKc_dt_ps' => $paramObj->pKc_dt_ps ?? null,
            'pKc_lo' => $paramObj->pKc_lo ?? null,
            'pkSd' => $paramObj->pkSd ?? null,
            'pCUser' => $paramObj->pCUser ?? null,
        ], $connection);
    }
}
