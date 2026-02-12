<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 00:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSoUpdDMTD
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSoUpdDMTD', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pMa_td'  => $params['pMa_td'] ?? null,
            'pTen_td'  => $params['pTen_td'] ?? null,
            'pKm'  => $params['pKm'] ?? null,
            'pKsd'  => $params['pKsd'] ?? null,
            'pLUser'  => $params['pLUser'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}
