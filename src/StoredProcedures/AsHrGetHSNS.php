<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:41
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsHrGetHSNS
{
    /**
     * Call stored procedure asHrGetHSNS
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrGetHSNS', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pId' => $paramObj->pId ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrGetHSNS with named parameters
     *
     * @param string $Ma_cty
     * @param string $Id
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Id = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pId' => $Id
        ];

        return self::call($params);
    }
}
