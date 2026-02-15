<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:55
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSOGetCk
{
    /**
     * Call stored procedure asSOGetCk
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSOGetCk', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pVt_nhomvt' => $params['pVt_nhomvt'] ?? null,
            'pKh_nhomkh' => $params['pKh_nhomkh'] ?? null,
            'pSl_ds' => $params['pSl_ds'] ?? null,
            'pTl_gt' => $params['pTl_gt'] ?? null,
            'pTl_sl_ds' => $params['pTl_sl_ds'] ?? null,
            'pma_kyck' => $params['pma_kyck'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSOGetCk with named parameters
     *
     * @param string $Ma_cty
     * @param string $Vt_nhomvt
     * @param string $Kh_nhomkh
     * @param string $Sl_ds
     * @param string $Tl_gt
     * @param string $Tl_sl_ds
     * @param string $ma_kyck
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Vt_nhomvt = null, string $Kh_nhomkh = null, string $Sl_ds = null, string $Tl_gt = null, string $Tl_sl_ds = null, string $ma_kyck = null, string $Ma_vt = null, string $Ma_nhvt = null, string $Ma_kh = null, string $Ma_nhkh = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pVt_nhomvt' => $Vt_nhomvt,
            'pKh_nhomkh' => $Kh_nhomkh,
            'pSl_ds' => $Sl_ds,
            'pTl_gt' => $Tl_gt,
            'pTl_sl_ds' => $Tl_sl_ds,
            'pma_kyck' => $ma_kyck,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh
        ];
        
        return self::call($params);
    }
}
