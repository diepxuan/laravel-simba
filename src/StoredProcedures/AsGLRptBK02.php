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

class AsGLRptBK02
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptBK02', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pngay_ct1' => $params['pngay_ct1'] ?? null,
            'pngay_ct2' => $params['pngay_ct2'] ?? null,
            'pGroupType' => $params['pGroupType'] ?? null,
            'pso_ct1' => $params['pso_ct1'] ?? null,
            'pso_ct2' => $params['pso_ct2'] ?? null,
            'ptk' => $params['ptk'] ?? null,
            'pNo_co' => $params['pNo_co'] ?? null,
            'ptk_du' => $params['ptk_du'] ?? null,
            'pma_kh' => $params['pma_kh'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pma_bp' => $params['pma_bp'] ?? null,
            'pma_phi' => $params['pma_phi'] ?? null,
            'pma_hd' => $params['pma_hd'] ?? null,
            'pma_ku' => $params['pma_ku'] ?? null,
            'pma_spct' => $params['pma_spct'] ?? null,
            'pma_ct' => $params['pma_ct'] ?? null,
            'pdien_giai' => $params['pdien_giai'] ?? null,
            'pma_nt' => $params['pma_nt'] ?? null,
            'pan_mk' => $params['pan_mk'] ?? null
        ], $connection);
    }
}
