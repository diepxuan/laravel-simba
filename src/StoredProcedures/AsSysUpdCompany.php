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

class AsSysUpdCompany
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSysUpdCompany', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pTen_tcty'  => $params['pTen_tcty'] ?? null,
            'pTen_cty'  => $params['pTen_cty'] ?? null,
            'pDia_chi'  => $params['pDia_chi'] ?? null,
            'pLanguage'  => $params['pLanguage'] ?? null,
        ], $connection);
    }
}
