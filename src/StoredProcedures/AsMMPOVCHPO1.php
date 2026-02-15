<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:59
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsMMPOVCHPO1
{
    /**
     * Call stored procedure asMMPOVCHPO1
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asMMPOVCHPO1', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pma_kh' => $params['pma_kh'] ?? null,
            'pma_vt' => $params['pma_vt'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asMMPOVCHPO1 with named parameters
     *
     * @param string $ma_cty
     * @param string $ma_kh
     * @param string $ma_vt
     * @param string $Ngay1
     * @param string $Ngay2
     * @return Collection
     */
    public static function callWithParams(string $ma_cty = null, string $ma_kh = null, string $ma_vt = null, string $Ngay1 = null, string $Ngay2 = null): Collection
    {
        $params = [
            'pma_cty' => $ma_cty,
            'pma_kh' => $ma_kh,
            'pma_vt' => $ma_vt,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2
        ];
        
        return self::call($params);
    }
}
