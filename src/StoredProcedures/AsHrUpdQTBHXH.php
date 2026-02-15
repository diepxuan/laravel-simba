<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:57
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrUpdQTBHXH
{
    /**
     * Call stored procedure asHrUpdQTBHXH
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdQTBHXH', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qtbhxh' => $params['pId_qtbhxh'] ?? null,
            'pNgay_bd' => $params['pNgay_bd'] ?? null,
            'pNgay_kt' => $params['pNgay_kt'] ?? null,
            'pSo_thang' => $params['pSo_thang'] ?? null,
            'pSo_nam' => $params['pSo_nam'] ?? null,
            'pTong_so_thang' => $params['pTong_so_thang'] ?? null,
            'pMa_cvcm' => $params['pMa_cvcm'] ?? null,
            'pHe_so_luong' => $params['pHe_so_luong'] ?? null,
            'pTong_phu_cap' => $params['pTong_phu_cap'] ?? null,
            'pLuong_toi_thieu' => $params['pLuong_toi_thieu'] ?? null,
            'pLuong_co_ban' => $params['pLuong_co_ban'] ?? null,
            'pTong_luong' => $params['pTong_luong'] ?? null,
            'pTl_BHXH_cty' => $params['pTl_BHXH_cty'] ?? null,
            'pTien_BHXH_cty' => $params['pTien_BHXH_cty'] ?? null,
            'pTl_BHYT_cty' => $params['pTl_BHYT_cty'] ?? null,
            'pTien_BHYT_cty' => $params['pTien_BHYT_cty'] ?? null,
            'pTl_BHTN_cty' => $params['pTl_BHTN_cty'] ?? null,
            'pTien_BHTN_cty' => $params['pTien_BHTN_cty'] ?? null,
            'pTl_BHXH_nv' => $params['pTl_BHXH_nv'] ?? null,
            'pTien_BHXH_nv' => $params['pTien_BHXH_nv'] ?? null,
            'pTl_BHYT_nv' => $params['pTl_BHYT_nv'] ?? null,
            'pTien_BHYT_nv' => $params['pTien_BHYT_nv'] ?? null,
            'pTl_BHTN_nv' => $params['pTl_BHTN_nv'] ?? null,
            'pTien_BHTN_nv' => $params['pTien_BHTN_nv'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdQTBHXH with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtbhxh
     * @param string $Ngay_bd
     * @param string $Ngay_kt
     * @param int $So_thang
     * @param int $So_nam
     * @param int $Tong_so_thang
     * @param string $Ma_cvcm
     * @param float $He_so_luong
     * @param float $Tong_phu_cap
     * @param float $Luong_toi_thieu
     * @param float $Luong_co_ban
     * @param float $Tong_luong
     * @param float $Tl_BHXH_cty
     * @param float $Tien_BHXH_cty
     * @param float $Tl_BHYT_cty
     * @param float $Tien_BHYT_cty
     * @param float $Tl_BHTN_cty
     * @param float $Tien_BHTN_cty
     * @param float $Tl_BHXH_nv
     * @param float $Tien_BHXH_nv
     * @param float $Tl_BHYT_nv
     * @param float $Tien_BHYT_nv
     * @param float $Tl_BHTN_nv
     * @param float $Tien_BHTN_nv
     * @param string $Ghi_chu
     * @param string $Tai_lieu
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtbhxh = null, string $Ngay_bd = null, string $Ngay_kt = null, int $So_thang = null, int $So_nam = null, int $Tong_so_thang = null, string $Ma_cvcm = null, float $He_so_luong = null, float $Tong_phu_cap = null, float $Luong_toi_thieu = null, float $Luong_co_ban = null, float $Tong_luong = null, float $Tl_BHXH_cty = null, float $Tien_BHXH_cty = null, float $Tl_BHYT_cty = null, float $Tien_BHYT_cty = null, float $Tl_BHTN_cty = null, float $Tien_BHTN_cty = null, float $Tl_BHXH_nv = null, float $Tien_BHXH_nv = null, float $Tl_BHYT_nv = null, float $Tien_BHYT_nv = null, float $Tl_BHTN_nv = null, float $Tien_BHTN_nv = null, string $Ghi_chu = null, string $Tai_lieu = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtbhxh' => $Id_qtbhxh,
            'pNgay_bd' => $Ngay_bd,
            'pNgay_kt' => $Ngay_kt,
            'pSo_thang' => $So_thang,
            'pSo_nam' => $So_nam,
            'pTong_so_thang' => $Tong_so_thang,
            'pMa_cvcm' => $Ma_cvcm,
            'pHe_so_luong' => $He_so_luong,
            'pTong_phu_cap' => $Tong_phu_cap,
            'pLuong_toi_thieu' => $Luong_toi_thieu,
            'pLuong_co_ban' => $Luong_co_ban,
            'pTong_luong' => $Tong_luong,
            'pTl_BHXH_cty' => $Tl_BHXH_cty,
            'pTien_BHXH_cty' => $Tien_BHXH_cty,
            'pTl_BHYT_cty' => $Tl_BHYT_cty,
            'pTien_BHYT_cty' => $Tien_BHYT_cty,
            'pTl_BHTN_cty' => $Tl_BHTN_cty,
            'pTien_BHTN_cty' => $Tien_BHTN_cty,
            'pTl_BHXH_nv' => $Tl_BHXH_nv,
            'pTien_BHXH_nv' => $Tien_BHXH_nv,
            'pTl_BHYT_nv' => $Tl_BHYT_nv,
            'pTien_BHYT_nv' => $Tien_BHYT_nv,
            'pTl_BHTN_nv' => $Tl_BHTN_nv,
            'pTien_BHTN_nv' => $Tien_BHTN_nv,
            'pGhi_chu' => $Ghi_chu,
            'pTai_lieu' => $Tai_lieu,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
