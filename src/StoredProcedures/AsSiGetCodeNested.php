<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiGetCodeNested
{
    /**
     * Call stored procedure asSiGetCodeNested
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiGetCodeNested', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pTableName' => $params['pTableName'] ?? null,
            'pCode_fName' => $params['pCode_fName'] ?? null,
            'pName_fName' => $params['pName_fName'] ?? null,
            'pMa' => $params['pMa'] ?? null,
            'pQuerry' => $params['pQuerry'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiGetCodeNested with named parameters
     *
     * @param mixed $Ma_cty
     * @param mixed $TableName
     * @param mixed $Code_fName
     * @param mixed $Name_fName
     * @param string $Ma
     * @param mixed $Querry
     * @param string $ParamDefines
     * @return Collection
     */
    public static function callWithParams(mixed $Ma_cty = null, mixed $TableName = null, mixed $Code_fName = null, mixed $Name_fName = null, string $Ma = null, mixed $Querry = null, string $ParamDefines = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pTableName' => $TableName,
            'pCode_fName' => $Code_fName,
            'pName_fName' => $Name_fName,
            'pMa' => $Ma,
            'pQuerry' => $Querry,
            'ParamDefines' => $ParamDefines
        ];
        
        return self::call($params);
    }
}
