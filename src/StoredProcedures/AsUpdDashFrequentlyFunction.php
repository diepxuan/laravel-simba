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

class AsUpdDashFrequentlyFunction
{
    /**
     * Call stored procedure asUpdDashFrequentlyFunction
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdDashFrequentlyFunction', [
            'pUserName' => $params['pUserName'] ?? null,
            'pMenuID' => $params['pMenuID'] ?? null,
            'pDashID' => $params['pDashID'] ?? null,
            'pSpace' => $params['pSpace'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdDashFrequentlyFunction with named parameters
     *
     * @param string $UserName
     * @param string $MenuID
     * @param int $DashID
     * @param bool $Space
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $UserName = null, string $MenuID = null, int $DashID = null, bool $Space = null, int $Ret = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pMenuID' => $MenuID,
            'pDashID' => $DashID,
            'pSpace' => $Space,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
