<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:42
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsPOUpdPH5
{
    /**
     * Call stored procedure asPOUpdPH5
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOUpdPH5', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pSo_seri_mhd' => $paramObj->pSo_seri_mhd ?? null,
            'pSo_seri' => $paramObj->pSo_seri ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pNgay_lct' => $paramObj->pNgay_lct ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pTen_kh_vat' => $paramObj->pTen_kh_vat ?? null,
            'pDia_chi_vat' => $paramObj->pDia_chi_vat ?? null,
            'pMa_so_thue' => $paramObj->pMa_so_thue ?? null,
            'pNguoi_gd' => $paramObj->pNguoi_gd ?? null,
            'pMa_httt' => $paramObj->pMa_httt ?? null,
            'pTk_pt' => $paramObj->pTk_pt ?? null,
            'pTk_thue' => $paramObj->pTk_thue ?? null,
            'pDien_giai' => $paramObj->pDien_giai ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pTy_gia' => $paramObj->pTy_gia ?? null,
            'pT_tien' => $paramObj->pT_tien ?? null,
            'pT_tien_nt' => $paramObj->pT_tien_nt ?? null,
            'pT_thue' => $paramObj->pT_thue ?? null,
            'pT_thue_nt' => $paramObj->pT_thue_nt ?? null,
            'pT_tt' => $paramObj->pT_tt ?? null,
            'pT_tt_nt' => $paramObj->pT_tt_nt ?? null,
            'pT_so_luong' => $paramObj->pT_so_luong ?? null,
            'pGia_dd' => $paramObj->pGia_dd ?? null,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pPost2gl' => $paramObj->pPost2gl ?? null,
            'pPost2in' => $paramObj->pPost2in ?? null,
            'pMa_gd' => $paramObj->pMa_gd ?? null,
            'pLUser' => $paramObj->pLUser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPOUpdPH5 with named parameters
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
     * @param string $Ma_httt
     * @param string $Tk_pt
     * @param string $Tk_thue
     * @param string $Dien_giai
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param float $T_tien
     * @param float $T_tien_nt
     * @param float $T_thue
     * @param float $T_thue_nt
     * @param float $T_tt
     * @param float $T_tt_nt
     * @param float $T_so_luong
     * @param bool $Gia_dd
     * @param string $Trang_thai
     * @param bool $Post2gl
     * @param bool $Post2in
     * @param string $Ma_gd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Ma_ct = null, string $So_seri_mhd = null, string $So_seri = null, string $So_ct = null, string $Ngay_ct = null, string $Ngay_lct = null, string $Ma_kh = null, string $Ten_kh_vat = null, string $Dia_chi_vat = null, string $Ma_so_thue = null, string $Nguoi_gd = null, string $Ma_httt = null, string $Tk_pt = null, string $Tk_thue = null, string $Dien_giai = null, string $Ma_nt = null, float $Ty_gia = null, float $T_tien = null, float $T_tien_nt = null, float $T_thue = null, float $T_thue_nt = null, float $T_tt = null, float $T_tt_nt = null, float $T_so_luong = null, bool $Gia_dd = null, string $Trang_thai = null, bool $Post2gl = null, bool $Post2in = null, string $Ma_gd = null, string $LUser = null, int $Ret = null): Collection
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
            'pMa_httt' => $Ma_httt,
            'pTk_pt' => $Tk_pt,
            'pTk_thue' => $Tk_thue,
            'pDien_giai' => $Dien_giai,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pT_tien' => $T_tien,
            'pT_tien_nt' => $T_tien_nt,
            'pT_thue' => $T_thue,
            'pT_thue_nt' => $T_thue_nt,
            'pT_tt' => $T_tt,
            'pT_tt_nt' => $T_tt_nt,
            'pT_so_luong' => $T_so_luong,
            'pGia_dd' => $Gia_dd,
            'pTrang_thai' => $Trang_thai,
            'pPost2gl' => $Post2gl,
            'pPost2in' => $Post2in,
            'pMa_gd' => $Ma_gd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
