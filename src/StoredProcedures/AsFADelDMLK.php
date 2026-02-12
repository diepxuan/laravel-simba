<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsFADelDMLK
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFADelDMLK', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ts' => $params['pMa_ts'] ?? null,
            'pMa_Ts_Tgng' => $params['pMa_Ts_Tgng'] ?? null,
            'pMa_lk' => $params['pMa_lk'] ?? null,
            'pRet' => $params['pRet'] ?? null,
        ], $connection);
    }
}
