<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:59
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSODelND51dmqdadhd
{
    /**
     * Call stored procedure asSODelND51dmqdadhd
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSODelND51dmqdadhd', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_qd' => $params['pMa_qd'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSODelND51dmqdadhd with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_qd
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_qd = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_qd' => $Ma_qd,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
