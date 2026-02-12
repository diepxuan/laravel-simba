<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 11:36:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsFaUpdDmTs1
 * 
 * Stored procedure: asFaUpdDmTs1
 * Purpose: ----------------------------------------------------------------*/
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Tham số đầu vào.
 * - @pMa_ts (nvarchar(20)): Tham số đầu vào.
 * - @pMa_ts_tgng (nvarchar(20)): Tham số đầu vào.
 * - @pDien_giai (nvarchar(255)): Tham số đầu vào.
 * - @pTang_giam (bit): Tham số đầu vào.
 * - @pMa_ldtg (nvarchar(4)): Tham số đầu vào.
 * - @pSo_ct (nvarchar(12)): Tham số đầu vào.
 * - @pNgay_ct (smalldatetime): Tham số đầu vào.
 * - @pNgay_tg (smalldatetime): Tham số đầu vào.
 * - @pNgay_gt_cl (smalldatetime): Tham số đầu vào.
 * - @pNgay_bdkh (smalldatetime): Tham số đầu vào.
 * - @pNgay_tkh (smalldatetime): Tham số đầu vào.
 * - @pNgay_giam (smalldatetime): Tham số đầu vào.
 * - @pTinh_kh (bit): Tham số đầu vào.
 * - @pSt_kh (int): Tham số đầu vào.
 * - @pTl_kh (DECIMAL(19): Tham số đầu vào.
 * - @pSo_luong (DECIMAL(19): Tham số đầu vào.
 * - @pNg_gia_n1 (DECIMAL(19): Tham số đầu vào.
 * - @pNg_gia_n2 (DECIMAL(19): Tham số đầu vào.
 * - @pNg_gia_n3 (DECIMAL(19): Tham số đầu vào.
 * - @pNg_gia_n4 (DECIMAL(19): Tham số đầu vào.
 * - @pT_ng_gia (DECIMAL(19): Tham số đầu vào.
 * - @pGt_kh_n1 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_kh_n2 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_kh_n3 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_kh_n4 (DECIMAL(19): Tham số đầu vào.
 * - @pT_gt_kh (DECIMAL(19): Tham số đầu vào.
 * - @pGt_cl_n1 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_cl_n2 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_cl_n3 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_cl_n4 (DECIMAL(19): Tham số đầu vào.
 * - @pT_gt_cl (DECIMAL(19): Tham số đầu vào.
 * - @pKh_th_n1 (DECIMAL(19): Tham số đầu vào.
 * - @pKh_th_n2 (DECIMAL(19): Tham số đầu vào.
 * - @pKh_th_n3 (DECIMAL(19): Tham số đầu vào.
 * - @pKh_th_n4 (DECIMAL(19): Tham số đầu vào.
 * - @pT_kh_th (DECIMAL(19): Tham số đầu vào.
 * - @pSua_kh (bit): Tham số đầu vào.
 * - @pIs_giam (bit): Tham số đầu vào.
 * - @pIs_tkh (bit): Tham số đầu vào.
 * - @pKsd (bit): Tham số đầu vào.
 * - @pNg_gia_n10 (DECIMAL(19): Tham số đầu vào.
 * - @pNg_gia_n20 (DECIMAL(19): Tham số đầu vào.
 * - @pNg_gia_n30 (DECIMAL(19): Tham số đầu vào.
 * - @pNg_gia_n40 (DECIMAL(19): Tham số đầu vào.
 * - @pT_ng_gia0 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_kh_n10 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_kh_n20 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_kh_n30 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_kh_n40 (DECIMAL(19): Tham số đầu vào.
 * - @pT_gt_kh0 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_cl_n10 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_cl_n20 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_cl_n30 (DECIMAL(19): Tham số đầu vào.
 * - @pGt_cl_n40 (DECIMAL(19): Tham số đầu vào.
 * - @pT_gt_cl0 (DECIMAL(19): Tham số đầu vào.
 * - @pKh_th_n10 (DECIMAL(19): Tham số đầu vào.
 * - @pKh_th_n20 (DECIMAL(19): Tham số đầu vào.
 * - @pKh_th_n30 (DECIMAL(19): Tham số đầu vào.
 * - @pKh_th_n40 (DECIMAL(19): Tham số đầu vào.
 * - @pT_kh_th0 (DECIMAL(19): Tham số đầu vào.
 * - @pLUser (nvarchar(20)): Tham số đầu vào.
 * - @pRet (int OUTPUT): Tham số output (không được xử lý bởi ProcedureCaller hiện tại).
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện update).
 * 
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pMa_ts' => '',
            'pMa_ts_tgng' => '',
            'pDien_giai' => '',
            'pTang_giam' => '',
            'pMa_ldtg' => '',
            'pSo_ct' => '',
            'pNgay_ct' => '',
            'pNgay_tg' => '',
            'pNgay_gt_cl' => '',
            'pNgay_bdkh' => '',
            'pNgay_tkh' => '',
            'pNgay_giam' => '',
            'pTinh_kh' => '',
            'pSt_kh' => '',
            'pTl_kh' => '',
            'pSo_luong' => '',
            'pNg_gia_n1' => '',
            'pNg_gia_n2' => '',
            'pNg_gia_n3' => '',
            'pNg_gia_n4' => '',
            'pT_ng_gia' => '',
            'pGt_kh_n1' => '',
            'pGt_kh_n2' => '',
            'pGt_kh_n3' => '',
            'pGt_kh_n4' => '',
            'pT_gt_kh' => '',
            'pGt_cl_n1' => '',
            'pGt_cl_n2' => '',
            'pGt_cl_n3' => '',
            'pGt_cl_n4' => '',
            'pT_gt_cl' => '',
            'pKh_th_n1' => '',
            'pKh_th_n2' => '',
            'pKh_th_n3' => '',
            'pKh_th_n4' => '',
            'pT_kh_th' => '',
            'pSua_kh' => '',
            'pIs_giam' => '',
            'pIs_tkh' => '',
            'pKsd' => '',
            'pNg_gia_n10' => '',
            'pNg_gia_n20' => '',
            'pNg_gia_n30' => '',
            'pNg_gia_n40' => '',
            'pT_ng_gia0' => '',
            'pGt_kh_n10' => '',
            'pGt_kh_n20' => '',
            'pGt_kh_n30' => '',
            'pGt_kh_n40' => '',
            'pT_gt_kh0' => '',
            'pGt_cl_n10' => '',
            'pGt_cl_n20' => '',
            'pGt_cl_n30' => '',
            'pGt_cl_n40' => '',
            'pT_gt_cl0' => '',
            'pKh_th_n10' => '',
            'pKh_th_n20' => '',
            'pKh_th_n30' => '',
            'pKh_th_n40' => '',
            'pT_kh_th0' => '',
            'pLUser' => '',
 * ];
 * $result = AsFaUpdDmTs1::call($params);
 * ```
 */
class AsFaUpdDmTs1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaUpdDmTs1', [
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
            'pLUser' => $params['pLUser'] ?? null,
        ], $connection);
    }
}
