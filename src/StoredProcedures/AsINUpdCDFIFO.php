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

class AsINUpdCDFIFO
{
    /**
     * Call stored procedure asINUpdCDFIFO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINUpdCDFIFO', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec_nt' => $params['pStt_rec_nt'] ?? null,
            'pStt_rec0' => $params['pStt_rec0'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pSo_luong_qd' => $params['pSo_luong_qd'] ?? null,
            'pTien' => $params['pTien'] ?? null,
            'pTien_nt' => $params['pTien_nt'] ?? null,
            'pTon_kho' => $params['pTon_kho'] ?? null,
            'pSo_du' => $params['pSo_du'] ?? null,
            'pSo_du_nt' => $params['pSo_du_nt'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINUpdCDFIFO with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec_nt
     * @param string $Stt_rec0
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
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec_nt = null, string $Stt_rec0 = null, float $So_luong = null, float $So_luong_qd = null, float $Tien = null, float $Tien_nt = null, float $Ton_kho = null, float $So_du = null, float $So_du_nt = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec_nt' => $Stt_rec_nt,
            'pStt_rec0' => $Stt_rec0,
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
