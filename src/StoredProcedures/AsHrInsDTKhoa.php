<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:12
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsDTKhoa
{
    /**
     * Call stored procedure asHrInsDTKhoa
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsDTKhoa', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pMa_kdt' => $params['pMa_kdt'] ?? null,
            'pTen_kdt' => $params['pTen_kdt'] ?? null,
            'pNgay_dk' => $params['pNgay_dk'] ?? null,
            'pNgay_bd' => $params['pNgay_bd'] ?? null,
            'pNgay_kt' => $params['pNgay_kt'] ?? null,
            'pNganh_dt' => $params['pNganh_dt'] ?? null,
            'pCap_dt' => $params['pCap_dt'] ?? null,
            'pNoi_dung' => $params['pNoi_dung'] ?? null,
            'pChung_chi' => $params['pChung_chi'] ?? null,
            'pMa_doi_tuong' => $params['pMa_doi_tuong'] ?? null,
            'pTen_doi_tuong' => $params['pTen_doi_tuong'] ?? null,
            'pDia_diem_dt' => $params['pDia_diem_dt'] ?? null,
            'pSo_buoi' => $params['pSo_buoi'] ?? null,
            'pThoi_luong' => $params['pThoi_luong'] ?? null,
            'pTien_dt' => $params['pTien_dt'] ?? null,
            'pTl_dt_cty' => $params['pTl_dt_cty'] ?? null,
            'pTien_dt_cty' => $params['pTien_dt_cty'] ?? null,
            'pTl_dt_nv' => $params['pTl_dt_nv'] ?? null,
            'pTien_dt_nv' => $params['pTien_dt_nv'] ?? null,
            'pKet_qua' => $params['pKet_qua'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsDTKhoa with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_kdt
     * @param string $Ten_kdt
     * @param string $Ngay_dk
     * @param string $Ngay_bd
     * @param string $Ngay_kt
     * @param string $Nganh_dt
     * @param string $Cap_dt
     * @param string $Noi_dung
     * @param string $Chung_chi
     * @param string $Ma_doi_tuong
     * @param string $Ten_doi_tuong
     * @param string $Dia_diem_dt
     * @param int $So_buoi
     * @param float $Thoi_luong
     * @param float $Tien_dt
     * @param float $Tl_dt_cty
     * @param float $Tien_dt_cty
     * @param float $Tl_dt_nv
     * @param float $Tien_dt_nv
     * @param string $Ket_qua
     * @param string $Ghi_chu
     * @param string $Trang_thai
     * @param string $Tai_lieu
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_kdt = null, string $Ten_kdt = null, string $Ngay_dk = null, string $Ngay_bd = null, string $Ngay_kt = null, string $Nganh_dt = null, string $Cap_dt = null, string $Noi_dung = null, string $Chung_chi = null, string $Ma_doi_tuong = null, string $Ten_doi_tuong = null, string $Dia_diem_dt = null, int $So_buoi = null, float $Thoi_luong = null, float $Tien_dt = null, float $Tl_dt_cty = null, float $Tien_dt_cty = null, float $Tl_dt_nv = null, float $Tien_dt_nv = null, string $Ket_qua = null, string $Ghi_chu = null, string $Trang_thai = null, string $Tai_lieu = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_kdt' => $Ma_kdt,
            'pTen_kdt' => $Ten_kdt,
            'pNgay_dk' => $Ngay_dk,
            'pNgay_bd' => $Ngay_bd,
            'pNgay_kt' => $Ngay_kt,
            'pNganh_dt' => $Nganh_dt,
            'pCap_dt' => $Cap_dt,
            'pNoi_dung' => $Noi_dung,
            'pChung_chi' => $Chung_chi,
            'pMa_doi_tuong' => $Ma_doi_tuong,
            'pTen_doi_tuong' => $Ten_doi_tuong,
            'pDia_diem_dt' => $Dia_diem_dt,
            'pSo_buoi' => $So_buoi,
            'pThoi_luong' => $Thoi_luong,
            'pTien_dt' => $Tien_dt,
            'pTl_dt_cty' => $Tl_dt_cty,
            'pTien_dt_cty' => $Tien_dt_cty,
            'pTl_dt_nv' => $Tl_dt_nv,
            'pTien_dt_nv' => $Tien_dt_nv,
            'pKet_qua' => $Ket_qua,
            'pGhi_chu' => $Ghi_chu,
            'pTrang_thai' => $Trang_thai,
            'pTai_lieu' => $Tai_lieu,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
