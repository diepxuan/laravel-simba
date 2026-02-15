<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:55
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsMMDeldmlo
{
    /**
     * Call stored procedure asMMDeldmlo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asMMDeldmlo', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_lo_tp' => $params['pMa_lo_tp'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asMMDeldmlo with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_lo_tp
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_lo_tp = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_lo_tp' => $Ma_lo_tp,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
