<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiReOrderVoucherNumber
{
    /**
     * Call stored procedure asSiReOrderVoucherNumber
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiReOrderVoucherNumber', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ct' => $params['pMa_ct'] ?? null,
            'pSo_ct' => $params['pSo_ct'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pUser' => $params['pUser'] ?? null,
            'ph' => $params['ph'] ?? null,
            'prefix' => $params['prefix'] ?? null,
            'pattern' => $params['pattern'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pWidth' => $params['pWidth'] ?? null,
            'pma_cty' => $params['pma_cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiReOrderVoucherNumber with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ct
     * @param string $So_ct
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $User
     * @param mixed $h
     * @param string $refix
     * @param string $attern
     * @param string $ParamDefines
     * @param string $Width
     * @param mixed $ma_cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ct = null, string $So_ct = null, string $Ngay1 = null, string $Ngay2 = null, string $User = null, mixed $h = null, string $refix = null, string $attern = null, string $ParamDefines = null, string $Width = null, mixed $ma_cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ct' => $Ma_ct,
            'pSo_ct' => $So_ct,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pUser' => $User,
            'ph' => $h,
            'prefix' => $refix,
            'pattern' => $attern,
            'ParamDefines' => $ParamDefines,
            'pWidth' => $Width,
            'pma_cty' => $ma_cty
        ];
        
        return self::call($params);
    }
}
