<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:34
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPOInsDMTT
{
    /**
     * Call stored procedure asPOInsDMTT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPOInsDMTT', $params, $connection);
    }

    /**
     * Call stored procedure asPOInsDMTT with named parameters
     *
     * @param string $Ma_cty
     * @param string $ma_tt_po
     * @param string $Mo_ta
     * @param float $Han_ck
     * @param float $Tl_ck
     * @param float $Han_tt
     * @param float $Ls_qh
     * @param bool $kSd
     * @param string $LUser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $ma_tt_po = null, string $Mo_ta = null, float $Han_ck = null, float $Tl_ck = null, float $Han_tt = null, float $Ls_qh = null, bool $kSd = null, string $LUser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pma_tt_po' => $ma_tt_po,
            'pMo_ta' => $Mo_ta,
            'pHan_ck' => $Han_ck,
            'pTl_ck' => $Tl_ck,
            'pHan_tt' => $Han_tt,
            'pLs_qh' => $Ls_qh,
            'pkSd' => $kSd,
            'pLUser' => $LUser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
