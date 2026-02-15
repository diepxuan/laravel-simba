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

class AsHrInsChamCong
{
    /**
     * Call stored procedure asHrInsChamCong
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsChamCong', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNam' => $params['pNam'] ?? null,
            'pThang' => $params['pThang'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pMa_cham_cong' => $params['pMa_cham_cong'] ?? null,
            'pMa_cvcm' => $params['pMa_cvcm'] ?? null,
            'pHe_so_luong' => $params['pHe_so_luong'] ?? null,
            'pTong_phu_cap' => $params['pTong_phu_cap'] ?? null,
            'pMuc_luong' => $params['pMuc_luong'] ?? null,
            'pTong_luong' => $params['pTong_luong'] ?? null,
            'pNgay01' => $params['pNgay01'] ?? null,
            'pNgay02' => $params['pNgay02'] ?? null,
            'pNgay03' => $params['pNgay03'] ?? null,
            'pNgay04' => $params['pNgay04'] ?? null,
            'pNgay05' => $params['pNgay05'] ?? null,
            'pNgay06' => $params['pNgay06'] ?? null,
            'pNgay07' => $params['pNgay07'] ?? null,
            'pNgay08' => $params['pNgay08'] ?? null,
            'pNgay09' => $params['pNgay09'] ?? null,
            'pNgay10' => $params['pNgay10'] ?? null,
            'pNgay11' => $params['pNgay11'] ?? null,
            'pNgay12' => $params['pNgay12'] ?? null,
            'pNgay13' => $params['pNgay13'] ?? null,
            'pNgay14' => $params['pNgay14'] ?? null,
            'pNgay15' => $params['pNgay15'] ?? null,
            'pNgay16' => $params['pNgay16'] ?? null,
            'pNgay17' => $params['pNgay17'] ?? null,
            'pNgay18' => $params['pNgay18'] ?? null,
            'pNgay19' => $params['pNgay19'] ?? null,
            'pNgay20' => $params['pNgay20'] ?? null,
            'pNgay21' => $params['pNgay21'] ?? null,
            'pNgay22' => $params['pNgay22'] ?? null,
            'pNgay23' => $params['pNgay23'] ?? null,
            'pNgay24' => $params['pNgay24'] ?? null,
            'pNgay25' => $params['pNgay25'] ?? null,
            'pNgay26' => $params['pNgay26'] ?? null,
            'pNgay27' => $params['pNgay27'] ?? null,
            'pNgay28' => $params['pNgay28'] ?? null,
            'pNgay29' => $params['pNgay29'] ?? null,
            'pNgay30' => $params['pNgay30'] ?? null,
            'pNgay31' => $params['pNgay31'] ?? null,
            'pCuser' => $params['pCuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsChamCong with named parameters
     *
     * @param string $Ma_cty
     * @param int $Nam
     * @param int $Thang
     * @param string $Id
     * @param string $Ma_cham_cong
     * @param string $Ma_cvcm
     * @param float $He_so_luong
     * @param float $Tong_phu_cap
     * @param float $Muc_luong
     * @param float $Tong_luong
     * @param string $Ngay01
     * @param string $Ngay02
     * @param string $Ngay03
     * @param string $Ngay04
     * @param string $Ngay05
     * @param string $Ngay06
     * @param string $Ngay07
     * @param string $Ngay08
     * @param string $Ngay09
     * @param string $Ngay10
     * @param string $Ngay11
     * @param string $Ngay12
     * @param string $Ngay13
     * @param string $Ngay14
     * @param string $Ngay15
     * @param string $Ngay16
     * @param string $Ngay17
     * @param string $Ngay18
     * @param string $Ngay19
     * @param string $Ngay20
     * @param string $Ngay21
     * @param string $Ngay22
     * @param string $Ngay23
     * @param string $Ngay24
     * @param string $Ngay25
     * @param string $Ngay26
     * @param string $Ngay27
     * @param string $Ngay28
     * @param string $Ngay29
     * @param string $Ngay30
     * @param string $Ngay31
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, int $Nam = null, int $Thang = null, string $Id = null, string $Ma_cham_cong = null, string $Ma_cvcm = null, float $He_so_luong = null, float $Tong_phu_cap = null, float $Muc_luong = null, float $Tong_luong = null, string $Ngay01 = null, string $Ngay02 = null, string $Ngay03 = null, string $Ngay04 = null, string $Ngay05 = null, string $Ngay06 = null, string $Ngay07 = null, string $Ngay08 = null, string $Ngay09 = null, string $Ngay10 = null, string $Ngay11 = null, string $Ngay12 = null, string $Ngay13 = null, string $Ngay14 = null, string $Ngay15 = null, string $Ngay16 = null, string $Ngay17 = null, string $Ngay18 = null, string $Ngay19 = null, string $Ngay20 = null, string $Ngay21 = null, string $Ngay22 = null, string $Ngay23 = null, string $Ngay24 = null, string $Ngay25 = null, string $Ngay26 = null, string $Ngay27 = null, string $Ngay28 = null, string $Ngay29 = null, string $Ngay30 = null, string $Ngay31 = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNam' => $Nam,
            'pThang' => $Thang,
            'pId' => $Id,
            'pMa_cham_cong' => $Ma_cham_cong,
            'pMa_cvcm' => $Ma_cvcm,
            'pHe_so_luong' => $He_so_luong,
            'pTong_phu_cap' => $Tong_phu_cap,
            'pMuc_luong' => $Muc_luong,
            'pTong_luong' => $Tong_luong,
            'pNgay01' => $Ngay01,
            'pNgay02' => $Ngay02,
            'pNgay03' => $Ngay03,
            'pNgay04' => $Ngay04,
            'pNgay05' => $Ngay05,
            'pNgay06' => $Ngay06,
            'pNgay07' => $Ngay07,
            'pNgay08' => $Ngay08,
            'pNgay09' => $Ngay09,
            'pNgay10' => $Ngay10,
            'pNgay11' => $Ngay11,
            'pNgay12' => $Ngay12,
            'pNgay13' => $Ngay13,
            'pNgay14' => $Ngay14,
            'pNgay15' => $Ngay15,
            'pNgay16' => $Ngay16,
            'pNgay17' => $Ngay17,
            'pNgay18' => $Ngay18,
            'pNgay19' => $Ngay19,
            'pNgay20' => $Ngay20,
            'pNgay21' => $Ngay21,
            'pNgay22' => $Ngay22,
            'pNgay23' => $Ngay23,
            'pNgay24' => $Ngay24,
            'pNgay25' => $Ngay25,
            'pNgay26' => $Ngay26,
            'pNgay27' => $Ngay27,
            'pNgay28' => $Ngay28,
            'pNgay29' => $Ngay29,
            'pNgay30' => $Ngay30,
            'pNgay31' => $Ngay31,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
