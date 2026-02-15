<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINRptF5CD01
{
    /**
     * Call stored procedure asINRptF5CD01
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptF5CD01', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pNxt' => $params['pNxt'] ?? null,
            'pPSDC' => $params['pPSDC'] ?? null,
            'pSysMsg1' => $params['pSysMsg1'] ?? null,
            'pSysMsg2' => $params['pSysMsg2'] ?? null,
            'pSysMsg3' => $params['pSysMsg3'] ?? null,
            'pSysMsg4' => $params['pSysMsg4'] ?? null,
            'pSysMsg5' => $params['pSysMsg5'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptF5CD01 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_vt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Ma_lo
     * @param string $Tk_vt
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Nxt
     * @param string $PSDC
     * @param string $SysMsg1
     * @param string $SysMsg2
     * @param string $SysMsg3
     * @param string $SysMsg4
     * @param string $SysMsg5
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_vt = null, string $Ma_kho = null, string $Ma_vitri = null, string $Ma_lo = null, string $Tk_vt = null, string $Ngay1 = null, string $Ngay2 = null, string $Nxt = null, string $PSDC = null, string $SysMsg1 = null, string $SysMsg2 = null, string $SysMsg3 = null, string $SysMsg4 = null, string $SysMsg5 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_vt' => $Ma_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pMa_lo' => $Ma_lo,
            'pTk_vt' => $Tk_vt,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pNxt' => $Nxt,
            'pPSDC' => $PSDC,
            'pSysMsg1' => $SysMsg1,
            'pSysMsg2' => $SysMsg2,
            'pSysMsg3' => $SysMsg3,
            'pSysMsg4' => $SysMsg4,
            'pSysMsg5' => $SysMsg5
        ];
        
        return self::call($params);
    }
}
