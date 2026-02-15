<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetDmKhacDsResx
{
    /**
     * Call stored procedure asHrGetDmKhacDsResx
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetDmKhacDsResx', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pCode_name' => $params['pCode_name'] ?? null,
            'pLanguage' => $params['pLanguage'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetDmKhacDsResx with named parameters
     *
     * @param string $Ma_cty
     * @param string $Code_name
     * @param string $Language
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Code_name = null, string $Language = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pCode_name' => $Code_name,
            'pLanguage' => $Language
        ];
        
        return self::call($params);
    }
}
