<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetDmTCDanhGiaPH
{
    /**
     * Call stored procedure asHrGetDmTCDanhGiaPH
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetDmTCDanhGiaPH', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_tcdg' => $params['pMa_tcdg'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetDmTCDanhGiaPH with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tcdg
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tcdg = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tcdg' => $Ma_tcdg
        ];
        
        return self::call($params);
    }
}
