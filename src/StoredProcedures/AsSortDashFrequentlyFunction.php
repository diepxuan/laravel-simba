<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-12 00:00:00
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;
use Diepxuan\Simba\Helper\ParamHelper;

class AsSortDashFrequentlyFunction
{
    public static function call(array $params): Collection
    {
        $paramObj = ParamHelper::fromArray($params);
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSortDashFrequentlyFunction', [
            'pMenuIdSource'  => $paramObj->pMenuIdSource ?? null,
            'pSttTarget'  => $paramObj->pSttTarget ?? null,
            'pUserName'  => $paramObj->pUserName ?? null,
            'pDashID'  => $paramObj->pDashID ?? null,
            'pRet'  => $paramObj->pRet ?? null,
        ], $connection);
    }
}
