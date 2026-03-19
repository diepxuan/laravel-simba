<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:44
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrUpdQTKNCongTac
{
    /**
     * Call stored procedure asHrUpdQTKNCongTac
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdQTKNCongTac', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pId' => $paramObj->pId ?? null,
            'pId_qtknct' => $paramObj->pId_qtknct ?? null,
            'pMa_to_chuc' => $paramObj->pMa_to_chuc ?? null,
            'pTen_to_chuc' => $paramObj->pTen_to_chuc ?? null,
            'pMa_cvcm' => $paramObj->pMa_cvcm ?? null,
            'pNgay_bd' => $paramObj->pNgay_bd ?? null,
            'pNgay_kt' => $paramObj->pNgay_kt ?? null,
            'pMo_ta_cv' => $paramObj->pMo_ta_cv ?? null,
            'pThu_nhap_bd' => $paramObj->pThu_nhap_bd ?? null,
            'pThu_nhap_kt' => $paramObj->pThu_nhap_kt ?? null,
            'pTen_nql' => $paramObj->pTen_nql ?? null,
            'pChuc_danh_nql' => $paramObj->pChuc_danh_nql ?? null,
            'pThanh_tich' => $paramObj->pThanh_tich ?? null,
            'pSo_nv_ql' => $paramObj->pSo_nv_ql ?? null,
            'pMa_thoi_viec' => $paramObj->pMa_thoi_viec ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pLuser' => $paramObj->pLuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdQTKNCongTac with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtknct
     * @param string $Ma_to_chuc
     * @param string $Ten_to_chuc
     * @param string $Ma_cvcm
     * @param string $Ngay_bd
     * @param string $Ngay_kt
     * @param string $Mo_ta_cv
     * @param float $Thu_nhap_bd
     * @param float $Thu_nhap_kt
     * @param string $Ten_nql
     * @param string $Chuc_danh_nql
     * @param string $Thanh_tich
     * @param int $So_nv_ql
     * @param string $Ma_thoi_viec
     * @param string $Ghi_chu
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtknct = null, string $Ma_to_chuc = null, string $Ten_to_chuc = null, string $Ma_cvcm = null, string $Ngay_bd = null, string $Ngay_kt = null, string $Mo_ta_cv = null, float $Thu_nhap_bd = null, float $Thu_nhap_kt = null, string $Ten_nql = null, string $Chuc_danh_nql = null, string $Thanh_tich = null, int $So_nv_ql = null, string $Ma_thoi_viec = null, string $Ghi_chu = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtknct' => $Id_qtknct,
            'pMa_to_chuc' => $Ma_to_chuc,
            'pTen_to_chuc' => $Ten_to_chuc,
            'pMa_cvcm' => $Ma_cvcm,
            'pNgay_bd' => $Ngay_bd,
            'pNgay_kt' => $Ngay_kt,
            'pMo_ta_cv' => $Mo_ta_cv,
            'pThu_nhap_bd' => $Thu_nhap_bd,
            'pThu_nhap_kt' => $Thu_nhap_kt,
            'pTen_nql' => $Ten_nql,
            'pChuc_danh_nql' => $Chuc_danh_nql,
            'pThanh_tich' => $Thanh_tich,
            'pSo_nv_ql' => $So_nv_ql,
            'pMa_thoi_viec' => $Ma_thoi_viec,
            'pGhi_chu' => $Ghi_chu,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
