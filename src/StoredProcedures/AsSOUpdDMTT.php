<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOUpdDMTT
{
    /**
     * Call stored procedure asSOUpdDMTT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOUpdDMTT', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_tt' => $params['pMa_tt'] ?? null,
            'pMo_ta' => $params['pMo_ta'] ?? null,
            'pHan_ck' => $params['pHan_ck'] ?? null,
            'pTl_ck' => $params['pTl_ck'] ?? null,
            'pHan_tt' => $params['pHan_tt'] ?? null,
            'pLs_qh' => $params['pLs_qh'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLUser' => $params['pLUser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOUpdDMTT with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tt
     * @param string $Mo_ta
     * @param float $Han_ck
     * @param float $Tl_ck
     * @param float $Han_tt
     * @param float $Ls_qh
     * @param bool $Ksd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tt = null, string $Mo_ta = null, float $Han_ck = null, float $Tl_ck = null, float $Han_tt = null, float $Ls_qh = null, bool $Ksd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tt' => $Ma_tt,
            'pMo_ta' => $Mo_ta,
            'pHan_ck' => $Han_ck,
            'pTl_ck' => $Tl_ck,
            'pHan_tt' => $Han_tt,
            'pLs_qh' => $Ls_qh,
            'pKsd' => $Ksd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
