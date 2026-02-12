<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-11 11:16:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsAPInsPost2TT_APTT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPInsPost2TT_APTT', [
            'pMa_cty'       => $params['pMa_cty'] ?? SModel::CTY,
            'pStt_rec'      => $params['pStt_rec'] ?? null,
            'pStt_rec_hd'   => $params['pStt_rec_hd'] ?? null,
            'pMa_ct'        => $params['pMa_ct'] ?? null,
            'pNguoi_gd'     => $params['pNguoi_gd'] ?? null,
            'pDien_giai'    => $params['pDien_giai'] ?? null,
            'pTk_pt'        => $params['pTk_pt'] ?? null,
            'pMa_kh'        => $params['pMa_kh'] ?? null,
            'pSo_ct'        => $params['pSo_ct'] ?? null,
            'pNgay_ct'      => $params['pNgay_ct'] ?? null,
            'pMa_nt'        => $params['pMa_nt'] ?? null,
            'pTy_gia'       => $params['pTy_gia'] ?? null,
            'pT_tt'         => $params['pT_tt'] ?? null,
            'pT_tt_nt'      => $params['pT_tt_nt'] ?? null,
            'pTien_tt'      => $params['pTien_tt'] ?? null,
            'pTien_tt_nt'   => $params['pTien_tt_nt'] ?? null,
            'pTien_tt_qd'   => $params['pTien_tt_qd'] ?? null,
            'pT_tien'       => $params['pT_tien'] ?? null,
            'pT_tien_nt'    => $params['pT_tien_nt'] ?? null,
            'pUser'         => $params['pUser'] ?? null,
        ], $connection);
    }
}
