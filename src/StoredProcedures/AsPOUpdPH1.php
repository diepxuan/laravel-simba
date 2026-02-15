<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:22
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOUpdPH1
{
    /**
     * Call stored procedure asPOUpdPH1
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOUpdPH1', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pNguoi_gd' => $params['pNguoi_gd'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_lct' => $params['pNgay_lct'] ?? null,
            'pMa_tt_po' => $params['pMa_tt_po'] ?? null,
            'pHan_ck' => $params['pHan_ck'] ?? null,
            'pTl_ck' => $params['pTl_ck'] ?? null,
            'pHan_tt' => $params['pHan_tt'] ?? null,
            'pLs_qh' => $params['pLs_qh'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pT_tien_nt0' => $params['pT_tien_nt0'] ?? null,
            'pT_tien0' => $params['pT_tien0'] ?? null,
            'pT_thue' => $params['pT_thue'] ?? null,
            'pT_thue_nt' => $params['pT_thue_nt'] ?? null,
            'pT_tt' => $params['pT_tt'] ?? null,
            'pT_tt_nt' => $params['pT_tt_nt'] ?? null,
            'pT_so_luong' => $params['pT_so_luong'] ?? null,
            'pSua_tien' => $params['pSua_tien'] ?? null,
            'pSua_tt' => $params['pSua_tt'] ?? null,
            'pPost2gl' => $params['pPost2gl'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPOUpdPH1 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $Ma_kh
     * @param string $Nguoi_gd
     * @param string $Ma_hd
     * @param string $Dien_giai
     * @param string $So_ct
     * @param string $Ngay_ct
     * @param string $Ngay_lct
     * @param string $Ma_tt_po
     * @param float $Han_ck
     * @param float $Tl_ck
     * @param float $Han_tt
     * @param float $Ls_qh
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param float $T_tien_nt0
     * @param float $T_tien0
     * @param float $T_thue
     * @param float $T_thue_nt
     * @param float $T_tt
     * @param float $T_tt_nt
     * @param float $T_so_luong
     * @param bool $Sua_tien
     * @param bool $Sua_tt
     * @param bool $Post2gl
     * @param string $Trang_thai
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $Ma_kh = null, string $Nguoi_gd = null, string $Ma_hd = null, string $Dien_giai = null, string $So_ct = null, string $Ngay_ct = null, string $Ngay_lct = null, string $Ma_tt_po = null, float $Han_ck = null, float $Tl_ck = null, float $Han_tt = null, float $Ls_qh = null, string $Ma_nt = null, float $Ty_gia = null, float $T_tien_nt0 = null, float $T_tien0 = null, float $T_thue = null, float $T_thue_nt = null, float $T_tt = null, float $T_tt_nt = null, float $T_so_luong = null, bool $Sua_tien = null, bool $Sua_tt = null, bool $Post2gl = null, string $Trang_thai = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pMa_kh' => $Ma_kh,
            'pNguoi_gd' => $Nguoi_gd,
            'pMa_hd' => $Ma_hd,
            'pDien_giai' => $Dien_giai,
            'pSo_ct' => $So_ct,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_lct' => $Ngay_lct,
            'pMa_tt_po' => $Ma_tt_po,
            'pHan_ck' => $Han_ck,
            'pTl_ck' => $Tl_ck,
            'pHan_tt' => $Han_tt,
            'pLs_qh' => $Ls_qh,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pT_tien_nt0' => $T_tien_nt0,
            'pT_tien0' => $T_tien0,
            'pT_thue' => $T_thue,
            'pT_thue_nt' => $T_thue_nt,
            'pT_tt' => $T_tt,
            'pT_tt_nt' => $T_tt_nt,
            'pT_so_luong' => $T_so_luong,
            'pSua_tien' => $Sua_tien,
            'pSua_tt' => $Sua_tt,
            'pPost2gl' => $Post2gl,
            'pTrang_thai' => $Trang_thai,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
