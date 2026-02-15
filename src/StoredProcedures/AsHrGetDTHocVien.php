<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:56
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetDTHocVien
{
    /**
     * Call stored procedure asHrGetDTHocVien
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetDTHocVien', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_kdt' => $params['pMa_kdt'] ?? null,
            'pMa_ldt' => $params['pMa_ldt'] ?? null,
            'pId' => $params['pId'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetDTHocVien with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_kdt
     * @param string $Ma_ldt
     * @param string $Id
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_kdt = null, string $Ma_ldt = null, string $Id = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kdt' => $Ma_kdt,
            'pMa_ldt' => $Ma_ldt,
            'pId' => $Id
        ];
        
        return self::call($params);
    }
}
