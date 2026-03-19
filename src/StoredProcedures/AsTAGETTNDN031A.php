<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:44
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsTAGETTNDN031A
{
    /**
     * Call stored procedure asTAGETTNDN031A
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asTAGETTNDN031A', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pmau' => $paramObj->pmau ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asTAGETTNDN031A with named parameters
     *
     * @param string $Ma_cty
     * @param string $mau
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $mau = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pmau' => $mau
        ];

        return self::call($params);
    }
}
