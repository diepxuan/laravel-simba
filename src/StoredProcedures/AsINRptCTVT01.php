<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:07
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINRptCTVT01
{
    /**
     * Call stored procedure asINRptCTVT01
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptCTVT01', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pMau_bc' => $params['pMau_bc'] ?? null,
            'pDVT' => $params['pDVT'] ?? null,
            'pTK_vt' => $params['pTK_vt'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pSysMsg1' => $params['pSysMsg1'] ?? null,
            'pSysMsg2' => $params['pSysMsg2'] ?? null,
            'pSysMsg3' => $params['pSysMsg3'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptCTVT01 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_vt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Mau_bc
     * @param string $DVT
     * @param string $TK_vt
     * @param string $Ma_nt
     * @param string $SysMsg1
     * @param string $SysMsg2
     * @param string $SysMsg3
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_vt = null, string $Ma_kho = null, string $Ma_vitri = null, string $Mau_bc = null, string $DVT = null, string $TK_vt = null, string $Ma_nt = null, string $SysMsg1 = null, string $SysMsg2 = null, string $SysMsg3 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_vt' => $Ma_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pMau_bc' => $Mau_bc,
            'pDVT' => $DVT,
            'pTK_vt' => $TK_vt,
            'pMa_nt' => $Ma_nt,
            'pSysMsg1' => $SysMsg1,
            'pSysMsg2' => $SysMsg2,
            'pSysMsg3' => $SysMsg3
        ];
        
        return self::call($params);
    }
}
