<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrDelTDVongThi
{
    /**
     * Call stored procedure asHrDelTDVongThi
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrDelTDVongThi', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_yctd' => $params['pMa_yctd'] ?? null,
            'pVong_so' => $params['pVong_so'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrDelTDVongThi with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_yctd
     * @param string $Vong_so
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_yctd = null, string $Vong_so = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_yctd' => $Ma_yctd,
            'pVong_so' => $Vong_so,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
