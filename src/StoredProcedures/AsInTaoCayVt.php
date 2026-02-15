<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:59
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInTaoCayVt
{
    /**
     * Call stored procedure asInTaoCayVt
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInTaoCayVt', [
            'pMa_cty' => $params['pMa_cty'] ?? null,
            'pTblName' => $params['pTblName'] ?? null,
            'pSumFList' => $params['pSumFList'] ?? null,
            'pSysMsg1' => $params['pSysMsg1'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInTaoCayVt with named parameters
     *
     * @param string $Ma_cty
     * @param string $TblName
     * @param string $SumFList
     * @param string $SysMsg1
     * @return Collection
     */
    public static function callWithParams(string $Ma_cty = null, string $TblName = null, string $SumFList = null, string $SysMsg1 = null): Collection
    {
        $params = [
            'pMa_cty' => $Ma_cty,
            'pTblName' => $TblName,
            'pSumFList' => $SumFList,
            'pSysMsg1' => $SysMsg1
        ];
        
        return self::call($params);
    }
}
