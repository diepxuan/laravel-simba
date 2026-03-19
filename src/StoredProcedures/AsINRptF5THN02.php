<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsINRptF5THN02
{
    /**
     * Call stored procedure asINRptF5THN02
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asINRptF5THN02', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay1' => $paramObj->pNgay1 ?? null,
            'pNgay2' => $paramObj->pNgay2 ?? null,
            'pGroup' => $paramObj->pGroup ?? null,
            'pDetail' => $paramObj->pDetail ?? null,
            'pMa_kh' => $paramObj->pMa_kh ?? null,
            'pMa_NhKH' => $paramObj->pMa_NhKH ?? null,
            'pMa_PLKH1' => $paramObj->pMa_PLKH1 ?? null,
            'pMa_PLKH2' => $paramObj->pMa_PLKH2 ?? null,
            'pMa_PLKH3' => $paramObj->pMa_PLKH3 ?? null,
            'pLoai_pn' => $paramObj->pLoai_pn ?? null,
            'pMa_Hd' => $paramObj->pMa_Hd ?? null,
            'pMa_vt' => $paramObj->pMa_vt ?? null,
            'pMa_kho' => $paramObj->pMa_kho ?? null,
            'pMa_vitri' => $paramObj->pMa_vitri ?? null,
            'pMa_bp' => $paramObj->pMa_bp ?? null,
            'pMa_spct' => $paramObj->pMa_spct ?? null,
            'pTK_VT' => $paramObj->pTK_VT ?? null,
            'pTk_Du' => $paramObj->pTk_Du ?? null,
            'pNhom_VT' => $paramObj->pNhom_VT ?? null,
            'pPSDC' => $paramObj->pPSDC ?? null,
            'pMa_dangnx' => $paramObj->pMa_dangnx ?? null,
            'pMa_NT' => $paramObj->pMa_NT ?? null,
            'pDVT' => $paramObj->pDVT ?? null,
            'pLoai_gd' => $paramObj->pLoai_gd ?? null,
            'pGroup_Value' => $paramObj->pGroup_Value ?? null,
            'pDetail_Value' => $paramObj->pDetail_Value ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asINRptF5THN02 with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay1
     * @param string $Ngay2
     * @param string $Group
     * @param string $Detail
     * @param string $Ma_kh
     * @param string $Ma_NhKH
     * @param string $Ma_PLKH1
     * @param string $Ma_PLKH2
     * @param string $Ma_PLKH3
     * @param string $Loai_pn
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
     * @param string $Ma_dangnx
     * @param string $Ma_NT
     * @param string $DVT
     * @param string $Loai_gd
     * @param string $Group_Value
     * @param string $Detail_Value
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay1 = null, string $Ngay2 = null, string $Group = null, string $Detail = null, string $Ma_kh = null, string $Ma_NhKH = null, string $Ma_PLKH1 = null, string $Ma_PLKH2 = null, string $Ma_PLKH3 = null, string $Loai_pn = null, string $Ma_Hd = null, string $Ma_vt = null, string $Ma_kho = null, string $Ma_vitri = null, string $Ma_bp = null, string $Ma_spct = null, string $TK_VT = null, string $Tk_Du = null, string $Nhom_VT = null, string $PSDC = null, string $Ma_dangnx = null, string $Ma_NT = null, string $DVT = null, string $Loai_gd = null, string $Group_Value = null, string $Detail_Value = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay1' => $Ngay1,
            'pNgay2' => $Ngay2,
            'pGroup' => $Group,
            'pDetail' => $Detail,
            'pMa_kh' => $Ma_kh,
            'pMa_NhKH' => $Ma_NhKH,
            'pMa_PLKH1' => $Ma_PLKH1,
            'pMa_PLKH2' => $Ma_PLKH2,
            'pMa_PLKH3' => $Ma_PLKH3,
            'pLoai_pn' => $Loai_pn,
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
            'pMa_dangnx' => $Ma_dangnx,
            'pMa_NT' => $Ma_NT,
            'pDVT' => $DVT,
            'pLoai_gd' => $Loai_gd,
            'pGroup_Value' => $Group_Value,
            'pDetail_Value' => $Detail_Value
        ];

        return self::call($params);
    }
}
