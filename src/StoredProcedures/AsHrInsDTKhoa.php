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
use Diepxuan\Simba\Helper\ParamHelper;

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
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsDTKhoa', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_kdt' => $paramObj->pMa_kdt ?? null,
            'pTen_kdt' => $paramObj->pTen_kdt ?? null,
            'pNgay_dk' => $paramObj->pNgay_dk ?? null,
            'pNgay_bd' => $paramObj->pNgay_bd ?? null,
            'pNgay_kt' => $paramObj->pNgay_kt ?? null,
            'pNganh_dt' => $paramObj->pNganh_dt ?? null,
            'pCap_dt' => $paramObj->pCap_dt ?? null,
            'pNoi_dung' => $paramObj->pNoi_dung ?? null,
            'pChung_chi' => $paramObj->pChung_chi ?? null,
            'pMa_doi_tuong' => $paramObj->pMa_doi_tuong ?? null,
            'pTen_doi_tuong' => $paramObj->pTen_doi_tuong ?? null,
            'pDia_diem_dt' => $paramObj->pDia_diem_dt ?? null,
            'pSo_buoi' => $paramObj->pSo_buoi ?? null,
            'pThoi_luong' => $paramObj->pThoi_luong ?? null,
            'pTien_dt' => $paramObj->pTien_dt ?? null,
            'pTl_dt_cty' => $paramObj->pTl_dt_cty ?? null,
            'pTien_dt_cty' => $paramObj->pTien_dt_cty ?? null,
            'pTl_dt_nv' => $paramObj->pTl_dt_nv ?? null,
            'pTien_dt_nv' => $paramObj->pTien_dt_nv ?? null,
            'pKet_qua' => $paramObj->pKet_qua ?? null,
            'pGhi_chu' => $paramObj->pGhi_chu ?? null,
            'pTrang_thai' => $paramObj->pTrang_thai ?? null,
            'pTai_lieu' => $paramObj->pTai_lieu ?? null,
            'pCuser' => $paramObj->pCuser ?? null,
            'pRet' => $paramObj->pRet ?? null
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
