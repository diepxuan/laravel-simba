<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdUserObjectRight
{
    /**
     * Call stored procedure asUpdUserObjectRight
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdUserObjectRight', [
            'pUserName' => $params['pUserName'] ?? null,
            'pMenuID' => $params['pMenuID'] ?? null,
            'pObjectName' => $params['pObjectName'] ?? null,
            'pViewRight' => $params['pViewRight'] ?? null,
            'pEditRight' => $params['pEditRight'] ?? null,
            'pAddRight' => $params['pAddRight'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdUserObjectRight with named parameters
     *
     * @param string $UserName
     * @param string $MenuID
     * @param string $ObjectName
     * @param string $ViewRight
     * @param string $EditRight
     * @param string $AddRight
     * @return Collection
     */
    public static function callWithParams(string $UserName = null, string $MenuID = null, string $ObjectName = null, string $ViewRight = null, string $EditRight = null, string $AddRight = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pMenuID' => $MenuID,
            'pObjectName' => $ObjectName,
            'pViewRight' => $ViewRight,
            'pEditRight' => $EditRight,
            'pAddRight' => $AddRight
        ];
        
        return self::call($params);
    }
}
