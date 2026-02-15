<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:43
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIGetDMNGH
{
    /**
     * Call stored procedure asSIGetDMNGH
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMNGH', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ngh' => $params['pMa_ngh'] ?? null,
            'pStruct' => $params['pStruct'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIGetDMNGH with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ngh
     * @param string $Struct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ngh = null, string $Struct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ngh' => $Ma_ngh,
            'pStruct' => $Struct
        ];
        
        return self::call($params);
    }
}
