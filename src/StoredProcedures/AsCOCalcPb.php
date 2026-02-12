<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:45:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsCOCalcPb
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asCOCalcPb', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1'  => $params['pNgay1'] ?? null,
            'pNgay2'  => $params['pNgay2'] ?? null,
            'pId'     => $params['pId'] ?? null,
            'pMa_ct'  => $params['pMa_ct'] ?? null,
            'pUser'   => $params['pUser'] ?? null,
        ], $connection);
    }
}
