<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:24
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsCOdd
{
    /**
     * Call stored procedure asInsCOdd
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsCOdd', $params, $connection);
    }

    /**
     * Call stored procedure asInsCOdd with named parameters
     *
     * @param string $Ma_cty
     * @param int $Nam
     * @param int $Thang
     * @param string $Ma_spct
     * @param string $TK
     * @param float $Sl_kk_ck
     * @param float $Ty_le_ht
     * @param float $Sl_dd_ck
     * @param float $Gt_dd_ck
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Nam = null, int $Thang = null, string $Ma_spct = null, string $TK = null, float $Sl_kk_ck = null, float $Ty_le_ht = null, float $Sl_dd_ck = null, float $Gt_dd_ck = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNam' => $Nam,
            'pThang' => $Thang,
            'pMa_spct' => $Ma_spct,
            'pTK' => $TK,
            'pSl_kk_ck' => $Sl_kk_ck,
            'pTy_le_ht' => $Ty_le_ht,
            'pSl_dd_ck' => $Sl_dd_ck,
            'pGt_dd_ck' => $Gt_dd_ck,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
