<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:21
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsInTaoCaySPCT
{
    /**
     * Call stored procedure asInTaoCaySPCT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInTaoCaySPCT', [
            'pMa_cty' => $paramObj->pMa_cty ?? null,
            'pTblName' => $paramObj->pTblName ?? null,
            'pSumFList' => $paramObj->pSumFList ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInTaoCaySPCT with named parameters
     *
     * @param string $Ma_cty
     * @param string $TblName
     * @param string $SumFList
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $TblName = null, string $SumFList = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pTblName' => $TblName,
            'pSumFList' => $SumFList
        ];

        return self::call($params);
    }
}
