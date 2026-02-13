<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:15:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsCoCpCalDepreciation
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCoCpCalDepreciation', [
            'pDateFormat' => $params['pDateFormat'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
        ], $connection);
    }
}
