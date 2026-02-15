<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:20
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsTAOUT
{
    /**
     * Call stored procedure asInsTAOUT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsTAOUT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStt_rec0' => $params['pStt_rec0'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pNgay_lct' => $params['pNgay_lct'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pSo_seri' => $params['pSo_seri'] ?? null,
            'pSo_seri_mhd' => $params['pSo_seri_mhd'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pTen_kh' => $params['pTen_kh'] ?? null,
            'pDia_chi' => $params['pDia_chi'] ?? null,
            'pMa_so_thue' => $params['pMa_so_thue'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pTen_vt' => $params['pTen_vt'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pGia' => $params['pGia'] ?? null,
            'pGia_nt' => $params['pGia_nt'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pT_tien' => $params['pT_tien'] ?? null,
            'pT_tien_nt' => $params['pT_tien_nt'] ?? null,
            'pMa_thue' => $params['pMa_thue'] ?? null,
            'pThue_suat' => $params['pThue_suat'] ?? null,
            'pT_thue' => $params['pT_thue'] ?? null,
            'pT_thue_nt' => $params['pT_thue_nt'] ?? null,
            'pTk_thue' => $params['pTk_thue'] ?? null,
            'pTk_du' => $params['pTk_du'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsTAOUT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Ma_ct
     * @param string $Ngay_ct
     * @param int $Thang
     * @param int $Nam
     * @param string $Ngay_lct
     * @param string $So_ct
     * @param string $So_seri
     * @param string $So_seri_mhd
     * @param string $Ma_kh
     * @param string $Ten_kh
     * @param string $Dia_chi
     * @param string $Ma_so_thue
     * @param string $Ma_vt
     * @param string $Ten_vt
     * @param float $So_luong
     * @param float $Gia
     * @param float $Gia_nt
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param float $T_tien
     * @param float $T_tien_nt
     * @param string $Ma_thue
     * @param float $Thue_suat
     * @param float $T_thue
     * @param float $T_thue_nt
     * @param string $Tk_thue
     * @param string $Tk_du
     * @param string $Ma_spct
     * @param string $Ma_lo
     * @param string $Ma_bp
     * @param string $Ma_hd
     * @param string $Ghi_chu
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Ma_ct = null, string $Ngay_ct = null, int $Thang = null, int $Nam = null, string $Ngay_lct = null, string $So_ct = null, string $So_seri = null, string $So_seri_mhd = null, string $Ma_kh = null, string $Ten_kh = null, string $Dia_chi = null, string $Ma_so_thue = null, string $Ma_vt = null, string $Ten_vt = null, float $So_luong = null, float $Gia = null, float $Gia_nt = null, string $Ma_nt = null, float $Ty_gia = null, float $T_tien = null, float $T_tien_nt = null, string $Ma_thue = null, float $Thue_suat = null, float $T_thue = null, float $T_thue_nt = null, string $Tk_thue = null, string $Tk_du = null, string $Ma_spct = null, string $Ma_lo = null, string $Ma_bp = null, string $Ma_hd = null, string $Ghi_chu = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pMa_ct' => $Ma_ct,
            'pNgay_ct' => $Ngay_ct,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pNgay_lct' => $Ngay_lct,
            'pSo_ct' => $So_ct,
            'pSo_seri' => $So_seri,
            'pSo_seri_mhd' => $So_seri_mhd,
            'pMa_kh' => $Ma_kh,
            'pTen_kh' => $Ten_kh,
            'pDia_chi' => $Dia_chi,
            'pMa_so_thue' => $Ma_so_thue,
            'pMa_vt' => $Ma_vt,
            'pTen_vt' => $Ten_vt,
            'pSo_luong' => $So_luong,
            'pGia' => $Gia,
            'pGia_nt' => $Gia_nt,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pT_tien' => $T_tien,
            'pT_tien_nt' => $T_tien_nt,
            'pMa_thue' => $Ma_thue,
            'pThue_suat' => $Thue_suat,
            'pT_thue' => $T_thue,
            'pT_thue_nt' => $T_thue_nt,
            'pTk_thue' => $Tk_thue,
            'pTk_du' => $Tk_du,
            'pMa_spct' => $Ma_spct,
            'pMa_lo' => $Ma_lo,
            'pMa_bp' => $Ma_bp,
            'pMa_hd' => $Ma_hd,
            'pGhi_chu' => $Ghi_chu,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
