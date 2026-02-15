<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINGetDMNHVT
{
    /**
     * Call stored procedure asINGetDMNHVT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINGetDMNHVT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pStruct' => $params['pStruct'] ?? null,
            'pStt_nhom' => $params['pStt_nhom'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINGetDMNHVT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_nhvt
     * @param string $Struct
     * @param mixed $Stt_nhom
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_nhvt = null, string $Struct = null, mixed $Stt_nhom = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_nhvt' => $Ma_nhvt,
            'pStruct' => $Struct,
            'pStt_nhom' => $Stt_nhom
        ];
        
        return self::call($params);
    }
}
