<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLUpdMauBs
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdMauBs', [
            'pma_cty'  => $params['pma_cty'] ?? null,
            'pQd_cdkt'  => $params['pQd_cdkt'] ?? null,
            'pmau'  => $params['pmau'] ?? null,
            'pma_so'  => $params['pma_so'] ?? null,
            'pchi_tieu'  => $params['pchi_tieu'] ?? null,
            'pcach_tinh'  => $params['pcach_tinh'] ?? null,
            'ptk'  => $params['ptk'] ?? null,
            'ptien0'  => $params['ptien0'] ?? null,
            'ptien'  => $params['ptien'] ?? null,
            'ptien_nt0'  => $params['ptien_nt0'] ?? null,
            'ptien_nt'  => $params['ptien_nt'] ?? null,
            'pstt'  => $params['pstt'] ?? null,
            'pbold'  => $params['pbold'] ?? null,
            'pin_ck'  => $params['pin_ck'] ?? null,
            'pts_nv'  => $params['pts_nv'] ?? null,
            'pcong_no'  => $params['pcong_no'] ?? null,
            'pngoai_bang'  => $params['pngoai_bang'] ?? null,
            'psodu_duong'  => $params['psodu_duong'] ?? null,
            'pxtag'  => $params['pxtag'] ?? null,
            'pxstt'  => $params['pxstt'] ?? null,
            'ptm'  => $params['ptm'] ?? null,
        ], $connection);
    }
}