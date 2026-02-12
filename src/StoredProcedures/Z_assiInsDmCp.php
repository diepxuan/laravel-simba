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

class Z_assiInsDmCp
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_assiInsDmCp', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pMa_cp'   => $params['pMa_cp'] ?? null,
            'pTen_cp'  => $params['pTen_cp'] ?? null,
            'pKsd'     => $params['pKsd'] ?? null,
            'pLUser'   => $params['pLUser'] ?? null,
            'pRet'     => $params['pRet'] ?? null,
        ], $connection);
    }
}