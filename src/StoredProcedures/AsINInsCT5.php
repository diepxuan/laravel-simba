<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINInsCT5
{
    /**
     * Call stored procedure asINInsCT5
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsCT5', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStt_rec0' => $params['pStt_rec0'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pMa_nx' => $params['pMa_nx'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pDvt' => $params['pDvt'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null,
            'pTk_no' => $params['pTk_no'] ?? null,
            'pTk_cp' => $params['pTk_cp'] ?? null,
            'pKy_pb' => $params['pKy_pb'] ?? null,
            'pSo_ky' => $params['pSo_ky'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pSo_luong_qd' => $params['pSo_luong_qd'] ?? null,
            'pGia_nt' => $params['pGia_nt'] ?? null,
            'pGia' => $params['pGia'] ?? null,
            'pTien_nt' => $params['pTien_nt'] ?? null,
            'pTien' => $params['pTien'] ?? null,
            'pTen_vt' => $params['pTen_vt'] ?? null,
            'pMa_bpsd' => $params['pMa_bpsd'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINInsCT5 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Ma_nx
     * @param string $Ma_vt
     * @param string $Dvt
     * @param string $Tk_vt
     * @param string $Tk_no
     * @param string $Tk_cp
     * @param int $Ky_pb
     * @param int $So_ky
     * @param float $So_luong
     * @param float $So_luong_qd
     * @param float $Gia_nt
     * @param float $Gia
     * @param float $Tien_nt
     * @param float $Tien
     * @param string $Ten_vt
     * @param string $Ma_bpsd
     * @param string $Ma_lo
     * @param string $Ma_bp
     * @param string $Ma_hd
     * @param string $Ma_phi
     * @param string $Ma_spct
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Ma_kho = null, string $Ma_vitri = null, string $Ma_nx = null, string $Ma_vt = null, string $Dvt = null, string $Tk_vt = null, string $Tk_no = null, string $Tk_cp = null, int $Ky_pb = null, int $So_ky = null, float $So_luong = null, float $So_luong_qd = null, float $Gia_nt = null, float $Gia = null, float $Tien_nt = null, float $Tien = null, string $Ten_vt = null, string $Ma_bpsd = null, string $Ma_lo = null, string $Ma_bp = null, string $Ma_hd = null, string $Ma_phi = null, string $Ma_spct = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pMa_nx' => $Ma_nx,
            'pMa_vt' => $Ma_vt,
            'pDvt' => $Dvt,
            'pTk_vt' => $Tk_vt,
            'pTk_no' => $Tk_no,
            'pTk_cp' => $Tk_cp,
            'pKy_pb' => $Ky_pb,
            'pSo_ky' => $So_ky,
            'pSo_luong' => $So_luong,
            'pSo_luong_qd' => $So_luong_qd,
            'pGia_nt' => $Gia_nt,
            'pGia' => $Gia,
            'pTien_nt' => $Tien_nt,
            'pTien' => $Tien,
            'pTen_vt' => $Ten_vt,
            'pMa_bpsd' => $Ma_bpsd,
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
