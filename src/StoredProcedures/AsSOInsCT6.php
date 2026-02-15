<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:09
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOInsCT6
{
    /**
     * Call stored procedure asSOInsCT6
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOInsCT6', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStt_rec0' => $params['pStt_rec0'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pTen_vt' => $params['pTen_vt'] ?? null,
            'pDvt' => $params['pDvt'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pSo_luong_qd' => $params['pSo_luong_qd'] ?? null,
            'pGia2' => $params['pGia2'] ?? null,
            'pTien2' => $params['pTien2'] ?? null,
            'pTl_ck' => $params['pTl_ck'] ?? null,
            'pTien_ck' => $params['pTien_ck'] ?? null,
            'pMa_thue' => $params['pMa_thue'] ?? null,
            'pTs_gtgt' => $params['pTs_gtgt'] ?? null,
            'pThue_gtgt' => $params['pThue_gtgt'] ?? null,
            'pTt' => $params['pTt'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOInsCT6 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Ma_vt
     * @param string $Ten_vt
     * @param string $Dvt
     * @param float $So_luong
     * @param float $So_luong_qd
     * @param float $Gia2
     * @param float $Tien2
     * @param float $Tl_ck
     * @param float $Tien_ck
     * @param string $Ma_thue
     * @param float $Ts_gtgt
     * @param float $Thue_gtgt
     * @param float $Tt
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Ma_vt = null, string $Ten_vt = null, string $Dvt = null, float $So_luong = null, float $So_luong_qd = null, float $Gia2 = null, float $Tien2 = null, float $Tl_ck = null, float $Tien_ck = null, string $Ma_thue = null, float $Ts_gtgt = null, float $Thue_gtgt = null, float $Tt = null, int $Ret = null): Collection
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
            'pGia2' => $Gia2,
            'pTien2' => $Tien2,
            'pTl_ck' => $Tl_ck,
            'pTien_ck' => $Tien_ck,
            'pMa_thue' => $Ma_thue,
            'pTs_gtgt' => $Ts_gtgt,
            'pThue_gtgt' => $Thue_gtgt,
            'pTt' => $Tt,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
