<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 10:59:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIInsDMBP
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIInsDMBP', [
            'pMa_cty' => $params['pMa_cty'] ?? SModel::CTY,
            'pMa_bp'  => $params['pMa_bp'] ?? null,
            'pTen_bp' => $params['pTen_bp'] ?? null,
            'pKsd'    => $params['pKsd'] ?? null,
            'pLUser'  => $params['pLUser'] ?? null,
        ], $connection);
    }
}
