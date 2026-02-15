<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:45
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOUpdPH4
{
    /**
     * Call stored procedure asPOUpdPH4
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOUpdPH4', [
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
            'pSua_tt' => $params['pSua_tt'] ?? null,
            'pMa_tt_po' => $params['pMa_tt_po'] ?? null,
            'pHan_ck' => $params['pHan_ck'] ?? null,
            'pTl_ck' => $params['pTl_ck'] ?? null,
            'pHan_tt' => $params['pHan_tt'] ?? null,
            'pLs_qh' => $params['pLs_qh'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pT_tien_nt0' => $params['pT_tien_nt0'] ?? null,
            'pT_tien0' => $params['pT_tien0'] ?? null,
            'pT_cp_nt' => $params['pT_cp_nt'] ?? null,
            'pT_cp' => $params['pT_cp'] ?? null,
            'pT_thue_nt' => $params['pT_thue_nt'] ?? null,
            'pT_thue' => $params['pT_thue'] ?? null,
            'pT_tt' => $params['pT_tt'] ?? null,
            'pT_tt_nt' => $params['pT_tt_nt'] ?? null,
            'pT_so_luong' => $params['pT_so_luong'] ?? null,
            'pPost2gl' => $params['pPost2gl'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pKht_tain' => $params['pKht_tain'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPOUpdPH4 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $Ma_kh
     * @param string $Dia_chi
     * @param string $Nguoi_gd
     * @param string $Ma_httt
     * @param string $Tk_pt
     * @param string $Dien_giai
     * @param string $So_seri
     * @param string $So_ct
     * @param string $Ngay_ct
     * @param string $Ngay_lct
     * @param bool $Sua_tt
     * @param string $Ma_tt_po
     * @param float $Han_ck
     * @param float $Tl_ck
     * @param float $Han_tt
     * @param float $Ls_qh
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param float $T_tien_nt0
     * @param float $T_tien0
     * @param float $T_cp_nt
     * @param float $T_cp
     * @param float $T_thue_nt
     * @param float $T_thue
     * @param float $T_tt
     * @param float $T_tt_nt
     * @param float $T_so_luong
     * @param bool $Post2gl
     * @param string $Trang_thai
     * @param bool $Kht_tain
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $Ma_kh = null, string $Dia_chi = null, string $Nguoi_gd = null, string $Ma_httt = null, string $Tk_pt = null, string $Dien_giai = null, string $So_seri = null, string $So_ct = null, string $Ngay_ct = null, string $Ngay_lct = null, bool $Sua_tt = null, string $Ma_tt_po = null, float $Han_ck = null, float $Tl_ck = null, float $Han_tt = null, float $Ls_qh = null, string $Ma_nt = null, float $Ty_gia = null, float $T_tien_nt0 = null, float $T_tien0 = null, float $T_cp_nt = null, float $T_cp = null, float $T_thue_nt = null, float $T_thue = null, float $T_tt = null, float $T_tt_nt = null, float $T_so_luong = null, bool $Post2gl = null, string $Trang_thai = null, bool $Kht_tain = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pMa_kh' => $Ma_kh,
            'pDia_chi' => $Dia_chi,
            'pNguoi_gd' => $Nguoi_gd,
            'pMa_httt' => $Ma_httt,
            'pTk_pt' => $Tk_pt,
            'pDien_giai' => $Dien_giai,
            'pSo_seri' => $So_seri,
            'pSo_ct' => $So_ct,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_lct' => $Ngay_lct,
            'pSua_tt' => $Sua_tt,
            'pMa_tt_po' => $Ma_tt_po,
            'pHan_ck' => $Han_ck,
            'pTl_ck' => $Tl_ck,
            'pHan_tt' => $Han_tt,
            'pLs_qh' => $Ls_qh,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pT_tien_nt0' => $T_tien_nt0,
            'pT_tien0' => $T_tien0,
            'pT_cp_nt' => $T_cp_nt,
            'pT_cp' => $T_cp,
            'pT_thue_nt' => $T_thue_nt,
            'pT_thue' => $T_thue,
            'pT_tt' => $T_tt,
            'pT_tt_nt' => $T_tt_nt,
            'pT_so_luong' => $T_so_luong,
            'pPost2gl' => $Post2gl,
            'pTrang_thai' => $Trang_thai,
            'pKht_tain' => $Kht_tain,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
