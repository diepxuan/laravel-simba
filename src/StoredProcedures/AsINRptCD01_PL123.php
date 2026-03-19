<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:45
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINRptCD01_PL123
{
    /**
     * Call stored procedure asINRptCD01_PL123
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptCD01_PL123', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pLoai_bc' => $paramObj->pLoai_bc ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pTk_vt' => $paramObj->pTk_vt ?? null,
            'pMa_nhvt' => $paramObj->pMa_nhvt ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pma_plvt1' => $paramObj->pma_plvt1 ?? null,
            'pma_plvt2' => $paramObj->pma_plvt2 ?? null,
            'pma_plvt3' => $paramObj->pma_plvt3 ?? null,
            'pDVT' => $paramObj->pDVT ?? null,
            'pPSDC' => $paramObj->pPSDC ?? null,
            'pNgoai_te' => $paramObj->pNgoai_te ?? null,
            'pNam' => $paramObj->pNam ?? null,
            'pDk_nhom' => $paramObj->pDk_nhom ?? null,
            'pSysMsg1' => $paramObj->pSysMsg1 ?? null,
            'pSysMsg2' => $paramObj->pSysMsg2 ?? null,
            'pSysMsg3' => $paramObj->pSysMsg3 ?? null,
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pDvt' => $paramObj->pDvt ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptCD01_PL123 with named parameters
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
     * @param int $Nam
     * @param bool $Dk_nhom
     * @param string $SysMsg1
     * @param string $SysMsg2
     * @param string $SysMsg3
     * @param mixed $Ma_Cty
     * @param mixed $Dvt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Loai_bc = null, string $Ma_vt = null, string $Tk_vt = null, string $Ma_nhvt = null, string $Ma_kho = null, string $Ma_vitri = null, string $ma_plvt1 = null, string $ma_plvt2 = null, string $ma_plvt3 = null, string $DVT = null, string $PSDC = null, string $Ngoai_te = null, int $Nam = null, bool $Dk_nhom = null, string $SysMsg1 = null, string $SysMsg2 = null, string $SysMsg3 = null, mixed $Ma_Cty = null, mixed $Dvt = null): Collection
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
            'pNam' => $Nam,
            'pDk_nhom' => $Dk_nhom,
            'pSysMsg1' => $SysMsg1,
            'pSysMsg2' => $SysMsg2,
            'pSysMsg3' => $SysMsg3,
            'pMa_Cty' => $Ma_Cty,
            'pDvt' => $Dvt
        ];

        return self::call($params);
    }
}
