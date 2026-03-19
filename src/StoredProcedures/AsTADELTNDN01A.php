<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:01
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsTADELTNDN01A
{
    /**
     * Call stored procedure asTADELTNDN01A
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asTADELTNDN01A', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pmau' => $paramObj->pmau ?? null,
            'pma_so' => $paramObj->pma_so ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asTADELTNDN01A with named parameters
     *
     * @param string $Ma_cty
     * @param string $mau
     * @param string $ma_so
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $mau = null, string $ma_so = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pmau' => $mau,
            'pma_so' => $ma_so
        ];

        return self::call($params);
    }
}
