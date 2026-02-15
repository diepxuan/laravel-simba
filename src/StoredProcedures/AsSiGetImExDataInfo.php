<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:20
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSiGetImExDataInfo
{
    /**
     * Call stored procedure asSiGetImExDataInfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiGetImExDataInfo', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pCodeName' => $params['pCodeName'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiGetImExDataInfo with named parameters
     *
     * @param string $Ma_Cty
     * @param string $CodeName
     * @return Collection
     */
    public static function callWithParams(string $Ma_Cty = null, string $CodeName = null): Collection
    {
        $params = [
            'pMa_Cty' => $Ma_Cty,
            'pCodeName' => $CodeName
        ];
        
        return self::call($params);
    }
}
