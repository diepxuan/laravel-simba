<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:40
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsPOInsCT6
{
    /**
     * Call stored procedure asPOInsCT6
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOInsCT6', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pStt_rec0' => $paramObj->pStt_rec0 ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pTen_vt' => $paramObj->pTen_vt ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pDvt' => $paramObj->pDvt ?? null,
            'pGia' => $paramObj->pGia ?? null,
            'pGia_nt' => $paramObj->pGia_nt ?? null,
            'pTien_nt' => $paramObj->pTien_nt ?? null,
            'pTien' => $paramObj->pTien ?? null,
            'pTs_gtgt' => $paramObj->pTs_gtgt ?? null,
            'pThue_gtgt_nt' => $paramObj->pThue_gtgt_nt ?? null,
            'pThue_gtgt' => $paramObj->pThue_gtgt ?? null,
            'pTt_nt' => $paramObj->pTt_nt ?? null,
            'pTt' => $paramObj->pTt ?? null,
            'pTk_no' => $paramObj->pTk_no ?? null,
            'pTk_pt' => $paramObj->pTk_pt ?? null,
            'pTk_thue' => $paramObj->pTk_thue ?? null,
            'pMa_ku' => $paramObj->pMa_ku ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPOInsCT6 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Ma_vt
     * @param string $Ten_vt
     * @param float $So_luong
     * @param string $Dvt
     * @param float $Gia
     * @param float $Gia_nt
     * @param float $Tien_nt
     * @param float $Tien
     * @param float $Ts_gtgt
     * @param float $Thue_gtgt_nt
     * @param float $Thue_gtgt
     * @param float $Tt_nt
     * @param float $Tt
     * @param string $Tk_no
     * @param string $Tk_pt
     * @param string $Tk_thue
     * @param string $Ma_ku
     * @param string $Ma_lo
     * @param string $Ma_bp
     * @param string $Ma_hd
     * @param string $Ma_phi
     * @param string $Ma_spct
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Ma_vt = null, string $Ten_vt = null, float $So_luong = null, string $Dvt = null, float $Gia = null, float $Gia_nt = null, float $Tien_nt = null, float $Tien = null, float $Ts_gtgt = null, float $Thue_gtgt_nt = null, float $Thue_gtgt = null, float $Tt_nt = null, float $Tt = null, string $Tk_no = null, string $Tk_pt = null, string $Tk_thue = null, string $Ma_ku = null, string $Ma_lo = null, string $Ma_bp = null, string $Ma_hd = null, string $Ma_phi = null, string $Ma_spct = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pMa_vt' => $Ma_vt,
            'pTen_vt' => $Ten_vt,
            'pSo_luong' => $So_luong,
            'pDvt' => $Dvt,
            'pGia' => $Gia,
            'pGia_nt' => $Gia_nt,
            'pTien_nt' => $Tien_nt,
            'pTien' => $Tien,
            'pTs_gtgt' => $Ts_gtgt,
            'pThue_gtgt_nt' => $Thue_gtgt_nt,
            'pThue_gtgt' => $Thue_gtgt,
            'pTt_nt' => $Tt_nt,
            'pTt' => $Tt,
            'pTk_no' => $Tk_no,
            'pTk_pt' => $Tk_pt,
            'pTk_thue' => $Tk_thue,
            'pMa_ku' => $Ma_ku,
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
