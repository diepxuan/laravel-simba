<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-13 00:00:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsFaUpdDMTS
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaUpdDMTS', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ts' => $params['pMa_ts'] ?? null,
            'pTen_ts' => $params['pTen_ts'] ?? null,
            'pDvt' => $params['pDvt'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pNha_cc' => $params['pNha_cc'] ?? null,
            'pNuoc_sx' => $params['pNuoc_sx'] ?? null,
            'pNam_sx' => $params['pNam_sx'] ?? null,
            'pNgay_dvsd' => $params['pNgay_dvsd'] ?? null,
            'pCong_suat' => $params['pCong_suat'] ?? null,
            'pMa_bpsd' => $params['pMa_bpsd'] ?? null,
            'pma_spct' => $params['pma_spct'] ?? null,
            'pma_phi' => $params['pma_phi'] ?? null,
            'pTk_ts' => $params['pTk_ts'] ?? null,
            'pTk_kh' => $params['pTk_kh'] ?? null,
            'pTk_cp' => $params['pTk_cp'] ?? null,
            'pma_nhts1' => $params['pma_nhts1'] ?? null,
            'pma_nhts2' => $params['pma_nhts2'] ?? null,
            'pma_nhts3' => $params['pma_nhts3'] ?? null,
            'pMa_tg_ts' => $params['pMa_tg_ts'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_tang' => $params['pNgay_tang'] ?? null,
            'pMa_giam_ts' => $params['pMa_giam_ts'] ?? null,
            'pNgay_giam' => $params['pNgay_giam'] ?? null,
            'pNgay_gt_cl' => $params['pNgay_gt_cl'] ?? null,
            'pNgay_bdkh' => $params['pNgay_bdkh'] ?? null,
            'pNgay_tkh' => $params['pNgay_tkh'] ?? null,
            'pNgay_Dc' => $params['pNgay_Dc'] ?? null,
            'pLd_Dc' => $params['pLd_Dc'] ?? null,
            'pTinh_kh' => $params['pTinh_kh'] ?? null,
            'pSt_kh' => $params['pSt_kh'] ?? null,
            'pTl_kh' => $params['pTl_kh'] ?? null,
            'pNg_gia_n1' => $params['pNg_gia_n1'] ?? null,
            'pNg_gia_n2' => $params['pNg_gia_n2'] ?? null,
            'pNg_gia_n3' => $params['pNg_gia_n3'] ?? null,
            'pNg_gia_n4' => $params['pNg_gia_n4'] ?? null,
            'pT_ng_gia' => $params['pT_ng_gia'] ?? null,
            'pGt_kh_n1' => $params['pGt_kh_n1'] ?? null,
            'pGt_kh_n2' => $params['pGt_kh_n2'] ?? null,
            'pGt_kh_n3' => $params['pGt_kh_n3'] ?? null,
            'pGt_kh_n4' => $params['pGt_kh_n4'] ?? null,
            'pT_gt_kh' => $params['pT_gt_kh'] ?? null,
            'pGt_cl_n1' => $params['pGt_cl_n1'] ?? null,
            'pGt_cl_n2' => $params['pGt_cl_n2'] ?? null,
            'pGt_cl_n3' => $params['pGt_cl_n3'] ?? null,
            'pGt_cl_n4' => $params['pGt_cl_n4'] ?? null,
            'pT_gt_cl' => $params['pT_gt_cl'] ?? null,
            'pKh_th_n1' => $params['pKh_th_n1'] ?? null,
            'pKh_th_n2' => $params['pKh_th_n2'] ?? null,
            'pKh_th_n3' => $params['pKh_th_n3'] ?? null,
            'pKh_th_n4' => $params['pKh_th_n4'] ?? null,
            'pT_kh_th' => $params['pT_kh_th'] ?? null,
            'pSua_kh' => $params['pSua_kh'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
        ], $connection);
    }
}
