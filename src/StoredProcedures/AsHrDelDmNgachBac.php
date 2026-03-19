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

class AsHrDelDmNgachBac
{
    /**
     * Call stored procedure asHrDelDmNgachBac
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asHrDelDmNgachBac', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pMa_tbl' => $paramObj->pMa_tbl ?? null,
            'pMa_nb' => $paramObj->pMa_nb ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asHrDelDmNgachBac with named parameters
     *
     * @param string $Ma_cty
     * @param string $Ma_tbl
     * @param string $Ma_nb
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $Ma_tbl = null, string $Ma_nb = null, int $Ret = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pMa_tbl' => $Ma_tbl,
            'pMa_nb' => $Ma_nb,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
