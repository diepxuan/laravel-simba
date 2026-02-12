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

class Z_spupdglmauBcTc05
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_spupdglmauBcTc05', [
            'pma_cty'  => $params['pma_cty'] ?? null,
            'pmau'  => $params['pmau'] ?? null,
            'pma_so'  => $params['pma_so'] ?? null,
            'pstt'  => $params['pstt'] ?? null,
            'pchi_tieu'  => $params['pchi_tieu'] ?? null,
            'pcach_tinh'  => $params['pcach_tinh'] ?? null,
            'ptk_no'  => $params['ptk_no'] ?? null,
            'ptk_co'  => $params['ptk_co'] ?? null,
            'pbold'  => $params['pbold'] ?? null,
            'pin_ck'  => $params['pin_ck'] ?? null,
            'pma_so_ctu'  => $params['pma_so_ctu'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}
