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
use Diepxuan\Simba\Helper\ParamHelper;
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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsPH1', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pMa_gd' => $paramObj->pMa_gd ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_lct' => $paramObj->pNgay_lct ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pTen_kh' => $paramObj->pTen_kh ?? null,
            'pDia_chi' => $paramObj->pDia_chi ?? null,
            'pNguoi_gd' => $paramObj->pNguoi_gd ?? null,
            'pDien_giai' => $paramObj->pDien_giai ?? null,
            'pMa_nx' => $paramObj->pMa_nx ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pTy_gia' => $paramObj->pTy_gia ?? 0.0,
            'pT_tien_nt' => $paramObj->pT_tien_nt ?? 0.0,
            'pT_tien' => $paramObj->pT_tien ?? 0.0,
            'pT_so_luong' => $paramObj->pT_so_luong ?? 0.0,
            'pPN_GTB' => $paramObj->pPN_GTB ?? false,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pPost2gl' => $paramObj->pPost2gl ?? false,
            'pPost2in' => $paramObj->pPost2in ?? false,
            'pGia_thanh' => $paramObj->pGia_thanh ?? false,
            'pLUser' => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
