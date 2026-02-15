<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:07
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSODelND51dmmhdph
{
    /**
     * Call stored procedure asSODelND51dmmhdph
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSODelND51dmmhdph', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMau_so' => $params['pMau_so'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSODelND51dmmhdph with named parameters
     *
     * @param string $Ma_cty
     * @param string $Mau_so
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Mau_so = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMau_so' => $Mau_so,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
