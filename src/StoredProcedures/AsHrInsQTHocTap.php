<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:03
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsQTHocTap
{
    /**
     * Call stored procedure asHrInsQTHocTap
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsQTHocTap', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qtht' => $params['pId_qtht'] ?? null,
            'pMa_tddt' => $params['pMa_tddt'] ?? null,
            'pMa_htdt' => $params['pMa_htdt'] ?? null,
            'pMa_bang_cap' => $params['pMa_bang_cap'] ?? null,
            'pMa_nganh' => $params['pMa_nganh'] ?? null,
            'pGpa' => $params['pGpa'] ?? null,
            'pTong_ket' => $params['pTong_ket'] ?? null,
            'pXep_loai' => $params['pXep_loai'] ?? null,
            'pNgay_bd' => $params['pNgay_bd'] ?? null,
            'pNgay_kt' => $params['pNgay_kt'] ?? null,
            'pTrang_thai' => $params['pTrang_thai'] ?? null,
            'pMa_tcdt' => $params['pMa_tcdt'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pTai_lieu' => $params['pTai_lieu'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsQTHocTap with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtht
     * @param string $Ma_tddt
     * @param string $Ma_htdt
     * @param string $Ma_bang_cap
     * @param string $Ma_nganh
     * @param float $Gpa
     * @param float $Tong_ket
     * @param string $Xep_loai
     * @param string $Ngay_bd
     * @param string $Ngay_kt
     * @param string $Trang_thai
     * @param string $Ma_tcdt
     * @param string $Ghi_chu
     * @param string $Tai_lieu
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtht = null, string $Ma_tddt = null, string $Ma_htdt = null, string $Ma_bang_cap = null, string $Ma_nganh = null, float $Gpa = null, float $Tong_ket = null, string $Xep_loai = null, string $Ngay_bd = null, string $Ngay_kt = null, string $Trang_thai = null, string $Ma_tcdt = null, string $Ghi_chu = null, string $Tai_lieu = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtht' => $Id_qtht,
            'pMa_tddt' => $Ma_tddt,
            'pMa_htdt' => $Ma_htdt,
            'pMa_bang_cap' => $Ma_bang_cap,
            'pMa_nganh' => $Ma_nganh,
            'pGpa' => $Gpa,
            'pTong_ket' => $Tong_ket,
            'pXep_loai' => $Xep_loai,
            'pNgay_bd' => $Ngay_bd,
            'pNgay_kt' => $Ngay_kt,
            'pTrang_thai' => $Trang_thai,
            'pMa_tcdt' => $Ma_tcdt,
            'pGhi_chu' => $Ghi_chu,
            'pTai_lieu' => $Tai_lieu,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
