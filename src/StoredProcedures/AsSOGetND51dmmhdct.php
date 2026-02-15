<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOGetND51dmmhdct
{
    /**
     * Call stored procedure asSOGetND51dmmhdct
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetND51dmmhdct', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau_so' => $params['pMau_so'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOGetND51dmmhdct with named parameters
     *
     * @param string $Ma_cty
     * @param string $Mau_so
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Mau_so = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMau_so' => $Mau_so
        ];
        
        return self::call($params);
    }
}
