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

class AsSiGetAllGroupRights
{
    /**
     * Call stored procedure asSiGetAllGroupRights
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiGetAllGroupRights', [
            'pGroupName' => $params['pGroupName'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiGetAllGroupRights with named parameters
     *
     * @param string $GroupName
     * @return Collection
     */
    public static function callWithParams(string $GroupName = null): Collection
    {
        $params = [
            'pGroupName' => $GroupName
        ];
        
        return self::call($params);
    }
}
