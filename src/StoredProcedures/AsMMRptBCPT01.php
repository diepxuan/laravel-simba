<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsMMRptBCPT01
{
    /**
     * Call stored procedure asMMRptBCPT01
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asMMRptBCPT01', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pma_plvt1' => $params['pma_plvt1'] ?? null,
            'pma_plvt2' => $params['pma_plvt2'] ?? null,
            'pma_plvt3' => $params['pma_plvt3'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asMMRptBCPT01 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_vt
     * @param string $Ma_nhvt
     * @param string $ma_plvt1
     * @param string $ma_plvt2
     * @param string $ma_plvt3
     * @param mixed $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_vt = null, string $Ma_nhvt = null, string $ma_plvt1 = null, string $ma_plvt2 = null, string $ma_plvt3 = null, mixed $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_vt' => $Ma_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pma_plvt1' => $ma_plvt1,
            'pma_plvt2' => $ma_plvt2,
            'pma_plvt3' => $ma_plvt3,
            'pMa_Cty' => $Ma_Cty
        ];
        
        return self::call($params);
    }
}
