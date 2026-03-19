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

class AsSIInsLogUpdate
{
    /**
     * Call stored procedure asSIInsLogUpdate
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIInsLogUpdate', [
            'pUserName' => $paramObj->pUserName ?? null,
            'pContent' => $paramObj->pContent ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIInsLogUpdate with named parameters
     *
     * @param string $UserName
     * @param string $Content
     * @return Collection
     */
    public static function callWithParams(string $UserName = null, string $Content = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pContent' => $Content
        ];

        return self::call($params);
    }
}
