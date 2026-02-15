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
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptBKN03', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pSoct1' => $params['pSoct1'] ?? null,
            'pSoct2' => $params['pSoct2'] ?? null,
            'pLoai_pn' => $params['pLoai_pn'] ?? null,
            'pMa_Hd' => $params['pMa_Hd'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_nx' => $params['pMa_nx'] ?? null,
            'pTK_VT' => $params['pTK_VT'] ?? null,
            'pTk_Du' => $params['pTk_Du'] ?? null,
            'pMa_NhVT' => $params['pMa_NhVT'] ?? null,
            'pMa_NT' => $params['pMa_NT'] ?? null,
            'pDVT' => $params['pDVT'] ?? null,
            'pGroupType' => $params['pGroupType'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null,
            'pTk_du' => $params['pTk_du'] ?? null
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
