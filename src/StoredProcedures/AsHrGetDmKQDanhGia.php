<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:58
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetDmKQDanhGia
{
    /**
     * Call stored procedure asHrGetDmKQDanhGia
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetDmKQDanhGia', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_kqdg' => $params['pMa_kqdg'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetDmKQDanhGia with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_kqdg
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_kqdg = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kqdg' => $Ma_kqdg
        ];
        
        return self::call($params);
    }
}
