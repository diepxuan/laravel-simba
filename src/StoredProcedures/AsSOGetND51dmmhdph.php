<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:55
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOGetND51dmmhdph
{
    /**
     * Call stored procedure asSOGetND51dmmhdph
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetND51dmmhdph', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau_so' => $params['pMau_so'] ?? null,
            'pStruct' => $params['pStruct'] ?? null,
            'pMuduleId' => $params['pMuduleId'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOGetND51dmmhdph with named parameters
     *
     * @param string $Ma_cty
     * @param string $Mau_so
     * @param string $Struct
     * @param string $MuduleId
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Mau_so = null, string $Struct = null, string $MuduleId = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMau_so' => $Mau_so,
            'pStruct' => $Struct,
            'pMuduleId' => $MuduleId
        ];
        
        return self::call($params);
    }
}
