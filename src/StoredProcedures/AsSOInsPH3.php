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

class AsSOInsPH3
{
    /**
     * Call stored procedure asSOInsPH3
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsPH3', $params, $connection);
    }

    /**
     * Call stored procedure asSOInsPH3 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $Ma_gd
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
     * @param string $Nguoi_nhan
     * @param string $Cty_nhan
     * @param string $Dc_nhan
     * @param string $Tel_nhan
     * @param string $Ma_nvt
     * @param string $Ma_pt
     * @param string $Bien_so
     * @param string $Nguoi_lai
     * @param string $Ma_td
     * @param string $Ten_td
     * @param float $Km
     * @param bool $Gia_dd
     * @param bool $Ck_st
     * @param bool $Gia_st
     * @param bool $Sua_tien
     * @param bool $Sua_ck
     * @param bool $Sua_thue
     * @param bool $Sua_tt
     * @param string $So_px
     * @param string $Ngay_px
     * @param string $Dia_chi_px
     * @param string $Nguoi_gd_px
     * @param string $Tel_px
     * @param string $Dien_giai_px
     * @param float $T_tien
     * @param float $T_tien_nt
     * @param float $T_tien2
     * @param float $T_tien_nt2
     * @param float $T_thue
     * @param float $T_thue_nt
     * @param float $Tl_ck_ds
     * @param float $T_ck
     * @param float $T_ck_nt
     * @param float $T_ck_ds
     * @param float $T_ck_ds_nt
     * @param float $T_tt
     * @param float $T_tt_nt
     * @param float $t_so_luong
     * @param bool $Tao_tu_px
     * @param string $Trang_thai
     * @param string $Post2gl
     * @param string $Post2in
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $Ma_gd = null, string $So_seri = null, string $So_ct = null, string $Ngay_ct = null, string $Ngay_lct = null, string $Ma_kh = null, string $Ten_kh_vat = null, string $Dia_chi_vat = null, string $Ma_so_thue = null, string $Nguoi_gd = null, string $Dien_giai = null, string $Ma_nt = null, float $Ty_gia = null, string $Tk_pt = null, string $Tk_thue = null, string $Tk_ck_ds = null, string $Ma_httt = null, string $Httt = null, string $Ma_tt = null, float $Han_ck = null, float $Tl_ck = null, float $Han_tt = null, float $Ls_qh = null, string $Nguoi_nhan = null, string $Cty_nhan = null, string $Dc_nhan = null, string $Tel_nhan = null, string $Ma_nvt = null, string $Ma_pt = null, string $Bien_so = null, string $Nguoi_lai = null, string $Ma_td = null, string $Ten_td = null, float $Km = null, bool $Gia_dd = null, bool $Ck_st = null, bool $Gia_st = null, bool $Sua_tien = null, bool $Sua_ck = null, bool $Sua_thue = null, bool $Sua_tt = null, string $So_px = null, string $Ngay_px = null, string $Dia_chi_px = null, string $Nguoi_gd_px = null, string $Tel_px = null, string $Dien_giai_px = null, float $T_tien = null, float $T_tien_nt = null, float $T_tien2 = null, float $T_tien_nt2 = null, float $T_thue = null, float $T_thue_nt = null, float $Tl_ck_ds = null, float $T_ck = null, float $T_ck_nt = null, float $T_ck_ds = null, float $T_ck_ds_nt = null, float $T_tt = null, float $T_tt_nt = null, float $t_so_luong = null, bool $Tao_tu_px = null, string $Trang_thai = null, string $Post2gl = null, string $Post2in = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pMa_gd' => $Ma_gd,
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
            'pNguoi_nhan' => $Nguoi_nhan,
            'pCty_nhan' => $Cty_nhan,
            'pDc_nhan' => $Dc_nhan,
            'pTel_nhan' => $Tel_nhan,
            'pMa_nvt' => $Ma_nvt,
            'pMa_pt' => $Ma_pt,
            'pBien_so' => $Bien_so,
            'pNguoi_lai' => $Nguoi_lai,
            'pMa_td' => $Ma_td,
            'pTen_td' => $Ten_td,
            'pKm' => $Km,
            'pGia_dd' => $Gia_dd,
            'pCk_st' => $Ck_st,
            'pGia_st' => $Gia_st,
            'pSua_tien' => $Sua_tien,
            'pSua_ck' => $Sua_ck,
            'pSua_thue' => $Sua_thue,
            'pSua_tt' => $Sua_tt,
            'pSo_px' => $So_px,
            'pNgay_px' => $Ngay_px,
            'pDia_chi_px' => $Dia_chi_px,
            'pNguoi_gd_px' => $Nguoi_gd_px,
            'pTel_px' => $Tel_px,
            'pDien_giai_px' => $Dien_giai_px,
            'pT_tien' => $T_tien,
            'pT_tien_nt' => $T_tien_nt,
            'pT_tien2' => $T_tien2,
            'pT_tien_nt2' => $T_tien_nt2,
            'pT_thue' => $T_thue,
            'pT_thue_nt' => $T_thue_nt,
            'pTl_ck_ds' => $Tl_ck_ds,
            'pT_ck' => $T_ck,
            'pT_ck_nt' => $T_ck_nt,
            'pT_ck_ds' => $T_ck_ds,
            'pT_ck_ds_nt' => $T_ck_ds_nt,
            'pT_tt' => $T_tt,
            'pT_tt_nt' => $T_tt_nt,
            'pt_so_luong' => $t_so_luong,
            'pTao_tu_px' => $Tao_tu_px,
            'pTrang_thai' => $Trang_thai,
            'pPost2gl' => $Post2gl,
            'pPost2in' => $Post2in,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
