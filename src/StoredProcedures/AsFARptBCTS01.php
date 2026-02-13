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

class AsFARptBCTS01
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFARptBCTS01', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pNgay' => $params['pNgay'] ?? null,
            'pMa_ts' => $params['pMa_ts'] ?? null,
            'pMa_ts_all' => $params['pMa_ts_all'] ?? null,
        ], $connection);
    }
}
