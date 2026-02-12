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

class Z_asSiDelDmCp
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asSiDelDmCp', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pMa_cp'  => $params['pMa_cp'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}
