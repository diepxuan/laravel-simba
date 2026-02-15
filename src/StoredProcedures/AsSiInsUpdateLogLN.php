<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiInsUpdateLogLN
{
    /**
     * Call stored procedure asSiInsUpdateLogLN
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiInsUpdateLogLN', [
            'pProductid' => $params['pProductid'] ?? null,
            'pChildID' => $params['pChildID'] ?? null,
            'pLinkNumber' => $params['pLinkNumber'] ?? null,
            'pMaxLevel' => $params['pMaxLevel'] ?? null,
            'pBugLevel' => $params['pBugLevel'] ?? null,
            'pChildLevel' => $params['pChildLevel'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiInsUpdateLogLN with named parameters
     *
     * @param string $Productid
     * @param int $ChildID
     * @param string $LinkNumber
     * @param string $MaxLevel
     * @param string $BugLevel
     * @param string $ChildLevel
     * @return Collection
     */
    public static function callWithParams(string $Productid = null, int $ChildID = null, string $LinkNumber = null, string $MaxLevel = null, string $BugLevel = null, string $ChildLevel = null): Collection
    {
        $params = [
            'pProductid' => $Productid,
            'pChildID' => $ChildID,
            'pLinkNumber' => $LinkNumber,
            'pMaxLevel' => $MaxLevel,
            'pBugLevel' => $BugLevel,
            'pChildLevel' => $ChildLevel
        ];
        
        return self::call($params);
    }
}
