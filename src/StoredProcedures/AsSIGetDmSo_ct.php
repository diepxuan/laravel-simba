<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:02
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIGetDmSo_ct
{
    /**
     * Call stored procedure asSIGetDmSo_ct
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIGetDmSo_ct', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pPhan_he' => $params['pPhan_he'] ?? null,
            'pStruct' => $params['pStruct'] ?? null,
            'pLanguageId' => $params['pLanguageId'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIGetDmSo_ct with named parameters
     *
     * @param string $Ma_cty
     * @param string $Phan_he
     * @param string $Struct
     * @param string $LanguageId
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Phan_he = null, string $Struct = null, string $LanguageId = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pPhan_he' => $Phan_he,
            'pStruct' => $Struct,
            'pLanguageId' => $LanguageId
        ];
        
        return self::call($params);
    }
}
