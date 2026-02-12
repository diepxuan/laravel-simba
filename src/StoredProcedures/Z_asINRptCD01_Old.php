<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:30:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class Z_asINRptCD01_Old
{
    public static function call(array $params = []): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('z_asINRptCD01_Old', [
            'pMa_cty'    => $params['pMa_cty'] ?? null,
            'pNgay1'     => $params['pNgay1'] ?? null,
            'pNgay2'     => $params['pNgay2'] ?? null,
            'pLoai_bc'   => $params['pLoai_bc'] ?? 'INCD012.rpt',
            'pMa_vt'     => $params['pMa_vt'] ?? '',
            'pTk_vt'     => $params['pTk_vt'] ?? '',
            'pMa_nhvt'   => $params['pMa_nhvt'] ?? '',
            'pMa_kho'    => $params['pMa_kho'] ?? '',
            'pMa_vitri'  => $params['pMa_vitri'] ?? '',
            'pma_plvt1'  => $params['pma_plvt1'] ?? '',
            'pma_plvt2'  => $params['pma_plvt2'] ?? '',
            'pma_plvt3'  => $params['pma_plvt3'] ?? '',
            'group1'     => $params['group1'] ?? '',
            'group2'     => $params['group2'] ?? '',
            'group3'     => $params['group3'] ?? '',
            'pDVT'       => $params['pDVT'] ?? '',
            'pPSDC'      => $params['pPSDC'] ?? '1',
            'pNgoai_te'  => $params['pNgoai_te'] ?? '0',
        ], $connection);
    }
}