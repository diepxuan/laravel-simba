<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSORptND51phhd
{
    /**
     * Call stored procedure asSORptND51phhd
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptND51phhd', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_tb' => $params['pMa_tb'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptND51phhd with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tb
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tb = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tb' => $Ma_tb
        ];
        
        return self::call($params);
    }
}
