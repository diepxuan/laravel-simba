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
use Diepxuan\Simba\Helper\ParamHelper;
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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asFaUpdDmTs1', [
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
            'pLUser' => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
