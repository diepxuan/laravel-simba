<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:52
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrUpdQTHopDongLD
{
    /**
     * Call stored procedure asHrUpdQTHopDongLD
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdQTHopDongLD', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qthdld' => $params['pId_qthdld'] ?? null,
            'pMa_loai_hd' => $params['pMa_loai_hd'] ?? null,
            'pSo_hd' => $params['pSo_hd'] ?? null,
            'pNgay_bd' => $params['pNgay_bd'] ?? null,
            'pNgay_kt' => $params['pNgay_kt'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_dia_diem_lv' => $params['pMa_dia_diem_lv'] ?? null,
            'pMa_cvcm' => $params['pMa_cvcm'] ?? null,
            'pChuc_vu' => $params['pChuc_vu'] ?? null,
            'pMo_ta_cv' => $params['pMo_ta_cv'] ?? null,
            'pThoi_gian_lv' => $params['pThoi_gian_lv'] ?? null,
            'pPhuong_tien' => $params['pPhuong_tien'] ?? null,
            'pHt_tra_luong' => $params['pHt_tra_luong'] ?? null,
            'pNgay_tra_luong' => $params['pNgay_tra_luong'] ?? null,
            'pTien_luong' => $params['pTien_luong'] ?? null,
            'pTong_phu_cap' => $params['pTong_phu_cap'] ?? null,
            'pTen_phu_cap' => $params['pTen_phu_cap'] ?? null,
            'pTien_thuong' => $params['pTien_thuong'] ?? null,
            'pCd_nang_luong' => $params['pCd_nang_luong'] ?? null,
            'pCd_bao_ho_ld' => $params['pCd_bao_ho_ld'] ?? null,
            'pCd_nghi_ngoi' => $params['pCd_nghi_ngoi'] ?? null,
            'pCd_bhxh' => $params['pCd_bhxh'] ?? null,
            'pCd_dao_tao' => $params['pCd_dao_tao'] ?? null,
            'pThoa_thuan' => $params['pThoa_thuan'] ?? null,
            'pCd_boi_thuong' => $params['pCd_boi_thuong'] ?? null,
            'pNguoi_ky' => $params['pNguoi_ky'] ?? null,
            'pCvu_nguoi_ky' => $params['pCvu_nguoi_ky'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdQTHopDongLD with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qthdld
     * @param string $Ma_loai_hd
     * @param string $So_hd
     * @param string $Ngay_bd
     * @param string $Ngay_kt
     * @param string $Ma_bp
     * @param string $Ma_dia_diem_lv
     * @param string $Ma_cvcm
     * @param string $Chuc_vu
     * @param string $Mo_ta_cv
     * @param string $Thoi_gian_lv
     * @param string $Phuong_tien
     * @param string $Ht_tra_luong
     * @param string $Ngay_tra_luong
     * @param float $Tien_luong
     * @param float $Tong_phu_cap
     * @param string $Ten_phu_cap
     * @param float $Tien_thuong
     * @param string $Cd_nang_luong
     * @param string $Cd_bao_ho_ld
     * @param string $Cd_nghi_ngoi
     * @param string $Cd_bhxh
     * @param string $Cd_dao_tao
     * @param string $Thoa_thuan
     * @param string $Cd_boi_thuong
     * @param string $Nguoi_ky
     * @param string $Cvu_nguoi_ky
     * @param string $Tai_lieu
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qthdld = null, string $Ma_loai_hd = null, string $So_hd = null, string $Ngay_bd = null, string $Ngay_kt = null, string $Ma_bp = null, string $Ma_dia_diem_lv = null, string $Ma_cvcm = null, string $Chuc_vu = null, string $Mo_ta_cv = null, string $Thoi_gian_lv = null, string $Phuong_tien = null, string $Ht_tra_luong = null, string $Ngay_tra_luong = null, float $Tien_luong = null, float $Tong_phu_cap = null, string $Ten_phu_cap = null, float $Tien_thuong = null, string $Cd_nang_luong = null, string $Cd_bao_ho_ld = null, string $Cd_nghi_ngoi = null, string $Cd_bhxh = null, string $Cd_dao_tao = null, string $Thoa_thuan = null, string $Cd_boi_thuong = null, string $Nguoi_ky = null, string $Cvu_nguoi_ky = null, string $Tai_lieu = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qthdld' => $Id_qthdld,
            'pMa_loai_hd' => $Ma_loai_hd,
            'pSo_hd' => $So_hd,
            'pNgay_bd' => $Ngay_bd,
            'pNgay_kt' => $Ngay_kt,
            'pMa_bp' => $Ma_bp,
            'pMa_dia_diem_lv' => $Ma_dia_diem_lv,
            'pMa_cvcm' => $Ma_cvcm,
            'pChuc_vu' => $Chuc_vu,
            'pMo_ta_cv' => $Mo_ta_cv,
            'pThoi_gian_lv' => $Thoi_gian_lv,
            'pPhuong_tien' => $Phuong_tien,
            'pHt_tra_luong' => $Ht_tra_luong,
            'pNgay_tra_luong' => $Ngay_tra_luong,
            'pTien_luong' => $Tien_luong,
            'pTong_phu_cap' => $Tong_phu_cap,
            'pTen_phu_cap' => $Ten_phu_cap,
            'pTien_thuong' => $Tien_thuong,
            'pCd_nang_luong' => $Cd_nang_luong,
            'pCd_bao_ho_ld' => $Cd_bao_ho_ld,
            'pCd_nghi_ngoi' => $Cd_nghi_ngoi,
            'pCd_bhxh' => $Cd_bhxh,
            'pCd_dao_tao' => $Cd_dao_tao,
            'pThoa_thuan' => $Thoa_thuan,
            'pCd_boi_thuong' => $Cd_boi_thuong,
            'pNguoi_ky' => $Nguoi_ky,
            'pCvu_nguoi_ky' => $Cvu_nguoi_ky,
            'pTai_lieu' => $Tai_lieu,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
