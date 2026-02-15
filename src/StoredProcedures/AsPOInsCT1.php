<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:41
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOInsCT1
{
    /**
     * Call stored procedure asPOInsCT1
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOInsCT1', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStt_rec0' => $params['pStt_rec0'] ?? null,
            'pStt_rec_pdn' => $params['pStt_rec_pdn'] ?? null,
            'pStt_rec0_pdn' => $params['pStt_rec0_pdn'] ?? null,
            'pSo_pdn' => $params['pSo_pdn'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pTen_vt' => $params['pTen_vt'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null,
            'pTk_thue' => $params['pTk_thue'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pDvt' => $params['pDvt'] ?? null,
            'pSo_luong_qd' => $params['pSo_luong_qd'] ?? null,
            'pGia_nt0' => $params['pGia_nt0'] ?? null,
            'pGia0' => $params['pGia0'] ?? null,
            'pTien_nt0' => $params['pTien_nt0'] ?? null,
            'pTien0' => $params['pTien0'] ?? null,
            'pTs_gtgt' => $params['pTs_gtgt'] ?? null,
            'pThue_gtgt_nt' => $params['pThue_gtgt_nt'] ?? null,
            'pThue_gtgt' => $params['pThue_gtgt'] ?? null,
            'pTt_nt' => $params['pTt_nt'] ?? null,
            'pTt' => $params['pTt'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPOInsCT1 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Stt_rec_pdn
     * @param string $Stt_rec0_pdn
     * @param string $So_pdn
     * @param string $Ma_vt
     * @param string $Ten_vt
     * @param string $Tk_vt
     * @param string $Tk_thue
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param float $So_luong
     * @param string $Dvt
     * @param float $So_luong_qd
     * @param float $Gia_nt0
     * @param float $Gia0
     * @param float $Tien_nt0
     * @param float $Tien0
     * @param float $Ts_gtgt
     * @param float $Thue_gtgt_nt
     * @param float $Thue_gtgt
     * @param float $Tt_nt
     * @param float $Tt
     * @param string $Ma_lo
     * @param string $Ma_bp
     * @param string $Ma_hd
     * @param string $Ma_phi
     * @param string $Ma_spct
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Stt_rec_pdn = null, string $Stt_rec0_pdn = null, string $So_pdn = null, string $Ma_vt = null, string $Ten_vt = null, string $Tk_vt = null, string $Tk_thue = null, string $Ma_kho = null, string $Ma_vitri = null, float $So_luong = null, string $Dvt = null, float $So_luong_qd = null, float $Gia_nt0 = null, float $Gia0 = null, float $Tien_nt0 = null, float $Tien0 = null, float $Ts_gtgt = null, float $Thue_gtgt_nt = null, float $Thue_gtgt = null, float $Tt_nt = null, float $Tt = null, string $Ma_lo = null, string $Ma_bp = null, string $Ma_hd = null, string $Ma_phi = null, string $Ma_spct = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pStt_rec_pdn' => $Stt_rec_pdn,
            'pStt_rec0_pdn' => $Stt_rec0_pdn,
            'pSo_pdn' => $So_pdn,
            'pMa_vt' => $Ma_vt,
            'pTen_vt' => $Ten_vt,
            'pTk_vt' => $Tk_vt,
            'pTk_thue' => $Tk_thue,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pSo_luong' => $So_luong,
            'pDvt' => $Dvt,
            'pSo_luong_qd' => $So_luong_qd,
            'pGia_nt0' => $Gia_nt0,
            'pGia0' => $Gia0,
            'pTien_nt0' => $Tien_nt0,
            'pTien0' => $Tien0,
            'pTs_gtgt' => $Ts_gtgt,
            'pThue_gtgt_nt' => $Thue_gtgt_nt,
            'pThue_gtgt' => $Thue_gtgt,
            'pTt_nt' => $Tt_nt,
            'pTt' => $Tt,
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
