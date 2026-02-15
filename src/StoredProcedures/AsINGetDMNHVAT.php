<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:57
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINGetDMNHVAT
{
    /**
     * Call stored procedure asINGetDMNHVAT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINGetDMNHVAT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_nhvat' => $params['pMa_nhvat'] ?? null,
            'pStruct' => $params['pStruct'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINGetDMNHVAT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_nhvat
     * @param string $Struct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_nhvat = null, string $Struct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_nhvat' => $Ma_nhvat,
            'pStruct' => $Struct
        ];
        
        return self::call($params);
    }
}
