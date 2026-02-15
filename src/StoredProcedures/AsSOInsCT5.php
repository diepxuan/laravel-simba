<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:48
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOInsCT5
{
    /**
     * Call stored procedure asSOInsCT5
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsCT5', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStt_rec0' => $params['pStt_rec0'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pTen_vt' => $params['pTen_vt'] ?? null,
            'pDvt' => $params['pDvt'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pSo_luong_qd' => $params['pSo_luong_qd'] ?? null,
            'pGia_nt2' => $params['pGia_nt2'] ?? null,
            'pGia2' => $params['pGia2'] ?? null,
            'pTien_nt2' => $params['pTien_nt2'] ?? null,
            'pTien2' => $params['pTien2'] ?? null,
            'pTl_ck' => $params['pTl_ck'] ?? null,
            'pTien_ck_nt' => $params['pTien_ck_nt'] ?? null,
            'pTien_ck' => $params['pTien_ck'] ?? null,
            'pCk_ds' => $params['pCk_ds'] ?? null,
            'pCk_ds_nt' => $params['pCk_ds_nt'] ?? null,
            'pMa_thue' => $params['pMa_thue'] ?? null,
            'pTs_gtgt' => $params['pTs_gtgt'] ?? null,
            'pThue_gtgt_nt' => $params['pThue_gtgt_nt'] ?? null,
            'pThue_gtgt' => $params['pThue_gtgt'] ?? null,
            'pTt_nt' => $params['pTt_nt'] ?? null,
            'pTt' => $params['pTt'] ?? null,
            'pTk_pt' => $params['pTk_pt'] ?? null,
            'pTk_thue' => $params['pTk_thue'] ?? null,
            'pTk_dt' => $params['pTk_dt'] ?? null,
            'pTk_ck' => $params['pTk_ck'] ?? null,
            'pKhuyen_mai' => $params['pKhuyen_mai'] ?? null,
            'pTra_ck' => $params['pTra_ck'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pMa_nvkd' => $params['pMa_nvkd'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOInsCT5 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Ma_vt
     * @param string $Ten_vt
     * @param string $Dvt
     * @param float $So_luong
     * @param float $So_luong_qd
     * @param float $Gia_nt2
     * @param float $Gia2
     * @param float $Tien_nt2
     * @param float $Tien2
     * @param float $Tl_ck
     * @param float $Tien_ck_nt
     * @param float $Tien_ck
     * @param float $Ck_ds
     * @param float $Ck_ds_nt
     * @param string $Ma_thue
     * @param float $Ts_gtgt
     * @param float $Thue_gtgt_nt
     * @param float $Thue_gtgt
     * @param float $Tt_nt
     * @param float $Tt
     * @param string $Tk_pt
     * @param string $Tk_thue
     * @param string $Tk_dt
     * @param string $Tk_ck
     * @param string $Khuyen_mai
     * @param string $Tra_ck
     * @param string $Ma_lo
     * @param string $Ma_bp
     * @param string $Ma_hd
     * @param string $Ma_phi
     * @param string $Ma_spct
     * @param string $Ma_nvkd
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Ma_vt = null, string $Ten_vt = null, string $Dvt = null, float $So_luong = null, float $So_luong_qd = null, float $Gia_nt2 = null, float $Gia2 = null, float $Tien_nt2 = null, float $Tien2 = null, float $Tl_ck = null, float $Tien_ck_nt = null, float $Tien_ck = null, float $Ck_ds = null, float $Ck_ds_nt = null, string $Ma_thue = null, float $Ts_gtgt = null, float $Thue_gtgt_nt = null, float $Thue_gtgt = null, float $Tt_nt = null, float $Tt = null, string $Tk_pt = null, string $Tk_thue = null, string $Tk_dt = null, string $Tk_ck = null, string $Khuyen_mai = null, string $Tra_ck = null, string $Ma_lo = null, string $Ma_bp = null, string $Ma_hd = null, string $Ma_phi = null, string $Ma_spct = null, string $Ma_nvkd = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pMa_vt' => $Ma_vt,
            'pTen_vt' => $Ten_vt,
            'pDvt' => $Dvt,
            'pSo_luong' => $So_luong,
            'pSo_luong_qd' => $So_luong_qd,
            'pGia_nt2' => $Gia_nt2,
            'pGia2' => $Gia2,
            'pTien_nt2' => $Tien_nt2,
            'pTien2' => $Tien2,
            'pTl_ck' => $Tl_ck,
            'pTien_ck_nt' => $Tien_ck_nt,
            'pTien_ck' => $Tien_ck,
            'pCk_ds' => $Ck_ds,
            'pCk_ds_nt' => $Ck_ds_nt,
            'pMa_thue' => $Ma_thue,
            'pTs_gtgt' => $Ts_gtgt,
            'pThue_gtgt_nt' => $Thue_gtgt_nt,
            'pThue_gtgt' => $Thue_gtgt,
            'pTt_nt' => $Tt_nt,
            'pTt' => $Tt,
            'pTk_pt' => $Tk_pt,
            'pTk_thue' => $Tk_thue,
            'pTk_dt' => $Tk_dt,
            'pTk_ck' => $Tk_ck,
            'pKhuyen_mai' => $Khuyen_mai,
            'pTra_ck' => $Tra_ck,
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
