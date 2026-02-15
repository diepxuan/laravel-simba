<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:01
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsINRptF5THX02
{
    /**
     * Call stored procedure asINRptF5THX02
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptF5THX02', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay1' => $params['pNgay1'] ?? null,
            'pNgay2' => $params['pNgay2'] ?? null,
            'pCtu1' => $params['pCtu1'] ?? null,
            'pCtu2' => $params['pCtu2'] ?? null,
            'pLoai_px' => $params['pLoai_px'] ?? null,
            'pGroup' => $params['pGroup'] ?? null,
            'pDetail' => $params['pDetail'] ?? null,
            'pMa_kh' => $params['pMa_kh'] ?? null,
            'pMa_nhkh' => $params['pMa_nhkh'] ?? null,
            'pMa_Hd' => $params['pMa_Hd'] ?? null,
            'pMa_dangnx' => $params['pMa_dangnx'] ?? null,
            'pMa_kho' => $params['pMa_kho'] ?? null,
            'pMa_khon' => $params['pMa_khon'] ?? null,
            'pMa_vitri' => $params['pMa_vitri'] ?? null,
            'pMa_vt' => $params['pMa_vt'] ?? null,
            'pNhom_VT' => $params['pNhom_VT'] ?? null,
            'pTK_VT' => $params['pTK_VT'] ?? null,
            'pMa_spct' => $params['pMa_spct'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pPSDC' => $params['pPSDC'] ?? null,
            'pMa_NT' => $params['pMa_NT'] ?? null,
            'pTk_Du' => $params['pTk_Du'] ?? null,
            'pNgoai_te' => $params['pNgoai_te'] ?? null,
            'pLoai_gd' => $params['pLoai_gd'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptF5THX02 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ctu1
     * @param string $Ctu2
     * @param string $Loai_px
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
     * @param string $Ma_spct
     * @param string $Ma_bp
     * @param string $PSDC
     * @param string $Ma_NT
     * @param string $Tk_Du
     * @param string $Ngoai_te
     * @param string $Loai_gd
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ctu1 = null, string $Ctu2 = null, string $Loai_px = null, string $Group = null, string $Detail = null, string $Ma_kh = null, string $Ma_nhkh = null, string $Ma_Hd = null, string $Ma_dangnx = null, string $Ma_kho = null, string $Ma_khon = null, string $Ma_vitri = null, string $Ma_vt = null, string $Nhom_VT = null, string $TK_VT = null, string $Ma_spct = null, string $Ma_bp = null, string $PSDC = null, string $Ma_NT = null, string $Tk_Du = null, string $Ngoai_te = null, string $Loai_gd = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pCtu1' => $Ctu1,
            'pCtu2' => $Ctu2,
            'pLoai_px' => $Loai_px,
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
            'pMa_spct' => $Ma_spct,
            'pMa_bp' => $Ma_bp,
            'pPSDC' => $PSDC,
            'pMa_NT' => $Ma_NT,
            'pTk_Du' => $Tk_Du,
            'pNgoai_te' => $Ngoai_te,
            'pLoai_gd' => $Loai_gd
        ];
        
        return self::call($params);
    }
}
