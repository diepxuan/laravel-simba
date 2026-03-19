<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSOGetDMNVKD
{
    /**
     * Call stored procedure asSOGetDMNVKD
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetDMNVKD', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_nvkd' => $paramObj->pMa_nvkd ?? null,
            'pStruct' => $paramObj->pStruct ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOGetDMNVKD with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_nvkd
     * @param string $Struct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_nvkd = null, string $Struct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_nvkd' => $Ma_nvkd,
            'pStruct' => $Struct
        ];

        return self::call($params);
    }
}
