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

class AsInsGroupInfo
{
    /**
     * Call stored procedure asInsGroupInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsGroupInfo', $params, $connection);
    }

    /**
     * Call stored procedure asInsGroupInfo with named parameters
     *
     * @param string $Groupname
     * @param string $Fullname
     * @param bool $Ksd
     * @param bool $Grand
     * @param string $User
     * @return Collection
     */
    public static function callWithParams(string $Groupname = null, string $Fullname = null, bool $Ksd = null, bool $Grand = null, string $User = null): Collection
    {
        $params = [
            'pGroupname' => $Groupname,
            'pFullname' => $Fullname,
            'pKsd' => $Ksd,
            'pGrand' => $Grand,
            'pUser' => $User
        ];
        
        return self::call($params);
    }
}
