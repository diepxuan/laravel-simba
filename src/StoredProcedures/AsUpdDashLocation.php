<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdDashLocation
{
    /**
     * Call stored procedure asUpdDashLocation
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdDashLocation', [
            'pUserName' => $params['pUserName'] ?? null,
            'pDashIdSrc' => $params['pDashIdSrc'] ?? null,
            'pLocationTar' => $params['pLocationTar'] ?? null,
            'pXTar' => $params['pXTar'] ?? null,
            'pYTar' => $params['pYTar'] ?? null,
            'pHSrc' => $params['pHSrc'] ?? null,
            'pWSrc' => $params['pWSrc'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdDashLocation with named parameters
     *
     * @param string $UserName
     * @param int $DashIdSrc
     * @param int $LocationTar
     * @param int $XTar
     * @param int $YTar
     * @param int $HSrc
     * @param int $WSrc
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $UserName = null, int $DashIdSrc = null, int $LocationTar = null, int $XTar = null, int $YTar = null, int $HSrc = null, int $WSrc = null, int $Ret = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pDashIdSrc' => $DashIdSrc,
            'pLocationTar' => $LocationTar,
            'pXTar' => $XTar,
            'pYTar' => $YTar,
            'pHSrc' => $HSrc,
            'pWSrc' => $WSrc,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
