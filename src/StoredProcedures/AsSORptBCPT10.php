<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSORptBCPT10
{
    /**
     * Call stored procedure asSORptBCPT10
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptBCPT10', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pMa_TT' => $params['pMa_TT'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pMa_nhhd' => $params['pMa_nhhd'] ?? null,
            'pSoct1' => $params['pSoct1'] ?? null,
            'pSoct2' => $params['pSoct2'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptBCPT10 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_TT
     * @param string $Ma_hd
     * @param string $Ma_nhhd
     * @param string $Soct1
     * @param string $Soct2
     * @param string $Ma_nt
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_TT = null, string $Ma_hd = null, string $Ma_nhhd = null, string $Soct1 = null, string $Soct2 = null, string $Ma_nt = null, string $ParamDefines = null, string $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_TT' => $Ma_TT,
            'pMa_hd' => $Ma_hd,
            'pMa_nhhd' => $Ma_nhhd,
            'pSoct1' => $Soct1,
            'pSoct2' => $Soct2,
            'pMa_nt' => $Ma_nt,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty
        ];
        
        return self::call($params);
    }
}
