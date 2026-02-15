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

class AsINRptCTVT02
{
    /**
     * Call stored procedure asINRptCTVT02
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptCTVT02', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pDVT' => $params['pDVT'] ?? null,
            'pPSDC' => $params['pPSDC'] ?? null,
            'pNgoai_te' => $params['pNgoai_te'] ?? null,
            'pMau_bc' => $params['pMau_bc'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pSysMsg1' => $params['pSysMsg1'] ?? null,
            'pMa_nt0' => $params['pMa_nt0'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptCTVT02 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_vt
     * @param string $Tk_vt
     * @param string $Ma_nhvt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $DVT
     * @param string $PSDC
     * @param string $Ngoai_te
     * @param string $Mau_bc
     * @param string $Ma_nt
     * @param string $SysMsg1
     * @param string $Ma_nt0
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_vt = null, string $Tk_vt = null, string $Ma_nhvt = null, string $Ma_kho = null, string $Ma_vitri = null, string $DVT = null, string $PSDC = null, string $Ngoai_te = null, string $Mau_bc = null, string $Ma_nt = null, string $SysMsg1 = null, string $Ma_nt0 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_vt' => $Ma_vt,
            'pTk_vt' => $Tk_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pDVT' => $DVT,
            'pPSDC' => $PSDC,
            'pNgoai_te' => $Ngoai_te,
            'pMau_bc' => $Mau_bc,
            'pMa_nt' => $Ma_nt,
            'pSysMsg1' => $SysMsg1,
            'pMa_nt0' => $Ma_nt0
        ];
        
        return self::call($params);
    }
}
