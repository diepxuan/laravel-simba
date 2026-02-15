<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:52
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOGetND51xlhd
{
    /**
     * Call stored procedure asSOGetND51xlhd
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetND51xlhd', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pKieu_xl' => $params['pKieu_xl'] ?? null,
            'pStruct' => $params['pStruct'] ?? null,
            'pModuleId' => $params['pModuleId'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOGetND51xlhd with named parameters
     *
     * @param string $Ma_cty
     * @param string $Kieu_xl
     * @param string $Struct
     * @param string $ModuleId
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Kieu_xl = null, string $Struct = null, string $ModuleId = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pKieu_xl' => $Kieu_xl,
            'pStruct' => $Struct,
            'pModuleId' => $ModuleId
        ];
        
        return self::call($params);
    }
}
