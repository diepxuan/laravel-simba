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

class AsSOGetDMTKM
{
    /**
     * Call stored procedure asSOGetDMTKM
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetDMTKM', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_km' => $params['pMa_km'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pStruct' => $params['pStruct'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOGetDMTKM with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_km
     * @param string $Ma_vt
     * @param string $Struct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_km = null, string $Ma_vt = null, string $Struct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_km' => $Ma_km,
            'pMa_vt' => $Ma_vt,
            'pStruct' => $Struct
        ];
        
        return self::call($params);
    }
}
