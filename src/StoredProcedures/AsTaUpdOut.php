<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:50
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsTaUpdOut
{
    /**
     * Call stored procedure asTaUpdOut
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asTaUpdOut', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pStt_rec0' => $paramObj->pStt_rec0 ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pNgay_ct' => $paramObj->pNgay_ct ?? null,
            'pThang' => $paramObj->pThang ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pSo_seri_mhd' => $paramObj->pSo_seri_mhd ?? null,
            'pNgay_lct' => $paramObj->pNgay_lct ?? null,
            'pSo_ct' => $paramObj->pSo_ct ?? null,
            'pSo_seri' => $paramObj->pSo_seri ?? null,
            'pTen_kh' => $paramObj->pTen_kh ?? null,
            'pDia_chi' => $paramObj->pDia_chi ?? null,
            'pMa_so_thue' => $paramObj->pMa_so_thue ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pTen_vt' => $paramObj->pTen_vt ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pGia' => $paramObj->pGia ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pTy_gia' => $paramObj->pTy_gia ?? null,
            'pT_tien' => $paramObj->pT_tien ?? null,
            'pT_tien_nt' => $paramObj->pT_tien_nt ?? null,
            'pMA_thue' => $paramObj->pMA_thue ?? null,
            'pThue_suat' => $paramObj->pThue_suat ?? null,
            'pT_thue' => $paramObj->pT_thue ?? null,
            'pT_thue_nt' => $paramObj->pT_thue_nt ?? null,
            'pTk_thue' => $paramObj->pTk_thue ?? null,
            'pTk_du' => $paramObj->pTk_du ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pUser' => $paramObj->pUser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asTaUpdOut with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Ma_ct
     * @param string $Ngay_ct
     * @param int $Thang
     * @param int $Nam
     * @param string $So_seri_mhd
     * @param string $Ngay_lct
     * @param string $So_ct
     * @param string $So_seri
     * @param string $Ten_kh
     * @param string $Dia_chi
     * @param string $Ma_so_thue
     * @param string $Ma_vt
     * @param string $Ten_vt
     * @param float $So_luong
     * @param float $Gia
     * @param string $Ma_nt
     * @param float $Ty_gia
     * @param float $T_tien
     * @param float $T_tien_nt
     * @param string $MA_thue
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
     * @param string $Ma_kh
     * @param string $User
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Ma_ct = null, string $Ngay_ct = null, int $Thang = null, int $Nam = null, string $So_seri_mhd = null, string $Ngay_lct = null, string $So_ct = null, string $So_seri = null, string $Ten_kh = null, string $Dia_chi = null, string $Ma_so_thue = null, string $Ma_vt = null, string $Ten_vt = null, float $So_luong = null, float $Gia = null, string $Ma_nt = null, float $Ty_gia = null, float $T_tien = null, float $T_tien_nt = null, string $MA_thue = null, float $Thue_suat = null, float $T_thue = null, float $T_thue_nt = null, string $Tk_thue = null, string $Tk_du = null, string $Ma_spct = null, string $Ma_lo = null, string $Ma_bp = null, string $Ma_hd = null, string $Ghi_chu = null, string $Ma_kh = null, string $User = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pMa_ct' => $Ma_ct,
            'pNgay_ct' => $Ngay_ct,
            'pThang' => $Thang,
            'pNam' => $Nam,
            'pSo_seri_mhd' => $So_seri_mhd,
            'pNgay_lct' => $Ngay_lct,
            'pSo_ct' => $So_ct,
            'pSo_seri' => $So_seri,
            'pTen_kh' => $Ten_kh,
            'pDia_chi' => $Dia_chi,
            'pMa_so_thue' => $Ma_so_thue,
            'pMa_vt' => $Ma_vt,
            'pTen_vt' => $Ten_vt,
            'pSo_luong' => $So_luong,
            'pGia' => $Gia,
            'pMa_nt' => $Ma_nt,
            'pTy_gia' => $Ty_gia,
            'pT_tien' => $T_tien,
            'pT_tien_nt' => $T_tien_nt,
            'pMA_thue' => $MA_thue,
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
            'pMa_kh' => $Ma_kh,
            'pUser' => $User,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
