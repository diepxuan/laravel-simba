<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:21
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINRptBKN03
{
    /**
     * Call stored procedure asINRptBKN03
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptBKN03', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pSoct1' => $paramObj->pSoct1 ?? null,
            'pSoct2' => $paramObj->pSoct2 ?? null,
            'pLoai_pn' => $paramObj->pLoai_pn ?? null,
            'pMa_Hd' => $paramObj->pMa_Hd ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_nx' => $paramObj->pMa_nx ?? null,
            'pTK_VT' => $paramObj->pTK_VT ?? null,
            'pTk_Du' => $paramObj->pTk_Du ?? null,
            'pMa_NhVT' => $paramObj->pMa_NhVT ?? null,
            'pMa_NT' => $paramObj->pMa_NT ?? null,
            'pDVT' => $paramObj->pDVT ?? null,
            'pGroupType' => $paramObj->pGroupType ?? null,
            'ParamDefines' => $paramObj->ParamDefines ?? null,
            'pMa_Cty' => $paramObj->pMa_Cty ?? null,
            'pMa_nt' => $paramObj->pMa_nt ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pTk_vt' => $paramObj->pTk_vt ?? null,
            'pTk_du' => $paramObj->pTk_du ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptBKN03 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Soct1
     * @param string $Soct2
     * @param string $Loai_pn
     * @param string $Ma_Hd
     * @param string $Ma_kh
     * @param string $Ma_vt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Ma_bp
     * @param string $Ma_nx
     * @param string $TK_VT
     * @param string $Tk_Du
     * @param string $Ma_NhVT
     * @param string $Ma_NT
     * @param string $DVT
     * @param string $GroupType
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @param string $Ma_nt
     * @param string $Ma_hd
     * @param string $Tk_vt
     * @param string $Tk_du
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Soct1 = null, string $Soct2 = null, string $Loai_pn = null, string $Ma_Hd = null, string $Ma_kh = null, string $Ma_vt = null, string $Ma_kho = null, string $Ma_vitri = null, string $Ma_bp = null, string $Ma_nx = null, string $TK_VT = null, string $Tk_Du = null, string $Ma_NhVT = null, string $Ma_NT = null, string $DVT = null, string $GroupType = null, string $ParamDefines = null, string $Ma_Cty = null, string $Ma_nt = null, string $Ma_hd = null, string $Tk_vt = null, string $Tk_du = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pSoct1' => $Soct1,
            'pSoct2' => $Soct2,
            'pLoai_pn' => $Loai_pn,
            'pMa_Hd' => $Ma_Hd,
            'pMa_kh' => $Ma_kh,
            'pMa_vt' => $Ma_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pMa_bp' => $Ma_bp,
            'pMa_nx' => $Ma_nx,
            'pTK_VT' => $TK_VT,
            'pTk_Du' => $Tk_Du,
            'pMa_NhVT' => $Ma_NhVT,
            'pMa_NT' => $Ma_NT,
            'pDVT' => $DVT,
            'pGroupType' => $GroupType,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty,
            'pMa_nt' => $Ma_nt,
            'pMa_hd' => $Ma_hd,
            'pTk_vt' => $Tk_vt,
            'pTk_du' => $Tk_du
        ];

        return self::call($params);
    }
}
