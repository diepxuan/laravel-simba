<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:14
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINInsCDFIFO
{
    /**
     * Call stored procedure asINInsCDFIFO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINInsCDFIFO', $params, $connection);
    }

    /**
     * Call stored procedure asINInsCDFIFO with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec_nt
     * @param string $Stt_rec0
     * @param string $Ma_ct
     * @param string $Ngay_ct
     * @param string $So_ct
     * @param string $Ma_kho
     * @param string $Ma_vt
     * @param string $Ma_nt
     * @param float $So_luong
     * @param float $So_luong_qd
     * @param float $Tien
     * @param float $Tien_nt
     * @param float $Ton_kho
     * @param float $So_du
     * @param float $So_du_nt
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec_nt = null, string $Stt_rec0 = null, string $Ma_ct = null, string $Ngay_ct = null, string $So_ct = null, string $Ma_kho = null, string $Ma_vt = null, string $Ma_nt = null, float $So_luong = null, float $So_luong_qd = null, float $Tien = null, float $Tien_nt = null, float $Ton_kho = null, float $So_du = null, float $So_du_nt = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec_nt' => $Stt_rec_nt,
            'pStt_rec0' => $Stt_rec0,
            'pMa_ct' => $Ma_ct,
            'pNgay_ct' => $Ngay_ct,
            'pSo_ct' => $So_ct,
            'pMa_kho' => $Ma_kho,
            'pMa_vt' => $Ma_vt,
            'pMa_nt' => $Ma_nt,
            'pSo_luong' => $So_luong,
            'pSo_luong_qd' => $So_luong_qd,
            'pTien' => $Tien,
            'pTien_nt' => $Tien_nt,
            'pTon_kho' => $Ton_kho,
            'pSo_du' => $So_du,
            'pSo_du_nt' => $So_du_nt,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
