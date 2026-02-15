<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOUpdPH1
{
    /**
     * Call stored procedure asSOUpdPH1
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdPH1', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pTen_kh_vat' => $params['pTen_kh_vat'] ?? null,
            'pDia_chi_vat' => $params['pDia_chi_vat'] ?? null,
            'pMa_so_thue' => $params['pMa_so_thue'] ?? null,
            'pNguoi_gd' => $params['pNguoi_gd'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pMa_tt' => $params['pMa_tt'] ?? null,
            'pHan_ck' => $params['pHan_ck'] ?? null,
            'pTl_ck' => $params['pTl_ck'] ?? null,
            'pHan_tt' => $params['pHan_tt'] ?? null,
            'pLs_qh' => $params['pLs_qh'] ?? null,
            'pDien_giai' => $params['pDien_giai'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_hh' => $params['pNgay_hh'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pCk_st' => $params['pCk_st'] ?? null,
            'pGia_st' => $params['pGia_st'] ?? null,
            'pMa_dckh' => $params['pMa_dckh'] ?? null,
            'pNguoi_nhan' => $params['pNguoi_nhan'] ?? null,
            'pCty_nhan' => $params['pCty_nhan'] ?? null,
            'pDc_nhan' => $params['pDc_nhan'] ?? null,
            'pTel_nhan' => $params['pTel_nhan'] ?? null,
            'pMa_nvt' => $params['pMa_nvt'] ?? null,
            'pMa_pt' => $params['pMa_pt'] ?? null,
            'pBien_so' => $params['pBien_so'] ?? null,
            'pNguoi_lai' => $params['pNguoi_lai'] ?? null,
            'pMa_td' => $params['pMa_td'] ?? null,
            'pTen_td' => $params['pTen_td'] ?? null,
            'pKm' => $params['pKm'] ?? null,
            'pTk_pt' => $params['pTk_pt'] ?? null,
            'pTk_thue' => $params['pTk_thue'] ?? null,
            'pTk_ck_ds' => $params['pTk_ck_ds'] ?? null,
            'pT_tien2' => $params['pT_tien2'] ?? null,
            'pT_tien_nt2' => $params['pT_tien_nt2'] ?? null,
            'pT_thue' => $params['pT_thue'] ?? null,
            'pT_thue_nt' => $params['pT_thue_nt'] ?? null,
            'pT_ck' => $params['pT_ck'] ?? null,
            'pT_ck_nt' => $params['pT_ck_nt'] ?? null,
            'pTl_ck_ds' => $params['pTl_ck_ds'] ?? null,
            'pT_ck_ds' => $params['pT_ck_ds'] ?? null,
            'pT_ck_ds_nt' => $params['pT_ck_ds_nt'] ?? null,
            'pT_tt' => $params['pT_tt'] ?? null,
            'pT_tt_nt' => $params['pT_tt_nt'] ?? null,
            'pt_so_luong' => $params['pt_so_luong'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpdPH1 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Ma_ct
     * @param string $Ma_kh
     * @param string $Ten_kh_vat
     * @param string $Dia_chi_vat
     * @param string $Ma_so_thue
     * @param string $Nguoi_gd
     * @param string $Trang_thai
     * @param string $Ma_tt
     * @param float $Han_ck
     * @param float $Tl_ck
     * @param float $Han_tt
     * @param float $Ls_qh
     * @param string $Dien_giai
     * @param string $So_ct
     * @param string $Ngay_ct
     * @param string $Ngay_hh
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param bool $Ck_st
     * @param bool $Gia_st
     * @param string $Ma_dckh
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
     * @param string $Tk_pt
     * @param string $Tk_thue
     * @param string $Tk_ck_ds
     * @param float $T_tien2
     * @param float $T_tien_nt2
     * @param float $T_thue
     * @param float $T_thue_nt
     * @param float $T_ck
     * @param float $T_ck_nt
     * @param float $Tl_ck_ds
     * @param float $T_ck_ds
     * @param float $T_ck_ds_nt
     * @param float $T_tt
     * @param float $T_tt_nt
     * @param float $t_so_luong
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $Ma_kh = null, string $Ten_kh_vat = null, string $Dia_chi_vat = null, string $Ma_so_thue = null, string $Nguoi_gd = null, string $Trang_thai = null, string $Ma_tt = null, float $Han_ck = null, float $Tl_ck = null, float $Han_tt = null, float $Ls_qh = null, string $Dien_giai = null, string $So_ct = null, string $Ngay_ct = null, string $Ngay_hh = null, string $Ma_nt = null, float $Ty_gia = null, bool $Ck_st = null, bool $Gia_st = null, string $Ma_dckh = null, string $Nguoi_nhan = null, string $Cty_nhan = null, string $Dc_nhan = null, string $Tel_nhan = null, string $Ma_nvt = null, string $Ma_pt = null, string $Bien_so = null, string $Nguoi_lai = null, string $Ma_td = null, string $Ten_td = null, float $Km = null, string $Tk_pt = null, string $Tk_thue = null, string $Tk_ck_ds = null, float $T_tien2 = null, float $T_tien_nt2 = null, float $T_thue = null, float $T_thue_nt = null, float $T_ck = null, float $T_ck_nt = null, float $Tl_ck_ds = null, float $T_ck_ds = null, float $T_ck_ds_nt = null, float $T_tt = null, float $T_tt_nt = null, float $t_so_luong = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pMa_ct' => $Ma_ct,
            'pMa_kh' => $Ma_kh,
            'pTen_kh_vat' => $Ten_kh_vat,
            'pDia_chi_vat' => $Dia_chi_vat,
            'pMa_so_thue' => $Ma_so_thue,
            'pNguoi_gd' => $Nguoi_gd,
            'pTrang_thai' => $Trang_thai,
            'pMa_tt' => $Ma_tt,
            'pHan_ck' => $Han_ck,
            'pTl_ck' => $Tl_ck,
            'pHan_tt' => $Han_tt,
            'pLs_qh' => $Ls_qh,
            'pDien_giai' => $Dien_giai,
            'pSo_ct' => $So_ct,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_hh' => $Ngay_hh,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pCk_st' => $Ck_st,
            'pGia_st' => $Gia_st,
            'pMa_dckh' => $Ma_dckh,
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
            'pTk_pt' => $Tk_pt,
            'pTk_thue' => $Tk_thue,
            'pTk_ck_ds' => $Tk_ck_ds,
            'pT_tien2' => $T_tien2,
            'pT_tien_nt2' => $T_tien_nt2,
            'pT_thue' => $T_thue,
            'pT_thue_nt' => $T_thue_nt,
            'pT_ck' => $T_ck,
            'pT_ck_nt' => $T_ck_nt,
            'pTl_ck_ds' => $Tl_ck_ds,
            'pT_ck_ds' => $T_ck_ds,
            'pT_ck_ds_nt' => $T_ck_ds_nt,
            'pT_tt' => $T_tt,
            'pT_tt_nt' => $T_tt_nt,
            'pt_so_luong' => $t_so_luong,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
