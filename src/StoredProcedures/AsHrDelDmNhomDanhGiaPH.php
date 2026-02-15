<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:46
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrDelDmNhomDanhGiaPH
{
    /**
     * Call stored procedure asHrDelDmNhomDanhGiaPH
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrDelDmNhomDanhGiaPH', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_nhdg' => $params['pMa_nhdg'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrDelDmNhomDanhGiaPH with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_nhdg
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_nhdg = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_nhdg' => $Ma_nhdg,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
