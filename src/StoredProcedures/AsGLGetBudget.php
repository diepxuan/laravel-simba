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

class AsGLGetBudget
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLGetBudget', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pMa_tk' => $paramObj->pMa_tk ?? null,
            'pMa_tk_du' => $paramObj->pMa_tk_du ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pTtps_no_co' => $paramObj->pTtps_no_co ?? null,
        ], $connection);
    }
}
