<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:15
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrInsDmLuongToiThieu
{
    /**
     * Call stored procedure asHrInsDmLuongToiThieu
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrInsDmLuongToiThieu', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay_ad' => $paramObj->pNgay_ad ?? null,
            'pMuc_luong' => $paramObj->pMuc_luong ?? null,
            'pKsd' => $paramObj->pKsd ?? null,
            'pCuser' => $paramObj->pCuser ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrInsDmLuongToiThieu with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay_ad
     * @param float $Muc_luong
     * @param bool $Ksd
     * @param string $Cuser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay_ad = null, float $Muc_luong = null, bool $Ksd = null, string $Cuser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay_ad' => $Ngay_ad,
            'pMuc_luong' => $Muc_luong,
            'pKsd' => $Ksd,
            'pCuser' => $Cuser,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
