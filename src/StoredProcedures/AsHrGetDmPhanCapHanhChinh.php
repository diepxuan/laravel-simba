<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:49
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrGetDmPhanCapHanhChinh
{
    /**
     * Call stored procedure asHrGetDmPhanCapHanhChinh
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetDmPhanCapHanhChinh', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_pchc' => $paramObj->pMa_pchc ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetDmPhanCapHanhChinh with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_pchc
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_pchc = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_pchc' => $Ma_pchc
        ];

        return self::call($params);
    }
}
