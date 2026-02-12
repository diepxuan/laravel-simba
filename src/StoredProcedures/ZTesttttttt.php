<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:14:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class ZTesttttttt
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_testtttttt', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pMa_bp'  => $params['pMa_bp'] ?? null,
            'pStruct' => $params['pStruct'] ?? '0',
        ], $connection);
    }
}
