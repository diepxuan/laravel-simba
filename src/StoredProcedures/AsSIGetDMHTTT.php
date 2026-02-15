<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIGetDMHTTT
{
    /**
     * Call stored procedure asSIGetDMHTTT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDMHTTT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_httt' => $params['pMa_httt'] ?? null,
            'pModuleid' => $params['pModuleid'] ?? null,
            'pStruct' => $params['pStruct'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIGetDMHTTT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_httt
     * @param string $Moduleid
     * @param string $Struct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_httt = null, string $Moduleid = null, string $Struct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_httt' => $Ma_httt,
            'pModuleid' => $Moduleid,
            'pStruct' => $Struct
        ];
        
        return self::call($params);
    }
}
