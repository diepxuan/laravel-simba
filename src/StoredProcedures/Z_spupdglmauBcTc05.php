<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:32:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class Z_spupdglmauBcTc05
{
    public static function call(array $params = []): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_spupdglmauBcTc05', [
            'pma_cty'  => $paramObj->pma_cty ?? null,
            'pmau'  => $paramObj->pmau ?? null,
            'pma_so'  => $paramObj->pma_so ?? null,
            'pstt'  => $paramObj->pstt ?? null,
            'pchi_tieu'  => $paramObj->pchi_tieu ?? null,
            'pcach_tinh'  => $paramObj->pcach_tinh ?? null,
            'ptk_no'  => $paramObj->ptk_no ?? null,
            'ptk_co'  => $paramObj->ptk_co ?? null,
            'pbold'  => $paramObj->pbold ?? null,
            'pin_ck'  => $paramObj->pin_ck ?? null,
            'pma_so_ctu'  => $paramObj->pma_so_ctu ?? null,
            'pRet'  => $paramObj->pRet ?? null,
        ], $connection);
    }
}
