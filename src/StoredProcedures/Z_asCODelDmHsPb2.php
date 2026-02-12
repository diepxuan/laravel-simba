<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class Z_asCODelDmHsPb2
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asCODelDmHsPb2', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pThang'  => $params['pThang'] ?? null,
            'pNam'    => $params['pNam'] ?? null,
            'pMa_sp'  => $params['pMa_sp'] ?? null,
            'pRet'    => $params['pRet'] ?? null,
        ], $connection);
    }
}