<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetDmKhac
{
    /**
     * Call stored procedure asHrGetDmKhac
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetDmKhac', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pCode_name' => $params['pCode_name'] ?? null,
            'pMa' => $params['pMa'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetDmKhac with named parameters
     *
     * @param string $Ma_cty
     * @param string $Code_name
     * @param string $Ma
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Code_name = null, string $Ma = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pCode_name' => $Code_name,
            'pMa' => $Ma
        ];
        
        return self::call($params);
    }
}
