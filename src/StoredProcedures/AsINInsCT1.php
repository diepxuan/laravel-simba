<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:14
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINInsCT1
{
    /**
     * Call stored procedure asINInsCT1
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsCT1', $params, $connection);
    }

    /**
     * Call stored procedure asINInsCT1 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Stt_rec_lsx
     * @param string $Stt_rec0_lsx
     * @param string $So_lsx
     * @param string $Ma_kho
     * @param string $Ma_vt
     * @param string $Ten_vt
     * @param string $Dvt
     * @param string $Tk_vt
     * @param string $Tk_co
     * @param string $Ma_nx
     * @param float $So_luong
     * @param float $So_luong_qd
     * @param float $Gia_nt
     * @param float $Gia
     * @param float $Tien_nt
     * @param float $Tien
     * @param string $Ma_vitri
     * @param string $Ma_lo
     * @param string $Ma_bp
     * @param string $Ma_hd
     * @param string $Ma_phi
     * @param string $Ma_spct
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Stt_rec_lsx = null, string $Stt_rec0_lsx = null, string $So_lsx = null, string $Ma_kho = null, string $Ma_vt = null, string $Ten_vt = null, string $Dvt = null, string $Tk_vt = null, string $Tk_co = null, string $Ma_nx = null, float $So_luong = null, float $So_luong_qd = null, float $Gia_nt = null, float $Gia = null, float $Tien_nt = null, float $Tien = null, string $Ma_vitri = null, string $Ma_lo = null, string $Ma_bp = null, string $Ma_hd = null, string $Ma_phi = null, string $Ma_spct = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pStt_rec_lsx' => $Stt_rec_lsx,
            'pStt_rec0_lsx' => $Stt_rec0_lsx,
            'pSo_lsx' => $So_lsx,
            'pMa_kho' => $Ma_kho,
            'pMa_vt' => $Ma_vt,
            'pTen_vt' => $Ten_vt,
            'pDvt' => $Dvt,
            'pTk_vt' => $Tk_vt,
            'pTk_co' => $Tk_co,
            'pMa_nx' => $Ma_nx,
            'pSo_luong' => $So_luong,
            'pSo_luong_qd' => $So_luong_qd,
            'pGia_nt' => $Gia_nt,
            'pGia' => $Gia,
            'pTien_nt' => $Tien_nt,
            'pTien' => $Tien,
            'pMa_vitri' => $Ma_vitri,
            'pMa_lo' => $Ma_lo,
            'pMa_bp' => $Ma_bp,
            'pMa_hd' => $Ma_hd,
            'pMa_phi' => $Ma_phi,
            'pMa_spct' => $Ma_spct,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
