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
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrQTInsNghiCheDo
{
    /**
     * Call stored procedure asHrQTInsNghiCheDo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrQTInsNghiCheDo', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pId' => $paramObj->pId ?? null,
            'pId_qtncd' => $paramObj->pId_qtncd ?? null,
            'pSo_qd' => $paramObj->pSo_qd ?? null,
            'pNgay_qd' => $paramObj->pNgay_qd ?? null,
            'pNguoi_ky_qd' => $paramObj->pNguoi_ky_qd ?? null,
            'pLoai_ncd' => $paramObj->pLoai_ncd ?? null,
            'pMa_ncd' => $paramObj->pMa_ncd ?? null,
            'pDieu_kien_lv' => $paramObj->pDieu_kien_lv ?? null,
            'pMa_benh' => $paramObj->pMa_benh ?? null,
            'pTuoi_con' => $paramObj->pTuoi_con ?? null,
            'pNgay_bd' => $paramObj->pNgay_bd ?? null,
            'pNgay_kt' => $paramObj->pNgay_kt ?? null,
            'pTinh_ngay_kl' => $paramObj->pTinh_ngay_kl ?? null,
            'pSo_ngay_nghi' => $paramObj->pSo_ngay_nghi ?? null,
            'pMa_huong_dt' => $paramObj->pMa_huong_dt ?? null,
            'pMa_noi_dt' => $paramObj->pMa_noi_dt ?? null,
            'pCty_tt' => $paramObj->pCty_tt ?? null,
            'pNv_tt' => $paramObj->pNv_tt ?? null,
            'pBhxh_tt' => $paramObj->pBhxh_tt ?? null,
            'pNd_tai_gia' => $paramObj->pNd_tai_gia ?? null,
            'pNd_tap_trung' => $paramObj->pNd_tap_trung ?? null,
            'pNd_tu_ngay' => $paramObj->pNd_tu_ngay ?? null,
            'pNd_den_ngay' => $paramObj->pNd_den_ngay ?? null,
            'pNd_dia_chi' => $paramObj->pNd_dia_chi ?? null,
            'pNd_bhxh_tt' => $paramObj->pNd_bhxh_tt ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pTai_lieu' => $paramObj->pTai_lieu ?? null,
            'pCuser' => $paramObj->pCuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrQTInsNghiCheDo with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtncd
     * @param string $So_qd
     * @param string $Ngay_qd
     * @param string $Nguoi_ky_qd
     * @param string $Loai_ncd
     * @param string $Ma_ncd
     * @param string $Dieu_kien_lv
     * @param string $Ma_benh
     * @param int $Tuoi_con
     * @param string $Ngay_bd
     * @param string $Ngay_kt
     * @param bool $Tinh_ngay_kl
     * @param float $So_ngay_nghi
     * @param string $Ma_huong_dt
     * @param string $Ma_noi_dt
     * @param float $Cty_tt
     * @param float $Nv_tt
     * @param float $Bhxh_tt
     * @param float $Nd_tai_gia
     * @param float $Nd_tap_trung
     * @param string $Nd_tu_ngay
     * @param string $Nd_den_ngay
     * @param string $Nd_dia_chi
     * @param float $Nd_bhxh_tt
     * @param string $Ghi_chu
     * @param string $Tai_lieu
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtncd = null, string $So_qd = null, string $Ngay_qd = null, string $Nguoi_ky_qd = null, string $Loai_ncd = null, string $Ma_ncd = null, string $Dieu_kien_lv = null, string $Ma_benh = null, int $Tuoi_con = null, string $Ngay_bd = null, string $Ngay_kt = null, bool $Tinh_ngay_kl = null, float $So_ngay_nghi = null, string $Ma_huong_dt = null, string $Ma_noi_dt = null, float $Cty_tt = null, float $Nv_tt = null, float $Bhxh_tt = null, float $Nd_tai_gia = null, float $Nd_tap_trung = null, string $Nd_tu_ngay = null, string $Nd_den_ngay = null, string $Nd_dia_chi = null, float $Nd_bhxh_tt = null, string $Ghi_chu = null, string $Tai_lieu = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtncd' => $Id_qtncd,
            'pSo_qd' => $So_qd,
            'pNgay_qd' => $Ngay_qd,
            'pNguoi_ky_qd' => $Nguoi_ky_qd,
            'pLoai_ncd' => $Loai_ncd,
            'pMa_ncd' => $Ma_ncd,
            'pDieu_kien_lv' => $Dieu_kien_lv,
            'pMa_benh' => $Ma_benh,
            'pTuoi_con' => $Tuoi_con,
            'pNgay_bd' => $Ngay_bd,
            'pNgay_kt' => $Ngay_kt,
            'pTinh_ngay_kl' => $Tinh_ngay_kl,
            'pSo_ngay_nghi' => $So_ngay_nghi,
            'pMa_huong_dt' => $Ma_huong_dt,
            'pMa_noi_dt' => $Ma_noi_dt,
            'pCty_tt' => $Cty_tt,
            'pNv_tt' => $Nv_tt,
            'pBhxh_tt' => $Bhxh_tt,
            'pNd_tai_gia' => $Nd_tai_gia,
            'pNd_tap_trung' => $Nd_tap_trung,
            'pNd_tu_ngay' => $Nd_tu_ngay,
            'pNd_den_ngay' => $Nd_den_ngay,
            'pNd_dia_chi' => $Nd_dia_chi,
            'pNd_bhxh_tt' => $Nd_bhxh_tt,
            'pGhi_chu' => $Ghi_chu,
            'pTai_lieu' => $Tai_lieu,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
