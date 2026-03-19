<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINRptTHX01
{
    /**
     * Call stored procedure asINRptTHX01
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptTHX01', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pCtu1' => $paramObj->pCtu1 ?? null,
            'pCtu2' => $paramObj->pCtu2 ?? null,
            'pLoai_px' => $paramObj->pLoai_px ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_Hd' => $paramObj->pMa_Hd ?? null,
            'pMa_nx' => $paramObj->pMa_nx ?? null,
            'pMa_kho_xuat' => $paramObj->pMa_kho_xuat ?? null,
            'pMa_kho_nhap' => $paramObj->pMa_kho_nhap ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pNhom_VT' => $paramObj->pNhom_VT ?? null,
            'pTK_VT' => $paramObj->pTK_VT ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pPSDC' => $paramObj->pPSDC ?? null,
            'pMa_NT' => $paramObj->pMa_NT ?? null,
            'pTk_Du' => $paramObj->pTk_Du ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pNgoai_te' => $paramObj->pNgoai_te ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pDVT' => $paramObj->pDVT ?? null,
            'pSysMsg1' => $paramObj->pSysMsg1 ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'ParamDefines' => $paramObj->ParamDefines ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptTHX01 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ctu1
     * @param string $Ctu2
     * @param string $Loai_px
     * @param string $Ma_kh
     * @param string $Ma_Hd
     * @param string $Ma_nx
     * @param string $Ma_kho_xuat
     * @param string $Ma_kho_nhap
     * @param string $Ma_lo
     * @param string $Ma_vt
     * @param string $Nhom_VT
     * @param string $TK_VT
     * @param string $Ma_bp
     * @param string $PSDC
     * @param string $Ma_NT
     * @param string $Tk_Du
     * @param string $Ma_phi
     * @param string $Ngoai_te
     * @param string $Ma_spct
     * @param string $DVT
     * @param string $SysMsg1
     * @param mixed $Ma_nt
     * @param mixed $Ma_hd
     * @param string $ParamDefines
     * @param string $Ma_kho
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ctu1 = null, string $Ctu2 = null, string $Loai_px = null, string $Ma_kh = null, string $Ma_Hd = null, string $Ma_nx = null, string $Ma_kho_xuat = null, string $Ma_kho_nhap = null, string $Ma_lo = null, string $Ma_vt = null, string $Nhom_VT = null, string $TK_VT = null, string $Ma_bp = null, string $PSDC = null, string $Ma_NT = null, string $Tk_Du = null, string $Ma_phi = null, string $Ngoai_te = null, string $Ma_spct = null, string $DVT = null, string $SysMsg1 = null, mixed $Ma_nt = null, mixed $Ma_hd = null, string $ParamDefines = null, string $Ma_kho = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pCtu1' => $Ctu1,
            'pCtu2' => $Ctu2,
            'pLoai_px' => $Loai_px,
            'pMa_kh' => $Ma_kh,
            'pMa_Hd' => $Ma_Hd,
            'pMa_nx' => $Ma_nx,
            'pMa_kho_xuat' => $Ma_kho_xuat,
            'pMa_kho_nhap' => $Ma_kho_nhap,
            'pMa_lo' => $Ma_lo,
            'pMa_vt' => $Ma_vt,
            'pNhom_VT' => $Nhom_VT,
            'pTK_VT' => $TK_VT,
            'pMa_bp' => $Ma_bp,
            'pPSDC' => $PSDC,
            'pMa_NT' => $Ma_NT,
            'pTk_Du' => $Tk_Du,
            'pMa_phi' => $Ma_phi,
            'pNgoai_te' => $Ngoai_te,
            'pMa_spct' => $Ma_spct,
            'pDVT' => $DVT,
            'pSysMsg1' => $SysMsg1,
            'pMa_nt' => $Ma_nt,
            'pMa_hd' => $Ma_hd,
            'ParamDefines' => $ParamDefines,
            'pMa_kho' => $Ma_kho
        ];

        return self::call($params);
    }
}
