<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:02
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsPORptTH07
{
    /**
     * Call stored procedure asPORptTH07
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asPORptTH07', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pGroup' => $params['pGroup'] ?? null,
            'pDetail' => $params['pDetail'] ?? null,
            'pCtu1' => $params['pCtu1'] ?? null,
            'pCtu2' => $params['pCtu2'] ?? null,
            'pMa_NhNcc' => $params['pMa_NhNcc'] ?? null,
            'pMa_PLNCC1' => $params['pMa_PLNCC1'] ?? null,
            'pMa_PLNCC2' => $params['pMa_PLNCC2'] ?? null,
            'pMa_PLNCC3' => $params['pMa_PLNCC3'] ?? null,
            'pMa_Hd' => $params['pMa_Hd'] ?? null,
            'pMa_Ncc' => $params['pMa_Ncc'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_Ncco' => $params['pMa_Ncco'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pTK_VT' => $params['pTK_VT'] ?? null,
            'pTk_Du' => $params['pTk_Du'] ?? null,
            'pNhom_VT' => $params['pNhom_VT'] ?? null,
            'pMa_httt' => $params['pMa_httt'] ?? null,
            'pMa_NT' => $params['pMa_NT'] ?? null,
            'pDVT' => $params['pDVT'] ?? null,
            'ParamDefines' => $params['ParamDefines'] ?? null,
            'pMa_Cty' => $params['pMa_Cty'] ?? null,
            'pMa_nt' => $params['pMa_nt'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asPORptTH07 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Group
     * @param string $Detail
     * @param string $Ctu1
     * @param string $Ctu2
     * @param string $Ma_NhNcc
     * @param string $Ma_PLNCC1
     * @param string $Ma_PLNCC2
     * @param string $Ma_PLNCC3
     * @param string $Ma_Hd
     * @param string $Ma_Ncc
     * @param string $Ma_vt
     * @param string $Ma_Ncco
     * @param string $Ma_vitri
     * @param string $Ma_bp
     * @param string $Ma_spct
     * @param string $TK_VT
     * @param string $Tk_Du
     * @param string $Nhom_VT
     * @param string $Ma_httt
     * @param string $Ma_NT
     * @param string $DVT
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @param string $Ma_nt
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Group = null, string $Detail = null, string $Ctu1 = null, string $Ctu2 = null, string $Ma_NhNcc = null, string $Ma_PLNCC1 = null, string $Ma_PLNCC2 = null, string $Ma_PLNCC3 = null, string $Ma_Hd = null, string $Ma_Ncc = null, string $Ma_vt = null, string $Ma_Ncco = null, string $Ma_vitri = null, string $Ma_bp = null, string $Ma_spct = null, string $TK_VT = null, string $Tk_Du = null, string $Nhom_VT = null, string $Ma_httt = null, string $Ma_NT = null, string $DVT = null, string $ParamDefines = null, string $Ma_Cty = null, string $Ma_nt = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pGroup' => $Group,
            'pDetail' => $Detail,
            'pCtu1' => $Ctu1,
            'pCtu2' => $Ctu2,
            'pMa_NhNcc' => $Ma_NhNcc,
            'pMa_PLNCC1' => $Ma_PLNCC1,
            'pMa_PLNCC2' => $Ma_PLNCC2,
            'pMa_PLNCC3' => $Ma_PLNCC3,
            'pMa_Hd' => $Ma_Hd,
            'pMa_Ncc' => $Ma_Ncc,
            'pMa_vt' => $Ma_vt,
            'pMa_Ncco' => $Ma_Ncco,
            'pMa_vitri' => $Ma_vitri,
            'pMa_bp' => $Ma_bp,
            'pMa_spct' => $Ma_spct,
            'pTK_VT' => $TK_VT,
            'pTk_Du' => $Tk_Du,
            'pNhom_VT' => $Nhom_VT,
            'pMa_httt' => $Ma_httt,
            'pMa_NT' => $Ma_NT,
            'pDVT' => $DVT,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty,
            'pMa_nt' => $Ma_nt
        ];
        
        return self::call($params);
    }
}
