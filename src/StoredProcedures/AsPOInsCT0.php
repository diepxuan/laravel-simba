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

class AsPOInsCT0
{
    /**
     * Call stored procedure asPOInsCT0
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOInsCT0', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pStt_rec' => $paramObj->pStt_rec ?? null,
            'pStt_rec0' => $paramObj->pStt_rec0 ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pTen_vt' => $paramObj->pTen_vt ?? null,
            'pTk_vt' => $paramObj->pTk_vt ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pSo_luong' => $paramObj->pSo_luong ?? null,
            'pDvt' => $paramObj->pDvt ?? null,
            'pSo_luong_qd' => $paramObj->pSo_luong_qd ?? null,
            'pStt_rec_dhb' => $paramObj->pStt_rec_dhb ?? null,
            'pStt_rec0_dhb' => $paramObj->pStt_rec0_dhb ?? null,
            'pSo_dhb' => $paramObj->pSo_dhb ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPOInsCT0 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $Stt_rec0
     * @param string $Ma_vt
     * @param string $Ten_vt
     * @param string $Tk_vt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param float $So_luong
     * @param string $Dvt
     * @param float $So_luong_qd
     * @param string $Stt_rec_dhb
     * @param string $Stt_rec0_dhb
     * @param string $So_dhb
     * @param string $Ma_lo
     * @param string $Ma_bp
     * @param string $Ma_hd
     * @param string $Ma_phi
     * @param string $Ma_spct
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $Stt_rec0 = null, string $Ma_vt = null, string $Ten_vt = null, string $Tk_vt = null, string $Ma_kho = null, string $Ma_vitri = null, float $So_luong = null, string $Dvt = null, float $So_luong_qd = null, string $Stt_rec_dhb = null, string $Stt_rec0_dhb = null, string $So_dhb = null, string $Ma_lo = null, string $Ma_bp = null, string $Ma_hd = null, string $Ma_phi = null, string $Ma_spct = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pStt_rec0' => $Stt_rec0,
            'pMa_vt' => $Ma_vt,
            'pTen_vt' => $Ten_vt,
            'pTk_vt' => $Tk_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pSo_luong' => $So_luong,
            'pDvt' => $Dvt,
            'pSo_luong_qd' => $So_luong_qd,
            'pStt_rec_dhb' => $Stt_rec_dhb,
            'pStt_rec0_dhb' => $Stt_rec0_dhb,
            'pSo_dhb' => $So_dhb,
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
