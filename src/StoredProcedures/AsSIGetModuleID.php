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

class AsSIGetModuleID
{
    /**
     * Call stored procedure asSIGetModuleID
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetModuleID', [
            'pmenuid' => $params['pmenuid'] ?? null,
            'pStruct' => $params['pStruct'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIGetModuleID with named parameters
     *
     * @param string $menuid
     * @param string $Struct
     * @return Collection
     */
    public static function callWithParams(string $menuid = null, string $Struct = null): Collection
    {
        $params = [
            'pmenuid' => $menuid,
            'pStruct' => $Struct
        ];
        
        return self::call($params);
    }
}
