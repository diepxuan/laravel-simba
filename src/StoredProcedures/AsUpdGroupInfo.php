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

class AsUpdGroupInfo
{
    /**
     * Call stored procedure asUpdGroupInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdGroupInfo', [
            'pGroupname' => $params['pGroupname'] ?? null,
            'pFullname' => $params['pFullname'] ?? null,
            'pGrand' => $params['pGrand'] ?? null,
            'pKSD' => $params['pKSD'] ?? null,
            'pUser' => $params['pUser'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdGroupInfo with named parameters
     *
     * @param string $Groupname
     * @param string $Fullname
     * @param bool $Grand
     * @param bool $KSD
     * @param string $User
     * @return Collection
     */
    public static function callWithParams(string $Groupname = null, string $Fullname = null, bool $Grand = null, bool $KSD = null, string $User = null): Collection
    {
        $params = [
            'pGroupname' => $Groupname,
            'pFullname' => $Fullname,
            'pGrand' => $Grand,
            'pKSD' => $KSD,
            'pUser' => $User
        ];
        
        return self::call($params);
    }
}
