<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:45
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOGetDSHD
{
    /**
     * Call stored procedure asSOGetDSHD
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetDSHD', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOGetDSHD with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2
        ];
        
        return self::call($params);
    }
}
