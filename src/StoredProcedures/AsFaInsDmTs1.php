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

class AsFaInsDmTs1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaInsDmTs1', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ts' => $params['pMa_ts'] ?? null,
            'pMa_ts_tgng' => $params['pMa_ts_tgng'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pTang_giam' => $params['pTang_giam'] ?? null,
            'pMa_ldtg' => $params['pMa_ldtg'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_tg' => $params['pNgay_tg'] ?? null,
            'pNgay_gt_cl' => $params['pNgay_gt_cl'] ?? null,
            'pNgay_bdkh' => $params['pNgay_bdkh'] ?? null,
            'pNgay_tkh' => $params['pNgay_tkh'] ?? null,
            'pNgay_giam' => $params['pNgay_giam'] ?? null,
            'pTinh_kh' => $params['pTinh_kh'] ?? null,
            'pSt_kh' => $params['pSt_kh'] ?? null,
            'pTl_kh' => $params['pTl_kh'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
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
            'pIs_giam' => $params['pIs_giam'] ?? null,
            'pIs_tkh' => $params['pIs_tkh'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pNg_gia_n10' => $params['pNg_gia_n10'] ?? null,
            'pNg_gia_n20' => $params['pNg_gia_n20'] ?? null,
            'pNg_gia_n30' => $params['pNg_gia_n30'] ?? null,
            'pNg_gia_n40' => $params['pNg_gia_n40'] ?? null,
            'pT_ng_gia0' => $params['pT_ng_gia0'] ?? null,
            'pGt_kh_n10' => $params['pGt_kh_n10'] ?? null,
            'pGt_kh_n20' => $params['pGt_kh_n20'] ?? null,
            'pGt_kh_n30' => $params['pGt_kh_n30'] ?? null,
            'pGt_kh_n40' => $params['pGt_kh_n40'] ?? null,
            'pT_gt_kh0' => $params['pT_gt_kh0'] ?? null,
            'pGt_cl_n10' => $params['pGt_cl_n10'] ?? null,
            'pGt_cl_n20' => $params['pGt_cl_n20'] ?? null,
            'pGt_cl_n30' => $params['pGt_cl_n30'] ?? null,
            'pGt_cl_n40' => $params['pGt_cl_n40'] ?? null,
            'pT_gt_cl0' => $params['pT_gt_cl0'] ?? null,
            'pKh_th_n10' => $params['pKh_th_n10'] ?? null,
            'pKh_th_n20' => $params['pKh_th_n20'] ?? null,
            'pKh_th_n30' => $params['pKh_th_n30'] ?? null,
            'pKh_th_n40' => $params['pKh_th_n40'] ?? null,
            'pT_kh_th0' => $params['pT_kh_th0'] ?? null,
            'pCUser' => $params['pCUser'] ?? null,
        ], $connection);
    }
}
