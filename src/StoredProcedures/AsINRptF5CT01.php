<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINRptF5CT01
{
    /**
     * Call stored procedure asINRptF5CT01
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptF5CT01', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_khon' => $paramObj->pMa_khon ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_hd' => $paramObj->pMa_hd ?? null,
            'pTk_du' => $paramObj->pTk_du ?? null,
            'pMa_ct' => $paramObj->pMa_ct ?? null,
            'pNxt' => $paramObj->pNxt ?? null,
            'pPSDC' => $paramObj->pPSDC ?? null,
            'pMa_nhkh' => $paramObj->pMa_nhkh ?? null,
            'pMa_dangnx' => $paramObj->pMa_dangnx ?? null,
            'pMa_nhvt' => $paramObj->pMa_nhvt ?? null,
            'pTk_vt' => $paramObj->pTk_vt ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pLoai_gd' => $paramObj->pLoai_gd ?? null,
            'ParamDefines' => $paramObj->ParamDefines ?? null,
            'pMa_Cty' => $paramObj->pMa_Cty ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptF5CT01 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Ma_vt
     * @param string $Ma_kho
     * @param string $Ma_khon
     * @param string $Ma_vitri
     * @param string $Ma_kh
     * @param string $Ma_bp
     * @param string $Ma_hd
     * @param string $Tk_du
     * @param string $Ma_ct
     * @param string $Nxt
     * @param string $PSDC
     * @param string $Ma_nhkh
     * @param string $Ma_dangnx
     * @param string $Ma_nhvt
     * @param string $Tk_vt
     * @param string $Ma_spct
     * @param string $Loai_gd
     * @param string $ParamDefines
     * @param string $Ma_Cty
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Ma_vt = null, string $Ma_kho = null, string $Ma_khon = null, string $Ma_vitri = null, string $Ma_kh = null, string $Ma_bp = null, string $Ma_hd = null, string $Tk_du = null, string $Ma_ct = null, string $Nxt = null, string $PSDC = null, string $Ma_nhkh = null, string $Ma_dangnx = null, string $Ma_nhvt = null, string $Tk_vt = null, string $Ma_spct = null, string $Loai_gd = null, string $ParamDefines = null, string $Ma_Cty = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pMa_vt' => $Ma_vt,
            'pMa_kho' => $Ma_kho,
            'pMa_khon' => $Ma_khon,
            'pMa_vitri' => $Ma_vitri,
            'pMa_kh' => $Ma_kh,
            'pMa_bp' => $Ma_bp,
            'pMa_hd' => $Ma_hd,
            'pTk_du' => $Tk_du,
            'pMa_ct' => $Ma_ct,
            'pNxt' => $Nxt,
            'pPSDC' => $PSDC,
            'pMa_nhkh' => $Ma_nhkh,
            'pMa_dangnx' => $Ma_dangnx,
            'pMa_nhvt' => $Ma_nhvt,
            'pTk_vt' => $Tk_vt,
            'pMa_spct' => $Ma_spct,
            'pLoai_gd' => $Loai_gd,
            'ParamDefines' => $ParamDefines,
            'pMa_Cty' => $Ma_Cty
        ];

        return self::call($params);
    }
}
