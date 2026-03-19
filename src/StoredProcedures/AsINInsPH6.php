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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsPH6', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pMa_gd' => $paramObj->pMa_gd ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_lct' => $paramObj->pNgay_lct ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pNgay_ctn' => $paramObj->pNgay_ctn ?? null,
            'pSo_ctn' => $paramObj->pSo_ctn ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pNguoi_gd' => $paramObj->pNguoi_gd ?? null,
            'pDien_giai' => $paramObj->pDien_giai ?? null,
            'pPN_GTB' => $paramObj->pPN_GTB ?? null,
            'pPX_GDD' => $paramObj->pPX_GDD ?? null,
            'pTk_vt_lrtd' => $paramObj->pTk_vt_lrtd ?? null,
            'pTk_lrtd' => $paramObj->pTk_lrtd ?? null,
            'pT_so_luong' => $paramObj->pT_so_luong ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pTy_gia' => $paramObj->pTy_gia ?? null,
            'pT_tien_nt' => $paramObj->pT_tien_nt ?? null,
            'pT_tien' => $paramObj->pT_tien ?? null,
            'pPost2gl' => $paramObj->pPost2gl ?? null,
            'pPost2in' => $paramObj->pPost2in ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
        ], $connection);
    }
}
