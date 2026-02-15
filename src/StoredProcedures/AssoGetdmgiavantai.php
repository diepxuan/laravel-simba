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

class AssoGetdmgiavantai
{
    /**
     * Call stored procedure assoGetdmgiavantai
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('assoGetdmgiavantai', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_td' => $params['pMa_td'] ?? null,
            'pMa_pt' => $params['pMa_pt'] ?? null,
            'pStruct' => $params['pStruct'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure assoGetdmgiavantai with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_td
     * @param string $Ma_pt
     * @param string $Struct
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_td = null, string $Ma_pt = null, string $Struct = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_td' => $Ma_td,
            'pMa_pt' => $Ma_pt,
            'pStruct' => $Struct
        ];
        
        return self::call($params);
    }
}
