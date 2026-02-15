<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSORptBCPT09
{
    /**
     * Call stored procedure asSORptBCPT09
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSORptBCPT09', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_kyck' => $params['pMa_kyck'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pSL_DS' => $params['pSL_DS'] ?? null,
            'pTl_sl_ds' => $params['pTl_sl_ds'] ?? null,
            'pTl_gt' => $params['pTl_gt'] ?? null,
            'pGT_tu' => $params['pGT_tu'] ?? null,
            'pGT_den' => $params['pGT_den'] ?? null,
            'pCK' => $params['pCK'] ?? null,
            'pSql' => $params['pSql'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pWhere' => $params['pWhere'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSORptBCPT09 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_kyck
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $SL_DS
     * @param string $Tl_sl_ds
     * @param string $Tl_gt
     * @param mixed $GT_tu
     * @param mixed $GT_den
     * @param mixed $CK
     * @param mixed $Sql
     * @param string $ParamDefines
     * @param mixed $Where
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_kyck = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_kh = null, string $Ma_nhkh = null, string $SL_DS = null, string $Tl_sl_ds = null, string $Tl_gt = null, mixed $GT_tu = null, mixed $GT_den = null, mixed $CK = null, mixed $Sql = null, string $ParamDefines = null, mixed $Where = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_kyck' => $Ma_kyck,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pSL_DS' => $SL_DS,
            'pTl_sl_ds' => $Tl_sl_ds,
            'pTl_gt' => $Tl_gt,
            'pGT_tu' => $GT_tu,
            'pGT_den' => $GT_den,
            'pCK' => $CK,
            'pSql' => $Sql,
            'ParamDefines' => $ParamDefines,
            'pWhere' => $Where
        ];
        
        return self::call($params);
    }
}
