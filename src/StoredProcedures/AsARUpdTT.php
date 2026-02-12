<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:36:45
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsARUpdTT
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asARUpdTT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pMa_KH' => $params['pMa_KH'] ?? null,
            'pTk_pt' => $params['pTk_pt'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pT_tien2' => $params['pT_tien2'] ?? null,
            'pT_tien_nt2' => $params['pT_tien_nt2'] ?? null,
            'pT_thue' => $params['pT_thue'] ?? null,
            'pT_thue_nt' => $params['pT_thue_nt'] ?? null,
            'pT_tt' => $params['pT_tt'] ?? null,
            'pT_tt_nt' => $params['pT_tt_nt'] ?? null,
            'pTien_tt' => $params['pTien_tt'] ?? null,
            'pTien_tt_nt' => $params['pTien_tt_nt'] ?? null,
            'pNgay_tt' => $params['pNgay_tt'] ?? null,
            'pMa_tt' => $params['pMa_tt'] ?? null,
            'pHan_ck' => $params['pHan_ck'] ?? null,
            'pTl_ck' => $params['pTl_ck'] ?? null,
            'pHan_tt' => $params['pHan_tt'] ?? null,
            'pLs_qh' => $params['pLs_qh'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pStt_rec_tt' => $params['pStt_rec_tt'] ?? null,
            'pNgay_ct_tt' => $params['pNgay_ct_tt'] ?? null,
            'pMa_ct_tt' => $params['pMa_ct_tt'] ?? null,
            'pSo_ct_tt' => $params['pSo_ct_tt'] ?? null,
            'pTien_da_tt_nt' => $params['pTien_da_tt_nt'] ?? null,
            'pTien_da_tt' => $params['pTien_da_tt'] ?? null,
            'pDu_hd' => $params['pDu_hd'] ?? null,
            'pDu_hd_nt' => $params['pDu_hd_nt'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
        ], $connection);
    }
}
