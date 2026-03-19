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
use Diepxuan\Simba\Helper\ParamHelper;

class AsGLRptCTGS05
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGLRptCTGS05', [
            'pma_cty' => $paramObj->pma_cty ?? null,
            'pngay_ct1' => $paramObj->pngay_ct1 ?? null,
            'pngay_ct2' => $paramObj->pngay_ct2 ?? null,
            'pngay_lo1' => $paramObj->pngay_lo1 ?? null,
            'pngay_lo2' => $paramObj->pngay_lo2 ?? null,
            'pma_ct' => $paramObj->pma_ct ?? null,
            'ptk' => $paramObj->ptk ?? null,
            'ptk_du' => $paramObj->ptk_du ?? null,
            'pnhom_kh' => $paramObj->pnhom_kh ?? null,
            'pma_plkh1' => $paramObj->pma_plkh1 ?? null,
            'pma_plkh2' => $paramObj->pma_plkh2 ?? null,
            'pma_plkh3' => $paramObj->pma_plkh3 ?? null,
            'pma_kh' => $paramObj->pma_kh ?? null,
            'pso_ct1' => $paramObj->pso_ct1 ?? null,
            'pso_ct2' => $paramObj->pso_ct2 ?? null,
            'pso_lo1' => $paramObj->pso_lo1 ?? null,
            'pso_lo2' => $paramObj->pso_lo2 ?? null,
            'pma_nt' => $paramObj->pma_nt ?? null,
            'pma_hd' => $paramObj->pma_hd ?? null,
            'pma_phi' => $paramObj->pma_phi ?? null,
            'pdien_giai' => $paramObj->pdien_giai ?? null,
            'pma_bp' => $paramObj->pma_bp ?? null,
            'pma_spct' => $paramObj->pma_spct ?? null,
            'pma_ku' => $paramObj->pma_ku ?? null
        ], $connection);
    }
}
