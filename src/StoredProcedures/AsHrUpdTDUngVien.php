<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrUpdTDUngVien
{
    /**
     * Call stored procedure asHrUpdTDUngVien
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdTDUngVien', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_yctd' => $params['pMa_yctd'] ?? null,
            'pVong_so' => $params['pVong_so'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pHo_ten' => $params['pHo_ten'] ?? null,
            'pHo_dem' => $params['pHo_dem'] ?? null,
            'pTen' => $params['pTen'] ?? null,
            'pNgay_sinh' => $params['pNgay_sinh'] ?? null,
            'pGioi_tinh' => $params['pGioi_tinh'] ?? null,
            'pSo_cmnd' => $params['pSo_cmnd'] ?? null,
            'pMa_dia_dem_lv' => $params['pMa_dia_dem_lv'] ?? null,
            'pTen_dia_diem_lv' => $params['pTen_dia_diem_lv'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_cvcm' => $params['pMa_cvcm'] ?? null,
            'pThoi_gian_lv' => $params['pThoi_gian_lv'] ?? null,
            'pMa_htlv' => $params['pMa_htlv'] ?? null,
            'pLuong_de_nghi' => $params['pLuong_de_nghi'] ?? null,
            'pLuong_chap_nhan' => $params['pLuong_chap_nhan'] ?? null,
            'pNgay_ctdl' => $params['pNgay_ctdl'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdTDUngVien with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_yctd
     * @param string $Vong_so
     * @param string $Id
     * @param string $Ho_ten
     * @param string $Ho_dem
     * @param string $Ten
     * @param string $Ngay_sinh
     * @param string $Gioi_tinh
     * @param string $So_cmnd
     * @param string $Ma_dia_dem_lv
     * @param string $Ten_dia_diem_lv
     * @param string $Ma_bp
     * @param string $Ma_cvcm
     * @param string $Thoi_gian_lv
     * @param string $Ma_htlv
     * @param float $Luong_de_nghi
     * @param float $Luong_chap_nhan
     * @param string $Ngay_ctdl
     * @param string $Tai_lieu
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_yctd = null, string $Vong_so = null, string $Id = null, string $Ho_ten = null, string $Ho_dem = null, string $Ten = null, string $Ngay_sinh = null, string $Gioi_tinh = null, string $So_cmnd = null, string $Ma_dia_dem_lv = null, string $Ten_dia_diem_lv = null, string $Ma_bp = null, string $Ma_cvcm = null, string $Thoi_gian_lv = null, string $Ma_htlv = null, float $Luong_de_nghi = null, float $Luong_chap_nhan = null, string $Ngay_ctdl = null, string $Tai_lieu = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_yctd' => $Ma_yctd,
            'pVong_so' => $Vong_so,
            'pId' => $Id,
            'pHo_ten' => $Ho_ten,
            'pHo_dem' => $Ho_dem,
            'pTen' => $Ten,
            'pNgay_sinh' => $Ngay_sinh,
            'pGioi_tinh' => $Gioi_tinh,
            'pSo_cmnd' => $So_cmnd,
            'pMa_dia_dem_lv' => $Ma_dia_dem_lv,
            'pTen_dia_diem_lv' => $Ten_dia_diem_lv,
            'pMa_bp' => $Ma_bp,
            'pMa_cvcm' => $Ma_cvcm,
            'pThoi_gian_lv' => $Thoi_gian_lv,
            'pMa_htlv' => $Ma_htlv,
            'pLuong_de_nghi' => $Luong_de_nghi,
            'pLuong_chap_nhan' => $Luong_chap_nhan,
            'pNgay_ctdl' => $Ngay_ctdl,
            'pTai_lieu' => $Tai_lieu,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
