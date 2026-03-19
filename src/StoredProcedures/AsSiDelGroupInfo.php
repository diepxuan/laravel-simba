<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSiDelGroupInfo
{
    /**
     * Call stored procedure asSiDelGroupInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiDelGroupInfo', [
            'pGroupname' => $paramObj->pGroupname ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiDelGroupInfo with named parameters
     *
     * @param string $Groupname
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Groupname = null, int $Ret = null): Collection
    {
        $params = [
            'pGroupname' => $Groupname,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
