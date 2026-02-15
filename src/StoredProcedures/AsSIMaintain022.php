<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:52
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIMaintain022
{
    /**
     * Call stored procedure asSIMaintain022
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIMaintain022', $params, $connection);
    }

    /**
     * Call stored procedure asSIMaintain022 with named parameters
     *
     * @param string $Ma_cty
     * @param string $str_ma
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $str_ma = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pstr_ma' => $str_ma
        ];
        
        return self::call($params);
    }
}
