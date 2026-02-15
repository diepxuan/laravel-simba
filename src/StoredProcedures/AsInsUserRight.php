<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:37:19
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsUserRight
{
    /**
     * Call stored procedure asInsUserRight
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsUserRight', [
            'pUserName' => $params['pUserName'] ?? null,
            'pMenuID' => $params['pMenuID'] ?? null,
            'pViewRight' => $params['pViewRight'] ?? null,
            'pInsertRight' => $params['pInsertRight'] ?? null,
            'pUpdateRight' => $params['pUpdateRight'] ?? null,
            'pDeleteRight' => $params['pDeleteRight'] ?? null,
            'pLimitedPrint' => $params['pLimitedPrint'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asInsUserRight with named parameters
     *
     * @param string $UserName
     * @param string $MenuID
     * @param string $ViewRight
     * @param string $InsertRight
     * @param string $UpdateRight
     * @param string $DeleteRight
     * @param int $LimitedPrint
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $UserName = null, string $MenuID = null, string $ViewRight = null, string $InsertRight = null, string $UpdateRight = null, string $DeleteRight = null, int $LimitedPrint = null, int $Ret = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pMenuID' => $MenuID,
            'pViewRight' => $ViewRight,
            'pInsertRight' => $InsertRight,
            'pUpdateRight' => $UpdateRight,
            'pDeleteRight' => $DeleteRight,
            'pLimitedPrint' => $LimitedPrint,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
