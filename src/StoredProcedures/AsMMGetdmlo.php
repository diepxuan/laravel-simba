<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:59
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsMMGetdmlo
{
    /**
     * Call stored procedure asMMGetdmlo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asMMGetdmlo', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_lo_tp' => $params['pMa_lo_tp'] ?? null,
            'pStruct' => $params['pStruct'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asMMGetdmlo with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_lo_tp
     * @param string $Struct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_lo_tp = null, string $Struct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_lo_tp' => $Ma_lo_tp,
            'pStruct' => $Struct
        ];
        
        return self::call($params);
    }
}
