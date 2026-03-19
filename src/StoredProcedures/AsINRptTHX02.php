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
use Diepxuan\Simba\Helper\ParamHelper;

class AsINRptTHX02
{
    /**
     * Call stored procedure asINRptTHX02
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptTHX02', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pCtu1' => $paramObj->pCtu1 ?? null,
            'pCtu2' => $paramObj->pCtu2 ?? null,
            'pLoai_px' => $paramObj->pLoai_px ?? null,
            'pLoai_gd' => $paramObj->pLoai_gd ?? null,
            'pGroup' => $paramObj->pGroup ?? null,
            'pDetail' => $paramObj->pDetail ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_nhkh' => $paramObj->pMa_nhkh ?? null,
            'pMa_Hd' => $paramObj->pMa_Hd ?? null,
            'pMa_dangnx' => $paramObj->pMa_dangnx ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_khon' => $paramObj->pMa_khon ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pNhom_VT' => $paramObj->pNhom_VT ?? null,
            'pTK_VT' => $paramObj->pTK_VT ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pPSDC' => $paramObj->pPSDC ?? null,
            'pMa_NT' => $paramObj->pMa_NT ?? null,
            'pTk_Du' => $paramObj->pTk_Du ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pNgoai_te' => $paramObj->pNgoai_te ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pDVT' => $paramObj->pDVT ?? null,
            'pSysMsg1' => $paramObj->pSysMsg1 ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptTHX02 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ctu1
     * @param string $Ctu2
     * @param string $Loai_px
     * @param string $Loai_gd
     * @param string $Group
     * @param string $Detail
     * @param string $Ma_kh
     * @param string $Ma_nhkh
     * @param string $Ma_Hd
     * @param string $Ma_dangnx
     * @param string $Ma_kho
     * @param string $Ma_khon
     * @param string $Ma_vitri
     * @param string $Ma_vt
     * @param string $Nhom_VT
     * @param string $TK_VT
     * @param string $Ma_bp
     * @param string $PSDC
     * @param string $Ma_NT
     * @param string $Tk_Du
     * @param string $Ma_lo
     * @param string $Ma_phi
     * @param string $Ngoai_te
     * @param string $Ma_spct
     * @param string $DVT
     * @param string $SysMsg1
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ctu1 = null, string $Ctu2 = null, string $Loai_px = null, string $Loai_gd = null, string $Group = null, string $Detail = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_Hd = null, string $Ma_dangnx = null, string $Ma_kho = null, string $Ma_khon = null, string $Ma_vitri = null, string $Ma_vt = null, string $Nhom_VT = null, string $TK_VT = null, string $Ma_bp = null, string $PSDC = null, string $Ma_NT = null, string $Tk_Du = null, string $Ma_lo = null, string $Ma_phi = null, string $Ngoai_te = null, string $Ma_spct = null, string $DVT = null, string $SysMsg1 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pCtu1' => $Ctu1,
            'pCtu2' => $Ctu2,
            'pLoai_px' => $Loai_px,
            'pLoai_gd' => $Loai_gd,
            'pGroup' => $Group,
            'pDetail' => $Detail,
            'pMa_kh' => $Ma_kh,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_Hd' => $Ma_Hd,
            'pMa_dangnx' => $Ma_dangnx,
            'pMa_kho' => $Ma_kho,
            'pMa_khon' => $Ma_khon,
            'pMa_vitri' => $Ma_vitri,
            'pMa_vt' => $Ma_vt,
            'pNhom_VT' => $Nhom_VT,
            'pTK_VT' => $TK_VT,
            'pMa_bp' => $Ma_bp,
            'pPSDC' => $PSDC,
            'pMa_NT' => $Ma_NT,
            'pTk_Du' => $Tk_Du,
            'pMa_lo' => $Ma_lo,
            'pMa_phi' => $Ma_phi,
            'pNgoai_te' => $Ngoai_te,
            'pMa_spct' => $Ma_spct,
            'pDVT' => $DVT,
            'pSysMsg1' => $SysMsg1
        ];

        return self::call($params);
    }
}
