<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class Z_asARGetDMNgHKH
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asARGetDMNgHKH', [
            'pId_cn'   => $params['pId_cn'] ?? null,
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pMa_kh'   => $params['pMa_kh'] ?? null,
            'pMa_nh'   => $params['pMa_nh'] ?? null,
            'pStruct'  => $params['pStruct'] ?? '0',
        ], $connection);
    }
}