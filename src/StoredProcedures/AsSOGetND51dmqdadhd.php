<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:45
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOGetND51dmqdadhd
{
    /**
     * Call stored procedure asSOGetND51dmqdadhd
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetND51dmqdadhd', [
            'pMa_cty' => $params['pMa_cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOGetND51dmqdadhd with named parameters
     *
     * @param string $Ma_cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty
        ];
        
        return self::call($params);
    }
}
