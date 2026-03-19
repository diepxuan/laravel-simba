<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsFAUpdKHTS
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFAUpdKHTS', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pThang' => $paramObj->pThang ?? null,
            'pMa_ts' => $paramObj->pMa_ts ?? null,
            'pMa_ts_tgng' => $paramObj->pMa_ts_tgng ?? null,
            'pKh_n1' => $paramObj->pKh_n1 ?? null,
            'pKh_n2' => $paramObj->pKh_n2 ?? null,
            'pKh_n3' => $paramObj->pKh_n3 ?? null,
            'pKh_n4' => $paramObj->pKh_n4 ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pma_bpsd' => $paramObj->pma_bpsd ?? null,
            'ptk_kh' => $paramObj->ptk_kh ?? null,
            'ptk_cp' => $paramObj->ptk_cp ?? null,
            'pSua_kh' => $paramObj->pSua_kh ?? null,
        ], $connection);
    }
}
