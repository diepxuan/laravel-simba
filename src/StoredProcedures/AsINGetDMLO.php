<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:01
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINGetDMLO
{
    /**
     * Call stored procedure asINGetDMLO
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINGetDMLO', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pStruct' => $params['pStruct'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINGetDMLO with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_lo
     * @param string $Struct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_lo = null, string $Struct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_lo' => $Ma_lo,
            'pStruct' => $Struct
        ];
        
        return self::call($params);
    }
}
