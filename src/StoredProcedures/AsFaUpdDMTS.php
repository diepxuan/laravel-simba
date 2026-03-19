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
use Diepxuan\Simba\Helper\ParamHelper;

class AsFaUpdDMTS
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaUpdDMTS', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ts' => $paramObj->pMa_ts ?? null,
            'pTen_ts' => $paramObj->pTen_ts ?? null,
            'pDvt' => $paramObj->pDvt ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pNha_cc' => $paramObj->pNha_cc ?? null,
            'pNuoc_sx' => $paramObj->pNuoc_sx ?? null,
            'pNam_sx' => $paramObj->pNam_sx ?? null,
            'pNgay_dvsd' => $paramObj->pNgay_dvsd ?? null,
            'pCong_suat' => $paramObj->pCong_suat ?? null,
            'pMa_bpsd' => $paramObj->pMa_bpsd ?? null,
            'pma_spct' => $paramObj->pma_spct ?? null,
            'pma_phi' => $paramObj->pma_phi ?? null,
            'pTk_ts' => $paramObj->pTk_ts ?? null,
            'pTk_kh' => $paramObj->pTk_kh ?? null,
            'pTk_cp' => $paramObj->pTk_cp ?? null,
            'pma_nhts1' => $paramObj->pma_nhts1 ?? null,
            'pma_nhts2' => $paramObj->pma_nhts2 ?? null,
            'pma_nhts3' => $paramObj->pma_nhts3 ?? null,
            'pMa_tg_ts' => $paramObj->pMa_tg_ts ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_tang' => $paramObj->pNgay_tang ?? null,
            'pMa_giam_ts' => $paramObj->pMa_giam_ts ?? null,
            'pNgay_giam' => $paramObj->pNgay_giam ?? null,
            'pNgay_gt_cl' => $paramObj->pNgay_gt_cl ?? null,
            'pNgay_bdkh' => $paramObj->pNgay_bdkh ?? null,
            'pNgay_tkh' => $paramObj->pNgay_tkh ?? null,
            'pNgay_Dc' => $paramObj->pNgay_Dc ?? null,
            'pLd_Dc' => $paramObj->pLd_Dc ?? null,
            'pTinh_kh' => $paramObj->pTinh_kh ?? null,
            'pSt_kh' => $paramObj->pSt_kh ?? null,
            'pTl_kh' => $paramObj->pTl_kh ?? null,
            'pNg_gia_n1' => $paramObj->pNg_gia_n1 ?? null,
            'pNg_gia_n2' => $paramObj->pNg_gia_n2 ?? null,
            'pNg_gia_n3' => $paramObj->pNg_gia_n3 ?? null,
            'pNg_gia_n4' => $paramObj->pNg_gia_n4 ?? null,
            'pT_ng_gia' => $paramObj->pT_ng_gia ?? null,
            'pGt_kh_n1' => $paramObj->pGt_kh_n1 ?? null,
            'pGt_kh_n2' => $paramObj->pGt_kh_n2 ?? null,
            'pGt_kh_n3' => $paramObj->pGt_kh_n3 ?? null,
            'pGt_kh_n4' => $paramObj->pGt_kh_n4 ?? null,
            'pT_gt_kh' => $paramObj->pT_gt_kh ?? null,
            'pGt_cl_n1' => $paramObj->pGt_cl_n1 ?? null,
            'pGt_cl_n2' => $paramObj->pGt_cl_n2 ?? null,
            'pGt_cl_n3' => $paramObj->pGt_cl_n3 ?? null,
            'pGt_cl_n4' => $paramObj->pGt_cl_n4 ?? null,
            'pT_gt_cl' => $paramObj->pT_gt_cl ?? null,
            'pKh_th_n1' => $paramObj->pKh_th_n1 ?? null,
            'pKh_th_n2' => $paramObj->pKh_th_n2 ?? null,
            'pKh_th_n3' => $paramObj->pKh_th_n3 ?? null,
            'pKh_th_n4' => $paramObj->pKh_th_n4 ?? null,
            'pT_kh_th' => $paramObj->pT_kh_th ?? null,
            'pSua_kh' => $paramObj->pSua_kh ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
