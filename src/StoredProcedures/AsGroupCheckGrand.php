<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:41
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsGroupCheckGrand
{
    /**
     * Call stored procedure asGroupCheckGrand
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGroupCheckGrand', [
            'pUserName' => $paramObj->pUserName ?? null,
            'pCheck' => $paramObj->pCheck ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asGroupCheckGrand with named parameters
     *
     * @param string $UserName
     * @param mixed $Check
     * @return Collection
     */
    public static function callWithParams(string $UserName = null, mixed $Check = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pCheck' => $Check
        ];

        return self::call($params);
    }
}
