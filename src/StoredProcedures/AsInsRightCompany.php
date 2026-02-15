<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:57
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsRightCompany
{
    /**
     * Call stored procedure asInsRightCompany
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsRightCompany', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pUsername' => $params['pUsername'] ?? null,
            'pActive' => $params['pActive'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsRightCompany with named parameters
     *
     * @param string $Ma_cty
     * @param string $Username
     * @param bool $Active
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Username = null, bool $Active = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pUsername' => $Username,
            'pActive' => $Active,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
