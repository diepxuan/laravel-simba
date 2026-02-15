<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:58
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPoGetSetup
{
    /**
     * Call stored procedure asPoGetSetup
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPoGetSetup', [
            'pMa_Cty' => $params['pMa_Cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPoGetSetup with named parameters
     *
     * @param string $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_Cty' => $Ma_Cty
        ];
        
        return self::call($params);
    }
}
