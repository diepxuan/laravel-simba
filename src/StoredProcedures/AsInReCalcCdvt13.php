<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInReCalcCdvt13
{
    /**
     * Call stored procedure asInReCalcCdvt13
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInReCalcCdvt13', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pNam' => $params['pNam'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInReCalcCdvt13 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_vt
     * @param int $Nam
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_vt = null, int $Nam = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_vt' => $Ma_vt,
            'pNam' => $Nam
        ];
        
        return self::call($params);
    }
}
