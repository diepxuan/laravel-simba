<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:45
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsUserGroup
{
    /**
     * Call stored procedure asInsUserGroup
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsUserGroup', [
            'pGroupName' => $params['pGroupName'] ?? null,
            'pUserName' => $params['pUserName'] ?? null,
            'pDel' => $params['pDel'] ?? null,
            'pRet' => $params['pRet'] ?? null,
            'pusername' => $params['pusername'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsUserGroup with named parameters
     *
     * @param string $GroupName
     * @param string $UserName
     * @param mixed $Del
     * @param int $Ret
     * @param mixed $username
     * @return Collection
     */
    public static function callWithParams(string $GroupName = null, string $UserName = null, mixed $Del = null, int $Ret = null, mixed $username = null): Collection
    {
        $params = [
            'pGroupName' => $GroupName,
            'pUserName' => $UserName,
            'pDel' => $Del,
            'pRet' => $Ret,
            'pusername' => $username
        ];
        
        return self::call($params);
    }
}
