<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:09
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsPreChkUserLogin
{
    /**
     * Call stored procedure asPreChkUserLogin
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPreChkUserLogin', [
            'pUserName' => $paramObj->pUserName ?? null,
            'pPassword' => $paramObj->pPassword ?? null,
            'pOk' => $paramObj->pOk ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPreChkUserLogin with named parameters
     *
     * @param string $UserName
     * @param string $Password
     * @param int $Ok
     * @return Collection
     */
    public static function callWithParams(string $UserName = null, string $Password = null, int $Ok = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pPassword' => $Password,
            'pOk' => $Ok
        ];

        return self::call($params);
    }
}
