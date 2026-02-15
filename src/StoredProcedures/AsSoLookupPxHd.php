<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:20:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSoLookupPxHd
{
    /**
     * Call stored procedure asSoLookupPxHd
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSoLookupPxHd', $params, $connection);
    }

    /**
     * Call stored procedure asSoLookupPxHd with named parameters
     *
     * @param string $Ma_cty
     * @param string $Key
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Key = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pKey' => $Key
        ];
        
        return self::call($params);
    }
}
