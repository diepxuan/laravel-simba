<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:53
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSAGetDmCongDoan
{
    /**
     * Call stored procedure asSAGetDmCongDoan
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAGetDmCongDoan', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_sanpham' => $params['pMa_sanpham'] ?? null,
            'pMa_congdoan' => $params['pMa_congdoan'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSAGetDmCongDoan with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_sanpham
     * @param string $Ma_congdoan
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_sanpham = null, string $Ma_congdoan = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_sanpham' => $Ma_sanpham,
            'pMa_congdoan' => $Ma_congdoan
        ];
        
        return self::call($params);
    }
}
