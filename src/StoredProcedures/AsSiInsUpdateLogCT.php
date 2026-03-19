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
use Diepxuan\Simba\Helper\ParamHelper;

class AsSiInsUpdateLogCT
{
    /**
     * Call stored procedure asSiInsUpdateLogCT
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiInsUpdateLogCT', [
            'pItem_id' => $paramObj->pItem_id ?? null,
            'pId' => $paramObj->pId ?? null,
            'pName' => $paramObj->pName ?? null,
            'pType' => $paramObj->pType ?? null,
            'pLast_modify' => $paramObj->pLast_modify ?? null,
            'pFullpath' => $paramObj->pFullpath ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSiInsUpdateLogCT with named parameters
     *
     * @param string $Item_id
     * @param int $Id
     * @param string $Name
     * @param int $Type
     * @param string $Last_modify
     * @param string $Fullpath
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $Item_id = null, int $Id = null, string $Name = null, int $Type = null, string $Last_modify = null, string $Fullpath = null, int $Ret = null): Collection
    {
        $params = [
            'pItem_id' => $Item_id,
            'pId' => $Id,
            'pName' => $Name,
            'pType' => $Type,
            'pLast_modify' => $Last_modify,
            'pFullpath' => $Fullpath,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
