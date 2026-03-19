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

class AsSoInsCt2
{
    /**
     * Call stored procedure asSoInsCt2
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSoInsCt2', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pStt_rec0' => $paramObj->pStt_rec0 ?? null,
            'pStt_rec_dh' => $paramObj->pStt_rec_dh ?? null,
            'pStt_rec0_dh' => $paramObj->pStt_rec0_dh ?? null,
            'pSo_dh' => $paramObj->pSo_dh ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pTen_vt' => $paramObj->pTen_vt ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pDvt' => $paramObj->pDvt ?? null,
            'pSo_luong_qd' => $paramObj->pSo_luong_qd ?? null,
            'pGia_nt' => $paramObj->pGia_nt ?? null,
            'pGia' => $paramObj->pGia ?? null,
            'pTien_nt' => $paramObj->pTien_nt ?? null,
            'pTien' => $paramObj->pTien ?? null,
            'pGia_nt2' => $paramObj->pGia_nt2 ?? null,
            'pGia2' => $paramObj->pGia2 ?? null,
            'pTien_nt2' => $paramObj->pTien_nt2 ?? null,
            'pTien2' => $paramObj->pTien2 ?? null,
            'pTl_ck' => $paramObj->pTl_ck ?? null,
            'pTien_ck_nt' => $paramObj->pTien_ck_nt ?? null,
            'pTien_ck' => $paramObj->pTien_ck ?? null,
            'pMa_thue' => $paramObj->pMa_thue ?? null,
            'pTs_gtgt' => $paramObj->pTs_gtgt ?? null,
            'pThue_gtgt_nt' => $paramObj->pThue_gtgt_nt ?? null,
            'pThue_gtgt' => $paramObj->pThue_gtgt ?? null,
            'pTt_nt' => $paramObj->pTt_nt ?? null,
            'pTt' => $paramObj->pTt ?? null,
            'pKhuyen_mai' => $paramObj->pKhuyen_mai ?? null,
            'pTra_ck' => $paramObj->pTra_ck ?? null,
            'pTk_pt' => $paramObj->pTk_pt ?? null,
            'pTk_dt' => $paramObj->pTk_dt ?? null,
            'pTk_gv' => $paramObj->pTk_gv ?? null,
            'pTk_vt' => $paramObj->pTk_vt ?? null,
            'pTk_thue' => $paramObj->pTk_thue ?? null,
            'pTk_ck' => $paramObj->pTk_ck ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pMa_nvkd' => $paramObj->pMa_nvkd ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSoInsCt2 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Stt_rec_dh
     * @param string $Stt_rec0_dh
     * @param string $So_dh
     * @param string $Ma_vt
     * @param string $Ten_vt
     * @param float $So_luong
     * @param string $Dvt
     * @param float $So_luong_qd
     * @param float $Gia_nt
     * @param float $Gia
     * @param float $Tien_nt
     * @param float $Tien
     * @param float $Gia_nt2
     * @param float $Gia2
     * @param float $Tien_nt2
     * @param float $Tien2
     * @param float $Tl_ck
     * @param float $Tien_ck_nt
     * @param float $Tien_ck
     * @param string $Ma_thue
     * @param float $Ts_gtgt
     * @param float $Thue_gtgt_nt
     * @param float $Thue_gtgt
     * @param float $Tt_nt
     * @param float $Tt
     * @param bool $Khuyen_mai
     * @param bool $Tra_ck
     * @param string $Tk_pt
     * @param string $Tk_dt
     * @param string $Tk_gv
     * @param string $Tk_vt
     * @param string $Tk_thue
     * @param string $Tk_ck
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Ma_lo
     * @param string $Ma_bp
     * @param string $Ma_hd
     * @param string $Ma_phi
     * @param string $Ma_spct
     * @param string $Ma_nvkd
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Stt_rec_dh = null, string $Stt_rec0_dh = null, string $So_dh = null, string $Ma_vt = null, string $Ten_vt = null, float $So_luong = null, string $Dvt = null, float $So_luong_qd = null, float $Gia_nt = null, float $Gia = null, float $Tien_nt = null, float $Tien = null, float $Gia_nt2 = null, float $Gia2 = null, float $Tien_nt2 = null, float $Tien2 = null, float $Tl_ck = null, float $Tien_ck_nt = null, float $Tien_ck = null, string $Ma_thue = null, float $Ts_gtgt = null, float $Thue_gtgt_nt = null, float $Thue_gtgt = null, float $Tt_nt = null, float $Tt = null, bool $Khuyen_mai = null, bool $Tra_ck = null, string $Tk_pt = null, string $Tk_dt = null, string $Tk_gv = null, string $Tk_vt = null, string $Tk_thue = null, string $Tk_ck = null, string $Ma_kho = null, string $Ma_vitri = null, string $Ma_lo = null, string $Ma_bp = null, string $Ma_hd = null, string $Ma_phi = null, string $Ma_spct = null, string $Ma_nvkd = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pStt_rec_dh' => $Stt_rec_dh,
            'pStt_rec0_dh' => $Stt_rec0_dh,
            'pSo_dh' => $So_dh,
            'pMa_vt' => $Ma_vt,
            'pTen_vt' => $Ten_vt,
            'pSo_luong' => $So_luong,
            'pDvt' => $Dvt,
            'pSo_luong_qd' => $So_luong_qd,
            'pGia_nt' => $Gia_nt,
            'pGia' => $Gia,
            'pTien_nt' => $Tien_nt,
            'pTien' => $Tien,
            'pGia_nt2' => $Gia_nt2,
            'pGia2' => $Gia2,
            'pTien_nt2' => $Tien_nt2,
            'pTien2' => $Tien2,
            'pTl_ck' => $Tl_ck,
            'pTien_ck_nt' => $Tien_ck_nt,
            'pTien_ck' => $Tien_ck,
            'pMa_thue' => $Ma_thue,
            'pTs_gtgt' => $Ts_gtgt,
            'pThue_gtgt_nt' => $Thue_gtgt_nt,
            'pThue_gtgt' => $Thue_gtgt,
            'pTt_nt' => $Tt_nt,
            'pTt' => $Tt,
            'pKhuyen_mai' => $Khuyen_mai,
            'pTra_ck' => $Tra_ck,
            'pTk_pt' => $Tk_pt,
            'pTk_dt' => $Tk_dt,
            'pTk_gv' => $Tk_gv,
            'pTk_vt' => $Tk_vt,
            'pTk_thue' => $Tk_thue,
            'pTk_ck' => $Tk_ck,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pMa_lo' => $Ma_lo,
            'pMa_bp' => $Ma_bp,
            'pMa_hd' => $Ma_hd,
            'pMa_phi' => $Ma_phi,
            'pMa_spct' => $Ma_spct,
            'pMa_nvkd' => $Ma_nvkd,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
