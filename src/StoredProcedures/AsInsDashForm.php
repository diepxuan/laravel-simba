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

class AsInsDashForm
{
    /**
     * Call stored procedure asInsDashForm
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsDashForm', [
            'pUsername' => $params['pUsername'] ?? null,
            'pTitle' => $params['pTitle'] ?? null,
            'pFunctionID' => $params['pFunctionID'] ?? null,
            'pFormat' => $params['pFormat'] ?? null,
            'pLocation' => $params['pLocation'] ?? null,
            'pX' => $params['pX'] ?? null,
            'pY' => $params['pY'] ?? null,
            'pH' => $params['pH'] ?? null,
            'pW' => $params['pW'] ?? null,
            'pType' => $params['pType'] ?? null,
            'pDashId' => $params['pDashId'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsDashForm with named parameters
     *
     * @param string $Username
     * @param string $Title
     * @param string $FunctionID
     * @param string $Format
     * @param int $Location
     * @param int $X
     * @param int $Y
     * @param int $H
     * @param int $W
     * @param string $Type
     * @param int $DashId
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Username = null, string $Title = null, string $FunctionID = null, string $Format = null, int $Location = null, int $X = null, int $Y = null, int $H = null, int $W = null, string $Type = null, int $DashId = null, int $Ret = null): Collection
    {
        $params = [
            'pUsername' => $Username,
            'pTitle' => $Title,
            'pFunctionID' => $FunctionID,
            'pFormat' => $Format,
            'pLocation' => $Location,
            'pX' => $X,
            'pY' => $Y,
            'pH' => $H,
            'pW' => $W,
            'pType' => $Type,
            'pDashId' => $DashId,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
