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
use Diepxuan\Simba\Helper\ParamHelper;

class AsSOGetND51bkhd
{
    /**
     * Call stored procedure asSOGetND51bkhd
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetND51bkhd', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_tb' => $paramObj->pMa_tb ?? null,
            'pStruct' => $paramObj->pStruct ?? null,
            'pModuleId' => $paramObj->pModuleId ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOGetND51bkhd with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tb
     * @param string $Struct
     * @param string $ModuleId
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tb = null, string $Struct = null, string $ModuleId = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tb' => $Ma_tb,
            'pStruct' => $Struct,
            'pModuleId' => $ModuleId
        ];

        return self::call($params);
    }
}
