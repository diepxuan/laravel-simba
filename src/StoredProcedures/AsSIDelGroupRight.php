<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:42
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSIDelGroupRight
{
    /**
     * Call stored procedure asSIDelGroupRight
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSIDelGroupRight', [
            'pGroupName' => $paramObj->pGroupName ?? null,
            'pMenuID' => $paramObj->pMenuID ?? null,
            'pRet' => $paramObj->pRet ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asSIDelGroupRight with named parameters
     *
     * @param string $GroupName
     * @param string $MenuID
     * @param int $Ret
     * @return Collection
     */
    public static function callWithParams(string $GroupName = null, string $MenuID = null, int $Ret = null): Collection
    {
        $params = [
            'pGroupName' => $GroupName,
            'pMenuID' => $MenuID,
            'pRet' => $Ret
        ];

        return self::call($params);
    }
}
