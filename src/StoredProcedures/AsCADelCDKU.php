<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:36:46
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsCADelCDKU
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCADelCDKU', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pMa_ku' => $params['pMa_ku'] ?? null,
        ], $connection);
    }
}
