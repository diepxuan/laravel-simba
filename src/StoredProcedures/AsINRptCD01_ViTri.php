<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:22:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINRptCD01_ViTri
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptCD01_ViTri', [
            'pMa_cty' => $params['pMa_cty'] ?? '',
            'pNgay1' => $params['pNgay1'] ?? '',
            'pNgay2' => $params['pNgay2'] ?? '',
            'pLoai_bc' => $params['pLoai_bc'] ?? '',
            'pMa_vt' => $params['pMa_vt'] ?? '',
            'pTk_vt' => $params['pTk_vt'] ?? '',
            'pMa_nhvt' => $params['pMa_nhvt'] ?? '',
            'pMa_kho' => $params['pMa_kho'] ?? '',
            'pMa_vitri' => $params['pMa_vitri'] ?? '',
            'pma_plvt1' => $params['pma_plvt1'] ?? '',
            'pma_plvt2' => $params['pma_plvt2'] ?? '',
            'pma_plvt3' => $params['pma_plvt3'] ?? '',
            'group1' => $params['group1'] ?? '',
            'group2' => $params['group2'] ?? '',
            'group3' => $params['group3'] ?? '',
            'pDVT' => $params['pDVT'] ?? '',
            'pPSDC' => $params['pPSDC'] ?? '',
            'pNgoai_te' => $params['pNgoai_te'] ?? ''
        ], $connection);
    }
}
