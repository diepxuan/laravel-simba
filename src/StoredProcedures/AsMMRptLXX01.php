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
use Diepxuan\Simba\Helper\ParamHelper;

class AsMMRptLXX01
{
    /**
     * Call stored procedure asMMRptLXX01
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asMMRptLXX01', [
            'pma_cty' => $paramObj->pma_cty ?? null,
            'pngay_ct1' => $paramObj->pngay_ct1 ?? null,
            'pngay_ct2' => $paramObj->pngay_ct2 ?? null,
            'pma_vt' => $paramObj->pma_vt ?? null,
            'pma_lo_sx' => $paramObj->pma_lo_sx ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asMMRptLXX01 with named parameters
     *
     * @param string $ma_cty
     * @param string $ngay_ct1
     * @param string $ngay_ct2
     * @param string $ma_vt
     * @param string $ma_lo_sx
     * @return Collection
     */
    public static function callWithParams(string $ma_cty = null, string $ngay_ct1 = null, string $ngay_ct2 = null, string $ma_vt = null, string $ma_lo_sx = null): Collection
    {
        $params = [
            'pma_cty' => $ma_cty,
            'pngay_ct1' => $ngay_ct1,
            'pngay_ct2' => $ngay_ct2,
            'pma_vt' => $ma_vt,
            'pma_lo_sx' => $ma_lo_sx
        ];

        return self::call($params);
    }
}
