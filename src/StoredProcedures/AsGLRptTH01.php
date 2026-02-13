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

class AsGLRptTH01
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptTH01', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pngay_ct1' => $params['pngay_ct1'] ?? null,
            'pngay_ct2' => $params['pngay_ct2'] ?? null,
            'pma_ct' => $params['pma_ct'] ?? null,
            'ptk' => $params['ptk'] ?? null,
            'ptk_du' => $params['ptk_du'] ?? null,
            'pnhom_kh' => $params['pnhom_kh'] ?? null,
            'pma_plkh1' => $params['pma_plkh1'] ?? null,
            'pma_plkh2' => $params['pma_plkh2'] ?? null,
            'pma_plkh3' => $params['pma_plkh3'] ?? null,
            'pma_kh' => $params['pma_kh'] ?? null,
            'pso_ct1' => $params['pso_ct1'] ?? null,
            'pso_ct2' => $params['pso_ct2'] ?? null,
            'pNo_co' => $params['pNo_co'] ?? null,
            'pma_nt' => $params['pma_nt'] ?? null,
            'pma_hd' => $params['pma_hd'] ?? null,
            'pma_phi' => $params['pma_phi'] ?? null,
            'pdien_giai' => $params['pdien_giai'] ?? null,
            'pma_bp' => $params['pma_bp'] ?? null,
            'pma_spct' => $params['pma_spct'] ?? null,
            'pma_nhhd' => $params['pma_nhhd'] ?? null,
            'pma_lo' => $params['pma_lo'] ?? null,
            'pGroup' => $params['pGroup'] ?? null,
            'pBcNt' => $params['pBcNt'] ?? null
        ], $connection);
    }
}
