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

class AsHrInsHSNSPhuCap
{
    /**
     * Call stored procedure asHrInsHSNSPhuCap
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsHSNSPhuCap', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pMa' => $params['pMa'] ?? null,
            'pTen' => $params['pTen'] ?? null,
            'pHs_phu_cap' => $params['pHs_phu_cap'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsHSNSPhuCap with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Ma
     * @param string $Ten
     * @param float $Hs_phu_cap
     * @param string $Ghi_chu
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Ma = null, string $Ten = null, float $Hs_phu_cap = null, string $Ghi_chu = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pMa' => $Ma,
            'pTen' => $Ten,
            'pHs_phu_cap' => $Hs_phu_cap,
            'pGhi_chu' => $Ghi_chu,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
