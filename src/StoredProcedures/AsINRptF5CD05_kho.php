<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:17
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINRptF5CD05_kho
{
    /**
     * Call stored procedure asINRptF5CD05_kho
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptF5CD05_kho', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pNgay' => $params['pNgay'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pdvt' => $params['pdvt'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pNxt' => $params['pNxt'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pSysMsg1' => $params['pSysMsg1'] ?? null,
            'pSysMsg2' => $params['pSysMsg2'] ?? null,
            'pSysMsg3' => $params['pSysMsg3'] ?? null,
            'pSysMsg4' => $params['pSysMsg4'] ?? null,
            'pma_kho' => $params['pma_kho'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptF5CD05_kho with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_vt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Tk_vt
     * @param string $Ma_nhvt
     * @param string $Ngay
     * @param string $Ma_nt
     * @param string $dvt
     * @param string $Ma_lo
     * @param mixed $Nxt
     * @param mixed $Ngay1
     * @param mixed $Ngay2
     * @param string $SysMsg1
     * @param string $SysMsg2
     * @param string $SysMsg3
     * @param string $SysMsg4
     * @param mixed $ma_kho
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_vt = null, string $Ma_kho = null, string $Ma_vitri = null, string $Tk_vt = null, string $Ma_nhvt = null, string $Ngay = null, string $Ma_nt = null, string $dvt = null, string $Ma_lo = null, mixed $Nxt = null, mixed $Ngay1 = null, mixed $Ngay2 = null, string $SysMsg1 = null, string $SysMsg2 = null, string $SysMsg3 = null, string $SysMsg4 = null, mixed $ma_kho = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_vt' => $Ma_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pTk_vt' => $Tk_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pNgay' => $Ngay,
            'pMa_nt' => $Ma_nt,
            'pdvt' => $dvt,
            'pMa_lo' => $Ma_lo,
            'pNxt' => $Nxt,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pSysMsg1' => $SysMsg1,
            'pSysMsg2' => $SysMsg2,
            'pSysMsg3' => $SysMsg3,
            'pSysMsg4' => $SysMsg4,
            'pma_kho' => $ma_kho
        ];
        
        return self::call($params);
    }
}
