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
use Diepxuan\Simba\Helper\ParamHelper;

class AsINRptBKX04
{
    /**
     * Call stored procedure asINRptBKX04
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptBKX04', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pGroupType' => $paramObj->pGroupType ?? null,
            'pSoct1' => $paramObj->pSoct1 ?? null,
            'pSoct2' => $paramObj->pSoct2 ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_Hd' => $paramObj->pMa_Hd ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pLoai_px' => $paramObj->pLoai_px ?? null,
            'pLoai_gd' => $paramObj->pLoai_gd ?? null,
            'pMa_Nt' => $paramObj->pMa_Nt ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'PMa_nhvt' => $paramObj->PMa_nhvt ?? null,
            'ptk_vt' => $paramObj->ptk_vt ?? null,
            'pTk_Du' => $paramObj->pTk_Du ?? null,
            'pMa_lo' => $paramObj->pMa_lo ?? null,
            'pMa_phi' => $paramObj->pMa_phi ?? null,
            'pDVT' => $paramObj->pDVT ?? null,
            'pSysMsg1' => $paramObj->pSysMsg1 ?? null,
            'pSysMsg2' => $paramObj->pSysMsg2 ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pTK_VT' => $paramObj->pTK_VT ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'ParamDefines' => $paramObj->ParamDefines ?? null,
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pTK_vt' => $paramObj->pTK_vt ?? null,
            'pTK_du' => $paramObj->pTK_du ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptBKX04 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $GroupType
     * @param string $Soct1
     * @param string $Soct2
     * @param string $Ma_kh
     * @param string $Ma_Hd
     * @param string $Ma_kho
     * @param string $Ma_spct
     * @param string $Ma_bp
     * @param string $Loai_px
     * @param string $Loai_gd
     * @param string $Ma_Nt
     * @param string $Ma_vt
     * @param string $PMa_nhvt
     * @param string $tk_vt
     * @param string $Tk_Du
     * @param string $Ma_lo
     * @param string $Ma_phi
     * @param string $DVT
     * @param string $SysMsg1
     * @param string $SysMsg2
     * @param mixed $Ma_nt
     * @param mixed $TK_VT
     * @param mixed $Ma_hd
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @param string $TK_vt
     * @param string $TK_du
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $GroupType = null, string $Soct1 = null, string $Soct2 = null, string $Ma_kh = null, string $Ma_Hd = null, string $Ma_kho = null, string $Ma_spct = null, string $Ma_bp = null, string $Loai_px = null, string $Loai_gd = null, string $Ma_Nt = null, string $Ma_vt = null, string $PMa_nhvt = null, string $tk_vt = null, string $Tk_Du = null, string $Ma_lo = null, string $Ma_phi = null, string $DVT = null, string $SysMsg1 = null, string $SysMsg2 = null, mixed $Ma_nt = null, mixed $TK_VT = null, mixed $Ma_hd = null, string $ParamDefines = null, string $Ma_Cty = null, string $TK_vt = null, string $TK_du = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pGroupType' => $GroupType,
            'pSoct1' => $Soct1,
            'pSoct2' => $Soct2,
            'pMa_kh' => $Ma_kh,
            'pMa_Hd' => $Ma_Hd,
            'pMa_kho' => $Ma_kho,
            'pMa_spct' => $Ma_spct,
            'pMa_bp' => $Ma_bp,
            'pLoai_px' => $Loai_px,
            'pLoai_gd' => $Loai_gd,
            'pMa_Nt' => $Ma_Nt,
            'pMa_vt' => $Ma_vt,
            'PMa_nhvt' => $PMa_nhvt,
            'ptk_vt' => $tk_vt,
            'pTk_Du' => $Tk_Du,
            'pMa_lo' => $Ma_lo,
            'pMa_phi' => $Ma_phi,
            'pDVT' => $DVT,
            'pSysMsg1' => $SysMsg1,
            'pSysMsg2' => $SysMsg2,
            'pMa_nt' => $Ma_nt,
            'pTK_VT' => $TK_VT,
            'pMa_hd' => $Ma_hd,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty,
            'pTK_vt' => $TK_vt,
            'pTK_du' => $TK_du
        ];

        return self::call($params);
    }
}
