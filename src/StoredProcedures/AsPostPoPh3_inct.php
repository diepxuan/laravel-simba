<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:01
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPostPoPh3_inct
{
    /**
     * Call stored procedure asPostPoPh3_inct
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPostPoPh3_inct', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pNamTC' => $params['pNamTC'] ?? null,
            'pThangTC' => $params['pThangTC'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pNgay_ks' => $params['pNgay_ks'] ?? null,
            'pMa_gd' => $params['pMa_gd'] ?? null,
            'pRound' => $params['pRound'] ?? null,
            'pRoundNT' => $params['pRoundNT'] ?? null,
            'pluser' => $params['pluser'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPostPoPh3_inct with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param int $NamTC
     * @param int $ThangTC
     * @param string $Ngay_ct
     * @param string $Ngay_ks
     * @param string $Ma_gd
     * @param int $Round
     * @param int $RoundNT
     * @param string $luser
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, int $NamTC = null, int $ThangTC = null, string $Ngay_ct = null, string $Ngay_ks = null, string $Ma_gd = null, int $Round = null, int $RoundNT = null, string $luser = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pNamTC' => $NamTC,
            'pThangTC' => $ThangTC,
            'pNgay_ct' => $Ngay_ct,
            'pNgay_ks' => $Ngay_ks,
            'pMa_gd' => $Ma_gd,
            'pRound' => $Round,
            'pRoundNT' => $RoundNT,
            'pluser' => $luser
        ];
        
        return self::call($params);
    }
}
