<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:03:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsGLUpdCdTk
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLUpdCdTk', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pDu_No_Nt00' => $params['pDu_No_Nt00'] ?? null,
            'pDu_Co_Nt00' => $params['pDu_Co_Nt00'] ?? null,
            'pDu_No00' => $params['pDu_No00'] ?? null,
            'pDu_Co00' => $params['pDu_Co00'] ?? null,
            'pDu_No_Nt' => $params['pDu_No_Nt'] ?? null,
            'pDu_Co_Nt' => $params['pDu_Co_Nt'] ?? null,
            'pDu_No' => $params['pDu_No'] ?? null,
            'pDu_Co' => $params['pDu_Co'] ?? null,
            'pLUser' => $params['pLUser'] ?? null
        ], $connection);
    }
}
