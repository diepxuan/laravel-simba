<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOLookupHd4Px
{
    /**
     * Call stored procedure asPOLookupHd4Px
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOLookupHd4Px', $params, $connection);
    }

    /**
     * Call stored procedure asPOLookupHd4Px with named parameters
     *
     * @param string $Ma_cty
     * @param string $Key
     * @param mixed $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Key = null, mixed $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pKey' => $Key,
            'pMa_Cty' => $Ma_Cty
        ];
        
        return self::call($params);
    }
}
