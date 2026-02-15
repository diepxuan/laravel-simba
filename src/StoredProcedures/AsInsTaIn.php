<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:02
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsTaIn
{
    /**
     * Call stored procedure asInsTaIn
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsTaIn', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStt_rec0' => $params['pStt_rec0'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pSo_seri_mhd' => $params['pSo_seri_mhd'] ?? null,
            'pNgay_ct0' => $params['pNgay_ct0'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pSo_ct0' => $params['pSo_ct0'] ?? null,
            'pSo_seri0' => $params['pSo_seri0'] ?? null,
            'pMau_bc' => $params['pMau_bc'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pTen_kh' => $params['pTen_kh'] ?? null,
            'pDia_chi' => $params['pDia_chi'] ?? null,
            'pMa_so_thue' => $params['pMa_so_thue'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pTen_vt' => $params['pTen_vt'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pGia_nt' => $params['pGia_nt'] ?? null,
            'pTien_hang_nt' => $params['pTien_hang_nt'] ?? null,
            'pThue_nk_nt' => $params['pThue_nk_nt'] ?? null,
            'pThue_ttdb_nt' => $params['pThue_ttdb_nt'] ?? null,
            'pT_tien_nt' => $params['pT_tien_nt'] ?? null,
            'pThue_suat' => $params['pThue_suat'] ?? null,
            'pT_thue_nt' => $params['pT_thue_nt'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pTy_gia' => $params['pTy_gia'] ?? null,
            'pGia' => $params['pGia'] ?? null,
            'pTien_hang' => $params['pTien_hang'] ?? null,
            'pThue_nk' => $params['pThue_nk'] ?? null,
            'pThue_ttdb' => $params['pThue_ttdb'] ?? null,
            'pT_tien' => $params['pT_tien'] ?? null,
            'pT_thue' => $params['pT_thue'] ?? null,
            'pTk_thue_no' => $params['pTk_thue_no'] ?? null,
            'pTk_du' => $params['pTk_du'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pVAT_NK' => $params['pVAT_NK'] ?? null,
            'pStt_rec_pc' => $params['pStt_rec_pc'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsTaIn with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Ma_ct
     * @param string $Ma_bp
     * @param string $Ngay_ct
     * @param string $So_seri_mhd
     * @param string $Ngay_ct0
     * @param string $So_ct
     * @param string $So_ct0
     * @param string $So_seri0
     * @param int $Mau_bc
     * @param string $Ma_kh
     * @param string $Ten_kh
     * @param string $Dia_chi
     * @param string $Ma_so_thue
     * @param string $Ma_vt
     * @param string $Ten_vt
     * @param float $So_luong
     * @param float $Gia_nt
     * @param float $Tien_hang_nt
     * @param float $Thue_nk_nt
     * @param float $Thue_ttdb_nt
     * @param float $T_tien_nt
     * @param float $Thue_suat
     * @param float $T_thue_nt
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param float $Gia
     * @param float $Tien_hang
     * @param float $Thue_nk
     * @param float $Thue_ttdb
     * @param float $T_tien
     * @param float $T_thue
     * @param string $Tk_thue_no
     * @param string $Tk_du
     * @param string $Ghi_chu
     * @param string $Ma_spct
     * @param string $Ma_lo
     * @param bool $VAT_NK
     * @param string $Stt_rec_pc
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Ma_ct = null, string $Ma_bp = null, string $Ngay_ct = null, string $So_seri_mhd = null, string $Ngay_ct0 = null, string $So_ct = null, string $So_ct0 = null, string $So_seri0 = null, int $Mau_bc = null, string $Ma_kh = null, string $Ten_kh = null, string $Dia_chi = null, string $Ma_so_thue = null, string $Ma_vt = null, string $Ten_vt = null, float $So_luong = null, float $Gia_nt = null, float $Tien_hang_nt = null, float $Thue_nk_nt = null, float $Thue_ttdb_nt = null, float $T_tien_nt = null, float $Thue_suat = null, float $T_thue_nt = null, string $Ma_nt = null, float $Ty_gia = null, float $Gia = null, float $Tien_hang = null, float $Thue_nk = null, float $Thue_ttdb = null, float $T_tien = null, float $T_thue = null, string $Tk_thue_no = null, string $Tk_du = null, string $Ghi_chu = null, string $Ma_spct = null, string $Ma_lo = null, bool $VAT_NK = null, string $Stt_rec_pc = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pMa_ct' => $Ma_ct,
            'pMa_bp' => $Ma_bp,
            'pNgay_ct' => $Ngay_ct,
            'pSo_seri_mhd' => $So_seri_mhd,
            'pNgay_ct0' => $Ngay_ct0,
            'pSo_ct' => $So_ct,
            'pSo_ct0' => $So_ct0,
            'pSo_seri0' => $So_seri0,
            'pMau_bc' => $Mau_bc,
            'pMa_kh' => $Ma_kh,
            'pTen_kh' => $Ten_kh,
            'pDia_chi' => $Dia_chi,
            'pMa_so_thue' => $Ma_so_thue,
            'pMa_vt' => $Ma_vt,
            'pTen_vt' => $Ten_vt,
            'pSo_luong' => $So_luong,
            'pGia_nt' => $Gia_nt,
            'pTien_hang_nt' => $Tien_hang_nt,
            'pThue_nk_nt' => $Thue_nk_nt,
            'pThue_ttdb_nt' => $Thue_ttdb_nt,
            'pT_tien_nt' => $T_tien_nt,
            'pThue_suat' => $Thue_suat,
            'pT_thue_nt' => $T_thue_nt,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pGia' => $Gia,
            'pTien_hang' => $Tien_hang,
            'pThue_nk' => $Thue_nk,
            'pThue_ttdb' => $Thue_ttdb,
            'pT_tien' => $T_tien,
            'pT_thue' => $T_thue,
            'pTk_thue_no' => $Tk_thue_no,
            'pTk_du' => $Tk_du,
            'pGhi_chu' => $Ghi_chu,
            'pMa_spct' => $Ma_spct,
            'pMa_lo' => $Ma_lo,
            'pVAT_NK' => $VAT_NK,
            'pStt_rec_pc' => $Stt_rec_pc,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
