<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:57
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdGroupRight
{
    /**
     * Call stored procedure asUpdGroupRight
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdGroupRight', [
            'pGroupName' => $params['pGroupName'] ?? null,
            'pGroupName_Old' => $params['pGroupName_Old'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdGroupRight with named parameters
     *
     * @param string $GroupName
     * @param string $GroupName_Old
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $GroupName = null, string $GroupName_Old = null, int $Ret = null): Collection
    {
        $params = [
            'pGroupName' => $GroupName,
            'pGroupName_Old' => $GroupName_Old,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
