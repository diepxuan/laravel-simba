<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 09:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPUpdPH3
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPUpdPH3', [
            'pMa_cty'       => $params['pMa_cty'] ?? null,
            'pStt_rec'      => $params['pStt_rec'] ?? null,
            'pMa_ct'        => $params['pMa_ct'] ?? null,
            'pSo_ct'        => $params['pSo_ct'] ?? null,
            'pNgay_ct'      => $params['pNgay_ct'] ?? null,
            'pNgay_lct'     => $params['pNgay_lct'] ?? null,
            'pMa_kh'        => $params['pMa_kh'] ?? null,
            'pDia_chi'      => $params['pDia_chi'] ?? null,
            'pNguoi_gd'     => $params['pNguoi_gd'] ?? null,
            'pDien_giai'    => $params['pDien_giai'] ?? null,
            'pTk_co'        => $params['pTk_co'] ?? null,
            'pMa_gd'        => $params['pMa_gd'] ?? null,
            'pMa_nt'        => $params['pMa_nt'] ?? null,
            'pTy_gia'       => $params['pTy_gia'] ?? 0.0,
            'pT_tien_nt'    => $params['pT_tien_nt'] ?? 0.0,
            'pT_tien'       => $params['pT_tien'] ?? 0.0,
            'pDu'           => $params['pDu'] ?? 0.0,
            'pDu_nt'        => $params['pDu_nt'] ?? 0.0,
            'pTrang_thai'   => $params['pTrang_thai'] ?? null,
            'pPost2gl'      => $params['pPost2gl'] ?? null,
            'pLUser'        => $params['pLUser'] ?? null,
        ], $connection);
    }
}
