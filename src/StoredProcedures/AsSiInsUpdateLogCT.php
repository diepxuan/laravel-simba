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
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSiInsUpdateLogCT', [
            'pItem_id' => $params['pItem_id'] ?? null,
            'pId' => $params['pId'] ?? null,
            'pName' => $params['pName'] ?? null,
            'pType' => $params['pType'] ?? null,
            'pLast_modify' => $params['pLast_modify'] ?? null,
            'pFullpath' => $params['pFullpath'] ?? null,
            'pRet' => $params['pRet'] ?? null
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
