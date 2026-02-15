<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:24
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsUserInfo
{
    /**
     * Call stored procedure asInsUserInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsUserInfo', $params, $connection);
    }

    /**
     * Call stored procedure asInsUserInfo with named parameters
     *
     * @param string $UserName
     * @param string $FullName
     * @param string $Password
     * @param bool $IsAdmin
     * @param bool $Grand
     * @param bool $Disabled
     * @param string $User
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $UserName = null, string $FullName = null, string $Password = null, bool $IsAdmin = null, bool $Grand = null, bool $Disabled = null, string $User = null, int $Ret = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pFullName' => $FullName,
            'pPassword' => $Password,
            'pIsAdmin' => $IsAdmin,
            'pGrand' => $Grand,
            'pDisabled' => $Disabled,
            'pUser' => $User,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
