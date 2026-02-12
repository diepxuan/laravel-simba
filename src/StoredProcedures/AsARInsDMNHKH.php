<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:46:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARInsDMNHKH
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARInsDMNHKH', [
            'pMa_cty'   => $params['pMa_cty'] ?? null,
            'pMa_nhkh'  => $params['pMa_nhkh'] ?? null,
            'pTen_nhkh' => $params['pTen_nhkh'] ?? null,
            'pKsd'      => $params['pKsd'] ?? null,
            'pLUser'    => $params['pLUser'] ?? null,
        ], $connection);
    }
}
