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

class AsSortDashFrequentlyFunction
{
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asSortDashFrequentlyFunction', [
            'pMenuIdSource'  => $params['pMenuIdSource'] ?? null,
            'pSttTarget'  => $params['pSttTarget'] ?? null,
            'pUserName'  => $params['pUserName'] ?? null,
            'pDashID'  => $params['pDashID'] ?? null,
            'pRet'  => $params['pRet'] ?? null,
        ], $connection);
    }
}
