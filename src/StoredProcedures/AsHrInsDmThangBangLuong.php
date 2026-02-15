<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsDmThangBangLuong
{
    /**
     * Call stored procedure asHrInsDmThangBangLuong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsDmThangBangLuong', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_tbl' => $params['pMa_tbl'] ?? null,
            'pTen_tbl' => $params['pTen_tbl'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsDmThangBangLuong with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tbl
     * @param string $Ten_tbl
     * @param bool $Ksd
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tbl = null, string $Ten_tbl = null, bool $Ksd = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tbl' => $Ma_tbl,
            'pTen_tbl' => $Ten_tbl,
            'pKsd' => $Ksd,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
