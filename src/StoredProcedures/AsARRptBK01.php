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

class AsARRptBK01
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARRptBK01', [
            'pMa_cty' => $params['pPMa_cty'] ?? $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pPNgay1'] ?? $params['pNgay1'] ?? null,
            'pNgay2' => $params['pPNgay2'] ?? $params['pNgay2'] ?? null,
            'pMa_kh' => $params['pPMa_kh'] ?? $params['pMa_kh'] ?? null,
            'pMa_vt' => $params['pPMa_vt'] ?? $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pPMa_nhvt'] ?? $params['pMa_nhvt'] ?? null,
            'pMa_kho' => $params['pPMa_kho'] ?? $params['pMa_kho'] ?? null,
            'pMa_lo' => $params['pPMa_lo'] ?? $params['pMa_lo'] ?? null,
            'pMa_bp' => $params['pPMa_bp'] ?? $params['pMa_bp'] ?? null,
            'pMa_hd' => $params['pPMa_hd'] ?? $params['pMa_hd'] ?? null,
            'pMa_phi' => $params['pPMa_phi'] ?? $params['pMa_phi'] ?? null,
            'pMa_spct' => $params['pPMa_spct'] ?? $params['pMa_spct'] ?? null,
            'pMa_nvkd' => $params['pPMa_nvkd'] ?? $params['pMa_nvkd'] ?? null,
            'pMa_nt' => $params['pPMa_nt'] ?? $params['pMa_nt'] ?? null,
            'pSoct1' => $params['pPSoct1'] ?? $params['pSoct1'] ?? null,
            'pSoct2' => $params['pPSoct2'] ?? $params['pSoct2'] ?? null,
            'pMa_plkh1' => $params['pPMa_plkh1'] ?? $params['pMa_plkh1'] ?? null,
            'pMa_plkh2' => $params['pPMa_plkh2'] ?? $params['pMa_plkh2'] ?? null,
            'pMa_plkh3' => $params['pPMa_plkh3'] ?? $params['pMa_plkh3'] ?? null,
        ], $connection);
    }
}
