<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:05
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrInsQTCapCongCu
{
    /**
     * Call stored procedure asHrInsQTCapCongCu
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsQTCapCongCu', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pId_qtccc' => $params['pId_qtccc'] ?? null,
            'pMa_nhcc' => $params['pMa_nhcc'] ?? null,
            'pMa_cc' => $params['pMa_cc'] ?? null,
            'pTen_cc' => $params['pTen_cc'] ?? null,
            'pNgay_cap' => $params['pNgay_cap'] ?? null,
            'pNgay_tra' => $params['pNgay_tra'] ?? null,
            'pSo_luong' => $params['pSo_luong'] ?? null,
            'pGia_tri' => $params['pGia_tri'] ?? null,
            'pTong_gia_tri' => $params['pTong_gia_tri'] ?? null,
            'pGhi_chu' => $params['pGhi_chu'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsQTCapCongCu with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @param string $Id_qtccc
     * @param string $Ma_nhcc
     * @param string $Ma_cc
     * @param string $Ten_cc
     * @param string $Ngay_cap
     * @param string $Ngay_tra
     * @param float $So_luong
     * @param float $Gia_tri
     * @param float $Tong_gia_tri
     * @param string $Ghi_chu
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null, string $Id_qtccc = null, string $Ma_nhcc = null, string $Ma_cc = null, string $Ten_cc = null, string $Ngay_cap = null, string $Ngay_tra = null, float $So_luong = null, float $Gia_tri = null, float $Tong_gia_tri = null, string $Ghi_chu = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id,
            'pId_qtccc' => $Id_qtccc,
            'pMa_nhcc' => $Ma_nhcc,
            'pMa_cc' => $Ma_cc,
            'pTen_cc' => $Ten_cc,
            'pNgay_cap' => $Ngay_cap,
            'pNgay_tra' => $Ngay_tra,
            'pSo_luong' => $So_luong,
            'pGia_tri' => $Gia_tri,
            'pTong_gia_tri' => $Tong_gia_tri,
            'pGhi_chu' => $Ghi_chu,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
