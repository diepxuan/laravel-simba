<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:10
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOGetND51phhdct
{
    /**
     * Call stored procedure asSOGetND51phhdct
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetND51phhdct', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_tb' => $params['pMa_tb'] ?? null,
            'pChap_nhan' => $params['pChap_nhan'] ?? null,
            'pStruct' => $params['pStruct'] ?? null,
            'pModuleId' => $params['pModuleId'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOGetND51phhdct with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tb
     * @param bool $Chap_nhan
     * @param string $Struct
     * @param string $ModuleId
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tb = null, bool $Chap_nhan = null, string $Struct = null, string $ModuleId = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tb' => $Ma_tb,
            'pChap_nhan' => $Chap_nhan,
            'pStruct' => $Struct,
            'pModuleId' => $ModuleId
        ];
        
        return self::call($params);
    }
}
