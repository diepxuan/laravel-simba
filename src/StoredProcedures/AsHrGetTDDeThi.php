<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetTDDeThi
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetTDDeThi', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pMa_yctd'  => $params['pMa_yctd'] ?? null,
            'pVong_so'  => $params['pVong_so'] ?? null,
            'pMa_mon_thi'  => $params['pMa_mon_thi'] ?? null,
            'pDe_so'  => $params['pDe_so'] ?? null,
        ], $connection);
    }
}