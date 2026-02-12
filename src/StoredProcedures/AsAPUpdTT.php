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

class AsAPUpdTT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asAPUpdTT', [
            'pMa_cty'           => $params['pMa_cty'] ?? null,
            'pStt_rec'          => $params['pStt_rec'] ?? null,
            'pMa_ct'            => $params['pMa_ct'] ?? null,
            'pNgay_ct'          => $params['pNgay_ct'] ?? null,
            'pSo_ct'            => $params['pSo_ct'] ?? null,
            'pMa_KH'            => $params['pMa_KH'] ?? null,
            'pTk_pt'            => $params['pTk_pt'] ?? null,
            'pMa_nt'            => $params['pMa_nt'] ?? null,
            'pTy_gia'           => $params['pTy_gia'] ?? 0.0,
            'pT_tien0'          => $params['pT_tien0'] ?? 0.0,
            'pT_tien_nt0'       => $params['pT_tien_nt0'] ?? 0.0,
            'pT_thue'           => $params['pT_thue'] ?? 0.0,
            'pT_thue_nt'        => $params['pT_thue_nt'] ?? 0.0,
            'pT_tt'             => $params['pT_tt'] ?? 0.0,
            'pT_tt_nt'          => $params['pT_tt_nt'] ?? 0.0,
            'pNgay_tt'          => $params['pNgay_tt'] ?? null,
            'pMa_tt_po'         => $params['pMa_tt_po'] ?? null,
            'pHan_ck'           => $params['pHan_ck'] ?? 0.0,
            'pTl_ck'            => $params['pTl_ck'] ?? 0.0,
            'pHan_tt'           => $params['pHan_tt'] ?? 0.0,
            'pLs_qh'            => $params['pLs_qh'] ?? 0.0,
            'pMa_hd'            => $params['pMa_hd'] ?? null,
            'pDien_giai'        => $params['pDien_giai'] ?? null,
            'pStt_rec_tt'       => $params['pStt_rec_tt'] ?? null,
            'pNgay_ct_tt'       => $params['pNgay_ct_tt'] ?? null,
            'pMa_ct_tt'         => $params['pMa_ct_tt'] ?? null,
            'pSo_ct_tt'         => $params['pSo_ct_tt'] ?? null,
            'pTien_da_tt_nt'    => $params['pTien_da_tt_nt'] ?? 0.0,
            'pTien_da_tt'       => $params['pTien_da_tt'] ?? 0.0,
            'pDu_hd'            => $params['pDu_hd'] ?? 0.0,
            'pDu_hd_nt'         => $params['pDu_hd_nt'] ?? 0.0,
            'pLUser'            => $params['pLUser'] ?? null,
        ], $connection);
    }
}
