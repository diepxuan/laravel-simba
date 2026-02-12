<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARRptBCCN02
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBCCN02', [
            'pMa_cty' => $params['pPMa_cty'] ?? $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pPNgay1'] ?? $params['pNgay1'] ?? null,
            'pNgay2' => $params['pPNgay2'] ?? $params['pNgay2'] ?? null,
            'pTk' => $params['pPTk'] ?? $params['pTk'] ?? null,
            'pMa_kh' => $params['pPMa_kh'] ?? $params['pMa_kh'] ?? null,
            'pMa_plkh1' => $params['pPMa_plkh1'] ?? $params['pMa_plkh1'] ?? null,
            'pMa_plkh2' => $params['pPMa_plkh2'] ?? $params['pMa_plkh2'] ?? null,
            'pMa_plkh3' => $params['pPMa_plkh3'] ?? $params['pMa_plkh3'] ?? null,
            'pMa_nt' => $params['pPMa_nt'] ?? $params['pMa_nt'] ?? null,
            'pGroup1' => $params['pPGroup1'] ?? $params['pGroup1'] ?? null,
            'pGroup2' => $params['pPGroup2'] ?? $params['pGroup2'] ?? null,
            'pGroup3' => $params['pPGroup3'] ?? $params['pGroup3'] ?? null,
        ], $connection);
    }
}
