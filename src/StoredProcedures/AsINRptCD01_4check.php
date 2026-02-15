<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINRptCD01_4check
{
    /**
     * Call stored procedure asINRptCD01_4check
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptCD01_4check', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pLoai_bc' => $params['pLoai_bc'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pma_plvt1' => $params['pma_plvt1'] ?? null,
            'pma_plvt2' => $params['pma_plvt2'] ?? null,
            'pma_plvt3' => $params['pma_plvt3'] ?? null,
            'pDVT' => $params['pDVT'] ?? null,
            'pPSDC' => $params['pPSDC'] ?? null,
            'pNgoai_te' => $params['pNgoai_te'] ?? null,
            'pSysMsg1' => $params['pSysMsg1'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptCD01_4check with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Loai_bc
     * @param string $Ma_vt
     * @param string $Tk_vt
     * @param string $Ma_nhvt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $ma_plvt1
     * @param string $ma_plvt2
     * @param string $ma_plvt3
     * @param string $DVT
     * @param string $PSDC
     * @param string $Ngoai_te
     * @param string $SysMsg1
     * @param mixed $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Loai_bc = null, string $Ma_vt = null, string $Tk_vt = null, string $Ma_nhvt = null, string $Ma_kho = null, string $Ma_vitri = null, string $ma_plvt1 = null, string $ma_plvt2 = null, string $ma_plvt3 = null, string $DVT = null, string $PSDC = null, string $Ngoai_te = null, string $SysMsg1 = null, mixed $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pLoai_bc' => $Loai_bc,
            'pMa_vt' => $Ma_vt,
            'pTk_vt' => $Tk_vt,
            'pMa_nhvt' => $Ma_nhvt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pma_plvt1' => $ma_plvt1,
            'pma_plvt2' => $ma_plvt2,
            'pma_plvt3' => $ma_plvt3,
            'pDVT' => $DVT,
            'pPSDC' => $PSDC,
            'pNgoai_te' => $Ngoai_te,
            'pSysMsg1' => $SysMsg1,
            'pMa_Cty' => $Ma_Cty
        ];
        
        return self::call($params);
    }
}
