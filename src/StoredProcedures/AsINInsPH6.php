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
 * Class AsINInsPH6
 * 
 * Stored procedure: asINInsPH6
 * Purpose: ================================================
 * 
 * Tham số:
 * - @pMa_cty (nvarchar(3)): Tham số đầu vào.
 * - @pStt_rec (nvarchar(20)): Tham số đầu vào.
 * - @pMa_ct (nvarchar(3)): Tham số đầu vào.
 * - @pMa_gd (nvarchar(1)): Tham số đầu vào.
 * - @pNgay_ct (smalldatetime): Tham số đầu vào.
 * - @pNgay_lct (smalldatetime): Tham số đầu vào.
 * - @pSo_ct (nvarchar(12)): Tham số đầu vào.
 * - @pNgay_ctn (smalldatetime): Tham số đầu vào.
 * - @pSo_ctn (nvarchar(12)): Tham số đầu vào.
 * - @pMa_kh (nvarchar(20)): Tham số đầu vào.
 * - @pNguoi_gd (nvarchar(30)): Tham số đầu vào.
 * - @pDien_giai (nvarchar(255)): Tham số đầu vào.
 * - @pPN_GTB (bit): Tham số đầu vào.
 * - @pPX_GDD (bit): Tham số đầu vào.
 * - @pTk_vt_lrtd (nvarchar(20)): Tham số đầu vào.
 * - @pTk_lrtd (nvarchar(20)): Tham số đầu vào.
 * - @pT_so_luong (decimal(19): Tham số đầu vào.
 * - @pMa_nt (nvarchar(3)): Tham số đầu vào.
 * - @pTy_gia (decimal(19): Tham số đầu vào.
 * - @pT_tien_nt (decimal(19): Tham số đầu vào.
 * - @pT_tien (decimal(19): Tham số đầu vào.
 * - @pPost2gl (bit): Tham số đầu vào.
 * - @pPost2in (bit): Tham số đầu vào.
 * - @pLUser (nvarchar(20)): Tham số đầu vào.
 * - @pRet (int OUTPUT): Tham số output (không được xử lý bởi ProcedureCaller hiện tại).
 * 
 * Giá trị mặc định: Không có.
 * 
 * Kết quả trả về: Không có result set (chỉ thực hiện insert).
 * 
 * Example call:
 * ```php
 * $params = [
            'pMa_cty' => '',
            'pStt_rec' => '',
            'pMa_ct' => '',
            'pMa_gd' => '',
            'pNgay_ct' => '',
            'pNgay_lct' => '',
            'pSo_ct' => '',
            'pNgay_ctn' => '',
            'pSo_ctn' => '',
            'pMa_kh' => '',
            'pNguoi_gd' => '',
            'pDien_giai' => '',
            'pPN_GTB' => '',
            'pPX_GDD' => '',
            'pTk_vt_lrtd' => '',
            'pTk_lrtd' => '',
            'pT_so_luong' => '',
            'pMa_nt' => '',
            'pTy_gia' => '',
            'pT_tien_nt' => '',
            'pT_tien' => '',
            'pPost2gl' => '',
            'pPost2in' => '',
            'pLUser' => '',
 * ];
 * $result = AsINInsPH6::call($params);
 * ```
 */
class AsINInsPH6
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsPH6', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMa_gd' => $params['pMa_gd'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_lct' => $params['pNgay_lct'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ctn' => $params['pNgay_ctn'] ?? null,
            'pSo_ctn' => $params['pSo_ctn'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pNguoi_gd' => $params['pNguoi_gd'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pPN_GTB' => $params['pPN_GTB'] ?? null,
            'pPX_GDD' => $params['pPX_GDD'] ?? null,
            'pTk_vt_lrtd' => $params['pTk_vt_lrtd'] ?? null,
            'pTk_lrtd' => $params['pTk_lrtd'] ?? null,
            'pT_so_luong' => $params['pT_so_luong'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pT_tien_nt' => $params['pT_tien_nt'] ?? null,
            'pT_tien' => $params['pT_tien'] ?? null,
            'pPost2gl' => $params['pPost2gl'] ?? null,
            'pPost2in' => $params['pPost2in'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
        ], $connection);
    }
}
