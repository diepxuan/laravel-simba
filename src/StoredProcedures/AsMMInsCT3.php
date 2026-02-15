<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsMMInsCT3
{
    /**
     * Call stored procedure asMMInsCT3
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asMMInsCT3', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pStt_rec0' => $params['pStt_rec0'] ?? null,
            'pStt_rec_dh' => $params['pStt_rec_dh'] ?? null,
            'pStt_rec0_dh' => $params['pStt_rec0_dh'] ?? null,
            'pSo_dh' => $params['pSo_dh'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pTen_vt' => $params['pTen_vt'] ?? null,
            'pDvt' => $params['pDvt'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pSo_luong_qd' => $params['pSo_luong_qd'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asMMInsCT3 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Stt_rec_dh
     * @param string $Stt_rec0_dh
     * @param string $So_dh
     * @param string $Ma_vt
     * @param string $Ten_vt
     * @param string $Dvt
     * @param float $So_luong
     * @param float $So_luong_qd
     * @param string $Ma_hd
     * @param string $Ma_bp
     * @param string $Ma_phi
     * @param string $Ma_lo
     * @param string $Ghi_chu
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Stt_rec_dh = null, string $Stt_rec0_dh = null, string $So_dh = null, string $Ma_vt = null, string $Ten_vt = null, string $Dvt = null, float $So_luong = null, float $So_luong_qd = null, string $Ma_hd = null, string $Ma_bp = null, string $Ma_phi = null, string $Ma_lo = null, string $Ghi_chu = null, int $Ret = null): Collection
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
            'pDvt' => $Dvt,
            'pSo_luong' => $So_luong,
            'pSo_luong_qd' => $So_luong_qd,
            'pMa_hd' => $Ma_hd,
            'pMa_bp' => $Ma_bp,
            'pMa_phi' => $Ma_phi,
            'pMa_lo' => $Ma_lo,
            'pGhi_chu' => $Ghi_chu,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
