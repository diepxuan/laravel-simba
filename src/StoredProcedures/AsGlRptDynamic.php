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

class AsGlRptDynamic
{
    /**
     * Call stored procedure asGlRptDynamic
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asGlRptDynamic', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pTk' => $params['pTk'] ?? null,
            'pSum2TkTH2' => $params['pSum2TkTH2'] ?? null,
            'pSum2TkTH' => $params['pSum2TkTH'] ?? null,
            'pre_col' => $params['pre_col'] ?? null,
            'PivotColumn' => $params['PivotColumn'] ?? null,
            'PivotSql' => $params['PivotSql'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asGlRptDynamic with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Tk
     * @param string $Sum2TkTH2
     * @param bool $Sum2TkTH
     * @param string $re_col
     * @param string $PivotColumn
     * @param string $PivotSql
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Tk = null, string $Sum2TkTH2 = null, bool $Sum2TkTH = null, string $re_col = null, string $PivotColumn = null, string $PivotSql = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pTk' => $Tk,
            'pSum2TkTH2' => $Sum2TkTH2,
            'pSum2TkTH' => $Sum2TkTH,
            'pre_col' => $re_col,
            'PivotColumn' => $PivotColumn,
            'PivotSql' => $PivotSql
        ];
        
        return self::call($params);
    }
}
