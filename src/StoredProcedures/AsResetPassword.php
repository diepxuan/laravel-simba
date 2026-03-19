<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:02
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsResetPassword
{
    /**
     * Call stored procedure asResetPassword
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asResetPassword', [
            'pUserName' => $paramObj->pUserName ?? null,
            'pPassword' => $paramObj->pPassword ?? null,
            'pUser' => $paramObj->pUser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asResetPassword with named parameters
     *
     * @param string $UserName
     * @param string $Password
     * @param string $User
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $UserName = null, string $Password = null, string $User = null, int $Ret = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pPassword' => $Password,
            'pUser' => $User,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
