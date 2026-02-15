<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:43
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetTDVongThi
{
    /**
     * Call stored procedure asHrGetTDVongThi
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetTDVongThi', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_yctd' => $params['pMa_yctd'] ?? null,
            'pVong_so' => $params['pVong_so'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetTDVongThi with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_yctd
     * @param string $Vong_so
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_yctd = null, string $Vong_so = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_yctd' => $Ma_yctd,
            'pVong_so' => $Vong_so
        ];
        
        return self::call($params);
    }
}
