<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:47
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AssiUpd_ks
{
    /**
     * Call stored procedure assiUpd_ks
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('assiUpd_ks', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay_ks' => $params['pNgay_ks'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure assiUpd_ks with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay_ks
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay_ks = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay_ks' => $Ngay_ks,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
