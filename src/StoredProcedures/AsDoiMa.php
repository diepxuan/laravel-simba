<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsDoiMa
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asDoiMa', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pCode_name' => $params['pCode_name'] ?? null,
            'pOldValue' => $params['pOldValue'] ?? null,
            'pNewValue' => $params['pNewValue'] ?? null,
            'pTable_name' => $params['pTable_name'] ?? null,
        ], $connection);
    }
}
