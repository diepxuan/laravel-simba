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

class AsHrInsQTCongTac
{
    /**
     * Call stored procedure asHrInsQTCongTac
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsQTCongTac', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qtct' => $params['pId_qtct'] ?? null,
            'pNgay_ad' => $params['pNgay_ad'] ?? null,
            'pMo_ta_cv' => $params['pMo_ta_cv'] ?? null,
            'pMa_dia_diem_lv' => $params['pMa_dia_diem_lv'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_cvcm' => $params['pMa_cvcm'] ?? null,
            'pMa_nguoi_ql' => $params['pMa_nguoi_ql'] ?? null,
            'pSo_qd' => $params['pSo_qd'] ?? null,
            'pNgay_qd' => $params['pNgay_qd'] ?? null,
            'pNguoi_ky_qd' => $params['pNguoi_ky_qd'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsQTCongTac with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtct
     * @param string $Ngay_ad
     * @param string $Mo_ta_cv
     * @param string $Ma_dia_diem_lv
     * @param string $Ma_bp
     * @param string $Ma_cvcm
     * @param string $Ma_nguoi_ql
     * @param string $So_qd
     * @param string $Ngay_qd
     * @param string $Nguoi_ky_qd
     * @param string $Ghi_chu
     * @param string $Tai_lieu
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtct = null, string $Ngay_ad = null, string $Mo_ta_cv = null, string $Ma_dia_diem_lv = null, string $Ma_bp = null, string $Ma_cvcm = null, string $Ma_nguoi_ql = null, string $So_qd = null, string $Ngay_qd = null, string $Nguoi_ky_qd = null, string $Ghi_chu = null, string $Tai_lieu = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtct' => $Id_qtct,
            'pNgay_ad' => $Ngay_ad,
            'pMo_ta_cv' => $Mo_ta_cv,
            'pMa_dia_diem_lv' => $Ma_dia_diem_lv,
            'pMa_bp' => $Ma_bp,
            'pMa_cvcm' => $Ma_cvcm,
            'pMa_nguoi_ql' => $Ma_nguoi_ql,
            'pSo_qd' => $So_qd,
            'pNgay_qd' => $Ngay_qd,
            'pNguoi_ky_qd' => $Nguoi_ky_qd,
            'pGhi_chu' => $Ghi_chu,
            'pTai_lieu' => $Tai_lieu,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
