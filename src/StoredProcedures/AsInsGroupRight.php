<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:19:24
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsInsGroupRight
{
    /**
     * Call stored procedure asInsGroupRight
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asInsGroupRight', $params, $connection);
    }

    /**
     * Call stored procedure asInsGroupRight with named parameters
     *
     * @param string $GroupName
     * @param string $MenuID
     * @param string $ViewRight
     * @param string $InsertRight
     * @param string $UpdateRight
     * @param string $DeleteRight
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $GroupName = null, string $MenuID = null, string $ViewRight = null, string $InsertRight = null, string $UpdateRight = null, string $DeleteRight = null, int $Ret = null): Collection
    {
        $params = [
            'pGroupName' => $GroupName,
            'pMenuID' => $MenuID,
            'pViewRight' => $ViewRight,
            'pInsertRight' => $InsertRight,
            'pUpdateRight' => $UpdateRight,
            'pDeleteRight' => $DeleteRight,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
