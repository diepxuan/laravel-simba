<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:32:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class Z_asSIRptLogCt
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asSIRptLogCt', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pUser'  => $params['pUser'] ?? null,
            'pAction'  => $params['pAction'] ?? null,
            'pNgay1'  => $params['pNgay1'] ?? null,
            'pNgay2'  => $params['pNgay2'] ?? null,
        ], $connection);
    }
}
