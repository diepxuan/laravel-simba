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

class AsSiInsUpdateLogBk
{
    /**
     * Call stored procedure asSiInsUpdateLogBk
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiInsUpdateLogBk', [
            'pID' => $paramObj->pID ?? null,
            'pRet' => $paramObj->pRet ?? null,
            'pName' => $paramObj->pName ?? null,
            'pType' => $paramObj->pType ?? null,
            'pLast_Modify' => $paramObj->pLast_Modify ?? null,
            'pFullPath' => $paramObj->pFullPath ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiInsUpdateLogBk with named parameters
     *
     * @param int $ID
     * @param int $Ret
     * @param string $Name
     * @param string $Type
     * @param string $Last_Modify
     * @param string $FullPath
     * @return Collection
     */
    public static function callWithParams(int $ID = null, int $Ret = null, string $Name = null, string $Type = null, string $Last_Modify = null, string $FullPath = null): Collection
    {
        $params = [
            'pID' => $ID,
            'pRet' => $Ret,
            'pName' => $Name,
            'pType' => $Type,
            'pLast_Modify' => $Last_Modify,
            'pFullPath' => $FullPath
        ];

        return self::call($params);
    }
}
