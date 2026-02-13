<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLGetMauCf1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLGetMauCf1', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pQd_cdkt' => $params['pQd_cdkt'] ?? null,
            'pMau' => $params['pMau'] ?? null,
        ], $connection);
    }
}
