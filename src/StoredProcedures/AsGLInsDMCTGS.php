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

class AsGLInsDMCTGS
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLInsDMCTGS', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pTen_ctgs' => $params['pTen_ctgs'] ?? null,
            'pSo_hieu' => $params['pSo_hieu'] ?? null,
            'pNgay' => $params['pNgay'] ?? null,
            'pStt' => $params['pStt'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
        ], $connection);
    }
}
