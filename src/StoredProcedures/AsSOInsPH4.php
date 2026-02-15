<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:20:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOInsPH4
{
    /**
     * Call stored procedure asSOInsPH4
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsPH4', $params, $connection);
    }

    /**
     * Call stored procedure asSOInsPH4 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $Ma_gd
     * @param string $So_seri_mhd
     * @param string $So_seri
     * @param string $So_hd
     * @param string $So_ct
     * @param string $Ngay_ct
     * @param string $Ngay_lct
     * @param string $Ngay_hd
     * @param string $Ma_kh
     * @param string $Ten_kh_vat
     * @param string $Dia_chi_vat
     * @param string $Ma_so_thue
     * @param string $Nguoi_gd
     * @param string $Dien_giai
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param string $Ma_httt
     * @param string $Tk_pt
     * @param string $Tk_thue
     * @param string $Tk_ck_ds
     * @param float $Han_ck
     * @param float $Tl_ck
     * @param float $Han_tt
     * @param float $Ls_qh
     * @param bool $Gia_tb
     * @param bool $Sua_tien
     * @param bool $Sua_ck
     * @param bool $Sua_thue
     * @param string $So_pn
     * @param string $Ngay_pn
     * @param string $Dia_chi_pn
     * @param string $Nguoi_gd_pn
     * @param string $Tel_pn
     * @param string $Dien_giai_pn
     * @param float $T_tien2
     * @param float $T_tien_nt2
     * @param float $T_thue
     * @param float $T_thue_nt
     * @param bool $kht_tain
     * @param float $T_ck
     * @param float $T_ck_nt
     * @param float $T_ck_ds
     * @param float $T_ck_ds_nt
     * @param float $T_tt
     * @param float $T_tt_nt
     * @param float $T_so_luong
     * @param float $T_tien
     * @param float $T_tien_nt
     * @param bool $Tao_tu_hd
     * @param string $Trang_thai
     * @param string $Post2gl
     * @param string $Post2in
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $Ma_gd = null, string $So_seri_mhd = null, string $So_seri = null, string $So_hd = null, string $So_ct = null, string $Ngay_ct = null, string $Ngay_lct = null, string $Ngay_hd = null, string $Ma_kh = null, string $Ten_kh_vat = null, string $Dia_chi_vat = null, string $Ma_so_thue = null, string $Nguoi_gd = null, string $Dien_giai = null, string $Ma_nt = null, float $Ty_gia = null, string $Ma_httt = null, string $Tk_pt = null, string $Tk_thue = null, string $Tk_ck_ds = null, float $Han_ck = null, float $Tl_ck = null, float $Han_tt = null, float $Ls_qh = null, bool $Gia_tb = null, bool $Sua_tien = null, bool $Sua_ck = null, bool $Sua_thue = null, string $So_pn = null, string $Ngay_pn = null, string $Dia_chi_pn = null, string $Nguoi_gd_pn = null, string $Tel_pn = null, string $Dien_giai_pn = null, float $T_tien2 = null, float $T_tien_nt2 = null, float $T_thue = null, float $T_thue_nt = null, bool $kht_tain = null, float $T_ck = null, float $T_ck_nt = null, float $T_ck_ds = null, float $T_ck_ds_nt = null, float $T_tt = null, float $T_tt_nt = null, float $T_so_luong = null, float $T_tien = null, float $T_tien_nt = null, bool $Tao_tu_hd = null, string $Trang_thai = null, string $Post2gl = null, string $Post2in = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pMa_gd' => $Ma_gd,
            'pSo_seri_mhd' => $So_seri_mhd,
            'pSo_seri' => $So_seri,
            'pSo_hd' => $So_hd,
            'pSo_ct' => $So_ct,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_lct' => $Ngay_lct,
            'pNgay_hd' => $Ngay_hd,
            'pMa_kh' => $Ma_kh,
            'pTen_kh_vat' => $Ten_kh_vat,
            'pDia_chi_vat' => $Dia_chi_vat,
            'pMa_so_thue' => $Ma_so_thue,
            'pNguoi_gd' => $Nguoi_gd,
            'pDien_giai' => $Dien_giai,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pMa_httt' => $Ma_httt,
            'pTk_pt' => $Tk_pt,
            'pTk_thue' => $Tk_thue,
            'pTk_ck_ds' => $Tk_ck_ds,
            'pHan_ck' => $Han_ck,
            'pTl_ck' => $Tl_ck,
            'pHan_tt' => $Han_tt,
            'pLs_qh' => $Ls_qh,
            'pGia_tb' => $Gia_tb,
            'pSua_tien' => $Sua_tien,
            'pSua_ck' => $Sua_ck,
            'pSua_thue' => $Sua_thue,
            'pSo_pn' => $So_pn,
            'pNgay_pn' => $Ngay_pn,
            'pDia_chi_pn' => $Dia_chi_pn,
            'pNguoi_gd_pn' => $Nguoi_gd_pn,
            'pTel_pn' => $Tel_pn,
            'pDien_giai_pn' => $Dien_giai_pn,
            'pT_tien2' => $T_tien2,
            'pT_tien_nt2' => $T_tien_nt2,
            'pT_thue' => $T_thue,
            'pT_thue_nt' => $T_thue_nt,
            'pkht_tain' => $kht_tain,
            'pT_ck' => $T_ck,
            'pT_ck_nt' => $T_ck_nt,
            'pT_ck_ds' => $T_ck_ds,
            'pT_ck_ds_nt' => $T_ck_ds_nt,
            'pT_tt' => $T_tt,
            'pT_tt_nt' => $T_tt_nt,
            'pT_so_luong' => $T_so_luong,
            'pT_tien' => $T_tien,
            'pT_tien_nt' => $T_tien_nt,
            'pTao_tu_hd' => $Tao_tu_hd,
            'pTrang_thai' => $Trang_thai,
            'pPost2gl' => $Post2gl,
            'pPost2in' => $Post2in,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
