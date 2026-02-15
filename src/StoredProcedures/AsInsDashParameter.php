<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:54
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsDashParameter
{
    /**
     * Call stored procedure asInsDashParameter
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsDashParameter', [
            'pDashID' => $params['pDashID'] ?? null,
            'pUsername' => $params['pUsername'] ?? null,
            'pStt' => $params['pStt'] ?? null,
            'pParaname' => $params['pParaname'] ?? null,
            'pParavalue' => $params['pParavalue'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsDashParameter with named parameters
     *
     * @param int $DashID
     * @param string $Username
     * @param int $Stt
     * @param string $Paraname
     * @param string $Paravalue
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(int $DashID = null, string $Username = null, int $Stt = null, string $Paraname = null, string $Paravalue = null, int $Ret = null): Collection
    {
        $params = [
            'pDashID' => $DashID,
            'pUsername' => $Username,
            'pStt' => $Stt,
            'pParaname' => $Paraname,
            'pParavalue' => $Paravalue,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
