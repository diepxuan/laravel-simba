<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOUpdPH5
{
    /**
     * Call stored procedure asSOUpdPH5
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdPH5', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pSo_seri_mhd' => $params['pSo_seri_mhd'] ?? null,
            'pSo_seri' => $params['pSo_seri'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_lct' => $params['pNgay_lct'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pTen_kh_vat' => $params['pTen_kh_vat'] ?? null,
            'pDia_chi_vat' => $params['pDia_chi_vat'] ?? null,
            'pMa_so_thue' => $params['pMa_so_thue'] ?? null,
            'pNguoi_gd' => $params['pNguoi_gd'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pTk_pt' => $params['pTk_pt'] ?? null,
            'pTk_thue' => $params['pTk_thue'] ?? null,
            'pTk_ck_ds' => $params['pTk_ck_ds'] ?? null,
            'pMa_httt' => $params['pMa_httt'] ?? null,
            'pHttt' => $params['pHttt'] ?? null,
            'pMa_tt' => $params['pMa_tt'] ?? null,
            'pHan_ck' => $params['pHan_ck'] ?? null,
            'pTl_ck' => $params['pTl_ck'] ?? null,
            'pHan_tt' => $params['pHan_tt'] ?? null,
            'pLs_qh' => $params['pLs_qh'] ?? null,
            'pSua_ck' => $params['pSua_ck'] ?? null,
            'pSua_thue' => $params['pSua_thue'] ?? null,
            'pT_tien2' => $params['pT_tien2'] ?? null,
            'pT_tien_nt2' => $params['pT_tien_nt2'] ?? null,
            'pT_thue' => $params['pT_thue'] ?? null,
            'pT_thue_nt' => $params['pT_thue_nt'] ?? null,
            'pT_ck' => $params['pT_ck'] ?? null,
            'pT_ck_nt' => $params['pT_ck_nt'] ?? null,
            'pT_ck_ds' => $params['pT_ck_ds'] ?? null,
            'pT_ck_ds_nt' => $params['pT_ck_ds_nt'] ?? null,
            'pT_tt' => $params['pT_tt'] ?? null,
            'pT_tt_nt' => $params['pT_tt_nt'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pPost2gl' => $params['pPost2gl'] ?? null,
            'pPost2in' => $params['pPost2in'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpdPH5 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $So_seri_mhd
     * @param string $So_seri
     * @param string $So_ct
     * @param string $Ngay_ct
     * @param string $Ngay_lct
     * @param string $Ma_kh
     * @param string $Ten_kh_vat
     * @param string $Dia_chi_vat
     * @param string $Ma_so_thue
     * @param string $Nguoi_gd
     * @param string $Dien_giai
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param string $Tk_pt
     * @param string $Tk_thue
     * @param string $Tk_ck_ds
     * @param string $Ma_httt
     * @param string $Httt
     * @param string $Ma_tt
     * @param float $Han_ck
     * @param float $Tl_ck
     * @param float $Han_tt
     * @param float $Ls_qh
     * @param bool $Sua_ck
     * @param bool $Sua_thue
     * @param float $T_tien2
     * @param float $T_tien_nt2
     * @param float $T_thue
     * @param float $T_thue_nt
     * @param float $T_ck
     * @param float $T_ck_nt
     * @param float $T_ck_ds
     * @param float $T_ck_ds_nt
     * @param float $T_tt
     * @param float $T_tt_nt
     * @param string $Trang_thai
     * @param string $Post2gl
     * @param string $Post2in
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $So_seri_mhd = null, string $So_seri = null, string $So_ct = null, string $Ngay_ct = null, string $Ngay_lct = null, string $Ma_kh = null, string $Ten_kh_vat = null, string $Dia_chi_vat = null, string $Ma_so_thue = null, string $Nguoi_gd = null, string $Dien_giai = null, string $Ma_nt = null, float $Ty_gia = null, string $Tk_pt = null, string $Tk_thue = null, string $Tk_ck_ds = null, string $Ma_httt = null, string $Httt = null, string $Ma_tt = null, float $Han_ck = null, float $Tl_ck = null, float $Han_tt = null, float $Ls_qh = null, bool $Sua_ck = null, bool $Sua_thue = null, float $T_tien2 = null, float $T_tien_nt2 = null, float $T_thue = null, float $T_thue_nt = null, float $T_ck = null, float $T_ck_nt = null, float $T_ck_ds = null, float $T_ck_ds_nt = null, float $T_tt = null, float $T_tt_nt = null, string $Trang_thai = null, string $Post2gl = null, string $Post2in = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pSo_seri_mhd' => $So_seri_mhd,
            'pSo_seri' => $So_seri,
            'pSo_ct' => $So_ct,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_lct' => $Ngay_lct,
            'pMa_kh' => $Ma_kh,
            'pTen_kh_vat' => $Ten_kh_vat,
            'pDia_chi_vat' => $Dia_chi_vat,
            'pMa_so_thue' => $Ma_so_thue,
            'pNguoi_gd' => $Nguoi_gd,
            'pDien_giai' => $Dien_giai,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pTk_pt' => $Tk_pt,
            'pTk_thue' => $Tk_thue,
            'pTk_ck_ds' => $Tk_ck_ds,
            'pMa_httt' => $Ma_httt,
            'pHttt' => $Httt,
            'pMa_tt' => $Ma_tt,
            'pHan_ck' => $Han_ck,
            'pTl_ck' => $Tl_ck,
            'pHan_tt' => $Han_tt,
            'pLs_qh' => $Ls_qh,
            'pSua_ck' => $Sua_ck,
            'pSua_thue' => $Sua_thue,
            'pT_tien2' => $T_tien2,
            'pT_tien_nt2' => $T_tien_nt2,
            'pT_thue' => $T_thue,
            'pT_thue_nt' => $T_thue_nt,
            'pT_ck' => $T_ck,
            'pT_ck_nt' => $T_ck_nt,
            'pT_ck_ds' => $T_ck_ds,
            'pT_ck_ds_nt' => $T_ck_ds_nt,
            'pT_tt' => $T_tt,
            'pT_tt_nt' => $T_tt_nt,
            'pTrang_thai' => $Trang_thai,
            'pPost2gl' => $Post2gl,
            'pPost2in' => $Post2in,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
