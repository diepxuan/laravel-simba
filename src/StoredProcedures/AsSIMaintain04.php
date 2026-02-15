<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:50
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsSIMaintain04
{
    /**
     * Call stored procedure asSIMaintain04
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIMaintain04', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pngay_ct1' => $params['pngay_ct1'] ?? null,
            'pngay_ct2' => $params['pngay_ct2'] ?? null,
            'ptk' => $params['ptk'] ?? null,
            'ptk_du' => $params['ptk_du'] ?? null,
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay_ct1' => $params['pNgay_ct1'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIMaintain04 with named parameters
     *
     * @param string $ma_cty
     * @param string $ngay_ct1
     * @param string $ngay_ct2
     * @param string $tk
     * @param string $tk_du
     * @param mixed $Ma_cty
     * @param mixed $Ngay_ct1
     * @return Collection
     */
    public static function callWithParams(string $ma_cty = null, string $ngay_ct1 = null, string $ngay_ct2 = null, string $tk = null, string $tk_du = null, mixed $Ma_cty = null, mixed $Ngay_ct1 = null): Collection
    {
        $params = [
            'pma_cty' => $ma_cty,
            'pngay_ct1' => $ngay_ct1,
            'pngay_ct2' => $ngay_ct2,
            'ptk' => $tk,
            'ptk_du' => $tk_du,
            'pMa_cty' => $Ma_cty,
            'pNgay_ct1' => $Ngay_ct1
        ];
        
        return self::call($params);
    }
}
