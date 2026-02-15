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

class AsINRptBKN01
{
    /**
     * Call stored procedure asINRptBKN01
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptBKN01', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pSoct1' => $params['pSoct1'] ?? null,
            'pSoct2' => $params['pSoct2'] ?? null,
            'pMa_Hd' => $params['pMa_Hd'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null,
            'pMa_nhvt' => $params['pMa_nhvt'] ?? null,
            'pTk_vt' => $params['pTk_vt'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pLoai_pn' => $params['pLoai_pn'] ?? null,
            'pMa_nx' => $params['pMa_nx'] ?? null,
            'pTk_Du' => $params['pTk_Du'] ?? null,
            'pDVT' => $params['pDVT'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pMa_hd' => $params['pMa_hd'] ?? null,
            'pTk_du' => $params['pTk_du'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptBKN01 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_kh
     * @param string $Ma_kho
     * @param string $Soct1
     * @param string $Soct2
     * @param string $Ma_Hd
     * @param string $Ma_vt
     * @param string $Ma_nt
     * @param string $Ma_nhvt
     * @param string $Tk_vt
     * @param string $Ma_bp
     * @param string $Loai_pn
     * @param string $Ma_nx
     * @param string $Tk_Du
     * @param string $DVT
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @param string $Ma_hd
     * @param string $Tk_du
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_kh = null, string $Ma_kho = null, string $Soct1 = null, string $Soct2 = null, string $Ma_Hd = null, string $Ma_vt = null, string $Ma_nt = null, string $Ma_nhvt = null, string $Tk_vt = null, string $Ma_bp = null, string $Loai_pn = null, string $Ma_nx = null, string $Tk_Du = null, string $DVT = null, string $ParamDefines = null, string $Ma_Cty = null, string $Ma_hd = null, string $Tk_du = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_kh' => $Ma_kh,
            'pMa_kho' => $Ma_kho,
            'pSoct1' => $Soct1,
            'pSoct2' => $Soct2,
            'pMa_Hd' => $Ma_Hd,
            'pMa_vt' => $Ma_vt,
            'pMa_nt' => $Ma_nt,
            'pMa_nhvt' => $Ma_nhvt,
            'pTk_vt' => $Tk_vt,
            'pMa_bp' => $Ma_bp,
            'pLoai_pn' => $Loai_pn,
            'pMa_nx' => $Ma_nx,
            'pTk_Du' => $Tk_Du,
            'pDVT' => $DVT,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty,
            'pMa_hd' => $Ma_hd,
            'pTk_du' => $Tk_du
        ];
        
        return self::call($params);
    }
}
