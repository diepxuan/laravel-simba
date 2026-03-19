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

class AsFaInsDmTs1
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaInsDmTs1', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_ts' => $paramObj->pMa_ts ?? null,
            'pMa_ts_tgng' => $paramObj->pMa_ts_tgng ?? null,
            'pDien_giai' => $paramObj->pDien_giai ?? null,
            'pTang_giam' => $paramObj->pTang_giam ?? null,
            'pMa_ldtg' => $paramObj->pMa_ldtg ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_tg' => $paramObj->pNgay_tg ?? null,
            'pNgay_gt_cl' => $paramObj->pNgay_gt_cl ?? null,
            'pNgay_bdkh' => $paramObj->pNgay_bdkh ?? null,
            'pNgay_tkh' => $paramObj->pNgay_tkh ?? null,
            'pNgay_giam' => $paramObj->pNgay_giam ?? null,
            'pTinh_kh' => $paramObj->pTinh_kh ?? null,
            'pSt_kh' => $paramObj->pSt_kh ?? null,
            'pTl_kh' => $paramObj->pTl_kh ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
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
            'pIs_giam' => $paramObj->pIs_giam ?? null,
            'pIs_tkh' => $paramObj->pIs_tkh ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pNg_gia_n10' => $paramObj->pNg_gia_n10 ?? null,
            'pNg_gia_n20' => $paramObj->pNg_gia_n20 ?? null,
            'pNg_gia_n30' => $paramObj->pNg_gia_n30 ?? null,
            'pNg_gia_n40' => $paramObj->pNg_gia_n40 ?? null,
            'pT_ng_gia0' => $paramObj->pT_ng_gia0 ?? null,
            'pGt_kh_n10' => $paramObj->pGt_kh_n10 ?? null,
            'pGt_kh_n20' => $paramObj->pGt_kh_n20 ?? null,
            'pGt_kh_n30' => $paramObj->pGt_kh_n30 ?? null,
            'pGt_kh_n40' => $paramObj->pGt_kh_n40 ?? null,
            'pT_gt_kh0' => $paramObj->pT_gt_kh0 ?? null,
            'pGt_cl_n10' => $paramObj->pGt_cl_n10 ?? null,
            'pGt_cl_n20' => $paramObj->pGt_cl_n20 ?? null,
            'pGt_cl_n30' => $paramObj->pGt_cl_n30 ?? null,
            'pGt_cl_n40' => $paramObj->pGt_cl_n40 ?? null,
            'pT_gt_cl0' => $paramObj->pT_gt_cl0 ?? null,
            'pKh_th_n10' => $paramObj->pKh_th_n10 ?? null,
            'pKh_th_n20' => $paramObj->pKh_th_n20 ?? null,
            'pKh_th_n30' => $paramObj->pKh_th_n30 ?? null,
            'pKh_th_n40' => $paramObj->pKh_th_n40 ?? null,
            'pT_kh_th0' => $paramObj->pT_kh_th0 ?? null,
            'pCUser' => $paramObj->pCUser ?? null,
        ], $connection);
    }
}
