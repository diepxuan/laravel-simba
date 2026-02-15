<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:06
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetDmNhomDanhGiaPH
{
    /**
     * Call stored procedure asHrGetDmNhomDanhGiaPH
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetDmNhomDanhGiaPH', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_nhdg' => $params['pMa_nhdg'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetDmNhomDanhGiaPH with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_nhdg
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_nhdg = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_nhdg' => $Ma_nhdg
        ];
        
        return self::call($params);
    }
}
