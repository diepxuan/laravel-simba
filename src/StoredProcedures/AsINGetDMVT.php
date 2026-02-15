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

class AsINGetDMVT
{
    /**
     * Call stored procedure asINGetDMVT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINGetDMVT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pStruct' => $params['pStruct'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINGetDMVT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_vt
     * @param string $Struct
     * @param string $Language
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_vt = null, string $Struct = null, string $Language = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_vt' => $Ma_vt,
            'pStruct' => $Struct,
            'pLanguage' => $Language
        ];
        
        return self::call($params);
    }
}
