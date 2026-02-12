<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:14:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class ZSpupdglmauBcTc05
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_spupdglmauBcTc05', [
            'pma_cty'     => $params['pma_cty'] ?? '',
            'pmau'        => $params['pmau'] ?? '',
            'pma_so'      => $params['pma_so'] ?? '',
            'pstt'        => $params['pstt'] ?? 0,
            'pchi_tieu'   => $params['pchi_tieu'] ?? '',
            'pcach_tinh'  => $params['pcach_tinh'] ?? '',
            'ptk_no'      => $params['ptk_no'] ?? '',
            'ptk_co'      => $params['ptk_co'] ?? '',
            'pbold'       => $params['pbold'] ?? 0,
            'pin_ck'      => $params['pin_ck'] ?? 0,
            'pma_so_ctu'  => $params['pma_so_ctu'] ?? 0,
        ], $connection);
    }
}
