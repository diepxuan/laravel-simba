<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsLogCT4Delete
{
    /**
     * Call stored procedure asInsLogCT4Delete
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsLogCT4Delete', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pStt_rec' => $params['pStt_rec'] ?? null,
            'pUser' => $params['pUser'] ?? null,
            'pTable' => $params['pTable'] ?? null,
            'pAction' => $params['pAction'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsLogCT4Delete with named parameters
     *
     * @param string $Ma_cty
     * @param string $Stt_rec
     * @param string $User
     * @param string $Table
     * @param string $Action
     * @param string $ParamDefines
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Stt_rec = null, string $User = null, string $Table = null, string $Action = null, string $ParamDefines = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pStt_rec' => $Stt_rec,
            'pUser' => $User,
            'pTable' => $Table,
            'pAction' => $Action,
            'ParamDefines' => $ParamDefines
        ];
        
        return self::call($params);
    }
}
