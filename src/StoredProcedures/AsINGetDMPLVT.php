<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:01
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINGetDMPLVT
{
    /**
     * Call stored procedure asINGetDMPLVT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINGetDMPLVT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_plvt' => $params['pMa_plvt'] ?? null,
            'pStruct' => $params['pStruct'] ?? null,
            'pLoai' => $params['pLoai'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINGetDMPLVT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_plvt
     * @param string $Struct
     * @param string $Loai
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_plvt = null, string $Struct = null, string $Loai = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_plvt' => $Ma_plvt,
            'pStruct' => $Struct,
            'pLoai' => $Loai
        ];
        
        return self::call($params);
    }
}
