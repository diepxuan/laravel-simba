<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINInsCT3
{
    /**
     * Call stored procedure asINInsCT3
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsCT3', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pStt_rec0' => $paramObj->pStt_rec0 ?? null,
            'pMa_khon' => $paramObj->pMa_khon ?? null,
            'pMa_khox' => $paramObj->pMa_khox ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pMa_vitrin' => $paramObj->pMa_vitrin ?? null,
            'pMa_vitrix' => $paramObj->pMa_vitrix ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pDvt' => $paramObj->pDvt ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pSo_luong_qd' => $paramObj->pSo_luong_qd ?? null,
            'pGia_nt' => $paramObj->pGia_nt ?? null,
            'pGia' => $paramObj->pGia ?? null,
            'pTien_nt' => $paramObj->pTien_nt ?? null,
            'pTien' => $paramObj->pTien ?? null,
            'pMa_nx' => $paramObj->pMa_nx ?? null,
            'pTk_vt' => $paramObj->pTk_vt ?? null,
            'pTk_no' => $paramObj->pTk_no ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pTen_vt' => $paramObj->pTen_vt ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINInsCT3 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Ma_khon
     * @param string $Ma_khox
     * @param string $Ma_vitri
     * @param string $Ma_vitrin
     * @param string $Ma_vitrix
     * @param string $Ma_vt
     * @param string $Dvt
     * @param float $So_luong
     * @param float $So_luong_qd
     * @param float $Gia_nt
     * @param float $Gia
     * @param float $Tien_nt
     * @param float $Tien
     * @param string $Ma_nx
     * @param string $Tk_vt
     * @param string $Tk_no
     * @param string $Ma_lo
     * @param string $Ma_bp
     * @param string $Ma_hd
     * @param string $Ma_phi
     * @param string $Ma_spct
     * @param string $Ten_vt
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Ma_khon = null, string $Ma_khox = null, string $Ma_vitri = null, string $Ma_vitrin = null, string $Ma_vitrix = null, string $Ma_vt = null, string $Dvt = null, float $So_luong = null, float $So_luong_qd = null, float $Gia_nt = null, float $Gia = null, float $Tien_nt = null, float $Tien = null, string $Ma_nx = null, string $Tk_vt = null, string $Tk_no = null, string $Ma_lo = null, string $Ma_bp = null, string $Ma_hd = null, string $Ma_phi = null, string $Ma_spct = null, string $Ten_vt = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pMa_khon' => $Ma_khon,
            'pMa_khox' => $Ma_khox,
            'pMa_vitri' => $Ma_vitri,
            'pMa_vitrin' => $Ma_vitrin,
            'pMa_vitrix' => $Ma_vitrix,
            'pMa_vt' => $Ma_vt,
            'pDvt' => $Dvt,
            'pSo_luong' => $So_luong,
            'pSo_luong_qd' => $So_luong_qd,
            'pGia_nt' => $Gia_nt,
            'pGia' => $Gia,
            'pTien_nt' => $Tien_nt,
            'pTien' => $Tien,
            'pMa_nx' => $Ma_nx,
            'pTk_vt' => $Tk_vt,
            'pTk_no' => $Tk_no,
            'pMa_lo' => $Ma_lo,
            'pMa_bp' => $Ma_bp,
            'pMa_hd' => $Ma_hd,
            'pMa_phi' => $Ma_phi,
            'pMa_spct' => $Ma_spct,
            'pTen_vt' => $Ten_vt,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
