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
 * Class AsINInsPH1
 * 
 * Stored procedure: asINInsPH1
 * Purpose: 
 * 
 * Parameters:
 * - @pMa_cty (nvarchar(3)): input parameter.
 * - @pStt_rec (nvarchar(20)): input parameter.
 * - @pMa_ct (nvarchar(3)): input parameter.
 * - @pMa_gd (nvarchar(1)): input parameter.
 * - @pNgay_ct (smalldatetime): input parameter.
 * - @pNgay_lct (smalldatetime): input parameter.
 * - @pSo_ct (nvarchar(12)): input parameter.
 * - @pMa_kh (nvarchar(20)): input parameter.
 * - @pTen_kh (nvarchar(100)): input parameter.
 * - @pDia_chi (nvarchar(255)): input parameter.
 * - @pNguoi_gd (nvarchar(30)): input parameter.
 * - @pDien_giai (nvarchar(255)): input parameter.
 * - @pMa_nx (nvarchar(20)): input parameter.
 * - @pMa_nt (nvarchar(3)): input parameter.
 * - @pTy_gia (decimal(19,4)): input parameter.
 * - @pT_tien_nt (decimal(19,4)): input parameter.
 * - @pT_tien (decimal(19,4)): input parameter.
 * - @pT_so_luong (decimal(19,4)): input parameter.
 * - @pPN_GTB (bit): input parameter.
 * - @pTrang_thai (nvarchar(1)): input parameter.
 * - @pPost2gl (bit): input parameter.
 * - @pPost2in (bit): input parameter.
 * - @pGia_thanh (bit): input parameter.
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
 * $result = AsINInsPH1::call($params);
 * ```
 */
class AsINInsPH1
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsPH1', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMa_gd' => $params['pMa_gd'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_lct' => $params['pNgay_lct'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pTen_kh' => $params['pTen_kh'] ?? null,
            'pDia_chi' => $params['pDia_chi'] ?? null,
            'pNguoi_gd' => $params['pNguoi_gd'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pMa_nx' => $params['pMa_nx'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? 0.0,
            'pT_tien_nt' => $params['pT_tien_nt'] ?? 0.0,
            'pT_tien' => $params['pT_tien'] ?? 0.0,
            'pT_so_luong' => $params['pT_so_luong'] ?? 0.0,
            'pPN_GTB' => $params['pPN_GTB'] ?? false,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pPost2gl' => $params['pPost2gl'] ?? false,
            'pPost2in' => $params['pPost2in'] ?? false,
            'pGia_thanh' => $params['pGia_thanh'] ?? false,
            'pLUser' => $params['pLUser'] ?? null,
        ], $connection);
    }
}
