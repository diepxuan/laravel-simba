<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 13:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINRptBKX01
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptBKX01', [
            'pMa_cty'  => $params['pMa_cty'] ?? null,
            'pNgay1'  => $params['pNgay1'] ?? null,
            'pNgay2'  => $params['pNgay2'] ?? null,
            'pGroupType'  => $params['pGroupType'] ?? null,
            'pCtu1'  => $params['pCtu1'] ?? null,
            'pCtu2'  => $params['pCtu2'] ?? null,
            'pMa_kh'  => $params['pMa_kh'] ?? null,
            'pMa_NhKh'  => $params['pMa_NhKh'] ?? null,
            'pMa_PlKh1'  => $params['pMa_PlKh1'] ?? null,
            'pMa_PlKh2'  => $params['pMa_PlKh2'] ?? null,
            'pMa_PlKh3'  => $params['pMa_PlKh3'] ?? null,
            'pMa_Hd'  => $params['pMa_Hd'] ?? null,
            'pMa_nx'  => $params['pMa_nx'] ?? null,
            'pMa_kho'  => $params['pMa_kho'] ?? null,
            'pMa_spct'  => $params['pMa_spct'] ?? null,
            'pMa_bp'  => $params['pMa_bp'] ?? null,
            'pLoai_px'  => $params['pLoai_px'] ?? null,
            'pMa_Nt'  => $params['pMa_Nt'] ?? null,
            'pMa_vt'  => $params['pMa_vt'] ?? null,
            'ptk_vt'  => $params['ptk_vt'] ?? null,
            'pTk_Du'  => $params['pTk_Du'] ?? null,
            'pDVT'  => $params['pDVT'] ?? null,
            'pMa_Cty'  => $params['pMa_Cty'] ?? null,
            'pMa_nhkh'  => $params['pMa_nhkh'] ?? null,
            'pMa_plkh1'  => $params['pMa_plkh1'] ?? null,
            'pMa_plkh2'  => $params['pMa_plkh2'] ?? null,
            'pMa_plkh3'  => $params['pMa_plkh3'] ?? null,
            'pMa_Kh'  => $params['pMa_Kh'] ?? null,
            'pMa_nt'  => $params['pMa_nt'] ?? null,
        ], $connection);
    }
}