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

class AsARRptBccnHd01
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBccnHd01', [
            'pMa_cty' => $params['pPMa_cty'] ?? $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pPNgay1'] ?? $params['pNgay1'] ?? null,
            'pHan_Ky1' => $params['pPHan_Ky1'] ?? $params['pHan_Ky1'] ?? null,
            'pHan_Ky2' => $params['pPHan_Ky2'] ?? $params['pHan_Ky2'] ?? null,
            'pHan_Ky3' => $params['pPHan_Ky3'] ?? $params['pHan_Ky3'] ?? null,
            'pMa_NCC' => $params['pPMa_NCC'] ?? $params['pMa_NCC'] ?? null,
            'pMa_NhNCC' => $params['pPMa_NhNCC'] ?? $params['pMa_NhNCC'] ?? null,
            'pSap_xep' => $params['pPSap_xep'] ?? $params['pSap_xep'] ?? null,
            'pTat_toan' => $params['pPTat_toan'] ?? $params['pTat_toan'] ?? null,
            'pMa_nt' => $params['pPMa_nt'] ?? $params['pMa_nt'] ?? null,
            'pMa_TT' => $params['pPMa_TT'] ?? $params['pMa_TT'] ?? null,
        ], $connection);
    }
}
