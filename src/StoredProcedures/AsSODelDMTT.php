<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:45
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSODelDMTT
{
    /**
     * Call stored procedure asSODelDMTT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSODelDMTT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_tt' => $params['pMa_tt'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSODelDMTT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tt
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tt = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tt' => $Ma_tt,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
