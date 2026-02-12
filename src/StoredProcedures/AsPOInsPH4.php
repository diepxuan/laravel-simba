<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 12:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

/**
 * Class AsPOInsPH4
 * 
 * Stored procedure: asPOInsPH4
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (nvarchar(3)): input parameter.
 * - @pStt_rec (nvarchar(20)): input parameter.
 * - @pMa_ct (nvarchar(3)): input parameter.
 * - @pMa_kh (nvarchar(20)): input parameter.
 * - @pDia_chi (nvarchar(255)): input parameter.
 * - @pNguoi_gd (nvarchar(30)): input parameter.
 * - @pMa_httt (nvarchar(20)): input parameter.
 * - @pTk_pt (nvarchar(20)): input parameter.
 * - @pDien_giai (nvarchar(255)): input parameter.
 * - @pSo_seri (nvarchar(12)): input parameter.
 * - @pSo_ct (nvarchar(12)): input parameter.
 * - @pNgay_ct (smalldatetime): input parameter.
 * - @pNgay_lct (smalldatetime): input parameter.
 * - @pSua_tt (bit): input parameter.
 * - @pMa_tt_po (nvarchar(8)): input parameter.
 * - @pHan_ck (decimal(19,4)): input parameter.
 * - @pTl_ck (decimal(19,4)): input parameter.
 * - @pHan_tt (decimal(19,4)): input parameter.
 * - @pLs_qh (decimal(19,4)): input parameter.
 * - @pMa_nt (nvarchar(3)): input parameter.
 * - @pTy_gia (decimal(19,4)): input parameter.
 * - @pT_tien_nt0 (decimal(19,4)): input parameter.
 * - @pT_tien0 (decimal(19,4)): input parameter.
 * - @pT_cp_nt (decimal(19,4)): input parameter.
 * - @pT_cp (decimal(19,4)): input parameter.
 * - @pT_thue_nt (decimal(19,4)): input parameter.
 * - @pT_thue (decimal(19,4)): input parameter.
 * - @pT_tt (decimal(19,4)): input parameter.
 * - @pT_tt_nt (decimal(19,4)): input parameter.
 * - @pT_so_luong (decimal(19, 4)): input parameter.
 * - @pPost2gl (bit): input parameter.
 * - @pTrang_thai (nvarchar(1)): input parameter.
 * - @pKht_tain (BIT): input parameter.
 * - @pLUser (nvarchar(20)): input parameter.
 * - @pRet (int): output parameter.
 * 
 * Default values: 
 * 
 * Returns: Collection of query results.
 * 
 * Example call:
 * ```php
 * $params = [
 *     // Provide parameter values
 * ];
 * $result = AsPOInsPH4::call($params);
 * ```
 */
class AsPOInsPH4
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOInsPH4', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pDia_chi' => $params['pDia_chi'] ?? null,
            'pNguoi_gd' => $params['pNguoi_gd'] ?? null,
            'pMa_httt' => $params['pMa_httt'] ?? null,
            'pTk_pt' => $params['pTk_pt'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pSo_seri' => $params['pSo_seri'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_lct' => $params['pNgay_lct'] ?? null,
            'pSua_tt' => $params['pSua_tt'] ?? false,
            'pMa_tt_po' => $params['pMa_tt_po'] ?? null,
            'pHan_ck' => $params['pHan_ck'] ?? 0.0,
            'pTl_ck' => $params['pTl_ck'] ?? 0.0,
            'pHan_tt' => $params['pHan_tt'] ?? 0.0,
            'pLs_qh' => $params['pLs_qh'] ?? 0.0,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? 0.0,
            'pT_tien_nt0' => $params['pT_tien_nt0'] ?? 0.0,
            'pT_tien0' => $params['pT_tien0'] ?? 0.0,
            'pT_cp_nt' => $params['pT_cp_nt'] ?? 0.0,
            'pT_cp' => $params['pT_cp'] ?? 0.0,
            'pT_thue_nt' => $params['pT_thue_nt'] ?? 0.0,
            'pT_thue' => $params['pT_thue'] ?? 0.0,
            'pT_tt' => $params['pT_tt'] ?? 0.0,
            'pT_tt_nt' => $params['pT_tt_nt'] ?? 0.0,
            'pT_so_luong' => $params['pT_so_luong'] ?? 0.0,
            'pPost2gl' => $params['pPost2gl'] ?? false,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pKht_tain' => $params['pKht_tain'] ?? false,
            'pLUser' => $params['pLUser'] ?? null,
        ], $connection);
    }
}
