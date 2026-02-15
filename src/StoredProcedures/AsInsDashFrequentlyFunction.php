<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:58
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsDashFrequentlyFunction
{
    /**
     * Call stored procedure asInsDashFrequentlyFunction
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsDashFrequentlyFunction', [
            'pUserName' => $params['pUserName'] ?? null,
            'pMenuId' => $params['pMenuId'] ?? null,
            'pDashID' => $params['pDashID'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsDashFrequentlyFunction with named parameters
     *
     * @param string $UserName
     * @param string $MenuId
     * @param int $DashID
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $UserName = null, string $MenuId = null, int $DashID = null, int $Ret = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pMenuId' => $MenuId,
            'pDashID' => $DashID,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
