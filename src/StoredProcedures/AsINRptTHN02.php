<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINRptTHN02
{
    /**
     * Call stored procedure asINRptTHN02
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptTHN02', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pCtu1' => $params['pCtu1'] ?? null,
            'pCtu2' => $params['pCtu2'] ?? null,
            'pGroup' => $params['pGroup'] ?? null,
            'pDetail' => $params['pDetail'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_NhKH' => $params['pMa_NhKH'] ?? null,
            'pMa_PLKH1' => $params['pMa_PLKH1'] ?? null,
            'pMa_PLKH2' => $params['pMa_PLKH2'] ?? null,
            'pMa_PLKH3' => $params['pMa_PLKH3'] ?? null,
            'pLoai_pn' => $params['pLoai_pn'] ?? null,
            'pLoai_gd' => $params['pLoai_gd'] ?? null,
            'pMa_Hd' => $params['pMa_Hd'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pTK_VT' => $params['pTK_VT'] ?? null,
            'pTk_Du' => $params['pTk_Du'] ?? null,
            'pNhom_VT' => $params['pNhom_VT'] ?? null,
            'pPSDC' => $params['pPSDC'] ?? null,
            'pMa_nx' => $params['pMa_nx'] ?? null,
            'pMa_lo' => $params['pMa_lo'] ?? null,
            'pMa_phi' => $params['pMa_phi'] ?? null,
            'pMa_NT' => $params['pMa_NT'] ?? null,
            'pDVT' => $params['pDVT'] ?? null,
            'pSysMsg1' => $params['pSysMsg1'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptTHN02 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ctu1
     * @param string $Ctu2
     * @param string $Group
     * @param string $Detail
     * @param string $Ma_kh
     * @param string $Ma_NhKH
     * @param string $Ma_PLKH1
     * @param string $Ma_PLKH2
     * @param string $Ma_PLKH3
     * @param string $Loai_pn
     * @param string $Loai_gd
     * @param string $Ma_Hd
     * @param string $Ma_vt
     * @param string $Ma_kho
     * @param string $Ma_vitri
     * @param string $Ma_bp
     * @param string $Ma_spct
     * @param string $TK_VT
     * @param string $Tk_Du
     * @param string $Nhom_VT
     * @param string $PSDC
     * @param string $Ma_nx
     * @param string $Ma_lo
     * @param string $Ma_phi
     * @param string $Ma_NT
     * @param string $DVT
     * @param string $SysMsg1
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ctu1 = null, string $Ctu2 = null, string $Group = null, string $Detail = null, string $Ma_kh = null, string $Ma_NhKH = null, string $Ma_PLKH1 = null, string $Ma_PLKH2 = null, string $Ma_PLKH3 = null, string $Loai_pn = null, string $Loai_gd = null, string $Ma_Hd = null, string $Ma_vt = null, string $Ma_kho = null, string $Ma_vitri = null, string $Ma_bp = null, string $Ma_spct = null, string $TK_VT = null, string $Tk_Du = null, string $Nhom_VT = null, string $PSDC = null, string $Ma_nx = null, string $Ma_lo = null, string $Ma_phi = null, string $Ma_NT = null, string $DVT = null, string $SysMsg1 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pCtu1' => $Ctu1,
            'pCtu2' => $Ctu2,
            'pGroup' => $Group,
            'pDetail' => $Detail,
            'pMa_kh' => $Ma_kh,
            'pMa_NhKH' => $Ma_NhKH,
            'pMa_PLKH1' => $Ma_PLKH1,
            'pMa_PLKH2' => $Ma_PLKH2,
            'pMa_PLKH3' => $Ma_PLKH3,
            'pLoai_pn' => $Loai_pn,
            'pLoai_gd' => $Loai_gd,
            'pMa_Hd' => $Ma_Hd,
            'pMa_vt' => $Ma_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_vitri' => $Ma_vitri,
            'pMa_bp' => $Ma_bp,
            'pMa_spct' => $Ma_spct,
            'pTK_VT' => $TK_VT,
            'pTk_Du' => $Tk_Du,
            'pNhom_VT' => $Nhom_VT,
            'pPSDC' => $PSDC,
            'pMa_nx' => $Ma_nx,
            'pMa_lo' => $Ma_lo,
            'pMa_phi' => $Ma_phi,
            'pMa_NT' => $Ma_NT,
            'pDVT' => $DVT,
            'pSysMsg1' => $SysMsg1
        ];
        
        return self::call($params);
    }
}
