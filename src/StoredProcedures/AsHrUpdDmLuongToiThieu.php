<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:13
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrUpdDmLuongToiThieu
{
    /**
     * Call stored procedure asHrUpdDmLuongToiThieu
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrUpdDmLuongToiThieu', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay_ad' => $params['pNgay_ad'] ?? null,
            'pMuc_luong' => $params['pMuc_luong'] ?? null,
            'pKsd' => $params['pKsd'] ?? null,
            'pLuser' => $params['pLuser'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrUpdDmLuongToiThieu with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay_ad
     * @param float $Muc_luong
     * @param bool $Ksd
     * @param string $Luser
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay_ad = null, float $Muc_luong = null, bool $Ksd = null, string $Luser = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay_ad' => $Ngay_ad,
            'pMuc_luong' => $Muc_luong,
            'pKsd' => $Ksd,
            'pLuser' => $Luser,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
