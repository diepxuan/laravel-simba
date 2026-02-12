<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:04:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPInsPH1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPInsPH1', [
            'pMa_cty'       => $params['pMa_cty'] ?? null,
            'pStt_rec'      => $params['pStt_rec'] ?? null,
            'pMa_ct'        => $params['pMa_ct'] ?? null,
            'pSo_ct'        => $params['pSo_ct'] ?? null,
            'pStt_rec_dh'   => $params['pStt_rec_dh'] ?? null,
            'pSo_dh'        => $params['pSo_dh'] ?? null,
            'pNgay_ct'      => $params['pNgay_ct'] ?? null,
            'pNgay_lct'     => $params['pNgay_lct'] ?? null,
            'pMa_kh'        => $params['pMa_kh'] ?? null,
            'pDia_chi'      => $params['pDia_chi'] ?? '',
            'pNguoi_gd'     => $params['pNguoi_gd'] ?? '',
            'pDien_giai'    => $params['pDien_giai'] ?? '',
            'pTk_co'        => $params['pTk_co'] ?? null,
            'pMa_gd'        => $params['pMa_gd'] ?? null,
            'pMa_nt'        => $params['pMa_nt'] ?? null,
            'pTy_gia'       => $params['pTy_gia'] ?? 0.0,
            'pT_tien_nt'    => $params['pT_tien_nt'] ?? 0.0,
            'pT_tien'       => $params['pT_tien'] ?? 0.0,
            'pDu'           => $params['pDu'] ?? 0.0,
            'pDu_nt'        => $params['pDu_nt'] ?? 0.0,
            'pTrang_thai'   => $params['pTrang_thai'] ?? '',
            'pPost2gl'      => $params['pPost2gl'] ?? '',
            'pLUser'        => $params['pLUser'] ?? null,
        ], $connection);
    }
}
