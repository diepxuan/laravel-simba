<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetDmTCDanhGiaCT
{
    /**
     * Call stored procedure asHrGetDmTCDanhGiaCT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetDmTCDanhGiaCT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_tcdg' => $params['pMa_tcdg'] ?? null,
            'pId_diem' => $params['pId_diem'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetDmTCDanhGiaCT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tcdg
     * @param string $Id_diem
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tcdg = null, string $Id_diem = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tcdg' => $Ma_tcdg,
            'pId_diem' => $Id_diem
        ];
        
        return self::call($params);
    }
}
