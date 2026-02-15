<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:16
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdUserRight
{
    /**
     * Call stored procedure asUpdUserRight
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdUserRight', [
            'pUserName' => $params['pUserName'] ?? null,
            'pUserName_Old' => $params['pUserName_Old'] ?? null,
            'pRet' => $params['pRet'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdUserRight with named parameters
     *
     * @param string $UserName
     * @param string $UserName_Old
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $UserName = null, string $UserName_Old = null, int $Ret = null): Collection
    {
        $params = [
            'pUserName' => $UserName,
            'pUserName_Old' => $UserName_Old,
            'pRet' => $Ret
        ];
        
        return self::call($params);
    }
}
