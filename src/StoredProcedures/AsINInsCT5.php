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
use Diepxuan\Simba\Helper\ParamHelper;

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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsCT5', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pStt_rec0' => $paramObj->pStt_rec0 ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pMa_nx' => $paramObj->pMa_nx ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pDvt' => $paramObj->pDvt ?? null,
            'pTk_vt' => $paramObj->pTk_vt ?? null,
            'pTk_no' => $paramObj->pTk_no ?? null,
            'pTk_cp' => $paramObj->pTk_cp ?? null,
            'pKy_pb' => $paramObj->pKy_pb ?? null,
            'pSo_ky' => $paramObj->pSo_ky ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pSo_luong_qd' => $paramObj->pSo_luong_qd ?? null,
            'pGia_nt' => $paramObj->pGia_nt ?? null,
            'pGia' => $paramObj->pGia ?? null,
            'pTien_nt' => $paramObj->pTien_nt ?? null,
            'pTien' => $paramObj->pTien ?? null,
            'pTen_vt' => $paramObj->pTen_vt ?? null,
            'pMa_bpsd' => $paramObj->pMa_bpsd ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pRet' => $paramObj->pRet ?? null
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
