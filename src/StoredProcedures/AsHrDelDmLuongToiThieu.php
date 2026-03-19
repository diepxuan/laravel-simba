<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:04
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrDelDmLuongToiThieu
{
    /**
     * Call stored procedure asHrDelDmLuongToiThieu
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrDelDmLuongToiThieu', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pNgay_ad' => $paramObj->pNgay_ad ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrDelDmLuongToiThieu with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ngay_ad
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ngay_ad = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pNgay_ad' => $Ngay_ad,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
