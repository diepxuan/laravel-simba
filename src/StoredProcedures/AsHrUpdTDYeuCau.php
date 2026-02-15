<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:51
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrUpdTDYeuCau
{
    /**
     * Call stored procedure asHrUpdTDYeuCau
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdTDYeuCau', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_yctd' => $params['pMa_yctd'] ?? null,
            'pTen_yctd' => $params['pTen_yctd'] ?? null,
            'pNguoi_yc' => $params['pNguoi_yc'] ?? null,
            'pNgay_bd' => $params['pNgay_bd'] ?? null,
            'pNgay_kt' => $params['pNgay_kt'] ?? null,
            'pHt_nop_hs' => $params['pHt_nop_hs'] ?? null,
            'pMa_dia_diem_lv' => $params['pMa_dia_diem_lv'] ?? null,
            'pTen_dia_diem_lv' => $params['pTen_dia_diem_lv'] ?? null,
            'pMa_bp' => $params['pMa_bp'] ?? null,
            'pMa_cvcm' => $params['pMa_cvcm'] ?? null,
            'pMo_ta' => $params['pMo_ta'] ?? null,
            'pSo_luong_tuyen' => $params['pSo_luong_tuyen'] ?? null,
            'pThoi_gian_lv' => $params['pThoi_gian_lv'] ?? null,
            'pMa_htlv' => $params['pMa_htlv'] ?? null,
            'pGioi_tinh' => $params['pGioi_tinh'] ?? null,
            'pTuoi_tu' => $params['pTuoi_tu'] ?? null,
            'pTuoi_den' => $params['pTuoi_den'] ?? null,
            'pMuc_chuyen_mon' => $params['pMuc_chuyen_mon'] ?? null,
            'pMa_chuyen_mon' => $params['pMa_chuyen_mon'] ?? null,
            'pTen_chuyen_mon' => $params['pTen_chuyen_mon'] ?? null,
            'pBx_chuyen_mon' => $params['pBx_chuyen_mon'] ?? null,
            'pMuc_ky_nang' => $params['pMuc_ky_nang'] ?? null,
            'pMa_ky_nang' => $params['pMa_ky_nang'] ?? null,
            'pTen_ky_nang' => $params['pTen_ky_nang'] ?? null,
            'pBx_ky_nang' => $params['pBx_ky_nang'] ?? null,
            'pMuc_trinh_do' => $params['pMuc_trinh_do'] ?? null,
            'pMa_trinh_do' => $params['pMa_trinh_do'] ?? null,
            'pTen_trinh_do' => $params['pTen_trinh_do'] ?? null,
            'pBx_trinh_do' => $params['pBx_trinh_do'] ?? null,
            'pMuc_luong' => $params['pMuc_luong'] ?? null,
            'pQuyen_loi' => $params['pQuyen_loi'] ?? null,
            'pDs_ho_so' => $params['pDs_ho_so'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdTDYeuCau with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_yctd
     * @param string $Ten_yctd
     * @param string $Nguoi_yc
     * @param string $Ngay_bd
     * @param string $Ngay_kt
     * @param string $Ht_nop_hs
     * @param string $Ma_dia_diem_lv
     * @param string $Ten_dia_diem_lv
     * @param string $Ma_bp
     * @param string $Ma_cvcm
     * @param string $Mo_ta
     * @param float $So_luong_tuyen
     * @param string $Thoi_gian_lv
     * @param string $Ma_htlv
     * @param string $Gioi_tinh
     * @param float $Tuoi_tu
     * @param float $Tuoi_den
     * @param string $Muc_chuyen_mon
     * @param string $Ma_chuyen_mon
     * @param string $Ten_chuyen_mon
     * @param string $Bx_chuyen_mon
     * @param string $Muc_ky_nang
     * @param string $Ma_ky_nang
     * @param string $Ten_ky_nang
     * @param string $Bx_ky_nang
     * @param string $Muc_trinh_do
     * @param string $Ma_trinh_do
     * @param string $Ten_trinh_do
     * @param string $Bx_trinh_do
     * @param string $Muc_luong
     * @param string $Quyen_loi
     * @param string $Ds_ho_so
     * @param string $Ghi_chu
     * @param string $Trang_thai
     * @param string $Tai_lieu
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_yctd = null, string $Ten_yctd = null, string $Nguoi_yc = null, string $Ngay_bd = null, string $Ngay_kt = null, string $Ht_nop_hs = null, string $Ma_dia_diem_lv = null, string $Ten_dia_diem_lv = null, string $Ma_bp = null, string $Ma_cvcm = null, string $Mo_ta = null, float $So_luong_tuyen = null, string $Thoi_gian_lv = null, string $Ma_htlv = null, string $Gioi_tinh = null, float $Tuoi_tu = null, float $Tuoi_den = null, string $Muc_chuyen_mon = null, string $Ma_chuyen_mon = null, string $Ten_chuyen_mon = null, string $Bx_chuyen_mon = null, string $Muc_ky_nang = null, string $Ma_ky_nang = null, string $Ten_ky_nang = null, string $Bx_ky_nang = null, string $Muc_trinh_do = null, string $Ma_trinh_do = null, string $Ten_trinh_do = null, string $Bx_trinh_do = null, string $Muc_luong = null, string $Quyen_loi = null, string $Ds_ho_so = null, string $Ghi_chu = null, string $Trang_thai = null, string $Tai_lieu = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_yctd' => $Ma_yctd,
            'pTen_yctd' => $Ten_yctd,
            'pNguoi_yc' => $Nguoi_yc,
            'pNgay_bd' => $Ngay_bd,
            'pNgay_kt' => $Ngay_kt,
            'pHt_nop_hs' => $Ht_nop_hs,
            'pMa_dia_diem_lv' => $Ma_dia_diem_lv,
            'pTen_dia_diem_lv' => $Ten_dia_diem_lv,
            'pMa_bp' => $Ma_bp,
            'pMa_cvcm' => $Ma_cvcm,
            'pMo_ta' => $Mo_ta,
            'pSo_luong_tuyen' => $So_luong_tuyen,
            'pThoi_gian_lv' => $Thoi_gian_lv,
            'pMa_htlv' => $Ma_htlv,
            'pGioi_tinh' => $Gioi_tinh,
            'pTuoi_tu' => $Tuoi_tu,
            'pTuoi_den' => $Tuoi_den,
            'pMuc_chuyen_mon' => $Muc_chuyen_mon,
            'pMa_chuyen_mon' => $Ma_chuyen_mon,
            'pTen_chuyen_mon' => $Ten_chuyen_mon,
            'pBx_chuyen_mon' => $Bx_chuyen_mon,
            'pMuc_ky_nang' => $Muc_ky_nang,
            'pMa_ky_nang' => $Ma_ky_nang,
            'pTen_ky_nang' => $Ten_ky_nang,
            'pBx_ky_nang' => $Bx_ky_nang,
            'pMuc_trinh_do' => $Muc_trinh_do,
            'pMa_trinh_do' => $Ma_trinh_do,
            'pTen_trinh_do' => $Ten_trinh_do,
            'pBx_trinh_do' => $Bx_trinh_do,
            'pMuc_luong' => $Muc_luong,
            'pQuyen_loi' => $Quyen_loi,
            'pDs_ho_so' => $Ds_ho_so,
            'pGhi_chu' => $Ghi_chu,
            'pTrang_thai' => $Trang_thai,
            'pTai_lieu' => $Tai_lieu,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
