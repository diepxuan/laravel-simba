<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:20
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AssiDeldmngh
{
    /**
     * Call stored procedure assiDeldmngh
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('assiDeldmngh', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_ngh' => $params['pMa_ngh'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure assiDeldmngh with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_ngh
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_ngh = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_ngh' => $Ma_ngh,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
