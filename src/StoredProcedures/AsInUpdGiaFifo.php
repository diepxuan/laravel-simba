<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInUpdGiaFifo
{
    /**
     * Call stored procedure asInUpdGiaFifo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInUpdGiaFifo', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pMa_cty' => $params['pMa_cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInUpdGiaFifo with named parameters
     *
     * @param string $ma_cty
     * @param mixed $Ma_cty
     * @return Collection
     */
    public static function callWithParams(string $ma_cty = null, mixed $Ma_cty = null): Collection
    {
        $params = [
            'pma_cty' => $ma_cty,
            'pMa_cty' => $Ma_cty
        ];
        
        return self::call($params);
    }
}
