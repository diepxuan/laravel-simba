<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIGetDMPHI
{
    /**
     * Call stored procedure asSIGetDMPHI
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMPHI', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pStruct' => $params['pStruct'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIGetDMPHI with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_phi
     * @param string $Struct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_phi = null, string $Struct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_phi' => $Ma_phi,
            'pStruct' => $Struct
        ];
        
        return self::call($params);
    }
}
