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

class AsGLRptBCPT05
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBCPT05', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pTK' => $params['pTK'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pMa_BP' => $params['pMa_BP'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pGroup1' => $params['pGroup1'] ?? null,
            'pGroup2' => $params['pGroup2'] ?? null,
            'pGroup3' => $params['pGroup3'] ?? null,
            'pGroup4' => $params['pGroup4'] ?? null
        ], $connection);
    }
}
