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

class AsSoRptDMKM
{
    /**
     * Call stored procedure asSoRptDMKM
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSoRptDMKM', [
            'pma_cty' => $params['pma_cty'] ?? null,
            'pMa_km' => $params['pMa_km'] ?? null,
            'pNgayBD' => $params['pNgayBD'] ?? null,
            'pNgayKT' => $params['pNgayKT'] ?? null,
            'pSysMsg1' => $params['pSysMsg1'] ?? null,
            'pSysMsg2' => $params['pSysMsg2'] ?? null,
            'pSysMsg3' => $params['pSysMsg3'] ?? null,
            'pSysMsg4' => $params['pSysMsg4'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSoRptDMKM with named parameters
     *
     * @param string $ma_cty
     * @param string $Ma_km
     * @param string $NgayBD
     * @param string $NgayKT
     * @param string $SysMsg1
     * @param string $SysMsg2
     * @param string $SysMsg3
     * @param string $SysMsg4
     * @return Collection
     */
    public static function callWithParams(string $ma_cty = null, string $Ma_km = null, string $NgayBD = null, string $NgayKT = null, string $SysMsg1 = null, string $SysMsg2 = null, string $SysMsg3 = null, string $SysMsg4 = null): Collection
    {
        $params = [
            'pma_cty' => $ma_cty,
            'pMa_km' => $Ma_km,
            'pNgayBD' => $NgayBD,
            'pNgayKT' => $NgayKT,
            'pSysMsg1' => $SysMsg1,
            'pSysMsg2' => $SysMsg2,
            'pSysMsg3' => $SysMsg3,
            'pSysMsg4' => $SysMsg4
        ];
        
        return self::call($params);
    }
}
