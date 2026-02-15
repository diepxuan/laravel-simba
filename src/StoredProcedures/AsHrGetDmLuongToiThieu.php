<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsHrGetDmLuongToiThieu
{
    /**
     * Call stored procedure asHrGetDmLuongToiThieu
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetDmLuongToiThieu', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pNgay_ad' => $params['pNgay_ad'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetDmLuongToiThieu with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay_ad
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay_ad = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay_ad' => $Ngay_ad
        ];
        
        return self::call($params);
    }
}
