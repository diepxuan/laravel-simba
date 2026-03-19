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

class AsGLRptBCPT05
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCPT05', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pTK' => $paramObj->pTK ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pMa_BP' => $paramObj->pMa_BP ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pGroup1' => $paramObj->pGroup1 ?? null,
            'pGroup2' => $paramObj->pGroup2 ?? null,
            'pGroup3' => $paramObj->pGroup3 ?? null,
            'pGroup4' => $paramObj->pGroup4 ?? null
        ], $connection);
    }
}
