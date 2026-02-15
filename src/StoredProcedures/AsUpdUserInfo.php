<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:02
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdUserInfo
{
    /**
     * Call stored procedure asUpdUserInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdUserInfo', [
            'pUserName' => $params['pUserName'] ?? null,
            'pFullName' => $params['pFullName'] ?? null,
            'pIsAdmin' => $params['pIsAdmin'] ?? null,
            'pGrand' => $params['pGrand'] ?? null,
            'pDisabled' => $params['pDisabled'] ?? null,
            'pUser' => $params['pUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdUserInfo with named parameters
     *
     * @param string $UserName
     * @param string $FullName
     * @param bool $IsAdmin
     * @param bool $Grand
     * @param bool $Disabled
     * @param string $User
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $UserName = null, string $FullName = null, bool $IsAdmin = null, bool $Grand = null, bool $Disabled = null, string $User = null, int $Ret = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pFullName' => $FullName,
            'pIsAdmin' => $IsAdmin,
            'pGrand' => $Grand,
            'pDisabled' => $Disabled,
            'pUser' => $User,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
