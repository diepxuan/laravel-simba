<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARGetDMPLKH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARGetDMPLKH', [
            'pMa_cty'   => $params['pMa_cty'] ?? null,
            'pMa_plkh'  => $params['pMa_plkh'] ?? null,
            'pStruct'   => $params['pStruct'] ?? '0',
            'pLoai'     => $params['pLoai'] ?? null,
        ], $connection);
    }
}