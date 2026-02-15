<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrUpdQTLuong
{
    /**
     * Call stored procedure asHrUpdQTLuong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdQTLuong', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qtluong' => $params['pId_qtluong'] ?? null,
            'pNgay_ad' => $params['pNgay_ad'] ?? null,
            'pLuong_nb' => $params['pLuong_nb'] ?? null,
            'pMa_tbl' => $params['pMa_tbl'] ?? null,
            'pMa_nb' => $params['pMa_nb'] ?? null,
            'pHe_so_luong' => $params['pHe_so_luong'] ?? null,
            'pTong_phu_cap' => $params['pTong_phu_cap'] ?? null,
            'pMuc_luong' => $params['pMuc_luong'] ?? null,
            'pMuc_luong_BHXH' => $params['pMuc_luong_BHXH'] ?? null,
            'pSo_qd' => $params['pSo_qd'] ?? null,
            'pNgay_qd' => $params['pNgay_qd'] ?? null,
            'pNguoi_ky_qd' => $params['pNguoi_ky_qd'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdQTLuong with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtluong
     * @param string $Ngay_ad
     * @param bool $Luong_nb
     * @param string $Ma_tbl
     * @param string $Ma_nb
     * @param float $He_so_luong
     * @param float $Tong_phu_cap
     * @param float $Muc_luong
     * @param float $Muc_luong_BHXH
     * @param string $So_qd
     * @param string $Ngay_qd
     * @param string $Nguoi_ky_qd
     * @param string $Ghi_chu
     * @param string $Tai_lieu
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtluong = null, string $Ngay_ad = null, bool $Luong_nb = null, string $Ma_tbl = null, string $Ma_nb = null, float $He_so_luong = null, float $Tong_phu_cap = null, float $Muc_luong = null, float $Muc_luong_BHXH = null, string $So_qd = null, string $Ngay_qd = null, string $Nguoi_ky_qd = null, string $Ghi_chu = null, string $Tai_lieu = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtluong' => $Id_qtluong,
            'pNgay_ad' => $Ngay_ad,
            'pLuong_nb' => $Luong_nb,
            'pMa_tbl' => $Ma_tbl,
            'pMa_nb' => $Ma_nb,
            'pHe_so_luong' => $He_so_luong,
            'pTong_phu_cap' => $Tong_phu_cap,
            'pMuc_luong' => $Muc_luong,
            'pMuc_luong_BHXH' => $Muc_luong_BHXH,
            'pSo_qd' => $So_qd,
            'pNgay_qd' => $Ngay_qd,
            'pNguoi_ky_qd' => $Nguoi_ky_qd,
            'pGhi_chu' => $Ghi_chu,
            'pTai_lieu' => $Tai_lieu,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
