<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:50
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSAGetDmSanPham
{
    /**
     * Call stored procedure asSAGetDmSanPham
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSAGetDmSanPham', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_sanpham' => $params['pMa_sanpham'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSAGetDmSanPham with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_sanpham
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_sanpham = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_sanpham' => $Ma_sanpham
        ];
        
        return self::call($params);
    }
}
