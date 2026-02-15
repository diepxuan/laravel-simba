<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:58
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsdaoinfo
{
    /**
     * Call stored procedure asInsdaoinfo
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsdaoinfo', [
            'pTable_name' => $params['pTable_name'] ?? null,
            'pGet_sp' => $params['pGet_sp'] ?? null,
            'pIns_sp' => $params['pIns_sp'] ?? null,
            'pUpd_sp' => $params['pUpd_sp'] ?? null,
            'pDel_sp' => $params['pDel_sp'] ?? null,
            'pSch_sp' => $params['pSch_sp'] ?? null,
            'pChg_sp' => $params['pChg_sp'] ?? null,
            'pDescription' => $params['pDescription'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsdaoinfo with named parameters
     *
     * @param string $Table_name
     * @param string $Get_sp
     * @param string $Ins_sp
     * @param string $Upd_sp
     * @param string $Del_sp
     * @param string $Sch_sp
     * @param string $Chg_sp
     * @param string $Description
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Table_name = null, string $Get_sp = null, string $Ins_sp = null, string $Upd_sp = null, string $Del_sp = null, string $Sch_sp = null, string $Chg_sp = null, string $Description = null, int $Ret = null): Collection
    {
        $params = [
            'pTable_name' => $Table_name,
            'pGet_sp' => $Get_sp,
            'pIns_sp' => $Ins_sp,
            'pUpd_sp' => $Upd_sp,
            'pDel_sp' => $Del_sp,
            'pSch_sp' => $Sch_sp,
            'pChg_sp' => $Chg_sp,
            'pDescription' => $Description,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
