<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:11
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdCurentCultureInfo
{
    /**
     * Call stored procedure asUpdCurentCultureInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdCurentCultureInfo', [
            'pName' => $params['pName'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdCurentCultureInfo with named parameters
     *
     * @param string $Name
     * @return Collection
     */
    public static function callWithParams(string $Name = null): Collection
    {
        $params = [
            'pName' => $Name
        ];
        
        return self::call($params);
    }
}
