<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:53
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInGetTonKhoTucThoi
{
    /**
     * Call stored procedure asInGetTonKhoTucThoi
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInGetTonKhoTucThoi', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay_ct' => $params['pNgay_ct'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pTon_ht' => $params['pTon_ht'] ?? null,
            'pTon_tc' => $params['pTon_tc'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInGetTonKhoTucThoi with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay_ct
     * @param string $Ma_kho
     * @param string $Ma_vt
     * @param float $Ton_ht
     * @param float $Ton_tc
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay_ct = null, string $Ma_kho = null, string $Ma_vt = null, float $Ton_ht = null, float $Ton_tc = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay_ct' => $Ngay_ct,
            'pMa_kho' => $Ma_kho,
            'pMa_vt' => $Ma_vt,
            'pTon_ht' => $Ton_ht,
            'pTon_tc' => $Ton_tc
        ];
        
        return self::call($params);
    }
}
