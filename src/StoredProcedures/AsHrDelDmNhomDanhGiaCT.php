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

class AsHrDelDmNhomDanhGiaCT
{
    /**
     * Call stored procedure asHrDelDmNhomDanhGiaCT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrDelDmNhomDanhGiaCT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_nhdg' => $params['pMa_nhdg'] ?? null,
            'pMa_tcdg' => $params['pMa_tcdg'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrDelDmNhomDanhGiaCT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_nhdg
     * @param string $Ma_tcdg
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_nhdg = null, string $Ma_tcdg = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_nhdg' => $Ma_nhdg,
            'pMa_tcdg' => $Ma_tcdg,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
