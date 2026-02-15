<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:20:18
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsTaInsIn
{
    /**
     * Call stored procedure asTaInsIn
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asTaInsIn', $params, $connection);
    }

    /**
     * Call stored procedure asTaInsIn with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec_pn
     * @param string $Stt_rec0
     * @param string $Ma_ct
     * @param string $Ma_bp
     * @param string $Ngay_ct
     * @param string $So_ct
     * @param string $So_seri_mhd
     * @param string $Ngay_ct0
     * @param string $So_ct0
     * @param string $So_seri0
     * @param string $Mau_bc
     * @param string $Ma_kh
     * @param string $Ten_kh
     * @param string $Dia_chi
     * @param string $Ma_so_thue
     * @param string $Ma_vt
     * @param string $Ten_vt
     * @param float $So_luong
     * @param float $Gia
     * @param float $Tien_hang
     * @param float $Thue_nk
     * @param float $Thue_ttdb
     * @param float $T_tien
     * @param float $Thue_suat
     * @param float $T_thue
     * @param string $Tk_thue_no
     * @param string $Tk_du
     * @param string $Ghi_chu
     * @param string $Ma_spct
     * @param string $Ma_lo
     * @param string $User
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec_pn = null, string $Stt_rec0 = null, string $Ma_ct = null, string $Ma_bp = null, string $Ngay_ct = null, string $So_ct = null, string $So_seri_mhd = null, string $Ngay_ct0 = null, string $So_ct0 = null, string $So_seri0 = null, string $Mau_bc = null, string $Ma_kh = null, string $Ten_kh = null, string $Dia_chi = null, string $Ma_so_thue = null, string $Ma_vt = null, string $Ten_vt = null, float $So_luong = null, float $Gia = null, float $Tien_hang = null, float $Thue_nk = null, float $Thue_ttdb = null, float $T_tien = null, float $Thue_suat = null, float $T_thue = null, string $Tk_thue_no = null, string $Tk_du = null, string $Ghi_chu = null, string $Ma_spct = null, string $Ma_lo = null, string $User = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec_pn' => $Stt_rec_pn,
            'pStt_rec0' => $Stt_rec0,
            'pMa_ct' => $Ma_ct,
            'pMa_bp' => $Ma_bp,
            'pNgay_ct' => $Ngay_ct,
            'pSo_ct' => $So_ct,
            'pSo_seri_mhd' => $So_seri_mhd,
            'pNgay_ct0' => $Ngay_ct0,
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
            'pGia' => $Gia,
            'pTien_hang' => $Tien_hang,
            'pThue_nk' => $Thue_nk,
            'pThue_ttdb' => $Thue_ttdb,
            'pT_tien' => $T_tien,
            'pThue_suat' => $Thue_suat,
            'pT_thue' => $T_thue,
            'pTk_thue_no' => $Tk_thue_no,
            'pTk_du' => $Tk_du,
            'pGhi_chu' => $Ghi_chu,
            'pMa_spct' => $Ma_spct,
            'pMa_lo' => $Ma_lo,
            'pUser' => $User,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
